﻿Public Class form_EditIEntryNew
    Dim record_status As Boolean = False

    'INITIAL LOADING
    Private Sub form_EditEntryNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        splashScreen.Close()
        Me.Visible = True

        WOsearchSub()

        If record_status = False Then
            Me.Close()
        End If

    End Sub

    'SEARCH AND LOAD ALL RECORDS FROM THE DATABASE
    Sub WOsearchSub()
        Dim wo_num_search As String
        Dim wo_id_pull As String
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPulldata_ID, sql_queryPulldata_WODATE, sql_queryPulldata_STATUS, sql_queryPulldata_PROCESS, sql_queryPulldata_DUEDATE, sql_queryPulldata_QTY, sql_queryPulldata_PARTNUM, sql_queryPulldata_PRODUCT, sql_queryPulldata_STYLE, sql_queryPulldata_SIZE, sql_queryPulldata_PRESSURE, sql_queryPulldata_TEMPCLASS, sql_queryPulldata_TRIM, sql_queryPulldata_PSL, sql_queryPulldata_PR, sql_queryPulldata_HHPP, sql_queryPulldata_BUYOUT, sql_queryPulldata_NOTES, sql_queryPulldata_CREATEDBY, sql_queryPulldata_CREATEDBYDATE, sql_queryPulldata_MODIFIEDBY, sql_queryPulldata_MODIFIEDBYDATE As New OleDb.OleDbCommand
        Dim conn_string As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryPulldata_ID.Connection = sql_conn
        sql_queryPulldata_WODATE.Connection = sql_conn
        sql_queryPulldata_STATUS.Connection = sql_conn
        sql_queryPulldata_PROCESS.Connection = sql_conn
        sql_queryPulldata_DUEDATE.Connection = sql_conn
        sql_queryPulldata_QTY.Connection = sql_conn

        sql_queryPulldata_PARTNUM.Connection = sql_conn
        sql_queryPulldata_PRODUCT.Connection = sql_conn
        sql_queryPulldata_STYLE.Connection = sql_conn
        sql_queryPulldata_SIZE.Connection = sql_conn
        sql_queryPulldata_PRESSURE.Connection = sql_conn
        sql_queryPulldata_TEMPCLASS.Connection = sql_conn
        sql_queryPulldata_TRIM.Connection = sql_conn
        sql_queryPulldata_PSL.Connection = sql_conn
        sql_queryPulldata_PR.Connection = sql_conn
        sql_queryPulldata_HHPP.Connection = sql_conn
        sql_queryPulldata_BUYOUT.Connection = sql_conn

        sql_queryPulldata_NOTES.Connection = sql_conn

        sql_queryPulldata_CREATEDBY.Connection = sql_conn
        sql_queryPulldata_CREATEDBYDATE.Connection = sql_conn
        sql_queryPulldata_MODIFIEDBY.Connection = sql_conn
        sql_queryPulldata_MODIFIEDBYDATE.Connection = sql_conn


        'Search msg
        wo_num_search = InputBox("Please enter a Work Order Number to load it. If you are unsure what the Work Order number is, please refer to the Work Log.", "Search for a WO...")

        'exit if bad string
        If wo_num_search = "" Then
            MsgBox("Invalid Entry, Returning to Main Menu...")
            Exit Sub
        End If

        'FIRST try to get a match
        sql_queryPulldata_ID.CommandText = "SELECT ID FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        Try
            sql_conn.Open()
            wo_id_pull = Convert.ToString(sql_queryPulldata_ID.ExecuteScalar())
            sql_conn.Close()
            If wo_id_pull = "" Then
                MsgBox("Work Order #" & wo_num_search & " was not found in the database." & Environment.NewLine & "Please try again!" & Environment.NewLine & Environment.NewLine & "Returning to Main Menu...")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Returning to Main Menu...")
            Exit Sub
        End Try

        'write SQL queries

        sql_queryPulldata_WODATE.CommandText = "SELECT fld_wo_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_STATUS.CommandText = "SELECT fld_status FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PROCESS.CommandText = "SELECT fld_process FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_DUEDATE.CommandText = "SELECT fld_due_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_QTY.CommandText = "SELECT fld_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"

        sql_queryPulldata_PARTNUM.CommandText = "SELECT fld_part_num FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PRODUCT.CommandText = "SELECT fld_product FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_STYLE.CommandText = "SELECT fld_style FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SIZE.CommandText = "SELECT fld_size FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PRESSURE.CommandText = "SELECT fld_pressure FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TEMPCLASS.CommandText = "SELECT fld_tempclass FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TRIM.CommandText = "SELECT fld_trim FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PSL.CommandText = "SELECT fld_psl FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PR.CommandText = "SELECT fld_pr FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_HHPP.CommandText = "SELECT fld_hhpp FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_BUYOUT.CommandText = "SELECT fld_buyout FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"

        sql_queryPulldata_NOTES.CommandText = "SELECT fld_notes FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"

        'execute SQL

        'IF match is found then pull data
        Try
            text_WOnum.Text = wo_num_search
            sql_conn.Open()

            'make sure we don't try to pull DBNull data because it will throw an error

            If Not IsDBNull(sql_queryPulldata_WODATE.ExecuteScalar()) Then date_WOdate.Value = sql_queryPulldata_WODATE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_STATUS.ExecuteScalar()) Then combo_Status.Text = sql_queryPulldata_STATUS.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PROCESS.ExecuteScalar()) Then combo_Status.Text = sql_queryPulldata_STATUS.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_DUEDATE.ExecuteScalar()) Then date_DueDate.Value = sql_queryPulldata_DUEDATE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_QTY.ExecuteScalar()) Then text_Qty.Text = sql_queryPulldata_QTY.ExecuteScalar()

            If Not IsDBNull(sql_queryPulldata_PARTNUM.ExecuteScalar()) Then text_PartNum.Text = sql_queryPulldata_PARTNUM.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PRODUCT.ExecuteScalar()) Then combo_ProductType.Text = sql_queryPulldata_PRODUCT.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_STYLE.ExecuteScalar()) Then combo_Style.Text = sql_queryPulldata_STYLE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SIZE.ExecuteScalar()) Then combo_Size.Text = sql_queryPulldata_SIZE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PRESSURE.ExecuteScalar()) Then combo_Pressure.Text = sql_queryPulldata_PRESSURE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TEMPCLASS.ExecuteScalar()) Then combo_TempClass.Text = sql_queryPulldata_TEMPCLASS.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TRIM.ExecuteScalar()) Then combo_Trim.Text = sql_queryPulldata_TRIM.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PSL.ExecuteScalar()) Then combo_PSL.Text = sql_queryPulldata_PSL.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PR.ExecuteScalar()) Then combo_PR.Text = sql_queryPulldata_PR.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_HHPP.ExecuteScalar()) Then combo_Operator.Text = sql_queryPulldata_HHPP.ExecuteScalar()

            If Not IsDBNull(sql_queryPulldata_BUYOUT.ExecuteScalar()) Then
                If sql_queryPulldata_BUYOUT.ExecuteScalar() = True Then
                    check_BO.CheckState = 1
                Else
                    check_BO.CheckState = 0
                End If
            End If

            If Not IsDBNull(sql_queryPulldata_NOTES.ExecuteScalar()) Then text_Notes.Text = sql_queryPulldata_NOTES.ExecuteScalar()

            sql_conn.Close()
            record_status = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Returning to Main Menu...")
            Exit Sub
        End Try

    End Sub

    'SUBMIT BUTTON - UPDATE RECORDS IN DATABASE
    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Submit form
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryUpdateData As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim current_user As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryUpdateData.Connection = sql_conn


        current_user = Environ("Username")

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

        'GENERATE QUERY
        sql_queryUpdateData.CommandText = "UPDATE tbl_data_WOlog " &
                                    "SET fld_wo_date='" & date_WOdate.Value.Date &
                                    "', fld_status='" & combo_Status.Text &
                                    "', fld_process='" & combo_Process.Text &
                                    "', fld_due_date='" & date_DueDate.Value.Date &
                                    "', fld_qty='" & text_Qty.Text &
                                    "', fld_part_num='" & text_PartNum.Text &
                                    "', fld_product='" & combo_ProductType.Text &
                                    "', fld_style='" & combo_Style.Text &
                                    "', fld_size='" & combo_Size.Text &
                                    "', fld_pressure='" & combo_Pressure.Text &
                                    "', fld_tempclass='" & combo_TempClass.Text &
                                    "', fld_trim='" & combo_Trim.Text &
                                    "', fld_psl='" & combo_PSL.Text &
                                    "', fld_pr='" & combo_PR.Text &
                                    "', fld_hhpp='" & combo_Operator.Text &
                                    "', fld_buyout='" & check_BO.CheckState &
                                    "', fld_notes='" & text_Notes.Text &
                                    "', fld_LastModifiedBy='" & current_user &
                                    "', fld_LastModifiedDate='" & Date.Today & "'" &
                                    "WHERE fld_wo_num = '" & text_WOnum.Text & "'"

        'execute Query - sql insert into access db
        Try
            sql_conn.Open()
            sql_queryUpdateData.ExecuteNonQuery()
            MsgBox("The Work Order has been updated!" & Environment.NewLine & "Thank You!")
            sql_conn.Close()
            CreateWOfolder()
            'CreateShippingFolder()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Returning to Main Menu...")
            Exit Sub
        End Try

        Me.Close()

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

    'DELETES THE RECORD FROM THE DATABASE
    Private Sub button_Delete_Click(sender As Object, e As EventArgs) Handles button_Delete.Click
        'DELETE ENTRY BUTTON

        'strSql = "DELETE * FROM MATERIALdata WHERE ID = " & sqlStringID & ""

        'ask to confirm delete
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryDeleteWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim confirm_delete As String


        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & wo_working_dir & "WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryDeleteWOnum.Connection = sql_conn

        confirm_delete = InputBox("WARNING!" & Environment.NewLine & "THIS WILL PERMANENTLY DELETE THIS RECORD FROM THE DATABASE." & Environment.NewLine & "Please type 'DELETE' to confirm.", "Deleting Record...")

        If confirm_delete = "DELETE" Then

            'write SQL query
            sql_queryDeleteWOnum.CommandText = "DELETE * FROM tbl_data_WOlog WHERE fld_wo_num = '" & text_WOnum.Text & "'"
            Try
                sql_conn.Open()
                sql_queryDeleteWOnum.ExecuteNonQuery()
                sql_conn.Close()

                MsgBox("Work Order #" & text_WOnum.Text & " has been deleted!")

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

        Else
            MsgBox("Could not confirm deletion.")
            Exit Sub
        End If

    End Sub

    'RESETS THE FORM TO BLANK VALUES FOR LOADING PURPOSES
    Sub Clear_Form()
        'Clears Form by resetting all values

        'NOTES
        text_WOnum.Text = ""

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

    'EXIT BUTTON
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    'CAUSES VALIDATION TO MAKE SURE ONLY NUMBERS ARE ENTERED
    Private Sub text_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_Qty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class