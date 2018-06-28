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
        Dim Fld_StyleLabel As System.Windows.Forms.Label
        Dim Fld_PSLLabel As System.Windows.Forms.Label
        Dim Fld_HHPPLabel As System.Windows.Forms.Label
        Dim Fld_TempClassLabel As System.Windows.Forms.Label
        Dim Fld_PRLabel As System.Windows.Forms.Label
        Dim Fld_PressureLabel As System.Windows.Forms.Label
        Dim Fld_ProductTypeLabel As System.Windows.Forms.Label
        Dim Fld_TrimLabel As System.Windows.Forms.Label
        Dim Fld_SizeLabel As System.Windows.Forms.Label
        Dim Fld_WOnumLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AddNewEntry))
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
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.Tbl_term_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_HHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_PRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_PressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_PSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_ShipMethodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_TempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_TrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.button_Clear = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_WOnum = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_PartNum = New System.Windows.Forms.TextBox()
        Me.combo_ProductType = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.combo_Size = New System.Windows.Forms.ComboBox()
        Me.combo_Pressure = New System.Windows.Forms.ComboBox()
        Me.combo_Style = New System.Windows.Forms.ComboBox()
        Me.combo_Operator = New System.Windows.Forms.ComboBox()
        Me.combo_PR = New System.Windows.Forms.ComboBox()
        Me.combo_PSL = New System.Windows.Forms.ComboBox()
        Me.combo_Trim = New System.Windows.Forms.ComboBox()
        Me.combo_TempClass = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.date_ShipDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.text_DeliveryTicketNum = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_POnum = New System.Windows.Forms.TextBox()
        Me.Fld_CustomerLabel = New System.Windows.Forms.Label()
        Me.combo_Customer = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.text_Notes = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker8 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker9 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Fld_StyleLabel = New System.Windows.Forms.Label()
        Fld_PSLLabel = New System.Windows.Forms.Label()
        Fld_HHPPLabel = New System.Windows.Forms.Label()
        Fld_TempClassLabel = New System.Windows.Forms.Label()
        Fld_PRLabel = New System.Windows.Forms.Label()
        Fld_PressureLabel = New System.Windows.Forms.Label()
        Fld_ProductTypeLabel = New System.Windows.Forms.Label()
        Fld_TrimLabel = New System.Windows.Forms.Label()
        Fld_SizeLabel = New System.Windows.Forms.Label()
        Fld_WOnumLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fld_StyleLabel
        '
        Fld_StyleLabel.AutoSize = True
        Fld_StyleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_StyleLabel.Location = New System.Drawing.Point(3, 0)
        Fld_StyleLabel.Name = "Fld_StyleLabel"
        Fld_StyleLabel.Size = New System.Drawing.Size(73, 26)
        Fld_StyleLabel.TabIndex = 21
        Fld_StyleLabel.Text = "Style:"
        Fld_StyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PSLLabel
        '
        Fld_PSLLabel.AutoSize = True
        Fld_PSLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PSLLabel.Location = New System.Drawing.Point(177, 52)
        Fld_PSLLabel.Name = "Fld_PSLLabel"
        Fld_PSLLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PSLLabel.TabIndex = 18
        Fld_PSLLabel.Text = "PSL:"
        Fld_PSLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_HHPPLabel
        '
        Fld_HHPPLabel.AutoSize = True
        Fld_HHPPLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_HHPPLabel.Location = New System.Drawing.Point(351, 26)
        Fld_HHPPLabel.Name = "Fld_HHPPLabel"
        Fld_HHPPLabel.Size = New System.Drawing.Size(73, 26)
        Fld_HHPPLabel.TabIndex = 14
        Fld_HHPPLabel.Text = "Operator Type:"
        Fld_HHPPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_TempClassLabel
        '
        Fld_TempClassLabel.AutoSize = True
        Fld_TempClassLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TempClassLabel.Location = New System.Drawing.Point(177, 0)
        Fld_TempClassLabel.Name = "Fld_TempClassLabel"
        Fld_TempClassLabel.Size = New System.Drawing.Size(73, 26)
        Fld_TempClassLabel.TabIndex = 22
        Fld_TempClassLabel.Text = "Temp Class:"
        Fld_TempClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PRLabel
        '
        Fld_PRLabel.AutoSize = True
        Fld_PRLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PRLabel.Location = New System.Drawing.Point(351, 0)
        Fld_PRLabel.Name = "Fld_PRLabel"
        Fld_PRLabel.Size = New System.Drawing.Size(73, 26)
        Fld_PRLabel.TabIndex = 15
        Fld_PRLabel.Text = "PR:"
        Fld_PRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PressureLabel
        '
        Fld_PressureLabel.AutoSize = True
        Fld_PressureLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PressureLabel.Location = New System.Drawing.Point(3, 52)
        Fld_PressureLabel.Name = "Fld_PressureLabel"
        Fld_PressureLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PressureLabel.TabIndex = 16
        Fld_PressureLabel.Text = "Pressure:"
        Fld_PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_ProductTypeLabel
        '
        Fld_ProductTypeLabel.Location = New System.Drawing.Point(307, 0)
        Fld_ProductTypeLabel.Name = "Fld_ProductTypeLabel"
        Fld_ProductTypeLabel.Size = New System.Drawing.Size(99, 23)
        Fld_ProductTypeLabel.TabIndex = 29
        Fld_ProductTypeLabel.Text = "Product Type:"
        Fld_ProductTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_TrimLabel
        '
        Fld_TrimLabel.AutoSize = True
        Fld_TrimLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TrimLabel.Location = New System.Drawing.Point(177, 26)
        Fld_TrimLabel.Name = "Fld_TrimLabel"
        Fld_TrimLabel.Size = New System.Drawing.Size(73, 26)
        Fld_TrimLabel.TabIndex = 24
        Fld_TrimLabel.Text = "Trim:"
        Fld_TrimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_SizeLabel
        '
        Fld_SizeLabel.AutoSize = True
        Fld_SizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_SizeLabel.Location = New System.Drawing.Point(3, 26)
        Fld_SizeLabel.Name = "Fld_SizeLabel"
        Fld_SizeLabel.Size = New System.Drawing.Size(73, 26)
        Fld_SizeLabel.TabIndex = 20
        Fld_SizeLabel.Text = "Size:"
        Fld_SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_WOnumLabel
        '
        Fld_WOnumLabel.AutoSize = True
        Fld_WOnumLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_WOnumLabel.Location = New System.Drawing.Point(3, 0)
        Fld_WOnumLabel.Name = "Fld_WOnumLabel"
        Fld_WOnumLabel.Size = New System.Drawing.Size(95, 25)
        Fld_WOnumLabel.TabIndex = 1
        Fld_WOnumLabel.Text = "Work Order #:"
        Fld_WOnumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Label12.Location = New System.Drawing.Point(3, 65)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(95, 25)
        Label12.TabIndex = 101
        Label12.Text = "Status:"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Tbl_WOnumBindingNavigator.Size = New System.Drawing.Size(784, 25)
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
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Exit.Location = New System.Drawing.Point(670, 3)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(105, 28)
        Me.button_Exit.TabIndex = 24
        Me.button_Exit.Text = "CANCEL"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'Tbl_term_CustomersBindingSource
        '
        Me.Tbl_term_CustomersBindingSource.DataMember = "tbl_term_Customers"
        Me.Tbl_term_CustomersBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_HHPPBindingSource
        '
        Me.Tbl_term_HHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.Tbl_term_HHPPBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_PRBindingSource
        '
        Me.Tbl_term_PRBindingSource.DataMember = "tbl_term_PR"
        Me.Tbl_term_PRBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_PressureBindingSource
        '
        Me.Tbl_term_PressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.Tbl_term_PressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_PSLBindingSource
        '
        Me.Tbl_term_PSLBindingSource.DataMember = "tbl_term_PSL"
        Me.Tbl_term_PSLBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_ShipMethodBindingSource
        '
        Me.Tbl_term_ShipMethodBindingSource.DataMember = "tbl_term_ShipMethod"
        Me.Tbl_term_ShipMethodBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_SizeBindingSource
        '
        Me.Tbl_term_SizeBindingSource.DataMember = "tbl_term_Size"
        Me.Tbl_term_SizeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_StyleBindingSource
        '
        Me.Tbl_term_StyleBindingSource.DataMember = "tbl_term_Style"
        Me.Tbl_term_StyleBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_TempClassBindingSource
        '
        Me.Tbl_term_TempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.Tbl_term_TempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_TrimBindingSource
        '
        Me.Tbl_term_TrimBindingSource.DataMember = "tbl_term_Trim"
        Me.Tbl_term_TrimBindingSource.DataSource = Me.Db_WOlogDataSet
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
        'button_Submit
        '
        Me.button_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Submit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Submit.Location = New System.Drawing.Point(556, 3)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(108, 28)
        Me.button_Submit.TabIndex = 23
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Clear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Clear.Location = New System.Drawing.Point(3, 3)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(114, 28)
        Me.button_Clear.TabIndex = 25
        Me.button_Clear.Text = "CLEAR FORM"
        Me.button_Clear.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel4.TabIndex = 47
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42416!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.65553!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65296!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.13882!))
        Me.TableLayoutPanel5.Controls.Add(Me.button_Clear, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Exit, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Submit, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 524)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(778, 34)
        Me.TableLayoutPanel5.TabIndex = 47
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
        Me.TabControl1.TabIndex = 46
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
        Me.TableLayoutPanel3.TabIndex = 45
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
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 163)
        Me.GroupBox1.TabIndex = 41
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
        Me.TableLayoutPanel9.TabIndex = 102
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
        Me.text_Qty.TabIndex = 6
        '
        'combo_Status
        '
        Me.combo_Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.combo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Status.FormattingEnabled = True
        Me.combo_Status.Items.AddRange(New Object() {"OPEN", "PARTIAL", "STOCK", "CLOSED"})
        Me.combo_Status.Location = New System.Drawing.Point(104, 68)
        Me.combo_Status.Name = "combo_Status"
        Me.combo_Status.Size = New System.Drawing.Size(96, 21)
        Me.combo_Status.TabIndex = 100
        '
        'text_QBBAnum
        '
        Me.text_QBBAnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text_QBBAnum.Location = New System.Drawing.Point(104, 93)
        Me.text_QBBAnum.Name = "text_QBBAnum"
        Me.text_QBBAnum.Size = New System.Drawing.Size(96, 20)
        Me.text_QBBAnum.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 29)
        Me.Label8.TabIndex = 40
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
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "QB BA #:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_WOnum
        '
        Me.text_WOnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text_WOnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_WOnumBindingSource, "fld_WOnum", True))
        Me.text_WOnum.Location = New System.Drawing.Point(104, 3)
        Me.text_WOnum.Name = "text_WOnum"
        Me.text_WOnum.ReadOnly = True
        Me.text_WOnum.Size = New System.Drawing.Size(96, 20)
        Me.text_WOnum.TabIndex = 99
        Me.text_WOnum.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(218, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 163)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.CheckBox1, 0, 2)
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
        Me.TableLayoutPanel8.TabIndex = 42
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 122)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(421, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Check this box if you are buying out the material as a finished product from a Ve" &
    "ndor"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel7.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 27)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Part Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'text_PartNum
        '
        Me.text_PartNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_PartNum.Location = New System.Drawing.Point(97, 3)
        Me.text_PartNum.Name = "text_PartNum"
        Me.text_PartNum.Size = New System.Drawing.Size(204, 20)
        Me.text_PartNum.TabIndex = 8
        '
        'combo_ProductType
        '
        Me.combo_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_ProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_ProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_ProductTypeBindingSource, "fld_ProductType", True))
        Me.combo_ProductType.DataSource = Me.Tbl_term_ProductTypeBindingSource
        Me.combo_ProductType.DisplayMember = "fld_ProductType"
        Me.combo_ProductType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_ProductType.FormattingEnabled = True
        Me.combo_ProductType.Location = New System.Drawing.Point(412, 3)
        Me.combo_ProductType.Name = "combo_ProductType"
        Me.combo_ProductType.Size = New System.Drawing.Size(110, 21)
        Me.combo_ProductType.TabIndex = 9
        Me.combo_ProductType.ValueMember = "fld_ProductType"
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
        Me.TableLayoutPanel6.TabIndex = 40
        '
        'combo_Size
        '
        Me.combo_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_SizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_SizeBindingSource, "fld_Size", True))
        Me.combo_Size.DataSource = Me.Tbl_term_SizeBindingSource
        Me.combo_Size.DisplayMember = "fld_Size"
        Me.combo_Size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Size.FormattingEnabled = True
        Me.combo_Size.Location = New System.Drawing.Point(82, 29)
        Me.combo_Size.Name = "combo_Size"
        Me.combo_Size.Size = New System.Drawing.Size(89, 21)
        Me.combo_Size.TabIndex = 10
        Me.combo_Size.ValueMember = "fld_Size"
        '
        'combo_Pressure
        '
        Me.combo_Pressure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Pressure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PressureBindingSource, "fld_Pressure", True))
        Me.combo_Pressure.DataSource = Me.Tbl_term_PressureBindingSource
        Me.combo_Pressure.DisplayMember = "fld_Pressure"
        Me.combo_Pressure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Pressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Pressure.FormattingEnabled = True
        Me.combo_Pressure.Location = New System.Drawing.Point(82, 55)
        Me.combo_Pressure.Name = "combo_Pressure"
        Me.combo_Pressure.Size = New System.Drawing.Size(89, 21)
        Me.combo_Pressure.TabIndex = 11
        Me.combo_Pressure.ValueMember = "fld_Pressure"
        '
        'combo_Style
        '
        Me.combo_Style.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_StyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_StyleBindingSource, "fld_Style", True))
        Me.combo_Style.DataSource = Me.Tbl_term_StyleBindingSource
        Me.combo_Style.DisplayMember = "fld_Style"
        Me.combo_Style.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Style.FormattingEnabled = True
        Me.combo_Style.Location = New System.Drawing.Point(82, 3)
        Me.combo_Style.Name = "combo_Style"
        Me.combo_Style.Size = New System.Drawing.Size(89, 21)
        Me.combo_Style.TabIndex = 15
        Me.combo_Style.ValueMember = "fld_Style"
        '
        'combo_Operator
        '
        Me.combo_Operator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Operator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_HHPPBindingSource, "fld_HHPP", True))
        Me.combo_Operator.DataSource = Me.Tbl_term_HHPPBindingSource
        Me.combo_Operator.DisplayMember = "fld_HHPP"
        Me.combo_Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Operator.FormattingEnabled = True
        Me.combo_Operator.Location = New System.Drawing.Point(430, 29)
        Me.combo_Operator.Name = "combo_Operator"
        Me.combo_Operator.Size = New System.Drawing.Size(92, 21)
        Me.combo_Operator.TabIndex = 12
        Me.combo_Operator.ValueMember = "fld_HHPP"
        '
        'combo_PR
        '
        Me.combo_PR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PRBindingSource, "fld_PR", True))
        Me.combo_PR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PRBindingSource, "fld_PR", True))
        Me.combo_PR.DataSource = Me.Tbl_term_PRBindingSource
        Me.combo_PR.DisplayMember = "fld_PR"
        Me.combo_PR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_PR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PR.FormattingEnabled = True
        Me.combo_PR.Location = New System.Drawing.Point(430, 3)
        Me.combo_PR.Name = "combo_PR"
        Me.combo_PR.Size = New System.Drawing.Size(92, 21)
        Me.combo_PR.TabIndex = 17
        Me.combo_PR.ValueMember = "fld_PR"
        '
        'combo_PSL
        '
        Me.combo_PSL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_PSL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_PSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_PSLBindingSource, "fld_PSL", True))
        Me.combo_PSL.DataSource = Me.Tbl_term_PSLBindingSource
        Me.combo_PSL.DisplayMember = "fld_PSL"
        Me.combo_PSL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_PSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PSL.FormattingEnabled = True
        Me.combo_PSL.Location = New System.Drawing.Point(256, 55)
        Me.combo_PSL.Name = "combo_PSL"
        Me.combo_PSL.Size = New System.Drawing.Size(89, 21)
        Me.combo_PSL.TabIndex = 16
        Me.combo_PSL.ValueMember = "fld_PSL"
        '
        'combo_Trim
        '
        Me.combo_Trim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Trim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_TrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_TrimBindingSource, "fld_Trim", True))
        Me.combo_Trim.DataSource = Me.Tbl_term_TrimBindingSource
        Me.combo_Trim.DisplayMember = "fld_Trim"
        Me.combo_Trim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Trim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Trim.FormattingEnabled = True
        Me.combo_Trim.Location = New System.Drawing.Point(256, 29)
        Me.combo_Trim.Name = "combo_Trim"
        Me.combo_Trim.Size = New System.Drawing.Size(89, 21)
        Me.combo_Trim.TabIndex = 14
        Me.combo_Trim.ValueMember = "fld_Trim"
        '
        'combo_TempClass
        '
        Me.combo_TempClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_TempClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_TempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_TempClassBindingSource, "fld_TempClass", True))
        Me.combo_TempClass.DataSource = Me.Tbl_term_TempClassBindingSource
        Me.combo_TempClass.DisplayMember = "fld_TempClass"
        Me.combo_TempClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_TempClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_TempClass.FormattingEnabled = True
        Me.combo_TempClass.Location = New System.Drawing.Point(256, 3)
        Me.combo_TempClass.Name = "combo_TempClass"
        Me.combo_TempClass.Size = New System.Drawing.Size(89, 21)
        Me.combo_TempClass.TabIndex = 13
        Me.combo_TempClass.ValueMember = "fld_TempClass"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(758, 302)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shipping Info"
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
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox20, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox21, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox22, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox23, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox24, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox25, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox26, 5, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox27, 5, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox28, 5, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker3, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker4, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker5, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker6, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker7, 4, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker8, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker9, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox12, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox14, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox15, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox16, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox17, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox18, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox19, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox9, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox8, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox7, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox6, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox5, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox4, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.date_ShipDate, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.text_DeliveryTicketNum, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.text_POnum, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Fld_CustomerLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.combo_Customer, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox13, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 4, 3)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(752, 283)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(409, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 28)
        Me.Label17.TabIndex = 50
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
        Me.Label15.TabIndex = 48
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
        Me.Label16.TabIndex = 45
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
        Me.Label6.TabIndex = 44
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
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date_ShipDate
        '
        Me.date_ShipDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.date_ShipDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ShipDate.Location = New System.Drawing.Point(469, 31)
        Me.date_ShipDate.Name = "date_ShipDate"
        Me.date_ShipDate.Size = New System.Drawing.Size(91, 20)
        Me.date_ShipDate.TabIndex = 20
        Me.date_ShipDate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(3, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 25)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_DeliveryTicketNum
        '
        Me.text_DeliveryTicketNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_DeliveryTicketNum.Location = New System.Drawing.Point(566, 31)
        Me.text_DeliveryTicketNum.Name = "text_DeliveryTicketNum"
        Me.text_DeliveryTicketNum.Size = New System.Drawing.Size(183, 20)
        Me.text_DeliveryTicketNum.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(3, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 47
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
        Me.Label5.TabIndex = 34
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
        Me.Label9.TabIndex = 39
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
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "PO Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_POnum
        '
        Me.text_POnum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_POnum.Location = New System.Drawing.Point(33, 31)
        Me.text_POnum.Name = "text_POnum"
        Me.text_POnum.Size = New System.Drawing.Size(182, 20)
        Me.text_POnum.TabIndex = 2
        '
        'Fld_CustomerLabel
        '
        Me.Fld_CustomerLabel.AutoSize = True
        Me.Fld_CustomerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fld_CustomerLabel.Location = New System.Drawing.Point(221, 0)
        Me.Fld_CustomerLabel.Name = "Fld_CustomerLabel"
        Me.Fld_CustomerLabel.Size = New System.Drawing.Size(182, 28)
        Me.Fld_CustomerLabel.TabIndex = 13
        Me.Fld_CustomerLabel.Text = "Customer"
        Me.Fld_CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'combo_Customer
        '
        Me.combo_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_Customer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.combo_Customer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.combo_Customer.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.combo_Customer.DisplayMember = "fld_Customer"
        Me.combo_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Customer.FormattingEnabled = True
        Me.combo_Customer.Location = New System.Drawing.Point(221, 31)
        Me.combo_Customer.Name = "combo_Customer"
        Me.combo_Customer.Size = New System.Drawing.Size(182, 21)
        Me.combo_Customer.TabIndex = 4
        Me.combo_Customer.ValueMember = "fld_Customer"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(409, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(54, 20)
        Me.TextBox1.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 51
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
        Me.Label11.TabIndex = 52
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
        Me.Label18.TabIndex = 53
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
        Me.Label19.TabIndex = 54
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
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "10"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'text_Notes
        '
        Me.text_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_Notes.Location = New System.Drawing.Point(3, 3)
        Me.text_Notes.Multiline = True
        Me.text_Notes.Name = "text_Notes"
        Me.text_Notes.Size = New System.Drawing.Size(764, 483)
        Me.text_Notes.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(33, 256)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.TextBox2.TabIndex = 56
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(33, 231)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(182, 20)
        Me.TextBox3.TabIndex = 57
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Location = New System.Drawing.Point(33, 206)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(182, 20)
        Me.TextBox4.TabIndex = 57
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Location = New System.Drawing.Point(33, 56)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(182, 20)
        Me.TextBox5.TabIndex = 57
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Location = New System.Drawing.Point(33, 81)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(182, 20)
        Me.TextBox6.TabIndex = 57
        '
        'TextBox7
        '
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox7.Location = New System.Drawing.Point(33, 106)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(182, 20)
        Me.TextBox7.TabIndex = 57
        '
        'TextBox8
        '
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox8.Location = New System.Drawing.Point(33, 131)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(182, 20)
        Me.TextBox8.TabIndex = 57
        '
        'TextBox9
        '
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox9.Location = New System.Drawing.Point(33, 156)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(182, 20)
        Me.TextBox9.TabIndex = 57
        '
        'TextBox10
        '
        Me.TextBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox10.Location = New System.Drawing.Point(33, 181)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(182, 20)
        Me.TextBox10.TabIndex = 57
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox1.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox1.DisplayMember = "fld_Customer"
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(221, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 48
        Me.ComboBox1.ValueMember = "fld_Customer"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox2.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox2.DisplayMember = "fld_Customer"
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 81)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox2.TabIndex = 49
        Me.ComboBox2.ValueMember = "fld_Customer"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox3.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox3.DisplayMember = "fld_Customer"
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(221, 106)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox3.TabIndex = 49
        Me.ComboBox3.ValueMember = "fld_Customer"
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox4.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox4.DisplayMember = "fld_Customer"
        Me.ComboBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(221, 131)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox4.TabIndex = 49
        Me.ComboBox4.ValueMember = "fld_Customer"
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox5.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox5.DisplayMember = "fld_Customer"
        Me.ComboBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(221, 156)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox5.TabIndex = 49
        Me.ComboBox5.ValueMember = "fld_Customer"
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox6.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox6.DisplayMember = "fld_Customer"
        Me.ComboBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(221, 181)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox6.TabIndex = 49
        Me.ComboBox6.ValueMember = "fld_Customer"
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox7.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox7.DisplayMember = "fld_Customer"
        Me.ComboBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(221, 206)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox7.TabIndex = 49
        Me.ComboBox7.ValueMember = "fld_Customer"
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox8.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox8.DisplayMember = "fld_Customer"
        Me.ComboBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(221, 231)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox8.TabIndex = 49
        Me.ComboBox8.ValueMember = "fld_Customer"
        '
        'ComboBox9
        '
        Me.ComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_term_CustomersBindingSource, "fld_Customer", True))
        Me.ComboBox9.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.ComboBox9.DisplayMember = "fld_Customer"
        Me.ComboBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(221, 256)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox9.TabIndex = 49
        Me.ComboBox9.ValueMember = "fld_Customer"
        '
        'TextBox11
        '
        Me.TextBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox11.Location = New System.Drawing.Point(409, 56)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(54, 20)
        Me.TextBox11.TabIndex = 50
        '
        'TextBox12
        '
        Me.TextBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox12.Location = New System.Drawing.Point(409, 106)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(54, 20)
        Me.TextBox12.TabIndex = 51
        '
        'TextBox13
        '
        Me.TextBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox13.Location = New System.Drawing.Point(409, 131)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(54, 20)
        Me.TextBox13.TabIndex = 52
        '
        'TextBox14
        '
        Me.TextBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox14.Location = New System.Drawing.Point(409, 156)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(54, 20)
        Me.TextBox14.TabIndex = 53
        '
        'TextBox15
        '
        Me.TextBox15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox15.Location = New System.Drawing.Point(409, 181)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(54, 20)
        Me.TextBox15.TabIndex = 54
        '
        'TextBox16
        '
        Me.TextBox16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox16.Location = New System.Drawing.Point(409, 206)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(54, 20)
        Me.TextBox16.TabIndex = 55
        '
        'TextBox17
        '
        Me.TextBox17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox17.Location = New System.Drawing.Point(409, 81)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(54, 20)
        Me.TextBox17.TabIndex = 56
        '
        'TextBox18
        '
        Me.TextBox18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox18.Location = New System.Drawing.Point(409, 231)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(54, 20)
        Me.TextBox18.TabIndex = 57
        '
        'TextBox19
        '
        Me.TextBox19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox19.Location = New System.Drawing.Point(409, 256)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(54, 20)
        Me.TextBox19.TabIndex = 58
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(469, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 48
        Me.DateTimePicker1.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(469, 81)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker2.TabIndex = 49
        Me.DateTimePicker2.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(469, 106)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker3.TabIndex = 50
        Me.DateTimePicker3.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(469, 131)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker4.TabIndex = 51
        Me.DateTimePicker4.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(469, 156)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker5.TabIndex = 52
        Me.DateTimePicker5.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker6.Location = New System.Drawing.Point(469, 181)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker6.TabIndex = 53
        Me.DateTimePicker6.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker7
        '
        Me.DateTimePicker7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker7.Location = New System.Drawing.Point(469, 206)
        Me.DateTimePicker7.Name = "DateTimePicker7"
        Me.DateTimePicker7.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker7.TabIndex = 54
        Me.DateTimePicker7.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker8
        '
        Me.DateTimePicker8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker8.Location = New System.Drawing.Point(469, 231)
        Me.DateTimePicker8.Name = "DateTimePicker8"
        Me.DateTimePicker8.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker8.TabIndex = 55
        Me.DateTimePicker8.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'DateTimePicker9
        '
        Me.DateTimePicker9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker9.Location = New System.Drawing.Point(469, 256)
        Me.DateTimePicker9.Name = "DateTimePicker9"
        Me.DateTimePicker9.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker9.TabIndex = 56
        Me.DateTimePicker9.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'TextBox20
        '
        Me.TextBox20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox20.Location = New System.Drawing.Point(566, 56)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(183, 20)
        Me.TextBox20.TabIndex = 48
        '
        'TextBox21
        '
        Me.TextBox21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox21.Location = New System.Drawing.Point(566, 81)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(183, 20)
        Me.TextBox21.TabIndex = 49
        '
        'TextBox22
        '
        Me.TextBox22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox22.Location = New System.Drawing.Point(566, 106)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(183, 20)
        Me.TextBox22.TabIndex = 50
        '
        'TextBox23
        '
        Me.TextBox23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox23.Location = New System.Drawing.Point(566, 131)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(183, 20)
        Me.TextBox23.TabIndex = 51
        '
        'TextBox24
        '
        Me.TextBox24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox24.Location = New System.Drawing.Point(566, 156)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(183, 20)
        Me.TextBox24.TabIndex = 52
        '
        'TextBox25
        '
        Me.TextBox25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox25.Location = New System.Drawing.Point(566, 181)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(183, 20)
        Me.TextBox25.TabIndex = 53
        '
        'TextBox26
        '
        Me.TextBox26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox26.Location = New System.Drawing.Point(566, 206)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(183, 20)
        Me.TextBox26.TabIndex = 54
        '
        'TextBox27
        '
        Me.TextBox27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox27.Location = New System.Drawing.Point(566, 231)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(183, 20)
        Me.TextBox27.TabIndex = 55
        '
        'TextBox28
        '
        Me.TextBox28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox28.Location = New System.Drawing.Point(566, 256)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(183, 20)
        Me.TextBox28.TabIndex = 56
        '
        'form_AddNewEntry
        '
        Me.AcceptButton = Me.button_Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TableLayoutPanel4)
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
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents button_Exit As Button
    Friend WithEvents Tbl_term_CustomersBindingSource As BindingSource
    Friend WithEvents Tbl_term_CustomersTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter
    Friend WithEvents Tbl_term_HHPPBindingSource As BindingSource
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents Tbl_term_PRBindingSource As BindingSource
    Friend WithEvents Tbl_term_PRTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter
    Friend WithEvents Tbl_term_PressureBindingSource As BindingSource
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents Tbl_term_ProductTypeBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
    Friend WithEvents Tbl_term_ShipMethodBindingSource As BindingSource
    Friend WithEvents Tbl_term_ShipMethodTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ShipMethodTableAdapter
    Friend WithEvents Tbl_term_SizeBindingSource As BindingSource
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents Tbl_term_StyleBindingSource As BindingSource
    Friend WithEvents Tbl_term_StyleTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter
    Friend WithEvents Tbl_term_TempClassBindingSource As BindingSource
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
    Friend WithEvents Tbl_term_TrimBindingSource As BindingSource
    Friend WithEvents Tbl_term_TrimTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter
    Friend WithEvents Tbl_term_ProductTypeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter
    Friend WithEvents button_Submit As Button
    Friend WithEvents button_Clear As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combo_Status As ComboBox
    Friend WithEvents text_Qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents text_WOnum As TextBox
    Friend WithEvents date_WOdate As DateTimePicker
    Friend WithEvents text_QBBAnum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents date_ShipDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents text_DeliveryTicketNum As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_POnum As TextBox
    Friend WithEvents Fld_CustomerLabel As Label
    Friend WithEvents combo_Customer As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents text_Notes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents DateTimePicker7 As DateTimePicker
    Friend WithEvents DateTimePicker8 As DateTimePicker
    Friend WithEvents DateTimePicker9 As DateTimePicker
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
