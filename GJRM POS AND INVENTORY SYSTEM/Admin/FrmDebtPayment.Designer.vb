<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDebtPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDebtPayment))
        Me.txtTAmount = New MetroFramework.Controls.MetroTextBox()
        Me.txtCASH = New MetroFramework.Controls.MetroTextBox()
        Me.txtGcash = New MetroFramework.Controls.MetroTextBox()
        Me.txtBT = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTAmount
        '
        Me.txtTAmount.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTAmount.CustomButton.Image = Nothing
        Me.txtTAmount.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtTAmount.CustomButton.Name = ""
        Me.txtTAmount.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTAmount.CustomButton.TabIndex = 1
        Me.txtTAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTAmount.CustomButton.UseSelectable = True
        Me.txtTAmount.CustomButton.Visible = False
        Me.txtTAmount.DisplayIcon = True
        Me.txtTAmount.Enabled = False
        Me.txtTAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTAmount.Icon = CType(resources.GetObject("txtTAmount.Icon"), System.Drawing.Image)
        Me.txtTAmount.Lines = New String() {"0.00"}
        Me.txtTAmount.Location = New System.Drawing.Point(120, 97)
        Me.txtTAmount.MaxLength = 32767
        Me.txtTAmount.Name = "txtTAmount"
        Me.txtTAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTAmount.SelectedText = ""
        Me.txtTAmount.SelectionLength = 0
        Me.txtTAmount.SelectionStart = 0
        Me.txtTAmount.ShortcutsEnabled = True
        Me.txtTAmount.Size = New System.Drawing.Size(238, 23)
        Me.txtTAmount.TabIndex = 104
        Me.txtTAmount.Text = "0.00"
        Me.txtTAmount.UseSelectable = True
        Me.txtTAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTAmount.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCASH
        '
        Me.txtCASH.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCASH.CustomButton.Image = Nothing
        Me.txtCASH.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtCASH.CustomButton.Name = ""
        Me.txtCASH.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCASH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCASH.CustomButton.TabIndex = 1
        Me.txtCASH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCASH.CustomButton.UseSelectable = True
        Me.txtCASH.CustomButton.Visible = False
        Me.txtCASH.DisplayIcon = True
        Me.txtCASH.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCASH.Icon = CType(resources.GetObject("txtCASH.Icon"), System.Drawing.Image)
        Me.txtCASH.Lines = New String() {"0.00"}
        Me.txtCASH.Location = New System.Drawing.Point(120, 183)
        Me.txtCASH.MaxLength = 32767
        Me.txtCASH.Name = "txtCASH"
        Me.txtCASH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCASH.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCASH.SelectedText = ""
        Me.txtCASH.SelectionLength = 0
        Me.txtCASH.SelectionStart = 0
        Me.txtCASH.ShortcutsEnabled = True
        Me.txtCASH.Size = New System.Drawing.Size(238, 23)
        Me.txtCASH.TabIndex = 103
        Me.txtCASH.Text = "0.00"
        Me.txtCASH.UseSelectable = True
        Me.txtCASH.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCASH.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtGcash
        '
        Me.txtGcash.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtGcash.CustomButton.Image = Nothing
        Me.txtGcash.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtGcash.CustomButton.Name = ""
        Me.txtGcash.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGcash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGcash.CustomButton.TabIndex = 1
        Me.txtGcash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGcash.CustomButton.UseSelectable = True
        Me.txtGcash.CustomButton.Visible = False
        Me.txtGcash.DisplayIcon = True
        Me.txtGcash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGcash.Icon = CType(resources.GetObject("txtGcash.Icon"), System.Drawing.Image)
        Me.txtGcash.Lines = New String() {"0.00"}
        Me.txtGcash.Location = New System.Drawing.Point(120, 154)
        Me.txtGcash.MaxLength = 32767
        Me.txtGcash.Name = "txtGcash"
        Me.txtGcash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGcash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGcash.SelectedText = ""
        Me.txtGcash.SelectionLength = 0
        Me.txtGcash.SelectionStart = 0
        Me.txtGcash.ShortcutsEnabled = True
        Me.txtGcash.Size = New System.Drawing.Size(238, 23)
        Me.txtGcash.TabIndex = 102
        Me.txtGcash.Text = "0.00"
        Me.txtGcash.UseSelectable = True
        Me.txtGcash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGcash.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBT
        '
        Me.txtBT.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBT.CustomButton.Image = Nothing
        Me.txtBT.CustomButton.Location = New System.Drawing.Point(216, 1)
        Me.txtBT.CustomButton.Name = ""
        Me.txtBT.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBT.CustomButton.TabIndex = 1
        Me.txtBT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBT.CustomButton.UseSelectable = True
        Me.txtBT.CustomButton.Visible = False
        Me.txtBT.DisplayIcon = True
        Me.txtBT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBT.Icon = CType(resources.GetObject("txtBT.Icon"), System.Drawing.Image)
        Me.txtBT.Lines = New String() {"0.00"}
        Me.txtBT.Location = New System.Drawing.Point(120, 126)
        Me.txtBT.MaxLength = 32767
        Me.txtBT.Name = "txtBT"
        Me.txtBT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBT.SelectedText = ""
        Me.txtBT.SelectionLength = 0
        Me.txtBT.SelectionStart = 0
        Me.txtBT.ShortcutsEnabled = True
        Me.txtBT.Size = New System.Drawing.Size(238, 23)
        Me.txtBT.TabIndex = 101
        Me.txtBT.Text = "0.00"
        Me.txtBT.UseSelectable = True
        Me.txtBT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBT.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "GCASH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "CASH"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtName.Location = New System.Drawing.Point(120, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(238, 23)
        Me.txtName.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "NAME"
        '
        'txtTransno
        '
        Me.txtTransno.BackColor = System.Drawing.Color.White
        Me.txtTransno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransno.Enabled = False
        Me.txtTransno.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtTransno.Location = New System.Drawing.Point(120, 43)
        Me.txtTransno.Name = "txtTransno"
        Me.txtTransno.Size = New System.Drawing.Size(238, 23)
        Me.txtTransno.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "TRANSACTION NO"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(273, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 27)
        Me.btnSave.TabIndex = 89
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "TOTAL AMOUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "BANK TRANSFER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 30)
        Me.Panel1.TabIndex = 90
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(303, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 6
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
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 19)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "SETTLE DEBT"
        '
        'FrmDebtPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(371, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTAmount)
        Me.Controls.Add(Me.txtCASH)
        Me.Controls.Add(Me.txtGcash)
        Me.Controls.Add(Me.txtBT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTransno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDebtPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCASH As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGcash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTransno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTitle As Label
End Class
