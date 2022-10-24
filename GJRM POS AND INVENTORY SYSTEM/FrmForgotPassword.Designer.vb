<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmForgotPassword))
        Me.txtNewPass = New MetroFramework.Controls.MetroTextBox()
        Me.btnCCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCNewPass = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNewPass.CustomButton.Image = Nothing
        Me.txtNewPass.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtNewPass.CustomButton.Name = ""
        Me.txtNewPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPass.CustomButton.TabIndex = 1
        Me.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPass.CustomButton.UseSelectable = True
        Me.txtNewPass.CustomButton.Visible = False
        Me.txtNewPass.DisplayIcon = True
        Me.txtNewPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNewPass.Icon = CType(resources.GetObject("txtNewPass.Icon"), System.Drawing.Image)
        Me.txtNewPass.Lines = New String(-1) {}
        Me.txtNewPass.Location = New System.Drawing.Point(146, 262)
        Me.txtNewPass.MaxLength = 32767
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.PromptText = "New Password"
        Me.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.SelectionLength = 0
        Me.txtNewPass.SelectionStart = 0
        Me.txtNewPass.ShortcutsEnabled = True
        Me.txtNewPass.Size = New System.Drawing.Size(261, 26)
        Me.txtNewPass.TabIndex = 45
        Me.txtNewPass.UseSelectable = True
        Me.txtNewPass.WaterMark = "New Password"
        Me.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPass.WaterMarkFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCCancel
        '
        Me.btnCCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCCancel.FlatAppearance.BorderSize = 0
        Me.btnCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCCancel.Image = CType(resources.GetObject("btnCCancel.Image"), System.Drawing.Image)
        Me.btnCCancel.Location = New System.Drawing.Point(320, 326)
        Me.btnCCancel.Name = "btnCCancel"
        Me.btnCCancel.Size = New System.Drawing.Size(87, 30)
        Me.btnCCancel.TabIndex = 48
        Me.btnCCancel.Text = "   &CANCEL"
        Me.btnCCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(226, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 30)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(17, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "CONFIRM PASSWORD"
        '
        'txtCNewPass
        '
        Me.txtCNewPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCNewPass.CustomButton.Image = Nothing
        Me.txtCNewPass.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtCNewPass.CustomButton.Name = ""
        Me.txtCNewPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCNewPass.CustomButton.TabIndex = 1
        Me.txtCNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCNewPass.CustomButton.UseSelectable = True
        Me.txtCNewPass.CustomButton.Visible = False
        Me.txtCNewPass.DisplayIcon = True
        Me.txtCNewPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCNewPass.Icon = CType(resources.GetObject("txtCNewPass.Icon"), System.Drawing.Image)
        Me.txtCNewPass.Lines = New String(-1) {}
        Me.txtCNewPass.Location = New System.Drawing.Point(146, 294)
        Me.txtCNewPass.MaxLength = 32767
        Me.txtCNewPass.Name = "txtCNewPass"
        Me.txtCNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCNewPass.PromptText = "Confirm Password"
        Me.txtCNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCNewPass.SelectedText = ""
        Me.txtCNewPass.SelectionLength = 0
        Me.txtCNewPass.SelectionStart = 0
        Me.txtCNewPass.ShortcutsEnabled = True
        Me.txtCNewPass.Size = New System.Drawing.Size(261, 26)
        Me.txtCNewPass.TabIndex = 46
        Me.txtCNewPass.UseSelectable = True
        Me.txtCNewPass.WaterMark = "Confirm Password"
        Me.txtCNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCNewPass.WaterMarkFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(17, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "NEW PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "CODE"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.DisplayIcon = True
        Me.txtCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCode.Icon = CType(resources.GetObject("txtCode.Icon"), System.Drawing.Image)
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(146, 230)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.PromptText = "Code"
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(261, 26)
        Me.txtCode.TabIndex = 44
        Me.txtCode.UseSelectable = True
        Me.txtCode.WaterMark = "Code"
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.CustomButton.Visible = False
        Me.txtUser.DisplayIcon = True
        Me.txtUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUser.Icon = CType(resources.GetObject("txtUser.Icon"), System.Drawing.Image)
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(146, 198)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PromptText = "Username"
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.Size = New System.Drawing.Size(261, 26)
        Me.txtUser.TabIndex = 43
        Me.txtUser.UseSelectable = True
        Me.txtUser.WaterMark = "Username"
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(17, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "USERNAME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 177)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 101)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(174, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 68)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "JJA POS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(418, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.btnCCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCNewPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCNewPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
