Imports Microsoft.Reporting.WinForms
Public Class FrmReceiptPaid
    Private Sub FrmReceiptPaid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvReceipt.RefreshReport()
    End Sub
    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With rvReceipt.LocalReport
                .ReportPath = "Report\RptReceiptPaid.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            da.Fill(ds.Tables("dtPrintReceipt"))

            Dim pAddress As New ReportParameter("pAddress", "Address : " & _h2)
            Dim pNumber As New ReportParameter("pNumber", "Contact Number : " & _h3)
            Dim pCustomer As New ReportParameter("pCustomer", "Customer : " & FrmSettle.txtName.Text)
            Dim pTin As New ReportParameter("pTin", "TIN Number : " & FrmSettle.txtTinNumber.Text)
            Dim pCaddress As New ReportParameter("pCaddress", "Address : " & FrmSettle.txtAddress.Text)
            Dim pTransno As New ReportParameter("pTransno", "Transaction Number : " & FrmPOS.lblTransNo.Text)
            Dim pCashier As New ReportParameter("pCashier", "Prepared by : " & str_name)
            Dim pDate As New ReportParameter("pDate", "Date of purchase : " & Now.ToString("dddd, d MMM yyyy"))

            Dim pSubtotal As New ReportParameter("pSubtotal", Format((CDbl(FrmSettle.txtBill.Text) + CDbl(FrmPOS.lblDiscount.Text)), "#,##0.00"))
            Dim pLess As New ReportParameter("pLess", Format(CDbl(FrmPOS.lblDiscount.Text), "#,##0.00"))
            Dim pGrandTotal As New ReportParameter("pGrandTotal", Format(CDbl(FrmSettle.txtBill.Text), "#,##0.00"))

            rvReceipt.LocalReport.SetParameters(pAddress)
            rvReceipt.LocalReport.SetParameters(pNumber)
            rvReceipt.LocalReport.SetParameters(pCustomer)
            rvReceipt.LocalReport.SetParameters(pTin)
            rvReceipt.LocalReport.SetParameters(pCaddress)
            rvReceipt.LocalReport.SetParameters(pTransno)
            rvReceipt.LocalReport.SetParameters(pCashier)
            rvReceipt.LocalReport.SetParameters(pDate)
            rvReceipt.LocalReport.SetParameters(pSubtotal)
            rvReceipt.LocalReport.SetParameters(pLess)
            rvReceipt.LocalReport.SetParameters(pGrandTotal)

            rptds = New ReportDataSource("DataSet1", ds.Tables("dtPrintReceipt"))
            rvReceipt.LocalReport.DataSources.Add(rptds)
            rvReceipt.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'rvReceipt.ZoomMode = ZoomMode.Percent
            'rvReceipt.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class