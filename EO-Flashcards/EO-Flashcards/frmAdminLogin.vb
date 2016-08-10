' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmAdminLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = My.Settings.AdminPassword Then
            frmAdmin.Show()
            Me.Close() 'Simple login.
        Else
            MsgBox("Invalid Admin Password")
        End If
    End Sub
End Class