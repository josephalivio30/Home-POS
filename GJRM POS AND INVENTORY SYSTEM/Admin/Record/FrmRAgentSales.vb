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
            Dim adjustment As Double = 0
            Dim i As Integer
            sdate1 = Adt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Adt2.Value.ToString("yyyy-MM-dd")
            cn.Open()
            If cboAgent.Text = "ALL AGENT" Then
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and pdesc like '" & txtSearch.Text & "%' order by sdate desc", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent like '" & cboAgent.Text & "' and pdesc like '" & txtSearch.Text & "%' order by sdate desc", cn)
            End If

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                _qty += CDbl(dr.Item("qty").ToString)
                _discount += CDbl(dr.Item("discount").ToString)
                _net += ((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString))
                dgvDailySales.Rows.Add(i, dr.Item("id").ToString, dr.Item("pcode").ToString, dr.Item("cname").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("qty") * CDbl(dr.Item("price").ToString)), "#,##0.0"), Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), Format(CDbl(dr.Item("bprice").ToString), "#,##0.00"), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString)) - CDbl(dr.Item("discount").ToString), "#,##0.00"), dr.Item("agent").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString), dr.Item("remarks").ToString)
            End While
            dr.Close()
            cn.Close()

            cn.Open()
            If cboAgent.Text = "ALL AGENT" Then
                cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(adjustment)), '0', sum(adjustment)) as adjustment from tblsales where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Else
                cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(adjustment)), '0', sum(adjustment)) as adjustment from tblsales where sdate between #" & sdate1 & "# and #" & sdate2 & "# and agent like '" & cboAgent.Text & "'", cn)
            End If
            adjustment = CDbl(cm.ExecuteScalar)
            cn.Close()

            lblAdjustment.Text = Format(adjustment, currencysymbol & "#,##0.00")
            lblTotal.Text = Format(_total + adjustment, currencysymbol & "#,##0.00")
            lblQty.Text = Format(_qty, currencysymbol & "#,##0.0")
            lblDiscount.Text = Format(_discount, currencysymbol & "#,##0.00")
            lblTotalNet.Text = Format(_net, currencysymbol & "#,##0.00")
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
            cm = New OleDb.OleDbCommand("select distinct agent from tblcart", cn)
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
        If Adt1.Value > Adt2.Value Then
            Adt1.Value = Adt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadAgentSales()
    End Sub

    Private Sub Adt2_ValueChanged(sender As Object, e As EventArgs) Handles Adt2.ValueChanged
        If Adt1.Value > Adt2.Value Then
            Adt2.Value = Adt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadAgentSales()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAgentSales()
    End Sub

    Private Sub cboAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAgent.SelectedIndexChanged
        LoadAgentSales()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        Try
            If cboAgent.Text = "ALL AGENT" Then
                sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and pdesc like '" & txtSearch.Text & "%' order by sdate desc"
            Else
                sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and agent like '" & cboAgent.Text & "' and pdesc like '" & txtSearch.Text & "%' order by sdate desc"
            End If
            With FrmPrintAgentSales
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRAgentSales_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRAgentSales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvDailySales_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvDailySales.SortCompare
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