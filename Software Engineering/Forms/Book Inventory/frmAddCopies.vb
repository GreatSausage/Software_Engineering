Public Class frmAddCopies
    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        Dim bookTitle As String = GetBookTitle(txtISBN.Text)

        If Not String.IsNullOrEmpty(txtISBN.Text) Then
            txtTitle.Text = bookTitle

        Else
            txtTitle.Clear()
        End If
    End Sub

    Private Sub frmAddCopies_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtSuppliers As DataTable = DisplaySuppliers()
        txtSupplier.DataSource = dtSuppliers
        txtSupplier.DisplayMember = "supplierName"
        txtSupplier.ValueMember = "supplierID"

        rbDonated.Checked = True
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim price As Decimal

        If rbPurchased.Checked Then
            If String.IsNullOrEmpty(txtPrice.Text) OrElse String.IsNullOrEmpty(txtISBN.Text) Then
                MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Not String.IsNullOrEmpty(txtPrice.Text) Then
                price = Convert.ToDecimal(txtPrice.Text)
            End If
        End If

        If rbDonated.Checked Then
            If String.IsNullOrEmpty(txtISBN.Text) Then
                MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Not String.IsNullOrEmpty(txtPrice.text) Then
                price = Convert.ToDecimal(txtPrice.Text)
            ElseIf String.IsNullOrEmpty(txtPrice.text) Then
                price = 0.00
            End If
        End If

        Dim copiesToAdd As Integer = Convert.ToInt32(txtCopiesToAdd.Value)
        Dim bookID As Integer = Convert.ToInt32(GetBookID(txtISBN.Text))
        Dim supplierID As Integer = Convert.ToInt32(txtSupplier.SelectedValue)
        Dim type As String = If(rbDonated.Checked, "Donated", "Purchased")

        For i As Integer = 1 To copiesToAdd
            Dim acn As String = AccessionGenerator()
            AddCopies(acn, bookID, supplierID, price, type)
        Next

        MessageBox.Show("Copies added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class