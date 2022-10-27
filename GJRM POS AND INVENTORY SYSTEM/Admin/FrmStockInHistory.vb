Public Class FrmStockInHistory
    Dim sql As String
    Sub LoadStockInHistory()
        Try
            Dim i As Integer
            Dim sdate1 As String
            Dim sdate2 As String
            sdate1 = dt1.Value.ToString("dd-MM-yyyy")
            sdate2 = dt2.Value.ToString("dd-MM-yyyy")
            dgvStockInHistory.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from vwstockin where status like 'Done' and sdate between #" & dt1.Value.Date & "# and #" & dt2.Value.Date & "#", cn)
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
        LoadStockInHistory()
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
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
        sql = "Select * from vwstockin where status Like 'Done' and sdate between #" & dt1.Value.Date & "# and #" & dt2.Value.Date & "#"
        With FrmPrintStockHistory
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub
End Class