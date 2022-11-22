Public Class FrmDailySales
    Dim sdate As String = Now.ToString("MM-dd-yyyy")
    Sub LoadSale()
        Try
            dgvDailySales.Rows.Clear()
            Dim _total As Double
            Dim i As Integer
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from ComputeTotal where sdate between #" & sdate & "# and #" & sdate & "# and status like 'Completed' and transno like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                _total += CDbl(dr.Item("total").ToString)
                dgvDailySales.Rows.Add(i, dr.Item("id").ToString, dr.Item("pcode").ToString, dr.Item("cname").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), dr.Item("remarks").ToString)
            End While
            dr.Close()
            cn.Close()

            lblSTotal.Text = Format(_total, currencysymbol & "#,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmDailySales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
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
                    .txtDiscount.Text = dgvDailySales.Rows(e.RowIndex).Cells(8).Value.ToString
                    .txtTotal.Text = dgvDailySales.Rows(e.RowIndex).Cells(9).Value.ToString
                    .txtCancelBy.Text = str_user
                    .txtRemarks.Text = dgvDailySales.Rows(e.RowIndex).Cells(10).Value.ToString
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadSale()
    End Sub

    'cancelled order
    Sub LoadCancelOrder()
        Try
            dgvCancelOrder.Rows.Clear()
            Dim refund As Double = 0
            Dim i As Integer
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from vwcancelorder where sdate between #" & sdate & "# and #" & sdate & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dgvCancelOrder.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("cname").ToString, dr.Item("transno").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"), CDate(dr.Item("sdate").ToString).ToShortDateString, dr.Item("voidby").ToString, dr.Item("cancelledby").ToString, dr.Item("reason").ToString, dr.Item("saction").ToString, dr.Item("remarks").ToString)
            End While
            dr.Close()
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(total + discount)), '0', sum(total + discount)) as total from tblcancelorder where sdate between #" & sdate & "# and #" & sdate & "# and remarks = 'Paid'", cn)
            refund = CDbl(cm.ExecuteScalar)
            cn.Close()

            lblCTotal.Text = Format(refund, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    'debt
    Sub LoadDebt()
        Try
            dgvDebt.Rows.Clear()
            Dim total As Double
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbldebt where sdate between #" & sdate & "# and #" & sdate & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                total += CDbl(dr.Item("total"))
                dgvDebt.Rows.Add(dr.Item("transno").ToString, dr.Item("cname").ToString, dr.Item("cuser").ToString, Format(dr.Item("amount"), "#,##0.00").ToString, Format(dr.Item("adjustment"), "#,##0.00").ToString, Format(dr.Item("total"), "#,##0.00").ToString, dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString), Format(CDate(dr.Item("datetocollect").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            lblDTotal.Text = Format(total, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    'expense
    Sub LoadExpense()
        Try
            dgvExpense.Rows.Clear()
            Dim Rexpense As Double
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblexpense where sdate between #" & sdate & "# and #" & sdate & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvExpense.Rows.Add(dr.Item("expense").ToString, dr.Item("cuser").ToString, dr.Item("receiver").ToString, Format(dr.Item("amount"), "#,##0.00").ToString, dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as expense from tblexpense where sdate between #" & sdate & "# and #" & sdate & "#", cn)
            Rexpense = CDbl(cm.ExecuteScalar)
            lblETotal.Text = Format(Rexpense, currencysymbol & "#,##0.00")
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class