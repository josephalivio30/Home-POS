﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintDebtHistory
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
        Me.RvDebtHistory = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvDebtHistory
        '
        Me.RvDebtHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvDebtHistory.Location = New System.Drawing.Point(0, 0)
        Me.RvDebtHistory.Name = "RvDebtHistory"
        Me.RvDebtHistory.ServerReport.BearerToken = Nothing
        Me.RvDebtHistory.Size = New System.Drawing.Size(800, 450)
        Me.RvDebtHistory.TabIndex = 0
        '
        'FrmPrintDebtHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RvDebtHistory)
        Me.Name = "FrmPrintDebtHistory"
        Me.Text = "Debt History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvDebtHistory As Microsoft.Reporting.WinForms.ReportViewer
End Class
