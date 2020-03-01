Imports System.Collections.ObjectModel
Imports NModule.SJ
Imports NModule.D
Imports NModule.NFunctions
Imports NModule.Methods
Imports GeneralModule.Database
Public Class Form1

	Dim l As ReadOnlyCollection(Of String)
	'	Dim tgt_prog_folder As String = "C:\Users\iNovationServer\Documents\Projects\Net Timer\Copier\bin\Debug\Programs"
	Dim tgt_prog_folder As String = "D:\Work\Inhouse\Net Timer\Copier\bin\Debug\Programs"
	'	Dim internal_file As String = main_folder & "\flow.txt"
	Dim n As New NModule.Methods
	Public Function IsEmpty_(file_ As String) As Boolean
		Return ReadText(file_).Length < 1
	End Function
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Hide()
		PermitFolder(My.Application.Info.DirectoryPath)

		l = My.Computer.FileSystem.GetFiles(tgt_prog_folder, FileIO.SearchOption.SearchAllSubDirectories, "net timer.exe")
		If l.Count < 1 Then Environment.Exit(0)
		With l
			For i As Integer = 0 To .Count - 1
				StartFile(l(i))
			Next

		End With
		Environment.Exit(0)
	End Sub

End Class
