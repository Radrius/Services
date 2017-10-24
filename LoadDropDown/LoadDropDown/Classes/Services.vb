Imports System.ServiceProcess
Public Class Services

	Public Sub _Start(ByVal Service_Name As String, ByVal ComputerName As String)

		Dim service As ServiceController = New ServiceController(Service_Name, ComputerName)
		Try
			If service.Status.Equals(ServiceControllerStatus.Stopped) Then
				service.Start()
			Else
				'Service is running
			End If
		Catch ex As Exception
			Dim trace = New StackTrace(ex, True).ToString()
			Dim line As String = "Line:" & trace.ToString()
			Dim inner As String = ex.InnerException.ToString()
			Dim innerAry As String() = inner.Split(":")
			Utility.WriteException(ex.ToString, line)
		End Try
	End Sub

	Public Sub _Stop(ByVal Service_Name As String, ByVal ComputerName As String)

		Dim service As ServiceController = New ServiceController(Service_Name, ComputerName)
		Try
			If service.Status.Equals(ServiceControllerStatus.Running) Then
				service.Stop()
			Else
				'Service is already stopped.
			End If
		Catch ex As Exception
			Dim trace = New StackTrace(ex, True).ToString()
			Dim line As String = "Line:" & trace.ToString()
			Dim inner As String = ex.InnerException.ToString()
			Dim innerAry As String() = inner.Split(":")
			Utility.WriteException(ex.ToString, line)
		End Try
	End Sub

	Public Function _Check(ByVal Service_Name As String, ByVal ComputerName As String)

		Dim service As ServiceController = New ServiceController(Service_Name, ComputerName)
		Try
			If service.Status.Equals(ServiceControllerStatus.Running) Then
				Return 1
			ElseIf service.Status.Equals(ServiceControllerStatus.Stopped) Or service.Status.Equals(ServiceControllerStatus.StopPending) Then
				Return 0
			Else
				Return 2
			End If
		Catch ex As Exception
			Dim trace = New StackTrace(ex, True).ToString()
			Dim line As String = "Line:" & trace.ToString()
			Dim inner As String = ex.InnerException.ToString()
			Dim innerAry As String() = inner.Split(":")
			Utility.WriteException(ex.ToString, line)
			Return 2
		End Try

	End Function

End Class
