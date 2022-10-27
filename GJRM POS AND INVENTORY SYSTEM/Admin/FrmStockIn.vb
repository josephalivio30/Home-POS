Public Class FrmStockIn
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadStockIn()
        Try
            Dim i As Integer
            dgvStockIn.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from vwstockin where refno like '" & txtRefNo.Text & "' and status like 'Pending'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvStockIn.Rows.Add(i, dr.Item("id").ToString, dr.Item("refno").ToString, dr.Item("vendor").ToString, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, dr.Item("qty").ToString & roundT, Format(CDate(dr.Item("sdate").ToString).ToShortDateString) & " " & Format(CDate(dr.Item("stime").ToString).ToShortTimeString), dr.Item("stockinby").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvStockIn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockIn.CellContentClick
        Dim Pcolname As String = dgvStockIn.Columns(e.ColumnIndex).Name
        If Pcolname = "ColDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("delete from tblstockin where id like '" & dgvStockIn.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)
                LoadStockIn()
            End If
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If txtRefNo.Text = String.Empty Then
            MsgBox("Please enter reference number.", vbExclamation)
            Return
        End If
        If txtStockIn.Text = String.Empty Then
            MsgBox("Please enter stock in by.", vbExclamation)
            Return
        End If
        With FrmSearchProductStockIn
            .LoadProducts()
            .ShowDialog()
        End With
    End Sub

    Private Sub FrmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmStockIn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim i As Integer
            If MsgBox("Save this records?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("select * from tblstockin", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    If txtRefNo.Text = dr.Item("refno").ToString Then
                        MsgBox("Duplicate ref #, please click generate again", vbExclamation)
                        Return
                    End If
                End While
                dr.Close()
                cn.Close()

                If dgvStockIn.Rows.Count > 0 Then
                    For i = 0 To dgvStockIn.Rows.Count - 1

                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblproduct set qty = qty +'" & CInt(dgvStockIn.Rows(i).Cells(6).Value.ToString) & "' where pcode like '" & (dgvStockIn.Rows(i).Cells(4).Value.ToString) & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblstockin set qty = qty +'" & CInt(dgvStockIn.Rows(i).Cells(6).Value.ToString) & "', status = 'Done' where id like '" & (dgvStockIn.Rows(i).Cells(1).Value.ToString) & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        AuditTrail("Added " & dgvStockIn.Rows(i).Cells(6).Value.ToString & " qty, product name " & dgvStockIn.Rows(i).Cells(5).Value.ToString)
                    Next
                End If

                MsgBox("Record has been successfully saved", vbInformation)
                Clear()
                LoadStockIn()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Clear()
        txtRefNo.Clear()
        txtStockIn.Clear()
        dt1.Value = Now.ToString
        txtAddress.Clear()
        txtContact.Clear()
        cboVendor.SelectedIndex = -1
        lblID.Text = ""
    End Sub
    Sub LoadVendor()
        Try
            cboVendor.Items.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct vendor from tblvendor", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboVendor.Items.Add(UCase(dr.Item("vendor").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cboVendor_TextChanged(sender As Object, e As EventArgs) Handles cboVendor.TextChanged

        cn.Open()
        cm = New OleDb.OleDbCommand("select * from tblvendor where vendor like '" & cboVendor.Text & "'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblID.Text = dr.Item("ID").ToString
            txtContact.Text = dr.Item("contactperson").ToString
            txtAddress.Text = dr.Item("address").ToString
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub cboVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboVendor.KeyPress
        e.Handled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim random As New Random()
        Dim i As Double
        For i = 0 To 10
            txtRefNo.Text = Convert.ToString(random.Next(0, 999999999))
        Next
    End Sub

    Private Sub dgvStockIn_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvStockIn.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtRefNo_KeyPress
    End Sub


    Private Sub txtRefNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRefNo.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class