Public Class form_AddNewQuote
    Dim quote_number As String
    Dim quote_exists As Boolean

    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        Dim CurrentYear As String
        Dim FolderPathMain As String
        Dim FolderPathInternal As String
        Dim FolderPathExternal As String

        CurrentYear = Year(Now) & "\"

        quote_number = text_QuoteNumber.Text
        quote_exists = False

        If combo_CustomerName.Text = "" Then
            MsgBox("You need to select a Company Name before continuing.")
        Else
            If quote_number = "" Then
                MsgBox("You need to enter a Quote Number before continuing.")
            Else
                CheckQuote()
                If quote_exists = True Then
                    MsgBox("This Quote folder already exists.")
                Else
                    On Error Resume Next
                    FolderPathMain = cust_working_dir & combo_CustomerName.Text
                    MkDir(FolderPathMain & "\Quotes\" & CurrentYear)
                    MkDir(FolderPathMain & "\Quotes\" & CurrentYear & "\" & quote_number)
                    FolderPathExternal = FolderPathMain & "\Quotes\" & CurrentYear & "\" & quote_number & "\"
                    MkDir(FolderPathExternal & "Customer RFQ")
                    MkDir(FolderPathExternal & "Cost Analysis")
                    MkDir(FolderPathExternal & "Submitted Quotes")
                    MkDir(FolderPathExternal & "Vendor Quotes")

                    MsgBox("The Quote Folder has been created.")

                    combo_CustomerName.Text = ""
                    text_QuoteNumber.Text = ""

                    Dim folderName = From dir In IO.Directory.GetDirectories(cust_working_dir)
                                     Select IO.Path.GetFileName(dir)

                    combo_CustomerName.Items.AddRange(folderName.ToArray)

                End If
            End If
        End If
    End Sub

    Private Sub CheckQuote()
        Dim QuotePath As String
        Dim CurrentYear As String

        CurrentYear = Year(Now) & "\"

        QuotePath = cust_working_dir & combo_CustomerName.Text & "\Quotes\" & CurrentYear & "\" & text_QuoteNumber.Text

        If Dir(QuotePath, vbDirectory) <> "" Then
            quote_exists = True
            Exit Sub
        End If

    End Sub

    Private Sub form_AddNewQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim folderName = From dir In IO.Directory.GetDirectories(cust_working_dir)
                         Select IO.Path.GetFileName(dir)

        combo_CustomerName.Items.AddRange(folderName.ToArray)

    End Sub

    Private Sub text_QuoteNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QuoteNumber.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This character is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub

End Class