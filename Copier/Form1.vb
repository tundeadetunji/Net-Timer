Imports NModule.D
Imports NModule.Methods
Public Class Form1

	'REPLACE THIS WITH THE THE FINAL LOCATION OF THE Net Timer PROGRAM ITSELF, I.E. THE FOLDER CONTAINING THE MAIN EXE
	Dim src_prog_folder As String = "C:\PROGRAM FILES\Net Timer\Net Timer\bin\Debug"

	Dim tgt_prog_folder As String = My.Application.Info.DirectoryPath & "\Programs"

	'REPLACE THIS WITH THE FINAL LOCATION OF Setting.txt IN THE FOLDER CONTAINING THE EXE OF Net Timer Tray Icon
	Dim setting_file As String = "C:\PROGRAM FILES\Net Timer\Net Timer Tray Icon\bin\Debug\Setting.txt"

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Hide()
		PermitFolder(My.Application.Info.DirectoryPath)

		Dim id As String = Guid.NewGuid.ToString
		Dim tgt As String = tgt_prog_folder & "\" & id
		Try
			MkDir(tgt)
		Catch ex As Exception

		End Try
		My.Computer.FileSystem.CopyDirectory(src_prog_folder, tgt)
		WriteText(tgt & "\id.txt", tgt)
		WriteText(tgt & "\tid.txt", id)
		StartFile(tgt & "\net timer.exe")
		Environment.Exit(0)
	End Sub
End Class
