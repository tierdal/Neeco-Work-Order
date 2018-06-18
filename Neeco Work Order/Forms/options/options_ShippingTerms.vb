Public Class options_ShippingTerms
    Private Sub Tbl_term_SizeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_SizeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_SizeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_ShippingTerms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_ShipMethod' table. You can move, or remove it, as needed.
        Me.Tbl_term_ShipMethodTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_ShipMethod)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_ShipMethod' table. You can move, or remove it, as needed.
        Me.Tbl_term_ShipMethodTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_ShipMethod)
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Size' table. You can move, or remove it, as needed.
        Me.Tbl_term_SizeTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Size)

    End Sub
End Class