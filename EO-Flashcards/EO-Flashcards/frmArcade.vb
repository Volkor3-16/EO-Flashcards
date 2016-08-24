' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmArcade
    ' Loading each file into their own arrays
    'Dim english As String() = My.Resources.engout 'This causes errors because My.Resource.engout is compiled into the executable, and doesn't allow being imported back into a string.
    Dim english As String() = System.IO.File.ReadAllLines("C:\Users\ACP\Documents\GitHub\EO-Flashcards\EO-Flashcards\EO-Flashcards\Resources\engout.txt")
    Dim esperanto As String() = System.IO.File.ReadAllLines("C:\Users\ACP\Documents\GitHub\EO-Flashcards\EO-Flashcards\EO-Flashcards\Resources\espout.txt")
    ' I know this doesn't work on more than one computer, but If I use My.Resources It would error out.
    Dim score As Integer = 0
    Public Sub frmArcade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim randomword As Integer = CInt(Int((63425 * Rnd())))
        lblLineNumber.Text = randomword
        'Put that into the txtbox now.
        txtEsperanto.Text = esperanto(randomword + 1)
    End Sub
    Public Sub Arcade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTranslated.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'When enter pressed
            If LCase(english(lblLineNumber.Text() + 1)).Contains(txtTranslated.Text) Then 'Thanks to some fancy googling and tip top help form stackoverflow, we can know use parital answers.
                My.Settings.TotalCorrect += 1
                MsgBox("Correct") ' That above line allows for us to sometimes accidentally allow users to enter one letter, it looks impossible without rewriting a lot of it too fix.
                score += 1 'add one to score
                lblCorrect.Text = score
                Dim randomword As Integer = CInt(Int((63425 * Rnd()))) 'get new random word
                lblLineNumber.Text = randomword 'for debugging and somewhat cheaty reasons
                txtEsperanto.Text = esperanto(randomword + 1) 'need the +1 so it's not offset
                'txtTranslated.Clear() 'Doesn't work, no idea why.
                'If correct, find a new random number for comparison again.
            Else
                My.Settings.TotalIncorrect += 1
                Dim skip = MsgBox("Incorrect, Would you like to skip?", MsgBoxStyle.YesNo)
                If skip = MsgBoxResult.Yes Then
                    MsgBox("The correct answer was: " + english(lblLineNumber.Text))
                    Dim randomword As Integer = CInt(Int((63425 * Rnd())))
                    lblLineNumber.Text = randomword
                    txtEsperanto.Text = esperanto(randomword + 1)
                    txtTranslated.Clear()
                    'If skip = MsgBoxResult.No Then
                    '    txtTranslated.Clear() 'Doesn't work, no idea why.
                    'End If
                    'if incorrect, ask if they want to skip the word, and continue on with it.
                End If
            End If
        End If
    End Sub
End Class