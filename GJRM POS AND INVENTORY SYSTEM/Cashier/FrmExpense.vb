Public Class FrmExpense
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub save()
        Try
            If txtAmount.Text = String.Empty Or txtExpense.Text = String.Empty Or txtReceiver.Text = String.Empty Then
                MsgBox("Please enter missing field/s.", vbCritical)
                Return
            End If

            Dim sdate As String = Now.ToString("MM-dd-yyyy")
            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tblexpense(expense,cuser,receiver,amount,stime,sdate)values(@expense,@user,@receiver,@amount,@stime,@sdate)", cn)
            cm.Parameters.AddWithValue("expense", txtExpense.Text)
            cm.Parameters.AddWithValue("cuser", str_user)
            cm.Parameters.AddWithValue("receiver", txtReceiver.Text)
            cm.Parameters.AddWithValue("amount", CDbl(txtAmount.Text))
            cm.Parameters.AddWithValue("stime", Now.ToLongTimeString)
            cm.Parameters.AddWithValue("sdate", sdate)
            cm.ExecuteNonQuery()
            cn.Close()

            txtExpense.Focus()
            MsgBox("Expense has been successfully saved", vbInformation)
            AuditTrail("Expense amount of " & CDbl(txtAmount.Text))
            Clear()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Clear()
        txtExpense.Clear()
        txtReceiver.Clear()
        txtAmount.Clear()
    End Sub
    Private Sub FrmExpense_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub FrmExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub
End Class