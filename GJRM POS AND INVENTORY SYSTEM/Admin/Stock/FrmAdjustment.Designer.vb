<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdjustment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdjustment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cboCommand = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvAdjustment = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSelect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.cboCommand)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 159)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Adjustment"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(365, 25)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 15)
        Me.LinkLabel1.TabIndex = 64
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[ Generate ]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(441, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "USER"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQty.Location = New System.Drawing.Point(128, 109)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(153, 23)
        Me.txtQty.TabIndex = 62
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(128, 80)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(307, 23)
        Me.txtDesc.TabIndex = 61
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(727, 109)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 37)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "   &SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(908, 21)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 15)
        Me.lblID.TabIndex = 60
        Me.lblID.Visible = False
        '
        'cboCommand
        '
        Me.cboCommand.FormattingEnabled = True
        Me.cboCommand.Items.AddRange(New Object() {"REMOVE FROM INVENTORY", "ADD TO INVENTORY"})
        Me.cboCommand.Location = New System.Drawing.Point(515, 21)
        Me.cboCommand.Name = "cboCommand"
        Me.cboCommand.Size = New System.Drawing.Size(307, 23)
        Me.cboCommand.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(441, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "REMARKS"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(515, 80)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(307, 23)
        Me.txtUser.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "QTY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(441, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "COMMAND"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Location = New System.Drawing.Point(515, 51)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(307, 23)
        Me.txtRemarks.TabIndex = 56
        '
        'txtRefNo
        '
        Me.txtRefNo.BackColor = System.Drawing.Color.White
        Me.txtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRefNo.Enabled = False
        Me.txtRefNo.Location = New System.Drawing.Point(128, 22)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(231, 23)
        Me.txtRefNo.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "REFERENCE NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "PCODE"
        '
        'txtPcode
        '
        Me.txtPcode.BackColor = System.Drawing.Color.White
        Me.txtPcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPcode.Enabled = False
        Me.txtPcode.Location = New System.Drawing.Point(128, 51)
        Me.txtPcode.Name = "txtPcode"
        Me.txtPcode.Size = New System.Drawing.Size(307, 23)
        Me.txtPcode.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "DESCRIPTION"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1020, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 23)
        Me.btnClose.TabIndex = 59
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvAdjustment
        '
        Me.dgvAdjustment.AllowUserToAddRows = False
        Me.dgvAdjustment.AllowUserToResizeColumns = False
        Me.dgvAdjustment.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAdjustment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdjustment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAdjustment.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdjustment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAdjustment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAdjustment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdjustment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdjustment.ColumnHeadersHeight = 30
        Me.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAdjustment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column5, Me.Column6, Me.DataGridViewTextBoxColumn3, Me.Column9, Me.Column10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.ColSelect})
        Me.dgvAdjustment.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdjustment.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvAdjustment.EnableHeadersVisualStyles = False
        Me.dgvAdjustment.GridColor = System.Drawing.Color.LightSkyBlue
        Me.dgvAdjustment.Location = New System.Drawing.Point(7, 229)
        Me.dgvAdjustment.Name = "dgvAdjustment"
        Me.dgvAdjustment.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdjustment.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvAdjustment.RowHeadersVisible = False
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAdjustment.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvAdjustment.RowTemplate.Height = 25
        Me.dgvAdjustment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdjustment.Size = New System.Drawing.Size(1029, 341)
        Me.dgvAdjustment.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 36
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "PCODE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.HeaderText = "BARCODE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 81
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column9.HeaderText = "BRAND"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 67
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column10.HeaderText = "CATEGORY"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 85
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 61
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "STOCK ON HAND"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 119
        '
        'ColSelect
        '
        Me.ColSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = Nothing
        Me.ColSelect.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColSelect.HeaderText = ""
        Me.ColSelect.Image = CType(resources.GetObject("ColSelect.Image"), System.Drawing.Image)
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.ReadOnly = True
        Me.ColSelect.Width = 5
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.Icon = CType(resources.GetObject("txtSearch.Icon"), System.Drawing.Image)
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(7, 200)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search Description"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(345, 23)
        Me.txtSearch.TabIndex = 62
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search Description"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FrmAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1048, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvAdjustment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAdjustment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents cboCommand As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents dgvAdjustment As DataGridView
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ColSelect As DataGridViewImageColumn
End Class
