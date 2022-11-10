Imports Microsoft.Reporting.WinForms
Public Class frmPrintReceipt1
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvReceipt.RefreshReport()
    End Sub

    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With rvReceipt.LocalReport
                .ReportPath = "Report\rptReceipt.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtPrintReceipt"))

            Dim pCashier As New ReportParameter("pCashier", "CASHIER NAME : " & str_name)
            Dim pDate As New ReportParameter("pDate", "DATE | TIME : " & Now)
            Dim pTransno As New ReportParameter("pTransno", "TRANSACTION NO : " & FrmPOS.lblTransNo.Text)
            Dim pDisc As New ReportParameter("pDisc", Format(CDbl(frmPOS.lblDiscount.Text), "#,##0.00"))
            Dim pBill As New ReportParameter("pBill", frmSettle.txtBill.Text)
            'Dim pBnktransfer As New ReportParameter("pBnktransfer", Format(CDbl(frmSettle.txtBankTransfer.Text), "#,##0.00"))
            'Dim pGcash As New ReportParameter("pGcash", Format(CDbl(frmSettle.txtGcash.Text), "#,##0.00"))
            'Dim pCash As New ReportParameter("pCash", Format(CDbl(frmSettle.txtCash.Text), "#,##0.00"))
            'Dim pChange As New ReportParameter("pChange", frmSettle.txtChange.Text)

            rvReceipt.LocalReport.SetParameters(pCashier)
            rvReceipt.LocalReport.SetParameters(pDate)
            rvReceipt.LocalReport.SetParameters(pTransno)
            rvReceipt.LocalReport.SetParameters(pDisc)
            rvReceipt.LocalReport.SetParameters(pBill)
            'rvReceipt.LocalReport.SetParameters(pBnktransfer)
            'rvReceipt.LocalReport.SetParameters(pGcash)
            'rvReceipt.LocalReport.SetParameters(pCash)
            'rvReceipt.LocalReport.SetParameters(pChange)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtPrintReceipt"))
            rvReceipt.LocalReport.DataSources.Add(rptds)
            rvReceipt.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rvReceipt.ZoomMode = ZoomMode.Percent
            rvReceipt.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmReceipt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class