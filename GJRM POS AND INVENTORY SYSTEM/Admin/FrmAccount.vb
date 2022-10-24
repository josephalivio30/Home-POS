Public Class FrmAccount
    Dim user As String
    Dim pass As String
    Dim cuser As String

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs)
        Clear()
    End Sub

    Private Sub FrmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        txtConfirm.PasswordChar = Chr(149)
        txtOldPass.PasswordChar = Chr(149)
        txtNewPass.PasswordChar = Chr(149)
        txtCNewPass.PasswordChar = Chr(149)
        Me.KeyPreview = True
    End Sub
    Sub Clear()
        txtUser.Clear()
        txtPass.Clear()
        txtCode.Clear()
        txtConfirm.Clear()
        txtName.Clear()
        cboRole.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Create()
    End Sub
    Sub LoadAccount()
        dgvAccount.Rows.Clear()
        Try
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvAccount.Rows.Add(dr.Item("id").ToString, dr.Item("username").ToString, dr.Item("cname").ToString, dr.Item("role").ToString)
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub FrmAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            'If e.KeyCode = Keys.Escape Then
            '    Me.Close()
            If e.KeyCode = Keys.Enter Then
                Create()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Create()
        Try
            If txtUser.Text = "" Or txtPass.Text = "" Or txtConfirm.Text = "" Or txtName.Text = "" Or txtCode.Text = "" Or cboRole.SelectedItem = String.Empty Then
                MsgBox("Please enter missing field", vbCritical)
                Return
            End If
            If txtPass.Text <> txtConfirm.Text Then
                MsgBox("Invalid confirm password", vbCritical)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("Insert into tbluser (username, code, cpassword, cname, role)values(@username, @code, @cpassword, @cname, @role)", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@code", txtCode.Text)
                .Parameters.AddWithValue("@cpassword", txtPass.Text)
                .Parameters.AddWithValue("@cname", txtName.Text)
                .Parameters.AddWithValue("@role", cboRole.SelectedItem)

            End With
            cm.ExecuteNonQuery()
            cn.Close()

            MsgBox("New user account has been successfully saved!", vbInformation)

            If dgvAccount.RowCount > 0 Then
                AuditTrail("New account name " & txtName.Text & " created")
            End If

            LoadAccount()
            Clear()
            cboRole.SelectedIndex = 0

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellContentClick
        Dim colname As String = dgvAccount.Columns(e.ColumnIndex).Name
        If colname = "ColDelete" Then
            With FrmAdminPass
                .GetSql("delete from tbluser where username like '" & dgvAccount.Rows(e.RowIndex).Cells(1).Value.ToString & "'", dgvAccount.Rows(e.RowIndex).Cells(2).Value.ToString)
                .ShowDialog()
            End With
        End If
    End Sub
    Sub Save()
        Try
            Dim found As Boolean
            If txtCUser.Text = "" Or txtOldPass.Text = "" Or txtNewPass.Text = "" Or txtCNewPass.Text = "" Then
                MsgBox("Please enter missing field", vbCritical)
                Return
            End If
            If txtNewPass.Text <> txtCNewPass.Text Then
                MsgBox("Invalid confirm password", vbCritical)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbluser where username = @username and cpassword =@cpassword", cn)
            With cm
                .Parameters.AddWithValue("@username", txtCUser.Text)
                .Parameters.AddWithValue("@cpassword", txtOldPass.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                user = dr.Item("username")
                pass = dr.Item("cpassword")
            Else
                found = False
            End If
            dr.Close()
            cn.Close()

            If StrComp(txtCUser.Text, user, CompareMethod.Binary) Or StrComp(txtOldPass.Text, pass, CompareMethod.Binary) Then
                MsgBox("Invalid username or password", vbExclamation)
                txtOldPass.Clear()
                txtOldPass.Focus()
            Else
                cn.Open()
                cm = New OleDb.OleDbCommand("update tbluser set cpassword = @cpassword where username like '" & txtCUser.Text & "'", cn)
                cm.Parameters.AddWithValue("@cpassword", txtNewPass.Text)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("User Password has been successfully changed!", vbInformation)
                AuditTrail("User account name " & txtCUser.Text & " changed password")
                CClear()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub CClear()
        txtCUser.Clear()
        txtOldPass.Clear()
        txtNewPass.Clear()
        txtCNewPass.Clear()
        txtCUser.Focus()
    End Sub

    Private Sub txtCCancel_Click(sender As Object, e As EventArgs) Handles txtCCancel.Click
        CClear()
    End Sub

    Private Sub txtCSave_Click(sender As Object, e As EventArgs) Handles txtCSave.Click
        Save()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Private Sub cboRole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboRole.KeyPress
        e.Handled = True
    End Sub
End Class