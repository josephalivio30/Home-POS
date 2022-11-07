Public Class FrmProduct
    Private Sub FrmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        With FrmBrandList
            .LoadBrand()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnAddCtgry_Click(sender As Object, e As EventArgs) Handles btnAddCtgry.Click
        With FrmCategoryList
            .LoadCategory()
            .ShowDialog()
        End With
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
    Sub LoadCboBrand()
        Try
            cboBrand.Items.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblbrand", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboBrand.Items.Add(dr.Item("brand").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Sub Save()
        Try
            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim bid As Integer
                Dim cid As Integer
                cn.Open()
                cm = New OleDb.OleDbCommand("select id from tblbrand where brand like '" & cboBrand.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    bid = (dr.Item("id"))
                End If
                dr.Close()
                cn.Close()

                If CDbl(txtBPrice.Text) > CDbl(txtSPrice.Text) Then
                    MsgBox("The bought price must be lower than the selling price.", vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("select id from tblcategory where category like '" & cboCategory.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    cid = (dr.Item("id"))
                End If
                dr.Close()
                cn.Close()

                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblproduct(pcode,barcode, pdesc, bid, cid, bprice, sprice, reorder)values(@pcode, @barcode, @pdesc, @bid, @cid, @bprice, @sprice, @reorder)", cn)
                With cm.Parameters
                    .AddWithValue("@pcode", txtProductCode.Text)
                    .AddWithValue("@barcode", txtBarCode.Text)
                    .AddWithValue("@pdesc", txtDescription.Text)
                    .AddWithValue("@bid", bid)
                    .AddWithValue("@cid", cid)
                    .AddWithValue("@bprice", txtBPrice.Text)
                    .AddWithValue("@sprice", txtSPrice.Text)
                    .AddWithValue("@reorder", CInt(txtReOrder.Text))
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved", vbInformation)
                AuditTrail("Added product name " & txtDescription.Text)
                With FrmProductList
                    .LoadProducts()
                End With
                Clear()

            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateProduct()
        Try
            If MsgBox("Update this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim bid As Integer
                Dim cid As Integer
                cn.Open()
                cm = New OleDb.OleDbCommand("select id from tblbrand where brand like '" & cboBrand.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    bid = dr.Item("id").ToString
                End If
                dr.Close()
                cn.Close()

                If CDbl(txtBPrice.Text) > CDbl(txtSPrice.Text) Then
                    MsgBox("The bought price must be lower than the selling price.", vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("select id from tblcategory where category like '" & cboCategory.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    cid = dr.Item("id").ToString
                End If
                dr.Close()
                cn.Close()

                cn.Open()
                cm = New OleDb.OleDbCommand("update tblproduct set barcode = @barcode, pdesc = @pdesc, bid = @bid, cid = @cid, bprice = @bprice, sprice = @sprice, reorder = @reorder  where pcode like '" & txtProductCode.Text & "'", cn)
                With cm.Parameters
                    .AddWithValue("@barcode", txtBarCode.Text)
                    .AddWithValue("@description", txtDescription.Text)
                    .AddWithValue("@bid", bid)
                    .AddWithValue("@cid", cid)
                    .AddWithValue("@bprice", Format(CDbl(txtBPrice.Text), "#,##0.00"))
                    .AddWithValue("@sprice", Format(CDbl(txtSPrice.Text), "#,##0.00"))
                    .AddWithValue("@reorder", CInt(txtReOrder.Text))
                End With
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("Record has been successfully updated", vbInformation)
                AuditTrail("Updated product name " & txtDescription.Text)
                With FrmProductList
                    .LoadProducts()
                End With
                Clear()
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Clear()
        txtProductCode.Clear()
        txtDescription.Clear()
        txtBarCode.Clear()
        cboBrand.Text = ""
        cboCategory.Text = ""
        txtBPrice.Text = ""
        txtSPrice.Text = ""
        txtReOrder.Text = ""
        txtProductCode.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductCode.Text = String.Empty Or txtBarCode.Text = String.Empty Or txtDescription.Text = String.Empty Or txtBPrice.Text = String.Empty Or txtSPrice.Text = String.Empty Or cboBrand.Text = String.Empty Or cboCategory.Text = String.Empty Then
            MsgBox("Required empty field.", vbExclamation)
            Return
        ElseIf btnSave.Enabled = False Then
            Return
        Else
            Save()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProductCode.Text = String.Empty Or txtBarCode.Text = String.Empty Or txtDescription.Text = String.Empty Or txtBPrice.Text = String.Empty Or txtSPrice.Text = String.Empty Or cboBrand.Text = String.Empty Or cboCategory.Text = String.Empty Then
            MsgBox("Required empty field.", vbExclamation)
            Return
        Else
            UpdateProduct()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub txtBPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBPrice.KeyPress, txtSPrice.KeyPress, txtReOrder.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
    Private Sub cboBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBrand.KeyPress, cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            If btnSave.Enabled = False Then
                Return
            Else
                Save()
            End If
        End If
    End Sub
End Class