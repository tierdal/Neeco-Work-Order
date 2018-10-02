Public Class options_ProductType
    Private Sub Tbl_term_ProductTypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_ProductTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_ProductTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_ProductType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_ProductType' table. You can move, or remove it, as needed.
        Me.Tbl_term_ProductTypeTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_ProductType)

    End Sub

End Class