Public Class FrmSearchProductStockIn
    Sub LoadProducts()
        Try
            Dim i As Integer
            dgvOnhand.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select pcode, pdesc, qty from tblproduct where pdesc like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvOnhand.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, dr.Item("qty").ToString & roundT)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub dgvOnhand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOnhand.CellContentClick
        Dim Pcolname As String = dgvOnhand.Columns(e.ColumnIndex).Name
        If Pcolname = "ColCheck" Then
            If MsgBox("Add this Item?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblstockin (refno, pcode, sdate, stime, stockinby) values (@refno, @pcode, @sdate, @stime, @stockinby)", cn)
                With cm.Parameters
                    .AddWithValue("@refno", FrmStockIn.txtRefNo.Text)
                    .AddWithValue("@pcode", dgvOnhand.Rows(e.RowIndex).Cells(1).Value.ToString)
                    .AddWithValue("@sdate", FrmStockIn.dt1.Value.ToShortDateString)
                    .AddWithValue("@stime", Now.ToShortTimeString)
                    .AddWithValue("@stockinby", FrmStockIn.txtStockIn.Text)
                End With
                cm.ExecuteNonQuery()
                dr.Close()
                cn.Close()

                With FrmStockIn
                    .LoadStockIn()
                End With
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmSearchProductStockIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmSearchProductStockIn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class