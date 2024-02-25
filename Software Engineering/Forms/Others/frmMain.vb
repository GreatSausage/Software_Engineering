Public Class frmMain
    Private Sub frmMain_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        DisplayFormPanel(frmMaintenance, panelDisplay)
    End Sub

    Private Sub btnBookInventory_Click(sender As Object, e As EventArgs) Handles btnBookInventory.Click
        DisplayFormPanel(frmBookInventory, panelDisplay)
    End Sub
End Class