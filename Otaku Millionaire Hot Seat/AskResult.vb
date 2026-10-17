Public Class AskResult
    Friend questionsRemaining As Integer 'declare questionsRemaining as Integer
    Friend AskA As Integer 'declare AskA as Integer
    Friend AskB As Integer 'declare AskB as Integer
    Friend AskC As Integer 'declare AskC as Integer
    Friend AskD As Integer 'declare AskD as Integer
    Friend ask As Integer 'declare ask as Integer
    Dim asksum As Integer 'declare asksum as Integer


    Private Sub AskResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If questionsRemaining = 5 Then
            'set values from question
            AskA = Q11.AskA
            AskB = Q11.AskB
            AskC = Q11.AskC
            AskD = Q11.AskD
            asksum = Q11.AskSum
        ElseIf questionsRemaining = 4 Then
            'set values from question
            AskA = Q12.AskA
            AskB = Q12.AskB
            AskC = Q12.AskC
            AskD = Q12.AskD
            asksum = Q12.AskSum
        ElseIf questionsRemaining = 3 Then
            'set values from question
            AskA = Q13.AskA
            AskB = Q13.AskB
            AskC = Q13.AskC
            AskD = Q13.AskD
            asksum = Q13.AskSum
        ElseIf questionsRemaining = 2 Then
            'set values from question
            AskA = Q14.AskA
            AskB = Q14.AskB
            AskC = Q14.AskC
            AskD = Q14.AskD
            asksum = Q14.AskSum
        Else
            'set values from question
            AskA = Q15.AskA
            AskB = Q15.AskB
            AskC = Q15.AskC
            AskD = Q15.AskD
            asksum = Q15.AskSum
        End If

        'Find the percentage
        AskA = CInt(AskA / asksum * 100)
        AskB = CInt(AskB / asksum * 100)
        AskC = CInt(AskC / asksum * 100)
        AskD = CInt(AskD / asksum * 100)

        'get results from question 12
        Result1.Text = CStr(AskA)
        Result2.Text = CStr(AskB)
        Result3.Text = CStr(AskC)
        Result4.Text = CStr(AskD)

        'get data from Ask Screen
        PlayerScreen.Result1.Text = Result1.Text
        PlayerScreen.Result2.Text = Result2.Text
        PlayerScreen.Result3.Text = Result3.Text
        PlayerScreen.Result4.Text = Result4.Text

        'computing Music
        My.Computer.Audio.Play(My.Resources.AskLifelineResults, AudioPlayMode.WaitToComplete)

        'show results
        A.Visible = True
        Result1.Visible = True
        PercentA.Visible = True
        B.Visible = True
        Result2.Visible = True
        PercentB.Visible = True
        C.Visible = True
        Result3.Visible = True
        PercentC.Visible = True
        D.Visible = True
        Result4.Visible = True
        PercentD.Visible = True
        PlayerScreen.A.Visible = True
        PlayerScreen.Result1.Visible = True
        PlayerScreen.PercentA.Visible = True
        PlayerScreen.B.Visible = True
        PlayerScreen.Result2.Visible = True
        PlayerScreen.PercentB.Visible = True
        PlayerScreen.C.Visible = True
        PlayerScreen.Result3.Visible = True
        PlayerScreen.PercentC.Visible = True
        PlayerScreen.D.Visible = True
        PlayerScreen.Result4.Visible = True
        PlayerScreen.PercentD.Visible = True
    End Sub

    Private Sub CloseAndRestart_Click(sender As Object, e As EventArgs) Handles CloseAndRestart.Click
        'add one to ask
        ask += 1

        If questionsRemaining = 5 Then
            'transfer ask number
            Q11.ask = ask

            'resume game
            Q11.asklifeline()
        ElseIf questionsRemaining = 4 Then
            'transfer ask number
            Q12.ask = ask

            'resume game
            Q12.asklifeline()
        ElseIf questionsRemaining = 3 Then
            'transfer ask number
            Q13.ask = ask

            'resume game
            Q13.asklifeline()
        ElseIf questionsRemaining = 2 Then
            'transfer ask number
            Q14.ask = ask

            'resume game
            Q14.asklifeline()
        Else
            'transfer ask number
            Q15.ask = ask

            'resume game
            Q15.asklifeline()
        End If
    End Sub
End Class