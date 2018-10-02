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
        Me.Tbl_WOnumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_WOlogDataSet = New NeecoDMS.db_WOlogDataSet()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.Tbl_WOnumTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter()
        Me.TableAdapterManager = New NeecoDMS.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_HHPPTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter()
        Me.Tbl_term_PRTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter()
        Me.Tbl_term_PressureTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter()
        Me.Tbl_term_PSLTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter()
        Me.Tbl_term_SizeTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter()
        Me.Tbl_term_StyleTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter()
        Me.Tbl_term_TempClassTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter()
        Me.Tbl_term_TrimTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter()
        Me.Tbl_term_ProductTypeTableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter()
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
        Me.check_BO = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_PartNum = New System.Windows.Forms.TextBox()
        Me.combo_ProductType = New System.Windows.Forms.ComboBox()
        Me.TbltermProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.combo_Size = New System.Windows.Forms.ComboBox()
        Me.TbltermSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Pressure = New System.Windows.Forms.ComboBox()
        Me.TbltermPressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Style = New System.Windows.Forms.ComboBox()
        Me.TbltermStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Operator = New System.Windows.Forms.ComboBox()
        Me.TbltermHHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PR = New System.Windows.Forms.ComboBox()
        Me.TbltermPRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_PSL = New System.Windows.Forms.ComboBox()
        Me.TbltermPSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_Trim = New System.Windows.Forms.ComboBox()
        Me.TbltermTrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_TempClass = New System.Windows.Forms.ComboBox()
        Me.TbltermTempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.text_Notes = New System.Windows.Forms.TextBox()
        Me.TbltermCustomers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers10BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers9BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomers2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbltermCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_Customers1TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers1TableAdapter()
        Me.Tbl_term_Customers2TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers2TableAdapter()
        Me.Tbl_term_Customers3TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers3TableAdapter()
        Me.Tbl_term_Customers4TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers4TableAdapter()
        Me.Tbl_term_Customers5TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers5TableAdapter()
        Me.Tbl_term_Customers6TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers6TableAdapter()
        Me.Tbl_term_Customers7TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers7TableAdapter()
        Me.Tbl_term_Customers8TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers8TableAdapter()
        Me.Tbl_term_Customers9TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers9TableAdapter()
        Me.Tbl_term_Customers10TableAdapter = New NeecoDMS.db_WOlogDataSetTableAdapters.tbl_term_Customers10TableAdapter()
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
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
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
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fld_StyleLabel
        '
        Fld_StyleLabel.AutoSize = True
        Fld_StyleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_StyleLabel.Location = New System.Drawing.Point(3, 0)
        Fld_StyleLabel.Name = "Fld_StyleLabel"
        Fld_StyleLabel.Size = New System.Drawing.Size(73, 27)
        Fld_StyleLabel.TabIndex = 99
        Fld_StyleLabel.Text = "Style:"
        Fld_StyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PSLLabel
        '
        Fld_PSLLabel.AutoSize = True
        Fld_PSLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PSLLabel.Location = New System.Drawing.Point(177, 54)
        Fld_PSLLabel.Name = "Fld_PSLLabel"
        Fld_PSLLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PSLLabel.TabIndex = 99
        Fld_PSLLabel.Text = "PSL:"
        Fld_PSLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_HHPPLabel
        '
        Fld_HHPPLabel.AutoSize = True
        Fld_HHPPLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_HHPPLabel.Location = New System.Drawing.Point(351, 27)
        Fld_HHPPLabel.Name = "Fld_HHPPLabel"
        Fld_HHPPLabel.Size = New System.Drawing.Size(73, 27)
        Fld_HHPPLabel.TabIndex = 99
        Fld_HHPPLabel.Text = "Operator Type:"
        Fld_HHPPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_TempClassLabel
        '
        Fld_TempClassLabel.AutoSize = True
        Fld_TempClassLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TempClassLabel.Location = New System.Drawing.Point(177, 0)
        Fld_TempClassLabel.Name = "Fld_TempClassLabel"
        Fld_TempClassLabel.Size = New System.Drawing.Size(73, 27)
        Fld_TempClassLabel.TabIndex = 99
        Fld_TempClassLabel.Text = "Temp Class:"
        Fld_TempClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PRLabel
        '
        Fld_PRLabel.AutoSize = True
        Fld_PRLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PRLabel.Location = New System.Drawing.Point(351, 0)
        Fld_PRLabel.Name = "Fld_PRLabel"
        Fld_PRLabel.Size = New System.Drawing.Size(73, 27)
        Fld_PRLabel.TabIndex = 99
        Fld_PRLabel.Text = "PR:"
        Fld_PRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_PressureLabel
        '
        Fld_PressureLabel.AutoSize = True
        Fld_PressureLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_PressureLabel.Location = New System.Drawing.Point(3, 54)
        Fld_PressureLabel.Name = "Fld_PressureLabel"
        Fld_PressureLabel.Size = New System.Drawing.Size(73, 28)
        Fld_PressureLabel.TabIndex = 99
        Fld_PressureLabel.Text = "Pressure:"
        Fld_PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Fld_TrimLabel
        '
        Fld_TrimLabel.AutoSize = True
        Fld_TrimLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_TrimLabel.Location = New System.Drawing.Point(177, 27)
        Fld_TrimLabel.Name = "Fld_TrimLabel"
        Fld_TrimLabel.Size = New System.Drawing.Size(73, 27)
        Fld_TrimLabel.TabIndex = 99
        Fld_TrimLabel.Text = "Trim:"
        Fld_TrimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_SizeLabel
        '
        Fld_SizeLabel.AutoSize = True
        Fld_SizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_SizeLabel.Location = New System.Drawing.Point(3, 27)
        Fld_SizeLabel.Name = "Fld_SizeLabel"
        Fld_SizeLabel.Size = New System.Drawing.Size(73, 27)
        Fld_SizeLabel.TabIndex = 99
        Fld_SizeLabel.Text = "Size:"
        Fld_SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_WOnumLabel
        '
        Fld_WOnumLabel.AutoSize = True
        Fld_WOnumLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Fld_WOnumLabel.Location = New System.Drawing.Point(3, 0)
        Fld_WOnumLabel.Name = "Fld_WOnumLabel"
        Fld_WOnumLabel.Size = New System.Drawing.Size(95, 26)
        Fld_WOnumLabel.TabIndex = 99
        Fld_WOnumLabel.Text = "Work Order #:"
        Fld_WOnumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Label12.Location = New System.Drawing.Point(3, 67)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(95, 26)
        Label12.TabIndex = 99
        Label12.Text = "Status:"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Exit.Location = New System.Drawing.Point(670, 3)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(105, 33)
        Me.button_Exit.TabIndex = 68
        Me.button_Exit.Text = "CANCEL"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'Tbl_WOnumTableAdapter
        '
        Me.Tbl_WOnumTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UpdateOrder = NeecoDMS.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.button_Submit.Size = New System.Drawing.Size(108, 33)
        Me.button_Submit.TabIndex = 67
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Clear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_Clear.Location = New System.Drawing.Point(3, 3)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(114, 33)
        Me.button_Clear.TabIndex = 69
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
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.75862!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(784, 261)
        Me.TableLayoutPanel4.TabIndex = 99
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.44401!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72716!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67182!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15702!))
        Me.TableLayoutPanel5.Controls.Add(Me.button_Clear, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Exit, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.button_Submit, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(778, 39)
        Me.TableLayoutPanel5.TabIndex = 99
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 210)
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
        Me.TabPage1.Size = New System.Drawing.Size(770, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Work Order Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(764, 178)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(758, 172)
        Me.TableLayoutPanel2.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 166)
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
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(203, 147)
        Me.TableLayoutPanel9.TabIndex = 99
        '
        'date_WOdate
        '
        Me.date_WOdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.date_WOdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_WOdate.Location = New System.Drawing.Point(104, 44)
        Me.date_WOdate.Name = "date_WOdate"
        Me.date_WOdate.Size = New System.Drawing.Size(96, 20)
        Me.date_WOdate.TabIndex = 1
        Me.date_WOdate.Value = New Date(2018, 6, 14, 14, 14, 51, 0)
        '
        'text_Qty
        '
        Me.text_Qty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.text_Qty.Location = New System.Drawing.Point(104, 123)
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
        Me.combo_Status.Location = New System.Drawing.Point(104, 70)
        Me.combo_Status.Name = "combo_Status"
        Me.combo_Status.Size = New System.Drawing.Size(96, 21)
        Me.combo_Status.TabIndex = 2
        '
        'text_QBBAnum
        '
        Me.text_QBBAnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text_QBBAnum.Location = New System.Drawing.Point(104, 96)
        Me.text_QBBAnum.Name = "text_QBBAnum"
        Me.text_QBBAnum.Size = New System.Drawing.Size(96, 20)
        Me.text_QBBAnum.TabIndex = 3
        Me.text_QBBAnum.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 28)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Quantity:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 26)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "QB BA #:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 99
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
        Me.text_WOnum.TabIndex = 0
        Me.text_WOnum.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(218, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 166)
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
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(531, 147)
        Me.TableLayoutPanel8.TabIndex = 99
        '
        'check_BO
        '
        Me.check_BO.AutoSize = True
        Me.check_BO.Location = New System.Drawing.Point(3, 124)
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
        'TbltermProductTypeBindingSource
        '
        Me.TbltermProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.TbltermProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
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
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(525, 82)
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
        Me.combo_Size.Location = New System.Drawing.Point(82, 30)
        Me.combo_Size.Name = "combo_Size"
        Me.combo_Size.Size = New System.Drawing.Size(89, 21)
        Me.combo_Size.TabIndex = 8
        Me.combo_Size.ValueMember = "fld_Size"
        '
        'TbltermSizeBindingSource
        '
        Me.TbltermSizeBindingSource.DataMember = "tbl_term_Size"
        Me.TbltermSizeBindingSource.DataSource = Me.Db_WOlogDataSet
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
        Me.combo_Pressure.Location = New System.Drawing.Point(82, 57)
        Me.combo_Pressure.Name = "combo_Pressure"
        Me.combo_Pressure.Size = New System.Drawing.Size(89, 21)
        Me.combo_Pressure.TabIndex = 9
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
        Me.combo_Style.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Style.FormattingEnabled = True
        Me.combo_Style.Location = New System.Drawing.Point(82, 3)
        Me.combo_Style.Name = "combo_Style"
        Me.combo_Style.Size = New System.Drawing.Size(89, 21)
        Me.combo_Style.TabIndex = 7
        Me.combo_Style.ValueMember = "fld_Style"
        '
        'TbltermStyleBindingSource
        '
        Me.TbltermStyleBindingSource.DataMember = "tbl_term_Style"
        Me.TbltermStyleBindingSource.DataSource = Me.Db_WOlogDataSet
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
        Me.combo_Operator.Location = New System.Drawing.Point(430, 30)
        Me.combo_Operator.Name = "combo_Operator"
        Me.combo_Operator.Size = New System.Drawing.Size(92, 21)
        Me.combo_Operator.TabIndex = 14
        Me.combo_Operator.ValueMember = "fld_HHPP"
        '
        'TbltermHHPPBindingSource
        '
        Me.TbltermHHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.TbltermHHPPBindingSource.DataSource = Me.Db_WOlogDataSet
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
        Me.combo_PSL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.combo_PSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_PSL.FormattingEnabled = True
        Me.combo_PSL.Location = New System.Drawing.Point(256, 57)
        Me.combo_PSL.Name = "combo_PSL"
        Me.combo_PSL.Size = New System.Drawing.Size(89, 21)
        Me.combo_PSL.TabIndex = 12
        Me.combo_PSL.ValueMember = "fld_PSL"
        '
        'TbltermPSLBindingSource
        '
        Me.TbltermPSLBindingSource.DataMember = "tbl_term_PSL"
        Me.TbltermPSLBindingSource.DataSource = Me.Db_WOlogDataSet
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
        Me.combo_Trim.Location = New System.Drawing.Point(256, 30)
        Me.combo_Trim.Name = "combo_Trim"
        Me.combo_Trim.Size = New System.Drawing.Size(89, 21)
        Me.combo_Trim.TabIndex = 11
        Me.combo_Trim.ValueMember = "fld_Trim"
        '
        'TbltermTrimBindingSource
        '
        Me.TbltermTrimBindingSource.DataMember = "tbl_term_Trim"
        Me.TbltermTrimBindingSource.DataSource = Me.Db_WOlogDataSet
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
        'TbltermTempClassBindingSource
        '
        Me.TbltermTempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.TbltermTempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.text_Notes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 184)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notes"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.text_Notes.Size = New System.Drawing.Size(764, 178)
        Me.text_Notes.TabIndex = 66
        '
        'TbltermCustomers1BindingSource
        '
        Me.TbltermCustomers1BindingSource.DataMember = "tbl_term_Customers1"
        Me.TbltermCustomers1BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers10BindingSource
        '
        Me.TbltermCustomers10BindingSource.DataMember = "tbl_term_Customers10"
        Me.TbltermCustomers10BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers9BindingSource
        '
        Me.TbltermCustomers9BindingSource.DataMember = "tbl_term_Customers9"
        Me.TbltermCustomers9BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers8BindingSource
        '
        Me.TbltermCustomers8BindingSource.DataMember = "tbl_term_Customers8"
        Me.TbltermCustomers8BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers7BindingSource
        '
        Me.TbltermCustomers7BindingSource.DataMember = "tbl_term_Customers7"
        Me.TbltermCustomers7BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers6BindingSource
        '
        Me.TbltermCustomers6BindingSource.DataMember = "tbl_term_Customers6"
        Me.TbltermCustomers6BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers5BindingSource
        '
        Me.TbltermCustomers5BindingSource.DataMember = "tbl_term_Customers5"
        Me.TbltermCustomers5BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers4BindingSource
        '
        Me.TbltermCustomers4BindingSource.DataMember = "tbl_term_Customers4"
        Me.TbltermCustomers4BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers3BindingSource
        '
        Me.TbltermCustomers3BindingSource.DataMember = "tbl_term_Customers3"
        Me.TbltermCustomers3BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomers2BindingSource
        '
        Me.TbltermCustomers2BindingSource.DataMember = "tbl_term_Customers2"
        Me.TbltermCustomers2BindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'TbltermCustomersBindingSource
        '
        Me.TbltermCustomersBindingSource.DataMember = "tbl_term_Customers"
        '
        'Tbl_term_Customers1TableAdapter
        '
        Me.Tbl_term_Customers1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers2TableAdapter
        '
        Me.Tbl_term_Customers2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers3TableAdapter
        '
        Me.Tbl_term_Customers3TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers4TableAdapter
        '
        Me.Tbl_term_Customers4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers5TableAdapter
        '
        Me.Tbl_term_Customers5TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers6TableAdapter
        '
        Me.Tbl_term_Customers6TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers7TableAdapter
        '
        Me.Tbl_term_Customers7TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers8TableAdapter
        '
        Me.Tbl_term_Customers8TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers9TableAdapter
        '
        Me.Tbl_term_Customers9TableAdapter.ClearBeforeFill = True
        '
        'Tbl_term_Customers10TableAdapter
        '
        Me.Tbl_term_Customers10TableAdapter.ClearBeforeFill = True
        '
        'form_AddNewEntry
        '
        Me.AcceptButton = Me.button_Submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(784, 261)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_AddNewEntry"
        Me.Text = "NeecoDMS - Add New Work Order"
        CType(Me.Tbl_WOnumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.TbltermSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermHHPPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPSLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTrimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermTempClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
        CType(Me.TbltermCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_WOnumBindingSource As BindingSource
    Friend WithEvents Tbl_WOnumTableAdapter As db_WOlogDataSetTableAdapters.tbl_WOnumTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents button_Exit As Button
    Friend WithEvents Tbl_term_CustomersTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents Tbl_term_PRTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PRTableAdapter
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents Tbl_term_StyleTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_StyleTableAdapter
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents text_Notes As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents check_BO As CheckBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TbltermCustomersBindingSource As BindingSource
    Friend WithEvents TbltermCustomers1BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers1TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers1TableAdapter
    Friend WithEvents TbltermCustomers2BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers2TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers2TableAdapter
    Friend WithEvents TbltermCustomers3BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers3TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers3TableAdapter
    Friend WithEvents TbltermCustomers4BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers4TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers4TableAdapter
    Friend WithEvents TbltermCustomers5BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers5TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers5TableAdapter
    Friend WithEvents TbltermCustomers6BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers6TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers6TableAdapter
    Friend WithEvents TbltermCustomers7BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers7TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers7TableAdapter
    Friend WithEvents TbltermCustomers8BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers8TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers8TableAdapter
    Friend WithEvents TbltermCustomers9BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers9TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers9TableAdapter
    Friend WithEvents TbltermCustomers10BindingSource As BindingSource
    Friend WithEvents Tbl_term_Customers10TableAdapter As db_WOlogDataSetTableAdapters.tbl_term_Customers10TableAdapter
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
