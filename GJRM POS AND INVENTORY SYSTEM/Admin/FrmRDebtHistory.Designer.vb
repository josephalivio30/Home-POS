<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRDebtHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRDebtHistory))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.btnSPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ddt2 = New System.Windows.Forms.DateTimePicker()
        Me.Ddt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvDebtHistory = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel18.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDebtHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel18.TabIndex = 92
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "TOTAL DEBT PAID"
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
        Me.btnClose.TabIndex = 90
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboName)
        Me.Panel1.Controls.Add(Me.btnSPrint)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Ddt2)
        Me.Panel1.Controls.Add(Me.Ddt1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 30)
        Me.Panel1.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(942, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "NAME"
        '
        'cboName
        '
        Me.cboName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(987, 3)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(121, 23)
        Me.cboName.TabIndex = 6
        Me.cboName.Text = "ALL NAMES"
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
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter Date [From - to]"
        '
        'Ddt2
        '
        Me.Ddt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ddt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Ddt2.Location = New System.Drawing.Point(812, 2)
        Me.Ddt2.Name = "Ddt2"
        Me.Ddt2.Size = New System.Drawing.Size(124, 23)
        Me.Ddt2.TabIndex = 3
        '
        'Ddt1
        '
        Me.Ddt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ddt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Ddt1.Location = New System.Drawing.Point(682, 2)
        Me.Ddt1.Name = "Ddt1"
        Me.Ddt1.Size = New System.Drawing.Size(124, 23)
        Me.Ddt1.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(260, 29)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "DEBT HISTORY REPORT"
        '
        'dgvDebtHistory
        '
        Me.dgvDebtHistory.AllowUserToAddRows = False
        Me.dgvDebtHistory.AllowUserToResizeColumns = False
        Me.dgvDebtHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvDebtHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDebtHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDebtHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvDebtHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDebtHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDebtHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebtHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDebtHistory.ColumnHeadersHeight = 30
        Me.dgvDebtHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDebtHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.Column1, Me.DataGridViewTextBoxColumn20, Me.Column2, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.dgvDebtHistory.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDebtHistory.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgvDebtHistory.EnableHeadersVisualStyles = False
        Me.dgvDebtHistory.GridColor = System.Drawing.Color.LightSkyBlue
        Me.dgvDebtHistory.Location = New System.Drawing.Point(12, 67)
        Me.dgvDebtHistory.Name = "dgvDebtHistory"
        Me.dgvDebtHistory.ReadOnly = True
        Me.dgvDebtHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDebtHistory.RowHeadersVisible = False
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvDebtHistory.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvDebtHistory.RowTemplate.Height = 25
        Me.dgvDebtHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDebtHistory.Size = New System.Drawing.Size(1013, 594)
        Me.dgvDebtHistory.TabIndex = 96
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "TRANSACTION NO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn19.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 62
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column1.HeaderText = "RECEIVED BY"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn20.HeaderText = "DEBT AMOUNT"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 109
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column2.HeaderText = "PAID AMOUNT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 107
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn21.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 56
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn22.HeaderText = "TIME"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 57
        '
        'FrmRDebtHistory
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1204, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDebtHistory)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmRDebtHistory"
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDebtHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents btnSPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Ddt2 As DateTimePicker
    Friend WithEvents Ddt1 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvDebtHistory As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
End Class
