﻿Imports System.Security.Policy

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

    Private Sub dgAuthors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAuthors.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgAuthors.Rows(e.RowIndex)
            Dim authorName As String = row.Cells("authorName").Value.ToString
            Dim authorID As Integer = Convert.ToInt32(row.Cells("authorID").Value)

            Dim frmAuthorsInstance As New frmAddAuthors()
            frmAuthorsInstance.SetSelectedAuthorMaintenance(authorID, authorName)
            frmAuthorsInstance.Show()
            frmAuthorsInstance.btnSave.Visible = False
            frmAuthorsInstance.lblAuthors.Text = "AUTHOR INFORMATION"
        End If
    End Sub

    Private Sub dgSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSuppliers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgSuppliers.Rows(e.RowIndex)
            Dim supplierName As String = row.Cells("supplierName").Value.ToString
            Dim supplierID As Integer = Convert.ToInt32(row.Cells("supplierID").Value)
            Dim contactNo As String = row.Cells("contactNumber").Value.ToString
            Dim address As String = row.Cells("address").Value.ToString

            Dim frmSuppliersInstance As New frmAddSuppliers()
            frmSuppliersInstance.SetSelectedSuppliersMaintenance(supplierID, supplierName, contactNo, address)
            frmSuppliersInstance.Show()
            frmSuppliersInstance.btnSave.Visible = False
            frmSuppliersInstance.lblSupplier.Text = "SUPPLIER INFORMATION"
        End If
    End Sub

    Private Sub dgPublishers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPublishers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgPublishers.Rows(e.RowIndex)
            Dim publisherName As String = row.Cells("publisherName").Value.ToString
            Dim publisherID As Integer = Convert.ToInt32(row.Cells("publisherID").Value)

            Dim frmPublisherInstance As New frmAddPublishers()
            frmPublisherInstance.SetSelectedPublisherMaintenance(publisherID, publisherName)
            frmPublisherInstance.Show()
            frmPublisherInstance.btnSave.Visible = False
            frmPublisherInstance.lblPublishers.Text = "PUBLISHER INFORMATION"
        End If
    End Sub

    Private Sub dgGenres_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGenres.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgGenres.Rows(e.RowIndex)
            Dim genreName As String = row.Cells("genreName").Value.ToString
            Dim genreID As Integer = Convert.ToInt32(row.Cells("genreID").Value)
            Dim description As String = row.Cells("description").Value.ToString

            Dim frmGenreInstance As New frmAddGenre()
            frmGenreInstance.SetSelectedGenreMaintenance(genreID, genreName, description)
            frmGenreInstance.Show()
            frmGenreInstance.btnSave.Visible = False
            frmGenreInstance.lblGenre.Text = "GENRE INFORMATION"
        End If
    End Sub

    Private Sub dgBookshelves_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBookshelves.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBookshelves.Rows(e.RowIndex)
            Dim shelfID As Integer = Convert.ToInt32(row.Cells("shelfID").Value)
            Dim description As String = row.Cells("shelfDescription").Value.ToString
            Dim location As String = row.Cells("shelfLocation").Value.ToString
            Dim shelfNo As Integer = Convert.ToInt32(row.Cells("shelfNo").Value)

            Dim frmShelfInstance As New frmAddShelf()
            frmShelfInstance.SetSelectedShelfMaintenance(shelfID, description, location, shelfNo)
            frmShelfInstance.Show()
            frmShelfInstance.btnSave.Visible = False
            frmShelfInstance.txtShelfNo.ReadOnly = True
            frmShelfInstance.lblShelf.Text = "SHELF INFORMATION"
        End If
    End Sub
End Class