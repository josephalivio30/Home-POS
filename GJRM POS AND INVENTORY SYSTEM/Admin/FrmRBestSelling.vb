Public Class FrmRBestSelling
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Sub LoadBestSelling()
        Try
            dgvBestSelling.Rows.Clear()
            cn.Open()
            Dim i As Integer
            sdate1 = Bdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Bdt2.Value.ToString("yyyy-MM-dd")
            cm = New OleDb.OleDbCommand("SELECT tblproduct.pcode, tblproduct.pdesc, tblcart.price, Sum(tblcart.qty) AS qty, (tblcart.price * Sum(tblcart.qty)) as total
                                        FROM tblcart INNER JOIN tblproduct ON tblcart.pcode = tblproduct.pcode where sdate between #" & sdate1 & "# and #" & sdate2 & "#
                                        GROUP BY tblproduct.pcode, tblproduct.pdesc, tblcart.price
                                        ORDER BY Sum(tblcart.qty) DESC;
                                        ", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dgvBestSelling.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.0"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Sdt1_ValueChanged(sender As Object, e As EventArgs) Handles Bdt1.ValueChanged
        LoadBestSelling()
    End Sub

    Private Sub Sdt2_ValueChanged(sender As Object, e As EventArgs) Handles Bdt2.ValueChanged
        LoadBestSelling()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnBPrint.Click
        sql = "SELECT tblproduct.pcode, tblproduct.pdesc, tblcart.price, Sum(tblcart.qty) AS qty, (tblcart.price * Sum(tblcart.qty)) as total
                                        FROM tblcart INNER JOIN tblproduct ON tblcart.pcode = tblproduct.pcode where sdate between #" & sdate1 & "# and #" & sdate2 & "#
                                        GROUP BY tblproduct.pcode, tblproduct.pdesc, tblcart.price
                                        ORDER BY Sum(tblcart.qty) DESC;
                                        "
        With FrmPrintBestSelling
            .PrintPreview(sql)
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class