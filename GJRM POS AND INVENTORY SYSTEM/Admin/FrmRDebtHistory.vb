Public Class FrmRDebtHistory
    Dim sql As String
    Dim sdate1 As String
    Dim sdate2 As String

    Dim banktransfer As Double = 0
    Dim gcash As Double = 0
    Dim cash As Double = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmDebtHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub LoadDebtHistory()
        sdate1 = Ddt1.Value.ToString("yyyy-MM-dd")
        sdate2 = Ddt2.Value.ToString("yyyy-MM-dd")
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
                dgvDebtHistory.Rows.Add(dr.Item("transno").ToString, dr.Item("cname").ToString, dr.Item("cuser").ToString, Format(CDbl(dr.Item("amount").ToString), "#,##0.00"), Format(CDbl(dr.Item("banktransfer")) + CDbl(dr.Item("gcash")) + CDbl(dr.Item("cash"))), dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            lblTotal.Text = Format(total, currencysymbol & "#,##0.00")

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(banktransfer)), '0', sum(banktransfer)) as banktransfer, IIf(IsNull(sum(gcash)), '0', sum(gcash)) as gcash, IIf(IsNull(sum(cash)), '0', sum(cash)) as cash from tbldebthistory where sdate between #" & sdate1 & "# and #" & sdate2 & "# and cuser like '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                banktransfer = CDbl(dr.Item("banktransfer").ToString)
                gcash = CDbl(dr.Item("gcash").ToString)
                cash = CDbl(dr.Item("cash").ToString)
            End While
            cn.Close()
            dr.Close()

            lblBt.Text = Format(banktransfer, currencysymbol & "#,##0.00")
            lblGcash.Text = Format(gcash, currencysymbol & "#,##0.00")
            lblCash.Text = Format(cash, currencysymbol & "#,##0.00")

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
            cn.Close()
            dr.Close()
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
        If Ddt1.Value > Ddt2.Value Then
            Ddt1.Value = Ddt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadDebtHistory()
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles Ddt2.ValueChanged
        If Ddt1.Value > Ddt2.Value Then
            Ddt2.Value = Ddt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadDebtHistory()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        If cboName.Text = "ALL NAMES" Then
            sql = "select sdate, transno, cname,cuser,amount, banktransfer + gcash + cash as total, stime from tbldebthistory where sdate between #" & sdate1 & "# and #" & sdate2 & "#"
        Else
            sql = "select sdate, transno, cname,cuser,amount, banktransfer + gcash + cash as total, stime from tbldebthistory where cname like '" & cboName.Text & "' and sdate between #" & sdate1 & "# and #" & sdate2 & "#"
        End If
        With FrmPrintDebtHistory
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvDebtHistory_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvDebtHistory.SortCompare
        Try
            Dim dval1, dval2 As Double

            If Not Double.TryParse(e.CellValue1.ToString, dval1) Then Return
            If Not Double.TryParse(e.CellValue2.ToString, dval2) Then Return

            If dval1 = dval2 Then
                e.SortResult = 0
            ElseIf dval2 > dval1 Then
                e.SortResult = -1
            ElseIf dval1 > dval2 Then
                e.SortResult = 1
            End If
            e.Handled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class