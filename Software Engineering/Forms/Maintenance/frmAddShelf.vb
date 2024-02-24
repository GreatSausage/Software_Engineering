Public Class frmAddShelf
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtShelfNo.Text) OrElse
           String.IsNullOrEmpty(txtDescription.Text) OrElse
           String.IsNullOrEmpty(txtLocation.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddBookshelves(txtShelfNo.Text, txtDescription.Text, txtLocation.Text)
            Me.Close()
        End If
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress, txtLocation.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtShelfNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShelfNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class