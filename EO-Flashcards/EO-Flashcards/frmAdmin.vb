Public Class frmAdmin
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click

    End Sub

    Private Sub btnAdminPassword_Click(sender As Object, e As EventArgs) Handles btnAdminPassword.Click
        My.Settings.AdminPassword = InputBox("Enter New Password WARNING, this will change with no confirmation, and if spelt wrong, will set that.")
    End Sub
End Class