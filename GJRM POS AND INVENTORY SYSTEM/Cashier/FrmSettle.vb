Public Class FrmSettle
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub savepayment()
        Try
            Dim sdate As String = Now.ToString("MM-dd-yyyy")
            Dim stime As String = Now.ToString("hh:mm:ss")

            cn.Open()

            cm = New OleDb.OleDbCommand("insert into tblsales(cname,transno, sdate, stime, cashier, total, discount, totalbill, banktransfer, gcash, cheque, cash, schange)values(@cname, @transno, @sdate, @stime, @cashier, @total, @discount, @totalbill, @banktransfer, @gcash, @cheque, @cash, @schange)", cn)
            With cm
                .Parameters.AddWithValue("@cname", "" + txtName.Text)
                .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@sdate", sdate)
                .Parameters.AddWithValue("@stime", stime)
                .Parameters.AddWithValue("@cashier", "" + str_user)
                .Parameters.AddWithValue("@total", Format(CDbl(txtBill.Text) + CDbl(FrmPOS.lblDiscount.Text), "#,##0.00"))
                .Parameters.AddWithValue("@discount", CDbl(FrmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@totalbill", CDbl("" + txtBill.Text))
                .Parameters.AddWithValue("@banktransfer", CDbl("" + txtBankTransfer.Text))
                .Parameters.AddWithValue("@gcash", CDbl("" + txtGcash.Text))
                .Parameters.AddWithValue("@cheque", CDbl("" + txtCheque.Text))
                .Parameters.AddWithValue("@cash", CDbl("" + txtCash.Text))
                .Parameters.AddWithValue("@schange", CDbl("" + txtChange.Text))
                .ExecuteNonQuery()
            End With
            cn.Close()

            'Updates the status of the tblcart
            cn.Open()
            cm = New OleDb.OleDbCommand("update tblcart set status = 'Completed', remarks = 'Paid', cname = '" & txtName.Text & "', agent = '" & FrmPOS.cboAgent.Text & "' where transno like '" & FrmPOS.lblTransNo.Text & "' and status like 'Pending'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            'Updates the qty in the tblproduct
            For i = 0 To FrmPOS.dgvCart.Rows.Count - 1
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblproduct set qty = qty -'" & CInt(FrmPOS.dgvCart.Rows(i).Cells(5).Value.ToString) & "' where pcode like '" & (FrmPOS.dgvCart.Rows(i).Cells(2).Value.ToString) & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            Next

            cn.Open()
            cm = New OleDb.OleDbCommand("update tblsales set remarks = 'Paid' where transno like '" & FrmPOS.lblTransNo.Text & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            If MsgBox("Do you want to print bill", vbYesNo + vbQuestion) = vbYes Then
                Dim sql As String
                sql = "select * from ComputeTotal where transno like '" & FrmPOS.lblTransNo.Text & "'"
                With frmPrintReceipt1
                    .PrintPreview(Sql)
                    .ShowDialog()
                End With
            End If

            MsgBox("Payment successfully saved", vbInformation)

            With FrmPOS
                .lblTransNo.Text = .GetTransno
                .LoadCart()
                .LoadProducts()
            End With

            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            If txtCash.Text = String.Empty Then
                txtCash.Text = "0.00"
            End If
            If txtGcash.Text = String.Empty Then
                txtGcash.Text = "0.00"
            End If
            If txtBankTransfer.Text = String.Empty Then
                txtBankTransfer.Text = "0.00"
            End If
            If txtCheque.Text = String.Empty Then
                txtCheque.Text = "0.00"
            End If
            If txtName.Text = String.Empty Then
                txtName.Text = "noname"
            End If
            Dim total As Double = CDbl(txtBill.Text)
            Dim change As Double = (CDbl(txtGcash.Text) + CDbl(txtCash.Text) + CDbl(txtBankTransfer.Text) + CDbl(txtCheque.Text)) - total
            If change < 0 Then
                MsgBox("Insufficient Cash! Plase enter correct amount.", vbExclamation)
                Return
                'Else
                '    If MsgBox("Do you want to print bill", vbYesNo + vbQuestion) = vbYes Then
                '        PrintReceipt()
                '    End If
            End If
            savepayment()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub FrmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub FrmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            btnAccept_Click(sender, e)
        End If
    End Sub
    Private Sub txtBankTransfer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGcash.KeyPress, txtCash.KeyPress, txtBankTransfer.KeyPress, txtCheque.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
    Sub calculateMoney()
        Dim totalmoney As Double = Val(txtGcash.Text) + Val(txtCash.Text) + Val(txtBankTransfer.Text) + Val(txtCheque.Text)
        Dim bill As Double = CDbl("0" + txtBill.Text)
        Dim change As Double = totalmoney - bill
        Try
            If change < 0 Then
                txtChange.Text = Format(change, "#,##0.00")
            Else
                txtChange.Text = Format(change, "#,##0.00")
            End If
        Catch ex As Exception
            txtChange.Text = Format(change, "#,##0.00")
        End Try
    End Sub
    Private Sub txtGcash_TextChanged(sender As Object, e As EventArgs) Handles txtGcash.TextChanged, txtCash.TextChanged, txtBankTransfer.TextChanged, txtCheque.TextChanged
        calculateMoney()
    End Sub
End Class