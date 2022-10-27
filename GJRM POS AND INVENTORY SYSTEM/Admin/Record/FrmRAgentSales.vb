Public Class FrmRAgentSales
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Sub LoadAgentSales()
        Try
            dgvDailySales.Rows.Clear()
            Dim _total As Double = 0
            Dim _discount As Double = 0
            Dim _net As Double = 0
            Dim _qty As Double = 0
            Dim i As Integer
            sdate1 = Adt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Adt2.Value.ToString("yyyy-MM-dd")
            cn.Open()
            If cboAgent.Text = "ALL AGENT" Then
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent <> 'NO AGENT' and transno like '" & txtSearch.Text & "%' order by sdate desc", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent like '" & cboAgent.Text & "' and pdesc like '" & txtSearch.Text & "%' order by sdate desc", cn)
            End If

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                _qty += CDbl(dr.Item("qty").ToString)
                _discount += CDbl(dr.Item("discount").ToString)
                _net += ((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString)) - CDbl(dr.Item("discount").ToString)
                dgvDailySales.Rows.Add(i, dr.Item("id").ToString, dr.Item("pcode").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), Format(CDbl(dr.Item("bprice").ToString), "#,##0.00"), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString)) - CDbl(dr.Item("discount").ToString), "#,##0.00"), dr.Item("agent").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            dr.Close()
            cn.Close()

            lblTotal.Text = Format(_total - _discount, currencysymbol & "#,##0.00")
            lblQty.Text = Format(_qty, currencysymbol & "#,##0.0")
            lblDiscount.Text = Format(_discount, currencysymbol & "#,##0.00")
            lblTotalNet.Text = Format(_net - _discount, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadAgent()
        Try
            cboAgent.Items.Clear()
            cboAgent.Items.Add("ALL AGENT")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct agent from tblcart where agent <> 'NO AGENT'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboAgent.Items.Add(UCase(dr.Item("agent").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cboAgent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAgent.KeyPress
        e.Handled = True
    End Sub

    Private Sub Adt1_ValueChanged(sender As Object, e As EventArgs) Handles Adt1.ValueChanged
        LoadAgentSales()
    End Sub

    Private Sub Adt2_ValueChanged(sender As Object, e As EventArgs) Handles Adt2.ValueChanged
        LoadAgentSales()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAgentSales()
    End Sub

    Private Sub cboAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAgent.SelectedIndexChanged
        LoadAgentSales()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        If cboAgent.Text = "ALL AGENT" Then
            sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent <> 'NO AGENT' and transno like '" & txtSearch.Text & "%' order by sdate desc"
        Else
            sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent like '" & cboAgent.Text & "' and pdesc like '" & txtSearch.Text & "%' order by sdate desc"
        End If
        With FrmPrintAgentSales
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub
End Class