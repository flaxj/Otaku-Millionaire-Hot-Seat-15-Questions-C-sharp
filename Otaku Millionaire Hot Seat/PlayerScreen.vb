Public Class PlayerScreen
    Friend Players As Integer = 6 'declare the Players Varible
    Friend subjects(15) As String 'declare the string array
    Friend question(7) As String 'declare question string array

    Private Sub PlayerScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'perform LoadTopics
        Loadtopics()
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
    End Sub

    Sub ResetMoneyTree()
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

    Sub StartandResumeGame()
        'hide the big money tree
        HideValue()
    End Sub

    Sub QuestionLoader()
        'put the lablel in the value
        Question1.Text = question(0)
        Question2.Text = question(1)
        Question3.Text = question(2)
        ChoiceA.Text = question(3)
        ChoiceB.Text = question(4)
        ChoiceC.Text = question(5)
        ChoiceD.Text = question(6)
    End Sub

    Sub ShowQuestions()
        'show the question lables
        Question1.Visible = True
        Question2.Visible = True
        Question3.Visible = True
    End Sub

    Sub ShowChoices()
        'show the choices
        ChoiceA.Visible = True
        ChoiceB.Visible = True
        ChoiceC.Visible = True
        ChoiceD.Visible = True
    End Sub

    Sub ResetQuestionArea()
        'hide the question and choices
        Question1.Visible = False
        Question2.Visible = False
        Question3.Visible = False
        ChoiceA.Visible = False
        ChoiceB.Visible = False
        ChoiceC.Visible = False
        ChoiceD.Visible = False

        'clear question array
        Array.Clear(question, 0, 7)

        'redim the question array
        ReDim question(7)

        'set the new value
        QuestionLoader()

        'reset the font size
        ChoiceA.Font = New Font(ChoiceA.Font.FontFamily, 30)
        ChoiceB.Font = New Font(ChoiceB.Font.FontFamily, 30)
        ChoiceC.Font = New Font(ChoiceC.Font.FontFamily, 30)
        ChoiceD.Font = New Font(ChoiceD.Font.FontFamily, 30)

        'reset the answer color
        ChoiceA.BackColor = DefaultBackColor
        ChoiceA.ForeColor = DefaultForeColor
        ChoiceB.BackColor = DefaultBackColor
        ChoiceB.ForeColor = DefaultForeColor
        ChoiceC.BackColor = DefaultBackColor
        ChoiceC.ForeColor = DefaultForeColor
        ChoiceD.BackColor = DefaultBackColor
        ChoiceD.ForeColor = DefaultForeColor

        'reset clock
        Seconds.BackColor = DefaultBackColor
        Seconds.ForeColor = DefaultForeColor
        Placeholder.BackColor = DefaultBackColor
        Placeholder.ForeColor = DefaultForeColor
        Tenths.BackColor = DefaultBackColor
        Tenths.ForeColor = DefaultForeColor
    End Sub

    Sub HideChoices()
        'hide the choices
        ChoiceA.Visible = False
        ChoiceB.Visible = False
        ChoiceC.Visible = False
        ChoiceD.Visible = False
    End Sub

    Sub LevelWindow()
        'hide playerscreen game screen
        Topic.Visible = False
        Seconds.Visible = False
        Placeholder.Visible = False
        Tenths.Visible = False
        QuestionValue.Visible = False
    End Sub

    Sub EndOfGame()
        'hide playerscreen game screen
        Topic.Visible = False
        Seconds.Visible = False
        Placeholder.Visible = False
        Tenths.Visible = False
        QuestionValue.Visible = False

        'hide lifelines
        AskPic.Visible = False
        AskFriendPic.Visible = False
        DoubleDipPic.Visible = False
        TrustPic.Visible = False
        PassPic.Visible = False

        'show prize label
        Prize.Visible = True

        'reset question area
        ResetQuestionArea()
    End Sub
End Class