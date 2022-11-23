Public Class FrmPrintTodaySales
    Dim texttoprint As String
    Dim sdate = Now.ToString("MM-dd-yyyy")

    Sub LoadTodaySales()
        Try
            SumOfAll()
            cn.Close()

            texttoprint &= "CASHIER : " & str_name & Environment.NewLine
            texttoprint &= "DATE : " & Now.ToShortDateString & " " & Environment.NewLine
            texttoprint &= "TIMEIN : " & timein & " " & Environment.NewLine
            texttoprint &= "TIMEOUT : " & timeout & " " & Environment.NewLine
            texttoprint &= "START CASH : " & currencysymbol & Format(CDbl(startamount), "#,##0.00") & Environment.NewLine
            texttoprint &= "DAILY SALES : " & currencysymbol & Format(CDbl(sales), "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL DEBT PAID : " & currencysymbol & Format(CDbl(debtpaid), "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL ADJUSTMENT : " & currencysymbol & Format(CDbl(adjustment), "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL DEBT : " & currencysymbol & Format(CDbl(debt), "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL DISCOUNT : " & currencysymbol & Format(discount, "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL REFUND : " & currencysymbol & Format(refund, "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL EXPENSE : " & currencysymbol & Format(CDbl(expense), "#,##0.00") & Environment.NewLine
            texttoprint &= "TOTAL SALES : " & currencysymbol & Format(CDbl(sales + startAmount + debtpaid) - (expense + debt + adjustment), "#,##0.00") & Environment.NewLine
            texttoprint &= "BANKTRANSFER : " & currencysymbol & Format(CDbl(banktransfer), "#,##0.00") & Environment.NewLine
            texttoprint &= "GCASH : " & currencysymbol & Format(CDbl(gcash), "#,##0.00") & Environment.NewLine
            texttoprint &= "CHEQUE : " & currencysymbol & Format(CDbl(cheque), "#,##0.00") & Environment.NewLine
            texttoprint &= "CASH : " & currencysymbol & Format(CDbl(cash), "#,##0.00") & Environment.NewLine
            texttoprint &= Environment.NewLine

            rtbSales.Text = texttoprint
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub rtbSales_MouseDown(sender As Object, e As MouseEventArgs) Handles rtbSales.MouseDown
        Me.Focus()
        rtbSales.SelectionStart = rtbSales.TextLength
        rtbSales.SelectionLength = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Static currentchar As Integer
            Dim textfont As Font = New Font("Verdana", 7, FontStyle.Bold)

            Dim h, w As Integer
            Dim left, top As Integer
            With PrintDocument1.DefaultPageSettings
                h = 0
                w = 0
                left = 0
                top = 0
            End With

            Dim lines As Integer = CInt(Math.Round(h / 1))
            Dim b As New Rectangle(left, top, w, h)
            Dim format As StringFormat
            format = New StringFormat(StringFormatFlags.LineLimit)
            Dim line, chars As Integer


            e.Graphics.MeasureString(Mid(texttoprint, currentchar + 1), textfont, New SizeF(w, h), format, chars, line)
            e.Graphics.DrawString(texttoprint.Substring(currentchar, chars), New Font("Verdana", 7, FontStyle.Regular), Brushes.Black, b, format)

            currentchar = currentchar + chars
            If currentchar < texttoprint.Length Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                currentchar = 0
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub PrintReceipt()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If MsgBox("Do you want to print Daily Sales", vbYesNo + vbQuestion) = vbYes Then
            PrintReceipt()
        End If
    End Sub

    Private Sub FrmPrintTodaySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub FrmPrintTodaySales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf Keys.KeyCode = Keys.Enter Then
            btnPrint_Click(sender, e)
        End If
    End Sub
End Class