Public Class FrmRBestSelling
    Dim sdate1 As String
    Dim sdate2 As String
    Sub LoadBestSelling()
        dgvBestSelling.Rows.Clear()
        cn.Open()
        Dim i As Integer
        sdate1 = Sdt1.Value.ToString("yyyy-MM-dd")
        sdate2 = Sdt2.Value.ToString("yyyy-MM-dd")
        cm = New OleDb.OleDbCommand("SELECT tblproduct.pcode, tblproduct.pdesc, tblcart.price, Sum(tblcart.qty) AS SumOfqty
                                        FROM tblcart INNER JOIN tblproduct ON tblcart.pcode = tblproduct.pcode where sdate between #" & sdate1 & "# and #" & sdate2 & "#
                                        GROUP BY tblproduct.pcode, tblproduct.pdesc, tblcart.price
                                        ORDER BY Sum(tblcart.qty) DESC;
                                        ", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            dgvBestSelling.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("SumOfqty").ToString), "#,##0.0"), Format(CDbl(dr.Item("price").ToString) * CDbl(dr.Item("SumOfqty").ToString), "#,##0.00"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Sdt1_ValueChanged(sender As Object, e As EventArgs) Handles Sdt1.ValueChanged
        LoadBestSelling()
    End Sub

    Private Sub Sdt2_ValueChanged(sender As Object, e As EventArgs) Handles Sdt2.ValueChanged
        LoadBestSelling()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class