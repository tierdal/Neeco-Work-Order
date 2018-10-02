Public Class form_AddNewVendor
    Dim vendor_name As String
    Dim vendor_exists As Boolean

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        Dim FolderPathMain As String

        vendor_name = text_VendorName.Text
        vendor_exists = False

        If vendor_name = "" Then
            MsgBox("You need to enter a Vendor Name before continuing.")
        Else
            CheckVendorNames()
            If vendor_exists = True Then
                MsgBox("This company already exists.")
            Else
                FolderPathMain = vend_working_dir & vendor_name
                MkDir(FolderPathMain)
                MkDir(FolderPathMain & "\General Documents")

                MsgBox("The Vendor Folder has been created.")

                text_VendorName.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckVendorNames()
        If Dir(vend_working_dir & text_VendorName.Text, vbDirectory) <> "" Then
            vendor_exists = True
            Exit Sub
        End If
    End Sub

    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub text_VendorName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_VendorName.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This character is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
End Class