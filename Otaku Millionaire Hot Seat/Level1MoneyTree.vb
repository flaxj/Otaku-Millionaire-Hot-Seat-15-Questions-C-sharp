Public Class Level1MoneyTree
    Friend subjects(15) As String 'declare the string array
    Friend questionsAsked As Integer = 0 'declare the questionsAsked as Integer
    Dim count As Integer 'set count as Integer
    Dim time As Integer 'set time as integer

    Private Sub Level1MoneyTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'perform LoadTopics
        Loadtopics()
    End Sub

    Public Sub Loadtopics()
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
                'show money tree
                Values()
                PlayerScreen.Values()

                'change show money tree box text to start money tree
                ShowMoneyTree.Text = "Start Money Tree"
            Case 1
                'big color tree change
                BigColorTreeClock()

                'disable ShowMoneyTree
                ShowMoneyTree.Enabled = False
            Case 2
                'show topics
                ShowTopics()
                PlayerScreen.ShowTopics()

                'change show money tree box text to hide topics
                ShowMoneyTree.Text = "Hide Topics"
            Case 3
                'hide topics
                HideTopics()
                PlayerScreen.HideTopics()

                'show money Tree
                Values()
                PlayerScreen.Values()

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
    End Sub

    Public Sub BigColorTreeClock()
        'start the clock
        MoneyTreeClock.Start()
    End Sub

    Private Sub MoneyTreeClock_Tick(sender As Object, e As EventArgs) Handles MoneyTreeClock.Tick
        'add one to time
        time += 1

        'check to see if the time is 31
        If time = 31 Then
            'reset Money Tree Sub
            ResetMoneyTree()
            PlayerScreen.ResetMoneyTree()
        Else
            'perform big Color Money Tree Change
            BigColorTreeChange()
        End If
    End Sub

    Public Sub BigColorTreeChange()
        'change the tree color
        If time = 1 Then
            'change the first money value
            Money01.BackColor = Color.Green
            Money01.ForeColor = Color.White
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White
        ElseIf time = 2 Then
            'change the second money value
            Money02.BackColor = Color.Green
            Money02.ForeColor = Color.White
            PlayerScreen.Money02.BackColor = Color.Green
            PlayerScreen.Money02.ForeColor = Color.White
        ElseIf time = 3 Then
            'change the third money value
            Money03.BackColor = Color.Green
            Money03.ForeColor = Color.White
            PlayerScreen.Money03.BackColor = Color.Green
            PlayerScreen.Money03.ForeColor = Color.White
        ElseIf time = 4 Then
            'change the first money value
            Money04.BackColor = Color.Green
            Money04.ForeColor = Color.White
            PlayerScreen.Money04.BackColor = Color.Green
            PlayerScreen.Money04.ForeColor = Color.White
        ElseIf time = 5 Then
            'change the second money value
            Money05.BackColor = Color.Green
            Money05.ForeColor = Color.White
            PlayerScreen.Money05.BackColor = Color.Green
            PlayerScreen.Money05.ForeColor = Color.White
        ElseIf time = 6 Then
            'change the third money value
            Money06.BackColor = Color.Green
            Money06.ForeColor = Color.White
            PlayerScreen.Money06.BackColor = Color.Green
            PlayerScreen.Money06.ForeColor = Color.White
        ElseIf time = 7 Then
            'change the first money value
            Money07.BackColor = Color.Green
            Money07.ForeColor = Color.White
            PlayerScreen.Money07.BackColor = Color.Green
            PlayerScreen.Money07.ForeColor = Color.White
        ElseIf time = 8 Then
            'change the second money value
            Money08.BackColor = Color.Green
            Money08.ForeColor = Color.White
            PlayerScreen.Money08.BackColor = Color.Green
            PlayerScreen.Money08.ForeColor = Color.White
        ElseIf time = 9 Then
            'change the third money value
            Money09.BackColor = Color.Green
            Money09.ForeColor = Color.White
            PlayerScreen.Money09.BackColor = Color.Green
            PlayerScreen.Money09.ForeColor = Color.White
        ElseIf time = 10 Then
            'change the first money value
            Money10.BackColor = Color.Green
            Money10.ForeColor = Color.White
            PlayerScreen.Money10.BackColor = Color.Green
            PlayerScreen.Money10.ForeColor = Color.White
        ElseIf time = 11 Then
            'change the second money value
            Money11.BackColor = Color.Green
            Money11.ForeColor = Color.White
            PlayerScreen.Money11.BackColor = Color.Green
            PlayerScreen.Money11.ForeColor = Color.White
        ElseIf time = 12 Then
            'change the third money value
            Money12.BackColor = Color.Green
            Money12.ForeColor = Color.White
            PlayerScreen.Money12.BackColor = Color.Green
            PlayerScreen.Money12.ForeColor = Color.White
        ElseIf time = 13 Then
            'change the first money value
            Money13.BackColor = Color.Green
            Money13.ForeColor = Color.White
            PlayerScreen.Money13.BackColor = Color.Green
            PlayerScreen.Money13.ForeColor = Color.White
        ElseIf time = 14 Then
            'change the second money value
            Money14.BackColor = Color.Green
            Money14.ForeColor = Color.White
            PlayerScreen.Money14.BackColor = Color.Green
            PlayerScreen.Money14.ForeColor = Color.White
        ElseIf time = 15 Then
            'change the jackpot money value to green
            Money15.BackColor = Color.Green
            Money15.ForeColor = Color.White
            PlayerScreen.Money15.BackColor = Color.Green
            PlayerScreen.Money15.ForeColor = Color.White
        ElseIf time = 16 Or time = 18 Or time = 20 Or time = 22 Or time = 24 Or time = 26 Or time = 28 Or time = 30 Then
            'change the jackpot money value to orange
            Money15.BackColor = Color.Orange
            Money15.ForeColor = Color.Black
            PlayerScreen.Money15.BackColor = Color.Orange
            PlayerScreen.Money15.ForeColor = Color.Black
        Else
            'change the jackpot money value to green
            Money15.BackColor = Color.Green
            Money15.ForeColor = Color.White
            PlayerScreen.Money15.BackColor = Color.Green
            PlayerScreen.Money15.ForeColor = Color.White
        End If
    End Sub

    Public Sub ResetMoneyTree()
        'reset the money tree
        Money01.BackColor = DefaultBackColor
        Money01.ForeColor = DefaultForeColor
        Money02.BackColor = DefaultBackColor
        Money02.ForeColor = DefaultForeColor
        Money03.BackColor = DefaultBackColor
        Money03.ForeColor = DefaultForeColor
        Money04.BackColor = DefaultBackColor
        Money04.ForeColor = DefaultForeColor
        Money05.BackColor = DefaultBackColor
        Money05.ForeColor = DefaultForeColor
        Money06.BackColor = DefaultBackColor
        Money06.ForeColor = DefaultForeColor
        Money07.BackColor = DefaultBackColor
        Money07.ForeColor = DefaultForeColor
        Money08.BackColor = DefaultBackColor
        Money08.ForeColor = DefaultForeColor
        Money09.BackColor = DefaultBackColor
        Money09.ForeColor = DefaultForeColor
        Money10.BackColor = DefaultBackColor
        Money10.ForeColor = DefaultForeColor
        Money11.BackColor = DefaultBackColor
        Money11.ForeColor = DefaultForeColor
        Money12.BackColor = DefaultBackColor
        Money12.ForeColor = DefaultForeColor
        Money13.BackColor = DefaultBackColor
        Money13.ForeColor = DefaultForeColor
        Money14.BackColor = DefaultBackColor
        Money14.ForeColor = DefaultForeColor
        Money15.BackColor = DefaultBackColor
        Money15.ForeColor = DefaultForeColor

        If time = 31 Then
            'stop the clock
            MoneyTreeClock.Stop()

            'change show money tree box text to show topics
            ShowMoneyTree.Text = "Show Topics"

            'enable the ShowMoneyTree box
            ShowMoneyTree.Enabled = True
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
        Topic13.Visible = True
        Topic14.Visible = True
        Topic15.Visible = True
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
        Topic15.Visible = False
    End Sub

    Private Sub Transition_Click(sender As Object, e As EventArgs) Handles Transition.Click
        'show the count file
        Select Case count
            Case 4
                'show the pass lifeline
                PassPic.Visible = True
                PlayerScreen.PassPic.Visible = True
            Case 5
                'level Two lifelines
                LevelTwoLifelines()
                PlayerScreen.LevelTwoLifelines()
            Case 6
                'show the Ask a Friend Lifeline
                AskFriendPic.Visible = True
                PlayerScreen.AskFriendPic.Visible = True
            Case 7
                'show the Trust the Computer lifeline
                TrustPic.Visible = True
                PlayerScreen.TrustPic.Visible = True
            Case 8
                'show the double dip lifeline
                DoubleDipPic.Visible = True
                PlayerScreen.DoubleDipPic.Visible = True
            Case 9
                'final five questions color
                LevelThreeLifelines()
                PlayerScreen.LevelThreeLifelines()
            Case 10
                'hide Pass
                PassPic.Visible = False
                PlayerScreen.PassPic.Visible = False

                'show the ask the audience lifeline
                AskPic.Visible = True
                PlayerScreen.AskPic.Visible = True
            Case 11
                'level 4 question color
                Money15.BackColor = Color.Gold
                PlayerScreen.Money15.BackColor = Color.Gold
            Case 12
                'hide all other Lifelines
                AskFriendPic.Visible = False
                AskPic.Visible = False
                TrustPic.Visible = False
                DoubleDipPic.Visible = False
                PlayerScreen.DoubleDipPic.Visible = False
                PlayerScreen.AskFriendPic.Visible = False
                PlayerScreen.AskPic.Visible = False
                PlayerScreen.TrustPic.Visible = False
            Case 13
                'show the first detail label
                MainDetail1.Visible = True
            Case 14
                'perform reset money tree
                ResetMoneyTree()
                PlayerScreen.ResetMoneyTree()

                'show Pass
                PassPic.Visible = True
                PlayerScreen.PassPic.Visible = True

                'display Level 1 Rules
                Level1Label.Visible = True
                Level1Rules.Visible = True

                'hide the Transition button
                Transition.Visible = False

                'show the start game button
                StartGame.Visible = True
        End Select

        'add one to count
        count += 1
    End Sub

    Sub LevelTwoLifelines()
        'change the background of the final ten questions
        Money06.BackColor = Color.Yellow
        Money07.BackColor = Color.Yellow
        Money08.BackColor = Color.Yellow
        Money09.BackColor = Color.Yellow
        Money10.BackColor = Color.Yellow
        Money11.BackColor = Color.Yellow
        Money12.BackColor = Color.Yellow
        Money13.BackColor = Color.Yellow
        Money14.BackColor = Color.Yellow
        Money15.BackColor = Color.Yellow
    End Sub

    Sub FirstFiveCorrect()
        'show the first five correct answers in green
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
    End Sub

    Sub LevelThreeLifelines()
        'change the background of the final five questions
        Money11.BackColor = Color.Orange
        Money12.BackColor = Color.Orange
        Money13.BackColor = Color.Orange
        Money14.BackColor = Color.Orange
        Money15.BackColor = Color.Orange
    End Sub

    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click
        'open Question 1
        Q01.Show()

        'start the game on the player side
        PlayerScreen.StartandResumeGame()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'end program
        End
    End Sub
End Class