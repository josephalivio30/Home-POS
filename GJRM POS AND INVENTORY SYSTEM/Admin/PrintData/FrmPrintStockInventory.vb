Imports Microsoft.Reporting.WinForms
Public Class FrmPrintStockInventory
    Private Sub FrmPrintStockInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvInventory.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With RvInventory.LocalReport
                .ReportPath = "Report\RptStockInventory.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtStockInventory"))

            Dim shopname As New ReportParameter("shopname", _shopname)
            Dim p1 As New ReportParameter("h1", _h1)
            Dim p2 As New ReportParameter("h2", _h2)
            Dim p3 As New ReportParameter("h3", _h3)
            Dim pHeader As New ReportParameter("pHeader", FrmInventoryList.cboList.Text.ToUpper & " REPORT")

            RvInventory.LocalReport.SetParameters(shopname)
            RvInventory.LocalReport.SetParameters(p1)
            RvInventory.LocalReport.SetParameters(p2)
            RvInventory.LocalReport.SetParameters(p3)
            RvInventory.LocalReport.SetParameters(pHeader)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtStockInventory"))
            RvInventory.LocalReport.DataSources.Add(rptds)
            RvInventory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RvInventory.ZoomMode = ZoomMode.Percent
            RvInventory.ZoomPercent = 100
            RvInventory.MaximumSize = DefaultMaximumSize
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class