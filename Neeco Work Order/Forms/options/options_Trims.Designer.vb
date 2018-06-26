<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options_Trims
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options_Trims))
        Me.Db_WOlogDataSet = New Neeco_Work_Order.db_WOlogDataSet()
        Me.Tbl_term_TrimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_term_TrimTableAdapter = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter()
        Me.TableAdapterManager = New Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_term_TrimBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_TrimBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_term_TrimDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TrimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_term_TrimBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_term_TrimBindingNavigator.SuspendLayout()
        CType(Me.Tbl_term_TrimDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_WOlogDataSet
        '
        Me.Db_WOlogDataSet.DataSetName = "db_WOlogDataSet"
        Me.Db_WOlogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_term_TrimBindingSource
        '
        Me.Tbl_term_TrimBindingSource.DataMember = "tbl_term_Trim"
        Me.Tbl_term_TrimBindingSource.DataSource = Me.Db_WOlogDataSet
        '
        'Tbl_term_TrimTableAdapter
        '
        Me.Tbl_term_TrimTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_term_TrimTableAdapter = Me.Tbl_term_TrimTableAdapter
        Me.TableAdapterManager.tbl_WOnumTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neeco_Work_Order.db_WOlogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_term_TrimBindingNavigator
        '
        Me.Tbl_term_TrimBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_term_TrimBindingNavigator.BindingSource = Me.Tbl_term_TrimBindingSource
        Me.Tbl_term_TrimBindingNavigator.CountItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_term_TrimBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tbl_term_TrimBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.Tbl_term_TrimBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_term_TrimBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.Name = "Tbl_term_TrimBindingNavigator"
        Me.Tbl_term_TrimBindingNavigator.PositionItem = Nothing
        Me.Tbl_term_TrimBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_term_TrimBindingNavigator.TabIndex = 0
        Me.Tbl_term_TrimBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_term_TrimBindingNavigatorSaveItem
        '
        Me.Tbl_term_TrimBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_term_TrimBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_term_TrimBindingNavigatorSaveItem.Name = "Tbl_term_TrimBindingNavigatorSaveItem"
        Me.Tbl_term_TrimBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Tbl_term_TrimBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_term_TrimDataGridView
        '
        Me.Tbl_term_TrimDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbl_term_TrimDataGridView.AutoGenerateColumns = False
        Me.Tbl_term_TrimDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_term_TrimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_term_TrimDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_term_TrimDataGridView.DataSource = Me.Tbl_term_TrimBindingSource
        Me.Tbl_term_TrimDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Tbl_term_TrimDataGridView.Name = "Tbl_term_TrimDataGridView"
        Me.Tbl_term_TrimDataGridView.Size = New System.Drawing.Size(284, 383)
        Me.Tbl_term_TrimDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fld_Trim"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Trim"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'options_Trims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.Tbl_term_TrimDataGridView)
        Me.Controls.Add(Me.Tbl_term_TrimBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "options_Trims"
        Me.Text = "Options - Trims"
        CType(Me.Db_WOlogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TrimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_term_TrimBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_term_TrimBindingNavigator.ResumeLayout(False)
        Me.Tbl_term_TrimBindingNavigator.PerformLayout()
        CType(Me.Tbl_term_TrimDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_WOlogDataSet As db_WOlogDataSet
    Friend WithEvents Tbl_term_TrimBindingSource As BindingSource
    Friend WithEvents Tbl_term_TrimTableAdapter As db_WOlogDataSetTableAdapters.tbl_term_TrimTableAdapter
    Friend WithEvents TableAdapterManager As db_WOlogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_term_TrimBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_term_TrimBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_term_TrimDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
