Public Class FrmDebtPayment
    Dim amount As String
    Dim sdate As String = Now.ToString("yyyy-MM-dd")
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Private Sub txtBt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBT.KeyPress, txtCASH.KeyPress, txtGcash.KeyPress, txtCheque.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
    Sub ValidatePayment()
        If txtBT.Text = String.Empty Then
            txtBT.Text = "0.00"
        ElseIf txtCASH.Text = String.Empty Then
            txtCASH.Text = "0.00"
        ElseIf txtGcash.Text = String.Empty Then
            txtGcash.Text = "0.00"
        ElseIf txtCheque.Text = String.Empty Then
            txtCheque.Text = "0.00"
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ValidatePayment()
        SaveDebtPayment()
    End Sub
    Private Sub FrmDebtPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmDebtPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Escape Then
            ValidatePayment()
            SaveDebtPayment()
        End If
    End Sub
    Sub SaveDebtPayment()
        Try
            Dim total As Double = CDbl(txtBT.Text) + CDbl(txtCASH.Text) + CDbl(txtGcash.Text) + CDbl(txtCheque.Text)
            If total > CDbl(txtTAmount.Text) Then
                MsgBox("Cash is over the amount needed! Please enter correct amount.", vbCritical)
                Return
            Else
                If txtTransno.Text = "PAY ALL" Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("insert into tbldebthistory (transno, cname, cuser, amount, banktransfer, gcash, cash, stime, sdate)values(@transno, @cname, @cuser, @amount, @banktransfer, @gcash, @cash, @stime, @sdate)", cn)
                    With cm
                        .Parameters.AddWithValue("@transno", txtTransno.Text)
                        .Parameters.AddWithValue("@cname", txtName.Text)
                        .Parameters.AddWithValue("@cuser", str_user)
                        .Parameters.AddWithValue("@amount", CDbl("" + txtTAmount.Text))
                        .Parameters.AddWithValue("@banktransfer", CDbl("" + txtBT.Text))
                        .Parameters.AddWithValue("@gcash", CDbl("" + txtCASH.Text))
                        .Parameters.AddWithValue("@cash", CDbl("" + txtGcash.Text))
                        .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                        .Parameters.AddWithValue("@sdate", sdate)

                        .ExecuteNonQuery()
                    End With
                    cn.Close()

                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblsales as s inner join tbldebt as d on s.transno = d.transno set remarks = 'Paid' where s.transno = d.transno", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tblcart as c inner join tbldebt as d on c.transno = d.transno set remarks = 'Paid' where c.transno = d.transno", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    cn.Open()
                    cm = New OleDb.OleDbCommand("delete from tbldebt where cname like '" & txtName.Text & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                Else
                    'else not pay all
                    'subtract amount from tbldebt
                    cn.Open()
                    cm = New OleDb.OleDbCommand("update tbldebt set total = total - '" & total & "' where transno like '" & txtTransno.Text & "' and cname like '" & txtName.Text & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    'extract amount from tbldebt
                    cn.Open()
                    cm = New OleDb.OleDbCommand("select total from tbldebt where transno like '" & txtTransno.Text & "' and cname like '" & txtName.Text & "'", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        total = dr.Item("total")
                    End If
                    cn.Close()
                    dr.Close()

                    'update tblsales and tblcart to paid
                    If total = "0" Then
                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblsales set remarks = 'Paid' where transno like '" & txtTransno.Text & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        cn.Open()
                        cm = New OleDb.OleDbCommand("update tblcart set remarks = 'Paid' where transno like '" & txtTransno.Text & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                    End If

                    cn.Open()
                    cm = New OleDb.OleDbCommand("insert into tbldebthistory (transno, cname, cuser, amount, banktransfer, gcash, cheque, cash, stime, sdate)values(@transno, @cname, @cuser, @amount, @banktransfer, @gcash, @cheque, @cash, @stime, @sdate)", cn)
                    With cm
                        .Parameters.AddWithValue("@transno", txtTransno.Text)
                        .Parameters.AddWithValue("@cname", txtName.Text)
                        .Parameters.AddWithValue("@cuser", str_user)
                        .Parameters.AddWithValue("@amount", CDbl("" + txtTAmount.Text))
                        .Parameters.AddWithValue("@banktransfer", CDbl("" + txtBT.Text))
                        .Parameters.AddWithValue("@gcash", CDbl("" + txtCASH.Text))
                        .Parameters.AddWithValue("@cheque", CDbl("" + txtCheque.Text))
                        .Parameters.AddWithValue("@cash", CDbl("" + txtGcash.Text))
                        .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                        .Parameters.AddWithValue("@sdate", sdate)
                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                End If

                'delete rows
                cn.Open()
                cm = New OleDb.OleDbCommand("delete from tbldebt where amount = 0", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("Debt Payment successfully saved", vbInformation)
                With FrmRDebt
                    .cboName.Text = "ALL NAMES"
                    .LoadDebt()
                    .LoadName()
                End With
                AuditTrail(txtName.Text & " paid the debt amounting " & Format(CDbl(total), "#,#0.00"))
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class