Imports Web_Module.DW
Imports Web_Module.DataConnectionDesktop
Imports GeneralModule.Database
Imports NModule.NFunctions
Imports NModule.D
Imports Feedback.Feedback
Imports NModule.Methods
Imports NModule.SJ
Imports General_Module.FormatWindow
Imports System.Collections.ObjectModel
Public Class Main
#Region "File Paths Variables"
	Private path_file As String = Content(My.Application.Info.DirectoryPath & "\id.txt")

	'REPLACE WITH THE VALUE OF THE SAME VARIABLE IN Form1 in Copier
	Private setting_file As String = ""
#End Region

#Region "Specifics Variables"
	Private setting_ As String = Content(setting_file)

	Private t As Integer = 0

	Private tID_file As String = path_file & "\tID.txt"
	Private Modal_file As String = path_file & "\Modal.txt"
	Private ModalText_file As String = path_file & "\ModalText.txt"
	Private dWhen_file As String = path_file & "\dWhen.txt"
	Private Display_file As String = path_file & "\Display.txt"
	Private Interval_file As String = path_file & "\Interval.txt"
	Private MinutesLabel_file As String = path_file & "\MinutesLabel.txt"
	Private tIcon_file As String = path_file & "\tIcon.txt"
	Private RepeatCheck_file As String = path_file & "\RepeatCheck.txt"
	Private hForever_file As String = path_file & "\hForever.txt"
	Private Time_file As String = path_file & "\Time.txt"

	Dim exists_ As Boolean = False

#End Region

#Region "References Variables"
	Private o As New General_Module.FormatWindow

#End Region

#Region "theme"
	Private Sub GreenTheme_Click(sender As Object, e As EventArgs) Handles GreenTheme.Click, TurqoiseTheme.Click, BrownTheme.Click, YellowTheme.Click, VelvetTheme.Click, PurpleTheme.Click, WhiteTheme.Click
		Dim mark_ As ToolStripMenuItem = sender
		MarkTheme(selected_theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)

		'dialog
		o.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, EmptyButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeBox, False, False, False, True, selected_theme, Feedback, TimeTimer, TimeLabel, False)
	End Sub

	Private Sub ThemeSelectBackground_Click(sender As Object, e As EventArgs) Handles ThemeSelectBackground.Click
		DialogBackground(Me)
	End Sub

	Private Sub ThemeClearBackground_Click(sender As Object, e As EventArgs) Handles ThemeClearBackground.Click
		ClearDialogBackground(Me)
	End Sub
#End Region

#Region "Other Functions"

	Private Sub ReadFile()
		If ModalText.Text.Trim <> "" Then
			RepeatTimer.Enabled = True
		End If
	End Sub

	Private Sub PlayFile()
		If ModalText.Text.Trim <> "" Then
			Try
				Process.Start(ModalText.Text.Trim)
			Catch ex As Exception
			End Try
		End If
	End Sub
	Private Sub FeedbackProgress()
		Select Case Modal.Text
			Case "Read Out Loud"
				ReadFile()
			Case "Start The App"
				PlayFile()
			Case Else
		End Select
		If RepeatCheck.Checked = False Then TimeTimer.Enabled = False
	End Sub

#End Region

