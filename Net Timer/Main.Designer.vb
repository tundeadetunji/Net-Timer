<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.PicturePath = New System.Windows.Forms.TextBox()
        Me.Feedback = New System.Windows.Forms.TextBox()
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HelpButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Label()
        Me.SystemCloseButton = New System.Windows.Forms.Button()
        Me.DialogTitle = New System.Windows.Forms.Label()
        Me.BottomLine = New System.Windows.Forms.PictureBox()
        Me.TopLine = New System.Windows.Forms.PictureBox()
        Me.BottomBorder = New System.Windows.Forms.PictureBox()
        Me.RightBorder = New System.Windows.Forms.PictureBox()
        Me.LeftBorder = New System.Windows.Forms.PictureBox()
        Me.TopBorder = New System.Windows.Forms.PictureBox()
        Me.EmptyButton = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.TextBox()
        Me.Commit = New System.Windows.Forms.Button()
        Me.Interval = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Modal = New System.Windows.Forms.ComboBox()
        Me.ModalText = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RepeatCheck = New System.Windows.Forms.CheckBox()
        Me.OutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InTimer = New System.Windows.Forms.Timer(Me.components)
        Me.xTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guide = New System.Windows.Forms.CheckBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FrenchLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThaiLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.YorubaLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassicThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LavenderThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NightThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoseThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.StandardThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApplicationFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessagePromptOnly = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MessagePromptWithVoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.VoiceOnly = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DefaultActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TurqoiseTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.VelvetTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PurpleTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.WhiteTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrownTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.YellowTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThemeBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeSelectBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThemeClearBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dWhen = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hForever = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tIcon = New System.Windows.Forms.TextBox()
        Me.bBrowseForIcon = New System.Windows.Forms.Button()
        Me.pIcon = New System.Windows.Forms.PictureBox()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.TitleBar = New System.Windows.Forms.PictureBox()
        Me.FooterBar = New System.Windows.Forms.PictureBox()
        Me.MaximizeBox = New System.Windows.Forms.Label()
        Me.dTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.pIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FooterBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(981, 738)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 20)
        Me.TimeLabel.TabIndex = 14616
        '
        'PicturePath
        '
        Me.PicturePath.Location = New System.Drawing.Point(541, 414)
        Me.PicturePath.Name = "PicturePath"
        Me.PicturePath.Size = New System.Drawing.Size(100, 26)
        Me.PicturePath.TabIndex = 14617
        Me.PicturePath.TabStop = False
        '
        'Feedback
        '
        Me.Feedback.Location = New System.Drawing.Point(683, 467)
        Me.Feedback.Multiline = True
        Me.Feedback.Name = "Feedback"
        Me.Feedback.ReadOnly = True
        Me.Feedback.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Feedback.Size = New System.Drawing.Size(204, 52)
        Me.Feedback.TabIndex = 14615
        Me.Feedback.TabStop = False
        '
        'TimeTimer
        '
        Me.TimeTimer.Interval = 1000
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.Color.Transparent
        Me.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpButton.Image = Global.Net_Timer.My.Resources.Resources.help
        Me.HelpButton.Location = New System.Drawing.Point(473, 478)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(30, 31)
        Me.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HelpButton.TabIndex = 14614
        Me.HelpButton.TabStop = False
        Me.HelpButton.Tag = "v"
        '
        'CloseButton
        '
        Me.CloseButton.AutoSize = True
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(560, 453)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(21, 20)
        Me.CloseButton.TabIndex = 14613
        Me.CloseButton.Tag = "hih"
        Me.CloseButton.Text = "X"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.AutoSize = True
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeButton.Location = New System.Drawing.Point(500, 438)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(18, 21)
        Me.MinimizeButton.TabIndex = 14612
        Me.MinimizeButton.Text = "_"
        '
        'SystemCloseButton
        '
        Me.SystemCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemCloseButton.Location = New System.Drawing.Point(665, 669)
        Me.SystemCloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SystemCloseButton.Name = "SystemCloseButton"
        Me.SystemCloseButton.Size = New System.Drawing.Size(112, 40)
        Me.SystemCloseButton.TabIndex = 14611
        Me.SystemCloseButton.TabStop = False
        Me.SystemCloseButton.Text = "Commit"
        Me.SystemCloseButton.UseVisualStyleBackColor = True
        '
        'DialogTitle
        '
        Me.DialogTitle.AutoSize = True
        Me.DialogTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DialogTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogTitle.Location = New System.Drawing.Point(397, 453)
        Me.DialogTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DialogTitle.Name = "DialogTitle"
        Me.DialogTitle.Size = New System.Drawing.Size(86, 20)
        Me.DialogTitle.TabIndex = 14610
        Me.DialogTitle.Text = "Net Timer"
        '
        'BottomLine
        '
        Me.BottomLine.BackColor = System.Drawing.Color.Black
        Me.BottomLine.Location = New System.Drawing.Point(464, 562)
        Me.BottomLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BottomLine.Name = "BottomLine"
        Me.BottomLine.Size = New System.Drawing.Size(795, 2)
        Me.BottomLine.TabIndex = 14609
        Me.BottomLine.TabStop = False
        '
        'TopLine
        '
        Me.TopLine.BackColor = System.Drawing.Color.Black
        Me.TopLine.Location = New System.Drawing.Point(459, 543)
        Me.TopLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TopLine.Name = "TopLine"
        Me.TopLine.Size = New System.Drawing.Size(795, 2)
        Me.TopLine.TabIndex = 14608
        Me.TopLine.TabStop = False
        '
        'BottomBorder
        '
        Me.BottomBorder.Location = New System.Drawing.Point(473, 593)
        Me.BottomBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BottomBorder.Name = "BottomBorder"
        Me.BottomBorder.Size = New System.Drawing.Size(118, 20)
        Me.BottomBorder.TabIndex = 14607
        Me.BottomBorder.TabStop = False
        '
        'RightBorder
        '
        Me.RightBorder.Location = New System.Drawing.Point(473, 669)
        Me.RightBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RightBorder.Name = "RightBorder"
        Me.RightBorder.Size = New System.Drawing.Size(118, 20)
        Me.RightBorder.TabIndex = 14605
        Me.RightBorder.TabStop = False
        '
        'LeftBorder
        '
        Me.LeftBorder.Location = New System.Drawing.Point(473, 623)
        Me.LeftBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftBorder.Name = "LeftBorder"
        Me.LeftBorder.Size = New System.Drawing.Size(118, 20)
        Me.LeftBorder.TabIndex = 14604
        Me.LeftBorder.TabStop = False
        '
        'TopBorder
        '
        Me.TopBorder.Location = New System.Drawing.Point(473, 639)
        Me.TopBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TopBorder.Name = "TopBorder"
        Me.TopBorder.Size = New System.Drawing.Size(118, 20)
        Me.TopBorder.TabIndex = 14606
        Me.TopBorder.TabStop = False
        '
        'EmptyButton
        '
        Me.EmptyButton.Location = New System.Drawing.Point(411, 469)
        Me.EmptyButton.Name = "EmptyButton"
        Me.EmptyButton.Size = New System.Drawing.Size(75, 23)
        Me.EmptyButton.TabIndex = 14619
        Me.EmptyButton.Text = "Button1"
        Me.EmptyButton.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(84, 267)
        Me.Display.MaxLength = 63
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(293, 26)
        Me.Display.TabIndex = 14630
        Me.Display.Text = "Display"
        '
        'Commit
        '
        Me.Commit.Location = New System.Drawing.Point(166, 580)
        Me.Commit.Name = "Commit"
        Me.Commit.Size = New System.Drawing.Size(53, 34)
        Me.Commit.TabIndex = 14633
        Me.Commit.Text = "Go!"
        Me.Commit.UseVisualStyleBackColor = True
        '
        'Interval
        '
        Me.Interval.Location = New System.Drawing.Point(13, 401)
        Me.Interval.Maximum = New Decimal(New Integer() {10080, 0, 0, 0})
        Me.Interval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Interval.Name = "Interval"
        Me.Interval.Size = New System.Drawing.Size(84, 26)
        Me.Interval.TabIndex = 14631
        Me.Interval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 14623
        Me.Label1.Text = "Display:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 14624
        Me.Label2.Text = "Begin in"
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.Location = New System.Drawing.Point(103, 403)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(57, 20)
        Me.MinutesLabel.TabIndex = 14625
        Me.MinutesLabel.Text = "Minute"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 14626
        Me.Label4.Text = "Do:"
        '
        'Modal
        '
        Me.Modal.FormattingEnabled = True
        Me.Modal.Location = New System.Drawing.Point(14, 86)
        Me.Modal.Name = "Modal"
        Me.Modal.Size = New System.Drawing.Size(181, 28)
        Me.Modal.TabIndex = 14627
        '
        'ModalText
        '
        Me.ModalText.Location = New System.Drawing.Point(14, 120)
        Me.ModalText.Multiline = True
        Me.ModalText.Name = "ModalText"
        Me.ModalText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ModalText.Size = New System.Drawing.Size(363, 78)
        Me.ModalText.TabIndex = 14628
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ToolStripMenuItem11, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem18, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 88)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(122, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        Me.DeleteToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(122, 6)
        Me.ToolStripMenuItem18.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RepeatTimer
        '
        Me.RepeatTimer.Interval = 3000
        '
        'RepeatCheck
        '
        Me.RepeatCheck.AutoSize = True
        Me.RepeatCheck.Checked = True
        Me.RepeatCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RepeatCheck.Location = New System.Drawing.Point(17, 586)
        Me.RepeatCheck.Name = "RepeatCheck"
        Me.RepeatCheck.Size = New System.Drawing.Size(81, 24)
        Me.RepeatCheck.TabIndex = 14634
        Me.RepeatCheck.Text = "Repeat"
        Me.RepeatCheck.UseVisualStyleBackColor = True
        '
        'OutTimer
        '
        '
        'InTimer
        '
        Me.InTimer.Enabled = True
        '
        'xTimer
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 900)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(40, 24)
        Me.MenuStrip1.TabIndex = 14630
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbToolStripMenuItem
        '
        Me.AbToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.AbToolStripMenuItem.Name = "AbToolStripMenuItem"
        Me.AbToolStripMenuItem.Size = New System.Drawing.Size(32, 20)
        Me.AbToolStripMenuItem.Text = "ab"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Guide
        '
        Me.Guide.AutoSize = True
        Me.Guide.Checked = True
        Me.Guide.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Guide.Location = New System.Drawing.Point(422, 448)
        Me.Guide.Name = "Guide"
        Me.Guide.Size = New System.Drawing.Size(71, 24)
        Me.Guide.TabIndex = 14632
        Me.Guide.Text = "Guide"
        Me.Guide.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TasksToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem13})
        Me.MenuStrip.Location = New System.Drawing.Point(420, 218)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(234, 28)
        Me.MenuStrip.TabIndex = 16760
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'TasksToolStripMenuItem
        '
        Me.TasksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem14, Me.NewEntryToolStripMenuItem, Me.ToolStripMenuItem12, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem16, Me.CloseToolStripMenuItem})
        Me.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem"
        Me.TasksToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.TasksToolStripMenuItem.Text = "Tasks"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem15, Me.CheckToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.NewToolStripMenuItem.Text = "Load"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(120, 6)
        '
        'CheckToolStripMenuItem
        '
        Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
        Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.CheckToolStripMenuItem.Text = "Check"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(168, 6)
        '
        'NewEntryToolStripMenuItem
        '
        Me.NewEntryToolStripMenuItem.Name = "NewEntryToolStripMenuItem"
        Me.NewEntryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewEntryToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.NewEntryToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(168, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(168, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishLanguage, Me.ToolStripSeparator1, Me.FrenchLanguage, Me.ToolStripSeparator2, Me.ThaiLanguage, Me.ToolStripSeparator3, Me.YorubaLanguage})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishLanguage
        '
        Me.EnglishLanguage.Name = "EnglishLanguage"
        Me.EnglishLanguage.Size = New System.Drawing.Size(134, 24)
        Me.EnglishLanguage.Text = "English"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'FrenchLanguage
        '
        Me.FrenchLanguage.Name = "FrenchLanguage"
        Me.FrenchLanguage.Size = New System.Drawing.Size(134, 24)
        Me.FrenchLanguage.Text = "français"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
        '
        'ThaiLanguage
        '
        Me.ThaiLanguage.Name = "ThaiLanguage"
        Me.ThaiLanguage.Size = New System.Drawing.Size(134, 24)
        Me.ThaiLanguage.Text = "ไทย"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(131, 6)
        '
        'YorubaLanguage
        '
        Me.YorubaLanguage.Name = "YorubaLanguage"
        Me.YorubaLanguage.Size = New System.Drawing.Size(134, 24)
        Me.YorubaLanguage.Text = "Yorùbá"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem, Me.ToolStripMenuItem1, Me.ApplicationFeedbackToolStripMenuItem, Me.ToolStripSeparator4, Me.DefaultActionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        Me.SettingsToolStripMenuItem.Visible = False
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassicThemes, Me.ToolStripMenuItem2, Me.LavenderThemes, Me.ToolStripMenuItem3, Me.NightThemes, Me.ToolStripMenuItem4, Me.RoseThemes, Me.ToolStripMenuItem5, Me.StandardThemes})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'ClassicThemes
        '
        Me.ClassicThemes.Name = "ClassicThemes"
        Me.ClassicThemes.Size = New System.Drawing.Size(144, 24)
        Me.ClassicThemes.Text = "Classic"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 6)
        '
        'LavenderThemes
        '
        Me.LavenderThemes.Name = "LavenderThemes"
        Me.LavenderThemes.Size = New System.Drawing.Size(144, 24)
        Me.LavenderThemes.Text = "Lavender"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(141, 6)
        '
        'NightThemes
        '
        Me.NightThemes.Name = "NightThemes"
        Me.NightThemes.Size = New System.Drawing.Size(144, 24)
        Me.NightThemes.Text = "Night"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(141, 6)
        '
        'RoseThemes
        '
        Me.RoseThemes.Name = "RoseThemes"
        Me.RoseThemes.Size = New System.Drawing.Size(144, 24)
        Me.RoseThemes.Text = "Rose"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(141, 6)
        '
        'StandardThemes
        '
        Me.StandardThemes.Name = "StandardThemes"
        Me.StandardThemes.Size = New System.Drawing.Size(144, 24)
        Me.StandardThemes.Text = "Standard"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
        '
        'ApplicationFeedbackToolStripMenuItem
        '
        Me.ApplicationFeedbackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessagePromptOnly, Me.ToolStripMenuItem6, Me.MessagePromptWithVoice, Me.ToolStripMenuItem7, Me.VoiceOnly})
        Me.ApplicationFeedbackToolStripMenuItem.Name = "ApplicationFeedbackToolStripMenuItem"
        Me.ApplicationFeedbackToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.ApplicationFeedbackToolStripMenuItem.Text = "Application Feedback"
        '
        'MessagePromptOnly
        '
        Me.MessagePromptOnly.Name = "MessagePromptOnly"
        Me.MessagePromptOnly.Size = New System.Drawing.Size(278, 24)
        Me.MessagePromptOnly.Text = "Message Prompt Only"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(275, 6)
        '
        'MessagePromptWithVoice
        '
        Me.MessagePromptWithVoice.Name = "MessagePromptWithVoice"
        Me.MessagePromptWithVoice.Size = New System.Drawing.Size(278, 24)
        Me.MessagePromptWithVoice.Text = "Message Prompt With Voice"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(275, 6)
        '
        'VoiceOnly
        '
        Me.VoiceOnly.Name = "VoiceOnly"
        Me.VoiceOnly.Size = New System.Drawing.Size(278, 24)
        Me.VoiceOnly.Text = "Voice Only"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(228, 6)
        '
        'DefaultActionsToolStripMenuItem
        '
        Me.DefaultActionsToolStripMenuItem.Name = "DefaultActionsToolStripMenuItem"
        Me.DefaultActionsToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.DefaultActionsToolStripMenuItem.Text = "Default Actions"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenTheme, Me.ToolStripSeparator5, Me.TurqoiseTheme, Me.ToolStripSeparator6, Me.VelvetTheme, Me.ToolStripSeparator7, Me.PurpleTheme, Me.ToolStripSeparator8, Me.WhiteTheme, Me.ToolStripMenuItem8, Me.BrownTheme, Me.ToolStripMenuItem9, Me.YellowTheme, Me.ToolStripMenuItem10, Me.ThemeBackground})
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(70, 24)
        Me.ToolStripMenuItem13.Text = "Theme"
        '
        'GreenTheme
        '
        Me.GreenTheme.Name = "GreenTheme"
        Me.GreenTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GreenTheme.Size = New System.Drawing.Size(260, 24)
        Me.GreenTheme.Text = "Green"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(257, 6)
        '
        'TurqoiseTheme
        '
        Me.TurqoiseTheme.Name = "TurqoiseTheme"
        Me.TurqoiseTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TurqoiseTheme.Size = New System.Drawing.Size(260, 24)
        Me.TurqoiseTheme.Text = "Turqoise"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(257, 6)
        '
        'VelvetTheme
        '
        Me.VelvetTheme.Name = "VelvetTheme"
        Me.VelvetTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VelvetTheme.Size = New System.Drawing.Size(260, 24)
        Me.VelvetTheme.Text = "Velvet"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(257, 6)
        '
        'PurpleTheme
        '
        Me.PurpleTheme.Name = "PurpleTheme"
        Me.PurpleTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PurpleTheme.Size = New System.Drawing.Size(260, 24)
        Me.PurpleTheme.Text = "Purple"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(257, 6)
        '
        'WhiteTheme
        '
        Me.WhiteTheme.Name = "WhiteTheme"
        Me.WhiteTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WhiteTheme.Size = New System.Drawing.Size(260, 24)
        Me.WhiteTheme.Text = "White"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(257, 6)
        '
        'BrownTheme
        '
        Me.BrownTheme.Name = "BrownTheme"
        Me.BrownTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BrownTheme.Size = New System.Drawing.Size(260, 24)
        Me.BrownTheme.Text = "Brown"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(257, 6)
        '
        'YellowTheme
        '
        Me.YellowTheme.Name = "YellowTheme"
        Me.YellowTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.YellowTheme.Size = New System.Drawing.Size(260, 24)
        Me.YellowTheme.Text = "Yellow"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(257, 6)
        '
        'ThemeBackground
        '
        Me.ThemeBackground.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeSelectBackground, Me.ToolStripMenuItem17, Me.ThemeClearBackground})
        Me.ThemeBackground.Name = "ThemeBackground"
        Me.ThemeBackground.Size = New System.Drawing.Size(260, 24)
        Me.ThemeBackground.Text = "Background"
        '
        'ThemeSelectBackground
        '
        Me.ThemeSelectBackground.Name = "ThemeSelectBackground"
        Me.ThemeSelectBackground.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ThemeSelectBackground.Size = New System.Drawing.Size(246, 24)
        Me.ThemeSelectBackground.Text = "Select"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(243, 6)
        '
        'ThemeClearBackground
        '
        Me.ThemeClearBackground.Name = "ThemeClearBackground"
        Me.ThemeClearBackground.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ThemeClearBackground.Size = New System.Drawing.Size(246, 24)
        Me.ThemeClearBackground.Text = "Clear"
        '
        'dWhen
        '
        Me.dWhen.FormattingEnabled = True
        Me.dWhen.Location = New System.Drawing.Point(14, 233)
        Me.dWhen.Name = "dWhen"
        Me.dWhen.Size = New System.Drawing.Size(363, 28)
        Me.dWhen.TabIndex = 14629
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 16761
        Me.Label3.Text = "When"
        '
        'hForever
        '
        Me.hForever.AutoSize = True
        Me.hForever.Checked = True
        Me.hForever.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hForever.Enabled = False
        Me.hForever.Location = New System.Drawing.Point(298, 586)
        Me.hForever.Name = "hForever"
        Me.hForever.Size = New System.Drawing.Size(82, 24)
        Me.hForever.TabIndex = 16763
        Me.hForever.TabStop = False
        Me.hForever.Text = "Forever"
        Me.hForever.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 16765
        Me.Label5.Text = "Icon:"
        '
        'tIcon
        '
        Me.tIcon.Enabled = False
        Me.tIcon.Location = New System.Drawing.Point(14, 482)
        Me.tIcon.MaxLength = 63
        Me.tIcon.Name = "tIcon"
        Me.tIcon.Size = New System.Drawing.Size(271, 26)
        Me.tIcon.TabIndex = 16764
        Me.tIcon.TabStop = False
        '
        'bBrowseForIcon
        '
        Me.bBrowseForIcon.Location = New System.Drawing.Point(291, 481)
        Me.bBrowseForIcon.Name = "bBrowseForIcon"
        Me.bBrowseForIcon.Size = New System.Drawing.Size(53, 28)
        Me.bBrowseForIcon.TabIndex = 14632
        Me.bBrowseForIcon.Text = "..."
        Me.bBrowseForIcon.UseVisualStyleBackColor = True
        '
        'pIcon
        '
        Me.pIcon.BackColor = System.Drawing.Color.Transparent
        Me.pIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pIcon.Location = New System.Drawing.Point(351, 482)
        Me.pIcon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pIcon.Name = "pIcon"
        Me.pIcon.Size = New System.Drawing.Size(26, 26)
        Me.pIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pIcon.TabIndex = 16767
        Me.pIcon.TabStop = False
        Me.pIcon.Tag = "v"
        '
        'tID
        '
        Me.tID.Location = New System.Drawing.Point(674, 588)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(100, 26)
        Me.tID.TabIndex = 16768
        '
        'TitleBar
        '
        Me.TitleBar.Location = New System.Drawing.Point(490, 310)
        Me.TitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(11, 20)
        Me.TitleBar.TabIndex = 16797
        Me.TitleBar.TabStop = False
        '
        'FooterBar
        '
        Me.FooterBar.Location = New System.Drawing.Point(490, 310)
        Me.FooterBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FooterBar.Name = "FooterBar"
        Me.FooterBar.Size = New System.Drawing.Size(11, 20)
        Me.FooterBar.TabIndex = 16798
        Me.FooterBar.TabStop = False
        '
        'MaximizeBox
        '
        Me.MaximizeBox.AutoSize = True
        Me.MaximizeBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox.Location = New System.Drawing.Point(484, 310)
        Me.MaximizeBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaximizeBox.Name = "MaximizeBox"
        Me.MaximizeBox.Size = New System.Drawing.Size(22, 20)
        Me.MaximizeBox.TabIndex = 16799
        Me.MaximizeBox.Text = "O"
        '
        'dTime
        '
        Me.dTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dTime.Location = New System.Drawing.Point(418, 397)
        Me.dTime.Name = "dTime"
        Me.dTime.Size = New System.Drawing.Size(119, 26)
        Me.dTime.TabIndex = 16800
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 640)
        Me.Controls.Add(Me.dTime)
        Me.Controls.Add(Me.MaximizeBox)
        Me.Controls.Add(Me.FooterBar)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.pIcon)
        Me.Controls.Add(Me.bBrowseForIcon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tIcon)
        Me.Controls.Add(Me.hForever)
        Me.Controls.Add(Me.dWhen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Guide)
        Me.Controls.Add(Me.RepeatCheck)
        Me.Controls.Add(Me.ModalText)
        Me.Controls.Add(Me.Modal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MinutesLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Interval)
        Me.Controls.Add(Me.Commit)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.EmptyButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.PicturePath)
        Me.Controls.Add(Me.Feedback)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.SystemCloseButton)
        Me.Controls.Add(Me.DialogTitle)
        Me.Controls.Add(Me.BottomLine)
        Me.Controls.Add(Me.TopLine)
        Me.Controls.Add(Me.BottomBorder)
        Me.Controls.Add(Me.RightBorder)
        Me.Controls.Add(Me.LeftBorder)
        Me.Controls.Add(Me.TopBorder)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Net Timer"
        CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.pIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FooterBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeLabel As Label
	Friend WithEvents PicturePath As TextBox
	Friend WithEvents Feedback As TextBox
	Friend WithEvents TimeTimer As Timer
	Friend WithEvents HelpButton As PictureBox
	Friend WithEvents CloseButton As Label
	Friend WithEvents MinimizeButton As Label
	Friend WithEvents SystemCloseButton As Button
	Friend WithEvents DialogTitle As Label
	Friend WithEvents BottomLine As PictureBox
	Friend WithEvents TopLine As PictureBox
	Friend WithEvents BottomBorder As PictureBox
	Friend WithEvents RightBorder As PictureBox
	Friend WithEvents LeftBorder As PictureBox
	Friend WithEvents TopBorder As PictureBox
	Friend WithEvents EmptyButton As Button
	Friend WithEvents Display As TextBox
	Friend WithEvents Commit As Button
	Friend WithEvents Interval As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents MinutesLabel As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Modal As ComboBox
	Friend WithEvents ModalText As TextBox
	Friend WithEvents NotifyIcon1 As NotifyIcon
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RepeatTimer As Timer
	Friend WithEvents RepeatCheck As CheckBox
	Friend WithEvents OutTimer As Timer
	Friend WithEvents InTimer As Timer
	Friend WithEvents xTimer As Timer
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents AbToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Guide As CheckBox
	Friend WithEvents MenuStrip As MenuStrip
	Friend WithEvents TasksToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem15 As ToolStripSeparator
	Friend WithEvents CheckToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem14 As ToolStripSeparator
	Friend WithEvents NewEntryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem16 As ToolStripSeparator
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EnglishLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents FrenchLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ThaiLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents YorubaLanguage As ToolStripMenuItem
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClassicThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
	Friend WithEvents LavenderThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
	Friend WithEvents NightThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
	Friend WithEvents RoseThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
	Friend WithEvents StandardThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents ApplicationFeedbackToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MessagePromptOnly As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
	Friend WithEvents MessagePromptWithVoice As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
	Friend WithEvents VoiceOnly As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents DefaultActionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
	Friend WithEvents GreenTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents TurqoiseTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents VelvetTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents PurpleTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents WhiteTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
	Friend WithEvents BrownTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
	Friend WithEvents YellowTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
	Friend WithEvents ThemeBackground As ToolStripMenuItem
	Friend WithEvents ThemeSelectBackground As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem17 As ToolStripSeparator
	Friend WithEvents ThemeClearBackground As ToolStripMenuItem
	Friend WithEvents AnimationTimer As Timer
	Friend WithEvents dWhen As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents hForever As CheckBox
	Friend WithEvents Label5 As Label
	Friend WithEvents tIcon As TextBox
	Friend WithEvents bBrowseForIcon As Button
	Friend WithEvents pIcon As PictureBox
	Friend WithEvents tID As TextBox
	Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem18 As ToolStripSeparator
	Friend WithEvents TitleBar As PictureBox
	Friend WithEvents FooterBar As PictureBox
	Friend WithEvents MaximizeBox As Label
	Friend WithEvents dTime As DateTimePicker
End Class
