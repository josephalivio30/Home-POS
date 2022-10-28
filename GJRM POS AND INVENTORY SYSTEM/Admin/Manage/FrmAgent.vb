Public Class FrmAgent
    Dim agent As String
    Sub LoadAgent()
        Try
            Dim i As Integer
            dgvAgent.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblagent", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvAgent.Rows.Add(i, dr.Item("id"), dr.Item("agent").ToString)
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
                agent = dgvAgent.Rows(e.RowIndex).Cells(2).Value.ToString
                txtAgent.Text = agent
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                txtAgent.Focus()

            ElseIf colname = "ColDelete" Then
                If MsgBox("Delete this record", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblagent where agent like '" & dgvAgent.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    AuditTrail("Deleted agent name " & txtAgent.Text)
                    cn.Close()
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
    Sub UpdateAgent()
        Try
            If txtAgent.Text = String.Empty Then Return
            If MsgBox("Update agent name?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblagent set agent = @agent where agent like '" & agent & "'", cn)
                cm.Parameters.AddWithValue("@agent", txtAgent.Text)
                cm.ExecuteNonQuery()
                MsgBox("Record has been successfully updated.", vbInformation)
                AuditTrail("Updated agent name " & txtAgent.Text)
                cn.Close()
                LoadAgent()
                txtAgent.Clear()
                txtAgent.Focus()
                btnUpdate.Enabled = False
                btnSave.Enabled = True

                With FrmPOS
                    LoadAgent()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Save()
        Try
            If (txtAgent.Text = "") Then
                MsgBox("Please input data needed", vbCritical)
            ElseIf MsgBox("Save this agent name?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblagent (agent)values(@agent)", cn)
                cm.Parameters.AddWithValue("@agent", txtAgent.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Agent name has been successfully saved", vbInformation)
                AuditTrail("Added agent name " & txtAgent.Text)
                txtAgent.Clear()
                txtAgent.Focus()
                LoadAgent()

                With FrmPOS
                    LoadAgent()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAgent.Text = String.Empty Then
            MsgBox("Required empty field.", vbExclamation)
            Return
        ElseIf btnSave.Enabled = False Then
            Return
        Else
            Save()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAgent.Text = String.Empty Then Return
        UpdateAgent()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtAgent.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtAgent.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAgent_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtAgent.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            ElseIf btnSave.Enabled = False Then
                Return
            Else
                Save()
            End If
        End If
    End Sub

    Private Sub FrmAgent_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub
End Class