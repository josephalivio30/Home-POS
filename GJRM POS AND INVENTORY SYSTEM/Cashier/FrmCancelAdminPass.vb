Public Class FrmCancelAdminPass
    Dim pass As String
    Dim user As String
    Dim sql As String
    Dim _total As Double
    Sub Save()
        Try
            If txtPass.Text = String.Empty Then
                MsgBox("Required to input administrator password!", vbExclamation)
                Return
            End If
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser where cpassword = @cpassword and role = 'Administrator'", cn)
            cm.Parameters.AddWithValue("@cpassword", txtPass.Text)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                pass = dr.Item("cpassword")
                user = dr.Item("cname")
            End If
            dr.Close()
            cn.Close()

            If StrComp(txtPass.Text, pass, CompareMethod.Binary) Then
                MsgBox("Invalid administrator password", vbCritical)
            Else
                If MsgBox("Cancel this item?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("insert into tblcancelorder(transno, pcode, price, qty, discount, total, sdate, stime, voidby, cancelledby, reason,saction)values(@transno, @pcode, @price, @qty, @discount, @total, @sdate, @stime, @voidby, @cancelledby, @reason,saction)", cn)
                    With cm.Parameters
                        .AddWithValue("@transno", FrmCancelOrder.txtTransno.Text)
                        .AddWithValue("@pcode", FrmCancelOrder.txtPcode.Text)
                        .AddWithValue("@price", CDbl(FrmCancelOrder.txtPrice.Text))
                        .AddWithValue("@qty", CDbl(FrmCancelOrder.txtCQty.Text))
                        .AddWithValue("@discount", CDbl(FrmCancelOrder.txtDiscount.Text))
                        .AddWithValue("@total", CDbl(FrmCancelOrder.txtCQty.Text) * CDbl(FrmCancelOrder.txtPrice.Text) - CDbl(FrmCancelOrder.txtDiscount.Text))
                        .AddWithValue("@sdate", Now.ToShortDateString)
                        .AddWithValue("@stime", Now.ToShortTimeString)
                        .AddWithValue("@voidby", user)
                        .AddWithValue("@cancelledby", str_user)
                        .AddWithValue("@reason", FrmCancelOrder.txtReason.Text)

                        If FrmCancelOrder.rbYes.Checked = True Then
                            .AddWithValue("@saction", "Yes")
                        ElseIf FrmCancelOrder.rbNo.Checked = True Then
                            .AddWithValue("@saction", "No")
                        End If
                    End With
                    cm.ExecuteNonQuery()
                    cn.Close()
                    'update tblproduct add qty
                    If FrmCancelOrder.rbYes.Checked = True Then
                        UpdateData("update tblproduct set qty = qty + '" & CDbl(FrmCancelOrder.txtCQty.Text) & "' where pcode like '" & FrmCancelOrder.txtPcode.Text & "'")
                    End If
                    'update ,tblcart subtract qty
                    UpdateData("update tblcart set qty = qty - '" & CDbl(FrmCancelOrder.txtCQty.Text) & "', total = price * qty - discount where id like '" & FrmCancelOrder.txtID.Text & "'")

                    'select total in tblsales
                    cn.Open()
                    cm = New OleDb.OleDbCommand("select total from tblcart where ID like '" & FrmCancelOrder.txtID.Text & "' and transno like '" & FrmCancelOrder.txtTransno.Text & "'", cn)
                    dr = cm.ExecuteReader
                    While dr.Read
                        _total = dr.Item("total")
                    End While
                    cn.Close()
                    dr.Close()

                    'Update total and cash in tblsales 
                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblsales set total = total - '" & _total & "', totalbill = totalbill - '" & _total & "' - discount, cash = (banktransfer + gcash + cash) - '" & _total & "' - discount where transno like '" & FrmCancelOrder.txtTransno.Text & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    'Update total in tblsales 
                    UpdateData("update tblsales set banktransfer = 0, gcash = 0 where transno like '" & FrmCancelOrder.txtTransno.Text & "'")

                    'delete row in tblcart
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblcart where qty = 0", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    'delete row in tblcart
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblsales where totalbill = 0", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    MsgBox("Order transaction has been successfully cancelled.", vbInformation)
                    AuditTrail("voided product name " & FrmCancelOrder.txtDesc.Text)
                End If
                Me.Dispose()
                FrmCancelOrder.Dispose()
                FrmDailySales.LoadSale()
                FrmPOS.LoadProducts()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateData(ByVal sql As String)
        cn.Open()
        cm = New OleDb.OleDbCommand(sql, cn)
        cm.ExecuteNonQuery()
        cn.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub FrmCancelAdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        KeyPreview = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmCancelAdminPass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            Save()
        End If
    End Sub
End Class