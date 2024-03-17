﻿Public Class frmAddGenre
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtGenre.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please fill in the necesarry fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddGenre(txtGenre.Text, txtDescription.Text)
            Me.Close()
        End If
    End Sub

    Private Sub LettersOnly(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress, txtGenre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteGenre(txtGenreID.Text)
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtGenre.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please fill in the necesarry fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateGenre(txtGenreID.Text, txtGenre.Text, txtDescription.Text)
            Me.Close()
        End If
    End Sub

    Public Sub SetSelectedGenreMaintenance(genreID As Integer, genreName As String, description As String)
        txtGenre.Text = genreName
        txtGenreID.Text = genreID
        txtDescription.Text = description
    End Sub
End Class