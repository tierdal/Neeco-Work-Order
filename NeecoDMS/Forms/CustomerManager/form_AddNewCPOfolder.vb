Public Class form_AddNewCPOfolder
    Dim po_number As String
    Dim po_exists As Boolean

    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        Dim CurrentYear As String
        Dim FolderPathMain As String
        Dim FolderPathInternal As String
        Dim FolderPathExternal As String

        CurrentYear = Year(Now) & "\"

        po_number = text_POnumber.Text
        po_exists = False

        If combo_CustomerName.Text = "" Then
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
                    FolderPathMain = cust_working_dir & combo_CustomerName.Text
                    MkDir(FolderPathMain & "\External Documents\" & CurrentYear)
                    MkDir(FolderPathMain & "\Internal Documents\" & CurrentYear)
                    MkDir(FolderPathMain & "\External Documents\" & CurrentYear & "\" & po_number)
                    MkDir(FolderPathMain & "\Internal Documents\" & CurrentYear & "\" & po_number)
                    FolderPathExternal = FolderPathMain & "\External Documents\" & CurrentYear & "\" & po_number & "\"
                    MkDir(FolderPathExternal & "Invoices")
                    MkDir(FolderPathExternal & "Quality Documents")
                    MkDir(FolderPathExternal & "Shipping Documents")
                    MkDir(FolderPathExternal & "Customer Purchase Order")
                    FolderPathInternal = FolderPathMain & "\Internal Documents\" & CurrentYear & "\" & po_number & "\"
                    MkDir(FolderPathInternal & "Other Documents")
                    MkDir(FolderPathInternal & "Production Documents")
                    MkDir(FolderPathInternal & "Purchasing Documents")

                    MsgBox("The Customer PO Folder has been created.")

                    combo_CustomerName.Text = ""
                    text_POnumber.Text = ""

                    Dim folderName = From dir In IO.Directory.GetDirectories(cust_working_dir)
                                     Select IO.Path.GetFileName(dir)

                    combo_CustomerName.Items.AddRange(folderName.ToArray)

                End If
            End If
        End If
    End Sub

    Private Sub CheckPO()
        Dim PathExternal As String
        Dim PathInternal As String
        Dim CurrentYear As String

        CurrentYear = Year(Now) & "\"

        PathExternal = cust_working_dir & combo_CustomerName.Text & "\External Documents\" & CurrentYear & "\" & text_POnumber.Text
        PathInternal = cust_working_dir & combo_CustomerName.Text & "\Internal Documents\" & CurrentYear & "\" & text_POnumber.Text

        If Dir(PathExternal, vbDirectory) <> "" Then
            po_exists = True
            Exit Sub
        End If
        If Dir(PathInternal, vbDirectory) <> "" Then
            po_exists = True
            Exit Sub
        End If
    End Sub

    Private Sub form_AddNewCPOfolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim folderName = From dir In IO.Directory.GetDirectories(cust_working_dir)
                         Select IO.Path.GetFileName(dir)

        combo_CustomerName.Items.AddRange(folderName.ToArray)

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