<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventoryList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventoryList))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInventoryList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboList = New System.Windows.Forms.ComboBox()
        Me.btnSPrint = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvInventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInventoryList
        '
        Me.dgvInventoryList.AllowUserToAddRows = False
        Me.dgvInventoryList.AllowUserToResizeColumns = False
        Me.dgvInventoryList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvInventoryList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventoryList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventoryList.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventoryList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInventoryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInventoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventoryList.ColumnHeadersHeight = 30
        Me.dgvInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventoryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column5, Me.Column9, Me.Column2, Me.Column6, Me.Column8, Me.Column4, Me.Column3, Me.Column13, Me.Column1, Me.Column10})
        Me.dgvInventoryList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventoryList.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvInventoryList.EnableHeadersVisualStyles = False
        Me.dgvInventoryList.GridColor = System.Drawing.Color.LightSkyBlue
        Me.dgvInventoryList.Location = New System.Drawing.Point(12, 67)
        Me.dgvInventoryList.Name = "dgvInventoryList"
        Me.dgvInventoryList.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryList.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvInventoryList.RowHeadersVisible = False
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvInventoryList.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvInventoryList.RowTemplate.Height = 25
        Me.dgvInventoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventoryList.Size = New System.Drawing.Size(1013, 588)
        Me.dgvInventoryList.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cboList)
        Me.Panel1.Controls.Add(Me.btnSPrint)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 30)
        Me.Panel1.TabIndex = 80
        '
        'cboList
        '
        Me.cboList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboList.FormattingEnabled = True
        Me.cboList.Items.AddRange(New Object() {"Inventory Stocks", "Critical Stocks"})
        Me.cboList.Location = New System.Drawing.Point(985, 3)
        Me.cboList.Name = "cboList"
        Me.cboList.Size = New System.Drawing.Size(123, 23)
        Me.cboList.TabIndex = 49
        Me.cboList.Text = "Inventory Stocks"
        '
        'btnSPrint
        '
        Me.btnSPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSPrint.FlatAppearance.BorderSize = 0
        Me.btnSPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSPrint.ForeColor = System.Drawing.Color.White
        Me.btnSPrint.Image = CType(resources.GetObject("btnSPrint.Image"), System.Drawing.Image)
        Me.btnSPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSPrint.Location = New System.Drawing.Point(1114, 3)
        Me.btnSPrint.Name = "btnSPrint"
        Me.btnSPrint.Size = New System.Drawing.Size(78, 24)
        Me.btnSPrint.TabIndex = 8
        Me.btnSPrint.Text = "   PRINT"
        Me.btnSPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSPrint.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(235, 29)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "INVENTORY STOCKS"
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
        Me.btnClose.Location = New System.Drawing.Point(1179, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 31)
        Me.btnClose.TabIndex = 81
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 36
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "PCODE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 67
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column9.HeaderText = "BARCODE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 81
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "BRAND"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 67
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.HeaderText = "CATEGORY"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 85
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column4.HeaderText = "SPRICE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 67
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column3.HeaderText = "RE-ORDER"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 84
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column13.HeaderText = "STOCK ON HAND"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 119
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column1.HeaderText = "BPRICE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 68
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column10.HeaderText = "TOTAL VALUE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 97
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel18.Controls.Add(Me.Label18)
        Me.Panel18.Controls.Add(Me.lblTotal)
        Me.Panel18.Location = New System.Drawing.Point(1031, 67)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(161, 60)
        Me.Panel18.TabIndex = 83
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "GRAND VALUE"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(158, 45)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "00000000.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmInventoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1204, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.dgvInventoryList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmInventoryList"
        CType(Me.dgvInventoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInventoryList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSPrint As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents cboList As ComboBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotal As Label
End Class
