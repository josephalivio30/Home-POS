Public Class FrmAdjustment
    Dim qty As Integer = 0
    Sub LoadProducts()
        Try
            Dim i As Integer
            dgvAdjustment.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select tblproduct.pcode, tblproduct.barcode, tblproduct.pdesc, tblbrand.brand, tblcategory.category, tblproduct.sprice, tblproduct.qty from (tblproduct inner join tblbrand on tblproduct.bid = tblbrand.id) inner join tblcategory on tblproduct.cid = tblcategory.id where tblproduct.pdesc like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvAdjustment.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, dr.Item("pdesc").ToString, dr.Item("brand").ToString, dr.Item("category").ToString, Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), dr.Item("qty").ToString & roundT)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub RandomRefNo()
        Dim random As New Random()
        Dim i As Double
        For i = 0 To 10
            txtRefNo.Text = Convert.ToString(random.Next(0, 999999999))
        Next
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub
    Sub save()
        Try
            If txtPcode.Text = String.Empty Or txtDesc.Text = String.Empty Or txtQty.Text = String.Empty Or txtRemarks.Text = String.Empty Or cboCommand.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
            End If
            Dim i As Integer
            If MsgBox("Save this records?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("select * from tbladjustment", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    If txtRefNo.Text = dr.Item("refno").ToString Then
                        MsgBox("Duplicate ref #, please click generate again", vbExclamation)
                        Return
                    End If
                End While
                dr.Close()
                cn.Close()

                If CInt(txtQty.Text) > qty Then
                    MsgBox("Stock on hand quantity should be greater than the adjustment qty", vbExclamation)
                    Return
                End If

                If cboCommand.Text = "REMOVE FROM INVENTORY" Then
                    SqlStatement("update tblproduct set qty = qty - '" & CInt(txtQty.Text) & "' where pcode like '" & txtPcode.Text & "'")
                ElseIf cboCommand.Text = "ADD TO INVENTORY" Then
                    SqlStatement("update tblproduct set qty = qty + '" & CInt(txtQty.Text) & "' where pcode like '" & txtPcode.Text & "'")
                End If
            End If

            SqlStatement("insert into tbladjustment(refno, pcode, qty, saction, remarks, sdate, cuser)values('" & txtRefNo.Text & "', '" & txtPcode.Text & "', '" & txtQty.Text & "', '" & cboCommand.Text & "', '" & txtRemarks.Text & "', '" & Now.ToShortDateString & "', '" & txtUser.Text & "')")
            LoadProducts()
            Dashboard()
            MsgBox("Record has been successfully adjusted", vbInformation)
            AuditTrail("Adjusted product name " & dgvAdjustment.Rows(i).Cells(3).Value.ToString)
            Clear()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SqlStatement(ByVal sql As String)
        cn.Open()
        cm = New OleDb.OleDbCommand(sql, cn)
        cm.ExecuteNonQuery()
        cn.Close()
    End Sub
    Sub Clear()
        txtDesc.Clear()
        txtPcode.Clear()
        txtQty.Clear()
        txtRefNo.Clear()
        txtRemarks.Clear()
        cboCommand.Text = ""
        RandomRefNo()
    End Sub
    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdjustment.CellContentClick
        Dim Pcolname As String = dgvAdjustment.Columns(e.ColumnIndex).Name
        If Pcolname = "ColSelect" Then
            txtPcode.Text = dgvAdjustment.Rows(e.RowIndex).Cells(1).Value.ToString
            txtDesc.Text = dgvAdjustment.Rows(e.RowIndex).Cells(3).Value.ToString
            qty = CInt(dgvAdjustment.Rows(e.RowIndex).Cells(7).Value.ToString)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RandomRefNo()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmAdjustment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            save()
        End If
    End Sub
End Class