Public Class FrmAdminPass
    Private sql As String
    Dim pass As String
    Private Sub FrmAdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        txtPass.PasswordChar = Chr(149)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
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
            End If
            dr.Close()
            cn.Close()

            If StrComp(txtPass.Text, pass, CompareMethod.Binary) Then
                MsgBox("Invalid administrator password", vbCritical)
            Else
                If MsgBox("Delete this account?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand(sql, cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    MsgBox("Account has been successfully deleted", vbInformation)
                    FrmAccount.LoadAccount()
                End If
                AuditTrail("Remove Account Name " & Name)
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub GetSql(ByVal sql As String, ByVal name As String)
        Me.sql = sql
        Me.Name = name
    End Sub

    Private Sub FrmAdminPass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            Save()
        End If
    End Sub
End Class