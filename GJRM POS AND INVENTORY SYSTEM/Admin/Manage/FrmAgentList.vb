Public Class FrmAgentList
    Dim agent As String
    Sub LoadAgent()
        Try
            Dim i As Integer
            dgvAgent.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblagent where agent like '" & txtSearch.Text & "%' order by agent asc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvAgent.Rows.Add(i, dr.Item("id"), dr.Item("agent").ToString, dr.Item("address").ToString, dr.Item("contact").ToString, dr.Item("email").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvAgent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgent.CellContentClick
        Try
            Dim colname As String = dgvAgent.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                With FrmAgent
                    .lblID.Text = dgvAgent.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtAgent.Text = dgvAgent.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAddress.Text = dgvAgent.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtNo.Text = dgvAgent.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtEmail.Text = dgvAgent.Rows(e.RowIndex).Cells(5).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .ShowDialog()
                End With

            ElseIf colname = "ColDelete" Then
                If MsgBox("Delete this record", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblagent where agent like '" & dgvAgent.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    cn.Close()
                    AuditTrail("Deleted agent name " & dgvAgent.Rows(e.RowIndex).Cells(2).Value.ToString)
                    LoadAgent()

                    With FrmPOS
                        LoadAgent()
                    End With
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub FrmAgent_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmAgent_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        With FrmAgent
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAgent()
    End Sub
End Class