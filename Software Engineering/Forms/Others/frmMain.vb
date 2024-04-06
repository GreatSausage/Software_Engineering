﻿Public Class frmMain
    Private Sub frmMain_Resized(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        DisplayFormPanel(frmMainte, panelDisplay)
    End Sub

    Private Sub btnBookInventory_Click(sender As Object, e As EventArgs) Handles btnBookInventory.Click
        DisplayFormPanel(frmBookInventory, panelDisplay)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DisplayFormPanel(frmIssueReturn, panelDisplay)
    End Sub
End Class