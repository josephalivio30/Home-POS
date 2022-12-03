Public Class FrmSettle
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub savepayment()
        Try
            Dim sdate As String = Now.ToString("MM-dd-yyyy")
            Dim stime As String = Now.ToString("hh:mm:ss")
            If CDbl(txtGcash.Text) > CDbl(txtBill.Text) Then
                MsgBox("Gcash must not be higher than the bill.", vbExclamation)
                Return
            ElseIf CDbl(txtBankTransfer.Text) > CDbl(txtBill.Text) Then
                MsgBox("Banktransfer must not be higher than the bill.", vbExclamation)
                Return
            End If
            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tblsales(cname, transno, sdate, stime, cashier, total, discount, totalbill, banktransfer, gcash, cash, schange)values(@cname, @transno, @sdate, @stime, @cashier, @total, @discount, @totalbill, @banktransfer, @gcash, @cash, @schange)", cn)
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
                .Parameters.AddWithValue("@cash", CDbl("" + txtCash.Text) - CDbl(txtChange.Text))
                .Parameters.AddWithValue("@schange", CDbl("" + txtChange.Text))
                .ExecuteNonQuery()
            End With
            cn.Close()

            'check customer if already have account
            If CheckCustomer("select cname from tblcustomer where cname like '" & txtName.Text & "'") = False Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcustomer(cname, datecreated)values(@cname, @datecreated)", cn)
                With cm
                    .Parameters.AddWithValue("@cname", "" + txtName.Text)
                    .Parameters.AddWithValue("@datecreated", sdate)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Created new account of the customer", vbInformation)
            End If

            'Updates the status of the tblcart
            cn.Open()
            cm = New OleDb.OleDbCommand("update tblcart set status = 'Completed', remarks = 'Paid', cname = '" & txtName.Text & "' where transno like '" & FrmPOS.lblTransNo.Text & "' and status like 'Pending'", cn)
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

            'If MsgBox("Do you want to print bill", vbYesNo + vbQuestion) = vbYes Then
            '    Dim sql As String
            '    sql = "select * from ComputeTotal where transno like '" & FrmPOS.lblTransNo.Text & "'"
            '    With FrmReceiptPaid
            '        .PrintPreview(sql)
            '        .ShowDialog()
            '    End With
            'End If

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
            If CDbl(txtCash.Text) + CDbl(txtGcash.Text) + CDbl(txtBankTransfer.Text) = 0 Then
                Return
            End If
            If txtCash.Text = String.Empty Then
                txtCash.Text = "0.00"
            End If
            If txtGcash.Text = String.Empty Then
                txtGcash.Text = "0.00"
            End If
            If txtBankTransfer.Text = String.Empty Then
                txtBankTransfer.Text = "0.00"
            End If
            If txtName.Text = String.Empty Then
                txtName.Text = "noname"
            End If
            Dim total As Double = CDbl(txtBill.Text)
            Dim change As Double = (CDbl(txtGcash.Text) + CDbl(txtCash.Text) + CDbl(txtBankTransfer.Text)) - total
            If change < 0 Then
                MsgBox("Insufficient Cash! Plase enter correct amount.", vbExclamation)
                Return
            End If
            savepayment()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub FrmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AutoComplete()
    End Sub
    Sub AutoComplete()
        Try
            Dim sql As String = "select distinct cname from tblcustomer"
            cm = New OleDb.OleDbCommand(sql, cn)
            da = New OleDb.OleDbDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("cname").ToString())
            Next
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtName.AutoCompleteCustomSource = col
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub FrmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            btnAccept_Click(sender, e)
        End If
    End Sub
    Private Sub txtBankTransfer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGcash.KeyPress, txtCash.KeyPress, txtBankTransfer.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
    Sub calculateMoney()
        Dim totalmoney As Double = Val(txtGcash.Text) + Val(txtCash.Text) + Val(txtBankTransfer.Text)
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
    Private Sub txtGcash_TextChanged(sender As Object, e As EventArgs) Handles txtGcash.TextChanged, txtCash.TextChanged, txtBankTransfer.TextChanged
        calculateMoney()
    End Sub
End Class