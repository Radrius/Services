Imports System.IO
Imports System.Reflection
Public Class Utility

	Public Shared Sub WriteException(ByVal exception As String, line As String)

		Dim version As String
		Dim _Date As DateTime = DateTime.Now
		Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
		Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")

		version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Path = New Uri(Path).LocalPath

		If Not Directory.Exists(Path & "\Log\") Then
			Directory.CreateDirectory(Path & "\Log\")
		End If

		Dim LogPath As String = Path + "\Log\" & _DateString & "_RollBackError.log"


		If Not File.Exists(LogPath) Then
			Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** RollBack " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception & line)
			End Using
		Else
			Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** RollBack " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception & line)
			End Using
		End If
	End Sub

End Class