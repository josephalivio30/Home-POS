﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceiptPaid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceiptPaid))
        Me.rvReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvReceipt
        '
        Me.rvReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvReceipt.Location = New System.Drawing.Point(0, 0)
        Me.rvReceipt.Name = "rvReceipt"
        Me.rvReceipt.ServerReport.BearerToken = Nothing
        Me.rvReceipt.Size = New System.Drawing.Size(800, 450)
        Me.rvReceipt.TabIndex = 0
        Me.rvReceipt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'FrmReceiptPaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rvReceipt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReceiptPaid"
        Me.Text = "Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvReceipt As Microsoft.Reporting.WinForms.ReportViewer
End Class
