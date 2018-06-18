Public Class options_Customer
    Private Sub Tbl_term_CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_term_CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_term_CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_WOlogDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_WOlogDataSet.tbl_term_Customers' table. You can move, or remove it, as needed.
        Me.Tbl_term_CustomersTableAdapter.Fill(Me.Db_WOlogDataSet.tbl_term_Customers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class