Public Class Lab07
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declare 3 variables as number for later use
        Dim val1 As Integer
        Dim val2 As Integer
        Dim val3 As Integer
        'grab the values from the first two textboxes and add them
        val1 = Val(TextBox1.Text)
        val2 = Val(TextBox3.Text)
        val3 = val1 + val2
        'set TextBox3 text property to the sum of the first two
        TextBox2.Text = val3
    End Sub
End Class