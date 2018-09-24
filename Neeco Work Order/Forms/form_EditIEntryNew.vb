Public Class form_EditIEntryNew
    Dim record_status As Boolean = False

    'INITIAL LOADING
    Private Sub form_EditEntryNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim sql_queryPulldata_ID, sql_queryPulldata_WODATE, sql_queryPulldata_STATUS, sql_queryPulldata_QBBANUM, sql_queryPulldata_QTY, sql_queryPulldata_PARTNUM, sql_queryPulldata_PRODUCT, sql_queryPulldata_STYLE, sql_queryPulldata_SIZE, sql_queryPulldata_PRESSURE, sql_queryPulldata_TEMPCLASS, sql_queryPulldata_TRIM, sql_queryPulldata_PSL, sql_queryPulldata_PR, sql_queryPulldata_HHPP, sql_queryPulldata_BUYOUT, sql_queryPulldata_NOTES, sql_queryPulldata_PONUM1, sql_queryPulldata_CUSTOMER1, sql_queryPulldata_SHIPQTY1, sql_queryPulldata_SHIPDATE1, sql_queryPulldata_TICKET1, sql_queryPulldata_PONUM2, sql_queryPulldata_CUSTOMER2, sql_queryPulldata_SHIPQTY2, sql_queryPulldata_SHIPDATE2, sql_queryPulldata_TICKET2, sql_queryPulldata_PONUM3, sql_queryPulldata_CUSTOMER3, sql_queryPulldata_SHIPQTY3, sql_queryPulldata_SHIPDATE3, sql_queryPulldata_TICKET3, sql_queryPulldata_PONUM4, sql_queryPulldata_CUSTOMER4, sql_queryPulldata_SHIPQTY4, sql_queryPulldata_SHIPDATE4, sql_queryPulldata_TICKET4, sql_queryPulldata_PONUM5, sql_queryPulldata_CUSTOMER5, sql_queryPulldata_SHIPQTY5, sql_queryPulldata_SHIPDATE5, sql_queryPulldata_TICKET5, sql_queryPulldata_PONUM6, sql_queryPulldata_CUSTOMER6, sql_queryPulldata_SHIPQTY6, sql_queryPulldata_SHIPDATE6, sql_queryPulldata_TICKET6, sql_queryPulldata_PONUM7, sql_queryPulldata_CUSTOMER7, sql_queryPulldata_SHIPQTY7, sql_queryPulldata_SHIPDATE7, sql_queryPulldata_TICKET7, sql_queryPulldata_PONUM8, sql_queryPulldata_CUSTOMER8, sql_queryPulldata_SHIPQTY8, sql_queryPulldata_SHIPDATE8, sql_queryPulldata_TICKET8, sql_queryPulldata_PONUM9, sql_queryPulldata_CUSTOMER9, sql_queryPulldata_SHIPQTY9, sql_queryPulldata_SHIPDATE9, sql_queryPulldata_TICKET9, sql_queryPulldata_PONUM10, sql_queryPulldata_CUSTOMER10, sql_queryPulldata_SHIPQTY10, sql_queryPulldata_SHIPDATE10, sql_queryPulldata_TICKET10, sql_queryPulldata_CREATEDBY, sql_queryPulldata_CREATEDBYDATE, sql_queryPulldata_MODIFIEDBY, sql_queryPulldata_MODIFIEDBYDATE As New OleDb.OleDbCommand
        Dim conn_string As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryPulldata_ID.Connection = sql_conn
        sql_queryPulldata_WODATE.Connection = sql_conn
        sql_queryPulldata_STATUS.Connection = sql_conn
        sql_queryPulldata_QBBANUM.Connection = sql_conn
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

        sql_queryPulldata_PONUM1.Connection = sql_conn
        sql_queryPulldata_CUSTOMER1.Connection = sql_conn
        sql_queryPulldata_SHIPQTY1.Connection = sql_conn
        sql_queryPulldata_SHIPDATE1.Connection = sql_conn
        sql_queryPulldata_TICKET1.Connection = sql_conn
        sql_queryPulldata_PONUM2.Connection = sql_conn
        sql_queryPulldata_CUSTOMER2.Connection = sql_conn
        sql_queryPulldata_SHIPQTY2.Connection = sql_conn
        sql_queryPulldata_SHIPDATE2.Connection = sql_conn
        sql_queryPulldata_TICKET2.Connection = sql_conn
        sql_queryPulldata_PONUM3.Connection = sql_conn
        sql_queryPulldata_CUSTOMER3.Connection = sql_conn
        sql_queryPulldata_SHIPQTY3.Connection = sql_conn
        sql_queryPulldata_SHIPDATE3.Connection = sql_conn
        sql_queryPulldata_TICKET3.Connection = sql_conn
        sql_queryPulldata_PONUM4.Connection = sql_conn
        sql_queryPulldata_CUSTOMER4.Connection = sql_conn
        sql_queryPulldata_SHIPQTY4.Connection = sql_conn
        sql_queryPulldata_SHIPDATE4.Connection = sql_conn
        sql_queryPulldata_TICKET4.Connection = sql_conn
        sql_queryPulldata_PONUM5.Connection = sql_conn
        sql_queryPulldata_CUSTOMER5.Connection = sql_conn
        sql_queryPulldata_SHIPQTY5.Connection = sql_conn
        sql_queryPulldata_SHIPDATE5.Connection = sql_conn
        sql_queryPulldata_TICKET5.Connection = sql_conn
        sql_queryPulldata_PONUM6.Connection = sql_conn
        sql_queryPulldata_CUSTOMER6.Connection = sql_conn
        sql_queryPulldata_SHIPQTY6.Connection = sql_conn
        sql_queryPulldata_SHIPDATE6.Connection = sql_conn
        sql_queryPulldata_TICKET6.Connection = sql_conn
        sql_queryPulldata_PONUM7.Connection = sql_conn
        sql_queryPulldata_CUSTOMER7.Connection = sql_conn
        sql_queryPulldata_SHIPQTY7.Connection = sql_conn
        sql_queryPulldata_SHIPDATE7.Connection = sql_conn
        sql_queryPulldata_TICKET7.Connection = sql_conn
        sql_queryPulldata_PONUM8.Connection = sql_conn
        sql_queryPulldata_CUSTOMER8.Connection = sql_conn
        sql_queryPulldata_SHIPQTY8.Connection = sql_conn
        sql_queryPulldata_SHIPDATE8.Connection = sql_conn
        sql_queryPulldata_TICKET8.Connection = sql_conn
        sql_queryPulldata_PONUM9.Connection = sql_conn
        sql_queryPulldata_CUSTOMER9.Connection = sql_conn
        sql_queryPulldata_SHIPQTY9.Connection = sql_conn
        sql_queryPulldata_SHIPDATE9.Connection = sql_conn
        sql_queryPulldata_TICKET9.Connection = sql_conn
        sql_queryPulldata_PONUM10.Connection = sql_conn
        sql_queryPulldata_CUSTOMER10.Connection = sql_conn
        sql_queryPulldata_SHIPQTY10.Connection = sql_conn
        sql_queryPulldata_SHIPDATE10.Connection = sql_conn
        sql_queryPulldata_TICKET10.Connection = sql_conn

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
        sql_queryPulldata_QBBANUM.CommandText = "SELECT fld_qb_ba_num FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
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

        sql_queryPulldata_PONUM1.CommandText = "SELECT fld_s1_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER1.CommandText = "SELECT fld_s1_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY1.CommandText = "SELECT fld_s1_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE1.CommandText = "SELECT fld_s1_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET1.CommandText = "SELECT fld_s1_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM2.CommandText = "SELECT fld_s2_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER2.CommandText = "SELECT fld_s2_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY2.CommandText = "SELECT fld_s2_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE2.CommandText = "SELECT fld_s2_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET2.CommandText = "SELECT fld_s2_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM3.CommandText = "SELECT fld_s3_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER3.CommandText = "SELECT fld_s3_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY3.CommandText = "SELECT fld_s3_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE3.CommandText = "SELECT fld_s3_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET3.CommandText = "SELECT fld_s3_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM4.CommandText = "SELECT fld_s4_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER4.CommandText = "SELECT fld_s4_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY4.CommandText = "SELECT fld_s4_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE4.CommandText = "SELECT fld_s4_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET4.CommandText = "SELECT fld_s4_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM5.CommandText = "SELECT fld_s5_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER5.CommandText = "SELECT fld_s5_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY5.CommandText = "SELECT fld_s5_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE5.CommandText = "SELECT fld_s5_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET5.CommandText = "SELECT fld_s5_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM6.CommandText = "SELECT fld_s6_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER6.CommandText = "SELECT fld_s6_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY6.CommandText = "SELECT fld_s6_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE6.CommandText = "SELECT fld_s6_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET6.CommandText = "SELECT fld_s6_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM7.CommandText = "SELECT fld_s7_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER7.CommandText = "SELECT fld_s7_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY7.CommandText = "SELECT fld_s7_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE7.CommandText = "SELECT fld_s7_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET7.CommandText = "SELECT fld_s7_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM8.CommandText = "SELECT fld_s8_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER8.CommandText = "SELECT fld_s8_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY8.CommandText = "SELECT fld_s8_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE8.CommandText = "SELECT fld_s8_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET8.CommandText = "SELECT fld_s8_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM9.CommandText = "SELECT fld_s9_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER9.CommandText = "SELECT fld_s9_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY9.CommandText = "SELECT fld_s9_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE9.CommandText = "SELECT fld_s9_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET9.CommandText = "SELECT fld_s9_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_PONUM10.CommandText = "SELECT fld_s10_po FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_CUSTOMER10.CommandText = "SELECT fld_s10_customer FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPQTY10.CommandText = "SELECT fld_s10_qty FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_SHIPDATE10.CommandText = "SELECT fld_s10_date FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"
        sql_queryPulldata_TICKET10.CommandText = "SELECT fld_s10_ticket FROM tbl_data_WOlog WHERE fld_wo_num = '" & wo_num_search & "'"

        'execute SQL

        'IF match is found then pull data
        Try
            text_WOnum.Text = wo_num_search
            sql_conn.Open()

            'make sure we don't try to pull DBNull data because it will throw an error

            If Not IsDBNull(sql_queryPulldata_WODATE.ExecuteScalar()) Then date_WOdate.Value = sql_queryPulldata_WODATE.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_STATUS.ExecuteScalar()) Then combo_Status.Text = sql_queryPulldata_STATUS.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_QBBANUM.ExecuteScalar()) Then text_QBBAnum.Text = sql_queryPulldata_QBBANUM.ExecuteScalar()
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

            If Not IsDBNull(sql_queryPulldata_PONUM1.ExecuteScalar()) Then text_POnum1.Text = sql_queryPulldata_PONUM1.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER1.ExecuteScalar()) Then combo_Customer1.Text = sql_queryPulldata_CUSTOMER1.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY1.ExecuteScalar()) Then text_QtyShip1.Text = sql_queryPulldata_SHIPQTY1.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE1.ExecuteScalar()) Then date_ShipDate1.Value = sql_queryPulldata_SHIPDATE1.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET1.ExecuteScalar()) Then text_Ticket1.Text = sql_queryPulldata_TICKET1.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM2.ExecuteScalar()) Then text_POnum2.Text = sql_queryPulldata_PONUM2.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER2.ExecuteScalar()) Then combo_Customer2.Text = sql_queryPulldata_CUSTOMER2.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY2.ExecuteScalar()) Then text_QtyShip2.Text = sql_queryPulldata_SHIPQTY2.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE2.ExecuteScalar()) Then date_ShipDate2.Value = sql_queryPulldata_SHIPDATE2.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET2.ExecuteScalar()) Then text_Ticket2.Text = sql_queryPulldata_TICKET2.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM3.ExecuteScalar()) Then text_POnum3.Text = sql_queryPulldata_PONUM3.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER3.ExecuteScalar()) Then combo_Customer3.Text = sql_queryPulldata_CUSTOMER3.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY3.ExecuteScalar()) Then text_QtyShip3.Text = sql_queryPulldata_SHIPQTY3.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE3.ExecuteScalar()) Then date_ShipDate3.Value = sql_queryPulldata_SHIPDATE3.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET3.ExecuteScalar()) Then text_Ticket3.Text = sql_queryPulldata_TICKET3.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM4.ExecuteScalar()) Then text_POnum4.Text = sql_queryPulldata_PONUM4.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER4.ExecuteScalar()) Then combo_Customer4.Text = sql_queryPulldata_CUSTOMER4.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY4.ExecuteScalar()) Then text_QtyShip4.Text = sql_queryPulldata_SHIPQTY4.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE4.ExecuteScalar()) Then date_ShipDate4.Value = sql_queryPulldata_SHIPDATE4.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET4.ExecuteScalar()) Then text_Ticket4.Text = sql_queryPulldata_TICKET4.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM5.ExecuteScalar()) Then text_POnum5.Text = sql_queryPulldata_PONUM5.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER5.ExecuteScalar()) Then combo_Customer5.Text = sql_queryPulldata_CUSTOMER5.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY5.ExecuteScalar()) Then text_QtyShip5.Text = sql_queryPulldata_SHIPQTY5.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE5.ExecuteScalar()) Then date_ShipDate5.Value = sql_queryPulldata_SHIPDATE5.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET5.ExecuteScalar()) Then text_Ticket5.Text = sql_queryPulldata_TICKET5.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM6.ExecuteScalar()) Then text_POnum6.Text = sql_queryPulldata_PONUM6.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER6.ExecuteScalar()) Then combo_Customer6.Text = sql_queryPulldata_CUSTOMER6.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY6.ExecuteScalar()) Then text_QtyShip6.Text = sql_queryPulldata_SHIPQTY6.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE6.ExecuteScalar()) Then date_ShipDate6.Value = sql_queryPulldata_SHIPDATE6.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET6.ExecuteScalar()) Then text_Ticket6.Text = sql_queryPulldata_TICKET6.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM7.ExecuteScalar()) Then text_POnum7.Text = sql_queryPulldata_PONUM7.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER7.ExecuteScalar()) Then combo_Customer7.Text = sql_queryPulldata_CUSTOMER7.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY7.ExecuteScalar()) Then text_QtyShip7.Text = sql_queryPulldata_SHIPQTY7.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE7.ExecuteScalar()) Then date_ShipDate7.Value = sql_queryPulldata_SHIPDATE7.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET7.ExecuteScalar()) Then text_Ticket7.Text = sql_queryPulldata_TICKET7.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM8.ExecuteScalar()) Then text_POnum8.Text = sql_queryPulldata_PONUM8.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER8.ExecuteScalar()) Then combo_Customer8.Text = sql_queryPulldata_CUSTOMER8.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY8.ExecuteScalar()) Then text_QtyShip8.Text = sql_queryPulldata_SHIPQTY8.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE8.ExecuteScalar()) Then date_ShipDate8.Value = sql_queryPulldata_SHIPDATE8.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET8.ExecuteScalar()) Then text_Ticket8.Text = sql_queryPulldata_TICKET8.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM9.ExecuteScalar()) Then text_POnum9.Text = sql_queryPulldata_PONUM9.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER9.ExecuteScalar()) Then combo_Customer9.Text = sql_queryPulldata_CUSTOMER9.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY9.ExecuteScalar()) Then text_QtyShip9.Text = sql_queryPulldata_SHIPQTY9.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE9.ExecuteScalar()) Then date_ShipDate9.Value = sql_queryPulldata_SHIPDATE9.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET9.ExecuteScalar()) Then text_Ticket9.Text = sql_queryPulldata_TICKET9.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_PONUM10.ExecuteScalar()) Then text_POnum10.Text = sql_queryPulldata_PONUM10.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_CUSTOMER10.ExecuteScalar()) Then combo_Customer10.Text = sql_queryPulldata_CUSTOMER10.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPQTY10.ExecuteScalar()) Then text_QtyShip10.Text = sql_queryPulldata_SHIPQTY10.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_SHIPDATE10.ExecuteScalar()) Then date_ShipDate10.Value = sql_queryPulldata_SHIPDATE10.ExecuteScalar()
            If Not IsDBNull(sql_queryPulldata_TICKET10.ExecuteScalar()) Then text_Ticket10.Text = sql_queryPulldata_TICKET10.ExecuteScalar()

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
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
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
        If text_Qty.Text = "" Then
            MsgBox("Please type a Quantity")
            Exit Sub
        End If

        'GENERATE QUERY
        sql_queryUpdateData.CommandText = "UPDATE tbl_data_WOlog " &
                                    "SET fld_wo_date='" & date_WOdate.Value.Date &
                                    "', fld_status='" & combo_Status.Text &
                                    "', fld_qb_ba_num='" & text_QBBAnum.Text &
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
                                    "', fld_s1_po='" & text_POnum1.Text &
                                    "', fld_s1_customer='" & combo_Customer1.Text &
                                    "', fld_s1_qty='" & text_QtyShip1.Text &
                                    "', fld_s1_date='" & date_ShipDate1.Value.Date &
                                    "', fld_s1_ticket='" & text_Ticket1.Text &
                                    "', fld_s2_po='" & text_POnum2.Text &
                                    "', fld_s2_customer='" & combo_Customer2.Text &
                                    "', fld_s2_qty='" & text_QtyShip2.Text &
                                    "', fld_s2_date='" & date_ShipDate2.Value.Date &
                                    "', fld_s2_ticket='" & text_Ticket2.Text &
                                    "', fld_s3_po='" & text_POnum3.Text &
                                    "', fld_s3_customer='" & combo_Customer3.Text &
                                    "', fld_s3_qty='" & text_QtyShip3.Text &
                                    "', fld_s3_date='" & date_ShipDate3.Value.Date &
                                    "', fld_s3_ticket='" & text_Ticket3.Text &
                                    "', fld_s4_po='" & text_POnum4.Text &
                                    "', fld_s4_customer='" & combo_Customer4.Text &
                                    "', fld_s4_qty='" & text_QtyShip4.Text &
                                    "', fld_s4_date='" & date_ShipDate4.Value.Date &
                                    "', fld_s4_ticket='" & text_Ticket4.Text &
                                    "', fld_s5_po='" & text_POnum5.Text &
                                    "', fld_s5_customer='" & combo_Customer5.Text &
                                    "', fld_s5_qty='" & text_QtyShip5.Text &
                                    "', fld_s5_date='" & date_ShipDate5.Value.Date &
                                    "', fld_s5_ticket='" & text_Ticket5.Text &
                                    "', fld_s6_po='" & text_POnum6.Text &
                                    "', fld_s6_customer='" & combo_Customer6.Text &
                                    "', fld_s6_qty='" & text_QtyShip6.Text &
                                    "', fld_s6_date='" & date_ShipDate6.Value.Date &
                                    "', fld_s6_ticket='" & text_Ticket6.Text &
                                    "', fld_s7_po='" & text_POnum7.Text &
                                    "', fld_s7_customer='" & combo_Customer7.Text &
                                    "', fld_s7_qty='" & text_QtyShip7.Text &
                                    "', fld_s7_date='" & date_ShipDate7.Value.Date &
                                    "', fld_s7_ticket='" & text_Ticket7.Text &
                                    "', fld_s8_po='" & text_POnum8.Text &
                                    "', fld_s8_customer='" & combo_Customer8.Text &
                                    "', fld_s8_qty='" & text_QtyShip8.Text &
                                    "', fld_s8_date='" & date_ShipDate8.Value.Date &
                                    "', fld_s8_ticket='" & text_Ticket8.Text &
                                    "', fld_s9_po='" & text_POnum9.Text &
                                    "', fld_s9_customer='" & combo_Customer9.Text &
                                    "', fld_s9_qty='" & text_QtyShip9.Text &
                                    "', fld_s9_date='" & date_ShipDate9.Value.Date &
                                    "', fld_s9_ticket='" & text_Ticket9.Text &
                                    "', fld_s10_po='" & text_POnum10.Text &
                                    "', fld_s10_customer='" & combo_Customer10.Text &
                                    "', fld_s10_qty='" & text_QtyShip10.Text &
                                    "', fld_s10_date='" & date_ShipDate10.Value.Date &
                                    "', fld_s10_ticket='" & text_Ticket10.Text &
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

    'MsgBox("The PO Folders have been created.")

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
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\ad.neecovalves.com\Local File Server\Work Orders\WO App\db\db_WOlog.accdb"
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
End Class