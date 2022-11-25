Public Class FrmAgent
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub Save()
        Try
            If txtAgent.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If
            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblagent(agent,address, contact, email)values(@agent,@address, @contact, @email)", cn)
                With cm.Parameters
                    .AddWithValue("@agent", txtAgent.Text)
                    .AddWithValue("@address", txtAddress.Text)
                    .AddWithValue("@contact", txtNo.Text)
                    .AddWithValue("@email", txtEmail.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved", vbInformation)
                AuditTrail("Added agent name " & txtAgent.Text)
                With FrmAgentList
                    .LoadAgent()
                End With
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateAgent()
        Try
            If txtAgent.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If
            If MsgBox("Update this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblagent set agent = @agent ,address = @address , contact = @contact, email = @email where ID like '" & lblID.Text & "'", cn)
                With cm.Parameters
                    .AddWithValue("@agent", txtAgent.Text)
                    .AddWithValue("@address", txtAddress.Text)
                    .AddWithValue("@contact", txtNo.Text)
                    .AddWithValue("@email", txtEmail.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated", vbInformation)
                AuditTrail("updated agent name " & txtAgent.Text)
                With FrmAgentList
                    .LoadAgent()
                End With
                Clear()
            End If
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Clear()
        txtAgent.Clear()
        txtAddress.Clear()
        txtNo.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateAgent()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub


    Private Sub txtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub FrmAgent_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            If btnSave.Enabled = False Then
                Return
            Else
                Save()
            End If
        End If
    End Sub
End Class