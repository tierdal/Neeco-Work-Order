Public Class form_VendorCenter
    Private Sub button_NewVendor_Click(sender As Object, e As EventArgs) Handles button_NewVendor.Click
        form_AddNewVendor.Show()
    End Sub

    Private Sub button_NewVPO_Click(sender As Object, e As EventArgs) Handles button_NewVPO.Click
        form_AddNewVPOfolder.Show()
    End Sub

    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        'EXIT BUTTON
        Me.Close()
    End Sub
End Class