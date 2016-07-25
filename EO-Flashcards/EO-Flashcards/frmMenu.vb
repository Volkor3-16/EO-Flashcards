' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
'
'----------------------------------------------------------------------------
' "THE BEER-WARE LICENSE" (Revision 42):
' <AConsolePeasant@openmailbox.org> wrote this file. As long as you retain this notice you
' can do whatever you want with this stuff. If we meet some day, And you think
' this stuff Is worth it, you can buy me a beer in return.
' ----------------------------------------------------------------------------
'

Public Class frmMenu
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmAdmin.Show()
        Me.Close()
        ' Opens Admin Menu and closes frmMenu when clicked.
    End Sub
End Class