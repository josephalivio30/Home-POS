Public Class FrmDebt
    Dim total As Double
    Dim pass As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        savedebt()
    End Sub
    Sub savedebt()
        Try
            If txtName.Text = String.Empty Then
                MsgBox("Required empty field.", vbExclamation)
                Return
            End If

            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tblsales(transno, sdate, stime, cashier, total, discount, totalbill)values(@transno, @sdate, @stime, @cashier, @total, @discount, @totalbill)", cn)
            With cm
                .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                .Parameters.AddWithValue("@cashier", str_user)
                .Parameters.AddWithValue("@total", CDbl(FrmPOS.lblTotalBill.Text))
                .Parameters.AddWithValue("@discount", CDbl(FrmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@totalbill", CDbl("" + txtAmount.Text))
                .ExecuteNonQuery()
            End With
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("insert into tbldebt(transno, cname, cuser, amount, stime, sdate)values(@transno, @cname, @cuser, @amount, @stime, @sdate)", cn)
            With cm
                .Parameters.AddWithValue("@transno", FrmPOS.lblTransNo.Text)
                .Parameters.AddWithValue("@cname", txtName.Text)
                .Parameters.AddWithValue("@cuser", str_user)
                .Parameters.AddWithValue("@amount", CDbl("" + txtAmount.Text))
                .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                .Parameters.AddWithValue("@sdate", Now.ToShortDateString)
                .ExecuteNonQuery()
            End With
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("update tblcart set status = 'Completed', remarks = 'Unpaid' where transno like '" & FrmPOS.lblTransNo.Text & "' and status like 'Pending'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("update tblsales set remarks = 'Unpaid' where transno like '" & FrmPOS.lblTransNo.Text & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            MsgBox("Debt successfully saved", vbInformation)
            AuditTrail(txtName.Text & " debt amounting " & txtAmount.Text)
            With FrmPOS
                .lblTransNo.Text = .GetTransno
                .LoadCart()
            End With

            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub frmDebt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub frmDebt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            savedebt()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class