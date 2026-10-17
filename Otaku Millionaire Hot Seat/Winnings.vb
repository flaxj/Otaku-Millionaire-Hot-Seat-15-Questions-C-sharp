Public Class Winnings
    Dim winnings As String
    Friend question As Integer

    Private Sub Winnings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If question = 15 Then
            If Q15.TopPrizeAmount.BackColor = Color.Green Then
                winnings = Q15.TopPrizeAmount.Text
            Else
                winnings = Q15.WonSoFar.Text
            End If

            'set Winnings Value at value amount
            Select Case winnings
                Case "¥1,000,000"
                    AmountWon.Text = "¥1,000,000"
                    PlayerScreen.AmountWon.Text = "¥1,000,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥250,000"
                    AmountWon.Text = "¥250,000"
                    PlayerScreen.AmountWon.Text = "¥250,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥100,000"
                    AmountWon.Text = "¥100,000"
                    PlayerScreen.AmountWon.Text = "¥100,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥50,000"
                    AmountWon.Text = "¥50,000"
                    PlayerScreen.AmountWon.Text = "¥50,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥20,000"
                    AmountWon.Text = "¥20,000"
                    PlayerScreen.AmountWon.Text = "¥20,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥10,000"
                    AmountWon.Text = "¥10,000"
                    PlayerScreen.AmountWon.Text = "¥10,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
                Case "¥1,000"
                    AmountWon.Text = "¥1,000"
                    PlayerScreen.AmountWon.Text = "¥1,000"

                    'show the final picture and winnings on player screen
                    PlayerScreen.EndShowLogo.Visible = True
                    PlayerScreen.AmountWon.Visible = True

                    'reset questions
                    PlayerScreen.EndOfGame()
            End Select

            'close Question 15
            Q15.Close()
        Else
            If question > 10 And question < 15 Then
                AmountWon.Text = "¥1,000"
                PlayerScreen.AmountWon.Text = "¥1,000"

                'show the final picture and winnings on player screen
                PlayerScreen.EndShowLogo.Visible = True
                PlayerScreen.AmountWon.Visible = True

                'reset questions
                PlayerScreen.EndOfGame()

                Q14.Close()
                Q13.Close()
                Q12.Close()
                Q11.Close()
            Else
                'show the final picture and winnings on player screen
                PlayerScreen.EndShowLogo.Visible = True
                PlayerScreen.AmountWon.Visible = True

                'reset questions
                PlayerScreen.EndOfGame()

                Q10.Close()
                Q09.Close()
                Q08.Close()
                Q07.Close()
                Q06.Close()
            End If
        End If


        'Play the end of game music
        My.Computer.Audio.Play(My.Resources.End_of_Game, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub EndGame_Click(sender As Object, e As EventArgs) Handles EndGame.Click
        'exit the program
        Application.Exit()
    End Sub

    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show the AboutBox
        AboutBox.Show()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub
End Class