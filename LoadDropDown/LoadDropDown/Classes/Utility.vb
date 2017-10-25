Imports System.IO
Imports System.Reflection
Public Class Utility

	Public Shared Sub WriteException(ByVal exception As Exception)

		Dim version As String
		Dim _Date As DateTime = DateTime.Now
		Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
		Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")


		Dim trace = New StackTrace(exception, True).ToString()
		Dim line As String = "Line:" & trace.ToString()
		Dim inner As String = exception.InnerException.ToString()
		Dim innerAry As String() = inner.Split(":")


		version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Path = New Uri(Path).LocalPath

		If Not Directory.Exists(Path & "\Log\") Then
			Directory.CreateDirectory(Path & "\Log\")
		End If

		Dim LogPath As String = Path + "\Log\" & _DateString & "_ServicesError.log"


		If Not File.Exists(LogPath) Then
			Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** Services " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception.ToString() & line)
			End Using
		Else
			Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** Services " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception.ToString() & line)
			End Using
		End If
	End Sub

End Class