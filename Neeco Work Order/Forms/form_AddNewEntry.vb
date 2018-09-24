Public Class form_AddNewEntry

    'LOADING SUB
    Private Sub form_AddNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers10' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers10TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers10)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers9' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers9TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers9)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers8' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers8TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers8)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers7' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers7TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers7)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers6' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers6TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers6)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers5' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers5TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers5)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers4' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers4TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers4)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet1.tbl_term_Customers3' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers3TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers3)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet1.tbl_term_Customers2' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers2TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers2)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers1' table. You can move, or remove it, as needed.
        Me.Tbl_term_Customers1TableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers1)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Trim' table. You can move, or remove it, as needed.
        Me.Tbl_term_TrimTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Trim)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_TempClass' table. You can move, or remove it, as needed.
        Me.Tbl_term_TempClassTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_TempClass)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Style' table. You can move, or remove it, as needed.
        Me.Tbl_term_StyleTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Style)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Size' table. You can move, or remove it, as needed.
        Me.Tbl_term_SizeTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Size)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_ShipMethod' table. You can move, or remove it, as needed.
        'Me.Tbl_term_ShipMethodTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_ShipMethod)
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
        text_QBBAnum.Text = ""
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

        'SHIP FIELDS
        text_POnum1.Text = ""
        text_POnum2.Text = ""
        text_POnum3.Text = ""
        text_POnum4.Text = ""
        text_POnum5.Text = ""
        text_POnum6.Text = ""
        text_POnum7.Text = ""
        text_POnum8.Text = ""
        text_POnum9.Text = ""
        text_POnum10.Text = ""
        combo_Customer1.SelectedIndex = -1
        combo_Customer2.SelectedIndex = -1
        combo_Customer3.SelectedIndex = -1
        combo_Customer4.SelectedIndex = -1
        combo_Customer5.SelectedIndex = -1
        combo_Customer6.SelectedIndex = -1
        combo_Customer7.SelectedIndex = -1
        combo_Customer8.SelectedIndex = -1
        combo_Customer9.SelectedIndex = -1
        combo_Customer10.SelectedIndex = -1
        text_QtyShip1.Text = ""
        text_QtyShip2.Text = ""
        text_QtyShip3.Text = ""
        text_QtyShip4.Text = ""
        text_QtyShip5.Text = ""
        text_QtyShip6.Text = ""
        text_QtyShip7.Text = ""
        text_QtyShip8.Text = ""
        text_QtyShip9.Text = ""
        text_QtyShip10.Text = ""
        date_ShipDate1.Value = Date.Today
        date_ShipDate2.Value = Date.Today
        date_ShipDate3.Value = Date.Today
        date_ShipDate4.Value = Date.Today
        date_ShipDate5.Value = Date.Today
        date_ShipDate6.Value = Date.Today
        date_ShipDate7.Value = Date.Today
        date_ShipDate8.Value = Date.Today
        date_ShipDate9.Value = Date.Today
        date_ShipDate10.Value = Date.Today
        text_Ticket1.Text = ""
        text_Ticket2.Text = ""
        text_Ticket3.Text = ""
        text_Ticket4.Text = ""
        text_Ticket5.Text = ""
        text_Ticket6.Text = ""
        text_Ticket7.Text = ""
        text_Ticket8.Text = ""
        text_Ticket9.Text = ""
        text_Ticket10.Text = ""

    End Sub

    'PULLS THE WORK ORDER NUMBER FROM THE DB
    Sub PullWOnum()
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPullWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim wo_num_string As String
        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
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
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
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
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryInsertData.Connection = sql_conn

        'gets username for auditing purposes
        current_user = Environ("Username")

        If combo_Status.Text = "REPAIR" Then is_repair = 1

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
        If text_Qty.Text = "" Then
            MsgBox("Please type a Quantity")
            Exit Sub
        End If

        'generate Query
        sql_queryInsertData.CommandText = "INSERT INTO tbl_data_WOlog([fld_wo_num],[fld_wo_date],[fld_status],[fld_qb_ba_num],[fld_qty],[fld_part_num],[fld_product],[fld_style],[fld_size],[fld_pressure],[fld_tempclass],[fld_trim],[fld_psl],[fld_pr],[fld_hhpp],[fld_buyout],[fld_isrepair],[fld_notes],[fld_s1_po],[fld_s1_customer],[fld_s1_qty],[fld_s1_date],[fld_s1_ticket],[fld_s2_po],[fld_s2_customer],[fld_s2_qty],[fld_s2_date],[fld_s2_ticket],[fld_s3_po],[fld_s3_customer],[fld_s3_qty],[fld_s3_date],[fld_s3_ticket],[fld_s4_po],[fld_s4_customer],[fld_s4_qty],[fld_s4_date],[fld_s4_ticket],[fld_s5_po],[fld_s5_customer],[fld_s5_qty],[fld_s5_date],[fld_s5_ticket],[fld_s6_po],[fld_s6_customer],[fld_s6_qty],[fld_s6_date],[fld_s6_ticket],[fld_s7_po],[fld_s7_customer],[fld_s7_qty],[fld_s7_date],[fld_s7_ticket],[fld_s8_po],[fld_s8_customer],[fld_s8_qty],[fld_s8_date],[fld_s8_ticket],[fld_s9_po],[fld_s9_customer],[fld_s9_qty],[fld_s9_date],[fld_s9_ticket],[fld_s10_po],[fld_s10_customer],[fld_s10_qty],[fld_s10_date],[fld_s10_ticket],[fld_CreatedBy],[fld_CreatedByDate],[fld_LastModifiedBy],[fld_LastModifiedDate])VALUES(@WONUM,@WODATE,@STATUS,@QBBANUM,@QTY,@PARTNUM,@PRODUCT,@STYLE,@SIZE,@PRESSURE,@TEMPCLASS,@TRIM,@PSL,@PR,@HHPP,@BUYOUT,@REPAIR,@NOTES,@PONUM1,@CUSTOMER1,@SHIPQTY1,@SHIPDATE1,@TICKET1,@PONUM2,@CUSTOMER2,@SHIPQTY2,@SHIPDATE2,@TICKET2,@PONUM3,@CUSTOMER3,@SHIPQTY3,@SHIPDATE3,@TICKET3,@PONUM4,@CUSTOMER4,@SHIPQTY4,@SHIPDATE4,@TICKET4,@PONUM5,@CUSTOMER5,@SHIPQTY5,@SHIPDATE5,@TICKET5,@PONUM6,@CUSTOMER6,@SHIPQTY6,@SHIPDATE6,@TICKET6,@PONUM7,@CUSTOMER7,@SHIPQTY7,@SHIPDATE7,@TICKET7,@PONUM8,@CUSTOMER8,@SHIPQTY8,@SHIPDATE8,@TICKET8,@PONUM9,@CUSTOMER9,@SHIPQTY9,@SHIPDATE9,@TICKET9,@PONUM10,@CUSTOMER10,@SHIPQTY10,@SHIPDATE10,@TICKET10,@CREATEDBY,@CREATEDBYDATE,@MODIFIEDBY,@MODIFIEDBYDATE)"
        sql_queryInsertData.Parameters.AddWithValue("@WONUM", text_WOnum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@WODATE", date_WOdate.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@STATUS", combo_Status.Text)
        sql_queryInsertData.Parameters.AddWithValue("@QBBANUM", text_QBBAnum.Text)
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

        sql_queryInsertData.Parameters.AddWithValue("@PONUM1", text_POnum1.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER1", combo_Customer1.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY1", text_QtyShip1.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE1", date_ShipDate1.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET1", text_Ticket1.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM2", text_POnum2.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER2", combo_Customer2.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY2", text_QtyShip2.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE2", date_ShipDate2.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET2", text_Ticket2.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM3", text_POnum3.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER3", combo_Customer3.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY3", text_QtyShip3.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE3", date_ShipDate3.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET3", text_Ticket3.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM4", text_POnum4.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER4", combo_Customer4.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY4", text_QtyShip4.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE4", date_ShipDate4.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET4", text_Ticket4.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM5", text_POnum5.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER5", combo_Customer5.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY5", text_QtyShip5.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE5", date_ShipDate5.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET5", text_Ticket5.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM6", text_POnum6.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER6", combo_Customer6.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY6", text_QtyShip6.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE6", date_ShipDate6.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET6", text_Ticket6.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM7", text_POnum7.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER7", combo_Customer7.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY7", text_QtyShip7.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE7", date_ShipDate7.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET7", text_Ticket7.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM8", text_POnum8.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER8", combo_Customer8.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY8", text_QtyShip8.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE8", date_ShipDate8.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET8", text_Ticket8.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM9", text_POnum9.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER9", combo_Customer9.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY9", text_QtyShip9.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE9", date_ShipDate9.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET9", text_Ticket9.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM10", text_POnum10.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER10", combo_Customer10.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPQTY10", text_QtyShip10.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE10", date_ShipDate10.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@TICKET10", text_Ticket10.Text)

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
        FolderPathMain = "\\ad.neecovalves.com\Local File Server\Work Orders\" & CurrentYear
        MkDir(FolderPathMain)
        MkDir(FolderPathMain & wo_number)
        MkDir(FolderPathMain & wo_number & "\" & "Production")
        MkDir(FolderPathMain & wo_number & "\" & "Quality")
        MkDir(FolderPathMain & wo_number & "\" & "Shipping")
        MkDir(FolderPathMain & wo_number & "\" & "Purchasing")

        ' MsgBox("The WO Folders have been created.")

    End Sub

    'GENERATE A FOLDER STRUCTURE FOR EACH SHIPMENT FOR THE WORK ORDER
    'Sub CreateShippingFolder()
    '    Dim wo_number As String
    '    Dim CurrentYear As String
    '    Dim wo_year As String
    '    Dim FolderPathMain As String
    '    Dim FolderPathInternal As String
    '    Dim FolderPathExternal As String

    '    wo_year = Year(date_WOdate.Value.Date) & "\"
    '    CurrentYear = Year(Now)

    '    wo_number = text_WOnum.Text

    '    On Error Resume Next
    '    FolderPathMain = "\\ad.neecovalves.com\Local File Server\Work Orders\" & wo_year & wo_number & "\" & "Shipping\"

    '    If Not text_POnum1.Text = "" Or combo_Customer1.Text = "" Or combo_Customer1.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text & "\" & text_POnum1.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text & "\" & text_POnum1.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text & "\" & text_POnum1.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text & "\" & text_POnum1.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer1.Text & "\" & text_POnum1.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum2.Text = "" Or combo_Customer2.Text = "" Or combo_Customer2.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text & "\" & text_POnum2.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text & "\" & text_POnum2.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text & "\" & text_POnum2.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text & "\" & text_POnum2.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer2.Text & "\" & text_POnum2.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum3.Text = "" Or combo_Customer3.Text = "" Or combo_Customer3.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text & "\" & text_POnum3.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text & "\" & text_POnum3.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text & "\" & text_POnum3.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text & "\" & text_POnum3.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer3.Text & "\" & text_POnum3.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum4.Text = "" Or combo_Customer4.Text = "" Or combo_Customer4.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text & "\" & text_POnum4.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text & "\" & text_POnum4.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text & "\" & text_POnum4.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text & "\" & text_POnum4.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer4.Text & "\" & text_POnum4.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum5.Text = "" Or combo_Customer5.Text = "" Or combo_Customer5.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text & "\" & text_POnum5.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text & "\" & text_POnum5.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text & "\" & text_POnum5.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text & "\" & text_POnum5.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer5.Text & "\" & text_POnum5.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum6.Text = "" Or combo_Customer6.Text = "" Or combo_Customer6.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text & "\" & text_POnum6.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text & "\" & text_POnum6.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text & "\" & text_POnum6.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text & "\" & text_POnum6.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer6.Text & "\" & text_POnum6.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum7.Text = "" Or combo_Customer7.Text = "" Or combo_Customer7.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text & "\" & text_POnum7.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text & "\" & text_POnum7.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text & "\" & text_POnum7.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text & "\" & text_POnum7.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer7.Text & "\" & text_POnum7.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum8.Text = "" Or combo_Customer8.Text = "" Or combo_Customer8.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text & "\" & text_POnum8.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text & "\" & text_POnum8.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text & "\" & text_POnum8.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text & "\" & text_POnum8.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer8.Text & "\" & text_POnum8.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum9.Text = "" Or combo_Customer9.Text = "" Or combo_Customer9.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text & "\" & text_POnum9.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text & "\" & text_POnum9.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text & "\" & text_POnum9.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text & "\" & text_POnum9.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer9.Text & "\" & text_POnum9.Text & "\" & "Other")
    '    End If
    '    If Not text_POnum10.Text = "" Or combo_Customer10.Text = "" Or combo_Customer10.Text = "Stock" Then
    '        MkDir(FolderPathMain & CurrentYear)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text & "\" & text_POnum10.Text)
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text & "\" & text_POnum10.Text & "\" & "Shipping Docs")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text & "\" & text_POnum10.Text & "\" & "Quality")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text & "\" & text_POnum10.Text & "\" & "Customer PO")
    '        MkDir(FolderPathMain & CurrentYear & "\" & combo_Customer10.Text & "\" & text_POnum10.Text & "\" & "Other")
    '    End If

    '    'MsgBox("The PO Folders have been created.")

    'End Sub

    'CAUSES VALIDATION TO MAKE SURE ONLY NUMBERS ARE ENTERED
    Private Sub text_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_Qty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip4.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip5.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip6.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip7.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip8.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip9.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_QtyShip10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_QtyShip10.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    'CAUSES VALIDATION TO CHECK THAT ONLY VALID ITEMS ARE ENTERED
    Private Sub text_POnum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum1.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum2.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum3.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum4.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum5.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum6.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum7.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum8.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum9.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
    Private Sub text_POnum10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_POnum10.KeyPress
        Dim KeyAsciiString As String
        KeyAsciiString = e.KeyChar

        If KeyAsciiString = "/" Or KeyAsciiString = "\" Or KeyAsciiString = ":" Or KeyAsciiString = "*" Or KeyAsciiString = "?" Or KeyAsciiString = """" Or KeyAsciiString = "<" Or KeyAsciiString = ">" Or KeyAsciiString = "|" Then
            MsgBox("This key is not allowed: " & KeyAsciiString)
            e.Handled = True
        End If
    End Sub
End Class