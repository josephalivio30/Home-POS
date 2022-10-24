<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.pDashBoard = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWeeklySales = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblMonthlySales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.lblTotalProduct = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lblDailySales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSql = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.panelDebt = New System.Windows.Forms.Panel()
        Me.btnHDebt = New System.Windows.Forms.Button()
        Me.btnRDebt = New System.Windows.Forms.Button()
        Me.btnDebt = New System.Windows.Forms.Button()
        Me.panelSales = New System.Windows.Forms.Panel()
        Me.btnAuditTrail = New System.Windows.Forms.Button()
        Me.btnLogHistory = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.btnBestSelling = New System.Windows.Forms.Button()
        Me.btnRefund = New System.Windows.Forms.Button()
        Me.btnAgentSales = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.panelStock = New System.Windows.Forms.Panel()
        Me.btnInventoryList = New System.Windows.Forms.Button()
        Me.btnCriticalStock = New System.Windows.Forms.Button()
        Me.btnStockAdjustment = New System.Windows.Forms.Button()
        Me.btnStockInHistory = New System.Windows.Forms.Button()
        Me.btnStockEntry = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelManage = New System.Windows.Forms.Panel()
        Me.btnAgent = New System.Windows.Forms.Button()
        Me.btnVendor = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.panelOutput.SuspendLayout()
        Me.pDashBoard.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelDebt.SuspendLayout()
        Me.panelSales.SuspendLayout()
        Me.panelStock.SuspendLayout()
        Me.panelManage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelOutput
        '
        Me.panelOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelOutput.BackColor = System.Drawing.Color.Silver
        Me.panelOutput.Controls.Add(Me.pDashBoard)
        Me.panelOutput.Location = New System.Drawing.Point(296, 0)
        Me.panelOutput.Name = "panelOutput"
        Me.panelOutput.Size = New System.Drawing.Size(1076, 892)
        Me.panelOutput.TabIndex = 19
        '
        'pDashBoard
        '
        Me.pDashBoard.Controls.Add(Me.Panel3)
        Me.pDashBoard.Controls.Add(Me.Panel16)
        Me.pDashBoard.Controls.Add(Me.Panel17)
        Me.pDashBoard.Controls.Add(Me.Panel18)
        Me.pDashBoard.Location = New System.Drawing.Point(5, 58)
        Me.pDashBoard.Name = "pDashBoard"
        Me.pDashBoard.Size = New System.Drawing.Size(1064, 141)
        Me.pDashBoard.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblWeeklySales)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(534, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 109)
        Me.Panel3.TabIndex = 2
        '
        'lblWeeklySales
        '
        Me.lblWeeklySales.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklySales.ForeColor = System.Drawing.Color.White
        Me.lblWeeklySales.Location = New System.Drawing.Point(0, 0)
        Me.lblWeeklySales.Name = "lblWeeklySales"
        Me.lblWeeklySales.Size = New System.Drawing.Size(254, 52)
        Me.lblWeeklySales.TabIndex = 1
        Me.lblWeeklySales.Text = "0.00"
        Me.lblWeeklySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "WEEKLY SALES"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel16.Controls.Add(Me.lblMonthlySales)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Location = New System.Drawing.Point(797, 17)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(257, 109)
        Me.Panel16.TabIndex = 2
        '
        'lblMonthlySales
        '
        Me.lblMonthlySales.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySales.ForeColor = System.Drawing.Color.White
        Me.lblMonthlySales.Location = New System.Drawing.Point(7, 0)
        Me.lblMonthlySales.Name = "lblMonthlySales"
        Me.lblMonthlySales.Size = New System.Drawing.Size(250, 52)
        Me.lblMonthlySales.TabIndex = 3
        Me.lblMonthlySales.Text = "0.00"
        Me.lblMonthlySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "MONTHLY SALES"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel17.Controls.Add(Me.lblTotalProduct)
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Location = New System.Drawing.Point(8, 17)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(257, 109)
        Me.Panel17.TabIndex = 1
        '
        'lblTotalProduct
        '
        Me.lblTotalProduct.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProduct.ForeColor = System.Drawing.Color.White
        Me.lblTotalProduct.Location = New System.Drawing.Point(7, 0)
        Me.lblTotalProduct.Name = "lblTotalProduct"
        Me.lblTotalProduct.Size = New System.Drawing.Size(247, 52)
        Me.lblTotalProduct.TabIndex = 3
        Me.lblTotalProduct.Text = "0"
        Me.lblTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "TOTAL PRODUCT"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel18.Controls.Add(Me.lblDailySales)
        Me.Panel18.Controls.Add(Me.Label2)
        Me.Panel18.Location = New System.Drawing.Point(271, 17)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(257, 109)
        Me.Panel18.TabIndex = 0
        '
        'lblDailySales
        '
        Me.lblDailySales.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailySales.ForeColor = System.Drawing.Color.White
        Me.lblDailySales.Location = New System.Drawing.Point(0, 0)
        Me.lblDailySales.Name = "lblDailySales"
        Me.lblDailySales.Size = New System.Drawing.Size(254, 52)
        Me.lblDailySales.TabIndex = 1
        Me.lblDailySales.Text = "0.00"
        Me.lblDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DAILY SALES"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnSql)
        Me.Panel1.Controls.Add(Me.btnAccount)
        Me.Panel1.Controls.Add(Me.btnSetting)
        Me.Panel1.Controls.Add(Me.panelDebt)
        Me.Panel1.Controls.Add(Me.btnDebt)
        Me.Panel1.Controls.Add(Me.panelSales)
        Me.Panel1.Controls.Add(Me.btnRecord)
        Me.Panel1.Controls.Add(Me.panelStock)
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.panelManage)
        Me.Panel1.Controls.Add(Me.btnManage)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 892)
        Me.Panel1.TabIndex = 20
        '
        'btnSql
        '
        Me.btnSql.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSql.BackColor = System.Drawing.Color.Gray
        Me.btnSql.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSql.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSql.FlatAppearance.BorderSize = 0
        Me.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSql.ForeColor = System.Drawing.Color.White
        Me.btnSql.Image = CType(resources.GetObject("btnSql.Image"), System.Drawing.Image)
        Me.btnSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSql.Location = New System.Drawing.Point(0, 1196)
        Me.btnSql.Name = "btnSql"
        Me.btnSql.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSql.Size = New System.Drawing.Size(280, 45)
        Me.btnSql.TabIndex = 46
        Me.btnSql.Text = "   RETREIVE && RESTORE DATA"
        Me.btnSql.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSql.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSql.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAccount.BackColor = System.Drawing.Color.Gray
        Me.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.Image = CType(resources.GetObject("btnAccount.Image"), System.Drawing.Image)
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(0, 1151)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccount.Size = New System.Drawing.Size(280, 45)
        Me.btnAccount.TabIndex = 48
        Me.btnAccount.Text = "  ACCOUNT"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSetting.BackColor = System.Drawing.Color.Gray
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 1106)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSetting.Size = New System.Drawing.Size(280, 45)
        Me.btnSetting.TabIndex = 47
        Me.btnSetting.Text = "   STORE SETTINGS "
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'panelDebt
        '
        Me.panelDebt.Controls.Add(Me.btnHDebt)
        Me.panelDebt.Controls.Add(Me.btnRDebt)
        Me.panelDebt.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelDebt.Location = New System.Drawing.Point(0, 1015)
        Me.panelDebt.Name = "panelDebt"
        Me.panelDebt.Size = New System.Drawing.Size(280, 91)
        Me.panelDebt.TabIndex = 45
        '
        'btnHDebt
        '
        Me.btnHDebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHDebt.BackColor = System.Drawing.Color.Gray
        Me.btnHDebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHDebt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHDebt.FlatAppearance.BorderSize = 0
        Me.btnHDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHDebt.ForeColor = System.Drawing.Color.White
        Me.btnHDebt.Image = CType(resources.GetObject("btnHDebt.Image"), System.Drawing.Image)
        Me.btnHDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHDebt.Location = New System.Drawing.Point(0, 45)
        Me.btnHDebt.Name = "btnHDebt"
        Me.btnHDebt.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnHDebt.Size = New System.Drawing.Size(280, 45)
        Me.btnHDebt.TabIndex = 44
        Me.btnHDebt.Text = "   DEBT HISTORY"
        Me.btnHDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHDebt.UseVisualStyleBackColor = False
        '
        'btnRDebt
        '
        Me.btnRDebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRDebt.BackColor = System.Drawing.Color.Gray
        Me.btnRDebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDebt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRDebt.FlatAppearance.BorderSize = 0
        Me.btnRDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRDebt.ForeColor = System.Drawing.Color.White
        Me.btnRDebt.Image = CType(resources.GetObject("btnRDebt.Image"), System.Drawing.Image)
        Me.btnRDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDebt.Location = New System.Drawing.Point(0, 0)
        Me.btnRDebt.Name = "btnRDebt"
        Me.btnRDebt.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRDebt.Size = New System.Drawing.Size(280, 45)
        Me.btnRDebt.TabIndex = 43
        Me.btnRDebt.Text = "   DEBT REPORT"
        Me.btnRDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRDebt.UseVisualStyleBackColor = False
        '
        'btnDebt
        '
        Me.btnDebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDebt.BackColor = System.Drawing.Color.Gray
        Me.btnDebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDebt.FlatAppearance.BorderSize = 0
        Me.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebt.ForeColor = System.Drawing.Color.White
        Me.btnDebt.Image = CType(resources.GetObject("btnDebt.Image"), System.Drawing.Image)
        Me.btnDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDebt.Location = New System.Drawing.Point(0, 970)
        Me.btnDebt.Name = "btnDebt"
        Me.btnDebt.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDebt.Size = New System.Drawing.Size(280, 45)
        Me.btnDebt.TabIndex = 44
        Me.btnDebt.Text = "   DEBT"
        Me.btnDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDebt.UseVisualStyleBackColor = False
        '
        'panelSales
        '
        Me.panelSales.BackColor = System.Drawing.Color.Gray
        Me.panelSales.Controls.Add(Me.btnAuditTrail)
        Me.panelSales.Controls.Add(Me.btnLogHistory)
        Me.panelSales.Controls.Add(Me.btnExpense)
        Me.panelSales.Controls.Add(Me.btnBestSelling)
        Me.panelSales.Controls.Add(Me.btnRefund)
        Me.panelSales.Controls.Add(Me.btnAgentSales)
        Me.panelSales.Controls.Add(Me.btnSales)
        Me.panelSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSales.Location = New System.Drawing.Point(0, 660)
        Me.panelSales.Name = "panelSales"
        Me.panelSales.Size = New System.Drawing.Size(280, 310)
        Me.panelSales.TabIndex = 39
        '
        'btnAuditTrail
        '
        Me.btnAuditTrail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAuditTrail.BackColor = System.Drawing.Color.Gray
        Me.btnAuditTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuditTrail.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAuditTrail.FlatAppearance.BorderSize = 0
        Me.btnAuditTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditTrail.ForeColor = System.Drawing.Color.White
        Me.btnAuditTrail.Image = CType(resources.GetObject("btnAuditTrail.Image"), System.Drawing.Image)
        Me.btnAuditTrail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditTrail.Location = New System.Drawing.Point(0, 270)
        Me.btnAuditTrail.Name = "btnAuditTrail"
        Me.btnAuditTrail.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAuditTrail.Size = New System.Drawing.Size(280, 45)
        Me.btnAuditTrail.TabIndex = 42
        Me.btnAuditTrail.Text = "   AUDIT TRAIL"
        Me.btnAuditTrail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditTrail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAuditTrail.UseVisualStyleBackColor = False
        '
        'btnLogHistory
        '
        Me.btnLogHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogHistory.BackColor = System.Drawing.Color.Gray
        Me.btnLogHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogHistory.FlatAppearance.BorderSize = 0
        Me.btnLogHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogHistory.ForeColor = System.Drawing.Color.White
        Me.btnLogHistory.Image = CType(resources.GetObject("btnLogHistory.Image"), System.Drawing.Image)
        Me.btnLogHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogHistory.Location = New System.Drawing.Point(0, 225)
        Me.btnLogHistory.Name = "btnLogHistory"
        Me.btnLogHistory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLogHistory.Size = New System.Drawing.Size(280, 45)
        Me.btnLogHistory.TabIndex = 41
        Me.btnLogHistory.Text = "   LOG HISTORY"
        Me.btnLogHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogHistory.UseVisualStyleBackColor = False
        '
        'btnExpense
        '
        Me.btnExpense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExpense.BackColor = System.Drawing.Color.Gray
        Me.btnExpense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpense.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExpense.FlatAppearance.BorderSize = 0
        Me.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpense.ForeColor = System.Drawing.Color.White
        Me.btnExpense.Image = CType(resources.GetObject("btnExpense.Image"), System.Drawing.Image)
        Me.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpense.Location = New System.Drawing.Point(0, 180)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnExpense.Size = New System.Drawing.Size(280, 45)
        Me.btnExpense.TabIndex = 39
        Me.btnExpense.Text = "   EXPENSES"
        Me.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpense.UseVisualStyleBackColor = False
        '
        'btnBestSelling
        '
        Me.btnBestSelling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBestSelling.BackColor = System.Drawing.Color.Gray
        Me.btnBestSelling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBestSelling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBestSelling.FlatAppearance.BorderSize = 0
        Me.btnBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestSelling.ForeColor = System.Drawing.Color.White
        Me.btnBestSelling.Image = CType(resources.GetObject("btnBestSelling.Image"), System.Drawing.Image)
        Me.btnBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestSelling.Location = New System.Drawing.Point(0, 135)
        Me.btnBestSelling.Name = "btnBestSelling"
        Me.btnBestSelling.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBestSelling.Size = New System.Drawing.Size(280, 45)
        Me.btnBestSelling.TabIndex = 38
        Me.btnBestSelling.Text = "   BEST SELLING"
        Me.btnBestSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBestSelling.UseVisualStyleBackColor = False
        '
        'btnRefund
        '
        Me.btnRefund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRefund.BackColor = System.Drawing.Color.Gray
        Me.btnRefund.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefund.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRefund.FlatAppearance.BorderSize = 0
        Me.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefund.ForeColor = System.Drawing.Color.White
        Me.btnRefund.Image = CType(resources.GetObject("btnRefund.Image"), System.Drawing.Image)
        Me.btnRefund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefund.Location = New System.Drawing.Point(0, 90)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRefund.Size = New System.Drawing.Size(280, 45)
        Me.btnRefund.TabIndex = 43
        Me.btnRefund.Text = "   CANCELLED ORDER"
        Me.btnRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefund.UseVisualStyleBackColor = False
        '
        'btnAgentSales
        '
        Me.btnAgentSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgentSales.BackColor = System.Drawing.Color.Gray
        Me.btnAgentSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgentSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgentSales.FlatAppearance.BorderSize = 0
        Me.btnAgentSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgentSales.ForeColor = System.Drawing.Color.White
        Me.btnAgentSales.Image = CType(resources.GetObject("btnAgentSales.Image"), System.Drawing.Image)
        Me.btnAgentSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgentSales.Location = New System.Drawing.Point(0, 45)
        Me.btnAgentSales.Name = "btnAgentSales"
        Me.btnAgentSales.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgentSales.Size = New System.Drawing.Size(280, 45)
        Me.btnAgentSales.TabIndex = 37
        Me.btnAgentSales.Text = "   AGENT SALES"
        Me.btnAgentSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgentSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgentSales.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSales.BackColor = System.Drawing.Color.Gray
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 0)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSales.Size = New System.Drawing.Size(280, 45)
        Me.btnSales.TabIndex = 36
        Me.btnSales.Text = "   SALES "
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnRecord
        '
        Me.btnRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRecord.BackColor = System.Drawing.Color.Gray
        Me.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecord.FlatAppearance.BorderSize = 0
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.ForeColor = System.Drawing.Color.White
        Me.btnRecord.Image = CType(resources.GetObject("btnRecord.Image"), System.Drawing.Image)
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.Location = New System.Drawing.Point(0, 615)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRecord.Size = New System.Drawing.Size(280, 45)
        Me.btnRecord.TabIndex = 38
        Me.btnRecord.Text = "   SALES && RECORD"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'panelStock
        '
        Me.panelStock.BackColor = System.Drawing.Color.Gray
        Me.panelStock.Controls.Add(Me.btnInventoryList)
        Me.panelStock.Controls.Add(Me.btnCriticalStock)
        Me.panelStock.Controls.Add(Me.btnStockAdjustment)
        Me.panelStock.Controls.Add(Me.btnStockInHistory)
        Me.panelStock.Controls.Add(Me.btnStockEntry)
        Me.panelStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelStock.Location = New System.Drawing.Point(0, 387)
        Me.panelStock.Name = "panelStock"
        Me.panelStock.Size = New System.Drawing.Size(280, 228)
        Me.panelStock.TabIndex = 37
        '
        'btnInventoryList
        '
        Me.btnInventoryList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInventoryList.BackColor = System.Drawing.Color.Gray
        Me.btnInventoryList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventoryList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventoryList.FlatAppearance.BorderSize = 0
        Me.btnInventoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryList.ForeColor = System.Drawing.Color.White
        Me.btnInventoryList.Image = CType(resources.GetObject("btnInventoryList.Image"), System.Drawing.Image)
        Me.btnInventoryList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryList.Location = New System.Drawing.Point(0, 180)
        Me.btnInventoryList.Name = "btnInventoryList"
        Me.btnInventoryList.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnInventoryList.Size = New System.Drawing.Size(280, 45)
        Me.btnInventoryList.TabIndex = 33
        Me.btnInventoryList.Text = "   INVENTORY LISTS"
        Me.btnInventoryList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventoryList.UseVisualStyleBackColor = False
        '
        'btnCriticalStock
        '
        Me.btnCriticalStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCriticalStock.BackColor = System.Drawing.Color.Gray
        Me.btnCriticalStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCriticalStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCriticalStock.FlatAppearance.BorderSize = 0
        Me.btnCriticalStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCriticalStock.ForeColor = System.Drawing.Color.White
        Me.btnCriticalStock.Image = CType(resources.GetObject("btnCriticalStock.Image"), System.Drawing.Image)
        Me.btnCriticalStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCriticalStock.Location = New System.Drawing.Point(0, 135)
        Me.btnCriticalStock.Name = "btnCriticalStock"
        Me.btnCriticalStock.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCriticalStock.Size = New System.Drawing.Size(280, 45)
        Me.btnCriticalStock.TabIndex = 32
        Me.btnCriticalStock.Text = "   CRITICAL STOCKS"
        Me.btnCriticalStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCriticalStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCriticalStock.UseVisualStyleBackColor = False
        '
        'btnStockAdjustment
        '
        Me.btnStockAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStockAdjustment.BackColor = System.Drawing.Color.Gray
        Me.btnStockAdjustment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockAdjustment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockAdjustment.FlatAppearance.BorderSize = 0
        Me.btnStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockAdjustment.ForeColor = System.Drawing.Color.White
        Me.btnStockAdjustment.Image = CType(resources.GetObject("btnStockAdjustment.Image"), System.Drawing.Image)
        Me.btnStockAdjustment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockAdjustment.Location = New System.Drawing.Point(0, 90)
        Me.btnStockAdjustment.Name = "btnStockAdjustment"
        Me.btnStockAdjustment.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnStockAdjustment.Size = New System.Drawing.Size(280, 45)
        Me.btnStockAdjustment.TabIndex = 31
        Me.btnStockAdjustment.Text = "   STOCK ADJUSTMENT"
        Me.btnStockAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockAdjustment.UseVisualStyleBackColor = False
        '
        'btnStockInHistory
        '
        Me.btnStockInHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStockInHistory.BackColor = System.Drawing.Color.Gray
        Me.btnStockInHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockInHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockInHistory.FlatAppearance.BorderSize = 0
        Me.btnStockInHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockInHistory.ForeColor = System.Drawing.Color.White
        Me.btnStockInHistory.Image = CType(resources.GetObject("btnStockInHistory.Image"), System.Drawing.Image)
        Me.btnStockInHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockInHistory.Location = New System.Drawing.Point(0, 45)
        Me.btnStockInHistory.Name = "btnStockInHistory"
        Me.btnStockInHistory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnStockInHistory.Size = New System.Drawing.Size(280, 45)
        Me.btnStockInHistory.TabIndex = 30
        Me.btnStockInHistory.Text = "   STOCK IN HISTORY"
        Me.btnStockInHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockInHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockInHistory.UseVisualStyleBackColor = False
        '
        'btnStockEntry
        '
        Me.btnStockEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStockEntry.BackColor = System.Drawing.Color.Gray
        Me.btnStockEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockEntry.FlatAppearance.BorderSize = 0
        Me.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockEntry.ForeColor = System.Drawing.Color.White
        Me.btnStockEntry.Image = CType(resources.GetObject("btnStockEntry.Image"), System.Drawing.Image)
        Me.btnStockEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockEntry.Location = New System.Drawing.Point(0, 0)
        Me.btnStockEntry.Name = "btnStockEntry"
        Me.btnStockEntry.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnStockEntry.Size = New System.Drawing.Size(280, 45)
        Me.btnStockEntry.TabIndex = 28
        Me.btnStockEntry.Text = "   STOCK ENTRY"
        Me.btnStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockEntry.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStock.BackColor = System.Drawing.Color.Gray
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.ForeColor = System.Drawing.Color.White
        Me.btnStock.Image = CType(resources.GetObject("btnStock.Image"), System.Drawing.Image)
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(0, 342)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStock.Size = New System.Drawing.Size(280, 45)
        Me.btnStock.TabIndex = 36
        Me.btnStock.Text = "   STOCK"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogout.BackColor = System.Drawing.Color.Gray
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 1241)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(280, 45)
        Me.btnLogout.TabIndex = 33
        Me.btnLogout.Text = "   LOGOUT"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'panelManage
        '
        Me.panelManage.BackColor = System.Drawing.Color.Transparent
        Me.panelManage.Controls.Add(Me.btnAgent)
        Me.panelManage.Controls.Add(Me.btnVendor)
        Me.panelManage.Controls.Add(Me.btnBrand)
        Me.panelManage.Controls.Add(Me.btnCategory)
        Me.panelManage.Controls.Add(Me.btnProducts)
        Me.panelManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelManage.Location = New System.Drawing.Point(0, 111)
        Me.panelManage.Name = "panelManage"
        Me.panelManage.Size = New System.Drawing.Size(280, 231)
        Me.panelManage.TabIndex = 35
        '
        'btnAgent
        '
        Me.btnAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgent.BackColor = System.Drawing.Color.Gray
        Me.btnAgent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgent.FlatAppearance.BorderSize = 0
        Me.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgent.ForeColor = System.Drawing.Color.White
        Me.btnAgent.Image = CType(resources.GetObject("btnAgent.Image"), System.Drawing.Image)
        Me.btnAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgent.Location = New System.Drawing.Point(0, 180)
        Me.btnAgent.Name = "btnAgent"
        Me.btnAgent.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgent.Size = New System.Drawing.Size(280, 45)
        Me.btnAgent.TabIndex = 34
        Me.btnAgent.Text = "   AGENT"
        Me.btnAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgent.UseVisualStyleBackColor = False
        '
        'btnVendor
        '
        Me.btnVendor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVendor.BackColor = System.Drawing.Color.Gray
        Me.btnVendor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVendor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVendor.FlatAppearance.BorderSize = 0
        Me.btnVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendor.ForeColor = System.Drawing.Color.White
        Me.btnVendor.Image = CType(resources.GetObject("btnVendor.Image"), System.Drawing.Image)
        Me.btnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendor.Location = New System.Drawing.Point(0, 135)
        Me.btnVendor.Name = "btnVendor"
        Me.btnVendor.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnVendor.Size = New System.Drawing.Size(280, 45)
        Me.btnVendor.TabIndex = 33
        Me.btnVendor.Text = "   VENDOR"
        Me.btnVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVendor.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBrand.BackColor = System.Drawing.Color.Gray
        Me.btnBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBrand.FlatAppearance.BorderSize = 0
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrand.ForeColor = System.Drawing.Color.White
        Me.btnBrand.Image = CType(resources.GetObject("btnBrand.Image"), System.Drawing.Image)
        Me.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrand.Location = New System.Drawing.Point(0, 90)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBrand.Size = New System.Drawing.Size(280, 45)
        Me.btnBrand.TabIndex = 32
        Me.btnBrand.Text = "   BRAND"
        Me.btnBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCategory.BackColor = System.Drawing.Color.Gray
        Me.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.ForeColor = System.Drawing.Color.White
        Me.btnCategory.Image = CType(resources.GetObject("btnCategory.Image"), System.Drawing.Image)
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.Location = New System.Drawing.Point(0, 45)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCategory.Size = New System.Drawing.Size(280, 45)
        Me.btnCategory.TabIndex = 30
        Me.btnCategory.Text = "   CATEGORY"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnProducts.BackColor = System.Drawing.Color.Gray
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 0)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnProducts.Size = New System.Drawing.Size(280, 45)
        Me.btnProducts.TabIndex = 28
        Me.btnProducts.Text = "   PRODUCTS"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'btnManage
        '
        Me.btnManage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnManage.BackColor = System.Drawing.Color.Gray
        Me.btnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.ForeColor = System.Drawing.Color.White
        Me.btnManage.Image = CType(resources.GetObject("btnManage.Image"), System.Drawing.Image)
        Me.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManage.Location = New System.Drawing.Point(0, 66)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManage.Size = New System.Drawing.Size(280, 45)
        Me.btnManage.TabIndex = 27
        Me.btnManage.Text = "   MANAGE"
        Me.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManage.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblName)
        Me.Panel4.Controls.Add(Me.lblShopName)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 66)
        Me.Panel4.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 63)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(100, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(234, 15)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShopName
        '
        Me.lblShopName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopName.ForeColor = System.Drawing.Color.White
        Me.lblShopName.Location = New System.Drawing.Point(100, 17)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(166, 23)
        Me.lblShopName.TabIndex = 0
        Me.lblShopName.Text = "SHOP NAME"
        Me.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 892)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelOutput)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelOutput.ResumeLayout(False)
        Me.pDashBoard.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelDebt.ResumeLayout(False)
        Me.panelSales.ResumeLayout(False)
        Me.panelStock.ResumeLayout(False)
        Me.panelManage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelOutput As Panel
    Friend WithEvents pDashBoard As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblWeeklySales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblMonthlySales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents lblTotalProduct As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblDailySales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSql As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents panelDebt As Panel
    Friend WithEvents btnHDebt As Button
    Friend WithEvents btnRDebt As Button
    Friend WithEvents btnDebt As Button
    Friend WithEvents panelSales As Panel
    Friend WithEvents btnAuditTrail As Button
    Friend WithEvents btnLogHistory As Button
    Friend WithEvents btnExpense As Button
    Friend WithEvents btnBestSelling As Button
    Friend WithEvents btnRefund As Button
    Friend WithEvents btnAgentSales As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents panelStock As Panel
    Friend WithEvents btnStockInHistory As Button
    Friend WithEvents btnStockEntry As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents panelManage As Panel
    Friend WithEvents btnVendor As Button
    Friend WithEvents btnBrand As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnManage As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblShopName As Label
    Friend WithEvents btnStockAdjustment As Button
    Friend WithEvents btnAgent As Button
    Friend WithEvents btnCriticalStock As Button
    Friend WithEvents btnInventoryList As Button
End Class
