Imports Microsoft.Reporting.WinForms
Public Class FrmPrintBestSelling
    Private Sub FrmBestSelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.RvBestSelling.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvBestSelling.LocalReport
                .ReportPath = "Report\RptBestSelling.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtBestSelling"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "BEST SELLING REPORT DATE COVERED (" & FrmRBestSelling.Bdt1.Value.ToShortDateString & " - " & FrmRBestSelling.Bdt2.Value.ToShortDateString & ")")

            RvBestSelling.LocalReport.SetParameters(shopname)
            RvBestSelling.LocalReport.SetParameters(p1)
            RvBestSelling.LocalReport.SetParameters(p2)
            RvBestSelling.LocalReport.SetParameters(p3)
            RvBestSelling.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtBestSelling"))
            RvBestSelling.LocalReport.DataSources.Add(rptds)
            RvBestSelling.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvBestSelling.ZoomMode = ZoomMode.Percent
            RvBestSelling.ZoomPercent = 100
            RvBestSelling.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmPrintBestSelling_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class