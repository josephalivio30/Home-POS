Public Class FrmRDebt
    Dim amount As Double
    Sub LoadDebt()
        Try
            dgvDebt.Rows.Clear()
            Dim total As Double = 0
            cn.Open()
            If cboName.Text = "ALL NAMES" Then
                cm = New OleDb.OleDbCommand("select * from tbldebt", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from tbldebt where cname like '" & cboName.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                total += CDbl(dr.Item("total"))
                dgvDebt.Rows.Add(dr.Item("transno").ToString, dr.Item("cname").ToString, dr.Item("cuser").ToString, Format(dr.Item("amount"), "#,##0.00").ToString, Format(dr.Item("adjustment"), "#,##0.00").ToString, Format(dr.Item("total"), "#,##0.00").ToString, dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString), Format(CDate(dr.Item("datetocollect").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            lblTotal.Text = Format(total, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadName()
        Try
            cboName.Items.Clear()
            cboName.Items.Add("ALL NAMES")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cname from tbldebt", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboName.Items.Add(UCase(dr.Item("cname").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        LoadDebt()
    End Sub
    Private Sub cboName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboName.KeyPress
        e.Handled = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRDebt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRDebt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
    Private Sub btnPayAll_Click(sender As Object, e As EventArgs) Handles btnPayAll.Click
        Try
            If cboName.Text = String.Empty Or cboName.Text = "ALL NAMES" Then
                MsgBox("Please choose a name!", vbCritical)
                Return
            Else
                cn.Open()
                cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as amount from tbldebt where cname like '" & cboName.Text & "'", cn)
                amount = CDbl(cm.ExecuteScalar)
                cn.Close()
                With FrmDebtPayment
                    .txtTransno.Text = "PAY ALL"
                    .txtName.Text = cboName.Text
                    .txtTAmount.Text = Format(CDbl(amount), "#,##0.00")
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub dgvDebt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDebt.CellContentClick
        Try
            Dim colname As String = dgvDebt.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                With frmDebtPayment
                    .txtTransno.Text = dgvDebt.Rows(e.RowIndex).Cells(0).Value.ToString
                    .txtName.Text = dgvDebt.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtTAmount.Text = dgvDebt.Rows(e.RowIndex).Cells(5).Value.ToString
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvDebt_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvDebt.SortCompare
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