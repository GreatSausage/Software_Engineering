Public Class frmFindAuthor
    'Private Sub dgAuthor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAuthor.CellContentClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = dgAuthor.Rows(e.RowIndex)
    '        Dim authorName As String = row.Cells("authorName").Value.ToString
    '        Dim authorID As Integer = Convert.ToInt32(row.Cells("authorID").Value)

    '        Dim frmAddBooksInstance As frmAddBooks = DirectCast(Application.OpenForms("frmAddBooks"), frmAddBooks)
    '        If frmAddBooksInstance IsNot Nothing Then
    '            frmAddBooksInstance.SetSelectedAuthor(authorID, authorName)
    '        End If

    '        Dim frmBookInfoInstance As frmBookInfo = DirectCast(Application.OpenForms("frmBookInfo"), frmBookInfo)
    '        If frmBookInfoInstance IsNot Nothing Then
    '            frmBookInfoInstance.SetSelectedBookAuthor(authorID, authorName)
    '        End If
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub frmFindAuthor_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim authorsDt As DataTable = DisplayData("tblAuthors")
    '    dgAuthor.DataSource = authorsDt
    'End Sub

    'Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
    '    Me.Close()
    'End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    'SearchAuthors(dgAuthor, txtSearch.Text)
    'End Sub

    'Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
    '    frmAddBooks.someVariables &= Guna2CheckBox1.Text
    '    frmAddBooks.Guna2HtmlLabel1.Text = frmAddBooks.someVariables
    'End Sub

    'Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox2.CheckedChanged
    '    frmAddBooks.someVariables &= Guna2CheckBox2.Text
    '    frmAddBooks.Guna2HtmlLabel1.Text = frmAddBooks.someVariables
    'End Sub
End Class