Imports System.IO
Imports System.Collections.ObjectModel
Imports GeneralModule.KV
Imports Web_Module.DW
Imports Web_Module.DataConnectionDesktop
Imports NModule.Methods
Imports NModule.D
Public Class Form1

#Region "File Paths Variables"
    Private setting_file As String = My.Application.Info.DirectoryPath & "\Setting.txt"
    Dim tgt_prog_folder As String = "D:\Work\Inhouse\Net Timer\Copier\bin\Debug\Programs"
    Dim sync_complete_sound_file As String = My.Application.Info.DirectoryPath & "\Complete.wav"
#End Region

#Region "References Variables"
    Private f As New Feedback.Feedback
#End Region
#Region "Specifics Variables"
    Private setting_ As Boolean = Content(setting_file)
    Dim l_files As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(tgt_prog_folder, FileIO.SearchOption.SearchTopLevelOnly)
    Dim l As New List(Of String)
    '    Dim path_file As String = tgt_prog_folder & "\"

#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()
        UseOnlineStorageToolStripMenuItem.Checked = setting_
        PermitFolder(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub UseOnlineStorageToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles UseOnlineStorageToolStripMenuItem.CheckedChanged
        WriteText(setting_file, UseOnlineStorageToolStripMenuItem.Checked)
    End Sub

    Private Sub SynchronizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SynchronizeToolStripMenuItem.Click
        If MsgBox("About to upload content on this machine to the server. Any reminder with the same id will be overwritten. Proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "") = MsgBoxResult.No Then Exit Sub

        Try
            l.Clear()
        Catch ex As Exception
        End Try

        With l
            For i As Long = 0 To l_files.Count - 1
                .Add(Path.GetFileNameWithoutExtension(l_files(i)))
            Next
        End With

        Dim counter_ As Long = 0
        Try
            With l
                For i As Integer = 0 To .Count - 1
                    If QExists(table__, server_con, {"tID_file"}, {"tID_file", l(i)}) = False Then
                        CommitSequel(BuildInsertString(table__, {"tID_file", "Modal_file", "ModalText_file", "dWhen_file", "Display_file", "Interval_file", "MinutesLabel_file", "tIcon_file", "RepeatCheck_file", "hForever_file", "Time_file"}), server_con, {"tID_file", Content(tgt_prog_folder & "\" & l(i) & "\tID.txt"), "Modal_file", Content(tgt_prog_folder & "\" & l(i) & "\Modal.txt"), "ModalText_file", Content(tgt_prog_folder & "\" & l(i) & "\ModalText.txt"), "dWhen_file", Content(tgt_prog_folder & "\" & l(i) & "\dWhen.txt"), "Display_file", Content(tgt_prog_folder & "\" & l(i) & "\Display.txt"), "Interval_file", Content(tgt_prog_folder & "\" & l(i) & "\Interval.txt"), "MinutesLabel_file", Content(tgt_prog_folder & "\" & l(i) & "\MinutesLabel.txt"), "tIcon_file", Content(tgt_prog_folder & "\" & l(i) & "\tIcon.txt"), "RepeatCheck_file", Content(tgt_prog_folder & "\" & l(i) & "\RepeatCheck.txt"), "hForever_file", Content(tgt_prog_folder & "\" & l(i) & "\hForever.txt"), "Time_file", Content(tgt_prog_folder & "\" & l(i) & "\Time.txt")})
                        counter_ += 1
                    Else
                        CommitSequel(BuildUpdateString(table__, {"Modal_file", "ModalText_file", "dWhen_file", "Display_file", "Interval_file", "MinutesLabel_file", "tIcon_file", "RepeatCheck_file", "hForever_file", "Time_file"}, {"tID_file"}), server_con, {"Modal_file", Content(tgt_prog_folder & "\" & l(i) & "\Modal.txt"), "ModalText_file", Content(tgt_prog_folder & "\" & l(i) & "\ModalText.txt"), "dWhen_file", Content(tgt_prog_folder & "\" & l(i) & "\dWhen.txt"), "Display_file", Content(tgt_prog_folder & "\" & l(i) & "\Display.txt"), "Interval_file", Content(tgt_prog_folder & "\" & l(i) & "\Interval.txt"), "MinutesLabel_file", Content(tgt_prog_folder & "\" & l(i) & "\MinutesLabel.txt"), "tIcon_file", Content(tgt_prog_folder & "\" & l(i) & "\tIcon.txt"), "RepeatCheck_file", Content(tgt_prog_folder & "\" & l(i) & "\RepeatCheck.txt"), "hForever_file", Content(tgt_prog_folder & "\" & l(i) & "\hForever.txt"), "Time_file", Content(tgt_prog_folder & "\" & l(i) & "\Time.txt"), "tID_file", Content(tgt_prog_folder & "\" & l(i) & "\tID.txt")})
                        counter_ += 1
                    End If
                Next
            End With
            PlayAudio(sync_complete_sound_file)
            f.fFeedback(ToPlural(counter_, "record") & " synchronized.")
        Catch ex As Exception
        End Try
    End Sub
End Class
