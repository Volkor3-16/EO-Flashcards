' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.

Public Class frmMenu
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmAdmin.Show()
        Me.Close()
        ' Opens Admin Menu and closes frmMenu when clicked.
    End Sub
End Class
