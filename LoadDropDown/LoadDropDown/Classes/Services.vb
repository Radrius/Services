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
			Utility.WriteException(ex)
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
			Utility.WriteException(ex)
		End Try
	End Sub

	Public Function _Check(ByVal Service_Name As String, ByVal ComputerName As String)

		Dim service As ServiceController = New ServiceController(Service_Name, ComputerName)
		Try
			If service.Status.Equals(ServiceControllerStatus.Running) Or service.Status.Equals(ServiceControllerStatus.StartPending) Then
				Return 1
			ElseIf service.Status.Equals(ServiceControllerStatus.Stopped) Or service.Status.Equals(ServiceControllerStatus.StopPending) Then
				Return 0
			Else
				Return 2
			End If
		Catch ex As Exception
			Utility.WriteException(ex)
			Return 2
		End Try

	End Function

	Public Function _AvailableServices(ByVal ServiceName As String, ByVal ComputerName As String)

		Try
			Dim AllServices() As ServiceController
			AllServices = ServiceController.GetServices()

			For Each s In AllServices
				If s.ServiceName = ServiceName Then
					Return True
				End If
			Next

			Return False
		Catch ex As Exception
			Utility.WriteException(ex)
			Return False
		End Try

	End Function

End Class
