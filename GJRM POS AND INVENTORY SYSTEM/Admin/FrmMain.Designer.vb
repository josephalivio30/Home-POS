<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.pDashBoard = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStockOnHand = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTotalProduct = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCriticalItem = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDailySales = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.panelStock = New System.Windows.Forms.Panel()
        Me.btnInventoryList = New System.Windows.Forms.Button()
        Me.btnStockAdjustment = New System.Windows.Forms.Button()
        Me.btnStockInHistory = New System.Windows.Forms.Button()
        Me.btnStockEntry = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelManage = New System.Windows.Forms.Panel()
        Me.btnCustomer = New System.Windows.Forms.Button()
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
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelOutput.Size = New System.Drawing.Size(1076, 772)
        Me.panelOutput.TabIndex = 19
        '
        'pDashBoard
        '
        Me.pDashBoard.BackColor = System.Drawing.Color.Silver
        Me.pDashBoard.Controls.Add(Me.Chart1)
        Me.pDashBoard.Controls.Add(Me.Panel3)
        Me.pDashBoard.Controls.Add(Me.Panel17)
        Me.pDashBoard.Controls.Add(Me.Panel16)
        Me.pDashBoard.Controls.Add(Me.Panel18)
        Me.pDashBoard.Location = New System.Drawing.Point(5, 58)
        Me.pDashBoard.Name = "pDashBoard"
        Me.pDashBoard.Size = New System.Drawing.Size(1064, 634)
        Me.pDashBoard.TabIndex = 2
        '
        'Chart1
        '
        Me.Chart1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.Silver
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Silver
        Me.Chart1.BorderlineColor = System.Drawing.Color.Silver
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Silver
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Silver
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Silver
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(72, 147)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(772, 459)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblStockOnHand)
        Me.Panel3.Location = New System.Drawing.Point(534, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 109)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(70, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1, 90)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(86, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 38)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total stock on hand recorded in the database"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(86, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "STOCK ON HAND"
        '
        'lblStockOnHand
        '
        Me.lblStockOnHand.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockOnHand.ForeColor = System.Drawing.Color.White
        Me.lblStockOnHand.Location = New System.Drawing.Point(83, 16)
        Me.lblStockOnHand.Name = "lblStockOnHand"
        Me.lblStockOnHand.Size = New System.Drawing.Size(174, 36)
        Me.lblStockOnHand.TabIndex = 1
        Me.lblStockOnHand.Text = "0.0"
        Me.lblStockOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel17.Controls.Add(Me.GroupBox2)
        Me.Panel17.Controls.Add(Me.Label1)
        Me.Panel17.Controls.Add(Me.PictureBox2)
        Me.Panel17.Controls.Add(Me.lblTotalProduct)
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Location = New System.Drawing.Point(271, 17)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(257, 109)
        Me.Panel17.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(68, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1, 90)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total product line recorded in the database"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblTotalProduct
        '
        Me.lblTotalProduct.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProduct.ForeColor = System.Drawing.Color.White
        Me.lblTotalProduct.Location = New System.Drawing.Point(84, 15)
        Me.lblTotalProduct.Name = "lblTotalProduct"
        Me.lblTotalProduct.Size = New System.Drawing.Size(170, 36)
        Me.lblTotalProduct.TabIndex = 3
        Me.lblTotalProduct.Text = "0"
        Me.lblTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(86, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "TOTAL PRODUCT"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel16.Controls.Add(Me.GroupBox4)
        Me.Panel16.Controls.Add(Me.PictureBox5)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Controls.Add(Me.Label8)
        Me.Panel16.Controls.Add(Me.lblCriticalItem)
        Me.Panel16.Location = New System.Drawing.Point(797, 17)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(257, 109)
        Me.Panel16.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(68, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1, 90)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(86, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 38)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total critical item(s) recorded in the database"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(86, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "CRITICAL ITEM(S)"
        '
        'lblCriticalItem
        '
        Me.lblCriticalItem.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticalItem.ForeColor = System.Drawing.Color.White
        Me.lblCriticalItem.Location = New System.Drawing.Point(83, 15)
        Me.lblCriticalItem.Name = "lblCriticalItem"
        Me.lblCriticalItem.Size = New System.Drawing.Size(174, 36)
        Me.lblCriticalItem.TabIndex = 3
        Me.lblCriticalItem.Text = "0.0"
        Me.lblCriticalItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel18.Controls.Add(Me.GroupBox1)
        Me.Panel18.Controls.Add(Me.PictureBox3)
        Me.Panel18.Controls.Add(Me.Label2)
        Me.Panel18.Controls.Add(Me.Label5)
        Me.Panel18.Controls.Add(Me.lblDailySales)
        Me.Panel18.Location = New System.Drawing.Point(8, 17)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(257, 109)
        Me.Panel18.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(68, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1, 90)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(86, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total daily sales recorded in the database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(86, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DAILY SALES"
        '
        'lblDailySales
        '
        Me.lblDailySales.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailySales.ForeColor = System.Drawing.Color.White
        Me.lblDailySales.Location = New System.Drawing.Point(83, 15)
        Me.lblDailySales.Name = "lblDailySales"
        Me.lblDailySales.Size = New System.Drawing.Size(174, 36)
        Me.lblDailySales.TabIndex = 1
        Me.lblDailySales.Text = "0.00"
        Me.lblDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Gray
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
        Me.Panel1.Size = New System.Drawing.Size(297, 772)
        Me.Panel1.TabIndex = 20
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
        Me.btnAccount.Location = New System.Drawing.Point(0, 1073)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccount.Size = New System.Drawing.Size(280, 45)
        Me.btnAccount.TabIndex = 24
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
        Me.btnSetting.Location = New System.Drawing.Point(0, 1028)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSetting.Size = New System.Drawing.Size(280, 45)
        Me.btnSetting.TabIndex = 23
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
        Me.panelDebt.Location = New System.Drawing.Point(0, 937)
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
        Me.btnHDebt.TabIndex = 22
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
        Me.btnRDebt.TabIndex = 21
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
        Me.btnDebt.Location = New System.Drawing.Point(0, 892)
        Me.btnDebt.Name = "btnDebt"
        Me.btnDebt.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDebt.Size = New System.Drawing.Size(280, 45)
        Me.btnDebt.TabIndex = 20
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
        Me.panelSales.Controls.Add(Me.btnSales)
        Me.panelSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSales.Location = New System.Drawing.Point(0, 617)
        Me.panelSales.Name = "panelSales"
        Me.panelSales.Size = New System.Drawing.Size(280, 275)
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
        Me.btnAuditTrail.Location = New System.Drawing.Point(0, 225)
        Me.btnAuditTrail.Name = "btnAuditTrail"
        Me.btnAuditTrail.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAuditTrail.Size = New System.Drawing.Size(280, 45)
        Me.btnAuditTrail.TabIndex = 19
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
        Me.btnLogHistory.Location = New System.Drawing.Point(0, 180)
        Me.btnLogHistory.Name = "btnLogHistory"
        Me.btnLogHistory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLogHistory.Size = New System.Drawing.Size(280, 45)
        Me.btnLogHistory.TabIndex = 18
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
        Me.btnExpense.Location = New System.Drawing.Point(0, 135)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnExpense.Size = New System.Drawing.Size(280, 45)
        Me.btnExpense.TabIndex = 17
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
        Me.btnBestSelling.Location = New System.Drawing.Point(0, 90)
        Me.btnBestSelling.Name = "btnBestSelling"
        Me.btnBestSelling.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBestSelling.Size = New System.Drawing.Size(280, 45)
        Me.btnBestSelling.TabIndex = 16
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
        Me.btnRefund.Location = New System.Drawing.Point(0, 45)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRefund.Size = New System.Drawing.Size(280, 45)
        Me.btnRefund.TabIndex = 15
        Me.btnRefund.Text = "   CANCELLED ORDER"
        Me.btnRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefund.UseVisualStyleBackColor = False
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
        Me.btnSales.TabIndex = 13
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
        Me.btnRecord.Location = New System.Drawing.Point(0, 572)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRecord.Size = New System.Drawing.Size(280, 45)
        Me.btnRecord.TabIndex = 12
        Me.btnRecord.Text = "   SALES && RECORD"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'panelStock
        '
        Me.panelStock.BackColor = System.Drawing.Color.Gray
        Me.panelStock.Controls.Add(Me.btnInventoryList)
        Me.panelStock.Controls.Add(Me.btnStockAdjustment)
        Me.panelStock.Controls.Add(Me.btnStockInHistory)
        Me.panelStock.Controls.Add(Me.btnStockEntry)
        Me.panelStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelStock.Location = New System.Drawing.Point(0, 385)
        Me.panelStock.Name = "panelStock"
        Me.panelStock.Size = New System.Drawing.Size(280, 187)
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
        Me.btnInventoryList.Location = New System.Drawing.Point(0, 135)
        Me.btnInventoryList.Name = "btnInventoryList"
        Me.btnInventoryList.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnInventoryList.Size = New System.Drawing.Size(280, 45)
        Me.btnInventoryList.TabIndex = 11
        Me.btnInventoryList.Text = "   STOCK INVENTORY"
        Me.btnInventoryList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventoryList.UseVisualStyleBackColor = False
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
        Me.btnStockAdjustment.TabIndex = 10
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
        Me.btnStockInHistory.TabIndex = 9
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
        Me.btnStockEntry.TabIndex = 8
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
        Me.btnStock.Location = New System.Drawing.Point(0, 340)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStock.Size = New System.Drawing.Size(280, 45)
        Me.btnStock.TabIndex = 7
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
        Me.btnLogout.Location = New System.Drawing.Point(0, 1118)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(280, 45)
        Me.btnLogout.TabIndex = 25
        Me.btnLogout.Text = "   LOGOUT"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'panelManage
        '
        Me.panelManage.BackColor = System.Drawing.Color.Transparent
        Me.panelManage.Controls.Add(Me.btnCustomer)
        Me.panelManage.Controls.Add(Me.btnVendor)
        Me.panelManage.Controls.Add(Me.btnBrand)
        Me.panelManage.Controls.Add(Me.btnCategory)
        Me.panelManage.Controls.Add(Me.btnProducts)
        Me.panelManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelManage.Location = New System.Drawing.Point(0, 111)
        Me.panelManage.Name = "panelManage"
        Me.panelManage.Size = New System.Drawing.Size(280, 229)
        Me.panelManage.TabIndex = 35
        '
        'btnCustomer
        '
        Me.btnCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCustomer.BackColor = System.Drawing.Color.Gray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 180)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(280, 45)
        Me.btnCustomer.TabIndex = 7
        Me.btnCustomer.Text = "   CUSTOMER"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = False
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
        Me.btnVendor.TabIndex = 5
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
        Me.btnBrand.TabIndex = 4
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
        Me.btnCategory.TabIndex = 3
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
        Me.btnProducts.TabIndex = 2
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
        Me.btnManage.TabIndex = 1
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
        Me.lblShopName.Size = New System.Drawing.Size(197, 23)
        Me.lblShopName.TabIndex = 0
        Me.lblShopName.Text = "SHOP NAME"
        Me.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelOutput)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelOutput.ResumeLayout(False)
        Me.pDashBoard.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblStockOnHand As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblCriticalItem As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents lblTotalProduct As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblDailySales As Label
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents btnInventoryList As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCustomer As Button
End Class
