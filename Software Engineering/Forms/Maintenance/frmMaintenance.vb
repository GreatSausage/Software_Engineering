Imports System.Security.Policy

Public Class frmMaintenance
    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usersDt As DataTable = DisplayUsers()
        dgUser.DataSource = usersDt

        Dim suppliersDt As DataTable = DisplayData("tblSuppliers")
        dgSuppliers.DataSource = suppliersDt

        Dim authorsDt As DataTable = DisplayData("tblAuthors")
        dgAuthors.DataSource = authorsDt

        Dim publishersDt As DataTable = DisplayData("tblPublishers")
        dgPublishers.DataSource = publishersDt

        Dim genresDt As DataTable = DisplayData("tblGenres")
        dgGenres.DataSource = genresDt

        Dim shelvesDt As DataTable = DisplayData("tblBookshelves")
        dgBookshelves.DataSource = shelvesDt
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmAddUsers.Show()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        frmAddSuppliers.Show()
    End Sub

    Private Sub btnAuthors_Click(sender As Object, e As EventArgs) Handles btnAuthors.Click
        frmAddAuthors.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        frmAddPublishers.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frmAddGenre.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        frmAddShelf.Show()
    End Sub

End Class