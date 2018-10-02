Public Class options_TempClasses
    Private Sub Tbl_term_TempClassBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_TempClassBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_TempClassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_TempClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_TempClass' table. You can move, or remove it, as needed.
        Me.Tbl_term_TempClassTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_TempClass)

    End Sub
End Class