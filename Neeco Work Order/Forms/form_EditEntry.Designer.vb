<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_EditEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Fld_ShipmentMethodLabel As System.Windows.Forms.Label
        Dim Fld_SizeLabel As System.Windows.Forms.Label
        Dim Fld_TrimLabel As System.Windows.Forms.Label
        Dim Fld_ProductTypeLabel As System.Windows.Forms.Label
        Dim Fld_PressureLabel As System.Windows.Forms.Label
        Dim Fld_PRLabel As System.Windows.Forms.Label
        Dim Fld_TempClassLabel As System.Windows.Forms.Label
        Dim Fld_HHPPLabel As System.Windows.Forms.Label
        Dim Fld_PSLLabel As System.Windows.Forms.Label
        Dim Fld_StyleLabel As System.Windows.Forms.Label
        Dim Fld_WOnumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_EditEntry))
        Me.button_Delete = New System.Windows.Forms.Button()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.date_InvDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.date_ShipDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.text_InvNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_DeliveryTicketNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_ShipTerms = New System.Windows.Forms.ComboBox()
        Me.TbltermShipMethodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_PartNum = New System.Windows.Forms.TextBox()
        Me.combo_ProductType = New System.Windows.Forms.ComboBox()
        Me.TbltermProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Size = New System.Windows.Forms.ComboBox()
        Me.TbltermSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Trim = New System.Windows.Forms.ComboBox()
        Me.TbltermTrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Pressure = New System.Windows.Forms.ComboBox()
        Me.TbltermPressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Style = New System.Windows.Forms.ComboBox()
        Me.TbltermStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PR = New System.Windows.Forms.ComboBox()
        Me.TbltermPRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PSL = New System.Windows.Forms.ComboBox()
        Me.TbltermPSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Operator = New System.Windows.Forms.ComboBox()
        Me.TbltermHHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_TempClass = New System.Windows.Forms.ComboBox()
        Me.TbltermTempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.text_Qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_WOnum = New System.Windows.Forms.TextBox()
        Me.date_WOdate = New System.Windows.Forms.DateTimePicker()
        Me.text_QBBAnum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_POnum = New System.Windows.Forms.TextBox()
        Me.text_Notes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_Customer = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fld_CustomerLabel = New System.Windows.Forms.Label()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.Tbl_term_CustomersTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter()
        Me.Tbl_term_ProductTypeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter()
        Me.Tbl_term_HHPPTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter()
        Me.Tbl_term_StyleTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter()
        Me.Tbl_term_ShipMethodTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ShipMethodTableAdapter()
        Me.Tbl_term_PressureTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter()
        Me.Tbl_term_TrimTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter()
        Me.Tbl_term_PRTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter()
        Me.Tbl_term_SizeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter()
        Me.Tbl_term_TempClassTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter()
        Me.Tbl_term_PSLTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter()
        Fld_ShipmentMethodLabel = New System.Windows.Forms.Label()
        Fld_SizeLabel = New System.Windows.Forms.Label()
        Fld_TrimLabel = New System.Windows.Forms.Label()
        Fld_ProductTypeLabel = New System.Windows.Forms.Label()
        Fld_PressureLabel = New System.Windows.Forms.Label()
        Fld_PRLabel = New System.Windows.Forms.Label()
        Fld_TempClassLabel = New System.Windows.Forms.Label()
        Fld_HHPPLabel = New System.Windows.Forms.Label()
        Fld_PSLLabel = New System.Windows.Forms.Label()
        Fld_StyleLabel = New System.Windows.Forms.Label()
        Fld_WOnumLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TbltermShipMethodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fld_ShipmentMethodLabel
        '
        Fld_ShipmentMethodLabel.AutoSize = True
        Fld_ShipmentMethodLabel.Location = New System.Drawing.Point(448, 23)
        Fld_ShipmentMethodLabel.Name = "Fld_ShipmentMethodLabel"
        Fld_ShipmentMethodLabel.Size = New System.Drawing.Size(86, 13)
        Fld_ShipmentMethodLabel.TabIndex = 19
        Fld_ShipmentMethodLabel.Text = "Shipment Terms:"
        '
        'Fld_SizeLabel
        '
        Fld_SizeLabel.AutoSize = True
        Fld_SizeLabel.Location = New System.Drawing.Point(60, 90)
        Fld_SizeLabel.Name = "Fld_SizeLabel"
        Fld_SizeLabel.Size = New System.Drawing.Size(30, 13)
        Fld_SizeLabel.TabIndex = 20
        Fld_SizeLabel.Text = "Size:"
        '
        'Fld_TrimLabel
        '
        Fld_TrimLabel.AutoSize = True
        Fld_TrimLabel.Location = New System.Drawing.Point(288, 119)
        Fld_TrimLabel.Name = "Fld_TrimLabel"
        Fld_TrimLabel.Size = New System.Drawing.Size(30, 13)
        Fld_TrimLabel.TabIndex = 24
        Fld_TrimLabel.Text = "Trim:"
        '
        'Fld_ProductTypeLabel
        '
        Fld_ProductTypeLabel.AutoSize = True
        Fld_ProductTypeLabel.Location = New System.Drawing.Point(460, 38)
        Fld_ProductTypeLabel.Name = "Fld_ProductTypeLabel"
        Fld_ProductTypeLabel.Size = New System.Drawing.Size(74, 13)
        Fld_ProductTypeLabel.TabIndex = 39
        Fld_ProductTypeLabel.Text = "Product Type:"
        '
        'Fld_PressureLabel
        '
        Fld_PressureLabel.AutoSize = True
        Fld_PressureLabel.Location = New System.Drawing.Point(267, 89)
        Fld_PressureLabel.Name = "Fld_PressureLabel"
        Fld_PressureLabel.Size = New System.Drawing.Size(51, 13)
        Fld_PressureLabel.TabIndex = 16
        Fld_PressureLabel.Text = "Pressure:"
        '
        'Fld_PRLabel
        '
        Fld_PRLabel.AutoSize = True
        Fld_PRLabel.Location = New System.Drawing.Point(293, 149)
        Fld_PRLabel.Name = "Fld_PRLabel"
        Fld_PRLabel.Size = New System.Drawing.Size(25, 13)
        Fld_PRLabel.TabIndex = 15
        Fld_PRLabel.Text = "PR:"
        '
        'Fld_TempClassLabel
        '
        Fld_TempClassLabel.AutoSize = True
        Fld_TempClassLabel.Location = New System.Drawing.Point(26, 119)
        Fld_TempClassLabel.Name = "Fld_TempClassLabel"
        Fld_TempClassLabel.Size = New System.Drawing.Size(65, 13)
        Fld_TempClassLabel.TabIndex = 22
        Fld_TempClassLabel.Text = "Temp Class:"
        '
        'Fld_HHPPLabel
        '
        Fld_HHPPLabel.AutoSize = True
        Fld_HHPPLabel.Location = New System.Drawing.Point(480, 90)
        Fld_HHPPLabel.Name = "Fld_HHPPLabel"
        Fld_HHPPLabel.Size = New System.Drawing.Size(78, 13)
        Fld_HHPPLabel.TabIndex = 14
        Fld_HHPPLabel.Text = "Operator Type:"
        '
        'Fld_PSLLabel
        '
        Fld_PSLLabel.AutoSize = True
        Fld_PSLLabel.Location = New System.Drawing.Point(61, 149)
        Fld_PSLLabel.Name = "Fld_PSLLabel"
        Fld_PSLLabel.Size = New System.Drawing.Size(30, 13)
        Fld_PSLLabel.TabIndex = 18
        Fld_PSLLabel.Text = "PSL:"
        '
        'Fld_StyleLabel
        '
        Fld_StyleLabel.AutoSize = True
        Fld_StyleLabel.Location = New System.Drawing.Point(525, 119)
        Fld_StyleLabel.Name = "Fld_StyleLabel"
        Fld_StyleLabel.Size = New System.Drawing.Size(33, 13)
        Fld_StyleLabel.TabIndex = 21
        Fld_StyleLabel.Text = "Style:"
        '
        'Fld_WOnumLabel
        '
        Fld_WOnumLabel.AutoSize = True
        Fld_WOnumLabel.Location = New System.Drawing.Point(16, 39)
        Fld_WOnumLabel.Name = "Fld_WOnumLabel"
        Fld_WOnumLabel.Size = New System.Drawing.Size(75, 13)
        Fld_WOnumLabel.TabIndex = 1
        Fld_WOnumLabel.Text = "Work Order #:"
        '
        'button_Delete
        '
        Me.button_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button_Delete.Location = New System.Drawing.Point(12, 488)
        Me.button_Delete.Name = "button_Delete"
        Me.button_Delete.Size = New System.Drawing.Size(125, 23)
        Me.button_Delete.TabIndex = 46
        Me.button_Delete.Text = "DELETE ENTRY"
        Me.button_Delete.UseVisualStyleBackColor = True
        '
        'button_Submit
        '
        Me.button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Submit.Location = New System.Drawing.Point(516, 488)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(95, 23)
        Me.button_Submit.TabIndex = 44
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.date_InvDate)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.date_ShipDate)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.text_InvNum)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.text_DeliveryTicketNum)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.combo_ShipTerms)
        Me.GroupBox3.Controls.Add(Fld_ShipmentMethodLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 110)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shipping Info"
        '
        'date_InvDate
        '
        Me.date_InvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_InvDate.Location = New System.Drawing.Point(324, 75)
        Me.date_InvDate.Name = "date_InvDate"
        Me.date_InvDate.Size = New System.Drawing.Size(121, 20)
        Me.date_InvDate.TabIndex = 22
        Me.date_InvDate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Invoice Date:"
        '
        'date_ShipDate
        '
        Me.date_ShipDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate.Location = New System.Drawing.Point(540, 47)
        Me.date_ShipDate.Name = "date_ShipDate"
        Me.date_ShipDate.Size = New System.Drawing.Size(145, 20)
        Me.date_ShipDate.TabIndex = 20
        Me.date_ShipDate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(457, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Shipping Date:"
        '
        'text_InvNum
        '
        Me.text_InvNum.Location = New System.Drawing.Point(96, 75)
        Me.text_InvNum.Name = "text_InvNum"
        Me.text_InvNum.Size = New System.Drawing.Size(121, 20)
        Me.text_InvNum.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Invoice Number:"
        '
        'text_DeliveryTicketNum
        '
        Me.text_DeliveryTicketNum.Location = New System.Drawing.Point(97, 20)
        Me.text_DeliveryTicketNum.Name = "text_DeliveryTicketNum"
        Me.text_DeliveryTicketNum.Size = New System.Drawing.Size(323, 20)
        Me.text_DeliveryTicketNum.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Delivery Ticket #:"
        '
        'combo_ShipTerms
        '
        Me.combo_ShipTerms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ShipTerms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ShipTerms.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermShipMethodBindingSource, "fld_ShipmentMethod", True))
        Me.combo_ShipTerms.DataSource = Me.TbltermShipMethodBindingSource
        Me.combo_ShipTerms.DisplayMember = "fld_ShipmentMethod"
        Me.combo_ShipTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ShipTerms.FormattingEnabled = True
        Me.combo_ShipTerms.Location = New System.Drawing.Point(540, 20)
        Me.combo_ShipTerms.Name = "combo_ShipTerms"
        Me.combo_ShipTerms.Size = New System.Drawing.Size(145, 21)
        Me.combo_ShipTerms.TabIndex = 19
        Me.combo_ShipTerms.ValueMember = "fld_ShipmentMethod"
        '
        'TbltermShipMethodBindingSource
        '
        Me.TbltermShipMethodBindingSource.DataMember = "tbl_term_ShipMethod"
        Me.TbltermShipMethodBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.text_PartNum)
        Me.GroupBox2.Controls.Add(Me.combo_ProductType)
        Me.GroupBox2.Controls.Add(Fld_SizeLabel)
        Me.GroupBox2.Controls.Add(Fld_TrimLabel)
        Me.GroupBox2.Controls.Add(Me.combo_Size)
        Me.GroupBox2.Controls.Add(Fld_ProductTypeLabel)
        Me.GroupBox2.Controls.Add(Fld_PressureLabel)
        Me.GroupBox2.Controls.Add(Me.combo_Trim)
        Me.GroupBox2.Controls.Add(Me.combo_Pressure)
        Me.GroupBox2.Controls.Add(Me.combo_Style)
        Me.GroupBox2.Controls.Add(Fld_PRLabel)
        Me.GroupBox2.Controls.Add(Fld_TempClassLabel)
        Me.GroupBox2.Controls.Add(Me.combo_PR)
        Me.GroupBox2.Controls.Add(Fld_HHPPLabel)
        Me.GroupBox2.Controls.Add(Me.combo_PSL)
        Me.GroupBox2.Controls.Add(Me.combo_Operator)
        Me.GroupBox2.Controls.Add(Me.combo_TempClass)
        Me.GroupBox2.Controls.Add(Fld_PSLLabel)
        Me.GroupBox2.Controls.Add(Fld_StyleLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 182)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Part Number:"
        '
        'text_PartNum
        '
        Me.text_PartNum.Location = New System.Drawing.Point(97, 35)
        Me.text_PartNum.Name = "text_PartNum"
        Me.text_PartNum.Size = New System.Drawing.Size(323, 20)
        Me.text_PartNum.TabIndex = 8
        '
        'combo_ProductType
        '
        Me.combo_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataSource = Me.TbltermProductTypeBindingSource
        Me.combo_ProductType.DisplayMember = "fld_ProductType"
        Me.combo_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ProductType.FormattingEnabled = True
        Me.combo_ProductType.Location = New System.Drawing.Point(540, 35)
        Me.combo_ProductType.Name = "combo_ProductType"
        Me.combo_ProductType.Size = New System.Drawing.Size(145, 21)
        Me.combo_ProductType.TabIndex = 9
        Me.combo_ProductType.ValueMember = "fld_ProductType"
        '
        'TbltermProductTypeBindingSource
        '
        Me.TbltermProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.TbltermProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Size
        '
        Me.combo_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermSizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataSource = Me.TbltermSizeBindingSource
        Me.combo_Size.DisplayMember = "fld_Size"
        Me.combo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Size.FormattingEnabled = True
        Me.combo_Size.Location = New System.Drawing.Point(96, 87)
        Me.combo_Size.Name = "combo_Size"
        Me.combo_Size.Size = New System.Drawing.Size(121, 21)
        Me.combo_Size.TabIndex = 10
        Me.combo_Size.ValueMember = "fld_Size"
        '
        'TbltermSizeBindingSource
        '
        Me.TbltermSizeBindingSource.DataMember = "tbl_term_Size"
        Me.TbltermSizeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Trim
        '
        Me.combo_Trim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Trim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermTrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataSource = Me.TbltermTrimBindingSource
        Me.combo_Trim.DisplayMember = "fld_Trim"
        Me.combo_Trim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Trim.FormattingEnabled = True
        Me.combo_Trim.Location = New System.Drawing.Point(324, 116)
        Me.combo_Trim.Name = "combo_Trim"
        Me.combo_Trim.Size = New System.Drawing.Size(121, 21)
        Me.combo_Trim.TabIndex = 14
        Me.combo_Trim.ValueMember = "fld_Trim"
        '
        'TbltermTrimBindingSource
        '
        Me.TbltermTrimBindingSource.DataMember = "tbl_term_Trim"
        Me.TbltermTrimBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Pressure
        '
        Me.combo_Pressure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Pressure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataSource = Me.TbltermPressureBindingSource
        Me.combo_Pressure.DisplayMember = "fld_Pressure"
        Me.combo_Pressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Pressure.FormattingEnabled = True
        Me.combo_Pressure.Location = New System.Drawing.Point(324, 86)
        Me.combo_Pressure.Name = "combo_Pressure"
        Me.combo_Pressure.Size = New System.Drawing.Size(121, 21)
        Me.combo_Pressure.TabIndex = 11
        Me.combo_Pressure.ValueMember = "fld_Pressure"
        '
        'TbltermPressureBindingSource
        '
        Me.TbltermPressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.TbltermPressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Style
        '
        Me.combo_Style.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermStyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataSource = Me.TbltermStyleBindingSource
        Me.combo_Style.DisplayMember = "fld_Style"
        Me.combo_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Style.FormattingEnabled = True
        Me.combo_Style.Location = New System.Drawing.Point(564, 116)
        Me.combo_Style.Name = "combo_Style"
        Me.combo_Style.Size = New System.Drawing.Size(121, 21)
        Me.combo_Style.TabIndex = 15
        Me.combo_Style.ValueMember = "fld_Style"
        '
        'TbltermStyleBindingSource
        '
        Me.TbltermStyleBindingSource.DataMember = "tbl_term_Style"
        Me.TbltermStyleBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_PR
        '
        Me.combo_PR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPRBindingSource, "fld_PR", True))
        Me.combo_PR.DataSource = Me.TbltermPRBindingSource
        Me.combo_PR.DisplayMember = "fld_PR"
        Me.combo_PR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PR.FormattingEnabled = True
        Me.combo_PR.Location = New System.Drawing.Point(324, 146)
        Me.combo_PR.Name = "combo_PR"
        Me.combo_PR.Size = New System.Drawing.Size(121, 21)
        Me.combo_PR.TabIndex = 17
        Me.combo_PR.ValueMember = "fld_PR"
        '
        'TbltermPRBindingSource
        '
        Me.TbltermPRBindingSource.DataMember = "tbl_term_PR"
        Me.TbltermPRBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_PSL
        '
        Me.combo_PSL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PSL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataSource = Me.TbltermPSLBindingSource
        Me.combo_PSL.DisplayMember = "fld_PSL"
        Me.combo_PSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PSL.FormattingEnabled = True
        Me.combo_PSL.Location = New System.Drawing.Point(97, 146)
        Me.combo_PSL.Name = "combo_PSL"
        Me.combo_PSL.Size = New System.Drawing.Size(121, 21)
        Me.combo_PSL.TabIndex = 16
        Me.combo_PSL.ValueMember = "fld_PSL"
        '
        'TbltermPSLBindingSource
        '
        Me.TbltermPSLBindingSource.DataMember = "tbl_term_PSL"
        Me.TbltermPSLBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Operator
        '
        Me.combo_Operator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Operator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermHHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataSource = Me.TbltermHHPPBindingSource
        Me.combo_Operator.DisplayMember = "fld_HHPP"
        Me.combo_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Operator.FormattingEnabled = True
        Me.combo_Operator.Location = New System.Drawing.Point(564, 87)
        Me.combo_Operator.Name = "combo_Operator"
        Me.combo_Operator.Size = New System.Drawing.Size(121, 21)
        Me.combo_Operator.TabIndex = 12
        Me.combo_Operator.ValueMember = "fld_HHPP"
        '
        'TbltermHHPPBindingSource
        '
        Me.TbltermHHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.TbltermHHPPBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_TempClass
        '
        Me.combo_TempClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_TempClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermTempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataSource = Me.TbltermTempClassBindingSource
        Me.combo_TempClass.DisplayMember = "fld_TempClass"
        Me.combo_TempClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_TempClass.FormattingEnabled = True
        Me.combo_TempClass.Location = New System.Drawing.Point(97, 116)
        Me.combo_TempClass.Name = "combo_TempClass"
        Me.combo_TempClass.Size = New System.Drawing.Size(121, 21)
        Me.combo_TempClass.TabIndex = 13
        Me.combo_TempClass.ValueMember = "fld_TempClass"
        '
        'TbltermTempClassBindingSource
        '
        Me.TbltermTempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.TbltermTempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date_DueDate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.text_Qty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.text_WOnum)
        Me.GroupBox1.Controls.Add(Fld_WOnumLabel)
        Me.GroupBox1.Controls.Add(Me.date_WOdate)
        Me.GroupBox1.Controls.Add(Me.text_QBBAnum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.text_POnum)
        Me.GroupBox1.Controls.Add(Me.text_Notes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.combo_Customer)
        Me.GroupBox1.Controls.Add(Me.Fld_CustomerLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 168)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Info"
        '
        'date_DueDate
        '
        Me.date_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_DueDate.Location = New System.Drawing.Point(97, 89)
        Me.date_DueDate.Name = "date_DueDate"
        Me.date_DueDate.Size = New System.Drawing.Size(105, 20)
        Me.date_DueDate.TabIndex = 5
        Me.date_DueDate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Due Date:"
        '
        'text_Qty
        '
        Me.text_Qty.Location = New System.Drawing.Point(96, 133)
        Me.text_Qty.Name = "text_Qty"
        Me.text_Qty.Size = New System.Drawing.Size(105, 20)
        Me.text_Qty.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Order Quantity:"
        '
        'text_WOnum
        '
        Me.text_WOnum.Location = New System.Drawing.Point(97, 36)
        Me.text_WOnum.Name = "text_WOnum"
        Me.text_WOnum.ReadOnly = True
        Me.text_WOnum.Size = New System.Drawing.Size(105, 20)
        Me.text_WOnum.TabIndex = 99
        Me.text_WOnum.TabStop = False
        '
        'date_WOdate
        '
        Me.date_WOdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_WOdate.Location = New System.Drawing.Point(324, 36)
        Me.date_WOdate.Name = "date_WOdate"
        Me.date_WOdate.Size = New System.Drawing.Size(105, 20)
        Me.date_WOdate.TabIndex = 1
        Me.date_WOdate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'text_QBBAnum
        '
        Me.text_QBBAnum.Location = New System.Drawing.Point(97, 63)
        Me.text_QBBAnum.Name = "text_QBBAnum"
        Me.text_QBBAnum.Size = New System.Drawing.Size(105, 20)
        Me.text_QBBAnum.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "QB BA #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Date:"
        '
        'text_POnum
        '
        Me.text_POnum.Location = New System.Drawing.Point(540, 36)
        Me.text_POnum.Name = "text_POnum"
        Me.text_POnum.Size = New System.Drawing.Size(145, 20)
        Me.text_POnum.TabIndex = 2
        '
        'text_Notes
        '
        Me.text_Notes.Location = New System.Drawing.Point(324, 89)
        Me.text_Notes.Multiline = True
        Me.text_Notes.Name = "text_Notes"
        Me.text_Notes.Size = New System.Drawing.Size(361, 64)
        Me.text_Notes.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Notes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "PO Number:"
        '
        'combo_Customer
        '
        Me.combo_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomersBindingSource, "fld_Customer", True))
        Me.combo_Customer.DataSource = Me.TbltermCustomersBindingSource
        Me.combo_Customer.DisplayMember = "fld_Customer"
        Me.combo_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer.FormattingEnabled = True
        Me.combo_Customer.Location = New System.Drawing.Point(324, 62)
        Me.combo_Customer.Name = "combo_Customer"
        Me.combo_Customer.Size = New System.Drawing.Size(361, 21)
        Me.combo_Customer.TabIndex = 4
        Me.combo_Customer.ValueMember = "fld_Customer"
        '
        'TbltermCustomersBindingSource
        '
        Me.TbltermCustomersBindingSource.DataMember = "tbl_term_Customers"
        Me.TbltermCustomersBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Fld_CustomerLabel
        '
        Me.Fld_CustomerLabel.AutoSize = True
        Me.Fld_CustomerLabel.Location = New System.Drawing.Point(264, 65)
        Me.Fld_CustomerLabel.Name = "Fld_CustomerLabel"
        Me.Fld_CustomerLabel.Size = New System.Drawing.Size(54, 13)
        Me.Fld_CustomerLabel.TabIndex = 13
        Me.Fld_CustomerLabel.Text = "Customer:"
        '
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Location = New System.Drawing.Point(617, 488)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(95, 23)
        Me.button_Exit.TabIndex = 45
        Me.button_Exit.Text = "CANCEL"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'Tbl_term_CustomersTableAdapter
        '
        Me.Tbl_term_CustomersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_ProductTypeTableAdapter
        '
        Me.Tbl_term_ProductTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_HHPPTableAdapter
        '
        Me.Tbl_term_HHPPTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_StyleTableAdapter
        '
        Me.Tbl_term_StyleTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_ShipMethodTableAdapter
        '
        Me.Tbl_term_ShipMethodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PressureTableAdapter
        '
        Me.Tbl_term_PressureTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_TrimTableAdapter
        '
        Me.Tbl_term_TrimTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PRTableAdapter
        '
        Me.Tbl_term_PRTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_SizeTableAdapter
        '
        Me.Tbl_term_SizeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_TempClassTableAdapter
        '
        Me.Tbl_term_TempClassTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PSLTableAdapter
        '
        Me.Tbl_term_PSLTableAdapter.ClearBeforeFill = True
        '
        'form_EditEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(724, 521)
        Me.Controls.Add(Me.button_Delete)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button_Exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_EditEntry"
        Me.Text = "Neeco Work Order App - Edit Work Order"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TbltermShipMethodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Delete As Button
    Friend WithEvents button_Submit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents date_InvDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents date_ShipDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents text_InvNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_DeliveryTicketNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents combo_ShipTerms As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents text_PartNum As TextBox
    Friend WithEvents combo_ProductType As ComboBox
    Friend WithEvents combo_Size As ComboBox
    Friend WithEvents combo_Trim As ComboBox
    Friend WithEvents combo_Pressure As ComboBox
    Friend WithEvents combo_Style As ComboBox
    Friend WithEvents combo_PR As ComboBox
    Friend WithEvents combo_PSL As ComboBox
    Friend WithEvents combo_Operator As ComboBox
    Friend WithEvents combo_TempClass As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents date_DueDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents text_Qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents text_WOnum As TextBox
    Friend WithEvents date_WOdate As DateTimePicker
    Friend WithEvents text_QBBAnum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents text_POnum As TextBox
    Friend WithEvents text_Notes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents combo_Customer As ComboBox
    Friend WithEvents Fld_CustomerLabel As Label
    Friend WithEvents button_Exit As Button
    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents TbltermCustomersBindingSource As BindingSource
    Friend WithEvents Tbl_term_CustomersTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter
    Friend WithEvents TbltermProductTypeBindingSource As BindingSource
    Friend WithEvents Tbl_term_ProductTypeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter
    Friend WithEvents TbltermHHPPBindingSource As BindingSource
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents TbltermStyleBindingSource As BindingSource
    Friend WithEvents Tbl_term_StyleTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter
    Friend WithEvents TbltermShipMethodBindingSource As BindingSource
    Friend WithEvents Tbl_term_ShipMethodTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ShipMethodTableAdapter
    Friend WithEvents TbltermPressureBindingSource As BindingSource
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents TbltermTrimBindingSource As BindingSource
    Friend WithEvents Tbl_term_TrimTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter
    Friend WithEvents TbltermPRBindingSource As BindingSource
    Friend WithEvents Tbl_term_PRTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter
    Friend WithEvents TbltermSizeBindingSource As BindingSource
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents TbltermTempClassBindingSource As BindingSource
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
    Friend WithEvents TbltermPSLBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
End Class
