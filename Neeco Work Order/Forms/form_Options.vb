Public Class form_Options

    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    Private Sub button_About_Click(sender As Object, e As EventArgs) Handles button_About.Click
        info_AboutBox.Show()
    End Sub

    Private Sub button_Customers_Click(sender As Object, e As EventArgs) Handles button_Customers.Click
        options_Customer.Show()
    End Sub

    Private Sub button_ProductTypes_Click(sender As Object, e As EventArgs) Handles button_ProductTypes.Click
        options_ProductType.Show()
    End Sub

    Private Sub button_PSL_Click(sender As Object, e As EventArgs) Handles button_PSL.Click
        options_PSL.Show()
    End Sub

    Private Sub button_ShipTerms_Click(sender As Object, e As EventArgs) Handles button_ShipTerms.Click
        options_ShippingTerms.Show()
    End Sub

    Private Sub button_Sizes_Click(sender As Object, e As EventArgs) Handles button_Sizes.Click
        options_Sizes.Show()
    End Sub

    Private Sub button_Styles_Click(sender As Object, e As EventArgs) Handles button_Styles.Click
        options_Styles.Show()
    End Sub

    Private Sub button_TempClasses_Click(sender As Object, e As EventArgs) Handles button_TempClasses.Click
        options_TempClasses.Show()
    End Sub

    Private Sub button_Trims_Click(sender As Object, e As EventArgs) Handles button_Trims.Click
        options_Trims.Show()
    End Sub

    Private Sub button_PressureRatings_Click(sender As Object, e As EventArgs) Handles button_PressureRatings.Click
        options_PressureRatings.Show()
    End Sub

    Private Sub button_PR_Click(sender As Object, e As EventArgs) Handles button_PR.Click
        options_PR.Show()
    End Sub

    Private Sub button_Operators_Click(sender As Object, e As EventArgs) Handles button_Operators.Click
        options_OperatorStyles.Show()
    End Sub

    Private Sub button_Changelog_Click(sender As Object, e As EventArgs) Handles button_Changelog.Click
        form_changelog.Show()
    End Sub
End Class