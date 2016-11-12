Public Class Form1
    Private datebase As New BooksDataContext()



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AuthorBindingSource.DataSource =
            From author In datebase.Authors
            Order By author.AuthorID
            Select author
    End Sub


    Private Sub AuthorBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles AuthorBindingNavigator.RefreshItems
        Validate()
        AuthorBindingSource.EndEdit()
        datebase.SubmitChanges()
    End Sub
End Class
