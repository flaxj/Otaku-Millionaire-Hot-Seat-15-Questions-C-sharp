Public Class Welcome
    Private Sub StartButton2Screen_Click(sender As Object, e As EventArgs) Handles StartButton2Screen.Click
        TopicFile.Title = "Topic File"
        TopicFile.Filter = "Text Files|*.txt"

        'show topic open file box
        TopicFile.ShowDialog()
    End Sub

    Private Sub TopicFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TopicFile.FileOk
        'open the topic file
        TopicFile.OpenFile()

        'read topic file name
        PlayerScreen.subjects = IO.File.ReadAllLines(TopicFile.FileName)
        Level1MoneyTree.subjects = IO.File.ReadAllLines(TopicFile.FileName)
        Level2MoneyTree.subjects = IO.File.ReadAllLines(TopicFile.FileName)
        Level3MoneyTree.subjects = IO.File.ReadAllLines(TopicFile.FileName)
        Level4MoneyTree.subjects = IO.File.ReadAllLines(TopicFile.FileName)

        Question01.Title = "Question 1 File"
        Question01.Filter = "Text Files|*.txt"

        'show the Question 1 File Box
        Question01.ShowDialog()
    End Sub

    Private Sub Question01_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question01.FileOk
        'open the Question 1 file
        Question01.OpenFile()

        'read Question 1 file name
        Q01.Q1GamePlay = IO.File.ReadAllLines(Question01.FileName)

        Question02.Title = "Question 2 File"
        Question02.Filter = "Text Files|*.txt"

        'show the Question 2 File Box
        Question02.ShowDialog()
    End Sub

    Private Sub Question02_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question02.FileOk
        'open the Question 2 file
        Question02.OpenFile()

        'read Question 2 file name
        Q02.Q2GamePlay = IO.File.ReadAllLines(Question02.FileName)

        Question03.Title = "Question 3 File"
        Question03.Filter = "Text Files|*.txt"

        'show the Question 3 File Box
        Question03.ShowDialog()
    End Sub

    Private Sub Question03_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question03.FileOk
        'open the Question 3 file
        Question03.OpenFile()

        'read Question 3 file name
        Q03.Q3GamePlay = IO.File.ReadAllLines(Question03.FileName)

        Question04.Title = "Question 4 File"
        Question04.Filter = "Text Files|*.txt"

        'show the Question 4 File Box
        Question04.ShowDialog()
    End Sub

    Private Sub Question04_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question04.FileOk
        'open the Question 4 file
        Question04.OpenFile()

        'read Question 1 file name
        Q04.Q4GamePlay = IO.File.ReadAllLines(Question04.FileName)

        Question05.Title = "Question 5 File"
        Question05.Filter = "Text Files|*.txt"

        'show the Question 5 File Box
        Question05.ShowDialog()
    End Sub

    Private Sub Question05_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question05.FileOk
        'open the Question 5 file
        Question05.OpenFile()

        'read Question 5 file name
        Q05.Q5GamePlay = IO.File.ReadAllLines(Question05.FileName)

        Question06.Title = "Question 6 File"
        Question06.Filter = "Text Files|*.txt"

        'show the Question 6 File Box
        Question06.ShowDialog()
    End Sub

    Private Sub Question06_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question06.FileOk
        'open the Question 6 file
        Question06.OpenFile()

        'read Question 6 file name
        Q06.Q6GamePlay = IO.File.ReadAllLines(Question06.FileName)

        Question07.Title = "Question 7 File"
        Question07.Filter = "Text Files|*.txt"

        'show the Question 7 File Box
        Question07.ShowDialog()
    End Sub

    Private Sub Question07_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question07.FileOk
        'open the Question 7 file
        Question07.OpenFile()

        'read Question 7 file name
        Q07.Q7GamePlay = IO.File.ReadAllLines(Question07.FileName)

        Question08.Title = "Question 8 File"
        Question08.Filter = "Text Files|*.txt"

        'show the Question 8 File Box
        Question08.ShowDialog()
    End Sub

    Private Sub Question08_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question08.FileOk
        'open the Question 8 file
        Question08.OpenFile()

        'read Question 8 file name
        Q08.Q8GamePlay = IO.File.ReadAllLines(Question08.FileName)

        Question09.Title = "Question 9 File"
        Question09.Filter = "Text Files|*.txt"

        'show the Question 9 File Box
        Question09.ShowDialog()
    End Sub

    Private Sub Question09_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question09.FileOk
        'open the Question 9 file
        Question09.OpenFile()

        'read Question 9 file name
        Q09.Q9GamePlay = IO.File.ReadAllLines(Question09.FileName)

        Question10.Title = "Question 10 File"
        Question10.Filter = "Text Files|*.txt"

        'show the Question 10 File Box
        Question10.ShowDialog()
    End Sub

    Private Sub Question10_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question10.FileOk
        'open the Question 10 file
        Question10.OpenFile()

        'read Question 10 file name
        Q10.Q10GamePlay = IO.File.ReadAllLines(Question10.FileName)

        Question11.Title = "Question 11 File"
        Question11.Filter = "Text Files|*.txt"

        'show the Question 11 File Box
        Question11.ShowDialog()
    End Sub

    Private Sub Question11_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question11.FileOk
        'open the Question 11 file
        Question11.OpenFile()

        'read Question 11 file name
        Q11.Q11GamePlay = IO.File.ReadAllLines(Question11.FileName)

        Question12.Title = "Question 12 File"
        Question12.Filter = "Text Files|*.txt"

        'show the Question 12 File Box
        Question12.ShowDialog()
    End Sub

    Private Sub Question12_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question12.FileOk
        'open the Question 12 file
        Question12.OpenFile()

        'read Question 12 file name
        Q12.Q12GamePlay = IO.File.ReadAllLines(Question12.FileName)

        Question13.Title = "Question 13 File"
        Question13.Filter = "Text Files|*.txt"

        'show the Question 13 File Box
        Question13.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show the AboutBox
        AboutBox.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub

    Private Sub Question13_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question13.FileOk
        'open the Question 13 file
        Question13.OpenFile()

        'read Question 13 file name
        Q13.Q13GamePlay = IO.File.ReadAllLines(Question13.FileName)

        Question14.Title = "Question 14 File"
        Question14.Filter = "Text Files|*.txt"

        'show the Question 14 File Box
        Question14.ShowDialog()
    End Sub

    Private Sub Question14_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question14.FileOk
        'open the Question 14 file
        Question14.OpenFile()

        'read Question 14 file name
        Q14.Q14GamePlay = IO.File.ReadAllLines(Question14.FileName)

        Question15.Title = "Question 15 File"
        Question15.Filter = "Text Files|*.txt"

        'show the Question 15 File Box
        Question15.ShowDialog()
    End Sub

    Private Sub Question15_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Question15.FileOk
        'open the Question 15 file
        Question15.OpenFile()

        'read Question 15 file name
        Q15.Q15GamePlay = IO.File.ReadAllLines(Question15.FileName)

        'show opening theme screen and Player Screen
        OpeningScreen.Show()
        PlayerScreen.Show()
    End Sub
End Class
