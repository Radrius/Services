Imports System.Xml
Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim dt As DataTable = New DataTable
		dt.TableName = "Services"
		dt.ReadXml("Services.xml")

		For Each r As DataRow In dt.Rows
			ComboBox1.Items.Add(r.Item("ServiceName"))
			ListBox1.Items.Add(r.Item("ServiceName"))
		Next


	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim dt As DataTable = New DataTable
		dt.TableName = "Services"
		dt.ReadXml("Services.xml")
		Dim NewService As String = TextBox1.Text
		If NewService <> "" Then
			dt.Rows.Add(NewService)
			dt.WriteXml("Services.xml", XmlWriteMode.WriteSchema)
			ComboBox1.Refresh()
		Else
			MessageBox.Show("Please Enter a Service Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If


	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		Dim SelectedService As String = ListBox1.SelectedItem.ToString()
		MessageBox.Show(SelectedService)

		Dim something As Integer = 0

		something = something + 2

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

		Dim SelectedService As String = ComboBox1.SelectedItem.ToString()
		MessageBox.Show(SelectedService)
	End Sub

	Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

		Dim SelectedService As String = ListBox1.SelectedItem.ToString()

		MessageBox.Show(SelectedService)


	End Sub
End Class
