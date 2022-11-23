Public Class FrmInventoryList
    Dim sql As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadInventory()
        Try
            dgvInventoryList.Rows.Clear()
            cn.Open()
            Dim _total As Double
            Dim i As Integer
            If cboList.Text = "Inventory Stocks" Then
                cm = New OleDb.OleDbCommand("select * from tblinventorylist where pdesc like '" & txtSearch.Text & "%'", cn)
            ElseIf cboList.Text = "Critical Stocks" Then
                cm = New OleDb.OleDbCommand("select * from tblinventorylist WHERE (((tblproduct.[qty])<=[reorder])) where pdesc like '" & txtSearch.Text & "%'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                dgvInventoryList.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, (dr.Item("pdesc").ToString), (dr.Item("brand").ToString), (dr.Item("category").ToString), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(CInt(dr.Item("reorder").ToString), "#,##0.0"), Format(CInt(dr.Item("qty").ToString), "#,##0.0"), Format(CInt(dr.Item("bprice").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()

            lblTotal.Text = Format(_total, currencysymbol & "#,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cboList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboList.SelectedIndexChanged
        LoadInventory()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        Try
            If cboList.Text = "Inventory Stocks" Then
                sql = "select * from tblinventorylist where pdesc like '" & txtSearch.Text & "%'"
            ElseIf cboList.Text = "Critical Stocks" Then
                sql = "select * from tblinventorylist WHERE (((tblproduct.[qty])<=[reorder])) where pdesc like '" & txtSearch.Text & "%'"
            End If
            With FrmPrintStockInventory
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmInventoryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmInventoryList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cboList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboList.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadInventory()
    End Sub

    Private Sub dgvInventoryList_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvInventoryList.SortCompare
        Try
            Dim dval1, dval2 As Double

            If Not Double.TryParse(e.CellValue1.ToString, dval1) Then Return
            If Not Double.TryParse(e.CellValue2.ToString, dval2) Then Return

            If dval1 = dval2 Then
                e.SortResult = 0
            ElseIf dval2 > dval1 Then
                e.SortResult = -1
            ElseIf dval1 > dval2 Then
                e.SortResult = 1
            End If
            e.Handled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class