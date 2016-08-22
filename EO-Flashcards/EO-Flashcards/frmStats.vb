Public Class frmStats
    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCorrect.Text = My.Settings.TotalCorrect
        lblTotalIncorrect.Text = My.Settings.TotalIncorrect
    End Sub
End Class