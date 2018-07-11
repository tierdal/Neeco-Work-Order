<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_Customer))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_CustomersTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_CustomersBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_CustomersBindingSource
        '
        Me.Tbl_term_CustomersBindingSource.DataMember = "tbl_term_Customers"
        Me.Tbl_term_CustomersBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_CustomersTableAdapter
        '
        Me.Tbl_term_CustomersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_CustomersTableAdapter = Me.Tbl_term_CustomersTableAdapter
        Me.TableAdapterManager.tbl_term_HHPPTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PressureTableAdapter = Nothing
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
        'Tbl_term_CustomersBindingNavigator
        '
        Me.Tbl_term_CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_CustomersBindingNavigator.BindingSource = Me.Tbl_term_CustomersBindingSource
        Me.Tbl_term_CustomersBindingNavigator.CountItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_CustomersBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_CustomersBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.Name = "Tbl_term_CustomersBindingNavigator"
        Me.Tbl_term_CustomersBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_CustomersBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.Tbl_term_CustomersBindingNavigator.TabIndex = 0
        Me.Tbl_term_CustomersBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_CustomersBindingNavigatorSaveItem
        '
        Me.Tbl_term_CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_CustomersBindingNavigatorSaveItem.Name = "Tbl_term_CustomersBindingNavigatorSaveItem"
        Me.Tbl_term_CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_CustomersDataGridView
        '
        Me.Tbl_term_CustomersDataGridView.AllowUserToResizeColumns = False
        Me.Tbl_term_CustomersDataGridView.AllowUserToResizeRows = False
        Me.Tbl_term_CustomersDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_CustomersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_CustomersDataGridView.DataSource = Me.Tbl_term_CustomersBindingSource
        Me.Tbl_term_CustomersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_CustomersDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_CustomersDataGridView.Name = "Tbl_term_CustomersDataGridView"
        Me.Tbl_term_CustomersDataGridView.Size = New System.Drawing.Size(484, 386)
        Me.Tbl_term_CustomersDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_Customer"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.Tbl_term_CustomersDataGridView)
        Me.Controls.Add(Me.Tbl_term_CustomersBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_Customer"
        Me.Text = "Options - Customers"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_CustomersBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_CustomersBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_CustomersBindingSource As BindingSource
    Friend WithEvents Tbl_term_CustomersTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_CustomersTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_CustomersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
