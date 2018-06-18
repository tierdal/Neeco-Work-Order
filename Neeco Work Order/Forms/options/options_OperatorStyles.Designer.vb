<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_OperatorStyles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_OperatorStyles))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_HHPPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_HHPPTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_HHPPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_HHPPBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_HHPPDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_HHPPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_HHPPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_HHPPBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_HHPPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_HHPPBindingSource
        '
        Me.Tbl_term_HHPPBindingSource.DataMember = "tbl_term_HHPP"
        Me.Tbl_term_HHPPBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_HHPPTableAdapter
        '
        Me.Tbl_term_HHPPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_data_WOlogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_HHPPTableAdapter = Me.Tbl_term_HHPPTableAdapter
        Me.TableAdapterManager.tbl_term_PressureTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PRTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_ShipMethodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_HHPPBindingNavigator
        '
        Me.Tbl_term_HHPPBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_HHPPBindingNavigator.BindingSource = Me.Tbl_term_HHPPBindingSource
        Me.Tbl_term_HHPPBindingNavigator.CountItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_HHPPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_HHPPBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_HHPPBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_HHPPBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.Name = "Tbl_term_HHPPBindingNavigator"
        Me.Tbl_term_HHPPBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_HHPPBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_HHPPBindingNavigator.TabIndex = 0
        Me.Tbl_term_HHPPBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_HHPPBindingNavigatorSaveItem
        '
        Me.Tbl_term_HHPPBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_HHPPBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_HHPPBindingNavigatorSaveItem.Name = "Tbl_term_HHPPBindingNavigatorSaveItem"
        Me.Tbl_term_HHPPBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_HHPPBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_HHPPDataGridView
        '
        Me.Tbl_term_HHPPDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_HHPPDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_HHPPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_HHPPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_HHPPDataGridView.DataSource = Me.Tbl_term_HHPPBindingSource
        Me.Tbl_term_HHPPDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_HHPPDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_HHPPDataGridView.Name = "Tbl_term_HHPPDataGridView"
        Me.Tbl_term_HHPPDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_HHPPDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_HHPP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Operator Style"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_OperatorStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_HHPPDataGridView)
        Me.Controls.Add(Me.Tbl_term_HHPPBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_OperatorStyles"
        Me.Text = "Options - Operator Styles"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_HHPPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_HHPPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_HHPPBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_HHPPBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_HHPPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_HHPPBindingSource As BindingSource
    Friend WithEvents Tbl_term_HHPPTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_HHPPTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_HHPPBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_HHPPBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_HHPPDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
