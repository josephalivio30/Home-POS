Public Class FrmProductList
    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        With FrmProduct
            .LoadCboBrand()
            .LoadCboCategory()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Sub LoadCboCategory()
        Try
            cboCategory.Items.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblcategory", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboCategory.Items.Add(dr.Item("category").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub LoadProducts()
        Try
            Dim i As Integer
            dgvProduct.Rows.Clear()
            cn.Open()
            If cboCategory.Text = "ALL CATEGORY" Then
                cm = New OleDb.OleDbCommand("select tblproduct.pcode, tblproduct.barcode, tblproduct.pdesc, tblbrand.brand, tblcategory.category, tblproduct.bprice, tblproduct.sprice, tblproduct.reorder from (tblproduct inner join tblbrand on tblproduct.bid = tblbrand.id) inner join tblcategory on tblproduct.cid = tblcategory.id where tblproduct.pdesc like '" & txtSearch.Text & "%'", cn)
            Else
                cm = New OleDb.OleDbCommand("select tblproduct.pcode, tblproduct.barcode, tblproduct.pdesc, tblbrand.brand, tblcategory.category, tblproduct.bprice, tblproduct.sprice, tblproduct.reorder from (tblproduct inner join tblbrand on tblproduct.bid = tblbrand.id) inner join tblcategory on tblproduct.cid = tblcategory.id where tblproduct.pdesc like '" & txtSearch.Text & "%'and tblcategory.category like '" & cboCategory.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
                While dr.Read
                i = i + 1
                dgvProduct.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, dr.Item("pdesc").ToString, dr.Item("brand").ToString, dr.Item("category").ToString, Format(CDbl(dr.Item("bprice").ToString), "#,##0.00"), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), dr.Item("reorder").ToString & roundT)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        LoadProducts()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        Try
            'edit button in the datagridview'
            Dim Pcolname As String = dgvProduct.Columns(e.ColumnIndex).Name
            If Pcolname = "ColEdit" Then
                With FrmProduct
                    .txtProductCode.Text = dgvProduct.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtBarCode.Text = dgvProduct.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtDescription.Text = dgvProduct.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cboBrand.Text = dgvProduct.Rows(e.RowIndex).Cells(4).Value.ToString
                    .cboCategory.Text = dgvProduct.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtBPrice.Text = dgvProduct.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtSPrice.Text = dgvProduct.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtReOrder.Text = dgvProduct.Rows(e.RowIndex).Cells(8).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .LoadCboBrand()
                    .LoadCboCategory()
                    .ShowDialog()
                End With
                'delete product in the datagridview'
            ElseIf Pcolname = "ColDelete" Then
                If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblproduct where pcode like '" & dgvProduct.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    AuditTrail("deleted product name " & dgvProduct.Rows(e.RowIndex).Cells(3).Value.ToString)
                    LoadProducts()
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmProductList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
End Class