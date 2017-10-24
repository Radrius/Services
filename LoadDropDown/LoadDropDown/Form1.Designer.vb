<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(98, 221)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Add Service"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(98, 195)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(211, 20)
		Me.TextBox1.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(2, 195)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(77, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Service Name:"
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(98, 12)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(211, 95)
		Me.ListBox1.TabIndex = 4
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(98, 113)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 43)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Start Selected"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(2, 12)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(51, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Services:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(315, 12)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(40, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Status:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(361, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Label4"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(179, 113)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 43)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Stop Selected"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(2, 172)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(95, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Remote Computer:"
		'
		'ComboBox1
		'
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"20-0003"})
		Me.ComboBox1.Location = New System.Drawing.Point(98, 169)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(211, 21)
		Me.ComboBox1.TabIndex = 11
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(511, 261)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents ComboBox1 As ComboBox
End Class
