<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_TempClasses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_TempClasses))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_TempClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_TempClassTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_TempClassBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_TempClassBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_TempClassDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TempClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TempClassBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_TempClassBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_TempClassDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_TempClassBindingSource
        '
        Me.Tbl_term_TempClassBindingSource.DataMember = "tbl_term_TempClass"
        Me.Tbl_term_TempClassBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_TempClassTableAdapter
        '
        Me.Tbl_term_TempClassTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_SizeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_StyleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_term_TempClassTableAdapter = Me.Tbl_term_TempClassTableAdapter
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Nothing
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_TempClassBindingNavigator
        '
        Me.Tbl_term_TempClassBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_TempClassBindingNavigator.BindingSource = Me.Tbl_term_TempClassBindingSource
        Me.Tbl_term_TempClassBindingNavigator.CountItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_TempClassBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_TempClassBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_TempClassBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_TempClassBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.Name = "Tbl_term_TempClassBindingNavigator"
        Me.Tbl_term_TempClassBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_TempClassBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_TempClassBindingNavigator.TabIndex = 0
        Me.Tbl_term_TempClassBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_TempClassBindingNavigatorSaveItem
        '
        Me.Tbl_term_TempClassBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_TempClassBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_TempClassBindingNavigatorSaveItem.Name = "Tbl_term_TempClassBindingNavigatorSaveItem"
        Me.Tbl_term_TempClassBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_TempClassBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_TempClassDataGridView
        '
        Me.Tbl_term_TempClassDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_TempClassDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_TempClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_TempClassDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_TempClassDataGridView.DataSource = Me.Tbl_term_TempClassBindingSource
        Me.Tbl_term_TempClassDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_term_TempClassDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Tbl_term_TempClassDataGridView.Name = "Tbl_term_TempClassDataGridView"
        Me.Tbl_term_TempClassDataGridView.Size = New System.Drawing.Size(284, 386)
        Me.Tbl_term_TempClassDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_TempClass"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Temp Class"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_TempClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_TempClassDataGridView)
        Me.Controls.Add(Me.Tbl_term_TempClassBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_TempClasses"
        Me.Text = "Options - Temp Classes"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TempClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TempClassBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_TempClassBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_TempClassBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_TempClassDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_TempClassBindingSource As BindingSource
    Friend WithEvents Tbl_term_TempClassTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TempClassTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_TempClassBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_TempClassBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_TempClassDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
