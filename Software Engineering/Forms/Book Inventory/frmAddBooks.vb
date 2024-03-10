﻿Public Class frmAddBooks
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim yearPublished As Integer

        If Integer.TryParse(txtYearPublished.Text, yearPublished) Then
            If yearPublished > DateTime.Now.Year Then
                MessageBox.Show("Invalid Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If String.IsNullOrEmpty(txtISBN.Text) OrElse
                String.IsNullOrEmpty(txtTitle.Text) OrElse
                String.IsNullOrEmpty(txtYearPublished.Text) Then
                MessageBox.Show("Please fill in the necessary details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                AddBooks(txtISBN.Text, txtTitle.Text, txtAuthorID.Text, txtPublisherID.Text, txtYearPublished.Text, txtGenreID.Text)
                Me.Close()
            End If
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

        Dim dtGenre As DataTable = DisplayAlphabeticalData("tblGenres", "genreName")
        txtGenre.DataSource = dtGenre
        txtGenre.DisplayMember = "genreName"
        txtGenre.ValueMember = "genreID"
    End Sub

    Private Sub btnFindAuthor_Click(sender As Object, e As EventArgs) Handles btnFindAuthor.Click
        frmFindAuthor.Show()
    End Sub

    Public Sub SetSelectedAuthor(authorID As Integer, authorName As String)
        txtAuthor.Text = authorName
        txtAuthorID.Text = authorID
    End Sub

    Private Sub btnFindPublisher_Click(sender As Object, e As EventArgs) Handles btnFindPublisher.Click
        frmFindPublisher.Show()
    End Sub

    Public Sub SetSelectedPublisher(publisherID As Integer, publisherName As String)
        txtPublisherID.Text = publisherID
        txtPublisher.Text = publisherName
    End Sub

    Private Sub txtAuthor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAuthor.SelectedValueChanged
        txtAuthorID.Text = txtAuthor.SelectedValue.ToString
    End Sub

    Private Sub txtPublisher_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtPublisher.SelectedValueChanged
        txtPublisherID.Text = txtPublisher.SelectedValue.ToString
    End Sub

    Private Sub txtGenre_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGenre.SelectedValueChanged
        txtGenreID.Text = txtGenre.SelectedValue.ToString
    End Sub

    Private Sub DigitOnly(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress, txtYearPublished.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class