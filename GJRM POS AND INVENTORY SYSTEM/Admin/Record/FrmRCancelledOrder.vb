Public Class FrmRCancelledOrder
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Sub LoadCancelOrder()
        Try
            dgvCancelOrder.Rows.Clear()
            Dim _total As Double = 0
            Dim i As Integer
            sdate1 = Cdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Cdt2.Value.ToString("yyyy-MM-dd")
            cn.Open()

            If cboCancelledBy.Text = "ALL" Then
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%'", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%' and cancelledby like '" & cboCancelledBy.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                dgvCancelOrder.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), CDate(dr.Item("sdate").ToString).ToShortDateString, dr.Item("voidby").ToString, dr.Item("cancelledby").ToString, dr.Item("reason").ToString, dr.Item("saction").ToString)
            End While
            dr.Close()
            cn.Close()

            lblTotal.Text = Format(_total, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadCashier()
        Try
            cboCancelledBy.Items.Clear()
            cboCancelledBy.Items.Add("ALL")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cancelledby from vwcancelorder", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboCancelledBy.Items.Add(UCase(dr.Item("cancelledby").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Cdt1_ValueChanged(sender As Object, e As EventArgs) Handles Cdt1.ValueChanged
        LoadCancelOrder()
    End Sub

    Private Sub Cdt2_ValueChanged(sender As Object, e As EventArgs) Handles Cdt2.ValueChanged
        LoadCancelOrder()
    End Sub

    Private Sub cboCashier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCancelledBy.SelectedIndexChanged
        LoadCancelOrder()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCancelOrder()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        Try

            If cboCancelledBy.Text = "ALL" Then
                sql = "select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%'"
            Else
                sql = "select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and reason like '" & txtSearch.Text & "%' and cancelledby like '" & cboCancelledBy.Text & "'"
            End If
            With FrmPrintCancelledOrder
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboCancelledBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCancelledBy.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmRCancelledOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRCancelledOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class