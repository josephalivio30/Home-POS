<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExpense))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New MetroFramework.Controls.MetroTextBox()
        Me.txtReceiver = New MetroFramework.Controls.MetroTextBox()
        Me.txtExpense = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "AMOUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "RECEIVED BY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "EXPENSES"
        '
        'txtAmount
        '
        '
        '
        '
        Me.txtAmount.CustomButton.Image = Nothing
        Me.txtAmount.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.txtAmount.CustomButton.Name = ""
        Me.txtAmount.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAmount.CustomButton.TabIndex = 1
        Me.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAmount.CustomButton.UseSelectable = True
        Me.txtAmount.CustomButton.Visible = False
        Me.txtAmount.DisplayIcon = True
        Me.txtAmount.Icon = CType(resources.GetObject("txtAmount.Icon"), System.Drawing.Image)
        Me.txtAmount.Lines = New String(-1) {}
        Me.txtAmount.Location = New System.Drawing.Point(16, 148)
        Me.txtAmount.MaxLength = 32767
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.SelectionLength = 0
        Me.txtAmount.SelectionStart = 0
        Me.txtAmount.ShortcutsEnabled = True
        Me.txtAmount.Size = New System.Drawing.Size(261, 23)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.UseSelectable = True
        Me.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAmount.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtReceiver
        '
        Me.txtReceiver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtReceiver.CustomButton.Image = Nothing
        Me.txtReceiver.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.txtReceiver.CustomButton.Name = ""
        Me.txtReceiver.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtReceiver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReceiver.CustomButton.TabIndex = 1
        Me.txtReceiver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReceiver.CustomButton.UseSelectable = True
        Me.txtReceiver.CustomButton.Visible = False
        Me.txtReceiver.DisplayIcon = True
        Me.txtReceiver.Lines = New String(-1) {}
        Me.txtReceiver.Location = New System.Drawing.Point(16, 104)
        Me.txtReceiver.MaxLength = 32767
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReceiver.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReceiver.SelectedText = ""
        Me.txtReceiver.SelectionLength = 0
        Me.txtReceiver.SelectionStart = 0
        Me.txtReceiver.ShortcutsEnabled = True
        Me.txtReceiver.Size = New System.Drawing.Size(261, 23)
        Me.txtReceiver.TabIndex = 2
        Me.txtReceiver.UseSelectable = True
        Me.txtReceiver.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReceiver.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtExpense
        '
        Me.txtExpense.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtExpense.CustomButton.Image = Nothing
        Me.txtExpense.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.txtExpense.CustomButton.Name = ""
        Me.txtExpense.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtExpense.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtExpense.CustomButton.TabIndex = 1
        Me.txtExpense.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtExpense.CustomButton.UseSelectable = True
        Me.txtExpense.CustomButton.Visible = False
        Me.txtExpense.DisplayIcon = True
        Me.txtExpense.Lines = New String(-1) {}
        Me.txtExpense.Location = New System.Drawing.Point(16, 61)
        Me.txtExpense.MaxLength = 32767
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExpense.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtExpense.SelectedText = ""
        Me.txtExpense.SelectionLength = 0
        Me.txtExpense.SelectionStart = 0
        Me.txtExpense.ShortcutsEnabled = True
        Me.txtExpense.Size = New System.Drawing.Size(261, 23)
        Me.txtExpense.TabIndex = 1
        Me.txtExpense.UseSelectable = True
        Me.txtExpense.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtExpense.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 30)
        Me.Panel1.TabIndex = 58
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(221, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(774, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 27)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.lblTitle.Size = New System.Drawing.Size(78, 19)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "EXPENSES"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(190, 177)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 27)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FrmExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtReceiver)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReceiver As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtExpense As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSave As Button
End Class
