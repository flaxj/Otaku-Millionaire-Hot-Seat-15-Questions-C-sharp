Public Class Q01
    Friend Q1GamePlay(13) As String 'declare gameplay as string
    Friend GPlayersRemaining As Integer = 6 'declare GPlayersRemaining as Integer
    Friend GPlayerNumber As Integer = 1 'declare GPlayerNumber as Integer
    Friend questionsRemaining As Integer = 12 'declare questionsRemaining as Integer
    Friend SHQuestionsRemaining As Integer = 5 'declare safeHavenQuestionsRemaining as Integer
    Friend passUsage As Integer 'declare passUsage as Integer
    Friend TimeSeconds As Integer = 15 'declare TimeSeconds as Integer
    Friend TimeTenths As Integer = 0 'declare TimeTenths as Integer
    Dim choice As String 'set choice as string
    Dim answer As String 'set answer as string
    Dim CountA As Integer 'declare CountA as Integer
    Dim CountB As Integer 'declare CountB as Integer
    Dim CountC As Integer 'declare CountC as Integer
    Dim CountD As Integer 'declare CountD as Integer
    Dim ButtonCount As Integer 'declare ButtonCount as Integer
    Dim passcount As Integer 'declare passcount as Integer

    Private Sub Q01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'show PlayerScreen game screen
        PlayerScreen.Topic.Visible = True
            PlayerScreen.Seconds.Visible = True
            PlayerScreen.Placeholder.Visible = True
            PlayerScreen.Tenths.Visible = True
            PlayerScreen.QuestionValue.Visible = True

        'perform question loading
        QuestionLoading()

        'close the Level 1 Money Tree
        Level1MoneyTree.Close()

        'loadup the startGame Music
        My.Computer.Audio.Play(My.Resources.StartGame, AudioPlayMode.Background)
    End Sub

    Public Sub QuestionLoading()
        'set the top prize, topic, question, and choices
        'TopPrizeAmount.Text = PlayerScreen.Money12.Text
        Topic.Text = Q1GamePlay(0)
        Question1.Text = Q1GamePlay(1)
        Question2.Text = Q1GamePlay(2)
        Question3.Text = Q1GamePlay(3)
        ChoiceA.Text = Q1GamePlay(4)
        ChoiceB.Text = Q1GamePlay(5)
        ChoiceC.Text = Q1GamePlay(6)
        ChoiceD.Text = Q1GamePlay(7)
        PlayerScreen.Topic.Text = Q1GamePlay(0)
        PlayerScreen.question(0) = Q1GamePlay(1)
        PlayerScreen.question(1) = Q1GamePlay(2)
        PlayerScreen.question(2) = Q1GamePlay(3)
        PlayerScreen.question(3) = Q1GamePlay(4)
        PlayerScreen.question(4) = Q1GamePlay(5)
        PlayerScreen.question(5) = Q1GamePlay(6)
        PlayerScreen.question(6) = Q1GamePlay(7)

        'load the question on the PlayerScreen
        PlayerScreen.QuestionLoader()

        'set the answer
        answer = Q1GamePlay(8)

        'convert the choice text numbers
        CountA = CInt(Q1GamePlay(9))
        CountB = CInt(Q1GamePlay(10))
        CountC = CInt(Q1GamePlay(11))
        CountD = CInt(Q1GamePlay(12))

        If CountA >= 30 Then
            'change Font Size to 18
            ChoiceA.Font = New Font(ChoiceA.Font.FontFamily, 18)
            PlayerScreen.ChoiceA.Font = New Font(PlayerScreen.ChoiceA.Font.FontFamily, 18)
        End If

        If CountB >= 30 Then
            'change Font Size to 18
            ChoiceB.Font = New Font(ChoiceB.Font.FontFamily, 18)
            PlayerScreen.ChoiceB.Font = New Font(PlayerScreen.ChoiceB.Font.FontFamily, 18)
        End If

        If CountC >= 30 Then
            'change Font Size to 18
            ChoiceC.Font = New Font(ChoiceC.Font.FontFamily, 18)
            PlayerScreen.ChoiceC.Font = New Font(PlayerScreen.ChoiceC.Font.FontFamily, 18)
        End If

        If CountD >= 30 Then
            'change Font Size to 18
            ChoiceD.Font = New Font(ChoiceD.Font.FontFamily, 18)
            PlayerScreen.ChoiceD.Font = New Font(PlayerScreen.ChoiceD.Font.FontFamily, 18)
        End If
    End Sub

    Private Sub MasterButton_Click(sender As Object, e As EventArgs) Handles MasterButton.Click
        Select Case ButtonCount
            Case 0
                'start Level1 Music
                My.Computer.Audio.Play(My.Resources.Level1QuestionMusic, AudioPlayMode.BackgroundLoop)

                'show the question lables
                Question1.Visible = True
                Question2.Visible = True
                Question3.Visible = True

                'perform show questions
                PlayerScreen.ShowQuestions()

                'show the button next action
                MasterButton.Text = "Show Choices"
            Case 1
                'show the choices
                ChoiceA.Visible = True
                ChoiceB.Visible = True
                ChoiceC.Visible = True
                ChoiceD.Visible = True

                'perform show answers
                PlayerScreen.ShowChoices()

                'start the clock
                SecondsClock.Start()
                TenthsClock.Start()

                'enable Pass button and disable the MasterButton
                MasterButton.Enabled = False

                'show the MasterButton Next Action
                MasterButton.Text = "Answer"
            Case 2
                'perform questionResult
                QuestionResult()

                'show if correct is the answer
                If Correct.Visible = True Or choice = answer Then
                    'take away one from safe haven
                    SHQuestionsRemaining -= 1
                    SafeHavenQuestionsRemaining.Text = CStr(SHQuestionsRemaining)

                    'play level1 correct music
                    My.Computer.Audio.Play(My.Resources.Level1Correct, AudioPlayMode.Background)

                    'show the pass Lifeline Picture
                    PassPic.Visible = True
                    PlayerScreen.PassPic.Visible = True
                Else
                    'take one from GPlayersRemaining
                    GPlayersRemaining -= 1
                    PlayerScreen.Players -= 1

                    'play level1 incorrect music
                    My.Computer.Audio.Play(My.Resources.Level1Wrong, AudioPlayMode.Background)

                    'take away one from players
                    PlayersRemaining.Text = CStr(GPlayersRemaining)
                End If
            Case 3
                'reset questions
                PlayerScreen.ResetQuestionArea()

                'start Level1 Music
                My.Computer.Audio.Play(My.Resources.Level1QuestionMusic, AudioPlayMode.BackgroundLoop)

                'check if incorrect is visible
                If Incorrect.Visible = True Then
                    'set top prize amount
                    TopPrizeAmount.Text = "¥250,000"

                    'set new risk value to ¥150,000
                    AmountAtRisk.Text = "¥150,000"

                    'show the pass Lifeline Picture
                    PassPic.Visible = True
                    PlayerScreen.PassPic.Visible = True
                Else
                    'reset questions
                    PlayerScreen.ResetQuestionArea()

                    'open the second question
                    Q02.Show()
                End If
            Case 4
                'open the second question
                Q02.Show()
        End Select

        'add one to ButtonCount
        ButtonCount += 1
    End Sub

    Private Sub TenthsClock_Tick(sender As Object, e As EventArgs) Handles TenthsClock.Tick
        'take one away from seconds
        If TimeTenths = 0 Then
            If TimeSeconds = 15 Then
                'take away one from seconds
                TimeSeconds -= 1
                Seconds.Text = CStr(TimeSeconds)
                PlayerScreen.Seconds.Text = Seconds.Text

                'reset tenths text to 9
                TimeTenths = 9
                Tenths.Text = CStr(TimeTenths)
                PlayerScreen.Tenths.Text = Tenths.Text
            ElseIf TimeSeconds = 0 Then
                'stop the clock
                TenthsClock.Stop()
                SecondsClock.Stop()

                If PassPic.Visible = False Then
                    'show the incorrect label
                    Incorrect.Visible = True

                    'enable MasterButton
                    MasterButton.Enabled = True
                End If
            End If
        Else
            'take one away from tenths
            TimeTenths -= 1
            Tenths.Text = CStr(TimeTenths)
            PlayerScreen.Tenths.Text = Tenths.Text
        End If

        'second check for background
        If TimeSeconds >= 10 And TimeSeconds < 15 Then
            'change the clock background to yellow
            Seconds.BackColor = Color.Yellow
            Placeholder.BackColor = Color.Yellow
            Tenths.BackColor = Color.Yellow
            PlayerScreen.Seconds.BackColor = Color.Yellow
            PlayerScreen.Placeholder.BackColor = Color.Yellow
            PlayerScreen.Tenths.BackColor = Color.Yellow
        ElseIf TimeSeconds >= 5 And TimeSeconds < 10 Then
            'change the clock background to Orange
            Seconds.BackColor = Color.Orange
            Placeholder.BackColor = Color.Orange
            Tenths.BackColor = Color.Orange
            PlayerScreen.Seconds.BackColor = Color.Orange
            PlayerScreen.Placeholder.BackColor = Color.Orange
            PlayerScreen.Tenths.BackColor = Color.Orange
        ElseIf TimeSeconds < 5 Then
            'change the clock background to red
            Seconds.BackColor = Color.Red
            Seconds.ForeColor = Color.White
            Placeholder.BackColor = Color.Red
            Placeholder.ForeColor = Color.White
            Tenths.BackColor = Color.Red
            Tenths.ForeColor = Color.White
            PlayerScreen.Seconds.BackColor = Color.Red
            PlayerScreen.Seconds.ForeColor = Color.White
            PlayerScreen.Placeholder.BackColor = Color.Red
            PlayerScreen.Placeholder.ForeColor = Color.White
            PlayerScreen.Tenths.BackColor = Color.Red
            PlayerScreen.Tenths.ForeColor = Color.White
        End If
    End Sub

    Private Sub SecondsClock_Tick(sender As Object, e As EventArgs) Handles SecondsClock.Tick
        If TimeSeconds = 0 Then
            'stop the seconds clock
            SecondsClock.Stop()
        Else
            'take away one from seconds
            TimeSeconds -= 1
            Seconds.Text = CStr(TimeSeconds)
            PlayerScreen.Seconds.Text = Seconds.Text

            'reset tenths text to 9
            TimeTenths = 9
            Tenths.Text = CStr(TimeTenths)
            PlayerScreen.Tenths.Text = Tenths.Text
        End If
    End Sub

    Private Sub ChoiceA_CheckedChanged(sender As Object, e As EventArgs) Handles ChoiceA.CheckedChanged
        'set choice to A
        choice = ChoiceA.Text

        'perform Final Answer
        FinalAnswer()
    End Sub

    Private Sub ChoiceB_CheckedChanged(sender As Object, e As EventArgs) Handles ChoiceB.CheckedChanged
        'set choice to B
        choice = ChoiceB.Text

        'perform Final Answer
        FinalAnswer()
    End Sub

    Private Sub ChoiceC_CheckedChanged(sender As Object, e As EventArgs) Handles ChoiceC.CheckedChanged
        'set choice to c
        choice = ChoiceC.Text

        'perform Final Answer
        FinalAnswer()
    End Sub

    Private Sub ChoiceD_CheckedChanged(sender As Object, e As EventArgs) Handles ChoiceD.CheckedChanged
        'set choice to d
        choice = ChoiceD.Text

        'perform Final Answer
        FinalAnswer()
    End Sub

    Public Sub FinalAnswer()
        'stop clock
        TenthsClock.Stop()
        SecondsClock.Stop()

        'change background to orange
        Select Case choice
            Case ChoiceA.Text
                ChoiceA.BackColor = Color.Orange
                PlayerScreen.ChoiceA.BackColor = Color.Orange
            Case ChoiceB.Text
                ChoiceB.BackColor = Color.Orange
                PlayerScreen.ChoiceB.BackColor = Color.Orange
            Case ChoiceC.Text
                ChoiceC.BackColor = Color.Orange
                PlayerScreen.ChoiceC.BackColor = Color.Orange
            Case ChoiceD.Text
                ChoiceD.BackColor = Color.Orange
                PlayerScreen.ChoiceD.BackColor = Color.Orange
        End Select

        'show the result
        If choice = answer Then
            'show the correct label
            Correct.Visible = True
        Else
            'show the incorrect label
            Incorrect.Visible = True

            Select Case answer
                Case ChoiceA.Text
                    ChoiceA.BackColor = Color.Green
                    ChoiceA.ForeColor = Color.White
                Case ChoiceB.Text
                    ChoiceB.BackColor = Color.Green
                    ChoiceB.ForeColor = Color.White
                Case ChoiceC.Text
                    ChoiceC.BackColor = Color.Green
                    ChoiceC.ForeColor = Color.White
                Case ChoiceD.Text
                    ChoiceD.BackColor = Color.Green
                    ChoiceD.ForeColor = Color.White
            End Select
        End If

        'disable the pass button and reenable the MasterButton
        MasterButton.Enabled = True
    End Sub

    Public Sub QuestionResult()
        'take one away from questions
        questionsRemaining -= 1
        TopPrizeQuestionRemaining.Text = CStr(questionsRemaining)

        'show the color answer
        Select Case answer
            Case ChoiceA.Text
                ChoiceA.BackColor = Color.Green
                ChoiceA.ForeColor = Color.White
                PlayerScreen.ChoiceA.BackColor = Color.Green
                PlayerScreen.ChoiceA.ForeColor = Color.White
            Case ChoiceB.Text
                ChoiceB.BackColor = Color.Green
                ChoiceB.ForeColor = Color.White
                PlayerScreen.ChoiceB.BackColor = Color.Green
                PlayerScreen.ChoiceB.ForeColor = Color.White
            Case ChoiceC.Text
                ChoiceC.BackColor = Color.Green
                ChoiceC.ForeColor = Color.White
                PlayerScreen.ChoiceC.BackColor = Color.Green
                PlayerScreen.ChoiceC.ForeColor = Color.White
            Case ChoiceD.Text
                ChoiceD.BackColor = Color.Green
                ChoiceD.ForeColor = Color.White
                PlayerScreen.ChoiceD.BackColor = Color.Green
                PlayerScreen.ChoiceD.ForeColor = Color.White
        End Select

        'check if answer is correct
        If choice = answer Then
            'enable the money tree result
            PlayerScreen.Money01.BackColor = Color.Green
            PlayerScreen.Money01.ForeColor = Color.White

            'display the question value result
            QuestionValue.BackColor = Color.Green
            QuestionValue.ForeColor = Color.White

            'change the color of the topic to green
            Level2MoneyTree.Topic01.BackColor = Color.Green
            Level2MoneyTree.Topic01.ForeColor = Color.White
            Level3MoneyTree.Topic01.BackColor = Color.Green
            Level3MoneyTree.Topic01.ForeColor = Color.White
            Level4MoneyTree.Topic01.BackColor = Color.Green
            Level4MoneyTree.Topic01.ForeColor = Color.White
            PlayerScreen.Topic01.BackColor = Color.Green
            PlayerScreen.Topic01.ForeColor = Color.White
        Else
            'change the color of the topic to red
            Level2MoneyTree.Topic01.BackColor = Color.Red
            Level2MoneyTree.Topic01.ForeColor = Color.White
            Level3MoneyTree.Topic01.BackColor = Color.Red
            Level3MoneyTree.Topic01.ForeColor = Color.White
            Level4MoneyTree.Topic01.BackColor = Color.Red
            Level4MoneyTree.Topic01.ForeColor = Color.White
            PlayerScreen.Topic01.BackColor = Color.Red
            PlayerScreen.Topic01.ForeColor = Color.White
        End If
    End Sub

    Private Sub PassPic_Click(sender As Object, e As EventArgs) Handles PassPic.Click
        If passcount = 0 Then
            'stop clock
            TenthsClock.Stop()
            SecondsClock.Stop()

            'reset Clock to 15
            TimeSeconds = 15
            Seconds.Text = CStr(TimeSeconds)
            PlayerScreen.Seconds.Text = CStr(TimeSeconds)
            TimeTenths = 0
            Tenths.Text = CStr(TimeTenths)
            PlayerScreen.Tenths.Text = CStr(TimeTenths)

            'reset the clock background
            Seconds.BackColor = DefaultBackColor
            Seconds.ForeColor = DefaultForeColor
            Placeholder.BackColor = DefaultBackColor
            Placeholder.ForeColor = DefaultForeColor
            Tenths.BackColor = DefaultBackColor
            Tenths.ForeColor = DefaultForeColor
            PlayerScreen.Seconds.BackColor = DefaultBackColor
            PlayerScreen.Seconds.ForeColor = DefaultForeColor
            PlayerScreen.Placeholder.BackColor = DefaultBackColor
            PlayerScreen.Placeholder.ForeColor = DefaultForeColor
            PlayerScreen.Tenths.BackColor = DefaultBackColor
            PlayerScreen.Tenths.ForeColor = DefaultForeColor

            'hide the pass Lifeline Picture to Players
            PlayerScreen.PassPic.Visible = False

            'hide player choices
            PlayerScreen.HideChoices()

            'add one to passUsage
            passUsage += 1

            'add one to passcount
            passcount += 1
        Else
            'show player choices
            PlayerScreen.ShowChoices()

            'disable pass button
            PassPic.Visible = False

            'restart clock
            SecondsClock.Start()
            TenthsClock.Start()
        End If
    End Sub
End Class