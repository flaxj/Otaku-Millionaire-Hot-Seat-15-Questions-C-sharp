<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerScreen
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
        Me.AmountWon = New System.Windows.Forms.Label()
        Me.Prize = New System.Windows.Forms.Label()
        Me.EndShowLogo = New System.Windows.Forms.PictureBox()
        Me.QuestionValue = New System.Windows.Forms.Label()
        Me.Topic = New System.Windows.Forms.Label()
        Me.Tenths = New System.Windows.Forms.Label()
        Me.Placeholder = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Question3 = New System.Windows.Forms.Label()
        Me.Question2 = New System.Windows.Forms.Label()
        Me.Question1 = New System.Windows.Forms.Label()
        Me.ChoiceA = New System.Windows.Forms.Label()
        Me.ChoiceB = New System.Windows.Forms.Label()
        Me.ChoiceC = New System.Windows.Forms.Label()
        Me.ChoiceD = New System.Windows.Forms.Label()
        Me.TrustPic = New System.Windows.Forms.PictureBox()
        Me.AskFriendPic = New System.Windows.Forms.PictureBox()
        Me.PassPic = New System.Windows.Forms.PictureBox()
        Me.DoubleDipPic = New System.Windows.Forms.PictureBox()
        Me.AskPic = New System.Windows.Forms.PictureBox()
        Me.Result4 = New System.Windows.Forms.Label()
        Me.Result3 = New System.Windows.Forms.Label()
        Me.Result2 = New System.Windows.Forms.Label()
        Me.Result1 = New System.Windows.Forms.Label()
        Me.D = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.ShowLogo = New System.Windows.Forms.PictureBox()
        Me.PercentA = New System.Windows.Forms.Label()
        Me.PercentB = New System.Windows.Forms.Label()
        Me.PercentC = New System.Windows.Forms.Label()
        Me.PercentD = New System.Windows.Forms.Label()
        Me.Money01 = New System.Windows.Forms.Label()
        Me.Money02 = New System.Windows.Forms.Label()
        Me.Money03 = New System.Windows.Forms.Label()
        Me.Money04 = New System.Windows.Forms.Label()
        Me.Money10 = New System.Windows.Forms.Label()
        Me.Money09 = New System.Windows.Forms.Label()
        Me.Money08 = New System.Windows.Forms.Label()
        Me.Money07 = New System.Windows.Forms.Label()
        Me.Money06 = New System.Windows.Forms.Label()
        Me.Money05 = New System.Windows.Forms.Label()
        Me.Money11 = New System.Windows.Forms.Label()
        Me.Money12 = New System.Windows.Forms.Label()
        Me.Money13 = New System.Windows.Forms.Label()
        Me.Money14 = New System.Windows.Forms.Label()
        Me.Money15 = New System.Windows.Forms.Label()
        Me.Topic15 = New System.Windows.Forms.Label()
        Me.Topic14 = New System.Windows.Forms.Label()
        Me.Topic13 = New System.Windows.Forms.Label()
        Me.Topic01 = New System.Windows.Forms.Label()
        Me.Topic12 = New System.Windows.Forms.Label()
        Me.Topic11 = New System.Windows.Forms.Label()
        Me.Topic10 = New System.Windows.Forms.Label()
        Me.Topic09 = New System.Windows.Forms.Label()
        Me.Topic08 = New System.Windows.Forms.Label()
        Me.Topic07 = New System.Windows.Forms.Label()
        Me.Topic06 = New System.Windows.Forms.Label()
        Me.Topic05 = New System.Windows.Forms.Label()
        Me.Topic04 = New System.Windows.Forms.Label()
        Me.Topic03 = New System.Windows.Forms.Label()
        Me.Topic02 = New System.Windows.Forms.Label()
        CType(Me.EndShowLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmountWon
        '
        Me.AmountWon.AutoSize = True
        Me.AmountWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountWon.Location = New System.Drawing.Point(531, 570)
        Me.AmountWon.Name = "AmountWon"
        Me.AmountWon.Size = New System.Drawing.Size(64, 46)
        Me.AmountWon.TabIndex = 154
        Me.AmountWon.Text = "¥0"
        Me.AmountWon.Visible = False
        '
        'Prize
        '
        Me.Prize.AutoSize = True
        Me.Prize.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prize.Location = New System.Drawing.Point(531, 504)
        Me.Prize.Name = "Prize"
        Me.Prize.Size = New System.Drawing.Size(305, 46)
        Me.Prize.TabIndex = 153
        Me.Prize.Text = "Total Prize Won"
        Me.Prize.Visible = False
        '
        'EndShowLogo
        '
        Me.EndShowLogo.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Otaku_Millionaire_Hot_Seat
        Me.EndShowLogo.Location = New System.Drawing.Point(238, 64)
        Me.EndShowLogo.Name = "EndShowLogo"
        Me.EndShowLogo.Size = New System.Drawing.Size(788, 418)
        Me.EndShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EndShowLogo.TabIndex = 152
        Me.EndShowLogo.TabStop = False
        Me.EndShowLogo.Visible = False
        '
        'QuestionValue
        '
        Me.QuestionValue.AutoSize = True
        Me.QuestionValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionValue.Location = New System.Drawing.Point(65, 64)
        Me.QuestionValue.Name = "QuestionValue"
        Me.QuestionValue.Size = New System.Drawing.Size(108, 46)
        Me.QuestionValue.TabIndex = 228
        Me.QuestionValue.Text = "¥500"
        Me.QuestionValue.Visible = False
        '
        'Topic
        '
        Me.Topic.AutoSize = True
        Me.Topic.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic.Location = New System.Drawing.Point(54, 250)
        Me.Topic.Name = "Topic"
        Me.Topic.Size = New System.Drawing.Size(119, 46)
        Me.Topic.TabIndex = 243
        Me.Topic.Text = "Topic"
        Me.Topic.Visible = False
        '
        'Tenths
        '
        Me.Tenths.AutoSize = True
        Me.Tenths.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenths.Location = New System.Drawing.Point(588, 250)
        Me.Tenths.Name = "Tenths"
        Me.Tenths.Size = New System.Drawing.Size(42, 46)
        Me.Tenths.TabIndex = 242
        Me.Tenths.Text = "0"
        Me.Tenths.Visible = False
        '
        'Placeholder
        '
        Me.Placeholder.AutoSize = True
        Me.Placeholder.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Placeholder.Location = New System.Drawing.Point(568, 250)
        Me.Placeholder.Name = "Placeholder"
        Me.Placeholder.Size = New System.Drawing.Size(31, 46)
        Me.Placeholder.TabIndex = 241
        Me.Placeholder.Text = "."
        Me.Placeholder.Visible = False
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(518, 250)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(64, 46)
        Me.Seconds.TabIndex = 240
        Me.Seconds.Text = "15"
        Me.Seconds.Visible = False
        '
        'Question3
        '
        Me.Question3.AutoSize = True
        Me.Question3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question3.Location = New System.Drawing.Point(95, 455)
        Me.Question3.Name = "Question3"
        Me.Question3.Size = New System.Drawing.Size(202, 46)
        Me.Question3.TabIndex = 239
        Me.Question3.Text = "Question3"
        Me.Question3.Visible = False
        '
        'Question2
        '
        Me.Question2.AutoSize = True
        Me.Question2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question2.Location = New System.Drawing.Point(95, 409)
        Me.Question2.Name = "Question2"
        Me.Question2.Size = New System.Drawing.Size(202, 46)
        Me.Question2.TabIndex = 238
        Me.Question2.Text = "Question2"
        Me.Question2.Visible = False
        '
        'Question1
        '
        Me.Question1.AutoSize = True
        Me.Question1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question1.Location = New System.Drawing.Point(95, 363)
        Me.Question1.Name = "Question1"
        Me.Question1.Size = New System.Drawing.Size(202, 46)
        Me.Question1.TabIndex = 237
        Me.Question1.Text = "Question1"
        Me.Question1.Visible = False
        '
        'ChoiceA
        '
        Me.ChoiceA.AutoSize = True
        Me.ChoiceA.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceA.Location = New System.Drawing.Point(54, 531)
        Me.ChoiceA.Name = "ChoiceA"
        Me.ChoiceA.Size = New System.Drawing.Size(173, 46)
        Me.ChoiceA.TabIndex = 244
        Me.ChoiceA.Text = "ChoiceA"
        Me.ChoiceA.Visible = False
        '
        'ChoiceB
        '
        Me.ChoiceB.AutoSize = True
        Me.ChoiceB.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceB.Location = New System.Drawing.Point(633, 531)
        Me.ChoiceB.Name = "ChoiceB"
        Me.ChoiceB.Size = New System.Drawing.Size(173, 46)
        Me.ChoiceB.TabIndex = 245
        Me.ChoiceB.Text = "ChoiceB"
        Me.ChoiceB.Visible = False
        '
        'ChoiceC
        '
        Me.ChoiceC.AutoSize = True
        Me.ChoiceC.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceC.Location = New System.Drawing.Point(54, 601)
        Me.ChoiceC.Name = "ChoiceC"
        Me.ChoiceC.Size = New System.Drawing.Size(175, 46)
        Me.ChoiceC.TabIndex = 246
        Me.ChoiceC.Text = "ChoiceC"
        Me.ChoiceC.Visible = False
        '
        'ChoiceD
        '
        Me.ChoiceD.AutoSize = True
        Me.ChoiceD.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoiceD.Location = New System.Drawing.Point(633, 601)
        Me.ChoiceD.Name = "ChoiceD"
        Me.ChoiceD.Size = New System.Drawing.Size(175, 46)
        Me.ChoiceD.TabIndex = 247
        Me.ChoiceD.Text = "ChoiceD"
        Me.ChoiceD.Visible = False
        '
        'TrustPic
        '
        Me.TrustPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Trust_the_Computer_lifeline
        Me.TrustPic.Location = New System.Drawing.Point(1046, 41)
        Me.TrustPic.Name = "TrustPic"
        Me.TrustPic.Size = New System.Drawing.Size(100, 50)
        Me.TrustPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TrustPic.TabIndex = 274
        Me.TrustPic.TabStop = False
        Me.TrustPic.Visible = False
        '
        'AskFriendPic
        '
        Me.AskFriendPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_a_Friend_lifeline
        Me.AskFriendPic.Location = New System.Drawing.Point(940, 41)
        Me.AskFriendPic.Name = "AskFriendPic"
        Me.AskFriendPic.Size = New System.Drawing.Size(100, 50)
        Me.AskFriendPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskFriendPic.TabIndex = 273
        Me.AskFriendPic.TabStop = False
        Me.AskFriendPic.Visible = False
        '
        'PassPic
        '
        Me.PassPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.pass_lifeline
        Me.PassPic.Location = New System.Drawing.Point(825, 41)
        Me.PassPic.Name = "PassPic"
        Me.PassPic.Size = New System.Drawing.Size(100, 50)
        Me.PassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassPic.TabIndex = 272
        Me.PassPic.TabStop = False
        Me.PassPic.Visible = False
        '
        'DoubleDipPic
        '
        Me.DoubleDipPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Double_Dip_Lifeline
        Me.DoubleDipPic.Location = New System.Drawing.Point(1152, 41)
        Me.DoubleDipPic.Name = "DoubleDipPic"
        Me.DoubleDipPic.Size = New System.Drawing.Size(100, 50)
        Me.DoubleDipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DoubleDipPic.TabIndex = 275
        Me.DoubleDipPic.TabStop = False
        Me.DoubleDipPic.Visible = False
        '
        'AskPic
        '
        Me.AskPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_lifeline
        Me.AskPic.Location = New System.Drawing.Point(825, 41)
        Me.AskPic.Name = "AskPic"
        Me.AskPic.Size = New System.Drawing.Size(100, 50)
        Me.AskPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskPic.TabIndex = 276
        Me.AskPic.TabStop = False
        Me.AskPic.Visible = False
        '
        'Result4
        '
        Me.Result4.AutoSize = True
        Me.Result4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result4.Location = New System.Drawing.Point(613, 88)
        Me.Result4.Name = "Result4"
        Me.Result4.Size = New System.Drawing.Size(42, 46)
        Me.Result4.TabIndex = 285
        Me.Result4.Text = "0"
        Me.Result4.Visible = False
        '
        'Result3
        '
        Me.Result3.AutoSize = True
        Me.Result3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result3.Location = New System.Drawing.Point(359, 88)
        Me.Result3.Name = "Result3"
        Me.Result3.Size = New System.Drawing.Size(42, 46)
        Me.Result3.TabIndex = 284
        Me.Result3.Text = "0"
        Me.Result3.Visible = False
        '
        'Result2
        '
        Me.Result2.AutoSize = True
        Me.Result2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result2.Location = New System.Drawing.Point(613, 28)
        Me.Result2.Name = "Result2"
        Me.Result2.Size = New System.Drawing.Size(42, 46)
        Me.Result2.TabIndex = 283
        Me.Result2.Text = "0"
        Me.Result2.Visible = False
        '
        'Result1
        '
        Me.Result1.AutoSize = True
        Me.Result1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result1.Location = New System.Drawing.Point(359, 28)
        Me.Result1.Name = "Result1"
        Me.Result1.Size = New System.Drawing.Size(42, 46)
        Me.Result1.TabIndex = 282
        Me.Result1.Text = "0"
        Me.Result1.Visible = False
        '
        'D
        '
        Me.D.AutoSize = True
        Me.D.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D.Location = New System.Drawing.Point(516, 88)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(49, 46)
        Me.D.TabIndex = 281
        Me.D.Text = "D"
        Me.D.Visible = False
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(278, 88)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(49, 46)
        Me.C.TabIndex = 280
        Me.C.Text = "C"
        Me.C.Visible = False
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(518, 28)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(47, 46)
        Me.B.TabIndex = 279
        Me.B.Text = "B"
        Me.B.Visible = False
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(280, 28)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(47, 46)
        Me.A.TabIndex = 278
        Me.A.Text = "A"
        Me.A.Visible = False
        '
        'ShowLogo
        '
        Me.ShowLogo.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Otaku_Millionaire_Hot_Seat
        Me.ShowLogo.Location = New System.Drawing.Point(73, 31)
        Me.ShowLogo.Name = "ShowLogo"
        Me.ShowLogo.Size = New System.Drawing.Size(1121, 619)
        Me.ShowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ShowLogo.TabIndex = 286
        Me.ShowLogo.TabStop = False
        '
        'PercentA
        '
        Me.PercentA.AutoSize = True
        Me.PercentA.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentA.Location = New System.Drawing.Point(442, 28)
        Me.PercentA.Name = "PercentA"
        Me.PercentA.Size = New System.Drawing.Size(55, 46)
        Me.PercentA.TabIndex = 287
        Me.PercentA.Text = "%"
        Me.PercentA.Visible = False
        '
        'PercentB
        '
        Me.PercentB.AutoSize = True
        Me.PercentB.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentB.Location = New System.Drawing.Point(715, 28)
        Me.PercentB.Name = "PercentB"
        Me.PercentB.Size = New System.Drawing.Size(55, 46)
        Me.PercentB.TabIndex = 288
        Me.PercentB.Text = "%"
        Me.PercentB.Visible = False
        '
        'PercentC
        '
        Me.PercentC.AutoSize = True
        Me.PercentC.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentC.Location = New System.Drawing.Point(442, 88)
        Me.PercentC.Name = "PercentC"
        Me.PercentC.Size = New System.Drawing.Size(55, 46)
        Me.PercentC.TabIndex = 289
        Me.PercentC.Text = "%"
        Me.PercentC.Visible = False
        '
        'PercentD
        '
        Me.PercentD.AutoSize = True
        Me.PercentD.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentD.Location = New System.Drawing.Point(715, 88)
        Me.PercentD.Name = "PercentD"
        Me.PercentD.Size = New System.Drawing.Size(55, 46)
        Me.PercentD.TabIndex = 290
        Me.PercentD.Text = "%"
        Me.PercentD.Visible = False
        '
        'Money01
        '
        Me.Money01.AutoSize = True
        Me.Money01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money01.Location = New System.Drawing.Point(946, 580)
        Me.Money01.Name = "Money01"
        Me.Money01.Size = New System.Drawing.Size(79, 33)
        Me.Money01.TabIndex = 337
        Me.Money01.Text = "¥100"
        Me.Money01.Visible = False
        '
        'Money02
        '
        Me.Money02.AutoSize = True
        Me.Money02.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money02.Location = New System.Drawing.Point(946, 547)
        Me.Money02.Name = "Money02"
        Me.Money02.Size = New System.Drawing.Size(79, 33)
        Me.Money02.TabIndex = 349
        Me.Money02.Text = "¥200"
        Me.Money02.Visible = False
        '
        'Money03
        '
        Me.Money03.AutoSize = True
        Me.Money03.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money03.Location = New System.Drawing.Point(946, 514)
        Me.Money03.Name = "Money03"
        Me.Money03.Size = New System.Drawing.Size(79, 33)
        Me.Money03.TabIndex = 351
        Me.Money03.Text = "¥300"
        Me.Money03.Visible = False
        '
        'Money04
        '
        Me.Money04.AutoSize = True
        Me.Money04.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money04.Location = New System.Drawing.Point(946, 481)
        Me.Money04.Name = "Money04"
        Me.Money04.Size = New System.Drawing.Size(79, 33)
        Me.Money04.TabIndex = 350
        Me.Money04.Text = "¥500"
        Me.Money04.Visible = False
        '
        'Money10
        '
        Me.Money10.AutoSize = True
        Me.Money10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money10.Location = New System.Drawing.Point(945, 283)
        Me.Money10.Name = "Money10"
        Me.Money10.Size = New System.Drawing.Size(119, 33)
        Me.Money10.TabIndex = 343
        Me.Money10.Text = "¥10,000"
        Me.Money10.Visible = False
        '
        'Money09
        '
        Me.Money09.AutoSize = True
        Me.Money09.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money09.Location = New System.Drawing.Point(948, 316)
        Me.Money09.Name = "Money09"
        Me.Money09.Size = New System.Drawing.Size(103, 33)
        Me.Money09.TabIndex = 342
        Me.Money09.Text = "¥6,000"
        Me.Money09.Visible = False
        '
        'Money08
        '
        Me.Money08.AutoSize = True
        Me.Money08.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money08.Location = New System.Drawing.Point(951, 349)
        Me.Money08.Name = "Money08"
        Me.Money08.Size = New System.Drawing.Size(103, 33)
        Me.Money08.TabIndex = 341
        Me.Money08.Text = "¥4,000"
        Me.Money08.Visible = False
        '
        'Money07
        '
        Me.Money07.AutoSize = True
        Me.Money07.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money07.Location = New System.Drawing.Point(949, 382)
        Me.Money07.Name = "Money07"
        Me.Money07.Size = New System.Drawing.Size(103, 33)
        Me.Money07.TabIndex = 340
        Me.Money07.Text = "¥2,500"
        Me.Money07.Visible = False
        '
        'Money06
        '
        Me.Money06.AutoSize = True
        Me.Money06.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money06.Location = New System.Drawing.Point(945, 415)
        Me.Money06.Name = "Money06"
        Me.Money06.Size = New System.Drawing.Size(103, 33)
        Me.Money06.TabIndex = 339
        Me.Money06.Text = "¥1,500"
        Me.Money06.Visible = False
        '
        'Money05
        '
        Me.Money05.AutoSize = True
        Me.Money05.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money05.Location = New System.Drawing.Point(945, 448)
        Me.Money05.Name = "Money05"
        Me.Money05.Size = New System.Drawing.Size(109, 33)
        Me.Money05.TabIndex = 338
        Me.Money05.Text = "¥1,000"
        Me.Money05.Visible = False
        '
        'Money11
        '
        Me.Money11.AutoSize = True
        Me.Money11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money11.Location = New System.Drawing.Point(948, 247)
        Me.Money11.Name = "Money11"
        Me.Money11.Size = New System.Drawing.Size(119, 33)
        Me.Money11.TabIndex = 344
        Me.Money11.Text = "¥20,000"
        Me.Money11.Visible = False
        '
        'Money12
        '
        Me.Money12.AutoSize = True
        Me.Money12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money12.Location = New System.Drawing.Point(949, 214)
        Me.Money12.Name = "Money12"
        Me.Money12.Size = New System.Drawing.Size(119, 33)
        Me.Money12.TabIndex = 345
        Me.Money12.Text = "¥50,000"
        Me.Money12.Visible = False
        '
        'Money13
        '
        Me.Money13.AutoSize = True
        Me.Money13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money13.Location = New System.Drawing.Point(949, 181)
        Me.Money13.Name = "Money13"
        Me.Money13.Size = New System.Drawing.Size(135, 33)
        Me.Money13.TabIndex = 346
        Me.Money13.Text = "¥100,000"
        Me.Money13.Visible = False
        '
        'Money14
        '
        Me.Money14.AutoSize = True
        Me.Money14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money14.Location = New System.Drawing.Point(945, 148)
        Me.Money14.Name = "Money14"
        Me.Money14.Size = New System.Drawing.Size(135, 33)
        Me.Money14.TabIndex = 347
        Me.Money14.Text = "¥250,000"
        Me.Money14.Visible = False
        '
        'Money15
        '
        Me.Money15.AutoSize = True
        Me.Money15.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money15.Location = New System.Drawing.Point(945, 115)
        Me.Money15.Name = "Money15"
        Me.Money15.Size = New System.Drawing.Size(169, 33)
        Me.Money15.TabIndex = 348
        Me.Money15.Text = "¥1,000,000"
        Me.Money15.Visible = False
        '
        'Topic15
        '
        Me.Topic15.AutoSize = True
        Me.Topic15.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic15.Location = New System.Drawing.Point(950, 115)
        Me.Topic15.Name = "Topic15"
        Me.Topic15.Size = New System.Drawing.Size(118, 33)
        Me.Topic15.TabIndex = 354
        Me.Topic15.Text = "Label15"
        Me.Topic15.Visible = False
        '
        'Topic14
        '
        Me.Topic14.AutoSize = True
        Me.Topic14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic14.Location = New System.Drawing.Point(950, 148)
        Me.Topic14.Name = "Topic14"
        Me.Topic14.Size = New System.Drawing.Size(118, 33)
        Me.Topic14.TabIndex = 353
        Me.Topic14.Text = "Label14"
        Me.Topic14.Visible = False
        '
        'Topic13
        '
        Me.Topic13.AutoSize = True
        Me.Topic13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic13.Location = New System.Drawing.Point(950, 181)
        Me.Topic13.Name = "Topic13"
        Me.Topic13.Size = New System.Drawing.Size(118, 33)
        Me.Topic13.TabIndex = 352
        Me.Topic13.Text = "Label13"
        Me.Topic13.Visible = False
        '
        'Topic01
        '
        Me.Topic01.AutoSize = True
        Me.Topic01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic01.Location = New System.Drawing.Point(945, 580)
        Me.Topic01.Name = "Topic01"
        Me.Topic01.Size = New System.Drawing.Size(102, 33)
        Me.Topic01.TabIndex = 325
        Me.Topic01.Text = "Label1"
        Me.Topic01.Visible = False
        '
        'Topic12
        '
        Me.Topic12.AutoSize = True
        Me.Topic12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic12.Location = New System.Drawing.Point(952, 214)
        Me.Topic12.Name = "Topic12"
        Me.Topic12.Size = New System.Drawing.Size(118, 33)
        Me.Topic12.TabIndex = 336
        Me.Topic12.Text = "Label12"
        Me.Topic12.Visible = False
        '
        'Topic11
        '
        Me.Topic11.AutoSize = True
        Me.Topic11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic11.Location = New System.Drawing.Point(951, 247)
        Me.Topic11.Name = "Topic11"
        Me.Topic11.Size = New System.Drawing.Size(118, 33)
        Me.Topic11.TabIndex = 335
        Me.Topic11.Text = "Label11"
        Me.Topic11.Visible = False
        '
        'Topic10
        '
        Me.Topic10.AutoSize = True
        Me.Topic10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic10.Location = New System.Drawing.Point(948, 283)
        Me.Topic10.Name = "Topic10"
        Me.Topic10.Size = New System.Drawing.Size(118, 33)
        Me.Topic10.TabIndex = 334
        Me.Topic10.Text = "Label10"
        Me.Topic10.Visible = False
        '
        'Topic09
        '
        Me.Topic09.AutoSize = True
        Me.Topic09.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic09.Location = New System.Drawing.Point(952, 316)
        Me.Topic09.Name = "Topic09"
        Me.Topic09.Size = New System.Drawing.Size(102, 33)
        Me.Topic09.TabIndex = 333
        Me.Topic09.Text = "Label9"
        Me.Topic09.Visible = False
        '
        'Topic08
        '
        Me.Topic08.AutoSize = True
        Me.Topic08.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic08.Location = New System.Drawing.Point(950, 349)
        Me.Topic08.Name = "Topic08"
        Me.Topic08.Size = New System.Drawing.Size(102, 33)
        Me.Topic08.TabIndex = 332
        Me.Topic08.Text = "Label8"
        Me.Topic08.Visible = False
        '
        'Topic07
        '
        Me.Topic07.AutoSize = True
        Me.Topic07.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic07.Location = New System.Drawing.Point(951, 382)
        Me.Topic07.Name = "Topic07"
        Me.Topic07.Size = New System.Drawing.Size(102, 33)
        Me.Topic07.TabIndex = 331
        Me.Topic07.Text = "Label7"
        Me.Topic07.Visible = False
        '
        'Topic06
        '
        Me.Topic06.AutoSize = True
        Me.Topic06.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic06.Location = New System.Drawing.Point(952, 415)
        Me.Topic06.Name = "Topic06"
        Me.Topic06.Size = New System.Drawing.Size(102, 33)
        Me.Topic06.TabIndex = 330
        Me.Topic06.Text = "Label6"
        Me.Topic06.Visible = False
        '
        'Topic05
        '
        Me.Topic05.AutoSize = True
        Me.Topic05.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic05.Location = New System.Drawing.Point(952, 448)
        Me.Topic05.Name = "Topic05"
        Me.Topic05.Size = New System.Drawing.Size(102, 33)
        Me.Topic05.TabIndex = 329
        Me.Topic05.Text = "Label5"
        Me.Topic05.Visible = False
        '
        'Topic04
        '
        Me.Topic04.AutoSize = True
        Me.Topic04.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic04.Location = New System.Drawing.Point(948, 481)
        Me.Topic04.Name = "Topic04"
        Me.Topic04.Size = New System.Drawing.Size(102, 33)
        Me.Topic04.TabIndex = 328
        Me.Topic04.Text = "Label4"
        Me.Topic04.Visible = False
        '
        'Topic03
        '
        Me.Topic03.AutoSize = True
        Me.Topic03.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic03.Location = New System.Drawing.Point(952, 514)
        Me.Topic03.Name = "Topic03"
        Me.Topic03.Size = New System.Drawing.Size(102, 33)
        Me.Topic03.TabIndex = 327
        Me.Topic03.Text = "Label3"
        Me.Topic03.Visible = False
        '
        'Topic02
        '
        Me.Topic02.AutoSize = True
        Me.Topic02.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic02.Location = New System.Drawing.Point(945, 547)
        Me.Topic02.Name = "Topic02"
        Me.Topic02.Size = New System.Drawing.Size(102, 33)
        Me.Topic02.TabIndex = 326
        Me.Topic02.Text = "Label2"
        Me.Topic02.Visible = False
        '
        'PlayerScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.ShowLogo)
        Me.Controls.Add(Me.Money01)
        Me.Controls.Add(Me.Money02)
        Me.Controls.Add(Me.Money03)
        Me.Controls.Add(Me.Money04)
        Me.Controls.Add(Me.Money10)
        Me.Controls.Add(Me.Money09)
        Me.Controls.Add(Me.Money08)
        Me.Controls.Add(Me.Money07)
        Me.Controls.Add(Me.Money06)
        Me.Controls.Add(Me.Money05)
        Me.Controls.Add(Me.Money11)
        Me.Controls.Add(Me.Money12)
        Me.Controls.Add(Me.Money13)
        Me.Controls.Add(Me.Money14)
        Me.Controls.Add(Me.Money15)
        Me.Controls.Add(Me.Topic15)
        Me.Controls.Add(Me.Topic14)
        Me.Controls.Add(Me.Topic13)
        Me.Controls.Add(Me.Topic01)
        Me.Controls.Add(Me.Topic12)
        Me.Controls.Add(Me.Topic11)
        Me.Controls.Add(Me.Topic10)
        Me.Controls.Add(Me.Topic09)
        Me.Controls.Add(Me.Topic08)
        Me.Controls.Add(Me.Topic07)
        Me.Controls.Add(Me.Topic06)
        Me.Controls.Add(Me.Topic05)
        Me.Controls.Add(Me.Topic04)
        Me.Controls.Add(Me.Topic03)
        Me.Controls.Add(Me.Topic02)
        Me.Controls.Add(Me.PercentD)
        Me.Controls.Add(Me.PercentC)
        Me.Controls.Add(Me.PercentB)
        Me.Controls.Add(Me.PercentA)
        Me.Controls.Add(Me.Result4)
        Me.Controls.Add(Me.Result3)
        Me.Controls.Add(Me.Result2)
        Me.Controls.Add(Me.Result1)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.TrustPic)
        Me.Controls.Add(Me.AskFriendPic)
        Me.Controls.Add(Me.ChoiceD)
        Me.Controls.Add(Me.ChoiceC)
        Me.Controls.Add(Me.ChoiceB)
        Me.Controls.Add(Me.ChoiceA)
        Me.Controls.Add(Me.Topic)
        Me.Controls.Add(Me.Tenths)
        Me.Controls.Add(Me.Placeholder)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Question3)
        Me.Controls.Add(Me.Question2)
        Me.Controls.Add(Me.Question1)
        Me.Controls.Add(Me.QuestionValue)
        Me.Controls.Add(Me.AmountWon)
        Me.Controls.Add(Me.Prize)
        Me.Controls.Add(Me.PassPic)
        Me.Controls.Add(Me.EndShowLogo)
        Me.Controls.Add(Me.AskPic)
        Me.Controls.Add(Me.DoubleDipPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "PlayerScreen"
        Me.Text = "Player Screen"
        CType(Me.EndShowLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AmountWon As Label
    Friend WithEvents Prize As Label
    Friend WithEvents EndShowLogo As PictureBox
    Friend WithEvents QuestionValue As Label
    Friend WithEvents Topic As Label
    Friend WithEvents Tenths As Label
    Friend WithEvents Placeholder As Label
    Friend WithEvents Seconds As Label
    Friend WithEvents Question3 As Label
    Friend WithEvents Question2 As Label
    Friend WithEvents Question1 As Label
    Friend WithEvents ChoiceA As Label
    Friend WithEvents ChoiceB As Label
    Friend WithEvents ChoiceC As Label
    Friend WithEvents ChoiceD As Label
    Friend WithEvents TrustPic As PictureBox
    Friend WithEvents AskFriendPic As PictureBox
    Friend WithEvents PassPic As PictureBox
    Friend WithEvents DoubleDipPic As PictureBox
    Friend WithEvents AskPic As PictureBox
    Friend WithEvents Result4 As Label
    Friend WithEvents Result3 As Label
    Friend WithEvents Result2 As Label
    Friend WithEvents Result1 As Label
    Friend WithEvents D As Label
    Friend WithEvents C As Label
    Friend WithEvents B As Label
    Friend WithEvents A As Label
    Friend WithEvents ShowLogo As PictureBox
    Friend WithEvents PercentA As Label
    Friend WithEvents PercentB As Label
    Friend WithEvents PercentC As Label
    Friend WithEvents PercentD As Label
    Friend WithEvents Money01 As Label
    Friend WithEvents Money02 As Label
    Friend WithEvents Money03 As Label
    Friend WithEvents Money04 As Label
    Friend WithEvents Money10 As Label
    Friend WithEvents Money09 As Label
    Friend WithEvents Money08 As Label
    Friend WithEvents Money07 As Label
    Friend WithEvents Money06 As Label
    Friend WithEvents Money05 As Label
    Friend WithEvents Money11 As Label
    Friend WithEvents Money12 As Label
    Friend WithEvents Money13 As Label
    Friend WithEvents Money14 As Label
    Friend WithEvents Money15 As Label
    Friend WithEvents Topic15 As Label
    Friend WithEvents Topic14 As Label
    Friend WithEvents Topic13 As Label
    Friend WithEvents Topic01 As Label
    Friend WithEvents Topic12 As Label
    Friend WithEvents Topic11 As Label
    Friend WithEvents Topic10 As Label
    Friend WithEvents Topic09 As Label
    Friend WithEvents Topic08 As Label
    Friend WithEvents Topic07 As Label
    Friend WithEvents Topic06 As Label
    Friend WithEvents Topic05 As Label
    Friend WithEvents Topic04 As Label
    Friend WithEvents Topic03 As Label
    Friend WithEvents Topic02 As Label
End Class
