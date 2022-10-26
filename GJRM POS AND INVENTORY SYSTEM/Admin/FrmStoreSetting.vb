﻿Public Class FrmStoreSetting
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadSetting()
        If CheckSetting() = True Then
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblsetting", cn)
            dr = cm.ExecuteReader
            dr.Read()
            txtShopName.Text = dr.Item("shopname").ToString
            txtHeader1.Text = dr.Item("h1").ToString
            txtHeader2.Text = dr.Item("h2").ToString
            txtHeader3.Text = dr.Item("h3").ToString
            cn.Close()
            dr.Close()
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub
    Function CheckSetting() As Boolean
        Dim found As Boolean
        cn.Open()
        cm = New OleDb.OleDbCommand("select * from tblsetting", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            found = True
        Else
            found = False
        End If
        dr.Close()
        cn.Close()
        Return found
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Save this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("insert into tblsetting(shopname,h1,h2,h3)values(@shopname,@h1,@h2,@h3)", cn)
                cm.Parameters.AddWithValue("@shopname", txtShopName.Text)
                cm.Parameters.AddWithValue("@h1", txtHeader1.Text)
                cm.Parameters.AddWithValue("@h2", txtHeader2.Text)
                cm.Parameters.AddWithValue("@h3", txtHeader3.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved", vbInformation)
                btnSave.Enabled = True

                If CheckSetting() = True Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("select * from tblsetting", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    _shopname = dr.Item("shopname").ToString
                    _h1 = dr.Item("h1").ToString
                    _h2 = dr.Item("h2").ToString
                    _h3 = dr.Item("h3").ToString
                    cn.Close()
                    dr.Close()
                    Me.Dispose()
                End If
                FrmMain.lblShopName.Text = _shopname
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("Update the settings?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDb.OleDbCommand("update tblsetting set shopname = @shopname, h1 = @h1, h2 = @h2, h3 = @h3", cn)
                cm.Parameters.AddWithValue("@shopname", txtShopName.Text)
                cm.Parameters.AddWithValue("@h1", txtHeader1.Text)
                cm.Parameters.AddWithValue("@h2", txtHeader2.Text)
                cm.Parameters.AddWithValue("@h3", txtHeader3.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                AuditTrail("Updated settings")
                MsgBox("Record has been successfully updated.", vbInformation)

                If CheckSetting() = True Then
                    cn.Open()
                    cm = New OleDb.OleDbCommand("select * from tblsetting", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    _shopname = dr.Item("shopname").ToString
                    _h1 = dr.Item("h1").ToString
                    _h2 = dr.Item("h2").ToString
                    _h3 = dr.Item("h3").ToString
                    cn.Close()
                    dr.Close()

                    Me.Dispose()
                End If
                FrmMain.lblShopName.Text = _shopname
            End If
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmStoreSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmStoreSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
End Class