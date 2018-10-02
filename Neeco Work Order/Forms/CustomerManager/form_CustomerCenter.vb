Public Class form_CustomerCenter
    Private Sub button_NewCustomer_Click(sender As Object, e As EventArgs) Handles button_NewCustomer.Click
        form_AddNewCustomer.Show()
    End Sub

    Private Sub button_NewQuote_Click(sender As Object, e As EventArgs) Handles button_NewQuote.Click
        form_AddNewQuote.Show()
    End Sub

    Private Sub button_NewCPO_Click(sender As Object, e As EventArgs) Handles button_NewCPO.Click
        form_AddNewCPOfolder.Show
    End Sub

    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        'EXIT BUTTON
        Me.Close()
    End Sub
End Class