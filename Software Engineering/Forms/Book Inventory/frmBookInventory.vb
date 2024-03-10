Public Class frmBookInventory
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        frmAddBooks.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmAddCopies.Show()
    End Sub

    Private Sub frmBookInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtBooks As DataTable = DisplayBooks()
        dgBooks.DataSource = dtBooks

        Dim dtCopies As DataTable = DisplayCopies()
        dgCopies.DataSource = dtCopies
    End Sub

End Class