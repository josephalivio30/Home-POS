Public Class FrmCancelAdminPass
    Dim pass As String
    Dim user As String
    Dim sql As String
    Dim _total As Double
    Sub Save()
        Try
            If CheckClose() = True Then
                MsgBox("Transaction is already close", vbExclamation)
                Return
            End If
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
                    UpdateData("update tblcart set qty = qty - '" & CDbl(FrmCancelOrder.txtCQty.Text) & "', total = (price * qty) - discount where id like '" & FrmCancelOrder.txtID.Text & "'")

                    Dim qty As Double = CDbl(FrmCancelOrder.txtCQty.Text)
                    Dim price As Double = CDbl(FrmCancelOrder.txtPrice.Text)
                    _total = qty * price

                    'Update total and cash in tblsales 
                    UpdateData("update tblsales set total = total - '" & _total & "', totalbill = totalbill - '" & _total & "' where transno like '" & FrmCancelOrder.txtTransno.Text & "'")

                    'Select Case total In tblsales
                    Dim remain1 As Double = 0
                    Dim remain2 As Double = 0
                    Dim remain3 As Double = 0
                    Dim remain4 As Double = 0
                    Dim cash As Double
                    Dim gcash As Double
                    Dim bt As Double
                    Dim cheque As Double
                    cn.Open()
                    cm = New OleDb.OleDbCommand("select * from tblsales where transno like '" & FrmCancelOrder.txtTransno.Text & "'", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        cash = CDbl(dr.Item("cash").ToString)
                        gcash = CDbl(dr.Item("gcash").ToString)
                        bt = CDbl(dr.Item("banktransfer").ToString)
                        cheque = CDbl(dr.Item("cheque").ToString)
                        If _total > 0 Then
                            remain1 = cash - _total
                        End If
                        If remain1 < 0 Then
                            remain2 = gcash + remain1
                        End If
                        If remain2 < 0 Then
                            remain3 = bt + remain2
                        End If
                        If remain3 < 0 Then
                            remain4 = cheque + remain3
                        End If
                    End If
                    cn.Close()
                    If remain1 = 0 Then
                        UpdateData("Update tblsales set cash = cash + '" & remain1 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    Else
                        If remain1 < 0 Then
                            remain1 = 0
                        End If
                        UpdateData("Update tblsales set cash = '" & remain1 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    End If
                    If remain2 = 0 Then
                        UpdateData("Update tblsales set gcash = gcash + '" & remain2 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    Else
                        If remain2 < 0 Then
                            remain2 = 0
                        End If
                        UpdateData("Update tblsales set gcash = '" & remain2 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    End If
                    If remain3 = 0 Then
                        UpdateData("Update tblsales set banktransfer = banktransfer + '" & remain3 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    Else
                        If remain3 < 0 Then
                            remain3 = 0
                        End If
                        UpdateData("Update tblsales set banktransfer = '" & remain3 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    End If
                    If remain4 = 0 Then
                        UpdateData("Update tblsales set cheque = cheque + '" & remain4 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    Else
                        If remain4 < 0 Then
                            remain4 = 0
                        End If
                        UpdateData("Update tblsales set cheque = '" & remain4 & "'where transno like '" & FrmCancelOrder.txtTransno.Text & "'")
                    End If

                    'update total in tbldebt
                    UpdateData("update tbldebt set amount = amount - '" & _total & "' where transno like '" & FrmCancelOrder.txtTransno.Text & "'")

                    'update total in tblcart
                    UpdateData("update tblcart set total = price * qty where transno like '" & FrmCancelOrder.txtTransno.Text & "' and pcode like '" & FrmCancelOrder.txtPcode.Text & "'")

                    'delete row in tblcart
                    UpdateData("delete from tblcart where qty = 0")

                    'delete row in tbldebt
                    UpdateData("delete from tbldebt where amount = 0")

                    'delete row in tblcart
                    UpdateData("delete from tblsales where totalbill = 0")

                    MsgBox("Order transaction has been successfully cancelled.", vbInformation)
                    AuditTrail("cancelled product name " & FrmCancelOrder.txtDesc.Text)
                End If
                Me.Dispose()
                FrmCancelOrder.Dispose()
                FrmDailySales.LoadSale()
                FrmPOS.LoadProducts()
                FrmDailySales.LoadCancelOrder()
                FrmDailySales.LoadDebt()
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