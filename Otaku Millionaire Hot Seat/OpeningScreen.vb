Public Class OpeningScreen
    Private Sub OpeningScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'close the Welcome form
        Welcome.Hide()
    End Sub


    Private Sub OpenTheme_Click(sender As Object, e As EventArgs) Handles OpenTheme.Click
        'play opening theme
        My.Computer.Audio.Play(My.Resources.OpeningTheme, AudioPlayMode.Background)

        'show Host Introduction Screen
        EnterHost.Show()

        'close the Opening Theme Screen
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Application.Exit()
    End Sub
End Class