Public Class Level4MoneyTree
    Friend subjects(15) As String 'declare the string array
    Friend FinalGamePlay As String 'declare the FinalGamePlay string
    Friend GPlayersRemaining As Integer 'declare playersRemaining as Integer
    Friend AskFriendCount As Integer 'declare AskFriendCount as Integer
    Friend AskAudienceCount As Integer 'declare AskAudienceCount as Integer
    Friend DoubleDipCount As Integer 'declare DoubleDipCount as Integer
    Dim count As Integer 'set count as Integer

    Private Sub Level4MoneyTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'transfer Friend Varables from Question 14
        GPlayersRemaining = Q14.GPlayersRemaining
        AskFriendCount = Q14.AskFriendCount
        AskAudienceCount = Q14.AskAudienceCount
        DoubleDipCount = Q14.DoubleDipCount

        'play the Final Intro Music
        My.Computer.Audio.Play(My.Resources.FinalAndSecondChanceIntro, AudioPlayMode.Background)

        'perform loadtopics
        loadtopics()

        'show money Tree
        Values()

        'perfrom Lifeline Used
        LifelineUsed()

        'hide Question 14
        Q14.Hide()
    End Sub

    Sub loadtopics()
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
        Topic13.text = subjects(12)
        Topic14.text = subjects(13)
        Topic15.text = subjects(14)
    End Sub

    Sub LifelineUsed()
        'check to see if Ask a Friend is used
        If AskFriendCount = 1 Then
            'hide and disable the Ask a Friend Lifeline
            AskFriendPic.Visible = False
            PlayerScreen.AskFriendPic.Visible = False
        End If

        'check to see if Ask the Audience is used
        If AskAudienceCount = 1 Then
            'hide and disable the Ask a Friend Lifeline
            AskPic.Visible = False
            PlayerScreen.AskPic.Visible = False
        End If

        'check to see if Double Dip is used
        If doubledipcount = 1 Then
            'hide and disable the Double Dip Lifeline
            DoubleDipPic.Visible = False
            PlayerScreen.DoubleDipPic.Visible = False
        End If
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

    Sub Values()
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
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
            Money11.BackColor = Color.Green
            Money11.ForeColor = Color.White
            Money12.BackColor = Color.Green
            Money12.ForeColor = Color.White
            Money13.BackColor = Color.Green
            Money13.ForeColor = Color.White
            Money14.BackColor = Color.Green
            Money14.ForeColor = Color.White
            Money15.BackColor = Color.Green
            Money15.ForeColor = Color.White
            Money13.BackColor = Color.Green
            Money13.ForeColor = Color.White
            Money14.BackColor = Color.Green
            Money14.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
            PlayerScreen.Money11.BackColor = Color.Green
            PlayerScreen.Money11.ForeColor = Color.White
            PlayerScreen.Money12.BackColor = Color.Green
            PlayerScreen.Money12.ForeColor = Color.White
            PlayerScreen.Money13.BackColor = Color.Green
            PlayerScreen.Money13.ForeColor = Color.White
            PlayerScreen.Money14.BackColor = Color.Green
            PlayerScreen.Money14.ForeColor = Color.White
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
            Money05.BackColor = Color.Green
            Money05.ForeColor = Color.White
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
            Money11.BackColor = Color.Green
            Money11.ForeColor = Color.White
            Money12.BackColor = Color.Green
            Money12.ForeColor = Color.White
            Money13.BackColor = Color.Green
            Money13.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
            PlayerScreen.Money11.BackColor = Color.Green
            PlayerScreen.Money11.ForeColor = Color.White
            PlayerScreen.Money12.BackColor = Color.Green
            PlayerScreen.Money12.ForeColor = Color.White
            PlayerScreen.Money13.BackColor = Color.Green
            PlayerScreen.Money13.ForeColor = Color.White
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
            Money04.BackColor = Color.Green
            Money04.ForeColor = Color.White
            Money05.BackColor = Color.Green
            Money05.ForeColor = Color.White
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
            Money11.BackColor = Color.Green
            Money11.ForeColor = Color.White
            Money12.BackColor = Color.Green
            Money12.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
            PlayerScreen.Money11.BackColor = Color.Green
            PlayerScreen.Money11.ForeColor = Color.White
            PlayerScreen.Money12.BackColor = Color.Green
            PlayerScreen.Money12.ForeColor = Color.White
        ElseIf GPlayersRemaining = 3 Then
            'hide the Million, ¥250,000, and ¥100,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False

            'final question color
            Money15.BackColor = Color.Gold
            PlayerScreen.Money12.BackColor = Color.Gold
            Money15.ForeColor = Color.White
            PlayerScreen.Money12.ForeColor = Color.White

            'Green the correct answers
            Money01.ForeColor = Color.White
            Money05.BackColor = Color.Green
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            Money03.BackColor = Color.Green
            Money03.ForeColor = Color.White
            Money04.BackColor = Color.Green
            Money04.ForeColor = Color.White
            Money05.ForeColor = Color.White
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
            Money11.BackColor = Color.Green
            Money11.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
            PlayerScreen.Money11.BackColor = Color.Green
            PlayerScreen.Money11.ForeColor = Color.White
        ElseIf GPlayersRemaining = 2 Then
            'hide the Million, ¥250,000, ¥100,000, and ¥50,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            Money15.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False
            PlayerScreen.Money12.Visible = False

            'final question color
            Money14.BackColor = Color.Gold
            PlayerScreen.Money11.BackColor = Color.Gold
            Money14.ForeColor = Color.White
            PlayerScreen.Money11.ForeColor = Color.White

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
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
        Else
            'hide the Million, ¥250,000, ¥100,000, ¥50,000, and ¥20,000
            Money15.Visible = False
            Money14.Visible = False
            Money13.Visible = False
            Money15.Visible = False
            Money14.Visible = False
            PlayerScreen.Money15.Visible = False
            PlayerScreen.Money14.Visible = False
            PlayerScreen.Money13.Visible = False
            PlayerScreen.Money12.Visible = False
            PlayerScreen.Money11.Visible = False

            'final question color
            Money13.BackColor = Color.Gold
            PlayerScreen.Money10.BackColor = Color.Gold
            Money13.ForeColor = Color.White
            PlayerScreen.Money10.ForeColor = Color.White

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
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
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
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
        End If
    End Sub

    Sub ShowTopics()
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
        Topic13.visible = True
        Topic14.visible = True
        Topic15.visible = True
    End Sub

    Sub HideValue()
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
        Money13.visible = False
        Money14.Visible = False
        Money15.Visible = False
    End Sub

    Sub HideTopics()
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
        Topic15.visible = False
    End Sub

    Private Sub Transition_Click(sender As Object, e As EventArgs) Handles Transition.Click
        'show the count file
        Select Case count
            Case 2
                If Money14.Visible = True Then
                    'show second chance button
                    btnSecondChance.Visible = True
                Else
                    Exit Select
                End If
            Case 3
                'show the Level 4 Rules
                Level4Label.Visible = True
                Level4Rules.Visible = True

                'show the Final question Button
                ResumeGame.Visible = True

                'hide the TransitionButton
                Transition.Visible = False
        End Select

        'add one to count
        count += 1
    End Sub

    Private Sub ResumeGame_Click(sender As Object, e As EventArgs) Handles ResumeGame.Click
        'start the game on the player side
        PlayerScreen.StartandResumeGame()

        'open Question 15
        Q15.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub

    Private Sub btnSecondChance_Click(sender As Object, e As EventArgs) Handles btnSecondChance.Click
        If Money15.Visible = True Then
            'show Money12 as ¥2,000,000
            Money15.Text = "¥2,000,000"
            PlayerScreen.Money15.Text = "¥2,000,000"
        Else
            'show Money15
            Money15.Visible = True
            PlayerScreen.Money15.Visible = True
        End If

        'hide the other lifelines
        AskPic.Visible = False
        PlayerScreen.AskPic.Visible = False
        AskFriendPic.Visible = False
        PlayerScreen.AskFriendPic.Visible = False
        DoubleDipPic.Visible = False
        PlayerScreen.DoubleDipPic.Visible = False

        'display count to 4
        count = 4
    End Sub
End Class