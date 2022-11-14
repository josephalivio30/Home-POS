<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendor))
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(128, 86)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(307, 23)
        Me.txtAddress.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(19, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "TELEPHONE NO."
        '
        'txtVendor
        '
        Me.txtVendor.BackColor = System.Drawing.Color.White
        Me.txtVendor.Location = New System.Drawing.Point(128, 57)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(307, 23)
        Me.txtVendor.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "VENDOR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 30)
        Me.Panel1.TabIndex = 123
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
        Me.lblTitle.Size = New System.Drawing.Size(81, 15)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "ADD VENDOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "EMAIL ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "CONTACT PERSON"
        '
        'txtNo
        '
        Me.txtNo.BackColor = System.Drawing.Color.White
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Location = New System.Drawing.Point(128, 144)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(307, 23)
        Me.txtNo.TabIndex = 132
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.Location = New System.Drawing.Point(128, 115)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(307, 23)
        Me.txtContact.TabIndex = 131
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(128, 173)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 23)
        Me.txtEmail.TabIndex = 133
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(340, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 37)
        Me.btnCancel.TabIndex = 119
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
        Me.btnUpdate.Location = New System.Drawing.Point(239, 202)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 37)
        Me.btnUpdate.TabIndex = 118
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
        Me.btnSave.Location = New System.Drawing.Point(138, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 37)
        Me.btnSave.TabIndex = 117
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Location = New System.Drawing.Point(13, 225)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(0, 15)
        Me.txtID.TabIndex = 134
        Me.txtID.Visible = False
        '
        'FrmVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(447, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmVendor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtID As Label
End Class
