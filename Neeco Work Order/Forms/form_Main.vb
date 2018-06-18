Public Class form_Main
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        'EXIT BUTTON
        End
    End Sub

    Private Sub button_About_Click(sender As Object, e As EventArgs) Handles button_About.Click
        'BUTTON TO OPEN ADDITIONAL OPTIONS DIALOG WHICH LETS USERS TO ADD ITEMS TO DATA FIELDS
        form_Options.Show()
    End Sub

    Private Sub button_ViewWO_Click(sender As Object, e As EventArgs) Handles button_ViewWO.Click
        'BUTTON TO OPEN EXCEL WITH WORK ORDERS LOADED VIA A QUERY TO THE DB
        Dim wo_File As String = "\\neecosvr1\1.  Quality\WORK ORDER\WO App\Work Order Log.xlsx"

        If System.IO.File.Exists(wo_File) = True Then
            Process.Start(wo_File)
        Else
            'Stop execution of file doesn't exist
            MsgBox("Error. File Does Not Exist! Exiting...")
            Exit Sub
        End If

    End Sub

    Private Sub button_AddNewWO_Click(sender As Object, e As EventArgs) Handles button_AddNewWO.Click
        'BUTTON TO OPEN form_AddNewEntry AND APPEND A NEW WO ENTRY TO THE DB
        form_AddNewEntry.Show()
    End Sub

    Private Sub button_EditWO_Click(sender As Object, e As EventArgs) Handles button_EditWO.Click
        'BUTTON TO OPEN form_Search AND EDIT THE DATA FOR SELECTED WORK ORDER WHICH WOULD BE EDITABLE ON form_EditEntry
        form_EditEntry.Show()
    End Sub
End Class
