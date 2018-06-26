<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_AddNewEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Fld_WOnumLabel As System.Windows.Forms.Label
        Dim Fld_HHPPLabel As System.Windows.Forms.Label
        Dim Fld_PRLabel As System.Windows.Forms.Label
        Dim Fld_PressureLabel As System.Windows.Forms.Label
        Dim Fld_PSLLabel As System.Windows.Forms.Label
        Dim Fld_ShipmentMethodLabel As System.Windows.Forms.Label
        Dim Fld_SizeLabel As System.Windows.Forms.Label
        Dim Fld_StyleLabel As System.Windows.Forms.Label
        Dim Fld_TempClassLabel As System.Windows.Forms.Label
        Dim Fld_TrimLabel As System.Windows.Forms.Label
        Dim Fld_ProductTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AddNewEntry))
        Me.Fld_CustomerLabel = New System.Windows.Forms.Label()
        Me.Tbl_WOnumBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_WOnumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_WOnumBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.text_WOnum = New System.Windows.Forms.TextBox()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.combo_Customer = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Operator = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_HHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PR = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_PRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Pressure = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_PressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PSL = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_PSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_ShipTerms = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_ShipMethodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Size = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Style = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_TempClass = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_TempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Trim = New System.Windows.Forms.ComboBox()
        Me.Tbl_term_TrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.date_WOdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_PartNum = New System.Windows.Forms.TextBox()
        Me.text_Notes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_POnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_DeliveryTicketNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_InvNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_QBBAnum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbl_term_ProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_WOnumTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_CustomersTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter()
        Me.Tbl_term_HHPPTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter()
        Me.Tbl_term_PRTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter()
        Me.Tbl_term_PressureTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter()
        Me.Tbl_term_PSLTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter()
        Me.Tbl_term_ShipMethodTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ShipMethodTableAdapter()
        Me.Tbl_term_SizeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter()
        Me.Tbl_term_StyleTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter()
        Me.Tbl_term_TempClassTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter()
        Me.Tbl_term_TrimTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter()
        Me.Tbl_term_ProductTypeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter()
        Me.combo_ProductType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.text_Qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.date_InvDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.date_ShipDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.button_Clear = New System.Windows.Forms.Button()
        Fld_WOnumLabel = New System.Windows.Forms.Label()
        Fld_HHPPLabel = New System.Windows.Forms.Label()
        Fld_PRLabel = New System.Windows.Forms.Label()
        Fld_PressureLabel = New System.Windows.Forms.Label()
        Fld_PSLLabel = New System.Windows.Forms.Label()
        Fld_ShipmentMethodLabel = New System.Windows.Forms.Label()
        Fld_SizeLabel = New System.Windows.Forms.Label()
        Fld_StyleLabel = New System.Windows.Forms.Label()
        Fld_TempClassLabel = New System.Windows.Forms.Label()
        Fld_TrimLabel = New System.Windows.Forms.Label()
        Fld_ProductTypeLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_WOnumBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_WOnumBindingNavigator.SuspendLayout()
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_HHPPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PSLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_ShipMethodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TempClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TrimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_ProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        'Fld_HHPPLabel
        '
        Fld_HHPPLabel.AutoSize = True
        Fld_HHPPLabel.Location = New System.Drawing.Point(480, 90)
        Fld_HHPPLabel.Name = "Fld_HHPPLabel"
        Fld_HHPPLabel.Size = New System.Drawing.Size(78, 13)
        Fld_HHPPLabel.TabIndex = 14
        Fld_HHPPLabel.Text = "Operator Type:"
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
        'Fld_PressureLabel
        '
        Fld_PressureLabel.AutoSize = True
        Fld_PressureLabel.Location = New System.Drawing.Point(267, 89)
        Fld_PressureLabel.Name = "Fld_PressureLabel"
        Fld_PressureLabel.Size = New System.Drawing.Size(51, 13)
        Fld_PressureLabel.TabIndex = 16
        Fld_PressureLabel.Text = "Pressure:"
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
        'Fld_StyleLabel
        '
        Fld_StyleLabel.AutoSize = True
        Fld_StyleLabel.Location = New System.Drawing.Point(525, 119)
        Fld_StyleLabel.Name = "Fld_StyleLabel"
        Fld_StyleLabel.Size = New System.Drawing.Size(33, 13)
        Fld_StyleLabel.TabIndex = 21
        Fld_StyleLabel.Text = "Style:"
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
        'Fld_CustomerLabel
        '
        Me.Fld_CustomerLabel.AutoSize = True
        Me.Fld_CustomerLabel.Location = New System.Drawing.Point(264, 65)
        Me.Fld_CustomerLabel.Name = "Fld_CustomerLabel"
        Me.Fld_CustomerLabel.Size = New System.Drawing.Size(54, 13)
        Me.Fld_CustomerLabel.TabIndex = 13
        Me.Fld_CustomerLabel.Text = "Customer:"
        '
        'Tbl_WOnumBindingNavigator
        '
        Me.Tbl_WOnumBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_WOnumBindingNavigator.BindingSource = Me.Tbl_WOnumBindingSource
        Me.Tbl_WOnumBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_WOnumBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_WOnumBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_WOnumBindingNavigatorSaveItem})
        Me.Tbl_WOnumBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_WOnumBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_WOnumBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_WOnumBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_WOnumBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_WOnumBindingNavigator.Name = "Tbl_WOnumBindingNavigator"
        Me.Tbl_WOnumBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_WOnumBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Tbl_WOnumBindingNavigator.TabIndex = 0
        Me.Tbl_WOnumBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_WOnumBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Tbl_WOnumBindingSource
        '
        Me.Tbl_WOnumBindingSource.DataMember = "tbl_WOnum"
        Me.Tbl_WOnumBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_WOnumBindingNavigatorSaveItem
        '
        Me.Tbl_WOnumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_WOnumBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_WOnumBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_WOnumBindingNavigatorSaveItem.Name = "Tbl_WOnumBindingNavigatorSaveItem"
        Me.Tbl_WOnumBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_WOnumBindingNavigatorSaveItem.Text = "Save Data"
        '
        'text_WOnum
        '
        Me.text_WOnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_WOnumBindingSource, "fld_WOnum", True))
        Me.text_WOnum.Location = New System.Drawing.Point(97, 36)
        Me.text_WOnum.Name = "text_WOnum"
        Me.text_WOnum.ReadOnly = True
        Me.text_WOnum.Size = New System.Drawing.Size(105, 20)
        Me.text_WOnum.TabIndex = 99
        Me.text_WOnum.TabStop = False
        '
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Location = New System.Drawing.Point(617, 490)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(95, 23)
        Me.button_Exit.TabIndex = 24
        Me.button_Exit.Text = "CANCEL"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'combo_Customer
        '
        Me.combo_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.combo_Customer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.combo_Customer.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.combo_Customer.DisplayMember = "fld_Customer"
        Me.combo_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer.FormattingEnabled = True
        Me.combo_Customer.Location = New System.Drawing.Point(324, 62)
        Me.combo_Customer.Name = "combo_Customer"
        Me.combo_Customer.Size = New System.Drawing.Size(361, 21)
        Me.combo_Customer.TabIndex = 4
        Me.combo_Customer.ValueMember = "fld_Customer"
        '
        'Tbl_term_CustomersBindingSource
        '
        Me.Tbl_term_CustomersBindingSource.DataMember = "tbl_term_Customers"
        Me.Tbl_term_CustomersBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Operator
        '
        Me.combo_Operator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Operator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataSource = Me.Tbl_term_HHPPBindingSource
        Me.combo_Operator.DisplayMember = "fld_HHPP"
        Me.combo_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Operator.FormattingEnabled = True
        Me.combo_Operator.Location = New System.Drawing.Point(564, 87)
        Me.combo_Operator.Name = "combo_Operator"
        Me.combo_Operator.Size = New System.Drawing.Size(121, 21)
        Me.combo_Operator.TabIndex = 12
        Me.combo_Operator.ValueMember = "fld_HHPP"
        '
        'Tbl_term_HHPPBindingSource
        '
        Me.Tbl_term_HHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.Tbl_term_HHPPBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_PR
        '
        Me.combo_PR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PRBindingSource, "fld_PR", True))
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PRBindingSource, "fld_PR", True))
        Me.combo_PR.DataSource = Me.Tbl_term_PRBindingSource
        Me.combo_PR.DisplayMember = "fld_PR"
        Me.combo_PR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PR.FormattingEnabled = True
        Me.combo_PR.Location = New System.Drawing.Point(324, 146)
        Me.combo_PR.Name = "combo_PR"
        Me.combo_PR.Size = New System.Drawing.Size(121, 21)
        Me.combo_PR.TabIndex = 17
        Me.combo_PR.ValueMember = "fld_PR"
        '
        'Tbl_term_PRBindingSource
        '
        Me.Tbl_term_PRBindingSource.DataMember = "tbl_term_PR"
        Me.Tbl_term_PRBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Pressure
        '
        Me.combo_Pressure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Pressure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataSource = Me.Tbl_term_PressureBindingSource
        Me.combo_Pressure.DisplayMember = "fld_Pressure"
        Me.combo_Pressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Pressure.FormattingEnabled = True
        Me.combo_Pressure.Location = New System.Drawing.Point(324, 86)
        Me.combo_Pressure.Name = "combo_Pressure"
        Me.combo_Pressure.Size = New System.Drawing.Size(121, 21)
        Me.combo_Pressure.TabIndex = 11
        Me.combo_Pressure.ValueMember = "fld_Pressure"
        '
        'Tbl_term_PressureBindingSource
        '
        Me.Tbl_term_PressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.Tbl_term_PressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_PSL
        '
        Me.combo_PSL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PSL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataSource = Me.Tbl_term_PSLBindingSource
        Me.combo_PSL.DisplayMember = "fld_PSL"
        Me.combo_PSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PSL.FormattingEnabled = True
        Me.combo_PSL.Location = New System.Drawing.Point(97, 146)
        Me.combo_PSL.Name = "combo_PSL"
        Me.combo_PSL.Size = New System.Drawing.Size(121, 21)
        Me.combo_PSL.TabIndex = 16
        Me.combo_PSL.ValueMember = "fld_PSL"
        '
        'Tbl_term_PSLBindingSource
        '
        Me.Tbl_term_PSLBindingSource.DataMember = "tbl_term_PSL"
        Me.Tbl_term_PSLBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_ShipTerms
        '
        Me.combo_ShipTerms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ShipTerms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ShipTerms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_ShipMethodBindingSource, "fld_ShipmentMethod", True))
        Me.combo_ShipTerms.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_ShipMethodBindingSource, "fld_ShipmentMethod", True))
        Me.combo_ShipTerms.DataSource = Me.Tbl_term_ShipMethodBindingSource
        Me.combo_ShipTerms.DisplayMember = "fld_ShipmentMethod"
        Me.combo_ShipTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ShipTerms.FormattingEnabled = True
        Me.combo_ShipTerms.Location = New System.Drawing.Point(540, 20)
        Me.combo_ShipTerms.Name = "combo_ShipTerms"
        Me.combo_ShipTerms.Size = New System.Drawing.Size(145, 21)
        Me.combo_ShipTerms.TabIndex = 19
        Me.combo_ShipTerms.ValueMember = "fld_ShipmentMethod"
        '
        'Tbl_term_ShipMethodBindingSource
        '
        Me.Tbl_term_ShipMethodBindingSource.DataMember = "tbl_term_ShipMethod"
        Me.Tbl_term_ShipMethodBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Size
        '
        Me.combo_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_SizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_SizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataSource = Me.Tbl_term_SizeBindingSource
        Me.combo_Size.DisplayMember = "fld_Size"
        Me.combo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Size.FormattingEnabled = True
        Me.combo_Size.Location = New System.Drawing.Point(96, 87)
        Me.combo_Size.Name = "combo_Size"
        Me.combo_Size.Size = New System.Drawing.Size(121, 21)
        Me.combo_Size.TabIndex = 10
        Me.combo_Size.ValueMember = "fld_Size"
        '
        'Tbl_term_SizeBindingSource
        '
        Me.Tbl_term_SizeBindingSource.DataMember = "tbl_term_Size"
        Me.Tbl_term_SizeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Style
        '
        Me.combo_Style.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_StyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_StyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataSource = Me.Tbl_term_StyleBindingSource
        Me.combo_Style.DisplayMember = "fld_Style"
        Me.combo_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Style.FormattingEnabled = True
        Me.combo_Style.Location = New System.Drawing.Point(564, 116)
        Me.combo_Style.Name = "combo_Style"
        Me.combo_Style.Size = New System.Drawing.Size(121, 21)
        Me.combo_Style.TabIndex = 15
        Me.combo_Style.ValueMember = "fld_Style"
        '
        'Tbl_term_StyleBindingSource
        '
        Me.Tbl_term_StyleBindingSource.DataMember = "tbl_term_Style"
        Me.Tbl_term_StyleBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_TempClass
        '
        Me.combo_TempClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_TempClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_TempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_TempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataSource = Me.Tbl_term_TempClassBindingSource
        Me.combo_TempClass.DisplayMember = "fld_TempClass"
        Me.combo_TempClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_TempClass.FormattingEnabled = True
        Me.combo_TempClass.Location = New System.Drawing.Point(97, 116)
        Me.combo_TempClass.Name = "combo_TempClass"
        Me.combo_TempClass.Size = New System.Drawing.Size(121, 21)
        Me.combo_TempClass.TabIndex = 13
        Me.combo_TempClass.ValueMember = "fld_TempClass"
        '
        'Tbl_term_TempClassBindingSource
        '
        Me.Tbl_term_TempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.Tbl_term_TempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'combo_Trim
        '
        Me.combo_Trim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Trim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_TrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_TrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataSource = Me.Tbl_term_TrimBindingSource
        Me.combo_Trim.DisplayMember = "fld_Trim"
        Me.combo_Trim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Trim.FormattingEnabled = True
        Me.combo_Trim.Location = New System.Drawing.Point(324, 116)
        Me.combo_Trim.Name = "combo_Trim"
        Me.combo_Trim.Size = New System.Drawing.Size(121, 21)
        Me.combo_Trim.TabIndex = 14
        Me.combo_Trim.ValueMember = "fld_Trim"
        '
        'Tbl_term_TrimBindingSource
        '
        Me.Tbl_term_TrimBindingSource.DataMember = "tbl_term_Trim"
        Me.Tbl_term_TrimBindingSource.DataSource = Me.Db_WOlogDataSet
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Date:"
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
        'text_POnum
        '
        Me.text_POnum.Location = New System.Drawing.Point(540, 36)
        Me.text_POnum.Name = "text_POnum"
        Me.text_POnum.Size = New System.Drawing.Size(145, 20)
        Me.text_POnum.TabIndex = 2
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
        'Tbl_term_ProductTypeBindingSource
        '
        Me.Tbl_term_ProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.Tbl_term_ProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_WOnumTableAdapter
        '
        Me.Tbl_WOnumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_data_WOlogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_HHPPTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PressureTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PRTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_ShipMethodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Me.Tbl_WOnumTableAdapter
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_CustomersTableAdapter
        '
        Me.Tbl_term_CustomersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_HHPPTableAdapter
        '
        Me.Tbl_term_HHPPTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PRTableAdapter
        '
        Me.Tbl_term_PRTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PressureTableAdapter
        '
        Me.Tbl_term_PressureTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_PSLTableAdapter
        '
        Me.Tbl_term_PSLTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_ShipMethodTableAdapter
        '
        Me.Tbl_term_ShipMethodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_SizeTableAdapter
        '
        Me.Tbl_term_SizeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_StyleTableAdapter
        '
        Me.Tbl_term_StyleTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_TempClassTableAdapter
        '
        Me.Tbl_term_TempClassTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_TrimTableAdapter
        '
        Me.Tbl_term_TrimTableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_ProductTypeTableAdapter
        '
        Me.Tbl_term_ProductTypeTableAdapter.ClearBeforeFill = True
        '
        'combo_ProductType
        '
        Me.combo_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_ProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_ProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataSource = Me.Tbl_term_ProductTypeBindingSource
        Me.combo_ProductType.DisplayMember = "fld_ProductType"
        Me.combo_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ProductType.FormattingEnabled = True
        Me.combo_ProductType.Location = New System.Drawing.Point(540, 35)
        Me.combo_ProductType.Name = "combo_ProductType"
        Me.combo_ProductType.Size = New System.Drawing.Size(145, 21)
        Me.combo_ProductType.TabIndex = 9
        Me.combo_ProductType.ValueMember = "fld_ProductType"
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 168)
        Me.GroupBox1.TabIndex = 41
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 182)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 110)
        Me.GroupBox3.TabIndex = 43
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
        'button_Submit
        '
        Me.button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Submit.Location = New System.Drawing.Point(516, 490)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(95, 23)
        Me.button_Submit.TabIndex = 23
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Clear.Location = New System.Drawing.Point(12, 490)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(95, 23)
        Me.button_Clear.TabIndex = 25
        Me.button_Clear.Text = "CLEAR FORM"
        Me.button_Clear.UseVisualStyleBackColor = True
        '
        'form_AddNewEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(724, 521)
        Me.Controls.Add(Me.button_Clear)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.Tbl_WOnumBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_AddNewEntry"
        Me.Text = "Neeco Work Order App - Add New Work Order"
        CType(Me.Tbl_WOnumBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_WOnumBindingNavigator.ResumeLayout(False)
        Me.Tbl_WOnumBindingNavigator.PerformLayout()
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_HHPPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PSLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_ShipMethodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TempClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TrimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_ProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_WOnumBindingSource As BindingSource
    Friend WithEvents Tbl_WOnumTableAdapter As db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_WOnumBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_WOnumBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents text_WOnum As TextBox
    Friend WithEvents button_Exit As Button
    Friend WithEvents Tbl_term_CustomersBindingSource As BindingSource
    Friend WithEvents Tbl_term_CustomersTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter
    Friend WithEvents combo_Customer As ComboBox
    Friend WithEvents Tbl_term_HHPPBindingSource As BindingSource
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents combo_Operator As ComboBox
    Friend WithEvents Tbl_term_PRBindingSource As BindingSource
    Friend WithEvents Tbl_term_PRTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter
    Friend WithEvents combo_PR As ComboBox
    Friend WithEvents Tbl_term_PressureBindingSource As BindingSource
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents combo_Pressure As ComboBox
    Friend WithEvents Tbl_term_ProductTypeBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
    Friend WithEvents combo_PSL As ComboBox
    Friend WithEvents Tbl_term_ShipMethodBindingSource As BindingSource
    Friend WithEvents Tbl_term_ShipMethodTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ShipMethodTableAdapter
    Friend WithEvents combo_ShipTerms As ComboBox
    Friend WithEvents Tbl_term_SizeBindingSource As BindingSource
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents combo_Size As ComboBox
    Friend WithEvents Tbl_term_StyleBindingSource As BindingSource
    Friend WithEvents Tbl_term_StyleTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter
    Friend WithEvents combo_Style As ComboBox
    Friend WithEvents Tbl_term_TempClassBindingSource As BindingSource
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
    Friend WithEvents combo_TempClass As ComboBox
    Friend WithEvents Tbl_term_TrimBindingSource As BindingSource
    Friend WithEvents Tbl_term_TrimTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter
    Friend WithEvents combo_Trim As ComboBox
    Friend WithEvents date_WOdate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents text_PartNum As TextBox
    Friend WithEvents text_Notes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text_POnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents text_DeliveryTicketNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents text_InvNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_QBBAnum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Tbl_term_ProductTypeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter
    Friend WithEvents combo_ProductType As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Fld_CustomerLabel As Label
    Friend WithEvents text_Qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents date_DueDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents date_InvDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents date_ShipDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents button_Submit As Button
    Friend WithEvents button_Clear As Button
End Class
