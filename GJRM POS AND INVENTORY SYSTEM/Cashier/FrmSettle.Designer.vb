<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettle))
        Me.txtBankTransfer = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtGcash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBankTransfer
        '
        Me.txtBankTransfer.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtBankTransfer.Location = New System.Drawing.Point(13, 183)
        Me.txtBankTransfer.Name = "txtBankTransfer"
        Me.txtBankTransfer.Size = New System.Drawing.Size(291, 40)
        Me.txtBankTransfer.TabIndex = 42
        Me.txtBankTransfer.Text = "0.00"
        Me.txtBankTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Location = New System.Drawing.Point(13, 165)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(92, 15)
        Me.lbl.TabIndex = 54
        Me.lbl.Text = "BANK TRANSFER"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtCash.Location = New System.Drawing.Point(13, 305)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(291, 40)
        Me.txtCash.TabIndex = 45
        Me.txtCash.Text = "0.00"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGcash
        '
        Me.txtGcash.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtGcash.Location = New System.Drawing.Point(13, 244)
        Me.txtGcash.Name = "txtGcash"
        Me.txtGcash.Size = New System.Drawing.Size(291, 40)
        Me.txtGcash.TabIndex = 44
        Me.txtGcash.Text = "0.00"
        Me.txtGcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "GCASH"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 30)
        Me.Panel1.TabIndex = 51
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(243, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 7
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
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(126, 19)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "SETTLE PAYMENT"
        '
        'txtBill
        '
        Me.txtBill.Enabled = False
        Me.txtBill.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtBill.Location = New System.Drawing.Point(13, 122)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(291, 40)
        Me.txtBill.TabIndex = 50
        Me.txtBill.Text = "0.00"
        Me.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "TOTAL"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Image = CType(resources.GetObject("btnAccept.Image"), System.Drawing.Image)
        Me.btnAccept.Location = New System.Drawing.Point(44, 412)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(232, 36)
        Me.btnAccept.TabIndex = 48
        Me.btnAccept.Text = "   A&CCEPT PAYMENT"
        Me.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtChange.Location = New System.Drawing.Point(13, 366)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(291, 40)
        Me.txtChange.TabIndex = 47
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "CHANGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "CASH"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(13, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(291, 40)
        Me.txtName.TabIndex = 56
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "CUSTOMER'S NAME"
        '
        'FrmSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(313, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBankTransfer)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtGcash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSettle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtBankTransfer As TextBox
    Friend WithEvents lbl As Label
    Public WithEvents txtCash As TextBox
    Public WithEvents txtGcash As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTitle As Label
    Public WithEvents txtBill As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAccept As Button
    Public WithEvents txtChange As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
End Class
