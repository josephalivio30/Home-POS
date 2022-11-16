Public Class FrmRAuditTrail
    Dim sdate1 As String
    Dim sdate2 As String
    Private Sub FrmAuditTrail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Sub LoadAuditTrail()
        Try
            dgvAuditTrail.Rows.Clear()
            sdate1 = Adt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Adt2.Value.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tblaudit where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvAuditTrail.Rows.Add(dr.Item("id").ToString, dr.Item("cuser").ToString, dr.Item("summary").ToString, Format(CDate(dr.Item("sdate")), "MM-dd-yyyy").ToString, dr.Item("stime").ToString)
            End While
            cn.Close()
            dr.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub Adt1_ValueChanged(sender As Object, e As EventArgs) Handles Adt1.ValueChanged
        If Adt1.Value > Adt2.Value Then
            Adt1.Value = Adt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadAuditTrail()
    End Sub
    Private Sub Adt2_ValueChanged(sender As Object, e As EventArgs) Handles Adt2.ValueChanged
        If Adt1.Value > Adt2.Value Then
            Adt2.Value = Adt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadAuditTrail()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRAuditTrail_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub
End Class