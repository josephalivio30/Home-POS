<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProduct))
        Me.txtSPrice = New MetroFramework.Controls.MetroTextBox()
        Me.txtBPrice = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddCtgry = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReOrder = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSPrice
        '
        Me.txtSPrice.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSPrice.CustomButton.Image = Nothing
        Me.txtSPrice.CustomButton.Location = New System.Drawing.Point(284, 1)
        Me.txtSPrice.CustomButton.Name = ""
        Me.txtSPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSPrice.CustomButton.TabIndex = 1
        Me.txtSPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSPrice.CustomButton.UseSelectable = True
        Me.txtSPrice.CustomButton.Visible = False
        Me.txtSPrice.DisplayIcon = True
        Me.txtSPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSPrice.Icon = CType(resources.GetObject("txtSPrice.Icon"), System.Drawing.Image)
        Me.txtSPrice.Lines = New String(-1) {}
        Me.txtSPrice.Location = New System.Drawing.Point(130, 231)
        Me.txtSPrice.MaxLength = 32767
        Me.txtSPrice.Name = "txtSPrice"
        Me.txtSPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSPrice.SelectedText = ""
        Me.txtSPrice.SelectionLength = 0
        Me.txtSPrice.SelectionStart = 0
        Me.txtSPrice.ShortcutsEnabled = True
        Me.txtSPrice.Size = New System.Drawing.Size(306, 23)
        Me.txtSPrice.TabIndex = 8
        Me.txtSPrice.UseSelectable = True
        Me.txtSPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSPrice.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBPrice
        '
        Me.txtBPrice.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBPrice.CustomButton.Image = Nothing
        Me.txtBPrice.CustomButton.Location = New System.Drawing.Point(284, 1)
        Me.txtBPrice.CustomButton.Name = ""
        Me.txtBPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBPrice.CustomButton.TabIndex = 1
        Me.txtBPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBPrice.CustomButton.UseSelectable = True
        Me.txtBPrice.CustomButton.Visible = False
        Me.txtBPrice.DisplayIcon = True
        Me.txtBPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBPrice.Icon = CType(resources.GetObject("txtBPrice.Icon"), System.Drawing.Image)
        Me.txtBPrice.Lines = New String(-1) {}
        Me.txtBPrice.Location = New System.Drawing.Point(130, 202)
        Me.txtBPrice.MaxLength = 32767
        Me.txtBPrice.Name = "txtBPrice"
        Me.txtBPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBPrice.SelectedText = ""
        Me.txtBPrice.SelectionLength = 0
        Me.txtBPrice.SelectionStart = 0
        Me.txtBPrice.ShortcutsEnabled = True
        Me.txtBPrice.Size = New System.Drawing.Size(306, 23)
        Me.txtBPrice.TabIndex = 7
        Me.txtBPrice.UseSelectable = True
        Me.txtBPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBPrice.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "SELLING PRICE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 30)
        Me.Panel1.TabIndex = 98
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(377, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(4, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(86, 15)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "ADD PRODUCT"
        '
        'btnAddCtgry
        '
        Me.btnAddCtgry.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddCtgry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCtgry.FlatAppearance.BorderSize = 0
        Me.btnAddCtgry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCtgry.ForeColor = System.Drawing.Color.White
        Me.btnAddCtgry.Location = New System.Drawing.Point(398, 169)
        Me.btnAddCtgry.Name = "btnAddCtgry"
        Me.btnAddCtgry.Size = New System.Drawing.Size(38, 27)
        Me.btnAddCtgry.TabIndex = 6
        Me.btnAddCtgry.Text = "+"
        Me.btnAddCtgry.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(342, 289)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 37)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "  &CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(241, 289)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 37)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "   &UPDATE"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(140, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 37)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "BOUGHT PRICE"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.White
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(130, 173)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(262, 23)
        Me.cboCategory.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "CATEGORY"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(130, 115)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(307, 23)
        Me.txtDescription.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "DESCRIPTION"
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.Color.White
        Me.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductCode.Location = New System.Drawing.Point(130, 57)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(307, 23)
        Me.txtProductCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "PRODUCT CODE"
        '
        'btnAddBrand
        '
        Me.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBrand.FlatAppearance.BorderSize = 0
        Me.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBrand.ForeColor = System.Drawing.Color.White
        Me.btnAddBrand.Location = New System.Drawing.Point(398, 140)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(38, 27)
        Me.btnAddBrand.TabIndex = 4
        Me.btnAddBrand.Text = "+"
        Me.btnAddBrand.UseVisualStyleBackColor = False
        '
        'cboBrand
        '
        Me.cboBrand.BackColor = System.Drawing.Color.White
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(130, 144)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(262, 23)
        Me.cboBrand.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "BRAND"
        '
        'txtBarCode
        '
        Me.txtBarCode.BackColor = System.Drawing.Color.White
        Me.txtBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarCode.Location = New System.Drawing.Point(130, 86)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(307, 23)
        Me.txtBarCode.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "BARCODE"
        '
        'txtReOrder
        '
        Me.txtReOrder.BackColor = System.Drawing.Color.White
        Me.txtReOrder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReOrder.Location = New System.Drawing.Point(130, 260)
        Me.txtReOrder.Name = "txtReOrder"
        Me.txtReOrder.Size = New System.Drawing.Size(307, 23)
        Me.txtReOrder.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "RE-ORDER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(449, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtReOrder)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBarCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddBrand)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSPrice)
        Me.Controls.Add(Me.txtBPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddCtgry)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAddCtgry As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddBrand As Button
    Friend WithEvents cboBrand As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBarCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReOrder As TextBox
    Friend WithEvents Label8 As Label
End Class
