<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_ProductType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_ProductType))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_ProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_ProductTypeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_ProductTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_ProductTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_ProductTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbltermProductTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_ProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_ProductTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_ProductTypeBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_ProductTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_ProductTypeBindingSource
        '
        Me.Tbl_term_ProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.Tbl_term_ProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_ProductTypeTableAdapter
        '
        Me.Tbl_term_ProductTypeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_ProductTypeTableAdapter = Me.Tbl_term_ProductTypeTableAdapter
        Me.TableAdapterManager.tbl_term_PRTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_ProductTypeBindingNavigator
        '
        Me.Tbl_term_ProductTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_ProductTypeBindingNavigator.BindingSource = Me.TbltermProductTypeBindingSource
        Me.Tbl_term_ProductTypeBindingNavigator.CountItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_ProductTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_ProductTypeBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_ProductTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_ProductTypeBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.Name = "Tbl_term_ProductTypeBindingNavigator"
        Me.Tbl_term_ProductTypeBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_ProductTypeBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_ProductTypeBindingNavigator.TabIndex = 0
        Me.Tbl_term_ProductTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_term_ProductTypeBindingNavigatorSaveItem
        '
        Me.Tbl_term_ProductTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_ProductTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_ProductTypeBindingNavigatorSaveItem.Name = "Tbl_term_ProductTypeBindingNavigatorSaveItem"
        Me.Tbl_term_ProductTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_ProductTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_ProductTypeDataGridView
        '
        Me.Tbl_term_ProductTypeDataGridView.AllowUserToResizeColumns = False
        Me.Tbl_term_ProductTypeDataGridView.AllowUserToResizeRows = False
        Me.Tbl_term_ProductTypeDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_ProductTypeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_ProductTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_ProductTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_ProductTypeDataGridView.DataSource = Me.TbltermProductTypeBindingSource
        Me.Tbl_term_ProductTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_ProductTypeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_ProductTypeDataGridView.Name = "Tbl_term_ProductTypeDataGridView"
        Me.Tbl_term_ProductTypeDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_ProductTypeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_ProductType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TbltermProductTypeBindingSource
        '
        Me.TbltermProductTypeBindingSource.DataMember = "tbl_term_ProductType"
        Me.TbltermProductTypeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'options_ProductType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_ProductTypeDataGridView)
        Me.Controls.Add(Me.Tbl_term_ProductTypeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_ProductType"
        Me.Text = "Options - Product Type"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_ProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_ProductTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_ProductTypeBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_ProductTypeBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_ProductTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermProductTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_ProductTypeBindingSource As BindingSource
    Friend WithEvents Tbl_term_ProductTypeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_ProductTypeTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_ProductTypeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_ProductTypeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_ProductTypeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TbltermProductTypeBindingSource As BindingSource
End Class
