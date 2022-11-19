Public Class FrmRBestSelling
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Sub LoadBestSelling()
        Try
            dgvBestSelling.Rows.Clear()

            Dim i As Integer

            sdate1 = Bdt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Bdt2.Value.ToString("yyyy-MM-dd")
            sql1 = "SELECT tblproduct.pcode, tblproduct.pdesc, tblcart.price, Sum(tblcart.qty) AS qty, (tblcart.price * Sum(tblcart.qty)) as total
                                        FROM tblcart INNER JOIN tblproduct ON tblcart.pcode = tblproduct.pcode where tblcart.sdate between #" & sdate1 & "# and #" & sdate2 & "#
                                        GROUP BY tblproduct.pcode, tblproduct.pdesc, tblcart.price
                                        ORDER BY Sum(tblcart.qty) DESC"
            sql2 = "SELECT Top 10 tblproduct.pcode, tblproduct.pdesc, tblcart.price, Sum(tblcart.qty) AS qty, (tblcart.price * Sum(tblcart.qty)) as total
                                        FROM tblcart INNER JOIN tblproduct ON tblcart.pcode = tblproduct.pcode where tblcart.sdate between #" & sdate1 & "# and #" & sdate2 & "#
                                        GROUP BY tblproduct.pcode, tblproduct.pdesc, tblcart.price
                                        ORDER BY Sum(tblcart.qty) DESC"
            cn.Open()
            If cboTop.Text = "All" Then
                cm = New OleDb.OleDbCommand(sql1, cn)
            ElseIf cboTop.Text = "Top 10" Then
                cm = New OleDb.OleDbCommand(sql2, cn)
            End If

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

    Private Sub Bdt2_ValueChanged(sender As Object, e As EventArgs) Handles Bdt2.ValueChanged
        If Bdt1.Value > Bdt2.Value Then
            Bdt2.Value = Bdt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadBestSelling()
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnBPrint.Click
        Try
            If cboTop.Text = "All" Then
                sql = sql1
            ElseIf cboTop.Text = "Top 10" Then
                sql = sql2
            End If

            With FrmPrintBestSelling
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

    Private Sub FrmRBestSelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRBestSelling_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cboTop_TextChanged(sender As Object, e As EventArgs) Handles cboTop.SelectedIndexChanged
        LoadBestSelling()
    End Sub

    Private Sub cboTop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTop.KeyPress
        e.Handled = True
    End Sub
End Class