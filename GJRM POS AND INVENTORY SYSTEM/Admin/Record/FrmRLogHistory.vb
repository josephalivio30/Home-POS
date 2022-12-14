Public Class FrmRLogHistory
    Dim sdate1 As String
    Dim sdate2 As String
    Dim sql As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Sub LoadLogHistory()
        Try
            sdate1 = Ldt1.Value.ToString("yyyy-MM-dd")
            sdate2 = Ldt2.Value.ToString("yyyy-MM-dd")
            dgvLogHistory.Rows.Clear()
            cn.Open()
            cm = New OleDb.OleDbCommand("select * from tbllog where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvLogHistory.Rows.Add(dr.Item("cuser").ToString, Format(CDate(dr.Item("sdate")), "MM-dd-yyyy"), dr.Item("timein").ToString, dr.Item("timeout").ToString, dr.Item("status").ToString)
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub Ldt1_ValueChanged(sender As Object, e As EventArgs) Handles Ldt1.ValueChanged
        If Ldt1.Value > Ldt2.Value Then
            Ldt1.Value = Ldt2.Value
            MsgBox("From date must be lower or equal to the To date", vbExclamation)
        End If
        LoadLogHistory()
    End Sub
    Private Sub Ldt2_ValueChanged(sender As Object, e As EventArgs) Handles Ldt2.ValueChanged
        If Ldt1.Value > Ldt2.Value Then
            Ldt2.Value = Ldt1.Value
            MsgBox("From date must be higher or equal to the To date", vbExclamation)
        End If
        LoadLogHistory()
    End Sub
    Private Sub FrmRLogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmRLogHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSPrint_Click(sender As Object, e As EventArgs) Handles btnSPrint.Click
        Try
            sql = "select * from tbllog where sdate between #" & sdate1 & "# and #" & sdate2 & "#"
            With FrmPrintLogHistory
                .PrintPreview(sql)
                .ShowDialog()
            End With
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Class