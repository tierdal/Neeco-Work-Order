Public Class form_AddNewEntry

    'LOADING SUB
    Private Sub form_AddNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = False
        Dim splashScreen = New LoadingScreen()
        splashScreen.Show()

        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Trim' table. You can move, or remove it, as needed.
        Me.Tbl_term_TrimTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Trim)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_TempClass' table. You can move, or remove it, as needed.
        Me.Tbl_term_TempClassTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_TempClass)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Style' table. You can move, or remove it, as needed.
        Me.Tbl_term_StyleTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Style)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Size' table. You can move, or remove it, as needed.
        Me.Tbl_term_SizeTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Size)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_PSL' table. You can move, or remove it, as needed.
        Me.Tbl_term_PSLTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_PSL)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_ProductType' table. You can move, or remove it, as needed.
        Me.Tbl_term_ProductTypeTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_ProductType)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Pressure' table. You can move, or remove it, as needed.
        Me.Tbl_term_PressureTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Pressure)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_PR' table. You can move, or remove it, as needed.
        Me.Tbl_term_PRTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_PR)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_HHPP' table. You can move, or remove it, as needed.
        Me.Tbl_term_HHPPTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_HHPP)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_WOnum' table. You can move, or remove it, as needed.
        Me.Tbl_WOnumTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_WOnum)

        Clear_Form()

        date_WOdate.Select()

        PullWOnum()

        splashScreen.Close()
        Me.Visible = True

    End Sub

    'EXIT THE FORM
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    'ACTUAL BUTTON CLICK TO CLEAR THE FORM
    Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
        'CLEAR FORM BUTTON
        Clear_Form()
    End Sub

    'RESETS THE FORM TO DEFAULT VIEW
    Sub Clear_Form()
        'Clears Form by resetting all values

        'NOTES
        text_Notes.Text = ""

        'WO FIELDS
        date_WOdate.Value = Date.Today
        combo_Status.SelectedItem = ""
        combo_Process.SelectedItem = ""
        date_DueDate.Value = Date.Today
        text_Qty.Text = ""

        'PRODUCT FIELDS
        text_PartNum.Text = ""
        combo_Operator.SelectedIndex = -1
        combo_PR.SelectedIndex = -1
        combo_Pressure.SelectedIndex = -1
        combo_ProductType.SelectedIndex = -1
        combo_PSL.SelectedIndex = -1
        combo_Size.SelectedIndex = -1
        combo_Style.SelectedIndex = -1
        combo_TempClass.SelectedIndex = -1
        combo_Trim.SelectedIndex = -1
        check_BO.Checked = False

    End Sub

    'PULLS THE WORK ORDER NUMBER FROM THE DB
    Sub PullWOnum()
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPullWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim wo_num_string As String
        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryPullWOnum.Connection = sql_conn

        'write SQL query
        sql_queryPullWOnum.CommandText = "SELECT fld_WOnum FROM tbl_WOnum WHERE ID = 1"
        Try
            text_WOnum.Text = ""
            sql_conn.Open()
            wo_num_string = Convert.ToString(sql_queryPullWOnum.ExecuteScalar())
            sql_conn.Close()
            'update the WO number
            text_WOnum.Text = wo_num_string
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    'UPDATES THE WORK ORDER NUMBER IN THE DB 
    Sub PushWOnum()
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPushWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim wo_num_string As String
        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryPushWOnum.Connection = sql_conn

        'update WO number (+1)
        wo_num_string = text_WOnum.Text + 1

        'write SQL query
        sql_queryPushWOnum.CommandText = "UPDATE tbl_WOnum SET fld_WOnum = @WOnum WHERE ID = 1"
        sql_queryPushWOnum.Parameters.AddWithValue("@WOnum", wo_num_string)
        Try
            sql_conn.Open()
            sql_queryPushWOnum.ExecuteNonQuery()
            sql_conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    'submits a new record to the database based on the entered values
    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Submit form
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryInsertData As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim current_user As String
        Dim is_repair As String = 0

        'UPDATE WO NUMBER
        PullWOnum()

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryInsertData.Connection = sql_conn

        'gets username for auditing purposes
        current_user = Environ("Username")

        If combo_Process.Text = "REPAIR" Then is_repair = 1

        'validate data
        'If combo_Customer1.Text = "" Then
        '    MsgBox("Please select Customer")
        '    Exit Sub
        'End If
        'If text_PartNum.Text = "" Then
        '    MsgBox("Please type a Part Number")
        '    Exit Sub
        'End If
        If combo_Status.Text = "" Then
            MsgBox("Please select a Status")
            Exit Sub
        End If
        If combo_Process.Text = "" Then
            MsgBox("Please select a Process")
            Exit Sub
        End If
        If text_Qty.Text = "" Then
            MsgBox("Please type a Quantity")
            Exit Sub
        End If

        'generate Query

        sql_queryInsertData.CommandText = "INSERT INTO tbl_data_WOlog([fld_wo_num],[fld_wo_date],[fld_status],[fld_process],[fld_due_date],[fld_qty],[fld_part_num],[fld_product],[fld_style],[fld_size],[fld_pressure],[fld_tempclass],[fld_trim],[fld_psl],[fld_pr],[fld_hhpp],[fld_buyout],[fld_isrepair],[fld_notes],[fld_CreatedBy],[fld_CreatedByDate],[fld_LastModifiedBy],[fld_LastModifiedDate])VALUES(@WONUM,@WODATE,@STATUS,@PROCESS,@DUEDATE,@QTY,@PARTNUM,@PRODUCT,@STYLE,@SIZE,@PRESSURE,@TEMPCLASS,@TRIM,@PSL,@PR,@HHPP,@BUYOUT,@REPAIR,@NOTES,@CREATEDBY,@CREATEDBYDATE,@MODIFIEDBY,@MODIFIEDBYDATE)"
        sql_queryInsertData.Parameters.AddWithValue("@WONUM", text_WOnum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@WODATE", date_WOdate.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@STATUS", combo_Status.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PROCESS", combo_Process.Text)
        sql_queryInsertData.Parameters.AddWithValue("@DUEDATE", date_DueDate.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@QTY", text_Qty.Text)

        sql_queryInsertData.Parameters.AddWithValue("@PARTNUM", text_PartNum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PRODUCT", combo_ProductType.Text)
        sql_queryInsertData.Parameters.AddWithValue("@STYLE", combo_Style.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SIZE", combo_Size.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PRESSURE", combo_Pressure.Text)
        sql_queryInsertData.Parameters.AddWithValue("@TEMPCLASS", combo_TempClass.Text)
        sql_queryInsertData.Parameters.AddWithValue("@TRIM", combo_Trim.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PSL", combo_PSL.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PR", combo_PR.Text)
        sql_queryInsertData.Parameters.AddWithValue("@HHPP", combo_Operator.Text)
        sql_queryInsertData.Parameters.AddWithValue("@BUYOUT", check_BO.CheckState)
        sql_queryInsertData.Parameters.AddWithValue("@REPAIR", is_repair)

        sql_queryInsertData.Parameters.AddWithValue("@NOTES", text_Notes.Text)

        sql_queryInsertData.Parameters.AddWithValue("@CREATEDBY", current_user)
        sql_queryInsertData.Parameters.AddWithValue("@CREATEDBYDATE", Date.Today)
        sql_queryInsertData.Parameters.AddWithValue("@MODIFIEDBY", current_user)
        sql_queryInsertData.Parameters.AddWithValue("@MODIFIEDBYDATE", Date.Today)

        'On Error Resume Next
        'execute Query - sql insert into access db
        Try
            sql_conn.Open()
            sql_queryInsertData.ExecuteNonQuery()
            MsgBox("The Work Order has been submitted!" & Environment.NewLine & "Your WO Number is: " & text_WOnum.Text & Environment.NewLine & "Thank You!")
            sql_conn.Close()
            CreateWOfolder()
            'CreateShippingFolder()
            PushWOnum()
            Clear_Form()
            PullWOnum()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'GENERATE A FOLDER STRUCTURE FOR THE WORK ORDER DOCUMENTS 
    '\\ad.neecovalves.com\Local File Server\Work Orders\
    Sub CreateWOfolder()
        Dim wo_number As String
        Dim CurrentYear As String
        Dim FolderPathMain As String
        Dim FolderPathInternal As String
        Dim FolderPathExternal As String

        CurrentYear = Year(Now) & "\"

        wo_number = text_WOnum.Text

        On Error Resume Next
        FolderPathMain = wo_working_dir & CurrentYear
        MkDir(FolderPathMain)
        MkDir(FolderPathMain & wo_number)
        MkDir(FolderPathMain & wo_number & "\" & "Production")
        MkDir(FolderPathMain & wo_number & "\" & "Test Charts")

        ' MsgBox("The WO Folders have been created.")

    End Sub

    'CAUSES VALIDATION TO MAKE SURE ONLY NUMBERS ARE ENTERED
    Private Sub text_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_Qty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class