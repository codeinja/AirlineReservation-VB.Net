Public Class Home
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        NewCustomer.ShowDialog()
    End Sub

    Private Sub FlightDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightDetailsToolStripMenuItem.Click
        FlightDetaila.ShowDialog()
    End Sub

    Private Sub TicketReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketReservationToolStripMenuItem.Click
        TicketReservation.ShowDialog()
    End Sub

    Private Sub PaymentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentDetailsToolStripMenuItem.Click
        PaymentDetails.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Report.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class