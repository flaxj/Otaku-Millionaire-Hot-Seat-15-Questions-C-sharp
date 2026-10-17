Partial Public Class Q11
    Inherits Global.System.Windows.Forms.Form
    Friend Q11GamePlay(13) As String 'declare gameplay as string
    Friend GPlayersRemaining As Integer 'declare playersRemaining as Integer
    Friend GPlayerNumber As Integer 'declare GPlayerNumber as Integer
    Friend questionsRemaining As Integer = 5 'declare questionsRemaining as Integer
    Friend AskFriendCount As Integer 'declare AskFriendCount as Integer
    Friend DoubleDipCount As Integer 'declare DoubleDipCount as Integer
    Friend AskAudienceCount As Integer 'declare AskAudienceCount as Integer
    Friend AskA As Integer 'declare AskA as Integer
    Friend AskB As Integer 'declare AskB as Integer
    Friend AskC As Integer 'declare AskC as Integer
    Friend AskD As Integer 'declare AskD as Integer
    Friend Trust As Integer 'declare Trust as Integer
    Friend TimeSeconds As Integer = 45 'declare TimeSeconds as Integer
    Friend TimeTenths As Integer = 0 'declare Timetenths as Integer
    Dim choice As String 'set choice as string
    Dim answer As String 'set answer as string
    Dim CountA As Integer 'declare CountA as Integer
    Dim CountB As Integer 'declare CountB as Integer
    Dim CountC As Integer 'declare CountC as Integer
    Dim CountD As Integer 'declare CountD as Integer
    Dim ButtonCount As Integer 'declare ButtonCount as Integer
    Dim guess As Integer 'declare guess as Integer
    Friend ask As Integer 'declare ask as Integer
    Friend AskSum As Integer 'declare asksum as Integer
    Dim DDEnable As Integer = 0 'declare DDEnable as Integer

    Private Sub Q11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'transfer Friend Varables from Question 10
        GPlayersRemaining = Q10.GPlayersRemaining
        GPlayerNumber = Q10.GPlayerNumber
        AskFriendCount = Q10.AskFriendCount
        DoubleDipCount = Q10.DoubleDipCount
        TopPrizeAmount.Text = Q10.TopPrizeAmount.Text
        AskAudienceCount = Level3MoneyTree.AskCount
        Trust = Q10.Trust

        Winnings.question = 11

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

        If GPlayersRemaining = 6 Then
            'set QuestionValue to Question 11 Value
            QuestionValue.Text = "¥20,000"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        ElseIf GPlayersRemaining = 5 Then
            'set new risk value to ¥150,000
            AmountAtRisk.Text = "¥150,000"

            'set the value to Question 10
            QuestionValue.Text = "¥10,000"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        ElseIf GPlayersRemaining = 4 Then
            'set new risk value to ¥50,000
            AmountAtRisk.Text = "¥50,000"

            'set the value to question 9
            QuestionValue.Text = "¥6,000"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        ElseIf GPlayersRemaining = 3 Then
            'set new risk value to ¥30,000
            AmountAtRisk.Text = "¥30,000"

            'set the value to question 8
            QuestionValue.Text = "¥4,000"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        ElseIf GPlayersRemaining = 2 Then
            'set new risk value to ¥10,000
            AmountAtRisk.Text = "¥10,000"

            'set the value to question 7
            QuestionValue.Text = "¥2,500"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        Else
            'set new risk value to ¥9,000
            AmountAtRisk.Text = "¥9,000"

            'set questionValue to Question 6 Value
            QuestionValue.Text = "¥1,500"

            'transfer value to PlayerScreen
            PlayerScreen.QuestionValue.Text = QuestionValue.Text
        End If

        'perfrom Lifeline Used
        LifelineUsed()

        'show the numbers
        TopPrizeQuestionRemaining.Text = CStr(questionsRemaining)
        PlayersRemaining.Text = CStr(GPlayersRemaining)

        'close Question 10
        Q10.Close()
    End Sub

    Sub LifelineUsed()
        'check to see if Ask a Friend is used
        If AskFriendCount = 1 Then
            'hide and disable the Ask a Friend Lifeline
            AskFriendPic.Visible = False
            PlayerScreen.AskFriendPic.Visible = False
        End If

        'check to see if Double Dip is used
        If DoubleDipCount = 1 Then
            'hide and disable the Double Dip Lifeline
            DoubleDipPic.Visible = False
            PlayerScreen.DoubleDipPic.Visible = False
        End If

        'check to see if Trust the Computer is used
        If Trust = 0 Then
            'show the Trust the computer Picture
            TrustPic.Visible = True
            PlayerScreen.TrustPic.Visible = True
        Else
            'hide the Trust the Computer Picture
            TrustPic.Visible = False
            PlayerScreen.TrustPic.Visible = False
        End If
    End Sub

    Sub QuestionLoading()
        'set the topic, question, and choices
        Topic.Text = Q11GamePlay(0)
        Question1.Text = Q11GamePlay(1)
        Question2.Text = Q11GamePlay(2)
        Question3.Text = Q11GamePlay(3)
        ChoiceA.Text = Q11GamePlay(4)
        ChoiceB.Text = Q11GamePlay(5)
        ChoiceC.Text = Q11GamePlay(6)
        ChoiceD.Text = Q11GamePlay(7)
        PlayerScreen.Topic.Text = Q11GamePlay(0)
        PlayerScreen.question(0) = Q11GamePlay(1)
        PlayerScreen.question(1) = Q11GamePlay(2)
        PlayerScreen.question(2) = Q11GamePlay(3)
        PlayerScreen.question(3) = Q11GamePlay(4)
        PlayerScreen.question(4) = Q11GamePlay(5)
        PlayerScreen.question(5) = Q11GamePlay(6)
        PlayerScreen.question(6) = Q11GamePlay(7)

        'load the question on the PlayerScreen
        PlayerScreen.QuestionLoader()

        'set the answer
        answer = Q11GamePlay(8)

        'convert the choice text numbers
        CountA = CInt(Q11GamePlay(9))
        CountB = CInt(Q11GamePlay(10))
        CountC = CInt(Q11GamePlay(11))
        CountD = CInt(Q11GamePlay(12))

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

                'start Question 11 Music
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.Question11, AudioPlayMode.Background)

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
                    If GPlayersRemaining = 5 Then
                        'play Question 10 Correct Answer
                        My.Computer.Audio.Play(My.Resources.Question10Correct, AudioPlayMode.Background)
                    Else
                        'play Question 11 Correct Answer
                        My.Computer.Audio.Play(My.Resources.Question11Correct, AudioPlayMode.Background)
                    End If

                    If DoubleDipCount = 0 Then
                        'show the Double Dip Lifeline Picture
                        DoubleDipPic.Visible = True
                        PlayerScreen.DoubleDipPic.Visible = True
                    End If

                    If AskFriendCount = 0 Then
                        'show the Ask Friend Picture
                        AskFriendPic.Visible = True
                        PlayerScreen.AskFriendPic.Visible = True
                    End If

                    If AskAudienceCount = 0 Then
                        'show the Ask Friend Picture
                        AskPic.Visible = True
                        PlayerScreen.AskPic.Visible = True
                    End If

                    If Trust = 0 Then
                        'show the Trust the computer Picture
                        TrustPic.Visible = True
                        PlayerScreen.TrustPic.Visible = True
                    Else
                        'hide the Trust the Computer Picture
                        TrustPic.Visible = False
                        PlayerScreen.TrustPic.Visible = False
                    End If
                Else
                    'play Question 8 Incorrect
                    My.Computer.Audio.Play(My.Resources.Question8Wrong, AudioPlayMode.Background)

                    'take one from GPlayersRemaining
                    GPlayersRemaining -= 1
                    PlayerScreen.Players -= 1

                    'take away one from players
                    PlayersRemaining.Text = CStr(GPlayersRemaining)
                End If
            Case 3
                'check if incorrect is visible
                If Incorrect.Visible = True Or choice <> answer Then
                    If GPlayersRemaining = 5 Then
                        'reset questions
                        PlayerScreen.ResetQuestionArea()

                        'play the next player in
                        My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                        'set top prize amount
                        TopPrizeAmount.Text = "¥250,000"

                        'set new risk value to ¥150,000
                        AmountAtRisk.Text = "¥150,000"
                    ElseIf GPlayersRemaining = 4 Then
                        'reset questions
                        PlayerScreen.ResetQuestionArea()

                        'play the next player in
                        My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                        'set top prize amount
                        TopPrizeAmount.Text = "¥100,000"

                        'set new risk value to ¥50,000
                        AmountAtRisk.Text = "¥50,000"
                    ElseIf GPlayersRemaining = 3 Then
                        'reset questions
                        PlayerScreen.ResetQuestionArea()

                        'play the next player in
                        My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                        'set top prize amount
                        TopPrizeAmount.Text = "¥50,000"

                        'set new risk value to ¥30,000
                        AmountAtRisk.Text = "¥30,000"
                    ElseIf GPlayersRemaining = 2 Then
                        'reset questions
                        PlayerScreen.ResetQuestionArea()

                        'play the next player in
                        My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                        'set top prize amount
                        TopPrizeAmount.Text = "¥20,000"

                        'set new risk value to ¥10,000
                        AmountAtRisk.Text = "¥10,000"
                    ElseIf GPlayersRemaining = 1 Then
                        'reset questions
                        PlayerScreen.ResetQuestionArea()

                        'play the next player in
                        My.Computer.Audio.Play(My.Resources.Next_Player_In, AudioPlayMode.Background)

                        'set top prize amount
                        TopPrizeAmount.Text = "¥10,000"

                        'set new risk value to ¥9,000
                        AmountAtRisk.Text = "¥9,000"
                    Else
                        'show Winnings window
                        Winnings.Show()

                        Winnings.AmountWon.Text = "¥1,000"
                        PlayerScreen.AmountWon.Text = "¥1,000"

                        'show the final picture and winnings on player screen
                        PlayerScreen.EndShowLogo.Visible = True
                        PlayerScreen.AmountWon.Visible = True

                        'reset questions
                        PlayerScreen.EndOfGame()

                        'close Question Window
                        Close()

                        'exit sub
                        Exit Sub
                    End If

                    If DoubleDipCount = 0 Then
                        'show the Double Dip Lifeline Picture
                        DoubleDipPic.Visible = True
                        PlayerScreen.DoubleDipPic.Visible = True
                    End If

                    If AskFriendCount = 0 Then
                        'show the Ask Friend Picture
                        AskFriendPic.Visible = True
                        PlayerScreen.AskFriendPic.Visible = True
                    End If

                    If AskAudienceCount = 0 Then
                        'show the Ask Friend Picture
                        AskPic.Visible = True
                        PlayerScreen.AskPic.Visible = True
                    End If

                    If Trust = 0 Then
                        'show the Trust the computer Picture
                        TrustPic.Visible = True
                        PlayerScreen.TrustPic.Visible = True
                    Else
                        'hide the Trust the Computer Picture
                        TrustPic.Visible = False
                        PlayerScreen.TrustPic.Visible = False
                    End If
                Else
                    'reset questions
                    PlayerScreen.ResetQuestionArea()

                    'open the Question 12 Window
                    Q12.Show()
                End If
            Case 4
                'open the Question 12 Window
                Q12.Show()
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
        If DoubleDipPic.Visible = True And guess = 1 And DDEnable = 1 Then
            'play the first double dip final answer
            My.Computer.Audio.Play(My.Resources.DoubleDipFinalAnswer, AudioPlayMode.Background)
        Else
            'play the question 11 Final Answer
            My.Computer.Audio.Play(My.Resources.Question11Final, AudioPlayMode.Background)
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
            If DoubleDipCount = 1 Or DDEnable = 0 Then
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
            Else
                If Trust = 1 And (DoubleDipCount = 1 Or DDEnable = 0) Then
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
            End If
        End If

        'Check to see which button is visible
        If guess = 1 And (DDEnable = 1 And DoubleDipPic.Visible = True And AskPic.Visible = False And AskFriendPic.Visible = False And TrustPic.Visible = False) Then
            'disable the MasterButton
            MasterButton.Enabled = False
        Else
            'reenable the MasterButton
            MasterButton.Enabled = True
        End If
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
            If GPlayersRemaining = 6 Then
                'enable the money tree result
                PlayerScreen.Money11.BackColor = Color.Green
                PlayerScreen.Money11.ForeColor = Color.White
            ElseIf GPlayersRemaining = 5 Then
                'enable the money tree result
                PlayerScreen.Money10.BackColor = Color.Green
                PlayerScreen.Money10.ForeColor = Color.White
            ElseIf GPlayersRemaining = 4 Then
                'enable the money tree result
                PlayerScreen.Money09.BackColor = Color.Green
                PlayerScreen.Money09.ForeColor = Color.White
            ElseIf GPlayersRemaining = 3 Then
                'enable the money tree result
                PlayerScreen.Money08.BackColor = Color.Green
                PlayerScreen.Money08.ForeColor = Color.White
            ElseIf GPlayersRemaining = 2 Then
                'enable the money tree result
                PlayerScreen.Money07.BackColor = Color.Green
                PlayerScreen.Money07.ForeColor = Color.White
            Else
                'enable the money tree result
                PlayerScreen.Money06.BackColor = Color.Green
                PlayerScreen.Money06.ForeColor = Color.White
            End If

            'highlight the question value
            QuestionValue.BackColor = Color.Green
            QuestionValue.ForeColor = Color.White

            'change the color of the topic to green
            Level4MoneyTree.Topic11.BackColor = Color.Green
            Level4MoneyTree.Topic11.ForeColor = Color.White
            PlayerScreen.Topic11.BackColor = Color.Green
            PlayerScreen.Topic11.ForeColor = Color.White
        Else
            'change the color of the topic to red
            Level4MoneyTree.Topic11.BackColor = Color.Red
            Level4MoneyTree.Topic11.ForeColor = Color.White
            PlayerScreen.Topic11.BackColor = Color.Red
            PlayerScreen.Topic11.ForeColor = Color.White
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
                TrustPic.Visible = False
                PlayerScreen.AskFriendPic.Visible = False
                PlayerScreen.PassPic.Visible = False
                PlayerScreen.TrustPic.Visible = False

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

                    If GPlayersRemaining = 5 Then
                        'play Question 10 Correct Answer
                        My.Computer.Audio.Play(My.Resources.Question10Correct, AudioPlayMode.Background)
                    Else
                        'play Question 11 Correct Answer
                        My.Computer.Audio.Play(My.Resources.Question11Correct, AudioPlayMode.Background)
                    End If

                    If AskAudienceCount = 0 Then
                        'show the Ask Friend Picture
                        AskPic.Visible = True
                        PlayerScreen.AskPic.Visible = True
                    End If

                    If AskFriendCount = 0 Then
                        'show the Ask Friend Picture
                        AskFriendPic.Visible = True
                        PlayerScreen.AskFriendPic.Visible = True
                    End If

                    If Trust = 1 Then
                        'hide the Trust the Computer Picture
                        TrustPic.Visible = False
                        PlayerScreen.TrustPic.Visible = False
                    Else
                        'show the Trust the computer Picture
                        TrustPic.Visible = True
                        PlayerScreen.TrustPic.Visible = True
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

        'check for the apporate music for the clock
        Select Case TimeSeconds
            Case 45
                My.Computer.Audio.Play(My.Resources.Question11, AudioPlayMode.Background)
            Case 30
                My.Computer.Audio.Play(My.Resources.Question11_30, AudioPlayMode.Background)
            Case 15
                My.Computer.Audio.Play(My.Resources.Question11_15, AudioPlayMode.Background)
        End Select
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
                TrustPic.Visible = False
                PlayerScreen.TrustPic.Visible = False

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

                'hide the Ask The Audience and Trust Picture
                AskPic.Visible = False
                PlayerScreen.AskPic.Visible = False
                TrustPic.Visible = False
                PlayerScreen.TrustPic.Visible = False

                'close AskResult
                AskResult.Close()

                'restart the clock
                RestartQuestionClock()
        End Select
    End Sub

    Private Sub TrustPic_Click(sender As Object, e As EventArgs) Handles TrustPic.Click
        Dim computerSelection As Integer
        Dim min As Integer = 0
        Dim max As Integer = 4

        'declare and perform the random choices
        Dim randomNum As New Random

        'set selection to a random number
        computerSelection = randomNum.Next(min, max)

        'see what is the selection number
        If computerSelection = 0 Then
            'select choice A
            choice = ChoiceA.Text
        ElseIf computerSelection = 1 Then
            'select choice B
            choice = ChoiceB.Text
        ElseIf computerSelection = 2 Then
            'select choice C
            choice = ChoiceC.Text
        Else
            'select choice D
            choice = ChoiceD.Text
        End If

        'hide trust pic
        TrustPic.Visible = False

        'add one to Trust
        Trust += 1

        'perfom final answer
        FinalAnswer()
    End Sub
End Class