Public Class form_AddNewEntry
    Private Sub Tbl_WOnumBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_WOnumBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

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

    End Sub

    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
        'CLEAR FORM BUTTON
        Clear_Form()
    End Sub

    Sub Clear_Form()
        'Clears Form by resetting all values

        'NOTES
        text_Notes.Text = ""

        'WO FIELDS
        date_WOdate.Value = Date.Today
        text_QBBAnum.Text = ""
        text_Qty.Text = ""
        combo_Status.SelectedItem = ""

        'PRODUCT FIELDS
        text_PartNum.Text = ""
        combo_Operator.SelectedIndex = -1
        combo_PR.SelectedIndex = -1
        combo_Pressure.SelectedIndex = -1
        combo_ProductType.SelectedIndex = -1
        combo_PSL.SelectedIndex = -1
        'combo_ShipTerms.SelectedIndex = -1
        combo_Size.SelectedIndex = -1
        combo_Style.SelectedIndex = -1
        combo_TempClass.SelectedIndex = -1
        combo_Trim.SelectedIndex = -1

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
        'combo_Customer1.SelectedIndex = 0
        'combo_Customer2.SelectedIndex = -1
        text_QtyShip1.Text = ""
        date_ShipDate1.Value = Date.Today
        text_Ticket1.Text = ""

    End Sub
    Sub PullWOnum()
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPullWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim wo_num_string As String
        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\neecosvr1\1.  Quality\WORK ORDER\WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryPullWOnum.Connection = sql_conn

        'write SQL query
        sql_queryPullWOnum.CommandText = "SELECT fld_WOnum FROM tbl_WOnum WHERE ID = 1"
        Try
            sql_conn.Open()
            wo_num_string = Convert.ToString(sql_queryPullWOnum.ExecuteScalar())
            sql_conn.Close()
            'update the WO number if necessary
            text_WOnum.Text = wo_num_string
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
    Sub PushWOnum()
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryPushWOnum As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim wo_num_string As String
        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\neecosvr1\1.  Quality\WORK ORDER\WO App\db\db_WOlog.accdb"
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

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Submit form
        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_queryInsertData As New OleDb.OleDbCommand
        Dim conn_string As String
        Dim current_user As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\neecosvr1\1.  Quality\WORK ORDER\WO App\db\db_WOlog.accdb"
        sql_conn.ConnectionString = conn_string
        sql_queryInsertData.Connection = sql_conn


        current_user = Environ("Username")

        'validate data
        If combo_Customer1.Text = "" Then
            MsgBox("Please select Customer")
            Exit Sub
        End If
        If text_PartNum.Text = "" Then
            MsgBox("Please type a Part Number")
            Exit Sub
        End If
        If text_Qty.Text = "" Then
            MsgBox("Please type a Quantity")
            Exit Sub
        End If

        'UPDATE WO NUMBER
        PullWOnum()

        'generate Query
        sql_queryInsertData.CommandText = "INSERT INTO tbl_data_WOlog([fld_wo_num],[fld_wo_date],[fld_part_num],[fld_product],[fld_size],[fld_pressure],[fld_hhpp],[fld_tempclass],[fld_trim],[fld_style],[fld_psl],[fld_pr],[fld_qty],[fld_customer],[fld_notes],[fld_po_num],[fld_ship_date],[fld_delivery_num],[fld_qb_ba_num],[fld_CreatedBy],[fld_CreatedByDate],[fld_LastModifiedBy],[fld_LastModifiedDate])VALUES(@WONUM,@WODATE,@PARTNUM,@PRODUCT,@SIZE,@PRESSURE,@HHPP,@TEMPCLASS,@TRIM,@STYLE,@PSL,@PR,@QTY,@CUSTOMER,@NOTES,@PONUM,@SHIPDATE,@DELIVERYNUM,@QBBANUM,@CREATEDBY,@CREATEDBYDATE,@MODIFIEDBY,@MODIFIEDBYDATE)"
        sql_queryInsertData.Parameters.AddWithValue("@WONUM", text_WOnum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@WODATE", date_WOdate.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@PARTNUM", text_PartNum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PRODUCT", combo_ProductType.Text)
        sql_queryInsertData.Parameters.AddWithValue("@SIZE", combo_Size.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PRESSURE", combo_Pressure.Text)
        sql_queryInsertData.Parameters.AddWithValue("@HHPP", combo_Operator.Text)
        sql_queryInsertData.Parameters.AddWithValue("@TEMPCLASS", combo_TempClass.Text)
        sql_queryInsertData.Parameters.AddWithValue("@TRIM", combo_Trim.Text)
        sql_queryInsertData.Parameters.AddWithValue("@STYLE", combo_Style.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PSL", combo_PSL.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PR", combo_PR.Text)
        sql_queryInsertData.Parameters.AddWithValue("@QTY", text_Qty.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CUSTOMER", combo_Customer1.Text)
        sql_queryInsertData.Parameters.AddWithValue("@NOTES", text_Notes.Text)
        sql_queryInsertData.Parameters.AddWithValue("@PONUM", text_POnum1.Text)
        'sql_queryInsertData.Parameters.AddWithValue("@PODUE", date_DueDate.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@SHIPDATE", date_ShipDate1.Value.Date)
        sql_queryInsertData.Parameters.AddWithValue("@DELIVERYNUM", text_Ticket1.Text)
        'sql_queryInsertData.Parameters.AddWithValue("@INVDATE", date_InvDate.Value.Date)
        'sql_queryInsertData.Parameters.AddWithValue("@INVNUM", text_InvNum.Text)
        'sql_queryInsertData.Parameters.AddWithValue("@SHIPMETHOD", combo_ShipTerms.Text)
        'sql_queryInsertData.Parameters.AddWithValue("@APIAUDIT", "")
        sql_queryInsertData.Parameters.AddWithValue("@QBBANUM", text_QBBAnum.Text)
        sql_queryInsertData.Parameters.AddWithValue("@CREATEDBY", current_user)
        sql_queryInsertData.Parameters.AddWithValue("@CREATEDBYDATE", Date.Today)
        sql_queryInsertData.Parameters.AddWithValue("@MODIFIEDBY", current_user)
        sql_queryInsertData.Parameters.AddWithValue("@MODIFIEDBYDATE", Date.Today)

        'execute Query - sql insert into access db
        Try
            sql_conn.Open()
            sql_queryInsertData.ExecuteNonQuery()
            MsgBox("The Work Order has been submitted!" & Environment.NewLine & "Your WO Number is: " & text_WOnum.Text & Environment.NewLine & "Thank You!")
            sql_conn.Close()
            Clear_Form()
            PushWOnum()
            PullWOnum()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub text_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_Qty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class