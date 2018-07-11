<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_Sizes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_Sizes))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_SizeTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_SizeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_SizeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_SizeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_SizeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_SizeBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_SizeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_SizeBindingSource
        '
        Me.Tbl_term_SizeBindingSource.DataMember = "tbl_term_Size"
        Me.Tbl_term_SizeBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_SizeTableAdapter
        '
        Me.Tbl_term_SizeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Me.Tbl_term_SizeTableAdapter
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_SizeBindingNavigator
        '
        Me.Tbl_term_SizeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_SizeBindingNavigator.BindingSource = Me.Tbl_term_SizeBindingSource
        Me.Tbl_term_SizeBindingNavigator.CountItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_SizeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_SizeBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_SizeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_SizeBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.Name = "Tbl_term_SizeBindingNavigator"
        Me.Tbl_term_SizeBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_SizeBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_SizeBindingNavigator.TabIndex = 0
        Me.Tbl_term_SizeBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_SizeBindingNavigatorSaveItem
        '
        Me.Tbl_term_SizeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_SizeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_SizeBindingNavigatorSaveItem.Name = "Tbl_term_SizeBindingNavigatorSaveItem"
        Me.Tbl_term_SizeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_SizeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_SizeDataGridView
        '
        Me.Tbl_term_SizeDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_SizeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_SizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_SizeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_SizeDataGridView.DataSource = Me.Tbl_term_SizeBindingSource
        Me.Tbl_term_SizeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_SizeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_SizeDataGridView.Name = "Tbl_term_SizeDataGridView"
        Me.Tbl_term_SizeDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_SizeDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_Size"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_Sizes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_SizeDataGridView)
        Me.Controls.Add(Me.Tbl_term_SizeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_Sizes"
        Me.Text = "Options - Sizes"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_SizeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_SizeBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_SizeBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_SizeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_SizeBindingSource As BindingSource
    Friend WithEvents Tbl_term_SizeTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_SizeTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_SizeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_SizeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_SizeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
