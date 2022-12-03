Public Class FrmDebt
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        savedebt()


    End Sub
    Sub savedebt()
        Try
            If Now.Date = dtCollection.Value.ToShortDateString Then
                Return
            End If

            If txtName.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tblsales(cname, transno, sdate, stime, cashier, total, discount, totalbill)values(@cname, @transno, @sdate, @stime, @cashier, @total, @discount, @totalbill)", cn)
            With cm
                .Parameters.AddWithValue("@cname", txtName.Text)
                .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                .Parameters.AddWithValue("@cashier", str_user)
                .Parameters.AddWithValue("@total", CDbl(FrmPOS.lblTotalBill.Text))
                .Parameters.AddWithValue("@discount", CDbl(FrmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@totalbill", CDbl("" + txtAmount.Text))
                .ExecuteNonQuery()
            End With
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tbldebt(transno, cname, cuser, amount, stime, sdate, datetocollect)values(@transno, @cname, @cuser, @amount, @stime, @sdate, @datetocollect)", cn)
            With cm
                .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@cname", txtName.Text)
                .Parameters.AddWithValue("@cuser", str_user)
                .Parameters.AddWithValue("@amount", CDbl("" + FrmPOS.lblTotalBill.Text))
                .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                .Parameters.AddWithValue("@datetocollect", dtCollection.Value.ToShortDateString)
                .ExecuteNonQuery()
            End With
            cn.Close()

            'check customer if already have account
            If CheckCustomer("select cname from tblcustomer where cname like '" & txtName.Text & "'") = False Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcustomer(cname, datecreated)values(@cname, @datecreated)", cn)
                With cm
                    .Parameters.AddWithValue("@cname", "" + txtName.Text)
                    .Parameters.AddWithValue("@datecreated", Now.ToString("MM-dd-yyyy"))
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Created new account of the customer", vbInformation)
            End If

            'Updates the qty in the tblproduct
            For i = 0 To FrmPOS.dgvCart.Rows.Count - 1
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblproduct set qty = qty -'" & CInt(FrmPOS.dgvCart.Rows(i).Cells(5).Value.ToString) & "' where pcode like '" & (FrmPOS.dgvCart.Rows(i).Cells(2).Value.ToString) & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            Next

            cn.Open()
            cm = New OleDb.OleDbCommand("update tblcart set cname = '" & txtName.Text & "', status = 'Completed', remarks = 'Unpaid' where transno like '" & FrmPOS.lblTransNo.Text & "' and status like 'Pending'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("update tblsales set remarks = 'Unpaid' where transno like '" & FrmPOS.lblTransNo.Text & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            'If MsgBox("Do you want to print the receipt?", vbYesNo + vbQuestion) = vbYes Then
            '    Dim sql As String
            '    sql = "select * from ComputeTotal where transno like '" & FrmPOS.lblTransNo.Text & "'"
            '    With FrmReceiptDebt
            '        .PrintPreview(sql)
            '        .ShowDialog()
            '    End With
            'End If

            MsgBox("Debt successfully saved", vbInformation)
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
    Private Sub frmDebt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
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
    Private Sub frmDebt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            savedebt()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtAdjustment_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub dtCollection_ValueChanged(sender As Object, e As EventArgs) Handles dtCollection.ValueChanged

        If dtCollection.Value < Now.ToShortDateString Then
            dtCollection.Value = Now.ToShortDateString
            MsgBox("The date must be higher or equal to today date", vbExclamation)
        End If
    End Sub
    Private Sub txtTinNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class