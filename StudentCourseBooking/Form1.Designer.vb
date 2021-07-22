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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.PhoneNumber = New System.Windows.Forms.TextBox()
        Me.EmailAddress = New System.Windows.Forms.TextBox()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Engineering = New System.Windows.Forms.RadioButton()
        Me.InformationSystems = New System.Windows.Forms.RadioButton()
        Me.SoftwareDevelopment = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailCB = New System.Windows.Forms.CheckBox()
        Me.TextCB = New System.Windows.Forms.CheckBox()
        Me.CallCB = New System.Windows.Forms.CheckBox()
        Me.Summary = New System.Windows.Forms.ListBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Course Booking"
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(222, 74)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(200, 22)
        Me.FullName.TabIndex = 1
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Location = New System.Drawing.Point(222, 147)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.PhoneNumber.TabIndex = 2
        '
        'EmailAddress
        '
        Me.EmailAddress.Location = New System.Drawing.Point(222, 185)
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Size = New System.Drawing.Size(200, 22)
        Me.EmailAddress.TabIndex = 3
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Location = New System.Drawing.Point(222, 108)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(200, 22)
        Me.DateOfBirth.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contact Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Course"
        '
        'Engineering
        '
        Me.Engineering.AutoSize = True
        Me.Engineering.Location = New System.Drawing.Point(222, 284)
        Me.Engineering.Name = "Engineering"
        Me.Engineering.Size = New System.Drawing.Size(105, 21)
        Me.Engineering.TabIndex = 10
        Me.Engineering.TabStop = True
        Me.Engineering.Text = "Engineering"
        Me.Engineering.UseVisualStyleBackColor = True
        '
        'InformationSystems
        '
        Me.InformationSystems.AutoSize = True
        Me.InformationSystems.Location = New System.Drawing.Point(222, 313)
        Me.InformationSystems.Name = "InformationSystems"
        Me.InformationSystems.Size = New System.Drawing.Size(160, 21)
        Me.InformationSystems.TabIndex = 11
        Me.InformationSystems.TabStop = True
        Me.InformationSystems.Text = "Information Systems "
        Me.InformationSystems.UseVisualStyleBackColor = True
        '
        'SoftwareDevelopment
        '
        Me.SoftwareDevelopment.AutoSize = True
        Me.SoftwareDevelopment.Location = New System.Drawing.Point(222, 340)
        Me.SoftwareDevelopment.Name = "SoftwareDevelopment"
        Me.SoftwareDevelopment.Size = New System.Drawing.Size(175, 21)
        Me.SoftwareDevelopment.TabIndex = 12
        Me.SoftwareDevelopment.TabStop = True
        Me.SoftwareDevelopment.Text = "Software Development "
        Me.SoftwareDevelopment.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Preferenced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Content"
        '
        'EmailCB
        '
        Me.EmailCB.AutoSize = True
        Me.EmailCB.Location = New System.Drawing.Point(222, 228)
        Me.EmailCB.Name = "EmailCB"
        Me.EmailCB.Size = New System.Drawing.Size(64, 21)
        Me.EmailCB.TabIndex = 14
        Me.EmailCB.Text = "Email"
        Me.EmailCB.UseVisualStyleBackColor = True
        '
        'TextCB
        '
        Me.TextCB.AutoSize = True
        Me.TextCB.Location = New System.Drawing.Point(292, 228)
        Me.TextCB.Name = "TextCB"
        Me.TextCB.Size = New System.Drawing.Size(57, 21)
        Me.TextCB.TabIndex = 15
        Me.TextCB.Text = "Text"
        Me.TextCB.UseVisualStyleBackColor = True
        '
        'CallCB
        '
        Me.CallCB.AutoSize = True
        Me.CallCB.Location = New System.Drawing.Point(369, 228)
        Me.CallCB.Name = "CallCB"
        Me.CallCB.Size = New System.Drawing.Size(53, 21)
        Me.CallCB.TabIndex = 16
        Me.CallCB.Text = "Call"
        Me.CallCB.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.Summary.FormattingEnabled = True
        Me.Summary.ItemHeight = 16
        Me.Summary.Location = New System.Drawing.Point(465, 106)
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(283, 324)
        Me.Summary.TabIndex = 17
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(150, 383)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(149, 47)
        Me.Submit.TabIndex = 18
        Me.Submit.Text = "Student Detail Summary"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(529, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Student Detail Summary"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 463)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Summary)
        Me.Controls.Add(Me.CallCB)
        Me.Controls.Add(Me.TextCB)
        Me.Controls.Add(Me.EmailCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SoftwareDevelopment)
        Me.Controls.Add(Me.InformationSystems)
        Me.Controls.Add(Me.Engineering)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.EmailAddress)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Student Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FullName As TextBox
    Friend WithEvents PhoneNumber As TextBox
    Friend WithEvents EmailAddress As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Engineering As RadioButton
    Friend WithEvents InformationSystems As RadioButton
    Friend WithEvents SoftwareDevelopment As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents EmailCB As CheckBox
    Friend WithEvents TextCB As CheckBox
    Friend WithEvents CallCB As CheckBox
    Friend WithEvents Summary As ListBox
    Friend WithEvents Submit As Button
    Friend WithEvents Label8 As Label
End Class
