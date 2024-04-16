Public Class frmIssueReturn
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        frmBorrowBooks.Show()
    End Sub

    'Private Sub frmIssueReturn_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim dtBorrowed As DataTable = DisplayBorrowedBooks()
    '    dgBorrowed.DataSource = dtBorrowed
    'End Sub
End Class