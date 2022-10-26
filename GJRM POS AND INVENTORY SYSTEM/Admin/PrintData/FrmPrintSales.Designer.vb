<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintSales
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
        Me.RvSales = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvSales
        '
        Me.RvSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvSales.Location = New System.Drawing.Point(0, 0)
        Me.RvSales.Name = "RvSales"
        Me.RvSales.ServerReport.BearerToken = Nothing
        Me.RvSales.Size = New System.Drawing.Size(800, 553)
        Me.RvSales.TabIndex = 0
        '
        'FrmPrintSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.RvSales)
        Me.Name = "FrmPrintSales"
        Me.Text = "FrmPrintSales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvSales As Microsoft.Reporting.WinForms.ReportViewer
End Class
