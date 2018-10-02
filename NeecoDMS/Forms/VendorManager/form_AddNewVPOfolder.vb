Public Class form_AddNewVPOfolder
    Dim po_number As String
    Dim po_exists As Boolean

    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        Dim CurrentYear As String
        Dim FolderPathMain As String

        CurrentYear = Year(Now) & "\"

        po_number = text_POnumber.Text
        po_exists = False

        If combo_VendorName.Text = "" Then
            MsgBox("You need to select a Company Name before continuing.")
        Else
            If po_number = "" Then
                MsgBox("You need to enter a PO Number before continuing.")
            Else
                CheckPO()
                If po_exists = True Then
                    MsgBox("This PO folder already exists.")
                Else
                    On Error Resume Next
                    FolderPathMain = vend_working_dir & combo_VendorName.Text
                    MkDir(FolderPathMain & "\" & CurrentYear)
                    MkDir(FolderPathMain & "\" & CurrentYear & "\" & po_number)

                    MsgBox("The PO Folder has been created.")

                    combo_VendorName.Text = ""
                    text_POnumber.Text = ""

                    Dim folderName = From dir In IO.Directory.GetDirectories(vend_working_dir)
                                     Select IO.Path.GetFileName(dir)

                    combo_VendorName.Items.AddRange(folderName.ToArray)

                End If
            End If
        End If
    End Sub

    Private Sub CheckPO()
        Dim PO_Path As String
        Dim CurrentYear As String

        CurrentYear = Year(Now) & "\"

        PO_Path = vend_working_dir & combo_VendorName.Text & "\" & CurrentYear & "\" & text_POnumber.Text

        If Dir(PO_Path, vbDirectory) <> "" Then
            po_exists = True
            Exit Sub
        End If
    End Sub

    Private Sub form_AddNewVPOfolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim folderName = From dir In IO.Directory.GetDirectories(vend_working_dir)
                         Select IO.Path.GetFileName(dir)

        combo_VendorName.Items.AddRange(folderName.ToArray)

    End Sub

    Private Sub text_POnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnumber.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This character is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
End Class