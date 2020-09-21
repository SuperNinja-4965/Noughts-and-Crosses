Imports MaterialSkin
Public Class Main

    Public Player1, Player2, OpenGame As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
        Player1 = ""
        Player2 = ""
        OpenGame = ""
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenGameDialog.ShowDialog()
        If OpenGameDialog.FileName <> "" Then
            OpenGame = OpenGameDialog.FileName
            Game.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BeginGameBtn.Click
        Player1 = Player1Box.Text
        Player2 = Player2Box.Text
        If (Player1 <> "") And (Player2 <> "") Then
            Game.Show()
            Me.Hide()
        End If
    End Sub
End Class
