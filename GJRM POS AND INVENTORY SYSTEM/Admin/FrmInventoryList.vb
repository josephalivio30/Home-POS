﻿Public Class FrmInventoryList
    Dim sql As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadInventory()
        dgvInventoryList.Rows.Clear()
        cn.Open()
        Dim i As Integer
        If cboList.Text = "Inventory Stocks" Then
            cm = New OleDb.OleDbCommand("select * from tblinventorylist", cn)
        ElseIf cboList.Text = "Critical Stocks" Then
            cm = New OleDb.OleDbCommand("select * from tblinventorylist WHERE (((tblproduct.[qty])<=[reorder]))", cn)
        End If
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            dgvInventoryList.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, (dr.Item("pdesc").ToString), (dr.Item("brand").ToString), (dr.Item("category").ToString), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(CInt(dr.Item("reorder").ToString), "#,##0.0"), Format(CInt(dr.Item("qty").ToString), "#,##0.0"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub cboList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboList.SelectedIndexChanged
        LoadInventory()
    End Sub

    Private Sub cboList_KeyDown(sender As Object, e As KeyEventArgs) Handles cboList.KeyDown
        e.Handled = True
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        If cboList.Text = "Inventory Stocks" Then
            sql = "select * from tblinventorylist"
        ElseIf cboList.Text = "Critical Stocks" Then
            sql = "select * from tblinventorylist WHERE (((tblproduct.[qty])<=[reorder]))"
        End If
        With FrmPrintStockInventory
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub
End Class