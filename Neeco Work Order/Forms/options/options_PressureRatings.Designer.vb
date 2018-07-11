<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_PressureRatings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_PressureRatings))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_PressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_PressureTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_PressureBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_PressureBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_PressureDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbltermPressureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PressureBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_PressureBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_PressureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_PressureBindingSource
        '
        Me.Tbl_term_PressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.Tbl_term_PressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_PressureTableAdapter
        '
        Me.Tbl_term_PressureTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_PressureTableAdapter = Me.Tbl_term_PressureTableAdapter
        Me.TableAdapterManager.tbl_term_ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PRTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_PressureBindingNavigator
        '
        Me.Tbl_term_PressureBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_PressureBindingNavigator.BindingSource = Me.TbltermPressureBindingSource
        Me.Tbl_term_PressureBindingNavigator.CountItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_PressureBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_PressureBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_PressureBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_PressureBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.Name = "Tbl_term_PressureBindingNavigator"
        Me.Tbl_term_PressureBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_PressureBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_PressureBindingNavigator.TabIndex = 0
        Me.Tbl_term_PressureBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_PressureBindingNavigatorSaveItem
        '
        Me.Tbl_term_PressureBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_PressureBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_PressureBindingNavigatorSaveItem.Name = "Tbl_term_PressureBindingNavigatorSaveItem"
        Me.Tbl_term_PressureBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_PressureBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_PressureDataGridView
        '
        Me.Tbl_term_PressureDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_PressureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_PressureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_PressureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_PressureDataGridView.DataSource = Me.TbltermPressureBindingSource
        Me.Tbl_term_PressureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_PressureDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_PressureDataGridView.Name = "Tbl_term_PressureDataGridView"
        Me.Tbl_term_PressureDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_PressureDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_Pressure"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pressure Rating"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TbltermPressureBindingSource
        '
        Me.TbltermPressureBindingSource.DataMember = "tbl_term_Pressure"
        Me.TbltermPressureBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'options_PressureRatings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_PressureDataGridView)
        Me.Controls.Add(Me.Tbl_term_PressureBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_PressureRatings"
        Me.Text = "Options - Pressure Rating"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PressureBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_PressureBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_PressureBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_PressureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltermPressureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_PressureBindingSource As BindingSource
    Friend WithEvents Tbl_term_PressureTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PressureTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_PressureBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_PressureBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_PressureDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TbltermPressureBindingSource As BindingSource
End Class
