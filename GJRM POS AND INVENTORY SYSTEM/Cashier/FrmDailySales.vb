Public Class FrmDailySales
    Sub LoadSale()
        Try
            dgvDailySales.Rows.Clear()
            Dim _total As Double
            Dim i As Integer
            Dim sdate As String = Now.ToString("MM-dd-yyyy")
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from ComputeTotal where sdate between #" & sdate & "# and #" & sdate & "# and status like 'Completed' and transno like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                dgvDailySales.Rows.Add(i, dr.Item("id").ToString, dr.Item("pcode").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()

            lblTotal.Text = Format(_total, currencysymbol & "#,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmDailySales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvDailySales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDailySales.CellContentClick
        Try
            Dim colname As String = dgvDailySales.Columns(e.ColumnIndex).Name
            If colname = "ColCancel" Then
                With FrmCancelOrder
                    .txtID.Text = dgvDailySales.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtPcode.Text = dgvDailySales.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtDesc.Text = dgvDailySales.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtTransno.Text = dgvDailySales.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtPrice.Text = dgvDailySales.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtSQty.Text = dgvDailySales.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtDiscount.Text = dgvDailySales.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtTotal.Text = dgvDailySales.Rows(e.RowIndex).Cells(8).Value.ToString
                    .txtCancelBy.Text = str_user
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadSale()
    End Sub
End Class