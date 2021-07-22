Public Class Lab08
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check if textbox is empty, if it is throw an error
        If (TextBox1.Text = "") Then
            MsgBox("Text box cannot be left empty!")
            TextBox1.Focus()
            Exit Sub
        End If

        'if textbox text property is not a number, throw an error
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("Text box must be a valid number!")
            TextBox1.Focus()
            Exit Sub
        End If

        'declare counter and value varibles as integer
        Dim counter As Integer
        Dim value As Integer
        value = Val(TextBox1.Text)

        'loop 10 times
        For counter = 1 To 10
            ListBox1.Items.Add(value)
            'increase value by 1
            value = value + 1
        Next
    End Sub
End Class