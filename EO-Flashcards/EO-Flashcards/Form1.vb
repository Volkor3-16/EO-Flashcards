' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards

Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMenu.Show() 'Open main menu
        arrModule()
        Me.Close() 'Close myself
    End Sub

    Public booklist As List(Of dictonary)
    Public Sub btnLogin_Seperator(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Dim dicfile As String() = My.Resources.espdic. 'Using below until I can get this line working.
        Dim dicfile As String() = IO.File.ReadAllLines("C:\Users\ACP\Documents\GitHub\EO-Flashcards\EO-Flashcards\EO-Flashcards\Resources\espdic.txt")
        For Each line As String In dicfile
            Dim eoinfo As String() = line.Split(" : ")
            Dim abook As New dictonary(eoinfo(0), eoinfo(1))
            booklist.Add(abook)
        Next
    End Sub
End Class

Public Class dictonary
    Property eo As String
    Property en As String
    Public Sub New(ByVal eo As String, ByVal en As String)
        _en = eo
        _en = en
    End Sub
End Class
