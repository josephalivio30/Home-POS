Imports Microsoft.Reporting.WinForms
Public Class FrmPrintLogHistory
    Private Sub FrmLogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvLogHistory.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvLogHistory.LocalReport
                .ReportPath = "Report\RptLogHistory.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtLogHistory"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "LOG HISTORY REPORT DATE COVERED (" & FrmRLogHistory.Ldt1.Value.ToShortDateString & " - " & FrmRLogHistory.Ldt2.Value.ToShortDateString & ")")

            RvLogHistory.LocalReport.SetParameters(shopname)
            RvLogHistory.LocalReport.SetParameters(p1)
            RvLogHistory.LocalReport.SetParameters(p2)
            RvLogHistory.LocalReport.SetParameters(p3)
            RvLogHistory.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtLogHistory"))
            RvLogHistory.LocalReport.DataSources.Add(rptds)
            RvLogHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvLogHistory.ZoomMode = ZoomMode.Percent
            RvLogHistory.ZoomPercent = 100
            RvLogHistory.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class