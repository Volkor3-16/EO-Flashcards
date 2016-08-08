' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmMenu
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmAdminLogin.Show()
        frmAdmin.Close()
        ' Opens Admin new Form for admin login, as the previous method (inputbox) couldn't have a password mask.
    End Sub
End Class
