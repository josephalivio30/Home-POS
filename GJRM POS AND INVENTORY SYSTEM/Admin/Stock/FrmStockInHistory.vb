Public Class FrmStockInHistory
    Dim sql As String
    Dim sdate1 As String
    Dim sdate2 As String
    Sub LoadStockInHistory()
        Try
            Dim i As Integer
            sdate1 = dt1.Value.ToString("yyyy-MM-dd")
            sdate2 = dt2.Value.ToString("yyyy-MM-dd")
            dgvStockInHistory.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from vwstockin where status like 'Done' and sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvStockInHistory.Rows.Add(i, dr.Item("id").ToString, dr.Item("refno").ToString, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, dr.Item("qty").ToString & roundT, Format(CDate(dr.Item("sdate").ToString).ToShortDateString) & " " & Format(CDate(dr.Item("stime").ToString).ToShortTimeString), dr.Item("stockinby").ToString, dr.Item("vendor").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        If dt1.Value > dt2.Value Then
            dt1.Value = dt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadStockInHistory()
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        If dt1.Value > dt2.Value Then
            dt2.Value = dt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadStockInHistory()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmStockInHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmStockInHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            sql = "Select * from vwstockin where status Like 'Done' and sdate between #" & sdate1 & "# and #" & sdate2 & "#"
            With FrmPrintStockHistory
                .PrintPreview(sql)
                .ShowDialog()
            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvStockInHistory_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvStockInHistory.SortCompare
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