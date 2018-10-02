Public Class form_MainMenu
    Private Sub button_CustomerCenter_Click(sender As Object, e As EventArgs) Handles button_CustomerCenter.Click
        'MsgBox("This feature is not yet active!")
        form_CustomerCenter.Show()
    End Sub

    Private Sub button_VendorCenter_Click(sender As Object, e As EventArgs) Handles button_VendorCenter.Click
        'MsgBox("This feature is not yet active!")
        form_VendorCenter.Show()
    End Sub

    Private Sub button_WorkOrders_Click(sender As Object, e As EventArgs) Handles button_WorkOrders.Click
        form_WorkOrders.Show()
    End Sub

    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        'EXIT BUTTON
        End
    End Sub

    Private Sub button_help_Click(sender As Object, e As EventArgs) Handles button_help.Click
        'MsgBox("This feature is not yet active!")
        info_AboutBox.Show()
    End Sub

    Private Sub form_MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SET GLOBAL vars ON LOAD
        getAppPath()
        setWOworkingDIR()
        setCUSTworkingDIR()
        setVENDworkingDIR()
        'MsgBox(appPath)
    End Sub
End Class