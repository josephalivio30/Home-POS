Public Class FrmCustomerList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadCustomer()
        Try
            Dim i As Integer
            dgvCustomer.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblcustomer where cname like '" & txtSearch.Text & "%' order by cname asc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvCustomer.Rows.Add(i, dr.Item("id"), dr.Item("cname").ToString, Format(CDate(dr.Item("datecreated").ToString).ToShortDateString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmCustomerList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        Try
            Dim colname As String = dgvCustomer.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                With FrmCustomer
                    .lblID.Text = dgvCustomer.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtCustomer.Text = dgvCustomer.Rows(e.RowIndex).Cells(2).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .ShowDialog()
                End With
            ElseIf colname = "ColDelete" Then
                If MsgBox("Delete this record", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblcustomer where cname like '" & dgvCustomer.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    cn.Close()
                    AuditTrail("Deleted customer's name " & dgvCustomer.Rows(e.RowIndex).Cells(2).Value.ToString)
                    LoadCustomer()
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        With FrmCustomer
            .ShowDialog()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCustomer()
    End Sub
End Class