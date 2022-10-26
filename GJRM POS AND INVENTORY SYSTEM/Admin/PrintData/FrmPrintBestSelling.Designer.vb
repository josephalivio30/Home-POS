<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintBestSelling
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
        Me.RvBestSelling = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvBestSelling
        '
        Me.RvBestSelling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvBestSelling.Location = New System.Drawing.Point(0, 0)
        Me.RvBestSelling.Name = "RvBestSelling"
        Me.RvBestSelling.ServerReport.BearerToken = Nothing
        Me.RvBestSelling.Size = New System.Drawing.Size(800, 450)
        Me.RvBestSelling.TabIndex = 0
        '
        'FrmPrintBestSelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RvBestSelling)
        Me.Name = "FrmPrintBestSelling"
        Me.Text = "Best Selling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvBestSelling As Microsoft.Reporting.WinForms.ReportViewer
End Class
