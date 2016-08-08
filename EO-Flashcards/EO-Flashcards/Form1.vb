' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.

Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = My.Settings.GuestAccount Then
            frmMenu.Show()
            Me.Close()
        Else
            MsgBox("Invalid Username")
            txtUsername.Focus()
        End If
    End Sub
End Class
