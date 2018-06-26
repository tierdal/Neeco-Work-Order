<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_PSL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_PSL))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_PSLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_PSLTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_PSLBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_PSLBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_PSLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PSLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_PSLBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_PSLBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_PSLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_PSLBindingSource
        '
        Me.Tbl_term_PSLBindingSource.DataMember = "tbl_term_PSL"
        Me.Tbl_term_PSLBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_PSLTableAdapter
        '
        Me.Tbl_term_PSLTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_PSLTableAdapter = Me.Tbl_term_PSLTableAdapter
        Me.TableAdapterManager.tbl_term_ShipMethodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_PSLBindingNavigator
        '
        Me.Tbl_term_PSLBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_PSLBindingNavigator.BindingSource = Me.Tbl_term_PSLBindingSource
        Me.Tbl_term_PSLBindingNavigator.CountItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_PSLBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_PSLBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_PSLBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_PSLBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.Name = "Tbl_term_PSLBindingNavigator"
        Me.Tbl_term_PSLBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_PSLBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_PSLBindingNavigator.TabIndex = 0
        Me.Tbl_term_PSLBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_PSLBindingNavigatorSaveItem
        '
        Me.Tbl_term_PSLBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_PSLBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_PSLBindingNavigatorSaveItem.Name = "Tbl_term_PSLBindingNavigatorSaveItem"
        Me.Tbl_term_PSLBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_PSLBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_PSLDataGridView
        '
        Me.Tbl_term_PSLDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_PSLDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_PSLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_PSLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_PSLDataGridView.DataSource = Me.Tbl_term_PSLBindingSource
        Me.Tbl_term_PSLDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_PSLDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_PSLDataGridView.Name = "Tbl_term_PSLDataGridView"
        Me.Tbl_term_PSLDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_PSLDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_PSL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PSL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_PSL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_PSLDataGridView)
        Me.Controls.Add(Me.Tbl_term_PSLBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_PSL"
        Me.Text = "Options - PSL"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PSLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_PSLBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_PSLBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_PSLBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_PSLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_PSLBindingSource As BindingSource
    Friend WithEvents Tbl_term_PSLTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_PSLTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_PSLBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_PSLBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_PSLDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
