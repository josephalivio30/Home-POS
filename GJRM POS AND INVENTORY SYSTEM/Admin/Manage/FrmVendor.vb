Imports System.Text.RegularExpressions
Public Class FrmVendor
    Private Sub FrmVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub Save()
        Try
            If txtVendor.Text = String.Empty Or txtAddress.Text = String.Empty Or txtContact.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If

            Dim regex As Regex = New Regex("[a-zA-Z0-9_\-\.]+[@][a-z]+[\.][a-z]{2,3}")
            Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
            If Not isValid Then
                MsgBox("Please enter a valid email address.", vbExclamation)
                Return
            End If

            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblvendor(vendor,address, contactperson, telephone, email)values(@vendor,@address, @contactperson, @telephone, @email)", cn)
                With cm.Parameters
                    .AddWithValue("@vendor", txtVendor.Text)
                    .AddWithValue("@address", txtAddress.Text)
                    .AddWithValue("@contactperson", txtContact.Text)
                    .AddWithValue("@telephone", txtNo.Text)
                    .AddWithValue("@email", txtEmail.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved", vbInformation)
                AuditTrail("Added vendor name " & txtVendor.Text)
                With FrmVendorList
                    .LoadVendor()
                End With
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateVendor()
        Try
            If txtVendor.Text = String.Empty Or txtAddress.Text = String.Empty Or txtContact.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If

            Dim regex As Regex = New Regex("[a-zA-Z0-9_\-\.]+[@][a-z]+[\.][a-z]{2,3}")
            Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
            If Not isValid Then
                MsgBox("Please enter a valid email address.", vbExclamation)
                Return
            End If

            If MsgBox("Update this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblvendor set vendor = @vendor ,address = @address , contactperson = @contactperson , telephone = @telephone, email = @email where ID like '" & txtID.Text & "'", cn)
                With cm.Parameters
                    .AddWithValue("@vendor", txtVendor.Text)
                    .AddWithValue("@address", txtAddress.Text)
                    .AddWithValue("@contactperson", txtContact.Text)
                    .AddWithValue("@telephone", txtNo.Text)
                    .AddWithValue("@email", txtEmail.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated", vbInformation)
                AuditTrail("Updated vendor name " & txtVendor.Text)
                With FrmVendorList
                    .LoadVendor()
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
        txtVendor.Clear()
        txtAddress.Clear()
        txtContact.Clear()
        txtNo.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateVendor()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
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

    Private Sub FrmVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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