Public Class FrmCancelOrder
    Dim _total As Double
    Sub save()
        Try
            If rbYes.Checked = False And rbNo.Checked = False Then
                MsgBox("Please make a selection.", vbExclamation)
                Return
            End If
            If txtCQty.Text = String.Empty Or txtReason.Text = String.Empty Then
                MsgBox("All fields are required.", vbExclamation)
                Return
            End If
            If CDbl(txtSQty.Text) >= CDbl(txtCQty.Text) Then
                If str_role = "Administrator" Then
                    If MsgBox("Cancel this item?", vbYesNo + vbQuestion) = vbYes Then
                        cn.Open()
                        cm = New OleDb.OleDbCommand("insert into tblcancelorder(transno, pcode, price, qty, discount, total, sdate, stime, voidby, cancelledby, reason,saction)values(@transno, @pcode, @price, @qty, @discount, @total, @sdate, @stime, @voidby, @cancelledby, @reason,saction)", cn)
                        With cm.Parameters
                            .AddWithValue("@transno", txtTransno.Text)
                            .AddWithValue("@pcode", txtPcode.Text)
                            .AddWithValue("@price", CDbl(txtPrice.Text))
                            .AddWithValue("@qty", CDbl(txtCQty.Text))
                            .AddWithValue("@discount", CDbl(txtDiscount.Text))
                            .AddWithValue("@total", CDbl(txtCQty.Text) * CDbl(txtPrice.Text) - CDbl(txtDiscount.Text))
                            .AddWithValue("@sdate", Now.ToShortDateString)
                            .AddWithValue("@stime", Now.ToShortTimeString)
                            .AddWithValue("@voidby", str_name)
                            .AddWithValue("@cancelledby", str_user)
                            .AddWithValue("@reason", txtReason.Text)

                            If rbYes.Checked = True Then
                                .AddWithValue("@saction", "Yes")
                            ElseIf rbNo.Checked = True Then
                                .AddWithValue("@saction", "No")
                            End If
                        End With
                        cm.ExecuteNonQuery()
                        cn.Close()
                        'update tblproduct add qty
                        If rbYes.Checked = True Then
                            UpdateData("update tblproduct set qty = qty + '" & CDbl(txtCQty.Text) & "' where pcode like '" & txtPcode.Text & "'")
                        End If
                        'update ,tblcart subtract qty
                        UpdateData("update tblcart set qty = qty - '" & CDbl(txtCQty.Text) & "', total = price * qty - discount where id like '" & txtID.Text & "'")

                        'select total in tblsales
                        cn.Open()
                        cm = New OleDb.OleDbCommand("select total from tblcart where ID like '" & txtID.Text & "' and transno like '" & txtTransno.Text & "'", cn)
                        dr = cm.ExecuteReader
                        While dr.Read
                            _total = dr.Item("total")
                        End While
                        cn.Close()
                        dr.Close()

                        'Update total and cash in tblsales 
                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblsales set total = total - '" & _total & "', totalbill = totalbill - '" & _total & "' - discount, cash = (banktransfer + gcash + cash) - '" & _total & "' - discount where transno like '" & txtTransno.Text & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        'Update total in tblsales 
                        UpdateData("update tblsales set banktransfer = 0, gcash = 0 where transno like '" & txtTransno.Text & "'")

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
                        AuditTrail("voided product name " & txtDesc.Text)
                    End If
                    Me.Dispose()
                    FrmDailySales.LoadSale()
                    FrmRSales.LoadSale()
                    FrmPOS.LoadProducts()
                Else
                    With FrmCancelAdminPass
                        .ShowDialog()
                    End With
                End If
            Else
                MsgBox("Please type the correct number.", vbExclamation)
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
        save()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtCQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub FrmCancelOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmCancelOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            save()
        End If
    End Sub
End Class