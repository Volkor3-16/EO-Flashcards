Public Class frmAdminLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = My.Settings.AdminPassword Then
            frmAdmin.Show()
            Me.Close()
        Else
            MsgBox("Invalid Admin Password")
        End If
    End Sub
End Class