Public Class options_PressureRatings
    Private Sub Tbl_term_PressureBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_PressureBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_PressureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_PressureRatings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Pressure' table. You can move, or remove it, as needed.
        Me.Tbl_term_PressureTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Pressure)

    End Sub
End Class