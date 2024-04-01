Public Class frmAddBorrowers
    Private Sub frmAddBorrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtGrade As DataTable = DisplayGrades()
        txtGrade.DataSource = dtGrade
        txtGrade.ValueMember = "gradeID"
        txtGrade.DisplayMember = "grade"
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGrade.SelectedIndexChanged
        Dim grade As Integer
        If Integer.TryParse(txtGrade.Text, grade) Then
            Dim sectionsTable As DataTable = DisplaySection(grade)
            If sectionsTable IsNot Nothing Then
                txtSection.DataSource = sectionsTable
                txtSection.DisplayMember = "section"
                txtSection.ValueMember = "sectionID"
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim grade As Integer = Convert.ToInt32(txtGrade.SelectedValue)
        Dim section As Integer = Convert.ToInt32(txtSection.SelectedValue)

        If String.IsNullOrEmpty(txtFirstname.Text) OrElse
           String.IsNullOrEmpty(txtGuardianContact.Text) OrElse
           String.IsNullOrEmpty(txtLastname.Text) OrElse
           String.IsNullOrEmpty(txtStudentID.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddBorrowers(txtStudentID.Text, txtFirstname.Text, txtLastname.Text, grade, section, txtGuardianContact.Text)
            Me.Close()
        End If
    End Sub

    Private Sub AntiDoubleSpace(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtGuardianContact.KeyPress, txtLastname.KeyPress, txtStudentID.KeyPress
        If e.KeyChar = " " AndAlso txtFirstname.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtGuardianContact.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtLastname.Text.EndsWith(" ") Then
            e.Handled = True
        ElseIf e.KeyChar = " " AndAlso txtStudentID.Text.EndsWith(" ") Then
            e.Handled = True
        End If
    End Sub
End Class