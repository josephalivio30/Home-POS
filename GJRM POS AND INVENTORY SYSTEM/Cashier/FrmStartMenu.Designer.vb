<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStartMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStartMenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtStartingCash = New MetroFramework.Controls.MetroTextBox()
        Me.txtDiscount = New MetroFramework.Controls.MetroTextBox()
        Me.txtExpense = New MetroFramework.Controls.MetroTextBox()
        Me.txtDebt = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSales = New MetroFramework.Controls.MetroTextBox()
        Me.txtNet = New MetroFramework.Controls.MetroTextBox()
        Me.txtRefund = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTimeClose = New System.Windows.Forms.TextBox()
        Me.txtTimeStart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtGcash = New MetroFramework.Controls.MetroTextBox()
        Me.txtCash = New MetroFramework.Controls.MetroTextBox()
        Me.txtBt = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDebtPaid = New MetroFramework.Controls.MetroTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(65, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox2.TabIndex = 99
        Me.PictureBox2.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.Image = CType(resources.GetObject("btnEnd.Image"), System.Drawing.Image)
        Me.btnEnd.Location = New System.Drawing.Point(130, 440)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(116, 27)
        Me.btnEnd.TabIndex = 3
        Me.btnEnd.Text = "   END OF DAY"
        Me.btnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(8, 440)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(116, 27)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "   START OF DAY"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtStartingCash
        '
        Me.txtStartingCash.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtStartingCash.CustomButton.Image = Nothing
        Me.txtStartingCash.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtStartingCash.CustomButton.Name = ""
        Me.txtStartingCash.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStartingCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStartingCash.CustomButton.TabIndex = 1
        Me.txtStartingCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStartingCash.CustomButton.UseSelectable = True
        Me.txtStartingCash.CustomButton.Visible = False
        Me.txtStartingCash.DisplayIcon = True
        Me.txtStartingCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStartingCash.Icon = CType(resources.GetObject("txtStartingCash.Icon"), System.Drawing.Image)
        Me.txtStartingCash.Lines = New String(-1) {}
        Me.txtStartingCash.Location = New System.Drawing.Point(120, 121)
        Me.txtStartingCash.MaxLength = 32767
        Me.txtStartingCash.Name = "txtStartingCash"
        Me.txtStartingCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStartingCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStartingCash.SelectedText = ""
        Me.txtStartingCash.SelectionLength = 0
        Me.txtStartingCash.SelectionStart = 0
        Me.txtStartingCash.ShortcutsEnabled = True
        Me.txtStartingCash.Size = New System.Drawing.Size(253, 23)
        Me.txtStartingCash.TabIndex = 1
        Me.txtStartingCash.UseSelectable = True
        Me.txtStartingCash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStartingCash.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDiscount.CustomButton.Image = Nothing
        Me.txtDiscount.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtDiscount.CustomButton.Name = ""
        Me.txtDiscount.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiscount.CustomButton.TabIndex = 1
        Me.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiscount.CustomButton.UseSelectable = True
        Me.txtDiscount.CustomButton.Visible = False
        Me.txtDiscount.DisplayIcon = True
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDiscount.Icon = CType(resources.GetObject("txtDiscount.Icon"), System.Drawing.Image)
        Me.txtDiscount.Lines = New String(-1) {}
        Me.txtDiscount.Location = New System.Drawing.Point(120, 237)
        Me.txtDiscount.MaxLength = 32767
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiscount.SelectedText = ""
        Me.txtDiscount.SelectionLength = 0
        Me.txtDiscount.SelectionStart = 0
        Me.txtDiscount.ShortcutsEnabled = True
        Me.txtDiscount.Size = New System.Drawing.Size(253, 23)
        Me.txtDiscount.TabIndex = 96
        Me.txtDiscount.UseSelectable = True
        Me.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiscount.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtExpense
        '
        Me.txtExpense.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtExpense.CustomButton.Image = Nothing
        Me.txtExpense.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtExpense.CustomButton.Name = ""
        Me.txtExpense.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtExpense.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtExpense.CustomButton.TabIndex = 1
        Me.txtExpense.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtExpense.CustomButton.UseSelectable = True
        Me.txtExpense.CustomButton.Visible = False
        Me.txtExpense.DisplayIcon = True
        Me.txtExpense.Enabled = False
        Me.txtExpense.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtExpense.Icon = CType(resources.GetObject("txtExpense.Icon"), System.Drawing.Image)
        Me.txtExpense.Lines = New String(-1) {}
        Me.txtExpense.Location = New System.Drawing.Point(119, 295)
        Me.txtExpense.MaxLength = 32767
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExpense.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtExpense.SelectedText = ""
        Me.txtExpense.SelectionLength = 0
        Me.txtExpense.SelectionStart = 0
        Me.txtExpense.ShortcutsEnabled = True
        Me.txtExpense.Size = New System.Drawing.Size(253, 23)
        Me.txtExpense.TabIndex = 95
        Me.txtExpense.UseSelectable = True
        Me.txtExpense.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtExpense.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtDebt
        '
        Me.txtDebt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDebt.CustomButton.Image = Nothing
        Me.txtDebt.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtDebt.CustomButton.Name = ""
        Me.txtDebt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDebt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDebt.CustomButton.TabIndex = 1
        Me.txtDebt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDebt.CustomButton.UseSelectable = True
        Me.txtDebt.CustomButton.Visible = False
        Me.txtDebt.DisplayIcon = True
        Me.txtDebt.Enabled = False
        Me.txtDebt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDebt.Icon = CType(resources.GetObject("txtDebt.Icon"), System.Drawing.Image)
        Me.txtDebt.Lines = New String(-1) {}
        Me.txtDebt.Location = New System.Drawing.Point(120, 208)
        Me.txtDebt.MaxLength = 32767
        Me.txtDebt.Name = "txtDebt"
        Me.txtDebt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDebt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDebt.SelectedText = ""
        Me.txtDebt.SelectionLength = 0
        Me.txtDebt.SelectionStart = 0
        Me.txtDebt.ShortcutsEnabled = True
        Me.txtDebt.Size = New System.Drawing.Size(253, 23)
        Me.txtDebt.TabIndex = 93
        Me.txtDebt.UseSelectable = True
        Me.txtDebt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDebt.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 15)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "TOTAL DEBT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'txtSales
        '
        Me.txtSales.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSales.CustomButton.Image = Nothing
        Me.txtSales.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtSales.CustomButton.Name = ""
        Me.txtSales.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSales.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSales.CustomButton.TabIndex = 1
        Me.txtSales.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSales.CustomButton.UseSelectable = True
        Me.txtSales.CustomButton.Visible = False
        Me.txtSales.DisplayIcon = True
        Me.txtSales.Enabled = False
        Me.txtSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSales.Icon = CType(resources.GetObject("txtSales.Icon"), System.Drawing.Image)
        Me.txtSales.Lines = New String(-1) {}
        Me.txtSales.Location = New System.Drawing.Point(119, 150)
        Me.txtSales.MaxLength = 32767
        Me.txtSales.Name = "txtSales"
        Me.txtSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSales.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSales.SelectedText = ""
        Me.txtSales.SelectionLength = 0
        Me.txtSales.SelectionStart = 0
        Me.txtSales.ShortcutsEnabled = True
        Me.txtSales.Size = New System.Drawing.Size(253, 23)
        Me.txtSales.TabIndex = 77
        Me.txtSales.UseSelectable = True
        Me.txtSales.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSales.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNet.CustomButton.Image = Nothing
        Me.txtNet.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtNet.CustomButton.Name = ""
        Me.txtNet.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNet.CustomButton.TabIndex = 1
        Me.txtNet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNet.CustomButton.UseSelectable = True
        Me.txtNet.CustomButton.Visible = False
        Me.txtNet.DisplayIcon = True
        Me.txtNet.Enabled = False
        Me.txtNet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNet.Icon = CType(resources.GetObject("txtNet.Icon"), System.Drawing.Image)
        Me.txtNet.Lines = New String(-1) {}
        Me.txtNet.Location = New System.Drawing.Point(119, 324)
        Me.txtNet.MaxLength = 32767
        Me.txtNet.Name = "txtNet"
        Me.txtNet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNet.SelectedText = ""
        Me.txtNet.SelectionLength = 0
        Me.txtNet.SelectionStart = 0
        Me.txtNet.ShortcutsEnabled = True
        Me.txtNet.Size = New System.Drawing.Size(253, 23)
        Me.txtNet.TabIndex = 79
        Me.txtNet.UseSelectable = True
        Me.txtNet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNet.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtRefund
        '
        Me.txtRefund.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRefund.CustomButton.Image = Nothing
        Me.txtRefund.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtRefund.CustomButton.Name = ""
        Me.txtRefund.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRefund.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRefund.CustomButton.TabIndex = 1
        Me.txtRefund.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRefund.CustomButton.UseSelectable = True
        Me.txtRefund.CustomButton.Visible = False
        Me.txtRefund.DisplayIcon = True
        Me.txtRefund.Enabled = False
        Me.txtRefund.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRefund.Icon = CType(resources.GetObject("txtRefund.Icon"), System.Drawing.Image)
        Me.txtRefund.Lines = New String(-1) {}
        Me.txtRefund.Location = New System.Drawing.Point(120, 266)
        Me.txtRefund.MaxLength = 32767
        Me.txtRefund.Name = "txtRefund"
        Me.txtRefund.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefund.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRefund.SelectedText = ""
        Me.txtRefund.SelectionLength = 0
        Me.txtRefund.SelectionStart = 0
        Me.txtRefund.ShortcutsEnabled = True
        Me.txtRefund.Size = New System.Drawing.Size(253, 23)
        Me.txtRefund.TabIndex = 78
        Me.txtRefund.UseSelectable = True
        Me.txtRefund.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRefund.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "STARTING CASH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "TOTAL DISCOUNT"
        '
        'txtCashier
        '
        Me.txtCashier.BackColor = System.Drawing.Color.White
        Me.txtCashier.Enabled = False
        Me.txtCashier.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtCashier.Location = New System.Drawing.Point(119, 36)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(253, 23)
        Me.txtCashier.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "CASHIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "TIME START"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "TOTAL REFUND"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "TIME CLOSE"
        '
        'txtTimeClose
        '
        Me.txtTimeClose.BackColor = System.Drawing.Color.White
        Me.txtTimeClose.Enabled = False
        Me.txtTimeClose.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtTimeClose.Location = New System.Drawing.Point(119, 92)
        Me.txtTimeClose.Name = "txtTimeClose"
        Me.txtTimeClose.Size = New System.Drawing.Size(253, 23)
        Me.txtTimeClose.TabIndex = 90
        '
        'txtTimeStart
        '
        Me.txtTimeStart.BackColor = System.Drawing.Color.White
        Me.txtTimeStart.Enabled = False
        Me.txtTimeStart.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtTimeStart.Location = New System.Drawing.Point(119, 65)
        Me.txtTimeStart.Name = "txtTimeStart"
        Me.txtTimeStart.Size = New System.Drawing.Size(253, 23)
        Me.txtTimeStart.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "TOTAL EXPENSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "DAILY SALES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "TOTAL SALES"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(252, 440)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 27)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "   SALES REPORT"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 30)
        Me.Panel1.TabIndex = 76
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(303, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1129, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 27)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(146, 19)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "START && END MENU"
        '
        'txtGcash
        '
        Me.txtGcash.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtGcash.CustomButton.Image = Nothing
        Me.txtGcash.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtGcash.CustomButton.Name = ""
        Me.txtGcash.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGcash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGcash.CustomButton.TabIndex = 1
        Me.txtGcash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGcash.CustomButton.UseSelectable = True
        Me.txtGcash.CustomButton.Visible = False
        Me.txtGcash.DisplayIcon = True
        Me.txtGcash.Enabled = False
        Me.txtGcash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGcash.Icon = CType(resources.GetObject("txtGcash.Icon"), System.Drawing.Image)
        Me.txtGcash.Lines = New String(-1) {}
        Me.txtGcash.Location = New System.Drawing.Point(119, 382)
        Me.txtGcash.MaxLength = 32767
        Me.txtGcash.Name = "txtGcash"
        Me.txtGcash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGcash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGcash.SelectedText = ""
        Me.txtGcash.SelectionLength = 0
        Me.txtGcash.SelectionStart = 0
        Me.txtGcash.ShortcutsEnabled = True
        Me.txtGcash.Size = New System.Drawing.Size(253, 23)
        Me.txtGcash.TabIndex = 107
        Me.txtGcash.UseSelectable = True
        Me.txtGcash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGcash.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCash.CustomButton.Image = Nothing
        Me.txtCash.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtCash.CustomButton.Name = ""
        Me.txtCash.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCash.CustomButton.TabIndex = 1
        Me.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCash.CustomButton.UseSelectable = True
        Me.txtCash.CustomButton.Visible = False
        Me.txtCash.DisplayIcon = True
        Me.txtCash.Enabled = False
        Me.txtCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCash.Icon = CType(resources.GetObject("txtCash.Icon"), System.Drawing.Image)
        Me.txtCash.Lines = New String(-1) {}
        Me.txtCash.Location = New System.Drawing.Point(119, 411)
        Me.txtCash.MaxLength = 32767
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCash.SelectedText = ""
        Me.txtCash.SelectionLength = 0
        Me.txtCash.SelectionStart = 0
        Me.txtCash.ShortcutsEnabled = True
        Me.txtCash.Size = New System.Drawing.Size(253, 23)
        Me.txtCash.TabIndex = 101
        Me.txtCash.UseSelectable = True
        Me.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCash.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBt
        '
        Me.txtBt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBt.CustomButton.Image = Nothing
        Me.txtBt.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtBt.CustomButton.Name = ""
        Me.txtBt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBt.CustomButton.TabIndex = 1
        Me.txtBt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBt.CustomButton.UseSelectable = True
        Me.txtBt.CustomButton.Visible = False
        Me.txtBt.DisplayIcon = True
        Me.txtBt.Enabled = False
        Me.txtBt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBt.Icon = CType(resources.GetObject("txtBt.Icon"), System.Drawing.Image)
        Me.txtBt.Lines = New String(-1) {}
        Me.txtBt.Location = New System.Drawing.Point(120, 353)
        Me.txtBt.MaxLength = 32767
        Me.txtBt.Name = "txtBt"
        Me.txtBt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBt.SelectedText = ""
        Me.txtBt.SelectionLength = 0
        Me.txtBt.SelectionStart = 0
        Me.txtBt.ShortcutsEnabled = True
        Me.txtBt.Size = New System.Drawing.Size(253, 23)
        Me.txtBt.TabIndex = 100
        Me.txtBt.UseSelectable = True
        Me.txtBt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBt.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 15)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "BANKTRANSFER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(6, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "GCASH"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(6, 415)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 15)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "CASH"
        '
        'txtDebtPaid
        '
        Me.txtDebtPaid.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDebtPaid.CustomButton.Image = Nothing
        Me.txtDebtPaid.CustomButton.Location = New System.Drawing.Point(231, 1)
        Me.txtDebtPaid.CustomButton.Name = ""
        Me.txtDebtPaid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDebtPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDebtPaid.CustomButton.TabIndex = 1
        Me.txtDebtPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDebtPaid.CustomButton.UseSelectable = True
        Me.txtDebtPaid.CustomButton.Visible = False
        Me.txtDebtPaid.DisplayIcon = True
        Me.txtDebtPaid.Enabled = False
        Me.txtDebtPaid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDebtPaid.Icon = CType(resources.GetObject("txtDebtPaid.Icon"), System.Drawing.Image)
        Me.txtDebtPaid.Lines = New String(-1) {}
        Me.txtDebtPaid.Location = New System.Drawing.Point(119, 179)
        Me.txtDebtPaid.MaxLength = 32767
        Me.txtDebtPaid.Name = "txtDebtPaid"
        Me.txtDebtPaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDebtPaid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDebtPaid.SelectedText = ""
        Me.txtDebtPaid.SelectionLength = 0
        Me.txtDebtPaid.SelectionStart = 0
        Me.txtDebtPaid.ShortcutsEnabled = True
        Me.txtDebtPaid.Size = New System.Drawing.Size(253, 23)
        Me.txtDebtPaid.TabIndex = 110
        Me.txtDebtPaid.UseSelectable = True
        Me.txtDebtPaid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDebtPaid.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(7, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 15)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "TOTAL DEBT PAID"
        '
        'FrmStartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(378, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDebtPaid)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtGcash)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtBt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtStartingCash)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.txtDebt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtRefund)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTimeClose)
        Me.Controls.Add(Me.txtTimeStart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStartMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtStartingCash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDiscount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtExpense As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDebt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSales As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRefund As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCashier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTimeClose As TextBox
    Friend WithEvents txtTimeStart As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtGcash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDebtPaid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label16 As Label
End Class
