﻿
Public Class Form1

	'Dim ComputerName As String = Environment.MachineName.ToString() 'using local machine for now, this can be changed to be remote computers
	Private Sub Form1_Load() Handles MyBase.Load

		Dim dt As DataTable = New DataTable
		dt.TableName = "Services"
		dt.ReadXml("Services.xml")
		ListBox1.Items.Clear()
		For Each r As DataRow In dt.Rows
			ListBox1.Items.Add(r.Item("ServiceName"))
		Next

		ComboBox1.SelectedIndex = 0
		If ListBox1.Items.Count > 0 Then
			ListBox1.SelectedIndex = 0
		End If



	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this is to add a service

		Dim dt As DataTable = New DataTable
		dt.TableName = "Services"
		dt.ReadXml("Services.xml")
		Dim NewService As String = TextBox1.Text
		Dim ComputerName As String = ComboBox1.SelectedItem.ToString()
		Dim AvailableService As New Services
		Dim result As Boolean = False

		If NewService <> "" Then

			result = AvailableService._AvailableServices(NewService, ComputerName)

			If result = True Then
				dt.Rows.Add(NewService)
				dt.WriteXml("Services.xml", XmlWriteMode.WriteSchema)
				Form1_Load()
			Else
				MessageBox.Show("That service doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		Else
			MessageBox.Show("Please Enter a Service Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		Dim SelectedService As String = ListBox1.SelectedItem.ToString()
		Dim ComputerName As String = ComboBox1.SelectedItem.ToString()

		Dim StartService As New Services
		StartService._Start(SelectedService, ComputerName)
		CheckServices(SelectedService)

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

		Dim SelectedService As String = ListBox1.SelectedItem.ToString()
		Dim ComputerName As String = ComboBox1.SelectedItem.ToString()

		Dim StopService As New Services
		StopService._Stop(SelectedService, ComputerName)
		CheckServices(SelectedService)

	End Sub


	Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

		Dim SelectedService As String = ListBox1.SelectedItem.ToString()
		CheckServices(SelectedService)
	End Sub

	Private Sub CheckServices(ByVal SelectedService As String)
		Dim Result As Integer = Nothing
		Dim ComputerName As String = ComboBox1.SelectedItem.ToString()
		Dim CheckService As New Services
		Result = CheckService._Check(SelectedService, ComputerName)

		If Result = 0 Then
			Label4.Text = "Stopped or Stop Pending"
			Label4.ForeColor = Color.Red
		ElseIf Result = 1 Then
			Label4.Text = "Running"
			Label4.ForeColor = Color.Green
		Else
			Label4.Text = "Service doesn't exist"
			Label4.ForeColor = Color.Red
		End If
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

		Dim SelectedService As Integer = ListBox1.SelectedIndex
		Dim dt As DataTable = New DataTable

		dt.Columns.Add("ServiceName")
		For Each i In ListBox1.Items
			If ListBox1.Items.IndexOf(i) <> SelectedService Then
				dt.Rows.Add(i)
			End If
		Next
		ListBox1.Items.Clear()

		For Each r As DataRow In dt.Rows
			ListBox1.Items.Add(r.Item("ServiceName"))
		Next
		dt.TableName = "Services"
		dt.WriteXml("Services.xml", XmlWriteMode.WriteSchema)

		Form1_Load()

	End Sub
End Class
