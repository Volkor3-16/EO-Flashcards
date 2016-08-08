' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmMenu
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If InputBox("Enter Admin Password") = My.Settings.AdminPassword Then 'todo: Put all of this poo in a array
            frmAdmin.Show()
            Me.Close()
        Else
            MsgBox("Invalid Admin Password")
        End If
        ' Opens Admin Menu and closes frmMenu when clicked.
    End Sub
End Class
