Public Class FrmVendorList
    Sub LoadVendor()
        Try
            Dim i As Integer
            dgvVendor.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblvendor where vendor like '" & txtSearch.Text & "%' order by vendor asc", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvVendor.Rows.Add(i, dr.Item("ID").ToString, dr.Item("vendor").ToString, dr.Item("address").ToString, dr.Item("contactperson").ToString, dr.Item("telephone").ToString, dr.Item("email").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvVendor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVendor.CellContentClick
        Try
            'edit button in the datagridview'
            Dim Pcolname As String = dgvVendor.Columns(e.ColumnIndex).Name
            If Pcolname = "ColEdit" Then
                With FrmVendor
                    .txtID.Text = dgvVendor.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtVendor.Text = dgvVendor.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAddress.Text = dgvVendor.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtContact.Text = dgvVendor.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtNo.Text = dgvVendor.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtEmail.Text = dgvVendor.Rows(e.RowIndex).Cells(6).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .ShowDialog()
                End With
                'delete product in the datagridview'
            ElseIf Pcolname = "ColDelete" Then
                If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblvendor where ID like '" & dgvVendor.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    AuditTrail("Deleted vendor name " & dgvVendor.Rows(e.RowIndex).Cells(2).Value.ToString)
                    LoadVendor()
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        With FrmVendor
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmVendorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub dgvVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVendor.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadVendor()
    End Sub
End Class