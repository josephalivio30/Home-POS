Public Class FrmRSales
    Dim debtpaid As Double = 0

    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Dim banktransfer As Double = 0
    Dim gcash As Double = 0
    Dim cash As Double = 0
    Dim RstartAmount As Double = 0
    Dim Rrefund As Double = 0
    Dim Rexpense As Double = 0
    Dim Rdebt As Double = 0
    Dim Rdebtpaid As Double = 0
    Private Sub FrmRSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub LoadSale()
        Try
            dgvDailySales.Rows.Clear()
            Dim _total As Double = 0
            Dim _discount As Double = 0
            Dim _net As Double = 0
            Dim i As Integer
            sdate1 = Sdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Sdt2.Value.ToString("yyyy-MM-dd")
            cn.Open()
            If cboCashier.Text = "ALL CASHIER" Then
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and cname like '" & txtSearch.Text & "%' order by sdate, transno desc", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and cashier like '" & cboCashier.Text & "' and cname like '" & txtSearch.Text & "%' order by sdate, transno desc", cn)
            End If

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                _discount += CDbl(dr.Item("discount").ToString)
                _net += ((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString))
                dgvDailySales.Rows.Add(i, dr.Item("id").ToString, dr.Item("pcode").ToString, dr.Item("cname").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("qty") * CDbl(dr.Item("price").ToString)), "#,##0.0"), Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format(CDbl((dr.Item("qty")) * CDbl(dr.Item("price")) - CDbl(dr.Item("discount")).ToString), "#,##0.00"), Format(CDbl(dr.Item("bprice").ToString), "#,##0.00"), Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), Format(((CDbl(dr.Item("sprice").ToString) - CDbl(dr.Item("bprice").ToString)) * CDbl(dr.Item("qty").ToString)) - CDbl(dr.Item("discount").ToString), "#,##0.00"), dr.Item("cashier").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString), dr.Item("remarks").ToString)
            End While
            dr.Close()
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(banktransfer)), '0', sum(banktransfer)) as banktransfer, IIf(IsNull(sum(gcash)), '0', sum(gcash)) as gcash, IIf(IsNull(sum(cash)), '0', sum(cash)) as cash, IIf(IsNull(sum(schange)), '0', sum(schange)) as schange from tblsales where sdate between #" & sdate1 & "# and #" & sdate2 & "# and remarks like 'Paid'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                banktransfer = CDbl(dr.Item("banktransfer").ToString)
                gcash = CDbl(dr.Item("gcash").ToString)
                cash = CDbl(dr.Item("cash"))
            End While
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("Select IIf(IsNull(sum(initialcash)), '0', sum(initialcash)) as startamount from tblstart where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            RstartAmount = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("Select IIf(IsNull(sum(amount)), '0', sum(amount)) as expense from tblexpense where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Rexpense = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as debt from tbldebt where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Rdebt = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(gcash + banktransfer + cash)), '0', sum(gcash + banktransfer + cash)) as debt from tbldebthistory where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Rdebtpaid = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(total)), '0', sum(total)) as total from tblcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "# and remarks = 'Paid'", cn)
            Rrefund = CDbl(cm.ExecuteScalar)
            cn.Close()

            lblStartAmount.Text = Format(RstartAmount, currencysymbol & "#,##0.00")
            lblTotal.Text = Format(_total, currencysymbol & "#,##0.00") '- refund, - discount
            lblExpense.Text = Format(Rexpense, currencysymbol & "#,##0.00")
            lblDiscount.Text = Format(_discount, currencysymbol & "#,##0.00")
            lblSRefund.Text = Format(Rrefund, currencysymbol & "#,##0.00")
            lblDebt.Text = Format(Rdebt, currencysymbol & "#,##0.00")
            lblPaidDebt.Text = Format(Rdebtpaid, currencysymbol & "#,##0.00")
            lblGrandSales.Text = Format((_total + startAmount + Rdebtpaid) - (Rdebt + Rexpense), currencysymbol & "#,##0.00")
            lblTotalNet.Text = Format(_net, currencysymbol & "#,##0.00")

            lblbt.Text = Format(banktransfer, currencysymbol & "#,##0.00")
            lblgcash.Text = Format(gcash, currencysymbol & "#,##0.00")
            lblcash.Text = Format(cash, currencysymbol & "#,##0.00")

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
            cm = New OleDb.OleDbCommand("select distinct cashier from tblcart", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboCashier.Items.Add(UCase(dr.Item("cashier").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub Sdt1_ValueChanged(sender As Object, e As EventArgs) Handles Sdt1.ValueChanged
        If Sdt1.Value > Sdt2.Value Then
            Sdt1.Value = Sdt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadSale()
    End Sub

    Private Sub Sdt2_ValueChanged(sender As Object, e As EventArgs) Handles Sdt2.ValueChanged
        If Sdt1.Value > Sdt2.Value Then
            Sdt2.Value = Sdt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadSale()
    End Sub

    Private Sub cboCashier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCashier.SelectedIndexChanged
        LoadSale()
    End Sub

    Private Sub cboCashier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCashier.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgvDailySales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDailySales.CellContentClick
        Try
            Dim colname As String = dgvDailySales.Columns(e.ColumnIndex).Name
            If colname = "ColCancel" Then
                With FrmCancelOrder
                    .txtID.Text = dgvDailySales.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtPcode.Text = dgvDailySales.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtDesc.Text = dgvDailySales.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtName.Text = dgvDailySales.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtTransno.Text = dgvDailySales.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtPrice.Text = dgvDailySales.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtSQty.Text = dgvDailySales.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtDiscount.Text = dgvDailySales.Rows(e.RowIndex).Cells(9).Value.ToString
                    .txtTotal.Text = dgvDailySales.Rows(e.RowIndex).Cells(10).Value.ToString
                    .txtVoidBy.Text = str_name
                    .txtCancelBy.Text = str_user
                    .txtRemarks.Text = dgvDailySales.Rows(e.RowIndex).Cells(16).Value.ToString
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        If cboCashier.Text = "ALL CASHIER" Then
            sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and cname like '" & txtSearch.Text & "%' order by sdate, transno desc"
        Else
            sql = "select * from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# and status like 'Completed' and cashier like '" & cboCashier.Text & "' and cname like '" & txtSearch.Text & "%' order by sdate, transno desc"
        End If
        With FrmPrintSales
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadSale()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRSales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class