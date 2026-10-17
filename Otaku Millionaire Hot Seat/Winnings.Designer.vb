<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Winnings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Prize = New System.Windows.Forms.Label()
        Me.AmountWon = New System.Windows.Forms.Label()
        Me.EndGame = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndShowLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EndShowLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prize
        '
        Me.Prize.AutoSize = True
        Me.Prize.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prize.Location = New System.Drawing.Point(518, 486)
        Me.Prize.Name = "Prize"
        Me.Prize.Size = New System.Drawing.Size(305, 46)
        Me.Prize.TabIndex = 150
        Me.Prize.Text = "Total Prize Won"
        '
        'AmountWon
        '
        Me.AmountWon.AutoSize = True
        Me.AmountWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountWon.Location = New System.Drawing.Point(518, 552)
        Me.AmountWon.Name = "AmountWon"
        Me.AmountWon.Size = New System.Drawing.Size(64, 46)
        Me.AmountWon.TabIndex = 151
        Me.AmountWon.Text = "¥0"
        '
        'EndGame
        '
        Me.EndGame.Location = New System.Drawing.Point(526, 616)
        Me.EndGame.Name = "EndGame"
        Me.EndGame.Size = New System.Drawing.Size(297, 53)
        Me.EndGame.TabIndex = 152
        Me.EndGame.Text = "End Game"
        Me.EndGame.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 153
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EndShowLogo
        '
        Me.EndShowLogo.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Otaku_Millionaire_Hot_Seat
        Me.EndShowLogo.Location = New System.Drawing.Point(225, 46)
        Me.EndShowLogo.Name = "EndShowLogo"
        Me.EndShowLogo.Size = New System.Drawing.Size(788, 418)
        Me.EndShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EndShowLogo.TabIndex = 4
        Me.EndShowLogo.TabStop = False
        '
        'Winnings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.EndGame)
        Me.Controls.Add(Me.AmountWon)
        Me.Controls.Add(Me.Prize)
        Me.Controls.Add(Me.EndShowLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Winnings"
        Me.Text = "Winnings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EndShowLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EndShowLogo As PictureBox
    Friend WithEvents Prize As Label
    Friend WithEvents AmountWon As Label
    Friend WithEvents EndGame As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
