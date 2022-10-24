Public Class FrmInventoryList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadInventory()
        dgvInventoryList.Rows.Clear()
        cn.Open()
        Dim i As Integer
        cm = New OleDb.OleDbCommand("select * from tblinventorylist", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            dgvInventoryList.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, (dr.Item("pdesc").ToString), (dr.Item("brand").ToString), (dr.Item("category").ToString), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(CInt(dr.Item("reorder").ToString), "#,##0.0"), Format(CInt(dr.Item("qty").ToString), "#,##0.0"))
        End While
        dr.Close()
        cn.Close()
    End Sub
End Class