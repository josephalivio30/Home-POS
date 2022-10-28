Imports System.Net.Mail
Public Class FrmForgotPassword
    Dim pass As String
    Private Sub FrmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Left = (Panel1.Width - Panel2.Width) / 2
        KeyPreview = True
    End Sub
    Sub Save()
        Try
            Dim mail As New MailMessage
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("jja.solutions22@gmail.com")
            mail.To.Add(txtEmail.Text)
            mail.Subject = "POS & INVENTORY SYSTEM FORGOT PASSORD"
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser where email like '" & txtEmail.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                pass = dr.Item("cpassword").ToString
            Else
                MsgBox("Your Email is not registered in our system, please type the correct email", vbExclamation)
                Return
            End If
            dr.Close()
            cn.Close()

            mail.Body = "Good day Sir/Ma'am,
                         
    We have received your request, your old password is '" & pass & "'. We recommend to change your password after receiving this email.

Sincerely,
JJA SOLUTIONS"

            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential("jja.solutions22@gmail.com", "xujlpmugpswybpdn")
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)
            MsgBox("Mail has been successfully sent to your email", vbInformation)
            txtEmail.Clear()
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub FrmForgotPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

End Class