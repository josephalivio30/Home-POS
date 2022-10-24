Public Class FrmLogin
    Dim sdate As String = Now.ToString("dd-MM-yyyy")
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        Me.KeyPreview = True

        If CountRecords("select count(*) from tbluser where role like 'Administrator'") = 0 Then
            With FrmAccount
                .ShowDialog()
            End With
        End If
    End Sub
    Sub Login()
        Try
            If txtUser.Text = String.Empty Or txtPass.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser where username = @username and cpassword =@cpassword", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@cpassword", txtPass.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str_user = dr.Item("username").ToString
                str_pass = dr.Item("cpassword").ToString
                str_name = dr.Item("cname").ToString
                str_role = dr.Item("role").ToString
            End If
            dr.Close()
            cn.Close()

            If StrComp(txtUser.Text, str_user, CompareMethod.Binary) Or StrComp(txtPass.Text, str_pass, CompareMethod.Binary) Then
                MsgBox("Invalid username or password", vbExclamation)
                txtPass.Clear()
                txtPass.Focus()
            Else
                PureLogin()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub PureLogin()
        Try
            LogHistory("IN")
            MsgBox("Access Granted, Welcome " & str_name, vbInformation)

            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblsetting", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                _shopname = dr.Item("shopname").ToString
                _h1 = dr.Item("h1").ToString
                _h2 = dr.Item("h2").ToString
                _h3 = dr.Item("h3").ToString
            End If
            cn.Close()
            dr.Close()

            If str_role = "Administrator" Then
                With FrmMain
                    Dashboard()
                    .lblShopName.Text = _shopname
                    .lblName.Text = str_name & " | " & str_role
                    .ShowDialog()
                End With
                txtUser.Clear()
                txtPass.Clear()
                txtUser.Focus()
            Else
                With FrmPOS
                    If CheckStatus() = True Then
                        .btnNewOrder.Enabled = True
                    End If
                    .LoadAgent()
                    .lblShopname.Text = _shopname
                    .lblName.Text = str_name & " | " & str_role
                    .ShowDialog()
                    txtUser.Clear()
                    txtPass.Clear()
                    txtUser.Focus()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Do you want to Exit?", vbYesNo + vbQuestion) = vbYes Then
                Application.Exit()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to Exit?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub llForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llForgotPassword.LinkClicked
        With FrmForgotPassword
            .ShowDialog()
        End With
    End Sub
End Class