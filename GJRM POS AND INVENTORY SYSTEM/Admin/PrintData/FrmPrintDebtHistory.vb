Imports Microsoft.Reporting.WinForms
Public Class FrmPrintDebtHistory
    Private Sub FrmPrintDebtHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.RvDebtHistory.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvDebtHistory.LocalReport
                .ReportPath = "Report\RptDebtHistory.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtDebtHistory"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "DEBT HISTORY REPORT DATE COVERED (" & FrmRDebtHistory.Ddt1.Value.ToShortDateString & " - " & FrmRDebtHistory.Ddt2.Value.ToShortDateString & ") NAME : " & FrmRDebtHistory.cboName.Text)

            RvDebtHistory.LocalReport.SetParameters(shopname)
            RvDebtHistory.LocalReport.SetParameters(p1)
            RvDebtHistory.LocalReport.SetParameters(p2)
            RvDebtHistory.LocalReport.SetParameters(p3)
            RvDebtHistory.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtDebtHistory"))
            RvDebtHistory.LocalReport.DataSources.Add(rptds)
            RvDebtHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvDebtHistory.ZoomMode = ZoomMode.Percent
            RvDebtHistory.ZoomPercent = 100
            RvDebtHistory.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmPrintDebtHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class