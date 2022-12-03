Imports System.Windows.Forms.DataVisualization.Charting
Public Class FrmMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        panelManage.Visible = False
        panelStock.Visible = False
        panelSales.Visible = False
        panelDebt.Visible = False
        NotifyCriticalItems()
        NotifyCollection()
        'LoadChart()
    End Sub
    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Top = 0
        Me.Left = 0

        pDashBoard.Left = (panelOutput.Width - pDashBoard.Width) / 2
        Chart1.Left = (panelOutput.Width - pDashBoard.Width) / 2
    End Sub
    Sub hideSubMenu()
        If panelSales.Visible = True Then
            panelSales.Visible = False
        End If
        If panelDebt.Visible = True Then
            panelDebt.Visible = False
        End If
        If panelManage.Visible = True Then
            panelManage.Visible = False
        End If
        If panelStock.Visible = True Then
            panelStock.Visible = False
        End If
    End Sub
    Sub ShowSubMenu(ByVal subMenu As Panel)
        If (subMenu.Visible = False) Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        ShowSubMenu(panelManage)
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        ShowSubMenu(panelStock)
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        ShowSubMenu(panelSales)
    End Sub

    Private Sub btnDebt_Click(sender As Object, e As EventArgs) Handles btnDebt.Click
        ShowSubMenu(panelDebt)
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        With FrmBrandList
            .LoadBrand()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        With FrmCategoryList
            .LoadCategory()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        With FrmProductList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmProductList)
            .BringToFront()
            .LoadProducts()
            .LoadCboCategory()
            .Show()
        End With

    End Sub

    Private Sub btnStockEntry_Click(sender As Object, e As EventArgs) Handles btnStockEntry.Click
        With FrmStockIn
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmStockIn)
            .BringToFront()
            .LoadStockIn()
            .LoadVendor()
            .Show()
        End With
    End Sub

    Private Sub btnStockInHistory_Click(sender As Object, e As EventArgs) Handles btnStockInHistory.Click
        With FrmStockInHistory
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmStockInHistory)
            .BringToFront()
            .LoadStockInHistory()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Do you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
            LogHistory("OUT")
            FrmLogin.txtUser.Clear()
            FrmLogin.txtPass.Clear()
            FrmLogin.txtUser.Focus()
        End If
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With FrmRSales
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRSales)
            .BringToFront()
            .LoadCashier()
            .LoadSale()
            .Show()
        End With
    End Sub

    Private Sub btnBestSelling_Click(sender As Object, e As EventArgs) Handles btnBestSelling.Click
        With FrmBestSelling
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmBestSelling)
            .LoadBestSelling()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        With FrmRExpense
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRExpense)
            .BringToFront()
            .LoadExpense()
            .Show()
        End With
    End Sub

    Private Sub btnLogHistory_Click(sender As Object, e As EventArgs) Handles btnLogHistory.Click
        With FrmRLogHistory
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRLogHistory)
            .BringToFront()
            .LoadLogHistory()
            .Show()
        End With
    End Sub

    Private Sub btnAuditTrail_Click(sender As Object, e As EventArgs) Handles btnAuditTrail.Click
        With FrmRAuditTrail
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRAuditTrail)
            .BringToFront()
            .LoadAuditTrail()
            .Show()
        End With
    End Sub

    Private Sub btnRDebt_Click(sender As Object, e As EventArgs) Handles btnRDebt.Click
        With FrmRDebt
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRDebt)
            .BringToFront()
            .LoadDebt()
            .LoadName()
            .Show()
        End With
    End Sub

    Private Sub btnInventoryList_Click(sender As Object, e As EventArgs) Handles btnInventoryList.Click
        With FrmInventoryList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmInventoryList)
            .BringToFront()
            .LoadInventory()
            .Show()
        End With
    End Sub

    Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
        With FrmRCancelledOrder
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRCancelledOrder)
            .BringToFront()
            .LoadCancelOrder()
            .LoadCashier()
            .Show()
        End With
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        With FrmStoreSetting
            .LoadSetting()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        With FrmAccount
            .LoadAccount()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnHDebt_Click(sender As Object, e As EventArgs) Handles btnHDebt.Click
        With FrmRDebtHistory
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmRDebtHistory)
            .BringToFront()
            .LoadDebtHistory()
            .LoadName()
            .Show()
        End With
    End Sub

    Private Sub btnVendor_Click(sender As Object, e As EventArgs) Handles btnVendor.Click
        With FrmVendorList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmVendorList)
            .BringToFront()
            .LoadVendor()
            .Show()
        End With
    End Sub
    'Sub LoadChart()
    '    Try
    '        cn.Open()
    '        Dim sql As String = "Select Year([sdate]) As sYear, IIf(IsNull(sum(totalbill)), '0.00', sum(totalbill)) as total FROM tblsales where remarks Like 'Paid' GROUP BY Year([sdate])"
    '        da = New OleDb.OleDbDataAdapter(sql, cn)
    '        Dim ds As New DataSet

    '        da.Fill(ds, "Sales")
    '        Chart1.DataSource = ds.Tables("Sales")
    '        Dim series1 As Series
    '        series1 = Chart1.Series("Series1")
    '        series1.ChartType = SeriesChartType.Doughnut

    '        series1.Name = "SALES"

    '        Dim chart = Chart1
    '        chart.Series(series1.Name).XValueMember = "sYear"
    '        chart.Series(series1.Name).YValueMembers = "total"
    '        chart.Series(0).IsValueShownAsLabel = True
    '        cn.Close()
    '    Catch ex As Exception
    '        cn.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub

    Private Sub btnStockAdjustment_Click(sender As Object, e As EventArgs) Handles btnStockAdjustment.Click
        With FrmAdjustment
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmAdjustment)
            .BringToFront()
            .LoadProducts()
            .txtUser.Text = str_user
            .RandomRefNo()
            .Show()
        End With
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        With FrmCustomerList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            panelOutput.Controls.Add(FrmCustomerList)
            .BringToFront()
            .LoadCustomer()
            .Show()
        End With
    End Sub
End Class
