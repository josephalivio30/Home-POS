Imports Microsoft.Reporting.WinForms
Public Class FrmPrintStockHistory
    Private Sub FrmPrintStockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.RvStockHistory.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvStockHistory.LocalReport
                .ReportPath = "Report\RptStockHistory.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtStockHistory"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "STOCK HISTORY REPORT DATE COVERED (" & FrmStockInHistory.dt1.Value.ToShortDateString & " - " & FrmStockInHistory.dt2.Value.ToShortDateString & ")")

            RvStockHistory.LocalReport.SetParameters(shopname)
            RvStockHistory.LocalReport.SetParameters(p1)
            RvStockHistory.LocalReport.SetParameters(p2)
            RvStockHistory.LocalReport.SetParameters(p3)
            RvStockHistory.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtStockHistory"))
            RvStockHistory.LocalReport.DataSources.Add(rptds)
            RvStockHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvStockHistory.ZoomMode = ZoomMode.Percent
            RvStockHistory.ZoomPercent = 100
            RvStockHistory.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmPrintStockHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class