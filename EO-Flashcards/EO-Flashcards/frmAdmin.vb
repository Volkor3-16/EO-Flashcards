' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmAdmin
    Private Sub btnAdminPassword_Click(sender As Object, e As EventArgs) Handles btnAdminPassword.Click
        My.Settings.AdminPassword = InputBox("Enter New Password WARNING, this will change with no confirmation, and if spelt wrong, will set that.")
        'This instantly changes the admin password.
    End Sub

    Private Sub frmAdmin_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        frmMenu.Show() 'When being closed, open main menu instead of exiting program.
    End Sub
End Class