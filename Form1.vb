Public Class Ashley_TheaterRevenue1

    Private Sub frmAshley_TheaterRevenue1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ATS_PPT_Box.Focus() 'Load focus
        Dim dtmSystemDate As Date 'Declared to retrieve current date from system
        dtmSystemDate = Now
        tdyDate.Text = Today.ToString("D") 'Display current date

    End Sub

    Private Sub TextBox1GotFocus(sender As Object, e As EventArgs) Handles ATS_PPT_Box.GotFocus

        ATS_PPT_Box.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox1LostFocus(sender As Object, e As EventArgs) Handles ATS_PPT_Box.LostFocus
        ATS_PPT_Box.BackColor = Color.White
    End Sub
    Private Sub TextBox2GotFocus(sender As Object, e As EventArgs) Handles ATS_TS_Box.GotFocus
        ATS_TS_Box.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox2LostFocus(sender As Object, e As EventArgs) Handles ATS_TS_Box.LostFocus
        ATS_TS_Box.BackColor = Color.White
    End Sub
    Private Sub TextBox3GotFocus(sender As Object, e As EventArgs) Handles CTS_PPT_Box.GotFocus
        CTS_PPT_Box.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox3LostFocus(sender As Object, e As EventArgs) Handles CTS_PPT_Box.LostFocus
        CTS_PPT_Box.BackColor = Color.White
    End Sub
    Private Sub TextBox4GotFocus(sender As Object, e As EventArgs) Handles CTS_TS_Box.GotFocus
        CTS_TS_Box.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox4LostFocus(sender As Object, e As EventArgs) Handles CTS_TS_Box.LostFocus
        CTS_TS_Box.BackColor = Color.White

    End Sub

    Private Sub CtrButtonClick(sender As Object, e As EventArgs) Handles ctrButton.Click 'Declared variables for calculation:

        Dim decGrossAdultTicketSales As Decimal    'Gross adult sales
        Dim decGrossChildTicketSales As Decimal     'Gross child sales
        Dim decTotalGrossRevenue As Decimal        'Total gross adult + child
        Dim decNetAdultTicketSales As Decimal      'Net adult tickets
        Dim decNetChildTicketSales As Decimal     'Net child tickets
        Dim decTotalNetRevenue As Decimal        'Total net adult + child
        Const decCORPORATE_VAMPIRES As Decimal = CDec(0.2)  'The 20% revenue the box office keeps
        Dim totalCount As Decimal  'Total number of all tickets sold

        Try

            decGrossAdultTicketSales = CDec(ATS_PPT_Box.Text) * CDec(ATS_TS_Box.Text) 'Calculate gross adult sales
            GTR_ATS_Box.Text = decGrossAdultTicketSales.ToString("c") 'Display results
            decGrossChildTicketSales = CDec(CTS_PPT_Box.Text) * CDec(CTS_TS_Box.Text) 'Calculate gross child sales
            GTR_CTS_Box.Text = decGrossChildTicketSales.ToString("c") 'Display results
            decTotalGrossRevenue = decGrossAdultTicketSales + decGrossChildTicketSales 'Calculate total gross
            GTR_TGRTS.Text = decTotalGrossRevenue.ToString("c") 'Display results
            decNetAdultTicketSales = decGrossAdultTicketSales * decCORPORATE_VAMPIRES 'Calculate net adult sales
            NTR_ATS_Box.Text = decNetAdultTicketSales.ToString("c") 'Display results
            decNetChildTicketSales = decGrossChildTicketSales * decCORPORATE_VAMPIRES 'Calculate net child sales
            NTR_CTS_Box.Text = decNetChildTicketSales.ToString("c") 'Display results
            decTotalNetRevenue = decTotalGrossRevenue * decCORPORATE_VAMPIRES 'Calculate total net
            NTR_TNRTS.Text = decTotalNetRevenue.ToString("c") 'Display results
            totalCount = CDec(ATS_TS_Box.Text) + CDec(CTS_TS_Box.Text)
            TT_ST.Text = “Total Tickets Sold Today:” & totalCount

        Catch ex As Exception 'Error message
            MessageBox.Show("Error! Numeric values only!")

        End Try

    End Sub

    Private Sub ClrButtonClick(sender As Object, e As EventArgs) Handles clrButton.Click 'Clears all fields

        ATS_PPT_Box.Clear()
        ATS_TS_Box.Clear()
        CTS_PPT_Box.Clear()
        CTS_TS_Box.Clear()
        GTR_ATS_Box.Text = String.Empty
        GTR_CTS_Box.Text = String.Empty
        GTR_TGRTS.Text = String.Empty
        NTR_CTS_Box.Text = String.Empty
        NTR_TNRTS.Text = String.Empty
        NTR_ATS_Box.Text = String.Empty
        GTR_TGRTS.Text = String.Empty
        TT_ST.Text = String.Empty
        ATS_PPT_Box.Focus() 'Returns focus to start position

    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles extButton.Click 'Exit form
        Close()

    End Sub

End Class