Public Class FrmBrandList
    Dim brand As String
    Private Sub FrmBrandList_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub Save()
        Try
            If txtBrand.Text = String.Empty Then Return
            If MsgBox("Save the brand name?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblbrand (brand)values(@brand)", cn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                AuditTrail("Added brand name " & txtBrand.Text)
                LoadBrand()

                With FrmProduct
                    .LoadCboBrand()
                End With
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtBrand.Text = String.Empty Then
            MsgBox("Required empty field.", vbExclamation)
            Return
        ElseIf btnSave.Enabled = False Then
            Return
        Else
            Save()
        End If
    End Sub
    Sub LoadBrand()
        Try
            dgvBrand.Rows.Clear()
            Dim i As Integer
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblbrand order by brand asc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvBrand.Rows.Add(i, dr.Item("id"), dr.Item("brand").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtBrand.Clear()
        txtBrand.Focus()
    End Sub

    Private Sub dgvBrand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellContentClick
        Try
            Dim colname As String = dgvBrand.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                brand = dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString
                txtBrand.Text = brand
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                txtBrand.Focus()
            ElseIf colname = "ColDelete" Then
                If MsgBox("Delete this record", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblbrand where brand like '" & dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    cn.Close()
                    AuditTrail("Deleted brand name " & dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString)
                    LoadBrand()

                    With FrmProduct
                        .LoadCboBrand()
                    End With
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateBrand()
        Try
            If txtBrand.Text = String.Empty Then Return
            If MsgBox("Update brand name?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblbrand set brand = @brand where brand like '" & brand & "'", cn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                AuditTrail("Updated brand name " & txtBrand.Text)

                txtBrand.Clear()
                txtBrand.Focus()
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                LoadBrand()

                With FrmProduct
                    .LoadCboBrand()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtBrand.Text = String.Empty Then Return
        UpdateBrand()
    End Sub

    Private Sub FrmBrandList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtBrand.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            ElseIf btnSave.Enabled = False Then
                Return
            Else
                Save()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub
End Class