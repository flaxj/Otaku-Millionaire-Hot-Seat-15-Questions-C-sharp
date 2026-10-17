Public Class Level2MoneyTree
    Friend subjects(15) As String 'declare the string array
    Friend GPlayersRemaining As Integer 'declare playersRemaining as Integer
    Friend passUsage As Integer 'declare passUsage as Integer
    Dim count As Integer 'set count as Integer

    Private Sub Level2MoneyTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'transfer Friend Varables from Question 5
        GPlayersRemaining = Q05.GPlayersRemaining
        passUsage = Q05.passUsage

        'perform loadtopics
        Loadtopics()

        'show money Tree
        Values()

        'hide Question 5
        Q05.Hide()
    End Sub

    Sub Loadtopics()
        'load the topics into the money tree
        Topic01.Text = subjects(0)
        Topic02.Text = subjects(1)
        Topic03.Text = subjects(2)
        Topic04.Text = subjects(3)
        Topic05.Text = subjects(4)
        Topic06.Text = subjects(5)
        Topic07.Text = subjects(6)
        Topic08.Text = subjects(7)
        Topic09.Text = subjects(8)
        Topic10.Text = subjects(9)
        Topic11.Text = subjects(10)
        Topic12.Text = subjects(11)
        Topic13.Text = subjects(12)
        Topic14.Text = subjects(13)
        Topic15.Text = subjects(14)
    End Sub

    Private Sub ShowMoneyTree_Click(sender As Object, e As EventArgs) Handles ShowMoneyTree.Click
        'show the count file
        Select Case count
            Case 0
                'show topics
                ShowTopics()
                PlayerScreen.ShowTopics()

                'change show money tree box text to hide topics
                ShowMoneyTree.Text = "Hide Topics"
            Case 1
                'hide topics
                HideTopics()
                PlayerScreen.HideTopics()

                'show money Tree
                Values()

                'show Lifeline button
                Transition.Visible = True

                'hide the money tree button
                ShowMoneyTree.Visible = False
        End Select

        'add one to count
        count += 1
    End Sub

    Public Sub Values()
        'show the money tree
        Money01.Visible = True
        Money02.Visible = True
        Money03.Visible = True
        Money04.Visible = True
        Money05.Visible = True
        Money06.Visible = True
        Money07.Visible = True
        Money08.Visible = True
        Money09.Visible = True
        Money10.Visible = True
        Money11.Visible = True
        Money12.Visible = True
        Money13.Visible = True
        Money14.Visible = True
        Money15.Visible = True

        'show money Tree on PlayerScreen
        PlayerScreen.Values()

        If GPlayersRemaining = 6 Then
            'Green the correct answers
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            Money03.BackColor = Color.Green
            Money03.ForeColor = Color.White
            Money04.BackColor = Color.Green
            Money04.ForeColor = Color.White
            Money05.BackColor = Color.Green
            Money05.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
            PlayerScreen.Money02.BackColor = Color.Green
            PlayerScreen.Money02.ForeColor = Color.White
            PlayerScreen.Money03.BackColor = Color.Green
            PlayerScreen.Money03.ForeColor = Color.White
            PlayerScreen.Money04.BackColor = Color.Green
            PlayerScreen.Money04.ForeColor = Color.White
            PlayerScreen.Money05.BackColor = Color.Green
            PlayerScreen.Money05.ForeColor = Color.White
        ElseIf GPlayersRemaining = 5 Then
            'hide the Million
            Money15.Visible = False
            PlayerScreen.Money15.Visible = False

            'final question color
            Money14.BackColor = Color.Gold
            PlayerScreen.Money14.BackColor = Color.Gold
            Money14.ForeColor = Color.White
            PlayerScreen.Money14.ForeColor = Color.White

            'Green the correct answers
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            Money03.BackColor = Color.Green
            Money03.ForeColor = Color.White
            Money04.BackColor = Color.Green
            Money04.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
            PlayerScreen.Money02.BackColor = Color.Green
            PlayerScreen.Money02.ForeColor = Color.White
            PlayerScreen.Money03.BackColor = Color.Green
            PlayerScreen.Money03.ForeColor = Color.White
            PlayerScreen.Money04.BackColor = Color.Green
            PlayerScreen.Money04.ForeColor = Color.White
        ElseIf GPlayersRemaining = 4 Then
            'hide the Million and ¥250,000
            Money15.Visible = False
            Money14.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False

            'final question color
            Money13.BackColor = Color.Gold
            PlayerScreen.Money13.BackColor = Color.Gold
            Money13.ForeColor = Color.White
            PlayerScreen.Money13.ForeColor = Color.White

            'Green the correct answers
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            Money03.BackColor = Color.Green
            Money03.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
            PlayerScreen.Money02.BackColor = Color.Green
            PlayerScreen.Money02.ForeColor = Color.White
            PlayerScreen.Money03.BackColor = Color.Green
            PlayerScreen.Money03.ForeColor = Color.White
        ElseIf GPlayersRemaining = 3 Then
            'hide the Million, ¥250,000, and ¥100,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False

            'final question color
            Money12.BackColor = Color.Gold
            PlayerScreen.Money12.BackColor = Color.Gold
            Money12.ForeColor = Color.White
            PlayerScreen.Money12.ForeColor = Color.White

            'Green the correct answers
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
            PlayerScreen.Money02.BackColor = Color.Green
            PlayerScreen.Money02.ForeColor = Color.White
        ElseIf GPlayersRemaining = 2 Then
            'hide the Million, ¥250,000, ¥100,000, and ¥50,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            Money12.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False
            PlayerScreen.Money12.Visible = False

            'final question color
            Money11.BackColor = Color.Gold
            PlayerScreen.Money11.BackColor = Color.Gold
            Money11.ForeColor = Color.White
            PlayerScreen.Money11.ForeColor = Color.White

            'Green the correct answers
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
        ElseIf GPlayersRemaining = 1 Then
            'hide the Million, ¥250,000, ¥100,000, ¥50,000, and ¥20,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            Money12.Visible = False
            Money11.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False
            PlayerScreen.Money12.Visible = False
            PlayerScreen.Money11.Visible = False

            'final question color
            Money10.BackColor = Color.Gold
            PlayerScreen.Money10.BackColor = Color.Gold
            Money10.ForeColor = Color.White
            PlayerScreen.Money10.ForeColor = Color.White
        End If
    End Sub

    Public Sub ShowTopics()
        'perform Hide Values
        HideValue()

        'Show the Topics
        Topic01.Visible = True
        Topic02.Visible = True
        Topic03.Visible = True
        Topic04.Visible = True
        Topic05.Visible = True
        Topic06.Visible = True
        Topic07.Visible = True
        Topic08.Visible = True
        Topic09.Visible = True
        Topic10.Visible = True
        Topic11.Visible = True
        Topic12.Visible = True
        Topic13.Visible = True
        Topic14.Visible = True
        Topic15.Visible = True
    End Sub

    Public Sub HideValue()
        'Hide the money tree
        Money01.Visible = False
        Money02.Visible = False
        Money03.Visible = False
        Money04.Visible = False
        Money05.Visible = False
        Money06.Visible = False
        Money07.Visible = False
        Money08.Visible = False
        Money09.Visible = False
        Money10.Visible = False
        Money11.Visible = False
        Money12.Visible = False
        Money13.Visible = False
        Money14.Visible = False
        Money15.Visible = False
    End Sub

    Public Sub HideTopics()
        'hide the Topics
        Topic01.Visible = False
        Topic02.Visible = False
        Topic03.Visible = False
        Topic04.Visible = False
        Topic05.Visible = False
        Topic06.Visible = False
        Topic07.Visible = False
        Topic08.Visible = False
        Topic09.Visible = False
        Topic10.Visible = False
        Topic11.Visible = False
        Topic12.Visible = False
        Topic13.Visible = False
        Topic14.Visible = False
        Topic15.Visible = False
    End Sub

    Private Sub Transition_Click(sender As Object, e As EventArgs) Handles Transition.Click
        'show the count file
        Select Case count
            Case 2
                'show the Ask a Friend Lifeline
                AskFriendPic.Visible = True
                PlayerScreen.AskFriendPic.Visible = True
            Case 3
                'show the Double Dip Lifeline
                TrustPic.Visible = True
                PlayerScreen.TrustPic.Visible = True
            Case 4
                'show the Double Dip Lifeline
                DoubleDipPic.Visible = True
                PlayerScreen.DoubleDipPic.Visible = True
            Case 5
                'play the next level music
                My.Computer.Audio.Play(My.Resources.LevelTransitionMusic, AudioPlayMode.Background)

                'show the Level 2 Rules
                Level2Label.Visible = True
                Level2Rules.Visible = True

                'show the ResumeGame Button
                ResumeGame.Visible = True

                'hide the Transition Button
                Transition.Visible = False
        End Select

        'add one to count
        count += 1
    End Sub

    Private Sub ResumeGame_Click(sender As Object, e As EventArgs) Handles ResumeGame.Click
        'play the transition music
        My.Computer.Audio.Play(My.Resources.LevelTransitionMusic, AudioPlayMode.Background)

        'start the game on the player side
        PlayerScreen.StartandResumeGame()

        'open Question 6
        Q06.Show()

        'close the Double Dip Details
        Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub
End Class