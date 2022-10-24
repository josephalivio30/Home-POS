Public Class FrmRDebtHistory
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmDebtHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub LoadDebtHistory()
        Dim sdate1 As String = Ddt1.Value.ToString("yyyy-MM-dd")
        Dim sdate2 As String = Ddt2.Value.ToString("yyyy-MM-dd")
        Dim total As Double = 0
        Try
            dgvDebtHistory.Rows.Clear()
            cn.Open()
            If cboName.Text = "ALL NAMES" Then
                cm = New OleDb.OleDbCommand("select * from tbldebthistory where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from tbldebthistory where cname like '" & cboName.Text & "' and sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                total += Format(CDbl(dr.Item("banktransfer")) + CDbl(dr.Item("gcash")) + CDbl(dr.Item("cash")), "#,##0.00")
                dgvDebtHistory.Rows.Add(dr.Item("transno").ToString, dr.Item("cname").ToString, dr.Item("cuser").ToString, Format(CDbl(dr.Item("amount").ToString), "#,##0.00"), Format(CDbl(dr.Item("banktransfer")) + CDbl(dr.Item("gcash")) + CDbl(dr.Item("cash")), "#,##0.00"), dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            lblTotal.Text = Format(total, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadName()
        Try
            cboName.Items.Clear()
            cboName.Items.Add("ALL NAMES")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cname from tbldebthistory", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboName.Items.Add(UCase(dr.Item("cname").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        LoadDebtHistory()
    End Sub
    Private Sub cboName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboName.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmDebtHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles Ddt1.ValueChanged
        LoadDebtHistory()
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles Ddt2.ValueChanged
        LoadDebtHistory()
    End Sub
End Class