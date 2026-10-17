<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level1MoneyTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level1MoneyTree))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMoneyTree = New System.Windows.Forms.Button()
        Me.Transition = New System.Windows.Forms.Button()
        Me.StartGame = New System.Windows.Forms.Button()
        Me.MoneyTreeClock = New System.Windows.Forms.Timer(Me.components)
        Me.MainDetail1 = New System.Windows.Forms.Label()
        Me.Level1Label = New System.Windows.Forms.Label()
        Me.Level1Rules = New System.Windows.Forms.Label()
        Me.AskPic = New System.Windows.Forms.PictureBox()
        Me.DoubleDipPic = New System.Windows.Forms.PictureBox()
        Me.TrustPic = New System.Windows.Forms.PictureBox()
        Me.AskFriendPic = New System.Windows.Forms.PictureBox()
        Me.PassPic = New System.Windows.Forms.PictureBox()
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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowMoneyTree
        '
        Me.ShowMoneyTree.Location = New System.Drawing.Point(49, 72)
        Me.ShowMoneyTree.Name = "ShowMoneyTree"
        Me.ShowMoneyTree.Size = New System.Drawing.Size(240, 126)
        Me.ShowMoneyTree.TabIndex = 61
        Me.ShowMoneyTree.Text = "Show Money Tree"
        Me.ShowMoneyTree.UseVisualStyleBackColor = True
        '
        'Transition
        '
        Me.Transition.Location = New System.Drawing.Point(295, 72)
        Me.Transition.Name = "Transition"
        Me.Transition.Size = New System.Drawing.Size(238, 126)
        Me.Transition.TabIndex = 62
        Me.Transition.Text = "Show Lifelines"
        Me.Transition.UseVisualStyleBackColor = True
        Me.Transition.Visible = False
        '
        'StartGame
        '
        Me.StartGame.Location = New System.Drawing.Point(539, 72)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(251, 126)
        Me.StartGame.TabIndex = 63
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = True
        Me.StartGame.Visible = False
        '
        'MoneyTreeClock
        '
        Me.MoneyTreeClock.Interval = 1000
        '
        'MainDetail1
        '
        Me.MainDetail1.AutoSize = True
        Me.MainDetail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainDetail1.Location = New System.Drawing.Point(67, 230)
        Me.MainDetail1.Name = "MainDetail1"
        Me.MainDetail1.Size = New System.Drawing.Size(695, 330)
        Me.MainDetail1.TabIndex = 64
        Me.MainDetail1.Text = resources.GetString("MainDetail1.Text")
        Me.MainDetail1.Visible = False
        '
        'Level1Label
        '
        Me.Level1Label.AutoSize = True
        Me.Level1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level1Label.Location = New System.Drawing.Point(74, 560)
        Me.Level1Label.Name = "Level1Label"
        Me.Level1Label.Size = New System.Drawing.Size(96, 29)
        Me.Level1Label.TabIndex = 66
        Me.Level1Label.Text = "Level 1:"
        Me.Level1Label.Visible = False
        '
        'Level1Rules
        '
        Me.Level1Rules.AutoSize = True
        Me.Level1Rules.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level1Rules.Location = New System.Drawing.Point(74, 589)
        Me.Level1Rules.Name = "Level1Rules"
        Me.Level1Rules.Size = New System.Drawing.Size(308, 87)
        Me.Level1Rules.TabIndex = 67
        Me.Level1Rules.Text = "1. General Otaku Knowelge" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Five Questions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. 15 Seconds"
        Me.Level1Rules.Visible = False
        '
        'AskPic
        '
        Me.AskPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_lifeline
        Me.AskPic.Location = New System.Drawing.Point(825, 72)
        Me.AskPic.Name = "AskPic"
        Me.AskPic.Size = New System.Drawing.Size(100, 50)
        Me.AskPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskPic.TabIndex = 72
        Me.AskPic.TabStop = False
        Me.AskPic.Visible = False
        '
        'DoubleDipPic
        '
        Me.DoubleDipPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Double_Dip_Lifeline
        Me.DoubleDipPic.Location = New System.Drawing.Point(1152, 72)
        Me.DoubleDipPic.Name = "DoubleDipPic"
        Me.DoubleDipPic.Size = New System.Drawing.Size(100, 50)
        Me.DoubleDipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DoubleDipPic.TabIndex = 71
        Me.DoubleDipPic.TabStop = False
        Me.DoubleDipPic.Visible = False
        '
        'TrustPic
        '
        Me.TrustPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Trust_the_Computer_lifeline
        Me.TrustPic.Location = New System.Drawing.Point(1046, 72)
        Me.TrustPic.Name = "TrustPic"
        Me.TrustPic.Size = New System.Drawing.Size(100, 50)
        Me.TrustPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TrustPic.TabIndex = 70
        Me.TrustPic.TabStop = False
        Me.TrustPic.Visible = False
        '
        'AskFriendPic
        '
        Me.AskFriendPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_a_Friend_lifeline
        Me.AskFriendPic.Location = New System.Drawing.Point(940, 72)
        Me.AskFriendPic.Name = "AskFriendPic"
        Me.AskFriendPic.Size = New System.Drawing.Size(100, 50)
        Me.AskFriendPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskFriendPic.TabIndex = 69
        Me.AskFriendPic.TabStop = False
        Me.AskFriendPic.Visible = False
        '
        'PassPic
        '
        Me.PassPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.pass_lifeline
        Me.PassPic.Location = New System.Drawing.Point(825, 72)
        Me.PassPic.Name = "PassPic"
        Me.PassPic.Size = New System.Drawing.Size(100, 50)
        Me.PassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassPic.TabIndex = 68
        Me.PassPic.TabStop = False
        Me.PassPic.Visible = False
        '
        'Money01
        '
        Me.Money01.AutoSize = True
        Me.Money01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money01.Location = New System.Drawing.Point(959, 607)
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
        Me.Money02.Location = New System.Drawing.Point(959, 574)
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
        Me.Money03.Location = New System.Drawing.Point(959, 541)
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
        Me.Money04.Location = New System.Drawing.Point(959, 508)
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
        Me.Money10.Location = New System.Drawing.Point(958, 310)
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
        Me.Money09.Location = New System.Drawing.Point(961, 343)
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
        Me.Money08.Location = New System.Drawing.Point(964, 376)
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
        Me.Money07.Location = New System.Drawing.Point(962, 409)
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
        Me.Money06.Location = New System.Drawing.Point(958, 442)
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
        Me.Money05.Location = New System.Drawing.Point(958, 475)
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
        Me.Money11.Location = New System.Drawing.Point(961, 274)
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
        Me.Money12.Location = New System.Drawing.Point(962, 241)
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
        Me.Money13.Location = New System.Drawing.Point(962, 208)
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
        Me.Money14.Location = New System.Drawing.Point(958, 175)
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
        Me.Money15.Location = New System.Drawing.Point(958, 142)
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
        Me.Topic15.Location = New System.Drawing.Point(963, 142)
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
        Me.Topic14.Location = New System.Drawing.Point(963, 175)
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
        Me.Topic13.Location = New System.Drawing.Point(963, 208)
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
        Me.Topic01.Location = New System.Drawing.Point(958, 607)
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
        Me.Topic12.Location = New System.Drawing.Point(965, 241)
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
        Me.Topic11.Location = New System.Drawing.Point(964, 274)
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
        Me.Topic10.Location = New System.Drawing.Point(961, 310)
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
        Me.Topic09.Location = New System.Drawing.Point(965, 343)
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
        Me.Topic08.Location = New System.Drawing.Point(963, 376)
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
        Me.Topic07.Location = New System.Drawing.Point(964, 409)
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
        Me.Topic06.Location = New System.Drawing.Point(965, 442)
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
        Me.Topic05.Location = New System.Drawing.Point(965, 475)
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
        Me.Topic04.Location = New System.Drawing.Point(961, 508)
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
        Me.Topic03.Location = New System.Drawing.Point(965, 541)
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
        Me.Topic02.Location = New System.Drawing.Point(958, 574)
        Me.Topic02.Name = "Topic02"
        Me.Topic02.Size = New System.Drawing.Size(102, 33)
        Me.Topic02.TabIndex = 326
        Me.Topic02.Text = "Label2"
        Me.Topic02.Visible = False
        '
        'Level1MoneyTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
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
        Me.Controls.Add(Me.TrustPic)
        Me.Controls.Add(Me.AskFriendPic)
        Me.Controls.Add(Me.Level1Rules)
        Me.Controls.Add(Me.Level1Label)
        Me.Controls.Add(Me.MainDetail1)
        Me.Controls.Add(Me.StartGame)
        Me.Controls.Add(Me.Transition)
        Me.Controls.Add(Me.ShowMoneyTree)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PassPic)
        Me.Controls.Add(Me.DoubleDipPic)
        Me.Controls.Add(Me.AskPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Level1MoneyTree"
        Me.Text = "Level 1 Money Tree"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowMoneyTree As Button
    Friend WithEvents Transition As Button
    Friend WithEvents StartGame As Button
    Friend WithEvents MoneyTreeClock As Timer
    Friend WithEvents MainDetail1 As Label
    Friend WithEvents Level1Label As Label
    Friend WithEvents Level1Rules As Label
    Friend WithEvents PassPic As PictureBox
    Friend WithEvents AskFriendPic As PictureBox
    Friend WithEvents TrustPic As PictureBox
    Friend WithEvents DoubleDipPic As PictureBox
    Friend WithEvents AskPic As PictureBox
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
