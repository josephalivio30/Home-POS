Public Class FrmDiscount
    Dim _id As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub Discount()
        Try
            If (txtDiscount.Text = String.Empty) Then
                MsgBox("Please input correct amount", vbExclamation)
                Return
            End If
            If CDbl(txtDiscount.Text) < 0 Then
                MsgBox("Please enter correct amount.", vbExclamation)
                Return
            End If

            If CDbl(txtDiscount.Text) >= 0 Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblcart Set discount = @discount, total = @total where  id = @id", cn)
                With cm
                    .Parameters.AddWithValue("@discount", CDbl(txtDiscount.Text))
                    .Parameters.AddWithValue("@total", CDbl(txtTotal.Text))
                    .Parameters.AddWithValue("@id", lblID.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()

                With FrmPOS
                    .LoadCart()
                End With
                Me.Dispose()
            End If

            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        Try
            Dim _sub As Double = CDbl(txtSubTotal.Text)
            Dim _discount As Double = CDbl(txtDiscount.Text)
            If _discount > 0 Then
                txtTotal.Text = Format(_sub - _discount, "#,##0.00")

            ElseIf _discount = 0 Then
                txtTotal.Text = Format(_sub, "#,##0.00")
            End If
        Catch ex As Exception
            txtTotal.Text = "0.00"
        End Try
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Discount()
    End Sub
    Private Sub FrmDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            Discount()
        End If
    End Sub
    Private Sub FrmDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

End Class