#Region ""
	Private Function GetTime(t_)

		If Date.Parse(Now) <= t_ Then
			Return DateDiff(DateInterval.Minute, Date.Parse(Now), t_)
		Else
			Return (60 * 24) + DateDiff(DateInterval.Minute, Date.Parse(Now), t_)

		End If

	End Function
	Private Sub InitializeControls()
		Dim icon_file As String = ""
		Dim t__id As String = Content(tID_file)

		If setting_ = True Then
			If QExists(table__, server_con, {"tID_file"}, {"tID_file", t__id}) = False Then
				Exit Sub
			Else
				exists_ = True
			End If
			Try
				icon_file = QData(BuildSelectString(table__, {"tIcon_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				If icon_file.Length < 1 Then
					icon_file = default_icon
				End If

				tID.Text = t__id
				Modal.Text = QData(BuildSelectString(table__, {"Modal_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				ModalText.Text = QData(BuildSelectString(table__, {"ModalText_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				dWhen.Text = QData(BuildSelectString(table__, {"dWhen_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				Display.Text = QData(BuildSelectString(table__, {"Display_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				Interval.Value = GetTime(QData(BuildSelectString(table__, {"Time_file"}, {"tID_file"}), server_con, {"tID_file", t__id}))
				dTime.Value = QData(BuildSelectString(table__, {"Time_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				MinutesLabel.Text = QData(BuildSelectString(table__, {"MinutesLabel_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				RepeatCheck.Checked = QData(BuildSelectString(table__, {"RepeatCheck_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				hForever.Checked = QData(BuildSelectString(table__, {"hForever_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				Text = QData(BuildSelectString(table__, {"Display_file"}, {"tID_file"}), server_con, {"tID_file", t__id})
				NotifyIcon1.Text = QData(BuildSelectString(table__, {"Display_file"}, {"tID_file"}), server_con, {"tID_file", t__id})

				tIcon.Text = icon_file
				Try
					Icon = New Icon(icon_file)
					NotifyIcon1.Icon = New Icon(icon_file)
					pIcon.Image = Image.FromFile(icon_file)
				Catch ex As Exception
				End Try
			Catch ex As Exception
			End Try
		Else
			If Exists(Modal_file) = False Then
				Exit Sub
			Else
				exists_ = True
			End If
			Try
				icon_file = Content(tIcon_file)
				If icon_file.Length < 1 Then
					icon_file = default_icon
				End If
				tID.Text = Content(tID_file)
				Modal.Text = Content(Modal_file)
				ModalText.Text = Content(ModalText_file)
				dWhen.Text = Content(dWhen_file)
				Display.Text = Content(Display_file)
				Interval.Value = GetTime(Content(Time_file))
				dTime.Value = Content(Time_file)
				MinutesLabel.Text = Content(MinutesLabel_file)
				tIcon.Text = icon_file
				RepeatCheck.Checked = Content(RepeatCheck_file)
				hForever.Checked = Content(hForever_file)
				Text = Content(Display_file)
				Try
					NotifyIcon1.Icon = New Icon(icon_file)
					Icon = New Icon(icon_file)
					pIcon.Image = Image.FromFile(icon_file)
				Catch ex As Exception
				End Try
				NotifyIcon1.Text = Content(Display_file)

			Catch ex As Exception
			End Try
		End If

		Disable_Controls()



		Me.WindowState = FormWindowState.Normal
		MarkTheme(selected_theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)
		o.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, EmptyButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeBox, False, False, False, True, selected_theme, Feedback, TimeTimer, TimeLabel, False)
		TopLine.Visible = False
		BottomLine.Visible = False

	End Sub
	Public Function DisplayImage(p_ As PictureBox, i_ As Object, Optional as_bg_image As Boolean = False) As PictureBox
		Try
			If TypeOf i_ Is Image Then
				If as_bg_image Then
					p_.BackgroundImage = i_
				Else
					p_.Image = i_
				End If
			Else
				If as_bg_image Then
					p_.BackgroundImage = Image.FromFile(i_)
				Else
					p_.Image = Image.FromFile(i_)
				End If
			End If
		Catch
		End Try
	End Function
	Public Shadows Sub ShowIcon()
		Dim icon_file As String = Content(tIcon)
		If IsEmpty(tIcon) Then
			icon_file = default_icon
		End If

		Me.Icon = New Icon(icon_file)
		Me.Text = Content(Display)
		NotifyIcon1.Icon = New Icon(icon_file)

	End Sub
	Public Sub Disable_Controls()
		EnableControls({Modal, ModalText, dWhen, Display, tIcon, bBrowseForIcon, RepeatCheck, hForever}, False)

		If Content(dWhen) <> "the time is due" Then
			If exists_ = True Then
				ExitApp()
			End If
			Interval.Hide()
			MinutesLabel.Hide()
			Label2.Hide()
		Else
			Interval.Show()
			MinutesLabel.Show()
			Label2.Show()
		End If
	End Sub
	Private Sub SetValues()
		'fix nmodule

		Dim ml As String = MinutesLabel.Text
		With dWhen
			If .Text = "the time is due" Then
				MinutesLabel.Text = ml & " (" & DateAdd(DateInterval.Minute, Interval.Value, Date.Parse(Now)).ToLongTimeString & ")"
			Else
				MinutesLabel.Text = ml
			End If
		End With
		EnableControls({Modal, ModalText, dWhen, Display, tIcon, bBrowseForIcon, RepeatCheck, hForever}, False)

		Dim icon_file As String = Content(tIcon)
		If IsEmpty(tIcon) Then
			icon_file = default_icon
		End If

		Me.Icon = New Icon(icon_file)
		Me.Text = Content(Display)
		NotifyIcon1.Icon = New Icon(icon_file)

		NotifyIcon1.Text = Display.Text.Trim
		SaveValues()
	End Sub

	Private Sub SaveValues()
		If hForever.Checked = False Then Exit Sub
		Try

			tID.Text = Content(tID_file)

			Dim tID_file_ As String = Content(tID)
			Dim Modal_file_ As String = Content(Modal)
			Dim ModalText_file_ As String = Content(ModalText)
			Dim dWhen_file_ = Content(dWhen)
			Dim Display_file_ As String = Content(Display)
			Dim Interval_file_ As String = Content(Interval)
			Dim MinutesLabel_file_ As String = Content(MinutesLabel)
			Dim tIcon_file_ As String = Content(tIcon)
			Dim RepeatCheck_file_ As String = Content(RepeatCheck)
			Dim hForever_file_ As String = Content(hForever)
			Dim Time_file_ As String = Content(dTime)

			If setting_ = True Then
				CommitSequel(BuildInsertString(table__, {"tID_file", "Modal_file", "ModalText_file", "dWhen_file", "Display_file", "Interval_file", "MinutesLabel_file", "tIcon_file", "RepeatCheck_file", "hForever_file", "Time_file"}), server_con, {"tID_file", tID_file_, "Modal_file", Modal_file_, "ModalText_file", ModalText_file_, "dWhen_file", dWhen_file_, "Display_file", Display_file_, "Interval_file", Interval_file_, "MinutesLabel_file", MinutesLabel_file_, "tIcon_file", tIcon_file_, "RepeatCheck_file", RepeatCheck_file_, "hForever_file", hForever_file_, "Time_file", Time_file_})
			Else
				WriteText(tID_file, tID_file_)
				WriteText(Modal_file, Modal_file_)
				WriteText(ModalText_file, ModalText_file_)
				WriteText(dWhen_file, dWhen_file_)
				WriteText(Display_file, Display_file_)
				WriteText(Interval_file, Interval_file_)
				WriteText(MinutesLabel_file, MinutesLabel_file_)
				WriteText(tIcon_file, tIcon_file_)
				WriteText(RepeatCheck_file, RepeatCheck_file_)
				WriteText(hForever_file, hForever_file_)
				WriteText(Time_file, Time_file_)
			End If

			If Content(dWhen) <> "the time is due" Then ExitApp()

		Catch
		End Try
	End Sub
	Private Sub PrepareFile()

		Dim icon_file As String = Content(tIcon)
		If IsEmpty(tIcon) Then
			icon_file = default_icon
			tIcon.Text = icon_file
			DisplayImage(pIcon, icon_file)
		End If

		Dim n As New NModule.Methods

		If dWhen.Text = "computer starts" Then
			Try
				n.ToStartup(Content(ModalText), Content(tID))
			Catch ex As Exception
				MsgBox(ex.ToString)
			End Try
		ElseIf dWhen.Text = "I say" Then
			n.CreateShortcut(Content(ModalText), Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), Content(Display), icon_file)
			StartFile(Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\Speech\Common\sapisvr.exe")
		End If
	End Sub

#End Region

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PermitFolder(My.Application.Info.DirectoryPath)

		InitializeControls()

		If IsEmpty(tID) Then tID.Text = NewGUID()

		Me.WindowState = FormWindowState.Normal

		MarkTheme(selected_theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)

		'dialog
		o.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, EmptyButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeBox, False, False, False, True, selected_theme, Feedback, TimeTimer, TimeLabel, False)
		TopLine.Visible = False
		BottomLine.Visible = False

		'
		With Modal
			With .Items
				.Clear()
				.Add("Read Out Loud")
				.Add("Start The App")
			End With
		End With
		With dWhen
			With .Items
				.Clear()
				.Add("computer starts")
				.Add("I say")
				.Add("the time is due")
			End With
		End With

		OutTimer.Enabled = exists_

	End Sub

	Private Sub Display_TextChanged(sender As Object, e As EventArgs) Handles Display.TextChanged
		ToTitleCase(sender)
	End Sub

	Private Sub Interval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Interval.KeyPress
		AllowNumberOnly(e)
	End Sub

	Private Sub Modal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Modal.SelectedIndexChanged
		Select Case Modal.Text
			Case "Read Out Loud"
				FocusMe(sender, ModalText)
			Case "Start The App"
				ModalText.Text = o.GetFile("all", ModalText.Text)
		End Select
	End Sub

	Private Sub Modal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Modal.KeyPress, dWhen.KeyPress
		AllowNothing(e)
	End Sub

	Private Sub Interval_ValueChanged(sender As Object, e As EventArgs) Handles Interval.ValueChanged
		If Interval.Value = 1 Then
			MinutesLabel.Text = "Minute"
		ElseIf Interval.Value <> 1 Then
			MinutesLabel.Text = "Minutes"
		End If
	End Sub

	Private Sub Commit_Click(sender As Object, e As EventArgs) Handles Commit.Click
		If Display.Text.Trim = "" Then Exit Sub

		If IsEmpty(ModalText) Then Exit Sub

		If IsEmpty(dWhen) Then Exit Sub


		dTime.Value = DateAdd(DateInterval.Minute, Interval.Value, Date.Parse(Now))

		With dWhen
			If .Text <> "the time is due" Then
				PrepareFile()
			Else
				TimeTimer.Interval = Interval.Value * 1000 * 60
				TimeTimer.Enabled = True

			End If
		End With
		SetValues()

2:
		OutTimer.Enabled = True
	End Sub

	Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click ', NotifyIcon1.Click
		Me.WindowState = FormWindowState.Normal
		Me.OutTimer.Enabled = False
		Me.Opacity = 0
		Me.InTimer.Enabled = True
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

		Environment.Exit(0)
	End Sub

	Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
		FeedbackProgress()
	End Sub

	Private Sub RepeatTimer_Tick(sender As Object, e As EventArgs) Handles RepeatTimer.Tick
		If t = 3 Then
			RepeatTimer.Enabled = False
			t = 0
			Exit Sub
		End If
		f.fFeedback(ModalText.Text.Trim)
		t += 1
	End Sub

	Private Sub InTimer_Tick(sender As Object, e As EventArgs) Handles InTimer.Tick
		If OutTimer.Enabled = True Then OutTimer.Enabled = False
		If Me.Opacity >= 1 Then
			InTimer.Enabled = False
			Exit Sub
		End If
		Me.Opacity += 0.2

	End Sub

	Private Function DisplaySet() As Boolean
		Return Display.Text.Trim.Length > 0
	End Function
	Private Sub CloseOrExit(sender As Object, e As EventArgs)
		If Display.Text.Trim.Length < 1 And ModalText.Text.Trim.Length < 1 Then
			Environment.Exit(0)
		End If

		If DisplaySet() And Interval.Value.ToString.Trim <> "" Then
			Commit_Click(sender, e)
			Me.WindowState = FormWindowState.Minimized
		End If
	End Sub

	Private Sub OutTimer_Tick(sender As Object, e As EventArgs) Handles OutTimer.Tick
		If Me.Opacity <= 0 Then
			OutTimer.Enabled = False
		End If
		Me.Opacity -= 0.2
	End Sub

	Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
		OutTimer.Enabled = True
	End Sub

	Private Sub xTimer_Tick(sender As Object, e As EventArgs) Handles xTimer.Tick
		If Me.Opacity <= 0 Then
			Me.Close()
		End If
		Me.Opacity -= 0.2
	End Sub

	Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
		Commit_Click(sender, e)
	End Sub

	Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click, HelpButton.Click
		StartFile(My.Application.Info.DirectoryPath & "\Net Timer Help.exe")
	End Sub

	Private Sub bBrowseForIcon_Click(sender As Object, e As EventArgs) Handles bBrowseForIcon.Click
		Dim file_ As String
		Dim extension_ As String
		Dim value_ As Array = GetFileAndExtension("picture")
		If value_(0) = True And value_(1).ToString.Length > 0 And value_(2).ToString.Length > 0 Then
			file_ = value_(1)
			extension_ = value_(2)
			If extension_.ToLower <> ".ico" Then
				m_Feedback("Please select another file. The file needs to be a file with .ico extension.")
				Exit Sub
			End If
		Else
			Exit Sub
		End If

		tIcon.Text = file_
		pIcon.Image = Image.FromFile(file_)
	End Sub

	Private Sub dWhen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dWhen.SelectedIndexChanged
		Select Case dWhen.Text.Trim
			Case "I say"
				Label1.Text = "Start "
				Display.Focus()
			Case Else
				Label1.Text = "Display:"
				XFocusMe(Display, Display)
		End Select

		If Content(dWhen) <> "the time is due" Then
			Interval.Hide()
			MinutesLabel.Hide()
			Label2.Hide()
		Else
			Interval.Show()
			MinutesLabel.Show()
			Label2.Show()
		End If
	End Sub

	Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
		If m_Feedback("Really remove this reminder?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
		Dim n As New NModule.Methods
		Try
			n.RemoveFromStartup(Content(ModalText), Content(tID))
		Catch
		End Try
		Try
			WriteText(My.Application.Info.DirectoryPath & "\History.txt", "delete")

		Catch ex As Exception

		End Try
		Environment.Exit(0)
	End Sub
End Class