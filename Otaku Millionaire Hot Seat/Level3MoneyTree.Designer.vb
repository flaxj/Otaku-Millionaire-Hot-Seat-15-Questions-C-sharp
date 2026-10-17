<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level3MoneyTree
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
        Me.Level3Rules = New System.Windows.Forms.Label()
        Me.Level3Label = New System.Windows.Forms.Label()
        Me.ResumeGame = New System.Windows.Forms.Button()
        Me.Transition = New System.Windows.Forms.Button()
        Me.ShowMoneyTree = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AskPic = New System.Windows.Forms.PictureBox()
        Me.DoubleDipPic = New System.Windows.Forms.PictureBox()
        Me.TrustPic = New System.Windows.Forms.PictureBox()
        Me.AskFriendPic = New System.Windows.Forms.PictureBox()
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
        Me.SuspendLayout()
        '
        'Level3Rules
        '
        Me.Level3Rules.AutoSize = True
        Me.Level3Rules.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level3Rules.Location = New System.Drawing.Point(12, 303)
        Me.Level3Rules.Name = "Level3Rules"
        Me.Level3Rules.Size = New System.Drawing.Size(773, 165)
        Me.Level3Rules.TabIndex = 81
        Me.Level3Rules.Text = "1. Hard Anime or Manga Knowelge" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Four Questions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. 45 Seconds"
        Me.Level3Rules.Visible = False
        '
        'Level3Label
        '
        Me.Level3Label.AutoSize = True
        Me.Level3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level3Label.Location = New System.Drawing.Point(12, 234)
        Me.Level3Label.Name = "Level3Label"
        Me.Level3Label.Size = New System.Drawing.Size(192, 55)
        Me.Level3Label.TabIndex = 80
        Me.Level3Label.Text = "Level 3:"
        Me.Level3Label.Visible = False
        '
        'ResumeGame
        '
        Me.ResumeGame.Location = New System.Drawing.Point(512, 64)
        Me.ResumeGame.Name = "ResumeGame"
        Me.ResumeGame.Size = New System.Drawing.Size(251, 126)
        Me.ResumeGame.TabIndex = 79
        Me.ResumeGame.Text = "Start Level 3"
        Me.ResumeGame.UseVisualStyleBackColor = True
        Me.ResumeGame.Visible = False
        '
        'Transition
        '
        Me.Transition.Location = New System.Drawing.Point(268, 64)
        Me.Transition.Name = "Transition"
        Me.Transition.Size = New System.Drawing.Size(238, 126)
        Me.Transition.TabIndex = 78
        Me.Transition.Text = "Show Lifelines"
        Me.Transition.UseVisualStyleBackColor = True
        Me.Transition.Visible = False
        '
        'ShowMoneyTree
        '
        Me.ShowMoneyTree.Location = New System.Drawing.Point(22, 64)
        Me.ShowMoneyTree.Name = "ShowMoneyTree"
        Me.ShowMoneyTree.Size = New System.Drawing.Size(240, 126)
        Me.ShowMoneyTree.TabIndex = 77
        Me.ShowMoneyTree.Text = "Show Money Tree"
        Me.ShowMoneyTree.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 87
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
        'AskPic
        '
        Me.AskPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_lifeline
        Me.AskPic.Location = New System.Drawing.Point(802, 64)
        Me.AskPic.Name = "AskPic"
        Me.AskPic.Size = New System.Drawing.Size(100, 50)
        Me.AskPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskPic.TabIndex = 86
        Me.AskPic.TabStop = False
        Me.AskPic.Visible = False
        '
        'DoubleDipPic
        '
        Me.DoubleDipPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Double_Dip_Lifeline
        Me.DoubleDipPic.Location = New System.Drawing.Point(1120, 64)
        Me.DoubleDipPic.Name = "DoubleDipPic"
        Me.DoubleDipPic.Size = New System.Drawing.Size(100, 50)
        Me.DoubleDipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DoubleDipPic.TabIndex = 85
        Me.DoubleDipPic.TabStop = False
        '
        'TrustPic
        '
        Me.TrustPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Trust_the_Computer_lifeline
        Me.TrustPic.Location = New System.Drawing.Point(1014, 64)
        Me.TrustPic.Name = "TrustPic"
        Me.TrustPic.Size = New System.Drawing.Size(100, 50)
        Me.TrustPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TrustPic.TabIndex = 84
        Me.TrustPic.TabStop = False
        '
        'AskFriendPic
        '
        Me.AskFriendPic.Image = Global.Otaku_Millionaire_Hot_Seat.My.Resources.Resources.Ask_a_Friend_lifeline
        Me.AskFriendPic.Location = New System.Drawing.Point(908, 64)
        Me.AskFriendPic.Name = "AskFriendPic"
        Me.AskFriendPic.Size = New System.Drawing.Size(100, 50)
        Me.AskFriendPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AskFriendPic.TabIndex = 83
        Me.AskFriendPic.TabStop = False
        '
        'Money01
        '
        Me.Money01.AutoSize = True
        Me.Money01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money01.Location = New System.Drawing.Point(892, 600)
        Me.Money01.Name = "Money01"
        Me.Money01.Size = New System.Drawing.Size(79, 33)
        Me.Money01.TabIndex = 277
        Me.Money01.Text = "¥100"
        '
        'Money02
        '
        Me.Money02.AutoSize = True
        Me.Money02.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money02.Location = New System.Drawing.Point(892, 567)
        Me.Money02.Name = "Money02"
        Me.Money02.Size = New System.Drawing.Size(79, 33)
        Me.Money02.TabIndex = 289
        Me.Money02.Text = "¥200"
        '
        'Money03
        '
        Me.Money03.AutoSize = True
        Me.Money03.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money03.Location = New System.Drawing.Point(892, 534)
        Me.Money03.Name = "Money03"
        Me.Money03.Size = New System.Drawing.Size(79, 33)
        Me.Money03.TabIndex = 291
        Me.Money03.Text = "¥300"
        '
        'Money04
        '
        Me.Money04.AutoSize = True
        Me.Money04.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money04.Location = New System.Drawing.Point(892, 501)
        Me.Money04.Name = "Money04"
        Me.Money04.Size = New System.Drawing.Size(79, 33)
        Me.Money04.TabIndex = 290
        Me.Money04.Text = "¥500"
        '
        'Money10
        '
        Me.Money10.AutoSize = True
        Me.Money10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money10.Location = New System.Drawing.Point(891, 303)
        Me.Money10.Name = "Money10"
        Me.Money10.Size = New System.Drawing.Size(119, 33)
        Me.Money10.TabIndex = 283
        Me.Money10.Text = "¥10,000"
        '
        'Money09
        '
        Me.Money09.AutoSize = True
        Me.Money09.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money09.Location = New System.Drawing.Point(894, 336)
        Me.Money09.Name = "Money09"
        Me.Money09.Size = New System.Drawing.Size(103, 33)
        Me.Money09.TabIndex = 282
        Me.Money09.Text = "¥6,000"
        '
        'Money08
        '
        Me.Money08.AutoSize = True
        Me.Money08.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money08.Location = New System.Drawing.Point(897, 369)
        Me.Money08.Name = "Money08"
        Me.Money08.Size = New System.Drawing.Size(103, 33)
        Me.Money08.TabIndex = 281
        Me.Money08.Text = "¥4,000"
        '
        'Money07
        '
        Me.Money07.AutoSize = True
        Me.Money07.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money07.Location = New System.Drawing.Point(895, 402)
        Me.Money07.Name = "Money07"
        Me.Money07.Size = New System.Drawing.Size(103, 33)
        Me.Money07.TabIndex = 280
        Me.Money07.Text = "¥2,500"
        '
        'Money06
        '
        Me.Money06.AutoSize = True
        Me.Money06.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money06.Location = New System.Drawing.Point(891, 435)
        Me.Money06.Name = "Money06"
        Me.Money06.Size = New System.Drawing.Size(103, 33)
        Me.Money06.TabIndex = 279
        Me.Money06.Text = "¥1,500"
        '
        'Money05
        '
        Me.Money05.AutoSize = True
        Me.Money05.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money05.Location = New System.Drawing.Point(891, 468)
        Me.Money05.Name = "Money05"
        Me.Money05.Size = New System.Drawing.Size(109, 33)
        Me.Money05.TabIndex = 278
        Me.Money05.Text = "¥1,000"
        '
        'Money11
        '
        Me.Money11.AutoSize = True
        Me.Money11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money11.Location = New System.Drawing.Point(894, 267)
        Me.Money11.Name = "Money11"
        Me.Money11.Size = New System.Drawing.Size(119, 33)
        Me.Money11.TabIndex = 284
        Me.Money11.Text = "¥20,000"
        '
        'Money12
        '
        Me.Money12.AutoSize = True
        Me.Money12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money12.Location = New System.Drawing.Point(895, 234)
        Me.Money12.Name = "Money12"
        Me.Money12.Size = New System.Drawing.Size(119, 33)
        Me.Money12.TabIndex = 285
        Me.Money12.Text = "¥50,000"
        '
        'Money13
        '
        Me.Money13.AutoSize = True
        Me.Money13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money13.Location = New System.Drawing.Point(895, 201)
        Me.Money13.Name = "Money13"
        Me.Money13.Size = New System.Drawing.Size(135, 33)
        Me.Money13.TabIndex = 286
        Me.Money13.Text = "¥100,000"
        '
        'Money14
        '
        Me.Money14.AutoSize = True
        Me.Money14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money14.Location = New System.Drawing.Point(891, 168)
        Me.Money14.Name = "Money14"
        Me.Money14.Size = New System.Drawing.Size(135, 33)
        Me.Money14.TabIndex = 287
        Me.Money14.Text = "¥250,000"
        '
        'Money15
        '
        Me.Money15.AutoSize = True
        Me.Money15.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money15.Location = New System.Drawing.Point(891, 135)
        Me.Money15.Name = "Money15"
        Me.Money15.Size = New System.Drawing.Size(169, 33)
        Me.Money15.TabIndex = 288
        Me.Money15.Text = "¥1,000,000"
        '
        'Topic15
        '
        Me.Topic15.AutoSize = True
        Me.Topic15.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic15.Location = New System.Drawing.Point(896, 135)
        Me.Topic15.Name = "Topic15"
        Me.Topic15.Size = New System.Drawing.Size(118, 33)
        Me.Topic15.TabIndex = 294
        Me.Topic15.Text = "Label15"
        Me.Topic15.Visible = False
        '
        'Topic14
        '
        Me.Topic14.AutoSize = True
        Me.Topic14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic14.Location = New System.Drawing.Point(896, 168)
        Me.Topic14.Name = "Topic14"
        Me.Topic14.Size = New System.Drawing.Size(118, 33)
        Me.Topic14.TabIndex = 293
        Me.Topic14.Text = "Label14"
        Me.Topic14.Visible = False
        '
        'Topic13
        '
        Me.Topic13.AutoSize = True
        Me.Topic13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic13.Location = New System.Drawing.Point(896, 201)
        Me.Topic13.Name = "Topic13"
        Me.Topic13.Size = New System.Drawing.Size(118, 33)
        Me.Topic13.TabIndex = 292
        Me.Topic13.Text = "Label13"
        Me.Topic13.Visible = False
        '
        'Topic01
        '
        Me.Topic01.AutoSize = True
        Me.Topic01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic01.Location = New System.Drawing.Point(891, 600)
        Me.Topic01.Name = "Topic01"
        Me.Topic01.Size = New System.Drawing.Size(102, 33)
        Me.Topic01.TabIndex = 265
        Me.Topic01.Text = "Label1"
        Me.Topic01.Visible = False
        '
        'Topic12
        '
        Me.Topic12.AutoSize = True
        Me.Topic12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic12.Location = New System.Drawing.Point(898, 234)
        Me.Topic12.Name = "Topic12"
        Me.Topic12.Size = New System.Drawing.Size(118, 33)
        Me.Topic12.TabIndex = 276
        Me.Topic12.Text = "Label12"
        Me.Topic12.Visible = False
        '
        'Topic11
        '
        Me.Topic11.AutoSize = True
        Me.Topic11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic11.Location = New System.Drawing.Point(897, 267)
        Me.Topic11.Name = "Topic11"
        Me.Topic11.Size = New System.Drawing.Size(118, 33)
        Me.Topic11.TabIndex = 275
        Me.Topic11.Text = "Label11"
        Me.Topic11.Visible = False
        '
        'Topic10
        '
        Me.Topic10.AutoSize = True
        Me.Topic10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic10.Location = New System.Drawing.Point(894, 303)
        Me.Topic10.Name = "Topic10"
        Me.Topic10.Size = New System.Drawing.Size(118, 33)
        Me.Topic10.TabIndex = 274
        Me.Topic10.Text = "Label10"
        Me.Topic10.Visible = False
        '
        'Topic09
        '
        Me.Topic09.AutoSize = True
        Me.Topic09.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic09.Location = New System.Drawing.Point(898, 336)
        Me.Topic09.Name = "Topic09"
        Me.Topic09.Size = New System.Drawing.Size(102, 33)
        Me.Topic09.TabIndex = 273
        Me.Topic09.Text = "Label9"
        Me.Topic09.Visible = False
        '
        'Topic08
        '
        Me.Topic08.AutoSize = True
        Me.Topic08.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic08.Location = New System.Drawing.Point(896, 369)
        Me.Topic08.Name = "Topic08"
        Me.Topic08.Size = New System.Drawing.Size(102, 33)
        Me.Topic08.TabIndex = 272
        Me.Topic08.Text = "Label8"
        Me.Topic08.Visible = False
        '
        'Topic07
        '
        Me.Topic07.AutoSize = True
        Me.Topic07.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic07.Location = New System.Drawing.Point(897, 402)
        Me.Topic07.Name = "Topic07"
        Me.Topic07.Size = New System.Drawing.Size(102, 33)
        Me.Topic07.TabIndex = 271
        Me.Topic07.Text = "Label7"
        Me.Topic07.Visible = False
        '
        'Topic06
        '
        Me.Topic06.AutoSize = True
        Me.Topic06.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic06.Location = New System.Drawing.Point(898, 435)
        Me.Topic06.Name = "Topic06"
        Me.Topic06.Size = New System.Drawing.Size(102, 33)
        Me.Topic06.TabIndex = 270
        Me.Topic06.Text = "Label6"
        Me.Topic06.Visible = False
        '
        'Topic05
        '
        Me.Topic05.AutoSize = True
        Me.Topic05.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic05.Location = New System.Drawing.Point(898, 468)
        Me.Topic05.Name = "Topic05"
        Me.Topic05.Size = New System.Drawing.Size(102, 33)
        Me.Topic05.TabIndex = 269
        Me.Topic05.Text = "Label5"
        Me.Topic05.Visible = False
        '
        'Topic04
        '
        Me.Topic04.AutoSize = True
        Me.Topic04.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic04.Location = New System.Drawing.Point(894, 501)
        Me.Topic04.Name = "Topic04"
        Me.Topic04.Size = New System.Drawing.Size(102, 33)
        Me.Topic04.TabIndex = 268
        Me.Topic04.Text = "Label4"
        Me.Topic04.Visible = False
        '
        'Topic03
        '
        Me.Topic03.AutoSize = True
        Me.Topic03.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic03.Location = New System.Drawing.Point(898, 534)
        Me.Topic03.Name = "Topic03"
        Me.Topic03.Size = New System.Drawing.Size(102, 33)
        Me.Topic03.TabIndex = 267
        Me.Topic03.Text = "Label3"
        Me.Topic03.Visible = False
        '
        'Topic02
        '
        Me.Topic02.AutoSize = True
        Me.Topic02.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic02.Location = New System.Drawing.Point(891, 567)
        Me.Topic02.Name = "Topic02"
        Me.Topic02.Size = New System.Drawing.Size(102, 33)
        Me.Topic02.TabIndex = 266
        Me.Topic02.Text = "Label2"
        Me.Topic02.Visible = False
        '
        'Level3MoneyTree
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AskPic)
        Me.Controls.Add(Me.DoubleDipPic)
        Me.Controls.Add(Me.TrustPic)
        Me.Controls.Add(Me.AskFriendPic)
        Me.Controls.Add(Me.Level3Rules)
        Me.Controls.Add(Me.Level3Label)
        Me.Controls.Add(Me.ResumeGame)
        Me.Controls.Add(Me.Transition)
        Me.Controls.Add(Me.ShowMoneyTree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Level3MoneyTree"
        Me.Text = "Level 3 Money Tree"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AskPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleDipPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrustPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AskFriendPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DoubleDipPic As PictureBox
    Friend WithEvents TrustPic As PictureBox
    Friend WithEvents AskFriendPic As PictureBox
    Friend WithEvents Level3Rules As Label
    Friend WithEvents Level3Label As Label
    Friend WithEvents ResumeGame As Button
    Friend WithEvents Transition As Button
    Friend WithEvents ShowMoneyTree As Button
    Friend WithEvents AskPic As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
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
