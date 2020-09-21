Imports MaterialSkin
Public Class Game

    Dim Player1Name, Player2Name As String
    ' true = player1, false = player2
    Dim Turn As Boolean = True

    Dim GridVar(2, 2) As String
    Dim MoveCounter As Integer = 0

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting the Material Skin color scheme
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)

        'Getting the players names
        Player1Name = Main.Player1
        Player2Name = Main.Player2

        If Main.OpenGame <> "" Then
            OpenGameFile(Main.OpenGame)
        Else
            'resets the game ready to play.
            resetGame()
        End If
        Main.Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        'Reset the game. And starts a new game.
        Main.Show()
        Me.Close()
    End Sub

    ' This is run each time a player makes their move.
    Private Sub TurnOver(ByVal location As Integer)
        Dim XorO As String
        ' Finds the button and disables it (this will also give it an X/O so the players know where they have gone)
        Dim btns() = Controls.Find("GridBtn" + location.ToString, True)
        Dim btn As Button
        If btns IsNot Nothing Then
            btn = btns(0)
            btn.Enabled = False
            If Turn = True Then
                btn.Text = "X"
                ' Updates the 2d array with the move
                GridVar(Integer.Parse(location.ToString.Substring(0, 1)) - 1, Integer.Parse(location.ToString.Substring(1, 1)) - 1) = "X"
                TurnTracker.Text = "It is " + Player2Name + "'s Turn."
                Turn = False
                XorO = "X"
            Else
                btn.Text = "O"
                ' Updates the 2d array with the move
                GridVar(Integer.Parse(location.ToString.Substring(0, 1)) - 1, Integer.Parse(location.ToString.Substring(1, 1)) - 1) = "O"
                TurnTracker.Text = "It is " + Player1Name + "'s Turn."
                Turn = True
                XorO = "O"
            End If
        End If
        MoveCounter = MoveCounter + 1
        Moveslbl.Text = "Moves: " + MoveCounter.ToString

        ' Check to see if there is a winner. No point to check before 5 moves as it isnt possible to win.
        If MoveCounter >= 5 Then
            If (GridVar(0, 0) = XorO) And (GridVar(1, 0) = XorO) And (GridVar(2, 0) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(0, 1) = XorO) And (GridVar(1, 1) = XorO) And (GridVar(2, 1) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(0, 2) = XorO) And (GridVar(1, 2) = XorO) And (GridVar(2, 2) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(0, 0) = XorO) And (GridVar(0, 1) = XorO) And (GridVar(0, 2) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(1, 0) = XorO) And (GridVar(1, 1) = XorO) And (GridVar(1, 2) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(2, 0) = XorO) And (GridVar(2, 1) = XorO) And (GridVar(2, 2) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(0, 2) = XorO) And (GridVar(1, 1) = XorO) And (GridVar(2, 0) = XorO) Then
                GameWon(XorO)
            ElseIf (GridVar(0, 0) = XorO) And (GridVar(1, 1) = XorO) And (GridVar(2, 2) = XorO) Then
                GameWon(XorO)
            Else
                ' Checking to see if the Game is over. (Checks to see if all the squares are used up)
                For x = 0 To 2
                    For y = 0 To 2
                        Dim counter As Integer
                        If GridVar(x, y) <> "" Then
                            counter = counter + 1
                        End If
                        If counter = 9 Then
                            TurnTracker.Text = "The Game is a tie!"
                            MessageBox.Show("The Game is a tie!", "Game Over!")
                            SaveGameToolStripMenuItem.Enabled = False
                        End If
                    Next
                Next
            End If

        End If
    End Sub

    Private Sub GameWon(ByVal XorO2 As String)
        If XorO2 = "X" Then
            XorO2 = Player1Name
        Else
            XorO2 = Player2Name
        End If
        For x = 1 To 3
            For y = 1 To 3
                Dim btns() = Controls.Find("GridBtn" & x.ToString & y.ToString, True)
                Dim btn As Button
                If btns IsNot Nothing Then
                    btn = btns(0)
                    btn.Enabled = False
                End If
            Next
        Next
        TurnTracker.Text = XorO2 + " Wins!!"
        MessageBox.Show(XorO2 + " Wins!! Well Done!", "Game Over!")
        SaveGameToolStripMenuItem.Enabled = False
    End Sub

    Private Sub resetGame()
        Player1lbl.Text = "Player1 (" + Player1Name + "): Crosses"
        Player2lbl.Text = "Player2 (" + Player2Name + "): Noughts"
        TurnTracker.Text = "It is " + Player1Name + "'s Turn."
        Moveslbl.Text = "Moves: "

        'Resetting the variables
        GridVar = {{"", "", ""}, {"", "", ""}, {"", "", ""}}
        MoveCounter = 0
        Turn = True

        For x = 1 To 3
            For y = 1 To 3
                Dim btns() = Controls.Find("GridBtn" & x.ToString & y.ToString, True)
                Dim btn As Button
                If btns IsNot Nothing Then
                    btn = btns(0)
                    btn.Enabled = True
                    btn.Text = " "
                End If
            Next
        Next
        SaveGameToolStripMenuItem.Enabled = True
    End Sub

    Private Sub NewGameSamePlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameSamePlayersToolStripMenuItem.Click
        resetGame()
    End Sub

    ' These lines of code handle the button clicks.
    ' When the button is clicked a subroutine is called and the buttons id code is passed to the subroutine.
    Private Sub GridBtn11_Click(sender As Object, e As EventArgs) Handles GridBtn11.Click
        TurnOver(11)
    End Sub

    Private Sub GridBtn21_Click(sender As Object, e As EventArgs) Handles GridBtn21.Click
        TurnOver(21)
    End Sub

    Private Sub GridBtn31_Click(sender As Object, e As EventArgs) Handles GridBtn31.Click
        TurnOver(31)
    End Sub

    Private Sub GridBtn12_Click(sender As Object, e As EventArgs) Handles GridBtn12.Click
        TurnOver(12)
    End Sub

    Private Sub GridBtn22_Click(sender As Object, e As EventArgs) Handles GridBtn22.Click
        TurnOver(22)
    End Sub

    Private Sub GridBtn32_Click(sender As Object, e As EventArgs) Handles GridBtn32.Click
        TurnOver(32)
    End Sub

    Private Sub GridBtn13_Click(sender As Object, e As EventArgs) Handles GridBtn13.Click
        TurnOver(13)
    End Sub

    Private Sub GridBtn23_Click(sender As Object, e As EventArgs) Handles GridBtn23.Click
        TurnOver(23)
    End Sub

    Private Sub GridBtn33_Click(sender As Object, e As EventArgs) Handles GridBtn33.Click
        TurnOver(33)
    End Sub

    ' Code to Save and Open games
    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        SaveGameDialog.ShowDialog()
        If SaveGameDialog.FileName <> "" Then
            Dim file As String = SaveGameDialog.FileName
            If System.IO.File.Exists(file) Then
                System.IO.File.Delete(file)
            End If
            Dim objWriter As New System.IO.StreamWriter(file)
            objWriter.WriteLine(Player1Name)
            objWriter.WriteLine(Player2Name)
            Dim GridVar2(2, 2) As String
            Array.Copy(GridVar, GridVar2, GridVar2.Length)
            For x = 0 To 2
                For y = 0 To 2
                    If GridVar2(x, y) = "" Then
                        GridVar2(x, y) = "-"
                    End If
                Next
            Next
            objWriter.WriteLine(GridVar2(0, 0) + GridVar2(1, 0) + GridVar2(2, 0))
            objWriter.WriteLine(GridVar2(0, 1) + GridVar2(1, 1) + GridVar2(2, 1))
            objWriter.WriteLine(GridVar2(0, 2) + GridVar2(1, 2) + GridVar2(2, 2))
            If Turn = True Then
                objWriter.WriteLine("X")
            Else objWriter.WriteLine("O")
            End If
            objWriter.WriteLine("The program that created this file was: Noughts and Crosses by Joshua Glass")
            objWriter.Close()
        End If
    End Sub

    Private Sub OpenGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGameToolStripMenuItem.Click
        OpenGameDialog.ShowDialog()
        If OpenGameDialog.FileName <> "" Then
            OpenGameFile(OpenGameDialog.FileName)
        End If
    End Sub

    Private Sub OpenGameFile(ByVal file As String)
        Try
            Dim objReader As New System.IO.StreamReader(file)
            Player1Name = objReader.ReadLine()
            Player2Name = objReader.ReadLine()
            Dim row1 As String = objReader.ReadLine()
            Dim row2 As String = objReader.ReadLine()
            Dim row3 As String = objReader.ReadLine()
            Dim nextPlayer As String = objReader.ReadLine()
            objReader.Close()

            resetGame()

            For y = 1 To 3
                If row1.Substring(y - 1, 1) <> "-" Then
                    If row1.Substring(y - 1, 1) = "X" Then
                        Turn = True
                    Else Turn = False
                    End If
                    If y = 1 Then
                        TurnOver(11)
                    ElseIf y = 2 Then
                        TurnOver(21)
                    ElseIf y = 3 Then
                        TurnOver(31)
                    End If
                End If
            Next

            For y = 1 To 3
                If row2.Substring(y - 1, 1) <> "-" Then
                    If row2.Substring(y - 1, 1) = "X" Then
                        Turn = True
                    Else Turn = False
                    End If
                    If y = 1 Then
                        TurnOver(12)
                    ElseIf y = 2 Then
                        TurnOver(22)
                    ElseIf y = 3 Then
                        TurnOver(32)
                    End If
                End If
            Next

            For y = 1 To 3
                If row3.Substring(y - 1, 1) <> "-" Then
                    If row3.Substring(y - 1, 1) = "X" Then
                        Turn = True
                    Else Turn = False
                    End If
                    If y = 1 Then
                        TurnOver(13)
                    ElseIf y = 2 Then
                        TurnOver(23)
                    ElseIf y = 3 Then
                        TurnOver(33)
                    End If
                End If
            Next

            If nextPlayer = "X" Then
                Turn = True
                TurnTracker.Text = "It is " + Player1Name + "'s Turn."
            Else
                Turn = False
                TurnTracker.Text = "It is " + Player2Name + "'s Turn."
            End If
        Catch ex As Exception
            Dim answer As Integer
            answer = MsgBox("An error has occured please try again. Would you like to see more info on this error?", vbYesNo)
            If answer = vbYes Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class