Public Class Form1
    'a function to ensure that strings are not empty
    Private Function ValidateString(Box As TextBox, BoxName As String, ThrowError As Boolean) As Boolean
        'reset the colour of the box
        Box.BackColor = Color.White
        ValidateString = False
        'check that the boxes value is an empty string
        If Box.Text = "" Then
            'if the ThrowError parameter is true when begin the process of throwing the error
            If ThrowError = True Then
                'change the boxes colour so the user knows which one is invalid
                Box.BackColor = Color.LightPink
                Box.Focus()
                'throw a message box with the problem
                MsgBox(BoxName & " cannot be empty!")
            End If
            ValidateString = True
            Exit Function
        End If
    End Function

    'a function to ensure that numbers are actually numbers
    Private Function ValidateNumber(Box As TextBox, BoxName As String, ThrowError As Boolean) As Boolean
        'reset the colour of the box
        Box.BackColor = Color.White
        ValidateNumber = False
        'check that the boxes value is a valid number
        If IsNumeric(Box.Text) = False Then
            'if the ThrowError parameter is true when begin the process of throwing the error
            If ThrowError = True Then
                'change the boxes colour so the user knows which one is invalid
                Box.BackColor = Color.LightPink
                Box.Focus()
                'throw a message box with the problem
                MsgBox(BoxName & " must be a number!")
            End If
            ValidateNumber = True
            Exit Function
        End If
    End Function

    'a function to ensure that at least one of the radio buttons is selected
    Private Function ValidateRadio(Radio1 As RadioButton, Radio2 As RadioButton, Radio3 As RadioButton, SectionName As String, ThrowError As Boolean) As Boolean
        'reset the colours of the radio buttons
        Radio1.BackColor = Color.Empty
        Radio2.BackColor = Color.Empty
        Radio3.BackColor = Color.Empty
        ValidateRadio = False

        'check if no radio buttons are selected
        If Radio1.Checked = False And Radio2.Checked = False And Radio3.Checked = False Then
            'if the ThrowError parameter is true when begin the process of throwing the error
            If ThrowError = True Then
                'change the radio buttons colours so the user knows what is invalid
                Radio1.BackColor = Color.LightPink
                Radio2.BackColor = Color.LightPink
                Radio3.BackColor = Color.LightPink
                'throw a message box with the problem
                MsgBox("You must select a " & SectionName & "!")
            End If
            ValidateRadio = True
            Exit Function
        End If
    End Function

    'a function to ensure that at least one of the check buttons is selected
    Private Function ValidateCheck(Check1 As CheckBox, Check2 As CheckBox, Check3 As CheckBox, SectionName As String, ThrowError As Boolean) As Boolean
        'reset the colours of the checkboxes
        Check1.BackColor = Color.Empty
        Check2.BackColor = Color.Empty
        Check3.BackColor = Color.Empty
        ValidateCheck = False

        'check if no checkboxes are selected
        If Check1.Checked = False And Check2.Checked = False And Check3.Checked = False Then
            'if the ThrowError parameter is true when begin the process of throwing the error
            If ThrowError = True Then
                'change the checkboxes colours so the user knows what is invalid
                Check1.BackColor = Color.LightPink
                Check2.BackColor = Color.LightPink
                Check3.BackColor = Color.LightPink
                'throw a message box with the problem
                MsgBox("You must select at least one of the " & SectionName & "!")
            End If
            ValidateCheck = True
            Exit Function
        End If
    End Function

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        'validate each of the textboxes, ensure that name and email are not empty and that number Is a valid number
        If ValidateString(FullName, "Full Name", True) Then Exit Sub
        If ValidateNumber(PhoneNumber, "Content Number", True) Then Exit Sub
        If ValidateString(EmailAddress, "Email Address", True) Then Exit Sub

        'validate that at least one of the contact methods checkboxes are selected
        If ValidateCheck(EmailCB, TextCB, CallCB, "preferred contact methods", True) Then Exit Sub

        'validate that one of the course radio buttons are selected
        If ValidateRadio(Engineering, InformationSystems, SoftwareDevelopment, "course", True) Then Exit Sub

        'declare a date of birth variable and set it as the value in the date of birth date time picker
        Dim DOB As String = DateOfBirth.Value.Date

        'declare a variable used to store the selected course
        Dim selectedCourse As String
        'run though the course radio buttons, set which on is checked as the select course
        If Engineering.Checked Then
            selectedCourse = "Engineering"
        ElseIf InformationSystems.Checked Then
            selectedCourse = "Information Systems"
        Else
            selectedCourse = "Software Development"
        End If

        'declare variables for ways to contact, set default to 'No'
        Dim contactEmail As String = "No"
        Dim contactText As String = "No"
        Dim contactCall As String = "No"

        'run though each checkbox, set the contacts to 'Yes' if checked
        If EmailCB.Checked Then contactEmail = "Yes"
        If TextCB.Checked Then contactText = "Yes"
        If CallCB.Checked Then contactCall = "Yes"

        'add the inputted information to the list box
        Summary.Items.Add("===== Student Detail Summary =====")
        Summary.Items.Add("Student Name: " & FullName.Text)
        Summary.Items.Add("Date of Birth: " & DOB)
        Summary.Items.Add("------ Contact ------")
        Summary.Items.Add("Contact Number: " & PhoneNumber.Text)
        Summary.Items.Add("Email Address: " & EmailAddress.Text)
        Summary.Items.Add("Perferred Contact: ")
        Summary.Items.Add("    Email: " & contactEmail)
        Summary.Items.Add("    Text: " & contactText)
        Summary.Items.Add("    Call: " & contactCall)
        Summary.Items.Add("------ Course ------")
        Summary.Items.Add("Selected Course: " & selectedCourse)
        Summary.Items.Add("==================================")
    End Sub
End Class
