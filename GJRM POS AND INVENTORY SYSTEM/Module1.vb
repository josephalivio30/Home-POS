Imports System.Data.OleDb
Imports Tulpep.NotificationWindow
Module Module1
    Public cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\JOJO GWAPO\OneDrive\Documents\POS.accdb")
    Public cm As New OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public roundT As String = ".0"
    Public str_user, str_pass, str_name, str_role As String
    Public startid As String
    Public _shopname, _h1, _h2, _h3 As String
    Public id, transno As String
    Dim sdate As String = Now.ToString("yyyy-MM-dd")
    Public currencysymbol As String = "₱"

    Public timein As String
    Public timeout As String
    Public sales As Double
    Public startAmount As Double
    Public discount As Double
    Public refund As Double
    Public expense As Double
    Public debt As Double

    'it checks to enable the transaction everyday
    Function CheckStatus() As Boolean
        Try
            Dim found As Boolean
            cn.Open()
            cm = New OleDbCommand("select * from tblstart where sdate between #" & sdate & "# and #" & sdate & "# and status like 'open' and cuser like '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                startid = dr.Item("id").ToString
                found = True
            Else
                found = False
            End If
            dr.Close()
            cn.Close()
            Return found
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
    Sub NotifyCriticalItems()
        Try
            Dim critical As String = ""
            Dim count As String
            cn.Open()
            cm = New OleDbCommand("select count(*) from tblinventorylist WHERE tblproduct.qty <= reorder", cn)
            count = CDbl(cm.ExecuteScalar).ToString
            cn.Close()

            Dim i As Integer = 0
            cn.Open()
            cm = New OleDbCommand("select * from tblinventorylist WHERE tblproduct.qty <= reorder", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                critical += i & ". " & dr.Item("pdesc").ToString & Environment.NewLine
            End While
            cn.Close()
            dr.Close()

            If count = 0 Then
                Return
            Else
                Dim popup As PopupNotifier = New PopupNotifier()
                popup.Image = My.Resources._error
                popup.TitleText = " " & count & " CRITICAL ITEM(S)"
                popup.ContentText = critical
                popup.Popup()
            End If
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub SumOfAll()
        Try
            Dim sdate1 As String = Now.ToString("yyyy-MM-dd")
            Dim sdate2 As String = Now.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New OleDbCommand("select initialcash, timein, timeout from tblstart where sdate between #" & sdate1 & "# and #" & sdate2 & "# and cuser like '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                startAmount = dr.Item("initialcash").ToString
                timein = dr.Item("timein").ToString
                timeout = dr.Item("timeout").ToString
            End If
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDbCommand("select IIf(IsNull(sum(discount)), '0', sum(discount)) as discount, IIf(IsNull(sum(totalbill)), '0', sum(totalbill)) as total from tblsales where sdate between #" & sdate1 & "# and #" & sdate2 & "# and cashier like '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                sales = (Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
                discount = (Format(CDbl(dr.Item("discount").ToString), "#,##0.00"))
            End While
            cn.Close()
            dr.Close()

            cn.Open()
            cm = New OleDbCommand("Select IIf(IsNull(sum(amount)), '0', sum(amount)) as expense from tblexpense where sdate between #" & sdate1 & "# and #" & sdate2 & "# and cuser like '" & str_user & "'", cn)
            expense = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDbCommand("select IIf(IsNull(sum(amount)), '0', sum(amount)) as debt from tbldebt where sdate between #" & sdate1 & "# and #" & sdate2 & "# and cuser like '" & str_user & "'", cn)
            debt = CDbl(cm.ExecuteScalar)
            cn.Close()

            cn.Open()
            cm = New OleDbCommand("select IIf(IsNull(sum(total + discount)), '0', sum(total + discount)) as total from tblcancelorder where sdate between #" & sdate1 & "# and #" & sdate2 & "#", cn)
            refund = CDbl(cm.ExecuteScalar)
            cn.Close()
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    'needed to repair
    Function CheckUserOpen()
        Try
            Dim found As Boolean
            cn.Open()
            cm = New OleDbCommand("select * from tblstart where status = 'open' and sdate between #" & sdate & "# and #" & sdate & "# and cuser <> '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
            Else
                found = False
            End If
            cn.Close()
            dr.Close()
            Return found
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    'checks the start of the day
    Function CheckDay()
        Try
            Dim found As Boolean
            cn.Open()
            cm = New OleDbCommand("select * from tblstart where sdate between #" & sdate & "# and #" & sdate & "#", cn)
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
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    'check if the status is open and can still continue to transact
    Function CheckTransaction() As Boolean
        Try
            Dim isOpen As Boolean
            cn.Open()
            cm = New OleDbCommand("select * from tblstart where ID like '" & startid & "' and status like 'open' and cuser like '" & str_user & "'", cn)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                isOpen = True
            Else
                isOpen = False
            End If
            dr.Close()
            cn.Close()
            Return isOpen
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    'counts record in the database
    Function CountRecords(ByVal sql As String) As Boolean
        Dim count As Integer
        cn.Open()
        cm = New OleDbCommand(sql, cn)
        count = CInt(cm.ExecuteScalar)
        cn.Close()
        Return count
    End Function

    Sub AuditTrail(ByVal summary)
        Try
            cn.Open()
            cm = New OleDbCommand("insert into tblaudit(cuser, summary, sdate, stime)values(@cuser, @summary, @sdate, @stime)", cn)
            With cm
                .Parameters.AddWithValue("@cuser", str_user)
                .Parameters.AddWithValue("@summary", summary)
                .Parameters.AddWithValue("@sdate", Now.ToString("MM-dd-yyyy"))
                .Parameters.AddWithValue("@stime", Now.ToShortTimeString)
                .ExecuteNonQuery()
            End With
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LogHistory(ByVal ptype As String)
        Try
            If ptype = "IN" Then
                cn.Open()
                cm = New OleDbCommand("insert into tbllog(cuser,sdate,timein)values(@cuser,@sdate,@timein)", cn)
                With cm
                    .Parameters.AddWithValue("@cuser", str_user)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .Parameters.AddWithValue("@timein", Now.ToString("hh:mm:ss tt"))
                    .ExecuteNonQuery()
                End With
            Else
                cn.Open()
                cm = New OleDbCommand("select max(id) as id from tbllog where cuser = @cuser and sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@cuser", str_user)
                cm.Parameters.AddWithValue("@sdate", sdate)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then id = dr.Item("id").ToString
                cn.Close()

                cn.Open()
                cm = New OleDbCommand("update tbllog set status = 'Offline', timeout = '" & Now.ToString("hh:mm:ss tt") & "' where id like '" & id & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    'display content on the administator side
    Sub Dashboard()
        Try
            With FrmMain
                cn.Open()
                cm = New OleDbCommand("select count(*) from tblproduct", cn)
                Dim totalproduct As Integer = CInt(cm.ExecuteScalar)
                .lblTotalProduct.Text = Format(totalproduct, "#,##0.0")
                cn.Close()

                cn.Open()
                cm = New OleDbCommand("Select IIf(IsNull(sum(totalbill)), '0', sum(totalbill)) as total from tblsales where sdate between #" & sdate & "# and #" & sdate & "#", cn)
                Dim daily As Double = CDbl(cm.ExecuteScalar)
                .lblDailySales.Text = Format(daily, currencysymbol & "#,##0.00")
                cn.Close()

                cn.Open()
                cm = New OleDbCommand("select IIf(IsNull(sum(qty)), '0', sum(qty)) as total from tblproduct", cn)
                Dim stockonhand As Double = CDbl(cm.ExecuteScalar)
                .lblStockOnHand.Text = Format(stockonhand, "#,##0.0")
                cn.Close()

                cn.Open()
                cm = New OleDbCommand("select count(*) from tblinventorylist WHERE tblproduct.qty <= reorder", cn)
                Dim critical As Double = CDbl(cm.ExecuteScalar)
                .lblCriticalItem.Text = Format(critical, "#,##0.0")
                cn.Close()

            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Module
