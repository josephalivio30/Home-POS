<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgentList
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgentList))
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAgent = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColDelete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAgent
        '
        Me.dgvAgent.AllowUserToAddRows = False
        Me.dgvAgent.AllowUserToResizeColumns = False
        Me.dgvAgent.AllowUserToResizeRows = False
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAgent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvAgent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAgent.BackgroundColor = System.Drawing.Color.White
        Me.dgvAgent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAgent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAgent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvAgent.ColumnHeadersHeight = 30
        Me.dgvAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAgent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.Column1, Me.Column2, Me.Column3, Me.ColEdit, Me.ColDelete})
        Me.dgvAgent.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAgent.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgvAgent.EnableHeadersVisualStyles = False
        Me.dgvAgent.GridColor = System.Drawing.Color.LightSkyBlue
        Me.dgvAgent.Location = New System.Drawing.Point(8, 75)
        Me.dgvAgent.Name = "dgvAgent"
        Me.dgvAgent.ReadOnly = True
        Me.dgvAgent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAgent.RowHeadersVisible = False
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAgent.RowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvAgent.RowTemplate.Height = 25
        Me.dgvAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgent.Size = New System.Drawing.Size(915, 500)
        Me.dgvAgent.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 29)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "AGENT LIST"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.NullValue = CType(resources.GetObject("DataGridViewCellStyle27.NullValue"), Object)
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 5
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.NullValue = CType(resources.GetObject("DataGridViewCellStyle28.NullValue"), Object)
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 5
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(191, 1)
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
        Me.txtSearch.Location = New System.Drawing.Point(710, 46)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search Agent"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(213, 23)
        Me.txtSearch.TabIndex = 96
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search Agent"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCreateNew
        '
        Me.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateNew.FlatAppearance.BorderSize = 0
        Me.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNew.ForeColor = System.Drawing.Color.White
        Me.btnCreateNew.Image = CType(resources.GetObject("btnCreateNew.Image"), System.Drawing.Image)
        Me.btnCreateNew.Location = New System.Drawing.Point(189, 40)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(119, 29)
        Me.btnCreateNew.TabIndex = 95
        Me.btnCreateNew.Text = "   Add Agent"
        Me.btnCreateNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateNew.UseVisualStyleBackColor = False
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
        Me.btnClose.Location = New System.Drawing.Point(908, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 23)
        Me.btnClose.TabIndex = 93
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn13.HeaderText = "#"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 36
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn24.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn25.HeaderText = "AGENT"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column1.HeaderText = "ADDRESS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 78
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column2.HeaderText = "CONTACT NO."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 102
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column3.HeaderText = "EMAIL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 63
        '
        'ColEdit
        '
        Me.ColEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.NullValue = CType(resources.GetObject("DataGridViewCellStyle23.NullValue"), Object)
        Me.ColEdit.DefaultCellStyle = DataGridViewCellStyle23
        Me.ColEdit.HeaderText = ""
        Me.ColEdit.Image = CType(resources.GetObject("ColEdit.Image"), System.Drawing.Image)
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.ReadOnly = True
        Me.ColEdit.Width = 5
        '
        'ColDelete
        '
        Me.ColDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.NullValue = CType(resources.GetObject("DataGridViewCellStyle24.NullValue"), Object)
        Me.ColDelete.DefaultCellStyle = DataGridViewCellStyle24
        Me.ColDelete.HeaderText = ""
        Me.ColDelete.Image = CType(resources.GetObject("ColDelete.Image"), System.Drawing.Image)
        Me.ColDelete.Name = "ColDelete"
        Me.ColDelete.ReadOnly = True
        Me.ColDelete.Width = 5
        '
        'FrmAgentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(937, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnCreateNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvAgent)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAgentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAgent As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ColEdit As DataGridViewImageColumn
    Friend WithEvents ColDelete As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
