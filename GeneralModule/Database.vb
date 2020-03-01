Public Class Database

#Region "File Paths Variables"
	'you might change to App Data/Roaming
	Public Shared ReadOnly Property main_folder As String = My.Application.Info.DirectoryPath & "\Net Timer"

	Public Shared ReadOnly Property main_file As String = main_folder & "\main.txt"
	Public Shared ReadOnly Property variable_file As String = main_folder & "\Setting.txt"
	Public Shared ReadOnly Property default_icon As String = main_folder & "\ICS client.ico"
#End Region

#Region "Shared Info"
	Public Shared ReadOnly Property table__ As String = "YOUR SQL TABLE"

	Public Shared ReadOnly Property server_con As String = "YOUR SQL CONNECTION STRING"

#End Region

End Class
