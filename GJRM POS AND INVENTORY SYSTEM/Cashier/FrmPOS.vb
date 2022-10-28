Public Class FrmPOS
    Dim id As Integer
    Dim total As Double
    Dim discount As Double
    Public price As Double
    Public qty As Integer
    Private Sub FrmPOS_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Top = 0
        Me.Left = 0
    End Sub
    Function GetTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New OleDb.OleDbCommand("select top 1 transno from tblcart where transno like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GetTransno = CLng(dr.Item("transno").ToString) + 1
            Else
                GetTransno = sdate & "0001"
            End If
            dr.Close()
            cn.Close()
            Return GetTransno
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToLongDateString.ToUpper & " | " & Now.ToLongTimeString.ToUpper
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If dgvCart.Rows.Count > 0 Then
            Return
        End If
        lblTransNo.Text = GetTransno()
        txtBarcode.Enabled = True
        txtBarcode.Focus()
    End Sub

    Private Sub FrmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Timer1.Enabled = True
        LoadProducts()
        NotifyCriticalItems()
        If CheckStatus() = True Then
            btnExpense.Enabled = True
            btnDailySales.Enabled = True
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        Dim pcodee As String
        Dim pricee As Double
        Dim qty As Integer

        If txtBarcode.Text = String.Empty Then Return
        Try
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblproduct where barcode like '" & txtBarcode.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.qty = CInt(dr.Item("qty").ToString)
                pcodee = dr.Item("pcode").ToString
                pricee = CDbl(dr.Item("sprice").ToString)
                qty = CInt(txtQty.Text)

                AddtoCart(pcodee, pricee, qty)
                'With FrmQty
                '    .ProductDetails(dr.Item("pcode").ToString, CDbl(dr.Item("sprice").ToString), lblTransNo.Text, CInt(dr.Item("qty").ToString))
                '    .ShowDialog()
                'End With
            Else
                dr.Close()
                cn.Close()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub AddtoCart(ByVal pcode As String, ByVal price As Double, ByVal qty As Integer)
        Try
            Dim cart_qty As Integer
            Dim found As Boolean
            If txtQty.Text = String.Empty Then Return
            cn.Close()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblcart where transno = @transno and pcode = @pcode ", cn)
            With cm
                .Parameters.AddWithValue("@transno", lblTransNo.Text)
                .Parameters.AddWithValue("@pcode", pcode)
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
                If (Me.qty < CInt(txtQty.Text) + CInt(cart_qty)) Then
                    MsgBox("Unable to proceed. Remaining qty onhand is " & qty, vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("update tblcart set qty = qty + @qty where transno = @transno and pcode = @pcode", cn)
                With cm
                    .Parameters.AddWithValue("@qty", CDbl(qty))
                    .Parameters.AddWithValue("@transno", lblTransNo.Text)
                    .Parameters.AddWithValue("@pcode", pcode)
                    .ExecuteNonQuery()
                End With
                cn.Close()


                txtBarcode.SelectionStart = 0
                txtBarcode.SelectionLength = txtBarcode.Text.Length
                LoadCart()
            Else
                If (Me.qty < CInt(txtQty.Text)) Then
                    MsgBox("Unable to proceed. Remaining qty onhand is " & qty, vbExclamation)
                    Return
                End If

                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblcart (transno, pcode, price, qty, sdate, stime, total, cashier)values(@transno, @pcode, @price, @qty, @sdate, @stime, @total, cashier)", cn)
                With cm
                    .Parameters.AddWithValue("@transno", lblTransNo.Text)
                    .Parameters.AddWithValue("@pcode", pcode)
                    .Parameters.AddWithValue("@price", CDbl(price))
                    .Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                    .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                    .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                    .Parameters.AddWithValue("@total", CDbl(price) * CInt(txtQty.Text))
                    .Parameters.AddWithValue("@cashier", str_user)
                End With
                cm.ExecuteNonQuery()
                cn.Close()

            End If
            txtBarcode.SelectionStart = 0
            txtBarcode.SelectionLength = txtBarcode.Text.Length
            LoadCart()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadCart()
        Try
            dgvCart.Rows.Clear()
            Dim total As Double = 0
            Dim discount As Double = 0
            Dim i As Integer
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from ComputeTotal where transno like '" & lblTransNo.Text & "'and status like 'Pending'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                total += CDbl(dr.Item("total").ToString)
                discount += CDbl(dr.Item("discount").ToString)
                dgvCart.Rows.Add(i, dr.Item("id"), dr.Item("pcode").ToString, dr.Item("pdesc").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), dr.Item("qty").ToString & roundT, Format(CDbl(dr.Item("discount").ToString), "#,##0.00"), Format((CDbl(dr.Item("price")) * CDbl(dr.Item("qty"))) - CDbl(dr.Item("discount")), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()

            lblDiscount.Text = Format(discount, "#,##0.00")
            lblTotalBill.Text = Format(total, "#,##0.00")
            lblTotal.Text = Format(CDbl(total), "#,##0.00")

            If dgvCart.Rows.Count < 1 Then
                btnSettle.Enabled = False
                btnApplyDiscount.Enabled = False
                btnDebtPayment.Enabled = False
                'btnPrintBill.Enabled = False
                lblDiscount.Text = "0.00"
                lblTotalBill.Text = "0.00"
                lblTotal.Text = "0.00"
            Else
                'btnPrintBill.Enabled = True
                btnSettle.Enabled = True
                btnApplyDiscount.Enabled = True
                btnDebtPayment.Enabled = True
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadProducts()
        Try
            Dim i As Integer
            dgvProduct.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select tblproduct.pcode, tblproduct.barcode, tblproduct.pdesc, tblbrand.brand, tblcategory.category, tblproduct.sprice, tblproduct.qty from (tblproduct inner join tblbrand on tblproduct.bid = tblbrand.id) inner join tblcategory on tblproduct.cid = tblcategory.id where tblproduct.pdesc like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                dgvProduct.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("barcode").ToString, dr.Item("pdesc").ToString, dr.Item("brand").ToString, dr.Item("category").ToString, Format(CDbl(dr.Item("sprice").ToString), "#,##0.00"), dr.Item("qty").ToString & roundT)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        Try
            Dim colname As String = dgvProduct.Columns(e.ColumnIndex).Name
            If colname = "ColSelect" Then
                If CheckStatus() = False Then
                    MsgBox("Click the Start Menu first", vbExclamation)
                    Return
                End If
                If lblTransNo.Text = String.Empty Then
                    MsgBox("Click the new transaction first", vbExclamation)
                    Return
                Else
                    With FrmQty
                        .ProductDetails(dgvProduct.Rows(e.RowIndex).Cells(1).Value.ToString, dgvProduct.Rows(e.RowIndex).Cells(6).Value.ToString, lblTransNo.Text, dgvProduct.Rows(e.RowIndex).Cells(7).Value.ToString)
                        .ShowDialog()
                    End With
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        Try
            Dim colname As String = dgvCart.Columns(e.ColumnIndex).Name
            If colname = "ColDelete" Then
                If MsgBox("Void this item?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tblcart where id like '" & dgvCart.Rows(e.RowIndex).Cells(1).Value.ToString & "' and status like 'Pending'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Item has been successfully deleted", vbInformation)
                    LoadCart()
                End If
            ElseIf colname = "ColAdd" Then
                Dim i As Integer = 0
                cn.Open()
                cm = New OleDb.OleDbCommand("select sum(qty) from tblproduct where pcode like '" & dgvCart.Rows(e.RowIndex).Cells(2).Value.ToString & "' group by pcode", cn)
                i = CInt(cm.ExecuteScalar)
                cn.Close()

                If CInt(dgvCart.Rows(e.RowIndex).Cells(5).Value.ToString) < i Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblcart set qty = qty + '" & CInt(txtQty.Text) & "' where transno like '" & lblTransNo.Text & "' and pcode like '" & dgvCart.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    LoadCart()
                Else
                    MsgBox("Remaining qty onhand is " & i, vbExclamation)
                End If
            ElseIf colname = "ColMinus" Then
                Dim i As Integer = 0
                cn.Open()
                cm = New OleDb.OleDbCommand("select sum(qty) from tblcart where transno like '" & lblTransNo.Text & "'and pcode like '" & dgvCart.Rows(e.RowIndex).Cells(2).Value.ToString & "' group by transno, pcode", cn)
                i = CInt(cm.ExecuteScalar.ToString)
                cn.Close()

                If i > 1 Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblcart set qty = qty - '" & CInt(txtQty.Text) & "' where transno like '" & lblTransNo.Text & "' and pcode like '" & dgvCart.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    LoadCart()
                Else
                    MsgBox("Remaining qty on cart is " & i, vbExclamation)
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnApplyDiscount_Click(sender As Object, e As EventArgs) Handles btnApplyDiscount.Click
        With FrmDiscount
            .txtSubTotal.Text = Format(CDbl(price) * CDbl(qty), "#,##0.00")
            .txtDiscount.Text = discount
            .lblID.Text = id
            .ShowDialog()
            .txtDiscount.Focus()
        End With
    End Sub

    Private Sub dgvCart_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCart.SelectionChanged
        Dim i As Integer = dgvCart.CurrentRow.Index
        id = dgvCart.Rows(i).Cells(1).Value.ToString
        total = dgvCart.Rows(i).Cells(7).Value.ToString
        discount = dgvCart.Rows(i).Cells(6).Value.ToString
        price = dgvCart.Rows(i).Cells(4).Value.ToString
        qty = dgvCart.Rows(i).Cells(5).Value.ToString
    End Sub

    Private Sub btnSettle_Click(sender As Object, e As EventArgs) Handles btnSettle.Click
        With FrmSettle
            .txtBill.Text = lblTotalBill.Text
            .ShowDialog()
            .txtCash.Focus()
            .txtChange.Text = "0.00"
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Do you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
            LogHistory("OUT")
            FrmLogin.txtUser.Clear()
            FrmLogin.txtPass.Clear()
            FrmLogin.txtUser.Focus()
        End If
    End Sub

    Private Sub btnStartMenu_Click(sender As Object, e As EventArgs) Handles btnStartMenu.Click
        Try
            If CheckUserOpen() = True Then
                MsgBox("Other cashier is still open for transaction", vbCritical)
                Return
            Else
                With FrmStartMenu
                    .Display()
                    .ShowDialog()
                    .txtCashier.Text = str_user
                    .txtStartingCash.Focus()
                End With
            End If
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnDailySales_Click(sender As Object, e As EventArgs) Handles btnDailySales.Click
        With FrmDailySales
            .LoadSale()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        With FrmExpense
            .ShowDialog()
            .txtExpense.Focus()
        End With
    End Sub

    Private Sub btnDebtPayment_Click(sender As Object, e As EventArgs) Handles btnDebtPayment.Click
        With FrmDebt
            .txtDiscount.Text = lblDiscount.Text
            .txtAmount.Text = lblTotalBill.Text
            .txtName.Focus()
            .ShowDialog()
        End With
    End Sub
    Sub LoadAgent()
        Try
            cboAgent.Items.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select agent from tblagent", cn)
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

    Private Sub FrmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If btnStartMenu.Enabled = False Then
                Return
            Else
                btnStartMenu_Click(sender, e)
            End If

        ElseIf e.KeyCode = Keys.F2 Then
            If btnNewOrder.Enabled = False Then
                Return
            Else
                btnNewOrder_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            If btnSettle.Enabled = False Then
                Return
            Else
                btnSettle_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If btnApplyDiscount.Enabled = False Then
                Return
            Else
                btnApplyDiscount_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            If btnDebtPayment.Enabled = False Then
                Return
            Else
                btnDebtPayment_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If btnExpense.Enabled = False Then
                Return
            Else
                btnExpense_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            If btnDailySales.Enabled = False Then
                Return
            Else
                btnDailySales_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            If txtBarcode.Enabled = False Then
                Return
            Else
                txtBarcode.SelectionStart = 0
                txtBarcode.SelectionLength = txtBarcode.Text.Length
                LoadCart()
            End If
        End If
    End Sub
End Class