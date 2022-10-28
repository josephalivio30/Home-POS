Public Class FrmCategoryList
    Dim category As String
    Private Sub FrmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub LoadCategory()
        Try
            Dim i As Integer
            dgvCategory.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblcategory", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvCategory.Rows.Add(i, dr.Item("id"), dr.Item("category").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick
        Try
            Dim colname As String = dgvCategory.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                category = dgvCategory.Rows(e.RowIndex).Cells(2).Value.ToString
                txtCategory.Text = category
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                txtCategory.Focus()

            ElseIf colname = "ColDelete" Then
                If MsgBox("Delete this record", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblcategory where category like '" & dgvCategory.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Record has been successfully deleted", vbInformation)
                    AuditTrail("Deleted category list " & txtCategory.Text)
                    cn.Close()
                    LoadCategory()

                    With FrmProduct
                        .LoadCboCategory()
                    End With

                    With FrmProductList
                        .LoadCboCategory()
                    End With
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub UpdateCategory()
        Try
            If txtCategory.Text = String.Empty Then Return
            If MsgBox("Update category name?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblcategory set category = @category where category like '" & category & "'", cn)
                cm.Parameters.AddWithValue("@category", txtCategory.Text)
                cm.ExecuteNonQuery()
                MsgBox("Record has been successfully updated.", vbInformation)
                AuditTrail("Updated category list " & txtCategory.Text)
                cn.Close()
                LoadCategory()
                txtCategory.Clear()
                txtCategory.Focus()
                btnUpdate.Enabled = False
                btnSave.Enabled = True

                With FrmProduct
                    .LoadCboCategory()
                End With

                With FrmProductList
                    .LoadCboCategory()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Save()
        Try
            If (txtCategory.Text = "") Then
                MsgBox("Please input data needed", vbCritical)
            ElseIf MsgBox("Save this category?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcategory (category)values(@category)", cn)
                cm.Parameters.AddWithValue("@category", txtCategory.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Category has been successfully saved", vbInformation)
                AuditTrail("Added category list " & txtCategory.Text)
                txtCategory.Clear()
                txtCategory.Focus()
                LoadCategory()

                With FrmProduct
                    .LoadCboCategory()
                End With

                With FrmProductList
                    .LoadCboCategory()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCategory.Text = String.Empty Then
            MsgBox("Required empty field.", vbExclamation)
            Return
        ElseIf btnSave.Enabled = False Then
            Return
        Else
            Save()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCategory.Text = String.Empty Then Return
        UpdateCategory()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtCategory.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtCategory.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmCategoryList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtCategory.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            ElseIf btnSave.Enabled = False Then
                Return
            Else
                Save()
            End If
        End If
    End Sub
End Class