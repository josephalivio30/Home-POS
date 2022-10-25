Imports Microsoft.Reporting.WinForms
Public Class FrmPrintAgentSales
    Private Sub FrmPrintAgentSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvAgentSales.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvAgentSales.LocalReport
                .ReportPath = "Report\RptAgentSales.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtSalesRecord"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "AGENT SALES REPORT DATE COVERED (" & FrmAgentSales.Adt1.Value.ToShortDateString & " - " & FrmAgentSales.Adt2.Value.ToShortDateString & ") AGENT : " & FrmAgentSales.cboAgent.Text)

            RvAgentSales.LocalReport.SetParameters(shopname)
            RvAgentSales.LocalReport.SetParameters(p1)
            RvAgentSales.LocalReport.SetParameters(p2)
            RvAgentSales.LocalReport.SetParameters(p3)
            RvAgentSales.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtSalesRecord"))
            RvAgentSales.LocalReport.DataSources.Add(rptds)
            RvAgentSales.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvAgentSales.ZoomMode = ZoomMode.Percent
            RvAgentSales.ZoomPercent = 100
            RvAgentSales.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class