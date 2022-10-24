Public Class FrmCancelledOrder
    Dim sdate1 As String
    Dim sdate2 As String
    Sub LoadCancelOrder()
        Try
            dgvCancelOrder.Rows.Clear()
            Dim _total As Double = 0
            Dim i As Integer
            sdate1 = Cdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Cdt2.Value.ToString("yyyy-MM-dd")
            cn.Open()

            If cboCashier.Text = "ALL" Then
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and transno like '" & txtSearch.Text & "%'", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and transno like '" & txtSearch.Text & "%' and cancelledby like '" & cboCashier.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                dgvCancelOrder.Rows.Add(i, dr.Item("transno").ToString, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), CDate(dr.Item("sdate").ToString).ToShortDateString, dr.Item("voidby").ToString, dr.Item("cancelledby").ToString, dr.Item("reason").ToString, dr.Item("saction").ToString)
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
            cboCashier.Items.Clear()
            cboCashier.Items.Add("ALL CASHIER")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cancelledby from vwcancelorder", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboCashier.Items.Add(UCase(dr.Item("cancelledby").ToString))
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

    Private Sub cboCashier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCashier.SelectedIndexChanged
        LoadCancelOrder()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCancelOrder()
    End Sub
End Class