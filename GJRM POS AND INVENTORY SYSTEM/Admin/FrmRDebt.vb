﻿Public Class FrmRDebt
    Dim amount As Double
    Sub LoadDebt()
        Try
            dgvDebt.Rows.Clear()
            Dim debt As Double
            cn.Open()
            If cboName.Text = "ALL NAMES" Then
                cm = New OleDb.OleDbCommand("select * from tbldebt", cn)
            Else
                cm = New OleDb.OleDbCommand("select * from tbldebt where cname like '" & cboName.Text & "'", cn)
            End If
            dr = cm.ExecuteReader
            While dr.Read
                dgvDebt.Rows.Add(dr.Item("transno").ToString, dr.Item("cname").ToString, dr.Item("cuser").ToString, Format(dr.Item("amount"), "#,##0.00").ToString, dr.Item("stime").ToString, Format(CDate(dr.Item("sdate").ToString).ToShortDateString))
            End While
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as debt from tbldebt", cn)
            debt = CDbl(cm.ExecuteScalar)
            cn.Close()
            lblTotal.Text = Format(debt, currencysymbol & "#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadName()
        Try
            cboName.Items.Clear()
            cboName.Items.Add("ALL NAMES")
            cn.Open()
            cm = New OleDb.OleDbCommand("select distinct cname from tbldebt", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboName.Items.Add(UCase(dr.Item("cname").ToString))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        LoadDebt()
    End Sub
    Private Sub cboName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboName.KeyPress
        e.Handled = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRDebt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRDebt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
    Private Sub btnPayAll_Click(sender As Object, e As EventArgs) Handles btnPayAll.Click
        Try
            If cboName.Text = String.Empty Or cboName.Text = "ALL NAMES" Then
                MsgBox("Please choose a name!", vbCritical)
                Return
            Else
                cn.Open()
                cm = New OleDb.OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as amount from tbldebt where cname like '" & cboName.Text & "'", cn)
                amount = CDbl(cm.ExecuteScalar)
                cn.Close()
                With FrmDebtPayment
                    .txtTransno.Text = "PAY ALL"
                    .txtName.Text = cboName.Text
                    .txtTAmount.Text = Format(CDbl(amount), "#,##0.00")
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub dgvDebt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDebt.CellContentClick
        Try
            Dim colname As String = dgvDebt.Columns(e.ColumnIndex).Name
            If colname = "ColEdit" Then
                With frmDebtPayment
                    .txtTransno.Text = dgvDebt.Rows(e.RowIndex).Cells(0).Value.ToString
                    .txtName.Text = dgvDebt.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtTAmount.Text = dgvDebt.Rows(e.RowIndex).Cells(3).Value.ToString
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class