Public Class options_OperatorStyles
    Private Sub Tbl_term_HHPPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_HHPPBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_HHPPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub options_OperatorStyles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_HHPP' table. You can move, or remove it, as needed.
        Me.Tbl_term_HHPPTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_HHPP)

    End Sub
End Class