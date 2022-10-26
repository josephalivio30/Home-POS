<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintCancelledOrder
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
        Me.RvCancelledOrder = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvCancelledOrder
        '
        Me.RvCancelledOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvCancelledOrder.Location = New System.Drawing.Point(0, 0)
        Me.RvCancelledOrder.Name = "RvCancelledOrder"
        Me.RvCancelledOrder.ServerReport.BearerToken = Nothing
        Me.RvCancelledOrder.Size = New System.Drawing.Size(800, 450)
        Me.RvCancelledOrder.TabIndex = 0
        '
        'FrmPrintCancelledOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RvCancelledOrder)
        Me.Name = "FrmPrintCancelledOrder"
        Me.Text = "FrmPrintCancelledOrder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvCancelledOrder As Microsoft.Reporting.WinForms.ReportViewer
End Class
