Public Class FrmRExpense
    Dim sdate1 As String
    Dim sdate2 As String
    Dim Rexpense As Double
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadExpense()
        Try
            sdate1 = Edt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Edt2.Value.ToString("yyyy-MM-dd")
            dgvExpense.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblexpense where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvExpense.Rows.Add(dr.Item("expense").ToString, dr.Item("cuser").ToString, dr.Item("receiver").ToString, Format(dr.Item("amount"), "#,##0.00").ToString, dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as expense from tblexpense where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            Rexpense = CDbl(cm.ExecuteScalar)
            lblTotal.Text = Format(Rexpense, currencysymbol & "#,##0.00")
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Edt1_ValueChanged(sender As Object, e As EventArgs) Handles Edt1.ValueChanged
        LoadExpense()
    End Sub

    Private Sub Edt2_ValueChanged(sender As Object, e As EventArgs) Handles Edt2.ValueChanged
        LoadExpense()
    End Sub
    Private Sub FrmRExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRExpense_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class