Public Class FrmPrintStockInventory
    Private Sub FrmPrintStockInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class