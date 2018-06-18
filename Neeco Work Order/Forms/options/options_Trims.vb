Public Class options_Trims
    Private Sub Tbl_term_TrimBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_TrimBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_TrimBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_Trims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Trim' table. You can move, or remove it, as needed.
        Me.Tbl_term_TrimTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Trim)

    End Sub
End Class