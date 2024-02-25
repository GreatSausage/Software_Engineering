Public Class frmAddBooks
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim authorID As Integer = Convert.ToInt32(txtAuthor.SelectedValue)
        Dim publisherID As Integer = Convert.ToInt32(txtPublisher.SelectedValue)

        If String.IsNullOrEmpty(txtISBN.Text) OrElse
           String.IsNullOrEmpty(txtTitle.Text) OrElse
           String.IsNullOrEmpty(txtYearPublished.Text) Then
            MessageBox.Show("Please fill in the necessary details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            AddBooks(txtISBN.Text, txtTitle.Text, authorID, publisherID, txtYearPublished.Text)
            Me.Close()
        End If
    End Sub

    Private Sub frmAddBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtAuthors As DataTable = DisplayAlphabeticalData("tblAuthors", "authorName")
        txtAuthor.DataSource = dtAuthors
        txtAuthor.DisplayMember = "authorName"
        txtAuthor.ValueMember = "authorID"

        Dim dtPublisher As DataTable = DisplayAlphabeticalData("tblPublishers", "publisherName")
        txtPublisher.DataSource = dtPublisher
        txtPublisher.DisplayMember = "publisherName"
        txtPublisher.ValueMember = "publisherID"
    End Sub

    Private Sub btnFindPublisher_Click(sender As Object, e As EventArgs)

    End Sub
End Class