Imports Microsoft.Reporting.WinForms
Public Class FrmPrintExpense

    Private Sub FrmPrintExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Me.RvExpense.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvExpense.LocalReport
                .ReportPath = "Report\RptExpense.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtExpense"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", "EXPENSE REPORT DATE COVERED (" & FrmRExpense.Edt1.Value.ToShortDateString & " - " & FrmRExpense.Edt2.Value.ToShortDateString & ")")

            RvExpense.LocalReport.SetParameters(shopname)
            RvExpense.LocalReport.SetParameters(p1)
            RvExpense.LocalReport.SetParameters(p2)
            RvExpense.LocalReport.SetParameters(p3)
            RvExpense.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtExpense"))
            RvExpense.LocalReport.DataSources.Add(rptds)
            RvExpense.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvExpense.ZoomMode = ZoomMode.Percent
            RvExpense.ZoomPercent = 100
            RvExpense.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmPrintExpense_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class