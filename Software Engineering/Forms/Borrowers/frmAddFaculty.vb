Public Class frmAddFaculty
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtFirstname.Text) OrElse
           String.IsNullOrEmpty(txtLastname.Text) OrElse
           String.IsNullOrEmpty(txtContact.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddFaculty(txtFirstname.Text, txtLastname.Text, txtContact.Text)
            Me.Close()
        End If
    End Sub
End Class