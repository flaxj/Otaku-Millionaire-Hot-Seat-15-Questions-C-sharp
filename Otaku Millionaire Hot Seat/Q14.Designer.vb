<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Q14
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AskPic = New System.Windows.Forms.PictureBox()
        Me.DoubleDipPic = New System.Windows.Forms.PictureBox()
        Me.TrustPic = New System.Windows.Forms.PictureBox()
        Me.AskFriendPic = New System.Windows.Forms.PictureBox()
        Me.PlayersRemaining = New System.Windows.Forms.Label()
        Me.Topic = New System.Windows.Forms.Label()
        Me.MasterButton = New System.Windows.Forms.Button()
        Me.Tenths = New System.Windows.Forms.Label()
        Me.Placeholder = New System.Windows.Forms.Label()
        Me.Incorrect = New System.Windows.Forms.Label()
        Me.Correct = New System.Windows.Forms.Label()
        Me.SecondsClock = New System.Windows.Forms.Timer(Me.components)
        Me.AmountAtRisk = New System.Windows.Forms.Label()
        Me.TopPrizeQuestionRemaining = New System.Windows.Forms.Label()
        Me.TopPrizeAmount = New System.Windows.Forms.Label()
        Me.QuestionValue = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.ChoiceC = New System.Windows.Forms.CheckBox()
        Me.ChoiceB = New System.Windows.Forms.CheckBox()
        Me.ChoiceA = New System.Windows.Forms.CheckBox()
        Me.Question3 = New System.Windows.Forms.Label()
        Me.Question2 = New System.Windows.Forms.Label()
        Me.Question1 = New System.Windows.Forms.Label()
        Me.TenthsClock = New System.Windows.Forms.Timer(Me.components)
        Me.ChoiceD = New System.Windows.Forms.CheckBox()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AskPic
        '
        Me.AskPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_lifeline
        Me.AskPic.Location = New System.Drawing.Point(806, 41)
        Me.AskPic.Name = "AskPic"
        Me.AskPic.Size = New System.Drawing.Size(100, 50)
        Me.AskPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskPic.TabIndex = 264
        Me.AskPic.TabStop = False
        '
        'DoubleDipPic
        '
        Me.DoubleDipPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Double_Dip_Lifeline
        Me.DoubleDipPic.Location = New System.Drawing.Point(1124, 41)
        Me.DoubleDipPic.Name = "DoubleDipPic"
        Me.DoubleDipPic.Size = New System.Drawing.Size(100, 50)
        Me.DoubleDipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DoubleDipPic.TabIndex = 263
        Me.DoubleDipPic.TabStop = False
        '
        'TrustPic
        '
        Me.TrustPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Trust_the_Computer_lifeline
        Me.TrustPic.Location = New System.Drawing.Point(1018, 41)
        Me.TrustPic.Name = "TrustPic"
        Me.TrustPic.Size = New System.Drawing.Size(100, 50)
        Me.TrustPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TrustPic.TabIndex = 262
        Me.TrustPic.TabStop = False
        '
        'AskFriendPic
        '
        Me.AskFriendPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_a_Friend_lifeline
        Me.AskFriendPic.Location = New System.Drawing.Point(912, 41)
        Me.AskFriendPic.Name = "AskFriendPic"
        Me.AskFriendPic.Size = New System.Drawing.Size(100, 50)
        Me.AskFriendPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskFriendPic.TabIndex = 261
        Me.AskFriendPic.TabStop = False
        '
        'PlayersRemaining
        '
        Me.PlayersRemaining.AutoSize = True
        Me.PlayersRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayersRemaining.Location = New System.Drawing.Point(778, 108)
        Me.PlayersRemaining.Name = "PlayersRemaining"
        Me.PlayersRemaining.Size = New System.Drawing.Size(42, 46)
        Me.PlayersRemaining.TabIndex = 260
        Me.PlayersRemaining.Text = "6"
        '
        'Topic
        '
        Me.Topic.AutoSize = True
        Me.Topic.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic.Location = New System.Drawing.Point(40, 205)
        Me.Topic.Name = "Topic"
        Me.Topic.Size = New System.Drawing.Size(119, 46)
        Me.Topic.TabIndex = 259
        Me.Topic.Text = "Topic"
        '
        'MasterButton
        '
        Me.MasterButton.Location = New System.Drawing.Point(1025, 131)
        Me.MasterButton.Name = "MasterButton"
        Me.MasterButton.Size = New System.Drawing.Size(183, 73)
        Me.MasterButton.TabIndex = 258
        Me.MasterButton.Text = "Show Question"
        Me.MasterButton.UseVisualStyleBackColor = True
        '
        'Tenths
        '
        Me.Tenths.AutoSize = True
        Me.Tenths.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenths.Location = New System.Drawing.Point(574, 205)
        Me.Tenths.Name = "Tenths"
        Me.Tenths.Size = New System.Drawing.Size(42, 46)
        Me.Tenths.TabIndex = 257
        Me.Tenths.Text = "0"
        '
        'Placeholder
        '
        Me.Placeholder.AutoSize = True
        Me.Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Placeholder.Location = New System.Drawing.Point(554, 205)
        Me.Placeholder.Name = "Placeholder"
        Me.Placeholder.Size = New System.Drawing.Size(31, 46)
        Me.Placeholder.TabIndex = 256
        Me.Placeholder.Text = "."
        '
        'Incorrect
        '
        Me.Incorrect.AutoSize = True
        Me.Incorrect.BackColor = System.Drawing.Color.Red
        Me.Incorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Incorrect.Location = New System.Drawing.Point(722, 108)
        Me.Incorrect.Name = "Incorrect"
        Me.Incorrect.Size = New System.Drawing.Size(30, 46)
        Me.Incorrect.TabIndex = 255
        Me.Incorrect.Text = "I"
        Me.Incorrect.Visible = False
        '
        'Correct
        '
        Me.Correct.AutoSize = True
        Me.Correct.BackColor = System.Drawing.Color.Green
        Me.Correct.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correct.ForeColor = System.Drawing.Color.White
        Me.Correct.Location = New System.Drawing.Point(643, 108)
        Me.Correct.Name = "Correct"
        Me.Correct.Size = New System.Drawing.Size(49, 46)
        Me.Correct.TabIndex = 254
        Me.Correct.Text = "C"
        Me.Correct.Visible = False
        '
        'SecondsClock
        '
        Me.SecondsClock.Interval = 1000
        '
        'AmountAtRisk
        '
        Me.AmountAtRisk.AutoSize = True
        Me.AmountAtRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountAtRisk.Location = New System.Drawing.Point(318, 108)
        Me.AmountAtRisk.Name = "AmountAtRisk"
        Me.AmountAtRisk.Size = New System.Drawing.Size(185, 46)
        Me.AmountAtRisk.TabIndex = 253
        Me.AmountAtRisk.Text = "¥750,000"
        '
        'TopPrizeQuestionRemaining
        '
        Me.TopPrizeQuestionRemaining.AutoSize = True
        Me.TopPrizeQuestionRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopPrizeQuestionRemaining.Location = New System.Drawing.Point(643, 41)
        Me.TopPrizeQuestionRemaining.Name = "TopPrizeQuestionRemaining"
        Me.TopPrizeQuestionRemaining.Size = New System.Drawing.Size(64, 46)
        Me.TopPrizeQuestionRemaining.TabIndex = 252
        Me.TopPrizeQuestionRemaining.Text = "12"
        '
        'TopPrizeAmount
        '
        Me.TopPrizeAmount.AutoSize = True
        Me.TopPrizeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopPrizeAmount.Location = New System.Drawing.Point(318, 41)
        Me.TopPrizeAmount.Name = "TopPrizeAmount"
        Me.TopPrizeAmount.Size = New System.Drawing.Size(218, 46)
        Me.TopPrizeAmount.TabIndex = 251
        Me.TopPrizeAmount.Text = "¥1,000,000"
        '
        'QuestionValue
        '
        Me.QuestionValue.AutoSize = True
        Me.QuestionValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionValue.Location = New System.Drawing.Point(52, 41)
        Me.QuestionValue.Name = "QuestionValue"
        Me.QuestionValue.Size = New System.Drawing.Size(108, 46)
        Me.QuestionValue.TabIndex = 250
        Me.QuestionValue.Text = "¥500"
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(504, 205)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(64, 46)
        Me.Seconds.TabIndex = 249
        Me.Seconds.Text = "45"
        '
        'ChoiceC
        '
        Me.ChoiceC.AutoSize = True
        Me.ChoiceC.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceC.Location = New System.Drawing.Point(48, 589)
        Me.ChoiceC.Name = "ChoiceC"
        Me.ChoiceC.Size = New System.Drawing.Size(194, 50)
        Me.ChoiceC.TabIndex = 247
        Me.ChoiceC.Text = "ChoiceC"
        Me.ChoiceC.UseVisualStyleBackColor = True
        Me.ChoiceC.Visible = False
        '
        'ChoiceB
        '
        Me.ChoiceB.AutoSize = True
        Me.ChoiceB.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceB.Location = New System.Drawing.Point(690, 501)
        Me.ChoiceB.Name = "ChoiceB"
        Me.ChoiceB.Size = New System.Drawing.Size(192, 50)
        Me.ChoiceB.TabIndex = 246
        Me.ChoiceB.Text = "ChoiceB"
        Me.ChoiceB.UseVisualStyleBackColor = True
        Me.ChoiceB.Visible = False
        '
        'ChoiceA
        '
        Me.ChoiceA.AutoSize = True
        Me.ChoiceA.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceA.Location = New System.Drawing.Point(48, 501)
        Me.ChoiceA.Name = "ChoiceA"
        Me.ChoiceA.Size = New System.Drawing.Size(192, 50)
        Me.ChoiceA.TabIndex = 245
        Me.ChoiceA.Text = "ChoiceA"
        Me.ChoiceA.UseVisualStyleBackColor = True
        Me.ChoiceA.Visible = False
        '
        'Question3
        '
        Me.Question3.AutoSize = True
        Me.Question3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question3.Location = New System.Drawing.Point(81, 410)
        Me.Question3.Name = "Question3"
        Me.Question3.Size = New System.Drawing.Size(202, 46)
        Me.Question3.TabIndex = 244
        Me.Question3.Text = "Question3"
        Me.Question3.Visible = False
        '
        'Question2
        '
        Me.Question2.AutoSize = True
        Me.Question2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question2.Location = New System.Drawing.Point(81, 364)
        Me.Question2.Name = "Question2"
        Me.Question2.Size = New System.Drawing.Size(202, 46)
        Me.Question2.TabIndex = 243
        Me.Question2.Text = "Question2"
        Me.Question2.Visible = False
        '
        'Question1
        '
        Me.Question1.AutoSize = True
        Me.Question1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question1.Location = New System.Drawing.Point(81, 318)
        Me.Question1.Name = "Question1"
        Me.Question1.Size = New System.Drawing.Size(202, 46)
        Me.Question1.TabIndex = 242
        Me.Question1.Text = "Question1"
        Me.Question1.Visible = False
        '
        'ChoiceD
        '
        Me.ChoiceD.AutoSize = True
        Me.ChoiceD.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceD.Location = New System.Drawing.Point(690, 589)
        Me.ChoiceD.Name = "ChoiceD"
        Me.ChoiceD.Size = New System.Drawing.Size(194, 50)
        Me.ChoiceD.TabIndex = 248
        Me.ChoiceD.Text = "ChoiceD"
        Me.ChoiceD.UseVisualStyleBackColor = True
        Me.ChoiceD.Visible = False
        '
        'Q14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.AskPic)
        Me.Controls.Add(Me.DoubleDipPic)
        Me.Controls.Add(Me.TrustPic)
        Me.Controls.Add(Me.AskFriendPic)
        Me.Controls.Add(Me.PlayersRemaining)
        Me.Controls.Add(Me.Topic)
        Me.Controls.Add(Me.MasterButton)
        Me.Controls.Add(Me.Tenths)
        Me.Controls.Add(Me.Placeholder)
        Me.Controls.Add(Me.Incorrect)
        Me.Controls.Add(Me.Correct)
        Me.Controls.Add(Me.AmountAtRisk)
        Me.Controls.Add(Me.TopPrizeQuestionRemaining)
        Me.Controls.Add(Me.TopPrizeAmount)
        Me.Controls.Add(Me.QuestionValue)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.ChoiceC)
        Me.Controls.Add(Me.ChoiceB)
        Me.Controls.Add(Me.ChoiceA)
        Me.Controls.Add(Me.Question3)
        Me.Controls.Add(Me.Question2)
        Me.Controls.Add(Me.Question1)
        Me.Controls.Add(Me.ChoiceD)
        Me.Name = "Q14"
        Me.Text = "Q14"
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AskPic As PictureBox
    Friend WithEvents DoubleDipPic As PictureBox
    Friend WithEvents TrustPic As PictureBox
    Friend WithEvents AskFriendPic As PictureBox
    Friend WithEvents PlayersRemaining As Label
    Friend WithEvents Topic As Label
    Friend WithEvents MasterButton As Button
    Friend WithEvents Tenths As Label
    Friend WithEvents Placeholder As Label
    Friend WithEvents Incorrect As Label
    Friend WithEvents Correct As Label
    Friend WithEvents SecondsClock As Timer
    Friend WithEvents AmountAtRisk As Label
    Friend WithEvents TopPrizeQuestionRemaining As Label
    Friend WithEvents TopPrizeAmount As Label
    Friend WithEvents QuestionValue As Label
    Friend WithEvents Seconds As Label
    Friend WithEvents ChoiceC As CheckBox
    Friend WithEvents ChoiceB As CheckBox
    Friend WithEvents ChoiceA As CheckBox
    Friend WithEvents Question3 As Label
    Friend WithEvents Question2 As Label
    Friend WithEvents Question1 As Label
    Friend WithEvents TenthsClock As Timer
    Friend WithEvents ChoiceD As CheckBox
End Class
