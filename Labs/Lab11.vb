Public Class Lab11
    Private Function ValidateString(Box As TextBox, BoxName As String, ThrowError As Boolean) As String
        'reset the colour of the textbox
        Box.BackColor = Color.White

        'if textbox value is empty, then throw an error statement
        'that it must Not be so
        If (Box.Text = "") Then
            If (ThrowError = True) Then
                'set the textbox colour to light pink if error
                Box.BackColor = Color.LightPink
                Box.Focus()
                MsgBox(BoxName + " cannot be empty!")
            End If
            ValidateString = BoxName
            Exit Function
        End If

        ValidateString = ""
    End Function

    Private Function ValidateNumber(Box As TextBox, BoxName As String, ThrowError As Boolean) As String
        'reset the colour of the textbox
        Box.BackColor = Color.White

        'check that the textbox value is a number, if it Is Not,
        'throw an error stating that it must be one
        If IsNumeric(Box.Text) = False Then
            If (ThrowError = True) Then
                'set the textbox colour to light pink if error
                Box.BackColor = Color.LightPink
                Box.Focus()
                MsgBox(BoxName + " must be a number!")
            End If
            ValidateNumber = BoxName
            Exit Function
        End If

        ValidateNumber = ""
    End Function

    Private Sub Generate(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the listbox so the box doesn't become full of payslip inforamtion
        ListBox1.Items.Clear()

        'ensure that all textboxes that are expecting a string, get a string
        If (ValidateString(TextBox1, "Employee Name", True) = "") = False Then
            Exit Sub
        End If
        If (ValidateString(TextBox2, "Employee Surname", True) = "") = False Then
            Exit Sub
        End If
        If (ValidateString(TextBox3, "Employee Number", True) = "") = False Then
            Exit Sub
        End If

        'ensure that all textboxes that are expecting a number, get a number
        If (ValidateNumber(TextBox5, "Gross Salary", True) = "") = False Then
            Exit Sub
        End If
        If (ValidateNumber(TextBox6, "Taxation", True) = "") = False Then
            Exit Sub
        End If

        'get the date information from the date time pickers
        Dim payStart As String = DateTimePicker1.Value.Date
        Dim payEnd As String = DateTimePicker2.Value.Date

        'combine the employees first name and last name in a single string
        Dim employeeName As String = TextBox1.Text + " " + TextBox2.Text

        'take tax away from the gross salary, store in own variable
        Dim finalPay As String = Val(TextBox5.Text) - Val(TextBox6.Text)

        'add all the payslip information to the listbox
        ListBox1.Items.Add("============ PAYSLIP ============")
        ListBox1.Items.Add("Pay Period: " & payStart & " to " & payEnd)
        ListBox1.Items.Add("Employee's Name: " & employeeName)
        ListBox1.Items.Add("Employee's Number: " & TextBox3.Text)
        ListBox1.Items.Add("---------------------------------------")
        ListBox1.Items.Add("Gross Salary: $" & TextBox5.Text)
        ListBox1.Items.Add("Taxation: $" & TextBox6.Text)
        ListBox1.Items.Add("---------------------------------------")
        ListBox1.Items.Add("Nett Salary: $" & finalPay)
        ListBox1.Items.Add("=================================")
    End Sub
End Class