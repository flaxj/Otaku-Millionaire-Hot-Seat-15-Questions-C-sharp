Public Class EnterHost
    Dim count As Integer 'declare count as Integer

    Private Sub Transition_Click(sender As Object, e As EventArgs) Handles Transition.Click
        Select Case count
            Case 0
                'play the music
                My.Computer.Audio.Play(My.Resources.contestentIntro, AudioPlayMode.Background)

                'transition text to first player in
                Transition.Text = "First Player In"
            Case 1
                'play the next player in music
                My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                'transition text to Show Level1MoneyTree
                Transition.Text = "Show Level 1 Money Tree"
            Case 2
                'open the Level 1 Money Tree
                Level1MoneyTree.Show()

                'hide show logo
                PlayerScreen.ShowLogo.Visible = False

                'close the Host Introduction Window
                Close()
        End Select

        'add one to count
        count += 1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub
End Class