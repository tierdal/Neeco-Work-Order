Public Class options_PSL
    Private Sub Tbl_term_PSLBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_PSLBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_PSLBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_PSL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_PSL' table. You can move, or remove it, as needed.
        Me.Tbl_term_PSLTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_PSL)

    End Sub
End Class