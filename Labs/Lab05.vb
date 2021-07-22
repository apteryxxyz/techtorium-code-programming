Public Class Lab05
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'when the button is, check that the textbox is not empty
        If (TextBox1.Text = "") Then
            'tell the user they must include their name
            MsgBox("The 'First Name' textbox cannot be empty! Ensure you have included your name.")
        Else
            'if name is included, add to list box
            ListBox1.Items.Add("First Name: " + TextBox1.Text)
        End If
    End Sub
End Class