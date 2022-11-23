Public Class FrmBestSelling
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Sub LoadBestSelling()
        Try
            dgvBestSelling.Rows.Clear()
            Dim i As Integer
            sdate1 = Bdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Bdt2.Value.ToString("yyyy-MM-dd")
            cn.Open()

            cm = New OleDb.OleDbCommand("select pcode, pdesc, price, IIf(IsNull(sum(qty)), '0', sum(qty)) as qty, IIf(IsNull(sum(qty)), '0', price * sum(qty)) as total from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# GROUP BY pcode, pdesc, price
                                        ORDER BY Sum(qty) DESC", cn)
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
    Private Sub Bdt1_ValueChanged(sender As Object, e As EventArgs) Handles Bdt1.ValueChanged
        If Bdt1.Value > Bdt2.Value Then
            Bdt1.Value = Bdt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadBestSelling()
    End Sub
    Private Sub btnBPrint_Click(sender As Object, e As EventArgs) Handles btnBPrint.Click
        Try
            sql = "select pcode, pdesc, price, IIf(IsNull(sum(qty)), '0', sum(qty)) as qty, IIf(IsNull(sum(qty)), '0', price * sum(qty)) as total from SalesRecord where sdate between #" & sdate1 & "# and #" & sdate2 & "# GROUP BY pcode, pdesc, price
                                        ORDER BY Sum(qty) DESC"
            With FrmPrintBestSelling
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub Bdt2_ValueChanged(sender As Object, e As EventArgs) Handles Bdt2.ValueChanged
        If Bdt1.Value > Bdt2.Value Then
            Bdt2.Value = Bdt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadBestSelling()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRBestSelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRBestSelling_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvBestSelling_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvBestSelling.SortCompare
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