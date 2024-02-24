Public Class frmAddSuppliers
    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtSupplierName.Text) OrElse
           String.IsNullOrEmpty(txtContact.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("Please fill in the necessary fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            AddSuppliers(txtSupplierName.Text, txtContact.Text, txtAddress.Text)
            Me.Close()
        End If
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress, txtContact.KeyPress, txtSupplierName.KeyPress
        If e.KeyChar = " " AndAlso txtAddress.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtContact.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtSupplierName.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles txtSupplierName.KeyPress, txtAddress.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub DigitOnly(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class