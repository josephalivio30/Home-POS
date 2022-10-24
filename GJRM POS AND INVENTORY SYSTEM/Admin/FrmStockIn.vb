Public Class FrmStockIn
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadStockIn()
        Try
            Dim i As Integer
            dgvStockIn.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from vwstockin where refno like '" & txtRefNo.Text & "' and status like 'Pending'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvStockIn.Rows.Add(i, dr.Item("id").ToString, dr.Item("refno").ToString, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, dr.Item("qty").ToString & roundT, Format(CDate(dr.Item("sdate").ToString).ToShortDateString) & " " & Format(CDate(dr.Item("stime").ToString).ToShortTimeString), dr.Item("stockinby").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvStockIn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockIn.CellContentClick
        Dim Pcolname As String = dgvStockIn.Columns(e.ColumnIndex).Name
        If Pcolname = "ColDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("delete from tblstockin where id like '" & dgvStockIn.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)
                LoadStockIn()
            End If
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If txtRefNo.Text = String.Empty Then
            MsgBox("Please enter reference number.", vbExclamation)
            Return
        End If
        If txtStockIn.Text = String.Empty Then
            MsgBox("Please enter stock in by.", vbExclamation)
            Return
        End If
        With FrmSearchProductStockIn
            .LoadProducts()
            .ShowDialog()
        End With
    End Sub

    Private Sub FrmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmStockIn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim i As Integer
            If MsgBox("Save this records?", vbYesNo + vbQuestion) = vbYes Then
                If dgvStockIn.Rows.Count > 0 Then
                    For i = 0 To dgvStockIn.Rows.Count - 1

                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblproduct set qty = qty +'" & CInt(dgvStockIn.Rows(i).Cells(5).Value.ToString) & "' where pcode like '" & (dgvStockIn.Rows(i).Cells(3).Value.ToString) & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblstockin set qty = qty +'" & CInt(dgvStockIn.Rows(i).Cells(5).Value.ToString) & "', status = 'Done' where id like '" & (dgvStockIn.Rows(i).Cells(1).Value.ToString) & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        AuditTrail("Added " & dgvStockIn.Rows(i).Cells(5).Value.ToString & " qty, product name " & dgvStockIn.Rows(i).Cells(4).Value.ToString)
                    Next
                End If
                MsgBox("Record has been successfully saved", vbInformation)
                Clear()
                LoadStockIn()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Clear()
        txtRefNo.Clear()
        txtStockIn.Clear()
        dt1.Value = Now.ToString
    End Sub
End Class