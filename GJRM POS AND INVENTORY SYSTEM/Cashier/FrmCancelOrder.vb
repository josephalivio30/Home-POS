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
                        cm = New OleDb.OleDbCommand("insert into tblcancelorder(cname, transno, pcode, price, qty, discount, total, sdate, stime, voidby, cancelledby, reason,saction, remarks)values(@cname, @transno, @pcode, @price, @qty, @discount, @total, @sdate, @stime, @voidby, @cancelledby, @reason, @saction, @remarks)", cn)
                        With cm.Parameters
                            .AddWithValue("@cname", txtName.Text)
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
                            .AddWithValue("@remarks", txtRemarks.Text)

                        End With
                        cm.ExecuteNonQuery()
                        cn.Close()

                        'update tblproduct add qty
                        If rbYes.Checked = True Then
                            UpdateData("update tblproduct set qty = qty + '" & CDbl(txtCQty.Text) & "' where pcode like '" & txtPcode.Text & "'")
                        End If
                        'update ,tblcart subtract qty
                        UpdateData("update tblcart set qty = qty - '" & CDbl(txtCQty.Text) & "', total = (price * qty) - discount where id like '" & txtID.Text & "'")

                        Dim qty As Double = CDbl(txtCQty.Text)
                        Dim price As Double = CDbl(txtPrice.Text)
                        _total = qty * price

                        'Update total and cash in tblsales 
                        UpdateData("update tblsales set total = total - '" & _total & "', totalbill = totalbill - '" & _total & "' where transno like '" & txtTransno.Text & "'")

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
                        cm = New OleDb.OleDbCommand("select * from tblsales where transno like '" & txtTransno.Text & "'", cn)
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
                            UpdateData("Update tblsales set cash = cash + '" & remain1 & "'where transno like '" & txtTransno.Text & "'")
                        Else
                            If remain1 < 0 Then
                                remain1 = 0
                            End If
                            UpdateData("Update tblsales set cash = '" & remain1 & "'where transno like '" & txtTransno.Text & "'")
                        End If
                        If remain2 = 0 Then
                            UpdateData("Update tblsales set gcash = gcash + '" & remain2 & "'where transno like '" & txtTransno.Text & "'")
                        Else
                            If remain2 < 0 Then
                                remain2 = 0
                            End If
                            UpdateData("Update tblsales set gcash = '" & remain2 & "'where transno like '" & txtTransno.Text & "'")
                        End If
                        If remain3 = 0 Then
                            UpdateData("Update tblsales set banktransfer = banktransfer + '" & remain3 & "'where transno like '" & txtTransno.Text & "'")
                        Else
                            If remain3 < 0 Then
                                remain3 = 0
                            End If
                            UpdateData("Update tblsales set banktransfer = '" & remain3 & "'where transno like '" & txtTransno.Text & "'")
                        End If
                        If remain4 = 0 Then
                            UpdateData("Update tblsales set cheque = cheque + '" & remain4 & "'where transno like '" & txtTransno.Text & "'")
                        Else
                            If remain4 < 0 Then
                                remain4 = 0
                            End If
                            UpdateData("Update tblsales set cheque = '" & remain4 & "'where transno like '" & txtTransno.Text & "'")
                        End If

                        'update total in tbldebt 
                        UpdateData("update tbldebt set amount = amount - '" & _total & "' where transno like '" & txtTransno.Text & "'")

                        UpdateData("update tbldebt set total = adjustment + amount where transno like '" & txtTransno.Text & "'")

                        'update total in tblcart
                        UpdateData("update tblcart set total = price * qty where transno like '" & txtTransno.Text & "' and pcode like '" & txtPcode.Text & "'")

                        'delete row in tblcart
                        UpdateData("delete from tblcart where qty = 0")

                        'delete row in tbldebt
                        UpdateData("delete from tbldebt where amount = 0 Or amount < 0")

                        'delete row in tblcart
                        UpdateData("delete from tblsales where totalbill = 0 Or totalbill < 0 Or total = 0 Or total < 0")

                        MsgBox("Order transaction has been successfully cancelled.", vbInformation)
                        AuditTrail("Cancelled " & txtCQty.Text & " qty of " & txtDesc.Text)
                    End If
                    FrmDailySales.LoadSale()
                    FrmRSales.LoadSale()
                    FrmPOS.LoadProducts()
                    Me.Dispose()

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