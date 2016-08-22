Public Class frmArcade
    ' Loading each file into their own arrays
    Dim english As String() = System.IO.File.ReadAllLines("C:\Users\ACP\Documents\GitHub\EO-Flashcards\EO-Flashcards\EO-Flashcards\Resources\engout.txt")
    Dim esperanto As String() = System.IO.File.ReadAllLines("C:\Users\ACP\Documents\GitHub\EO-Flashcards\EO-Flashcards\EO-Flashcards\Resources\espout.txt")
    Public Sub frmArcade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim randomword As Integer = CInt(Int((63425 * Rnd())))
        lblLineNumber.Text = randomword
        'Put that into the txtbox now.
        txtEsperanto.Text = esperanto(randomword + 1)
    End Sub
    Public Sub Arcade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTranslated.KeyPress
        ' Detect Keypresses
        If e.KeyChar = ChrW(Keys.Enter) Then 'When enter pressed
            If txtTranslated.Text() = english(lblLineNumber.Text() + 1) Then
                MsgBox("Correct")
                Dim randomword As Integer = CInt(Int((63425 * Rnd())))
                lblLineNumber.Text = randomword
                txtEsperanto.Text = esperanto(randomword + 1)
                txtTranslated.Clear()
                'If correct, find a new random number for comparison again.
            Else
                Dim skip = MsgBox("Incorrect, Would you like to skip?", MsgBoxStyle.YesNo)
                If skip = MsgBoxResult.Yes Then
                    Dim randomword As Integer = CInt(Int((63425 * Rnd())))
                    lblLineNumber.Text = randomword
                    txtEsperanto.Text = esperanto(randomword + 1)
                    txtTranslated.Clear()
                    'if incorrect, ask if they want to skip the word, and continue on with it.
                End If
            End If
        End If
    End Sub
End Class