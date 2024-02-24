Public Class frmAddAuthors
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtAuthors.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddAuthors(txtAuthors.Text)
            Me.Close()
        End If
    End Sub

    Private Sub txtAuthors_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthors.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class