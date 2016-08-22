' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmMenu
    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        frmAdminLogin.Show()
        ' Opens Admin new Form for admin login, as the previous method (inputbox) couldn't have a password mask.
    End Sub

    Private Sub btnArcade_Click(sender As Object, e As EventArgs) Handles btnArcade.Click
        frmArcade.Show()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        frmStats.Show()
    End Sub
End Class
