<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRExpense))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Edt2 = New System.Windows.Forms.DateTimePicker()
        Me.Edt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvExpense = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSPrint)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Edt2)
        Me.Panel1.Controls.Add(Me.Edt1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 30)
        Me.Panel1.TabIndex = 49
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
        Me.Label3.Location = New System.Drawing.Point(724, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter Date [From - to]"
        '
        'Edt2
        '
        Me.Edt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Edt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Edt2.Location = New System.Drawing.Point(984, 2)
        Me.Edt2.Name = "Edt2"
        Me.Edt2.Size = New System.Drawing.Size(124, 23)
        Me.Edt2.TabIndex = 3
        '
        'Edt1
        '
        Me.Edt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Edt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Edt1.Location = New System.Drawing.Point(854, 2)
        Me.Edt1.Name = "Edt1"
        Me.Edt1.Size = New System.Drawing.Size(124, 23)
        Me.Edt1.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(197, 29)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "EXPENSE REPORT"
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
        Me.btnClose.TabIndex = 50
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvExpense
        '
        Me.dgvExpense.AllowUserToAddRows = False
        Me.dgvExpense.AllowUserToResizeColumns = False
        Me.dgvExpense.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvExpense.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExpense.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExpense.BackgroundColor = System.Drawing.Color.White
        Me.dgvExpense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvExpense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvExpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExpense.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExpense.ColumnHeadersHeight = 30
        Me.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvExpense.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.Column28, Me.DataGridViewTextBoxColumn35})
        Me.dgvExpense.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExpense.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvExpense.EnableHeadersVisualStyles = False
        Me.dgvExpense.GridColor = System.Drawing.Color.LightSkyBlue
        Me.dgvExpense.Location = New System.Drawing.Point(12, 67)
        Me.dgvExpense.Name = "dgvExpense"
        Me.dgvExpense.ReadOnly = True
        Me.dgvExpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvExpense.RowHeadersVisible = False
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvExpense.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvExpense.RowTemplate.Height = 25
        Me.dgvExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpense.Size = New System.Drawing.Size(1013, 594)
        Me.dgvExpense.TabIndex = 67
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn23.HeaderText = "EXPENSE"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn32.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn32.HeaderText = "RELEASED BY"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 97
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn33.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn33.HeaderText = "RECEIVED BY"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 97
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn34.HeaderText = "AMOUNT"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 79
        '
        'Column28
        '
        Me.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column28.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column28.HeaderText = "TIME"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.Width = 57
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn35.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn35.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 56
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
        Me.Panel18.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "TOTAL EXPENSE"
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
        'FrmRExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1204, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.dgvExpense)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmRExpense"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Edt2 As DateTimePicker
    Friend WithEvents Edt1 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvExpense As DataGridView
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
End Class
