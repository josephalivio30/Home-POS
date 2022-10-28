Imports Microsoft.Reporting.WinForms
Public Class FrmPrintSales
    Private Sub FrmPrintSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.RvSales.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvSales.LocalReport
                .ReportPath = "Report\RptSales.rdlc"
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
            Dim pHeader As New ReportParameter("pHeader", "SALES REPORT DATE COVERED (" & FrmRSales.Sdt1.Value.ToShortDateString & " - " & FrmRSales.Sdt2.Value.ToShortDateString & ") CASHIER : " & FrmRSales.cboCashier.Text)

            RvSales.LocalReport.SetParameters(shopname)
            RvSales.LocalReport.SetParameters(p1)
            RvSales.LocalReport.SetParameters(p2)
            RvSales.LocalReport.SetParameters(p3)
            RvSales.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtSalesRecord"))
            RvSales.LocalReport.DataSources.Add(rptds)
            RvSales.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvSales.ZoomMode = ZoomMode.Percent
            RvSales.ZoomPercent = 100
            RvSales.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmPrintSales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class