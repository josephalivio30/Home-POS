Public Class FrmRCancelledOrder
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Sub LoadCancelOrder()
        Try
            dgvCancelOrder.Rows.Clear()
            Dim refund As Double = 0
            Dim i As Integer
            sdate1 = Cdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Cdt2.Value.ToString("yyyy-MM-dd")
            cn.Open()

            If cboCancelledBy.Text = "ALL" Then
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%'", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%' and cancelledby like '" & cboCancelledBy.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dgvCancelOrder.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("cname").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), CDate(dr.Item("sdate").ToString).ToShortDateString, dr.Item("voidby").ToString, dr.Item("cancelledby").ToString, dr.Item("reason").ToString, dr.Item("saction").ToString, dr.Item("remarks").ToString)
            End While
            dr.Close()
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(total + discount)), '0', sum(total + discount)) as total from tblcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and remarks = 'Paid'", cn)
            refund = CDbl(cm.ExecuteScalar)
            cn.Close()

            lblTotal.Text = Format(refund, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadCashier()
        Try
            cboCancelledBy.Items.Clear()
            cboCancelledBy.Items.Add("ALL")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cancelledby from vwcancelorder", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboCancelledBy.Items.Add(UCase(dr.Item("cancelledby").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Cdt1_ValueChanged(sender As Object, e As EventArgs) Handles Cdt1.ValueChanged
        If Cdt1.Value > Cdt2.Value Then
            Cdt1.Value = Cdt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadCancelOrder()
    End Sub

    Private Sub Cdt2_ValueChanged(sender As Object, e As EventArgs) Handles Cdt2.ValueChanged
        If Cdt1.Value > Cdt2.Value Then
            Cdt2.Value = Cdt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadCancelOrder()
    End Sub

    Private Sub cboCashier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCancelledBy.SelectedIndexChanged
        LoadCancelOrder()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCancelOrder()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        Try

            If cboCancelledBy.Text = "ALL" Then
                sql = "select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%'"
            Else
                sql = "select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%' and cancelledby like '" & cboCancelledBy.Text & "'"
            End If
            With FrmPrintCancelledOrder
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboCancelledBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCancelledBy.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmRCancelledOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRCancelledOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub dgvCancelOrder_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvCancelOrder.SortCompare
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