Imports Microsoft.Reporting.WinForms
Public Class FrmPrintCancelledOrder
    Private Sub FrmPrintCancelledOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvCancelledOrder.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvCancelledOrder.LocalReport
                .ReportPath = "Report\RptCancelledOrder.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtCancelledOrder"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "CANCELLED ORDER REPORT DATE COVERED (" & FrmRCancelledOrder.Cdt1.Value.ToShortDateString & " - " & FrmRCancelledOrder.Cdt2.Value.ToShortDateString & ") CANCELLED BY : " & FrmRCancelledOrder.cboCancelledBy.Text)

            RvCancelledOrder.LocalReport.SetParameters(shopname)
            RvCancelledOrder.LocalReport.SetParameters(p1)
            RvCancelledOrder.LocalReport.SetParameters(p2)
            RvCancelledOrder.LocalReport.SetParameters(p3)
            RvCancelledOrder.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtCancelledOrder"))
            RvCancelledOrder.LocalReport.DataSources.Add(rptds)
            RvCancelledOrder.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvCancelledOrder.ZoomMode = ZoomMode.Percent
            RvCancelledOrder.ZoomPercent = 100
            RvCancelledOrder.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class