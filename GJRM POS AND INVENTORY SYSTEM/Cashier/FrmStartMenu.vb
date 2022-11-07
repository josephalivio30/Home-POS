Public Class FrmStartMenu
    Dim sdate As String = Now.ToString("MM-dd-yyyy")

    Private Sub FrmStartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub Display()
        SumOfAll()

        txtTimeStart.Text = timein
        txtTimeClose.Text = timeout
        txtStartingCash.Text = Format(CDbl(startAmount), "#,#0.00")
        txtCashier.Text = str_name
        txtSales.Text = Format(CDbl(sales), "#,#0.00")
        txtExpense.Text = Format(CDbl(expense), "#,#0.00")
        txtDiscount.Text = Format(CDbl(discount), "#,#0.00")
        txtRefund.Text = Format(CDbl(refund), "#,#0.00")
        txtDebt.Text = Format(CDbl(debt), "#,#0.00")
        txtNet.Text = Format(CDbl((sales) - (expense + discount + refund + debt)), "#,#0.00")

        If CheckTransaction() = True Then
            btnStart.Enabled = False
            txtStartingCash.Enabled = False
        Else
            txtStartingCash.Enabled = True
        End If
        If CheckDay() = False Then
            btnPrint.Enabled = False
        End If
        If CheckStatus() = False Then
            'txtStartingCash.Enabled = False
        End If
        If txtTimeClose.Text = String.Empty Then
            btnPrint.Enabled = False
        Else
            btnPrint.Enabled = True
        End If
    End Sub
    Sub EndDay()
        Try
            If CheckDay() = False Then
                MsgBox("Start the day by inputing starting amount in start menu", vbExclamation)
                Return
            End If
            If CheckStatus() = True Then

                If MsgBox("Do you want to close the transaction?", vbYesNo + vbQuestion) = vbYes Then

                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblstart set timeout = @timeout where id like '" & startid & "'and cuser like '" & str_user & "'", cn)
                    cm.Parameters.AddWithValue("@timeout", Now.ToShortTimeString)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblstart set status = 'close' where id like '" & startid & "'and cuser like '" & str_user & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    txtTimeClose.Text = Now.ToShortTimeString
                    AuditTrail("Ended the transaction")
                    MsgBox("Sales Transaction has been successfully closed!", vbInformation)

                    btnEnd.Enabled = False
                    btnPrint.Enabled = True
                    With FrmPOS
                        .btnNewOrder.Enabled = False
                        .btnSettle.Enabled = False
                        .btnApplyDiscount.Enabled = False
                        .btnExpense.Enabled = False
                        .btnDebtPayment.Enabled = False
                    End With
                End If
            Else
                MsgBox("Transaction is already close!", vbExclamation)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub StartDay()
        Try
            cn.Open()
            cm = New OleDb.OleDbCommand("select count(*) from tblstart where sdate between #" & sdate & "# and #" & sdate & "# and status like 'close' and cuser like '" & str_user & "'", cn)
            Dim count As Integer = CInt(cm.ExecuteScalar)
            cn.Close()

            If count = 0 Then
                If txtStartingCash.Text = String.Empty Then
                    MsgBox("Please input the initial Cash", vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblstart(sdate,initialcash,cuser,timein)values(@sdate,@initialcash,@cuser,@timein)", cn)
                With cm
                    .Parameters.AddWithValue("sdate", CDate(Now.ToShortDateString))
                    .Parameters.AddWithValue("initialcash", CDbl(txtStartingCash.Text))
                    .Parameters.AddWithValue("cuser", str_user)
                    .Parameters.AddWithValue("timein", Now.ToShortTimeString)
                    .ExecuteNonQuery()
                End With
                cn.Close()

                txtStartingCash.Text = Format(CDbl(txtStartingCash.Text), "#,#0.00")
                txtStartingCash.Enabled = False
                txtTimeStart.Text = Now.ToShortTimeString
                btnStart.Enabled = False

                AuditTrail("Starting cash amount of " & txtStartingCash.Text)

                With FrmPOS
                    If CheckStatus() = True Then
                        .btnNewOrder.Enabled = True
                        .btnExpense.Enabled = True
                        .btnDebtPayment.Enabled = True
                    Else
                        btnStart.Enabled = True
                        btnEnd.Enabled = False
                    End If
                End With
            Else
                MsgBox("Transaction is already close!", vbExclamation)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartDay()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        EndDay()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With FrmPrintTodaySales
            .LoadTodaySales()
            .ShowDialog()
        End With
    End Sub

    Private Sub FrmStartMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            If btnStart.Enabled = False Then
                Return
            Else
                btnStart_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class