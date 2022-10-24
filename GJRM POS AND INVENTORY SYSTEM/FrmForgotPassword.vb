Public Class FrmForgotPassword
    Dim code As String
    Private Sub FrmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Left = (Panel1.Width - Panel2.Width) / 2
        KeyPreview = True
        txtCNewPass.PasswordChar = Chr(149)
        txtNewPass.PasswordChar = Chr(149)
    End Sub
    Sub Save()
        Try
            If txtUser.Text = "" Or txtCode.Text = "" Or txtCNewPass.Text = "" Or txtNewPass.Text = "" Then
                MsgBox("Please enter missing field.", vbCritical)
                Return
            End If
            If txtNewPass.Text <> txtCNewPass.Text Then
                MsgBox("The password confirmation does not match.", vbCritical)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser where username = @username and code =@code", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@code", txtCode.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str_user = dr.Item("username").ToString
                code = dr.Item("code").ToString
            End If
            dr.Close()
            cn.Close()

            If StrComp(txtUser.Text, str_user, CompareMethod.Binary) Or StrComp(txtCode.Text, code, CompareMethod.Binary) Then
                MsgBox("Invalid username or code", vbExclamation)
                txtCode.Clear()
                txtCode.Focus()
            Else
                cn.Open()
                cm = New OleDb.OleDbCommand("update tbluser set cpassword = @cpassword where username like '" & txtUser.Text & "'", cn)
                cm.Parameters.AddWithValue("@cpassword", txtNewPass.Text)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("User Password has been successfully changed!", vbInformation)
                AuditTrail("User account name " & txtUser.Text & " changed password")
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Sub Clear()
        txtUser.Clear()
        txtCode.Clear()
        txtNewPass.Clear()
        txtCNewPass.Clear()
    End Sub

    Private Sub btnCCancel_Click(sender As Object, e As EventArgs) Handles btnCCancel.Click
        Clear()
    End Sub

    Private Sub FrmForgotPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub
End Class