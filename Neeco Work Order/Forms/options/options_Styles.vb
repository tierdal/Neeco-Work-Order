Public Class options_Styles
    Private Sub Tbl_term_StyleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_StyleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_StyleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_Styles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Style' table. You can move, or remove it, as needed.
        Me.Tbl_term_StyleTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Style)

    End Sub
End Class