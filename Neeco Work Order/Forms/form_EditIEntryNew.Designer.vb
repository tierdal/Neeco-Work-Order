<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_EditIEntryNew
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
        Dim Fld_ProductTypeLabel As System.Windows.Forms.Label
        Dim Fld_SizeLabel As System.Windows.Forms.Label
        Dim Fld_PressureLabel As System.Windows.Forms.Label
        Dim Fld_StyleLabel As System.Windows.Forms.Label
        Dim Fld_TempClassLabel As System.Windows.Forms.Label
        Dim Fld_HHPPLabel As System.Windows.Forms.Label
        Dim Fld_PRLabel As System.Windows.Forms.Label
        Dim Fld_PSLLabel As System.Windows.Forms.Label
        Dim Fld_TrimLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Fld_WOnumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_EditIEntryNew))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.check_BO = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_PartNum = New System.Windows.Forms.TextBox()
        Me.combo_ProductType = New System.Windows.Forms.ComboBox()
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.combo_Size = New System.Windows.Forms.ComboBox()
        Me.combo_Pressure = New System.Windows.Forms.ComboBox()
        Me.combo_Style = New System.Windows.Forms.ComboBox()
        Me.combo_Operator = New System.Windows.Forms.ComboBox()
        Me.combo_PR = New System.Windows.Forms.ComboBox()
        Me.combo_PSL = New System.Windows.Forms.ComboBox()
        Me.combo_Trim = New System.Windows.Forms.ComboBox()
        Me.combo_TempClass = New System.Windows.Forms.ComboBox()
        Me.text_Ticket2 = New System.Windows.Forms.TextBox()
        Me.text_Ticket3 = New System.Windows.Forms.TextBox()
        Me.text_Ticket4 = New System.Windows.Forms.TextBox()
        Me.text_Ticket5 = New System.Windows.Forms.TextBox()
        Me.text_Ticket6 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.text_Ticket7 = New System.Windows.Forms.TextBox()
        Me.text_Ticket8 = New System.Windows.Forms.TextBox()
        Me.text_Ticket9 = New System.Windows.Forms.TextBox()
        Me.text_Ticket10 = New System.Windows.Forms.TextBox()
        Me.date_ShipDate2 = New System.Windows.Forms.DateTimePicker()
        Me.combo_Customer1 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.date_ShipDate4 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate5 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate6 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate7 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate8 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate9 = New System.Windows.Forms.DateTimePicker()
        Me.date_ShipDate10 = New System.Windows.Forms.DateTimePicker()
        Me.text_QtyShip2 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip4 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip6 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip7 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip8 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip3 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip9 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip10 = New System.Windows.Forms.TextBox()
        Me.combo_Customer10 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers10BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer9 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers9BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer8 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer7 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer6 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer5 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer4 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer3 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Customer2 = New System.Windows.Forms.ComboBox()
        Me.TbltermCustomers2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.text_POnum7 = New System.Windows.Forms.TextBox()
        Me.text_POnum6 = New System.Windows.Forms.TextBox()
        Me.text_POnum5 = New System.Windows.Forms.TextBox()
        Me.text_POnum4 = New System.Windows.Forms.TextBox()
        Me.text_POnum3 = New System.Windows.Forms.TextBox()
        Me.text_POnum2 = New System.Windows.Forms.TextBox()
        Me.text_POnum8 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.date_ShipDate1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.text_Ticket1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_POnum1 = New System.Windows.Forms.TextBox()
        Me.Fld_CustomerLabel = New System.Windows.Forms.Label()
        Me.text_QtyShip1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.text_POnum9 = New System.Windows.Forms.TextBox()
        Me.text_POnum10 = New System.Windows.Forms.TextBox()
        Me.text_QtyShip5 = New System.Windows.Forms.TextBox()
        Me.date_ShipDate3 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.text_WOnum = New System.Windows.Forms.TextBox()
        Me.Tbl_WOnumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_Customers10TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers10TableAdapter()
        Me.Tbl_term_Customers8TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers8TableAdapter()
        Me.Tbl_term_Customers7TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers7TableAdapter()
        Me.Tbl_term_Customers6TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers6TableAdapter()
        Me.Tbl_term_Customers5TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers5TableAdapter()
        Me.Tbl_term_Customers4TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers4TableAdapter()
        Me.Tbl_term_Customers3TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers3TableAdapter()
        Me.Tbl_term_Customers2TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers2TableAdapter()
        Me.Tbl_term_Customers1TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers1TableAdapter()
        Me.TbltermCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.text_Notes = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tbl_term_Customers9TableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_Customers9TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.date_WOdate = New System.Windows.Forms.DateTimePicker()
        Me.text_Qty = New System.Windows.Forms.TextBox()
        Me.combo_Status = New System.Windows.Forms.ComboBox()
        Me.text_QBBAnum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbl_term_TempClassTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter()
        Me.Tbl_term_SizeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter()
        Me.Tbl_term_PSLTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter()
        Me.Tbl_term_PressureTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter()
        Me.Tbl_term_PRTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter()
        Me.Tbl_term_HHPPTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter()
        Me.Tbl_term_StyleTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_WOnumTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter()
        Me.Tbl_term_ProductTypeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.button_Delete = New System.Windows.Forms.Button()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.Tbl_term_TrimTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TbltermStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermPressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermTempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermTrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermPSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermPRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermHHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Fld_ProductTypeLabel = New System.Windows.Forms.Label()
        Fld_SizeLabel = New System.Windows.Forms.Label()
        Fld_PressureLabel = New System.Windows.Forms.Label()
        Fld_StyleLabel = New System.Windows.Forms.Label()
        Fld_TempClassLabel = New System.Windows.Forms.Label()
        Fld_HHPPLabel = New System.Windows.Forms.Label()
        Fld_PRLabel = New System.Windows.Forms.Label()
        Fld_PSLLabel = New System.Windows.Forms.Label()
        Fld_TrimLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Fld_WOnumLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TbltermCustomers1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers10BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers9BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomers2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fld_ProductTypeLabel
        '
        Fld_ProductTypeLabel.Location = New System.Drawing.Point(307, 0)
        Fld_ProductTypeLabel.Name = "Fld_ProductTypeLabel"
        Fld_ProductTypeLabel.Size = New System.Drawing.Size(99, 23)
        Fld_ProductTypeLabel.TabIndex = 99
        Fld_ProductTypeLabel.Text = "Product Type:"
        Fld_ProductTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_SizeLabel
        '
        Fld_SizeLabel.AutoSize = True
        Fld_SizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_SizeLabel.Location = New System.Drawing.Point(3, 26)
        Fld_SizeLabel.Name = "Fld_SizeLabel"
        Fld_SizeLabel.Size = New System.Drawing.Size(73, 26)
        Fld_SizeLabel.TabIndex = 99
        Fld_SizeLabel.Text = "Size:"
        Fld_SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PressureLabel
        '
        Fld_PressureLabel.AutoSize = True
        Fld_PressureLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PressureLabel.Location = New System.Drawing.Point(3, 52)
        Fld_PressureLabel.Name = "Fld_PressureLabel"
        Fld_PressureLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PressureLabel.TabIndex = 99
        Fld_PressureLabel.Text = "Pressure:"
        Fld_PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_StyleLabel
        '
        Fld_StyleLabel.AutoSize = True
        Fld_StyleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_StyleLabel.Location = New System.Drawing.Point(3, 0)
        Fld_StyleLabel.Name = "Fld_StyleLabel"
        Fld_StyleLabel.Size = New System.Drawing.Size(73, 26)
        Fld_StyleLabel.TabIndex = 99
        Fld_StyleLabel.Text = "Style:"
        Fld_StyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_TempClassLabel
        '
        Fld_TempClassLabel.AutoSize = True
        Fld_TempClassLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TempClassLabel.Location = New System.Drawing.Point(177, 0)
        Fld_TempClassLabel.Name = "Fld_TempClassLabel"
        Fld_TempClassLabel.Size = New System.Drawing.Size(73, 26)
        Fld_TempClassLabel.TabIndex = 99
        Fld_TempClassLabel.Text = "Temp Class:"
        Fld_TempClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_HHPPLabel
        '
        Fld_HHPPLabel.AutoSize = True
        Fld_HHPPLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_HHPPLabel.Location = New System.Drawing.Point(351, 26)
        Fld_HHPPLabel.Name = "Fld_HHPPLabel"
        Fld_HHPPLabel.Size = New System.Drawing.Size(73, 26)
        Fld_HHPPLabel.TabIndex = 99
        Fld_HHPPLabel.Text = "Operator Type:"
        Fld_HHPPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PRLabel
        '
        Fld_PRLabel.AutoSize = True
        Fld_PRLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PRLabel.Location = New System.Drawing.Point(351, 0)
        Fld_PRLabel.Name = "Fld_PRLabel"
        Fld_PRLabel.Size = New System.Drawing.Size(73, 26)
        Fld_PRLabel.TabIndex = 99
        Fld_PRLabel.Text = "PR:"
        Fld_PRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PSLLabel
        '
        Fld_PSLLabel.AutoSize = True
        Fld_PSLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PSLLabel.Location = New System.Drawing.Point(177, 52)
        Fld_PSLLabel.Name = "Fld_PSLLabel"
        Fld_PSLLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PSLLabel.TabIndex = 99
        Fld_PSLLabel.Text = "PSL:"
        Fld_PSLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_TrimLabel
        '
        Fld_TrimLabel.AutoSize = True
        Fld_TrimLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TrimLabel.Location = New System.Drawing.Point(177, 26)
        Fld_TrimLabel.Name = "Fld_TrimLabel"
        Fld_TrimLabel.Size = New System.Drawing.Size(73, 26)
        Fld_TrimLabel.TabIndex = 99
        Fld_TrimLabel.Text = "Trim:"
        Fld_TrimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Label12.Location = New System.Drawing.Point(3, 65)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(95, 25)
        Label12.TabIndex = 99
        Label12.Text = "Status:"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_WOnumLabel
        '
        Fld_WOnumLabel.AutoSize = True
        Fld_WOnumLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_WOnumLabel.Location = New System.Drawing.Point(3, 0)
        Fld_WOnumLabel.Name = "Fld_WOnumLabel"
        Fld_WOnumLabel.Size = New System.Drawing.Size(95, 25)
        Fld_WOnumLabel.TabIndex = 99
        Fld_WOnumLabel.Text = "Work Order #:"
        Fld_WOnumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(218, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 163)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.check_BO, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(531, 144)
        Me.TableLayoutPanel8.TabIndex = 99
        '
        'check_BO
        '
        Me.check_BO.AutoSize = True
        Me.check_BO.Location = New System.Drawing.Point(3, 122)
        Me.check_BO.Name = "check_BO"
        Me.check_BO.Size = New System.Drawing.Size(421, 17)
        Me.check_BO.TabIndex = 15
        Me.check_BO.Text = "Check this box if you are buying out the material as a finished product from a Ve" &
    "ndor"
        Me.check_BO.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.text_PartNum, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.combo_ProductType, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Fld_ProductTypeLabel, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(525, 27)
        Me.TableLayoutPanel7.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 27)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Part Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_PartNum
        '
        Me.text_PartNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_PartNum.Location = New System.Drawing.Point(97, 3)
        Me.text_PartNum.Name = "text_PartNum"
        Me.text_PartNum.Size = New System.Drawing.Size(204, 20)
        Me.text_PartNum.TabIndex = 5
        '
        'combo_ProductType
        '
        Me.combo_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataSource = Me.TbltermProductTypeBindingSource
        Me.combo_ProductType.DisplayMember = "fld_ProductType"
        Me.combo_ProductType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ProductType.FormattingEnabled = True
        Me.combo_ProductType.Location = New System.Drawing.Point(412, 3)
        Me.combo_ProductType.Name = "combo_ProductType"
        Me.combo_ProductType.Size = New System.Drawing.Size(110, 21)
        Me.combo_ProductType.TabIndex = 6
        Me.combo_ProductType.ValueMember = "fld_ProductType"
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 6
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel6.Controls.Add(Fld_SizeLabel, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Fld_PressureLabel, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_Size, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_Pressure, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Fld_StyleLabel, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Fld_TempClassLabel, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_Style, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_Operator, 5, 1)
        Me.TableLayoutPanel6.Controls.Add(Fld_HHPPLabel, 4, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_PR, 5, 0)
        Me.TableLayoutPanel6.Controls.Add(Fld_PRLabel, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Fld_PSLLabel, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_PSL, 3, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_Trim, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Fld_TrimLabel, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.combo_TempClass, 3, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(525, 80)
        Me.TableLayoutPanel6.TabIndex = 99
        '
        'combo_Size
        '
        Me.combo_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermSizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataSource = Me.TbltermSizeBindingSource
        Me.combo_Size.DisplayMember = "fld_Size"
        Me.combo_Size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Size.FormattingEnabled = True
        Me.combo_Size.Location = New System.Drawing.Point(82, 29)
        Me.combo_Size.Name = "combo_Size"
        Me.combo_Size.Size = New System.Drawing.Size(89, 21)
        Me.combo_Size.TabIndex = 8
        Me.combo_Size.ValueMember = "fld_Size"
        '
        'combo_Pressure
        '
        Me.combo_Pressure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Pressure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataSource = Me.TbltermPressureBindingSource
        Me.combo_Pressure.DisplayMember = "fld_Pressure"
        Me.combo_Pressure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Pressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Pressure.FormattingEnabled = True
        Me.combo_Pressure.Location = New System.Drawing.Point(82, 55)
        Me.combo_Pressure.Name = "combo_Pressure"
        Me.combo_Pressure.Size = New System.Drawing.Size(89, 21)
        Me.combo_Pressure.TabIndex = 9
        Me.combo_Pressure.ValueMember = "fld_Pressure"
        '
        'combo_Style
        '
        Me.combo_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermStyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataSource = Me.TbltermStyleBindingSource
        Me.combo_Style.DisplayMember = "fld_Style"
        Me.combo_Style.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Style.FormattingEnabled = True
        Me.combo_Style.Location = New System.Drawing.Point(82, 3)
        Me.combo_Style.Name = "combo_Style"
        Me.combo_Style.Size = New System.Drawing.Size(89, 21)
        Me.combo_Style.TabIndex = 7
        Me.combo_Style.ValueMember = "fld_Style"
        '
        'combo_Operator
        '
        Me.combo_Operator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Operator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermHHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataSource = Me.TbltermHHPPBindingSource
        Me.combo_Operator.DisplayMember = "fld_HHPP"
        Me.combo_Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Operator.FormattingEnabled = True
        Me.combo_Operator.Location = New System.Drawing.Point(430, 29)
        Me.combo_Operator.Name = "combo_Operator"
        Me.combo_Operator.Size = New System.Drawing.Size(92, 21)
        Me.combo_Operator.TabIndex = 14
        Me.combo_Operator.ValueMember = "fld_HHPP"
        '
        'combo_PR
        '
        Me.combo_PR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPRBindingSource, "fld_PR", True))
        Me.combo_PR.DataSource = Me.TbltermPRBindingSource
        Me.combo_PR.DisplayMember = "fld_PR"
        Me.combo_PR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_PR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PR.FormattingEnabled = True
        Me.combo_PR.Location = New System.Drawing.Point(430, 3)
        Me.combo_PR.Name = "combo_PR"
        Me.combo_PR.Size = New System.Drawing.Size(92, 21)
        Me.combo_PR.TabIndex = 13
        Me.combo_PR.ValueMember = "fld_PR"
        '
        'combo_PSL
        '
        Me.combo_PSL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PSL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermPSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataSource = Me.TbltermPSLBindingSource
        Me.combo_PSL.DisplayMember = "fld_PSL"
        Me.combo_PSL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_PSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PSL.FormattingEnabled = True
        Me.combo_PSL.Location = New System.Drawing.Point(256, 55)
        Me.combo_PSL.Name = "combo_PSL"
        Me.combo_PSL.Size = New System.Drawing.Size(89, 21)
        Me.combo_PSL.TabIndex = 12
        Me.combo_PSL.ValueMember = "fld_PSL"
        '
        'combo_Trim
        '
        Me.combo_Trim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Trim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermTrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataSource = Me.TbltermTrimBindingSource
        Me.combo_Trim.DisplayMember = "fld_Trim"
        Me.combo_Trim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Trim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Trim.FormattingEnabled = True
        Me.combo_Trim.Location = New System.Drawing.Point(256, 29)
        Me.combo_Trim.Name = "combo_Trim"
        Me.combo_Trim.Size = New System.Drawing.Size(89, 21)
        Me.combo_Trim.TabIndex = 11
        Me.combo_Trim.ValueMember = "fld_Trim"
        '
        'combo_TempClass
        '
        Me.combo_TempClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_TempClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermTempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataSource = Me.TbltermTempClassBindingSource
        Me.combo_TempClass.DisplayMember = "fld_TempClass"
        Me.combo_TempClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_TempClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_TempClass.FormattingEnabled = True
        Me.combo_TempClass.Location = New System.Drawing.Point(256, 3)
        Me.combo_TempClass.Name = "combo_TempClass"
        Me.combo_TempClass.Size = New System.Drawing.Size(89, 21)
        Me.combo_TempClass.TabIndex = 10
        Me.combo_TempClass.ValueMember = "fld_TempClass"
        '
        'text_Ticket2
        '
        Me.text_Ticket2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket2.Location = New System.Drawing.Point(566, 56)
        Me.text_Ticket2.Name = "text_Ticket2"
        Me.text_Ticket2.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket2.TabIndex = 25
        '
        'text_Ticket3
        '
        Me.text_Ticket3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket3.Location = New System.Drawing.Point(566, 81)
        Me.text_Ticket3.Name = "text_Ticket3"
        Me.text_Ticket3.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket3.TabIndex = 30
        '
        'text_Ticket4
        '
        Me.text_Ticket4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket4.Location = New System.Drawing.Point(566, 106)
        Me.text_Ticket4.Name = "text_Ticket4"
        Me.text_Ticket4.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket4.TabIndex = 35
        '
        'text_Ticket5
        '
        Me.text_Ticket5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket5.Location = New System.Drawing.Point(566, 131)
        Me.text_Ticket5.Name = "text_Ticket5"
        Me.text_Ticket5.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket5.TabIndex = 40
        '
        'text_Ticket6
        '
        Me.text_Ticket6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket6.Location = New System.Drawing.Point(566, 156)
        Me.text_Ticket6.Name = "text_Ticket6"
        Me.text_Ticket6.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket6.TabIndex = 45
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket2, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket3, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket4, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket5, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket6, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket7, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket8, 5, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket9, 5, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket10, 5, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate4, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate5, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate6, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate7, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate8, 4, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate9, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate10, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip4, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip6, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip7, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip8, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip3, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip9, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip10, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer10, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer9, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer8, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer7, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer6, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer5, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer4, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum7, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum6, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum8, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.text_Ticket1, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Fld_CustomerLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum9, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum10, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.text_QtyShip5, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate3, 4, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(752, 283)
        Me.TableLayoutPanel1.TabIndex = 99
        '
        'text_Ticket7
        '
        Me.text_Ticket7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket7.Location = New System.Drawing.Point(566, 181)
        Me.text_Ticket7.Name = "text_Ticket7"
        Me.text_Ticket7.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket7.TabIndex = 50
        '
        'text_Ticket8
        '
        Me.text_Ticket8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket8.Location = New System.Drawing.Point(566, 206)
        Me.text_Ticket8.Name = "text_Ticket8"
        Me.text_Ticket8.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket8.TabIndex = 55
        '
        'text_Ticket9
        '
        Me.text_Ticket9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket9.Location = New System.Drawing.Point(566, 231)
        Me.text_Ticket9.Name = "text_Ticket9"
        Me.text_Ticket9.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket9.TabIndex = 60
        '
        'text_Ticket10
        '
        Me.text_Ticket10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket10.Location = New System.Drawing.Point(566, 256)
        Me.text_Ticket10.Name = "text_Ticket10"
        Me.text_Ticket10.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket10.TabIndex = 65
        '
        'date_ShipDate2
        '
        Me.date_ShipDate2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate2.Location = New System.Drawing.Point(469, 56)
        Me.date_ShipDate2.Name = "date_ShipDate2"
        Me.date_ShipDate2.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate2.TabIndex = 24
        Me.date_ShipDate2.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'combo_Customer1
        '
        Me.combo_Customer1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers1BindingSource, "fld_Customer", True))
        Me.combo_Customer1.DataSource = Me.TbltermCustomers1BindingSource
        Me.combo_Customer1.DisplayMember = "fld_Customer"
        Me.combo_Customer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer1.FormattingEnabled = True
        Me.combo_Customer1.Location = New System.Drawing.Point(221, 31)
        Me.combo_Customer1.Name = "combo_Customer1"
        Me.combo_Customer1.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer1.TabIndex = 17
        Me.combo_Customer1.ValueMember = "fld_Customer"
        '
        'TbltermCustomers1BindingSource
        '
        Me.TbltermCustomers1BindingSource.DataMember = "tbl_term_Customers1"
        Me.TbltermCustomers1BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'date_ShipDate4
        '
        Me.date_ShipDate4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate4.Location = New System.Drawing.Point(469, 106)
        Me.date_ShipDate4.Name = "date_ShipDate4"
        Me.date_ShipDate4.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate4.TabIndex = 34
        Me.date_ShipDate4.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate5
        '
        Me.date_ShipDate5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate5.Location = New System.Drawing.Point(469, 131)
        Me.date_ShipDate5.Name = "date_ShipDate5"
        Me.date_ShipDate5.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate5.TabIndex = 39
        Me.date_ShipDate5.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate6
        '
        Me.date_ShipDate6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate6.Location = New System.Drawing.Point(469, 156)
        Me.date_ShipDate6.Name = "date_ShipDate6"
        Me.date_ShipDate6.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate6.TabIndex = 44
        Me.date_ShipDate6.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate7
        '
        Me.date_ShipDate7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate7.Location = New System.Drawing.Point(469, 181)
        Me.date_ShipDate7.Name = "date_ShipDate7"
        Me.date_ShipDate7.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate7.TabIndex = 49
        Me.date_ShipDate7.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate8
        '
        Me.date_ShipDate8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate8.Location = New System.Drawing.Point(469, 206)
        Me.date_ShipDate8.Name = "date_ShipDate8"
        Me.date_ShipDate8.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate8.TabIndex = 54
        Me.date_ShipDate8.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate9
        '
        Me.date_ShipDate9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate9.Location = New System.Drawing.Point(469, 231)
        Me.date_ShipDate9.Name = "date_ShipDate9"
        Me.date_ShipDate9.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate9.TabIndex = 59
        Me.date_ShipDate9.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'date_ShipDate10
        '
        Me.date_ShipDate10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate10.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate10.Location = New System.Drawing.Point(469, 256)
        Me.date_ShipDate10.Name = "date_ShipDate10"
        Me.date_ShipDate10.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate10.TabIndex = 64
        Me.date_ShipDate10.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'text_QtyShip2
        '
        Me.text_QtyShip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip2.Location = New System.Drawing.Point(409, 56)
        Me.text_QtyShip2.Name = "text_QtyShip2"
        Me.text_QtyShip2.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip2.TabIndex = 23
        '
        'text_QtyShip4
        '
        Me.text_QtyShip4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip4.Location = New System.Drawing.Point(409, 106)
        Me.text_QtyShip4.Name = "text_QtyShip4"
        Me.text_QtyShip4.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip4.TabIndex = 33
        '
        'text_QtyShip6
        '
        Me.text_QtyShip6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip6.Location = New System.Drawing.Point(409, 156)
        Me.text_QtyShip6.Name = "text_QtyShip6"
        Me.text_QtyShip6.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip6.TabIndex = 43
        '
        'text_QtyShip7
        '
        Me.text_QtyShip7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip7.Location = New System.Drawing.Point(409, 181)
        Me.text_QtyShip7.Name = "text_QtyShip7"
        Me.text_QtyShip7.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip7.TabIndex = 48
        '
        'text_QtyShip8
        '
        Me.text_QtyShip8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip8.Location = New System.Drawing.Point(409, 206)
        Me.text_QtyShip8.Name = "text_QtyShip8"
        Me.text_QtyShip8.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip8.TabIndex = 53
        '
        'text_QtyShip3
        '
        Me.text_QtyShip3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip3.Location = New System.Drawing.Point(409, 81)
        Me.text_QtyShip3.Name = "text_QtyShip3"
        Me.text_QtyShip3.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip3.TabIndex = 28
        '
        'text_QtyShip9
        '
        Me.text_QtyShip9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip9.Location = New System.Drawing.Point(409, 231)
        Me.text_QtyShip9.Name = "text_QtyShip9"
        Me.text_QtyShip9.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip9.TabIndex = 58
        '
        'text_QtyShip10
        '
        Me.text_QtyShip10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip10.Location = New System.Drawing.Point(409, 256)
        Me.text_QtyShip10.Name = "text_QtyShip10"
        Me.text_QtyShip10.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip10.TabIndex = 63
        '
        'combo_Customer10
        '
        Me.combo_Customer10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer10.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers10BindingSource, "fld_Customer", True))
        Me.combo_Customer10.DataSource = Me.TbltermCustomers10BindingSource
        Me.combo_Customer10.DisplayMember = "fld_Customer"
        Me.combo_Customer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer10.FormattingEnabled = True
        Me.combo_Customer10.Location = New System.Drawing.Point(221, 256)
        Me.combo_Customer10.Name = "combo_Customer10"
        Me.combo_Customer10.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer10.TabIndex = 62
        Me.combo_Customer10.ValueMember = "fld_Customer"
        '
        'TbltermCustomers10BindingSource
        '
        Me.TbltermCustomers10BindingSource.DataMember = "tbl_term_Customers10"
        Me.TbltermCustomers10BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer9
        '
        Me.combo_Customer9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer9.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers9BindingSource, "fld_Customer", True))
        Me.combo_Customer9.DataSource = Me.TbltermCustomers9BindingSource
        Me.combo_Customer9.DisplayMember = "fld_Customer"
        Me.combo_Customer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer9.FormattingEnabled = True
        Me.combo_Customer9.Location = New System.Drawing.Point(221, 231)
        Me.combo_Customer9.Name = "combo_Customer9"
        Me.combo_Customer9.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer9.TabIndex = 57
        Me.combo_Customer9.ValueMember = "fld_Customer"
        '
        'TbltermCustomers9BindingSource
        '
        Me.TbltermCustomers9BindingSource.DataMember = "tbl_term_Customers9"
        Me.TbltermCustomers9BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer8
        '
        Me.combo_Customer8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer8.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers8BindingSource, "fld_Customer", True))
        Me.combo_Customer8.DataSource = Me.TbltermCustomers8BindingSource
        Me.combo_Customer8.DisplayMember = "fld_Customer"
        Me.combo_Customer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer8.FormattingEnabled = True
        Me.combo_Customer8.Location = New System.Drawing.Point(221, 206)
        Me.combo_Customer8.Name = "combo_Customer8"
        Me.combo_Customer8.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer8.TabIndex = 52
        Me.combo_Customer8.ValueMember = "fld_Customer"
        '
        'TbltermCustomers8BindingSource
        '
        Me.TbltermCustomers8BindingSource.DataMember = "tbl_term_Customers8"
        Me.TbltermCustomers8BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer7
        '
        Me.combo_Customer7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers7BindingSource, "fld_Customer", True))
        Me.combo_Customer7.DataSource = Me.TbltermCustomers7BindingSource
        Me.combo_Customer7.DisplayMember = "fld_Customer"
        Me.combo_Customer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer7.FormattingEnabled = True
        Me.combo_Customer7.Location = New System.Drawing.Point(221, 181)
        Me.combo_Customer7.Name = "combo_Customer7"
        Me.combo_Customer7.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer7.TabIndex = 47
        Me.combo_Customer7.ValueMember = "fld_Customer"
        '
        'TbltermCustomers7BindingSource
        '
        Me.TbltermCustomers7BindingSource.DataMember = "tbl_term_Customers7"
        Me.TbltermCustomers7BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer6
        '
        Me.combo_Customer6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers6BindingSource, "fld_Customer", True))
        Me.combo_Customer6.DataSource = Me.TbltermCustomers6BindingSource
        Me.combo_Customer6.DisplayMember = "fld_Customer"
        Me.combo_Customer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer6.FormattingEnabled = True
        Me.combo_Customer6.Location = New System.Drawing.Point(221, 156)
        Me.combo_Customer6.Name = "combo_Customer6"
        Me.combo_Customer6.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer6.TabIndex = 42
        Me.combo_Customer6.ValueMember = "fld_Customer"
        '
        'TbltermCustomers6BindingSource
        '
        Me.TbltermCustomers6BindingSource.DataMember = "tbl_term_Customers6"
        Me.TbltermCustomers6BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer5
        '
        Me.combo_Customer5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers5BindingSource, "fld_Customer", True))
        Me.combo_Customer5.DataSource = Me.TbltermCustomers5BindingSource
        Me.combo_Customer5.DisplayMember = "fld_Customer"
        Me.combo_Customer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer5.FormattingEnabled = True
        Me.combo_Customer5.Location = New System.Drawing.Point(221, 131)
        Me.combo_Customer5.Name = "combo_Customer5"
        Me.combo_Customer5.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer5.TabIndex = 37
        Me.combo_Customer5.ValueMember = "fld_Customer"
        '
        'TbltermCustomers5BindingSource
        '
        Me.TbltermCustomers5BindingSource.DataMember = "tbl_term_Customers5"
        Me.TbltermCustomers5BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer4
        '
        Me.combo_Customer4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers4BindingSource, "fld_Customer", True))
        Me.combo_Customer4.DataSource = Me.TbltermCustomers4BindingSource
        Me.combo_Customer4.DisplayMember = "fld_Customer"
        Me.combo_Customer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer4.FormattingEnabled = True
        Me.combo_Customer4.Location = New System.Drawing.Point(221, 106)
        Me.combo_Customer4.Name = "combo_Customer4"
        Me.combo_Customer4.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer4.TabIndex = 32
        Me.combo_Customer4.ValueMember = "fld_Customer"
        '
        'TbltermCustomers4BindingSource
        '
        Me.TbltermCustomers4BindingSource.DataMember = "tbl_term_Customers4"
        Me.TbltermCustomers4BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer3
        '
        Me.combo_Customer3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers3BindingSource, "fld_Customer", True))
        Me.combo_Customer3.DataSource = Me.TbltermCustomers3BindingSource
        Me.combo_Customer3.DisplayMember = "fld_Customer"
        Me.combo_Customer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer3.FormattingEnabled = True
        Me.combo_Customer3.Location = New System.Drawing.Point(221, 81)
        Me.combo_Customer3.Name = "combo_Customer3"
        Me.combo_Customer3.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer3.TabIndex = 27
        Me.combo_Customer3.ValueMember = "fld_Customer"
        '
        'TbltermCustomers3BindingSource
        '
        Me.TbltermCustomers3BindingSource.DataMember = "tbl_term_Customers3"
        Me.TbltermCustomers3BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Customer2
        '
        Me.combo_Customer2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbltermCustomers2BindingSource, "fld_Customer", True))
        Me.combo_Customer2.DataSource = Me.TbltermCustomers2BindingSource
        Me.combo_Customer2.DisplayMember = "fld_Customer"
        Me.combo_Customer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer2.FormattingEnabled = True
        Me.combo_Customer2.Location = New System.Drawing.Point(221, 56)
        Me.combo_Customer2.Name = "combo_Customer2"
        Me.combo_Customer2.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer2.TabIndex = 22
        Me.combo_Customer2.ValueMember = "fld_Customer"
        '
        'TbltermCustomers2BindingSource
        '
        Me.TbltermCustomers2BindingSource.DataMember = "tbl_term_Customers2"
        Me.TbltermCustomers2BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'text_POnum7
        '
        Me.text_POnum7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum7.Location = New System.Drawing.Point(33, 181)
        Me.text_POnum7.Name = "text_POnum7"
        Me.text_POnum7.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum7.TabIndex = 46
        '
        'text_POnum6
        '
        Me.text_POnum6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum6.Location = New System.Drawing.Point(33, 156)
        Me.text_POnum6.Name = "text_POnum6"
        Me.text_POnum6.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum6.TabIndex = 41
        '
        'text_POnum5
        '
        Me.text_POnum5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum5.Location = New System.Drawing.Point(33, 131)
        Me.text_POnum5.Name = "text_POnum5"
        Me.text_POnum5.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum5.TabIndex = 36
        '
        'text_POnum4
        '
        Me.text_POnum4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum4.Location = New System.Drawing.Point(33, 106)
        Me.text_POnum4.Name = "text_POnum4"
        Me.text_POnum4.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum4.TabIndex = 31
        '
        'text_POnum3
        '
        Me.text_POnum3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum3.Location = New System.Drawing.Point(33, 81)
        Me.text_POnum3.Name = "text_POnum3"
        Me.text_POnum3.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum3.TabIndex = 26
        '
        'text_POnum2
        '
        Me.text_POnum2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum2.Location = New System.Drawing.Point(33, 56)
        Me.text_POnum2.Name = "text_POnum2"
        Me.text_POnum2.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum2.TabIndex = 21
        '
        'text_POnum8
        '
        Me.text_POnum8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum8.Location = New System.Drawing.Point(33, 206)
        Me.text_POnum8.Name = "text_POnum8"
        Me.text_POnum8.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum8.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(409, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 28)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Qty Shipped"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 25)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "5"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 28)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "#"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 25)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 25)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date_ShipDate1
        '
        Me.date_ShipDate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate1.Location = New System.Drawing.Point(469, 31)
        Me.date_ShipDate1.Name = "date_ShipDate1"
        Me.date_ShipDate1.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate1.TabIndex = 19
        Me.date_ShipDate1.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(3, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 25)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_Ticket1
        '
        Me.text_Ticket1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Ticket1.Location = New System.Drawing.Point(566, 31)
        Me.text_Ticket1.Name = "text_Ticket1"
        Me.text_Ticket1.Size = New System.Drawing.Size(183, 20)
        Me.text_Ticket1.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(3, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "4"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(566, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 28)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Ticket #"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(469, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 28)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Shipping Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(33, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 28)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "PO Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_POnum1
        '
        Me.text_POnum1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum1.Location = New System.Drawing.Point(33, 31)
        Me.text_POnum1.Name = "text_POnum1"
        Me.text_POnum1.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum1.TabIndex = 16
        '
        'Fld_CustomerLabel
        '
        Me.Fld_CustomerLabel.AutoSize = True
        Me.Fld_CustomerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fld_CustomerLabel.Location = New System.Drawing.Point(221, 0)
        Me.Fld_CustomerLabel.Name = "Fld_CustomerLabel"
        Me.Fld_CustomerLabel.Size = New System.Drawing.Size(182, 28)
        Me.Fld_CustomerLabel.TabIndex = 99
        Me.Fld_CustomerLabel.Text = "Customer"
        Me.Fld_CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_QtyShip1
        '
        Me.text_QtyShip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip1.Location = New System.Drawing.Point(409, 31)
        Me.text_QtyShip1.Name = "text_QtyShip1"
        Me.text_QtyShip1.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "6"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 25)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "7"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(3, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 25)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "8"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Location = New System.Drawing.Point(3, 228)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 25)
        Me.Label19.TabIndex = 99
        Me.Label19.Text = "9"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Location = New System.Drawing.Point(3, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 30)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "10"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_POnum9
        '
        Me.text_POnum9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum9.Location = New System.Drawing.Point(33, 231)
        Me.text_POnum9.Name = "text_POnum9"
        Me.text_POnum9.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum9.TabIndex = 56
        '
        'text_POnum10
        '
        Me.text_POnum10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum10.Location = New System.Drawing.Point(33, 256)
        Me.text_POnum10.Name = "text_POnum10"
        Me.text_POnum10.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum10.TabIndex = 61
        '
        'text_QtyShip5
        '
        Me.text_QtyShip5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_QtyShip5.Location = New System.Drawing.Point(409, 131)
        Me.text_QtyShip5.Name = "text_QtyShip5"
        Me.text_QtyShip5.Size = New System.Drawing.Size(54, 20)
        Me.text_QtyShip5.TabIndex = 38
        '
        'date_ShipDate3
        '
        Me.date_ShipDate3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate3.Location = New System.Drawing.Point(469, 81)
        Me.date_ShipDate3.Name = "date_ShipDate3"
        Me.date_ShipDate3.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate3.TabIndex = 29
        Me.date_ShipDate3.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(758, 302)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shipping Info"
        '
        'text_WOnum
        '
        Me.text_WOnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text_WOnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_WOnumBindingSource, "fld_WOnum", True))
        Me.text_WOnum.Location = New System.Drawing.Point(104, 3)
        Me.text_WOnum.Name = "text_WOnum"
        Me.text_WOnum.ReadOnly = True
        Me.text_WOnum.Size = New System.Drawing.Size(96, 20)
        Me.text_WOnum.TabIndex = 0
        Me.text_WOnum.TabStop = False
        '
        'Tbl_WOnumBindingSource
        '
        Me.Tbl_WOnumBindingSource.DataMember = "tbl_WOnum"
        Me.Tbl_WOnumBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_Customers10TableAdapter
        '
        Me.Tbl_term_Customers10TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers8TableAdapter
        '
        Me.Tbl_term_Customers8TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers7TableAdapter
        '
        Me.Tbl_term_Customers7TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers6TableAdapter
        '
        Me.Tbl_term_Customers6TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers5TableAdapter
        '
        Me.Tbl_term_Customers5TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers4TableAdapter
        '
        Me.Tbl_term_Customers4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers3TableAdapter
        '
        Me.Tbl_term_Customers3TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers2TableAdapter
        '
        Me.Tbl_term_Customers2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers1TableAdapter
        '
        Me.Tbl_term_Customers1TableAdapter.ClearBeforeFill = True
        '
        'TbltermCustomersBindingSource
        '
        Me.TbltermCustomersBindingSource.DataMember = "tbl_term_Customers"
        '
        'text_Notes
        '
        Me.text_Notes.AcceptsReturn = True
        Me.text_Notes.AcceptsTab = True
        Me.text_Notes.AllowDrop = True
        Me.text_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Notes.Location = New System.Drawing.Point(3, 3)
        Me.text_Notes.Multiline = True
        Me.text_Notes.Name = "text_Notes"
        Me.text_Notes.Size = New System.Drawing.Size(764, 483)
        Me.text_Notes.TabIndex = 66
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.text_Notes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tbl_term_Customers9TableAdapter
        '
        Me.Tbl_term_Customers9TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Exit.Location = New System.Drawing.Point(670, 3)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(105, 28)
        Me.button_Exit.TabIndex = 68
        Me.button_Exit.Text = "CANCEL"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 515)
        Me.TabControl1.TabIndex = 99
        Me.TabControl1.TabStop = False
        Me.TabControl1.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Work Order Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.43892!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.56108!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(764, 483)
        Me.TableLayoutPanel3.TabIndex = 99
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36412!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.63589!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(758, 169)
        Me.TableLayoutPanel2.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 163)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Info"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.date_WOdate, 1, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.text_Qty, 1, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.combo_Status, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.text_QBBAnum, 1, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel9.Controls.Add(Label12, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Fld_WOnumLabel, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.text_WOnum, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 6
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89474!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89474!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89474!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89474!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89474!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(203, 144)
        Me.TableLayoutPanel9.TabIndex = 99
        '
        'date_WOdate
        '
        Me.date_WOdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.date_WOdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_WOdate.Location = New System.Drawing.Point(104, 43)
        Me.date_WOdate.Name = "date_WOdate"
        Me.date_WOdate.Size = New System.Drawing.Size(96, 20)
        Me.date_WOdate.TabIndex = 1
        Me.date_WOdate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'text_Qty
        '
        Me.text_Qty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.text_Qty.Location = New System.Drawing.Point(104, 119)
        Me.text_Qty.Name = "text_Qty"
        Me.text_Qty.Size = New System.Drawing.Size(96, 20)
        Me.text_Qty.TabIndex = 4
        '
        'combo_Status
        '
        Me.combo_Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.combo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Status.FormattingEnabled = True
        Me.combo_Status.Items.AddRange(New Object() {"", "OPEN", "PARTIAL", "STOCK", "REPAIR", "CLOSED"})
        Me.combo_Status.Location = New System.Drawing.Point(104, 68)
        Me.combo_Status.Name = "combo_Status"
        Me.combo_Status.Size = New System.Drawing.Size(96, 21)
        Me.combo_Status.TabIndex = 2
        '
        'text_QBBAnum
        '
        Me.text_QBBAnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text_QBBAnum.Location = New System.Drawing.Point(104, 93)
        Me.text_QBBAnum.Name = "text_QBBAnum"
        Me.text_QBBAnum.Size = New System.Drawing.Size(96, 20)
        Me.text_QBBAnum.TabIndex = 3
        Me.text_QBBAnum.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 29)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Order Quantity:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "QB BA #:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Tbl_term_TempClassTableAdapter
        '
        Me.Tbl_term_TempClassTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_SizeTableAdapter
        '
        Me.Tbl_term_SizeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PSLTableAdapter
        '
        Me.Tbl_term_PSLTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PressureTableAdapter
        '
        Me.Tbl_term_PressureTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PRTableAdapter
        '
        Me.Tbl_term_PRTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_HHPPTableAdapter
        '
        Me.Tbl_term_HHPPTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_StyleTableAdapter
        '
        Me.Tbl_term_StyleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_data_WOlogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers10TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers3TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers4TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers5TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers6TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers7TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers8TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_Customers9TableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_HHPPTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PressureTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PRTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Me.Tbl_WOnumTableAdapter
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_WOnumTableAdapter
        '
        Me.Tbl_WOnumTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_ProductTypeTableAdapter
        '
        Me.Tbl_term_ProductTypeTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42416!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.65553!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65296!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.13882!))
        Me.TableLayoutPanel5.Controls.Add(Me.button_Delete, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Exit, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Submit, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 524)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(778, 34)
        Me.TableLayoutPanel5.TabIndex = 99
        '
        'button_Delete
        '
        Me.button_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Delete.Location = New System.Drawing.Point(3, 3)
        Me.button_Delete.Name = "button_Delete"
        Me.button_Delete.Size = New System.Drawing.Size(114, 28)
        Me.button_Delete.TabIndex = 69
        Me.button_Delete.Text = "DELETE RECORD"
        Me.button_Delete.UseVisualStyleBackColor = True
        '
        'button_Submit
        '
        Me.button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Submit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Submit.Location = New System.Drawing.Point(556, 3)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(108, 28)
        Me.button_Submit.TabIndex = 67
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'Tbl_term_TrimTableAdapter
        '
        Me.Tbl_term_TrimTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(784, 561)
        Me.TableLayoutPanel4.TabIndex = 100
        '
        'TbltermStyleBindingSource
        '
        Me.TbltermStyleBindingSource.DataMember = "tbl_term_Style"
        Me.TbltermStyleBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermProductTypeBindingSource
        '
        Me.TbltermProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.TbltermProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermSizeBindingSource
        '
        Me.TbltermSizeBindingSource.DataMember = "tbl_term_Size"
        Me.TbltermSizeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermPressureBindingSource
        '
        Me.TbltermPressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.TbltermPressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermTempClassBindingSource
        '
        Me.TbltermTempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.TbltermTempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermTrimBindingSource
        '
        Me.TbltermTrimBindingSource.DataMember = "tbl_term_Trim"
        Me.TbltermTrimBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermPSLBindingSource
        '
        Me.TbltermPSLBindingSource.DataMember = "tbl_term_PSL"
        Me.TbltermPSLBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermPRBindingSource
        '
        Me.TbltermPRBindingSource.DataMember = "tbl_term_PR"
        Me.TbltermPRBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermHHPPBindingSource
        '
        Me.TbltermHHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.TbltermHHPPBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'form_EditIEntryNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_EditIEntryNew"
        Me.Text = "Neeco Work Order App - Edit Work Order"
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TbltermCustomers1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers10BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers9BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomers2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents check_BO As CheckBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents text_PartNum As TextBox
    Friend WithEvents combo_ProductType As ComboBox
    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents combo_Size As ComboBox
    Friend WithEvents combo_Pressure As ComboBox
    Friend WithEvents combo_Operator As ComboBox
    Friend WithEvents combo_PR As ComboBox
    Friend WithEvents combo_PSL As ComboBox
    Friend WithEvents combo_Trim As ComboBox
    Friend WithEvents combo_TempClass As ComboBox
    Friend WithEvents text_Ticket2 As TextBox
    Friend WithEvents text_Ticket3 As TextBox
    Friend WithEvents text_Ticket4 As TextBox
    Friend WithEvents text_Ticket5 As TextBox
    Friend WithEvents text_Ticket6 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents text_Ticket7 As TextBox
    Friend WithEvents text_Ticket8 As TextBox
    Friend WithEvents text_Ticket9 As TextBox
    Friend WithEvents text_Ticket10 As TextBox
    Friend WithEvents date_ShipDate2 As DateTimePicker
    Friend WithEvents combo_Customer1 As ComboBox
    Friend WithEvents TbltermCustomers1BindingSource As BindingSource
    Friend WithEvents date_ShipDate4 As DateTimePicker
    Friend WithEvents date_ShipDate5 As DateTimePicker
    Friend WithEvents date_ShipDate6 As DateTimePicker
    Friend WithEvents date_ShipDate7 As DateTimePicker
    Friend WithEvents date_ShipDate8 As DateTimePicker
    Friend WithEvents date_ShipDate9 As DateTimePicker
    Friend WithEvents date_ShipDate10 As DateTimePicker
    Friend WithEvents text_QtyShip2 As TextBox
    Friend WithEvents text_QtyShip4 As TextBox
    Friend WithEvents text_QtyShip6 As TextBox
    Friend WithEvents text_QtyShip7 As TextBox
    Friend WithEvents text_QtyShip8 As TextBox
    Friend WithEvents text_QtyShip3 As TextBox
    Friend WithEvents text_QtyShip9 As TextBox
    Friend WithEvents text_QtyShip10 As TextBox
    Friend WithEvents combo_Customer10 As ComboBox
    Friend WithEvents TbltermCustomers10BindingSource As BindingSource
    Friend WithEvents combo_Customer9 As ComboBox
    Friend WithEvents TbltermCustomers9BindingSource As BindingSource
    Friend WithEvents combo_Customer8 As ComboBox
    Friend WithEvents TbltermCustomers8BindingSource As BindingSource
    Friend WithEvents combo_Customer7 As ComboBox
    Friend WithEvents TbltermCustomers7BindingSource As BindingSource
    Friend WithEvents combo_Customer6 As ComboBox
    Friend WithEvents TbltermCustomers6BindingSource As BindingSource
    Friend WithEvents combo_Customer5 As ComboBox
    Friend WithEvents TbltermCustomers5BindingSource As BindingSource
    Friend WithEvents combo_Customer4 As ComboBox
    Friend WithEvents TbltermCustomers4BindingSource As BindingSource
    Friend WithEvents combo_Customer3 As ComboBox
    Friend WithEvents TbltermCustomers3BindingSource As BindingSource
    Friend WithEvents combo_Customer2 As ComboBox
    Friend WithEvents TbltermCustomers2BindingSource As BindingSource
    Friend WithEvents text_POnum7 As TextBox
    Friend WithEvents text_POnum6 As TextBox
    Friend WithEvents text_POnum5 As TextBox
    Friend WithEvents text_POnum4 As TextBox
    Friend WithEvents text_POnum3 As TextBox
    Friend WithEvents text_POnum2 As TextBox
    Friend WithEvents text_POnum8 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents date_ShipDate1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents text_Ticket1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_POnum1 As TextBox
    Friend WithEvents Fld_CustomerLabel As Label
    Friend WithEvents text_QtyShip1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents text_POnum9 As TextBox
    Friend WithEvents text_POnum10 As TextBox
    Friend WithEvents text_QtyShip5 As TextBox
    Friend WithEvents date_ShipDate3 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents text_WOnum As TextBox
    Friend WithEvents Tbl_WOnumBindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers10TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers10TableAdapter
    Friend WithEvents Tbl_term_Customers8TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers8TableAdapter
    Friend WithEvents Tbl_term_Customers7TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers7TableAdapter
    Friend WithEvents Tbl_term_Customers6TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers6TableAdapter
    Friend WithEvents Tbl_term_Customers5TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers5TableAdapter
    Friend WithEvents Tbl_term_Customers4TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers4TableAdapter
    Friend WithEvents Tbl_term_Customers3TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers3TableAdapter
    Friend WithEvents Tbl_term_Customers2TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers2TableAdapter
    Friend WithEvents Tbl_term_Customers1TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers1TableAdapter
    Friend WithEvents TbltermCustomersBindingSource As BindingSource
    Friend WithEvents text_Notes As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Tbl_term_Customers9TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers9TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents button_Exit As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents date_WOdate As DateTimePicker
    Friend WithEvents text_Qty As TextBox
    Friend WithEvents combo_Status As ComboBox
    Friend WithEvents text_QBBAnum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents Tbl_term_PRTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents Tbl_term_StyleTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_WOnumTableAdapter As db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter
    Friend WithEvents Tbl_term_ProductTypeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents button_Delete As Button
    Friend WithEvents button_Submit As Button
    Friend WithEvents Tbl_term_TrimTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents combo_Style As ComboBox
    Friend WithEvents TbltermProductTypeBindingSource As BindingSource
    Friend WithEvents TbltermSizeBindingSource As BindingSource
    Friend WithEvents TbltermPressureBindingSource As BindingSource
    Friend WithEvents TbltermStyleBindingSource As BindingSource
    Friend WithEvents TbltermHHPPBindingSource As BindingSource
    Friend WithEvents TbltermPRBindingSource As BindingSource
    Friend WithEvents TbltermPSLBindingSource As BindingSource
    Friend WithEvents TbltermTrimBindingSource As BindingSource
    Friend WithEvents TbltermTempClassBindingSource As BindingSource
End Class
