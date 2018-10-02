Public Class form_AddNewCustomer

    Dim client_name As String
    Dim client_exists As Boolean

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        Dim FolderPathMain As String

        client_name = text_CustomerName.Text
        client_exists = False

        If client_name = "" Then
            MsgBox("You need to enter a Company Name before continuing.")
            Exit Sub
        Else
            CheckNames()
            If client_exists = True Then
                MsgBox("This company already exists.")
                Exit Sub
            Else
                FolderPathMain = cust_working_dir & client_name
                MkDir(FolderPathMain)
                MkDir(FolderPathMain & "\External Documents")
                MkDir(FolderPathMain & "\Internal Documents")
                MkDir(FolderPathMain & "\General Documents")
                MkDir(FolderPathMain & "\Quotes")

                MsgBox("The Customer Folder has been created.")

                text_CustomerName.Text = ""
                Exit Sub
            End If
        End If

    End Sub

    Private Sub CheckNames()
        If Dir(cust_working_dir & text_CustomerName.Text, vbDirectory) <> "" Then
            client_exists = True
            Exit Sub
        End If
    End Sub

    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub text_CustomerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_CustomerName.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This character is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub

End Class