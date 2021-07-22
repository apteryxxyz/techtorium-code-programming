Public Class Lab06
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'create the variable 'val1' and set it as an number 
        Dim val1 As Integer
        val1 = Val(TextBox1.Text)
        'reassign 'val1' as val1 plus 1
        val1 = val1 + 1
        'send the user the result in a message box
        MsgBox("The result is: " & val1)
    End Sub
End Class