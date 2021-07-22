Public Class Lab04
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        'add the information in the text boxes (and date time picker) to the listbox
        ListBox1.Items.Add("Basic Information:")
        ListBox1.Items.Add("First Name: " + TextBox1.Text)
        ListBox1.Items.Add("Last Name: " + TextBox2.Text)
        ListBox1.Items.Add("Email: " + TextBox3.Text)
        ListBox1.Items.Add("Mobile: " + TextBox4.Text)
        ListBox1.Items.Add("DOB: " + DateTimePicker1.Value.Date)
        ListBox1.Items.Add("Address: " + TextBox5.Text)
        ListBox1.Items.Add("Information Added")
    End Sub
End Class