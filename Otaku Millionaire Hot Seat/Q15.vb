Public Class Q15
    Friend Q15GamePlay(13) As String 'declare gameplay as string
    Friend GPlayersRemaining As Integer 'declare playersRemaining as Integer
    Friend GPlayerNumber As Integer 'declare GPlayerNumber as Integer
    Friend questionsRemaining As Integer = 1 'declare questionsRemaining as Integer
    Friend AskFriendCount As Integer 'declare AskFriendCount as Integer
    Friend AskAudienceCount As Integer 'declare AskAudienceCount as Integer
    Friend DoubleDipCount As Integer 'declare DoubleDipCount as Integer
    Friend AskA As Integer 'declare AskA as Integer
    Friend AskB As Integer 'declare AskB as Integer
    Friend AskC As Integer 'declare AskC as Integer
    Friend AskD As Integer 'declare AskD as Integer
    Friend TimeSeconds As Integer = 45 'declare TimeSeconds as Integer
    Friend TimeTenths As Integer = 0 'declare Timetenths as Integer
    Private FiftyFiftyWrong(3) As String 'declare FiftyFiftyWrong as string
    Dim choice As String 'set choice as string
    Dim answer As String 'set answer as string
    Dim topAmount As String 'set top amount as string
    Dim CountA As Integer 'declare CountA as Integer
    Dim CountB As Integer 'declare CountB as Integer
    Dim CountC As Integer 'declare CountC as Integer
    Dim CountD As Integer 'declare CountD as Integer
    Dim ButtonCount As Integer 'declare ButtonCount as Integer
    Dim guess As Integer 'declare guess as Integer
    Friend ask As Integer 'declare ask as Integer
    Friend AskSum As Integer    'decare AskSum as Integer
    Dim DDEnable As Integer = 0 'declare DDEnable as Integer

    Private Sub Q15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'transfer Friend Varables from Question 11 and Level 4
        GPlayersRemaining = Level4MoneyTree.GPlayersRemaining
        GPlayerNumber = Q14.GPlayerNumber
        AskFriendCount = Level4MoneyTree.AskFriendCount
        AskAudienceCount = Level4MoneyTree.AskAudienceCount
        DoubleDipCount = Level4MoneyTree.DoubleDipCount
        TopPrizeAmount.Text = Q14.TopPrizeAmount.Text
        Seconds.Text = CStr(TimeSeconds)
        Tenths.Text = CStr(TimeTenths)

        Winnings.question = 15


        'play the question Transiton Music
        My.Computer.Audio.Play(My.Resources.QuestionTransitionMusic, AudioPlayMode.Background)

        'show PlayerScreen game screen
        PlayerScreen.Topic.Visible = True
        PlayerScreen.Seconds.Visible = True
        PlayerScreen.Placeholder.Visible = True
        PlayerScreen.Tenths.Visible = True
        PlayerScreen.QuestionValue.Visible = True

        'perform question loading and reset clock
        PlayerScreen.Seconds.Text = CStr(45)
        PlayerScreen.Tenths.Text = CStr(0)
        QuestionLoading()

        If GPlayerNumber = 6 And Level4MoneyTree.Money15.Text = "¥2,000,000" Then
            'set new risk value to ¥1,999,000
            AmountAtRisk.Text = "¥1,999,000"

            'set top prize to ¥2,000,000
            TopPrizeAmount.Text = "¥2,000,000"
        ElseIf GPlayersRemaining = 6 Or Level4MoneyTree.Money15.Visible = True Then
            'set new risk value to ¥999,000
            AmountAtRisk.Text = "¥999,000"

            'set top prize to ¥1,000,000
            TopPrizeAmount.Text = "¥1,000,000"
        ElseIf GPlayersRemaining = 5 Then
            'set new risk value to ¥249,000
            AmountAtRisk.Text = "¥249,000"

            'set top prize to ¥250,000
            TopPrizeAmount.Text = "¥250,000"
        ElseIf GPlayersRemaining = 4 Then
            'set new risk value to ¥99,000
            AmountAtRisk.Text = "¥99,000"

            'set top prize to ¥100,000
            TopPrizeAmount.Text = "¥100,000"
        ElseIf GPlayersRemaining = 3 Then
            'set new risk value to ¥49,000
            AmountAtRisk.Text = "¥49,000"

            'set top prize to ¥50,000
            TopPrizeAmount.Text = "¥50,000"
        ElseIf GPlayersRemaining = 2 Then
            'set new risk value to ¥19,000
            AmountAtRisk.Text = " ¥19,000"

            'set top prize to ¥20,000
            TopPrizeAmount.Text = "¥20,000"
        Else
            'set new risk value to ¥9,000
            AmountAtRisk.Text = "¥9,000"

            'set top prize to ¥10,000
            TopPrizeAmount.Text = "¥10,000"
        End If

        'Transfer TopPrizeAmount to PlayerScreen
        PlayerScreen.QuestionValue.Text = TopPrizeAmount.Text

        'perfrom Lifeline Used
        LifelineUsed()

        'show the numbers
        TopPrizeQuestionRemaining.Text = CStr(questionsRemaining)
        PlayersRemaining.Text = CStr(GPlayersRemaining)

        'close Question 14 and Level 4 Windows
        Q14.Close()
        Level4MoneyTree.Close()
    End Sub

    Sub LifelineUsed()
        'check to see if Ask a Friend is used
        If AskFriendCount = 1 Or Level4MoneyTree.AskFriendPic.Visible = False Then
            'hide and disable the Ask a Friend Lifeline
            AskFriendPic.Visible = False
            PlayerScreen.AskFriendPic.Visible = False
        End If

        'check to see if Ask the Audience is used
        If AskAudienceCount = 1 Or Level4MoneyTree.AskPic.Visible = False Then
            'hide and disable the Ask the Audience Lifeline
            AskPic.Visible = False
            PlayerScreen.AskPic.Visible = False
        End If

        If DoubleDipCount = 1 Or Level4MoneyTree.DoubleDipPic.Visible = False Then
            'hide and disable the Double Dip Lifeline
            DoubleDipPic.Visible = False
            PlayerScreen.DoubleDipPic.Visible = False
        End If
    End Sub

    Sub QuestionLoading()
        'set the topic, question, and choices
        Topic.Text = Q15GamePlay(0)
        Question1.Text = Q15GamePlay(1)
        Question2.Text = Q15GamePlay(2)
        Question3.Text = Q15GamePlay(3)
        ChoiceA.Text = Q15GamePlay(4)
        ChoiceB.Text = Q15GamePlay(5)
        ChoiceC.Text = Q15GamePlay(6)
        ChoiceD.Text = Q15GamePlay(7)
        PlayerScreen.Topic.Text = Q15GamePlay(0)
        PlayerScreen.question(0) = Q15GamePlay(1)
        PlayerScreen.question(1) = Q15GamePlay(2)
        PlayerScreen.question(2) = Q15GamePlay(3)
        PlayerScreen.question(3) = Q15GamePlay(4)
        PlayerScreen.question(4) = Q15GamePlay(5)
        PlayerScreen.question(5) = Q15GamePlay(6)
        PlayerScreen.question(6) = Q15GamePlay(7)

        'load the question on the PlayerScreen
        PlayerScreen.QuestionLoader()

        'set the answer
        answer = Q15GamePlay(8)

        'convert the choice text numbers
        CountA = CInt(Q15GamePlay(9))
        CountB = CInt(Q15GamePlay(10))
        CountC = CInt(Q15GamePlay(11))
        CountD = CInt(Q15GamePlay(12))

        If CountA >= 60 Then
            'change Font Size to 12
            ChoiceA.Font = New Font(ChoiceA.Font.FontFamily, 12)
            PlayerScreen.ChoiceA.Font = New Font(PlayerScreen.ChoiceA.Font.FontFamily, 12)
        ElseIf CountA >= 30 And CountA < 60 Then
            'change Font Size to 18
            ChoiceA.Font = New Font(ChoiceA.Font.FontFamily, 18)
            PlayerScreen.ChoiceA.Font = New Font(PlayerScreen.ChoiceA.Font.FontFamily, 18)
        End If

        If CountB >= 60 Then
            'change Font Size to 12
            ChoiceB.Font = New Font(ChoiceB.Font.FontFamily, 12)
            PlayerScreen.ChoiceB.Font = New Font(PlayerScreen.ChoiceB.Font.FontFamily, 12)
        ElseIf CountB >= 30 And CountB < 60 Then
            'change Font Size to 18
            ChoiceB.Font = New Font(ChoiceB.Font.FontFamily, 18)
            PlayerScreen.ChoiceB.Font = New Font(PlayerScreen.ChoiceB.Font.FontFamily, 18)
        End If

        If CountC >= 60 Then
            'change Font Size to 12
            ChoiceC.Font = New Font(ChoiceC.Font.FontFamily, 12)
            PlayerScreen.ChoiceC.Font = New Font(PlayerScreen.ChoiceC.Font.FontFamily, 12)
        ElseIf CountC >= 30 And CountC < 60 Then
            'change Font Size to 18
            ChoiceC.Font = New Font(ChoiceC.Font.FontFamily, 18)
            PlayerScreen.ChoiceC.Font = New Font(PlayerScreen.ChoiceC.Font.FontFamily, 18)
        End If

        If CountD >= 60 Then
            'change Font Size to 12
            ChoiceD.Font = New Font(ChoiceD.Font.FontFamily, 12)
            PlayerScreen.ChoiceD.Font = New Font(PlayerScreen.ChoiceD.Font.FontFamily, 12)
        ElseIf CountD >= 30 And CountD < 60 Then
            'change Font Size to 18
            ChoiceD.Font = New Font(ChoiceD.Font.FontFamily, 18)
            PlayerScreen.ChoiceD.Font = New Font(PlayerScreen.ChoiceD.Font.FontFamily, 18)
        End If
    End Sub

    Private Sub MasterButton_Click(sender As Object, e As EventArgs) Handles MasterButton.Click
        Select Case ButtonCount
            Case 0
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

                'start Question 15 Music
                If GPlayersRemaining = 6 Then
                    My.Computer.Audio.Play(My.Resources.Question15MillionYenQuestion, AudioPlayMode.Background)
                Else
                    My.Computer.Audio.Play(My.Resources.Questions14and15, AudioPlayMode.Background)
                End If

                'disable the MasterButton
                MasterButton.Enabled = False

                'show the MasterButton Next Action
                MasterButton.Text = "Answer"
            Case 2
                'perform questionResult
                QuestionResult()

                'stop the audio
                My.Computer.Audio.Stop()

                'take away one from question remaining
                questionsRemaining -= 1
                TopPrizeQuestionRemaining.Text = CStr(questionsRemaining)

                'show if correct is the answer
                If Correct.Visible = True Or choice = answer Then
                    If GPlayersRemaining <> 6 Then
                        'play the winning soundtrack
                        My.Computer.Audio.Play(My.Resources.RegularWin, AudioPlayMode.Background)
                    Else
                        'play Million Yen Correct Answer
                        My.Computer.Audio.Play(My.Resources.MilllionYenWin, AudioPlayMode.Background)
                    End If

                    TopPrizeAmount.BackColor = Color.Green
                    TopPrizeAmount.ForeColor = Color.White
                Else
                    If GPlayersRemaining <> 6 Then
                        'play Question 14 Incorrect
                        My.Computer.Audio.Play(My.Resources.Questions14and15Wrong, AudioPlayMode.Background)
                    Else
                        'play Million Yen Incorrect Answer
                        My.Computer.Audio.Play(My.Resources.MillionYenWrong, AudioPlayMode.Background)
                    End If

                    'set WonSoFar and PlayerScreen to ¥1,000
                    WonSoFar.Text = "¥1,000"
                    PlayerScreen.QuestionValue.Text = "¥1,000"

                    'set won so far color
                    WonSoFar.BackColor = Color.Green
                    WonSoFar.ForeColor = Color.White
                End If
            Case 3
                'show Winnings window
                Winnings.Show()
        End Select

        'add one to ButtonCount
        ButtonCount += 1
    End Sub

    Private Sub TenthsClock_Tick(sender As Object, e As EventArgs) Handles TenthsClock.Tick
        'take one away from seconds
        If TimeTenths = 0 Then
            If TimeSeconds = 45 Or TimeSeconds = 30 Or TimeSeconds = 15 Then
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

                'show the incorrect label
                Incorrect.Visible = True

                'enable MasterButton
                MasterButton.Enabled = True
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

    Sub FinalAnswer()
        'stop the clock
        TenthsClock.Stop()
        SecondsClock.Stop()

        'stop the audio and play the proper Final Answer Sound
        My.Computer.Audio.Stop()
        If GPlayersRemaining = 6 Then
            'play the Million Yen Final Answer
            My.Computer.Audio.Play(My.Resources.Question15MillionYenFinalAnswer, AudioPlayMode.Background)
        Else
            'play the question 15 Final Answer
            My.Computer.Audio.Play(My.Resources.Questions14and15FinalAnswer, AudioPlayMode.Background)
        End If

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

            'show the color answer
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

        'reenable the MasterButton
        MasterButton.Enabled = True
    End Sub

    Sub QuestionResult()
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
            'highlight the question value
            TopPrizeAmount.BackColor = Color.Green
            TopPrizeAmount.ForeColor = Color.White
        Else
            'highlight the wonsofar value
            WonSoFar.BackColor = Color.Green
            WonSoFar.ForeColor = Color.White

            'Transfer Won So Far to PlayerScreen
            WonSoFar.Text = PlayerScreen.QuestionValue.Text
        End If
    End Sub

    Private Sub DoubleDipPic_Click(sender As Object, e As EventArgs) Handles DoubleDipPic.Click
        Select Case guess
            Case 0
                'stop the clock
                TenthsClock.Stop()
                SecondsClock.Stop()

                'check the clock for second time
                Select Case TimeSeconds
                    Case >= 30
                        'reset seconds to 45
                        TimeSeconds = 45
                    Case >= 15
                        'reset seconds to 30
                        TimeSeconds = 30
                    Case Else
                        'reset seconds to 15
                        TimeSeconds = 15
                End Select

                'display the seconds
                Seconds.Text = CStr(TimeSeconds)
                PlayerScreen.Seconds.Text = CStr(TimeSeconds)

                'check the clock for tenths place if it is at zero
                If TimeTenths <> 0 Then
                    'reset the tenths to zero
                    TimeTenths = 0
                    Tenths.Text = CStr(TimeTenths)
                    PlayerScreen.Tenths.Text = CStr(TimeTenths)
                End If

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

                'hide the other lifelines
                AskFriendPic.Visible = False
                AskPic.Visible = False
                PlayerScreen.AskFriendPic.Visible = False
                PlayerScreen.PassPic.Visible = False

                'Set DDEnable to one
                DDEnable = 1

                'stop the clock music and play Double Dip Music
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.DoubleDipLifelineFirstGuess, AudioPlayMode.Background)
            Case 1
                If Correct.Visible = True Then
                    'perform questionResult
                    QuestionResult()

                    'stop the audio
                    My.Computer.Audio.Stop()

                    'take away one from question remaining
                    questionsRemaining = questionsRemaining - 1
                    TopPrizeQuestionRemaining.Text = CStr(questionsRemaining)

                    If GPlayersRemaining = 6 Then
                        My.Computer.Audio.Play(My.Resources.Question15MillionYenQuestion, AudioPlayMode.Background)
                    Else
                        My.Computer.Audio.Play(My.Resources.Questions14and15, AudioPlayMode.Background)
                    End If

                    'enable the MasterButton and Disable the Double Dip
                    MasterButton.Enabled = True
                    DoubleDipPic.Visible = False
                    PlayerScreen.DoubleDipPic.Visible = False

                    'set button count to 3
                    ButtonCount = 3
                Else
                    Select Case choice
                        Case ChoiceA.Text
                            'hide choice A
                            ChoiceA.Visible = False
                            PlayerScreen.ChoiceA.Visible = False
                        Case ChoiceB.Text
                            'hide choice B
                            ChoiceB.Visible = False
                            PlayerScreen.ChoiceB.Visible = False
                        Case ChoiceC.Text
                            'hide choice C
                            ChoiceC.Visible = False
                            PlayerScreen.ChoiceC.Visible = False
                        Case ChoiceD.Text
                            'hide choice D
                            ChoiceD.Visible = False
                            PlayerScreen.ChoiceD.Visible = False
                    End Select

                    'reset the choice selection
                    choice = ""

                    'play the Double Dip Second Change
                    My.Computer.Audio.Play(My.Resources.DoubleDipSecondChance, AudioPlayMode.Background)
                End If

                'add one to Double Dip Count
                DoubleDipCount += 1
            Case 2
                'restart the clock
                RestartQuestionClock()

                'hide the incorrect lable
                Incorrect.Visible = False

                'exit sub
                Exit Sub
        End Select

        'add one to guess
        guess += 1
    End Sub

    Sub RestartQuestionClock()
        'restart the clock
        SecondsClock.Start()
        TenthsClock.Start()

        If GPlayersRemaining = 6 Then
            'check for the apporate music for the clock
            Select Case TimeSeconds
                Case 45
                    My.Computer.Audio.Play(My.Resources.Question15MillionYenQuestion, AudioPlayMode.Background)
                Case 30
                    My.Computer.Audio.Play(My.Resources.Question15MillionYenQuestion_30, AudioPlayMode.Background)
                Case 15
                    My.Computer.Audio.Play(My.Resources.Question15MillionYenQuestion_15, AudioPlayMode.Background)
            End Select
        Else
            'check for the apporate music for the clock
            Select Case TimeSeconds
                Case 45
                    My.Computer.Audio.Play(My.Resources.Questions14and15, AudioPlayMode.Background)
                Case 30
                    My.Computer.Audio.Play(My.Resources.Questions14and15_30, AudioPlayMode.Background)
                Case 15
                    My.Computer.Audio.Play(My.Resources.Questions14and15_15, AudioPlayMode.Background)
            End Select
        End If
    End Sub

    Private Sub AskFriendPic_Click(sender As Object, e As EventArgs) Handles AskFriendPic.Click
        Select Case AskFriendCount
            Case 0
                'stop the clock
                TenthsClock.Stop()
                SecondsClock.Stop()

                'play the Ask a Friend Music
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.AskAFriend, AudioPlayMode.Background)

                'hide the other lifelines
                AskPic.Visible = False
                PlayerScreen.AskPic.Visible = False
                DoubleDipPic.Visible = False
                PlayerScreen.DoubleDipPic.Visible = False

                'check the clock for second time
                If TimeSeconds >= 30 Then
                    'reset seconds to 45
                    TimeSeconds = 45
                ElseIf TimeSeconds >= 15 Then
                    'reset seconds to 30
                    TimeSeconds = 30
                Else
                    'reset seconds to 15
                    TimeSeconds = 15
                End If

                'display the seconds
                Seconds.Text = CStr(TimeSeconds)
                PlayerScreen.Seconds.Text = CStr(TimeSeconds)

                'check the clock for tenths place if it is at zero
                If TimeTenths <> 0 Then
                    'reset the tenths to zero
                    TimeTenths = 0
                    Tenths.Text = CStr(TimeTenths)
                    PlayerScreen.Tenths.Text = CStr(TimeTenths)
                End If

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

                'add one to Ask Friend Count
                AskFriendCount += 1
            Case 1
                'hide the Ask a Friend Button
                AskFriendPic.Visible = False

                'restart the clock
                RestartQuestionClock()
        End Select
    End Sub

    Private Sub AskPic_Click(sender As Object, e As EventArgs) Handles AskPic.Click
        'perform asklifeline
        asklifeline()

        'open the results
        AskResult.Show()
    End Sub

    Public Sub asklifeline()
        Select Case ask
            Case 0
                'stop the clock
                TenthsClock.Stop()
                SecondsClock.Stop()

                'Change to Ask the Audience Music
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.AskLifelineSurvay, AudioPlayMode.BackgroundLoop)

                'check the clock for second time
                Select Case TimeSeconds
                    Case >= 30
                        'reset seconds to 45
                        TimeSeconds = 45
                    Case >= 15
                        'reset seconds to 30
                        TimeSeconds = 30
                    Case Else
                        'reset seconds to 15
                        TimeSeconds = 15
                End Select

                'display the seconds
                Seconds.Text = CStr(TimeSeconds)
                PlayerScreen.Seconds.Text = CStr(TimeSeconds)

                'check the clock for tenths place if it is at zero
                If TimeTenths <> 0 Then
                    'reset the tenths to zero
                    TimeTenths = 0
                    Tenths.Text = CStr(TimeTenths)
                    PlayerScreen.Tenths.Text = CStr(TimeTenths)
                End If

                'reset the clock background
                Seconds.BackColor = DefaultBackColor
                Seconds.ForeColor = DefaultForeColor
                Placeholder.BackColor = DefaultBackColor
                Placeholder.ForeColor = DefaultForeColor
                Tenths.BackColor = DefaultBackColor
                Tenths.ForeColor = DefaultForeColor

                'load the questions remaining in the ask the audience results
                AskResult.questionsRemaining = questionsRemaining

                'put in the vote in the Audience
                AskA = CInt(InputBox("How many voted for Choice A?", "Ask The Audience", "0"))
                AskB = CInt(InputBox("How many voted for Choice B?", "Ask The Audience", "0"))
                AskC = CInt(InputBox("How many voted for Choice C?", "Ask The Audience", "0"))
                AskD = CInt(InputBox("How many voted for Choice D?", "Ask The Audience", "0"))

                'Combine AskSum Number
                AskSum = AskA + AskB + AskC + AskD

                'add one to Ask Audinece Count
                AskAudienceCount += 1
            Case 1
                'hide result on PlayerScreen
                PlayerScreen.A.Visible = False
                PlayerScreen.Result1.Visible = False
                PlayerScreen.PercentA.Visible = False
                PlayerScreen.B.Visible = False
                PlayerScreen.Result2.Visible = False
                PlayerScreen.PercentB.Visible = False
                PlayerScreen.C.Visible = False
                PlayerScreen.Result3.Visible = False
                PlayerScreen.PercentC.Visible = False
                PlayerScreen.D.Visible = False
                PlayerScreen.Result4.Visible = False
                PlayerScreen.PercentD.Visible = False

                'hide the Ask The Audience Picture
                AskPic.Visible = False
                PlayerScreen.AskPic.Visible = False

                'close AskResult
                AskResult.Close()

                'restart the clock
                RestartQuestionClock()
        End Select
    End Sub
End Class