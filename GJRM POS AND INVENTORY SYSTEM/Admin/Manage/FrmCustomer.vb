Public Class FrmCustomer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub UpdateCustomer()
        Try
            If txtCustomer.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If
            If MsgBox("Update this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblcustomer set cname = @cname ,address = @address , contact = @contact, tin = @tin where ID like '" & lblID.Text & "'", cn)
                With cm.Parameters
                    .AddWithValue("@cname", txtCustomer.Text)
                    .AddWithValue("@address", txtAddress.Text)
                    .AddWithValue("@contact", txtNo.Text)
                    .AddWithValue("@tin", txtTin.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated", vbInformation)
                AuditTrail("Updated customer's name " & txtCustomer.Text)
                With FrmCustomerList
                    .LoadCustomer()
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
        txtCustomer.Clear()
        txtAddress.Clear()
        txtNo.Clear()
        txtTin.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub
    Sub SaveCustomer()
        Try
            Dim sdate As String = Now.ToString("MM-dd-yyyy")
            If txtCustomer.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If
            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcustomer(cname, tin, contact, address, datecreated)values(@cname, @tin, @contact, @address, @datecreated)", cn)
                With cm
                    .Parameters.AddWithValue("@cname", "" + txtCustomer.Text)
                    .Parameters.AddWithValue("@tin", txtTin.Text)
                    .Parameters.AddWithValue("@contact", txtNo.Text)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@datecreated", sdate)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Record has been successfully saved", vbInformation)
                AuditTrail("Added customer's name " & txtCustomer.Text)
                With FrmCustomerList
                    .LoadCustomer()
                End With
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveCustomer()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateCustomer()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub txtTin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTin.KeyPress, txtNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            If btnSave.Enabled = False Then
                Return
            Else
                SaveCustomer()
            End If
        End If
    End Sub
End Class