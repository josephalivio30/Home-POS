Public Class FrmQty
    Dim pcodee As String
    Dim pricee As Double
    Dim transnoo As String
    Dim qty As Integer
    Dim cart_qty As Integer
    Private Sub FrmQty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            Save()
        End If
    End Sub
    Sub Save()
        Try
            Dim found As Boolean
            If txtQty.Text = String.Empty Then Return
            cn.Close()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblcart where transno = @transno and pcode = @pcode ", cn)
            With cm
                .Parameters.AddWithValue("@transno", transnoo)
                .Parameters.AddWithValue("@pcode", pcodee)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cart_qty = CInt(dr.Item("qty").ToString)
                found = True
            Else
                found = False
            End If
            dr.Close()
            cn.Close()

            If found = True Then
                If (qty < CInt(txtQty.Text) + CInt(cart_qty)) Then
                    MsgBox("Unable to proceed. Remaining qty on is " & qty, vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("update tblcart set qty = qty + @qty where transno = @transno and pcode = @pcode", cn)
                With cm
                    .Parameters.AddWithValue("@qty", CDbl(txtQty.Text))
                    .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                    .Parameters.AddWithValue("@pcode", pcodee)
                    .ExecuteNonQuery()
                End With
                cn.Close()

            Else
                If (qty < CInt(txtQty.Text)) Then
                    MsgBox("Unable to proceed. Remaining qty on is " & qty, vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcart (transno, pcode, price, qty, sdate, stime, total, cashier)values(@transno, @pcode, @price, @qty, @sdate, @stime, @total, cashier)", cn)
                With cm
                    .Parameters.AddWithValue("@transno", transnoo)
                    .Parameters.AddWithValue("@pcode", pcodee)
                    .Parameters.AddWithValue("@price", CDbl(pricee))
                    .Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                    .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                    .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                    .Parameters.AddWithValue("@total", CDbl(pricee) * CInt(txtQty.Text))
                    .Parameters.AddWithValue("@cashier", str_user)
                End With
                cm.ExecuteNonQuery()
                cn.Close()

            End If

            FrmPOS.LoadCart()
            FrmPOS.txtSearch.Clear()
            FrmPOS.txtSearch.Focus()
            With FrmPOS
                .LoadCart()
            End With

            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmQty_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub
    Sub ProductDetails(ByVal pcode As String, ByVal price As Double, ByVal transno As String, ByVal qty As Integer)
        pcodee = pcode
        pricee = CDbl(price)
        transnoo = transno
        Me.qty = qty
    End Sub

    Private Sub FrmQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            'Case 46 period
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class