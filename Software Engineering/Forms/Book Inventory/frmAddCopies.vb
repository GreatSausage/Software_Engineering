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
        If String.IsNullOrEmpty(txtISBN.Text) OrElse
           String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim copiesToAdd As Integer = Convert.ToInt32(txtCopiesToAdd.Value)
            Dim bookID As Integer = Convert.ToInt32(GetBookID(txtISBN.Text))
            Dim supplierID As Integer = Convert.ToInt32(txtSupplier.SelectedValue)
            Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
            Dim type As String = ""

            If rbDonated.Checked Then
                type = "Donated"
            Else
                type = "Purchased"
            End If
            For i As Integer = 1 To copiesToAdd
                Dim acn As String = AccessionGenerator()
                AddCopies(acn, bookID, supplierID, price, Type)
            Next
            MessageBox.Show("Copies added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub
End Class