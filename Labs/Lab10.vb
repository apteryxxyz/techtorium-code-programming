Public Class Lab10
    Private Function IsValidOnSubmit() As Boolean
        IsValidOnSubmit = False
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White

        If (TextBox1.Text = "") Then
            TextBox1.BackColor = Color.LightPink
            MsgBox("Number 1 must not be empty!")
            TextBox1.Focus()
            Exit Function
        End If

        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.BackColor = Color.LightPink
            MsgBox("Number 1 must be a valid number!")
            TextBox1.Focus()
            Exit Function
        End If

        If (TextBox2.Text = "") Then
            TextBox2.BackColor = Color.LightPink
            MsgBox("Number 2 must not be empty!")
            TextBox2.Focus()
            Exit Function
        End If

        If IsNumeric(TextBox1.Text) = False Then
            TextBox2.BackColor = Color.LightPink
            MsgBox("Number 2 must be a number!")
            TextBox2.Focus()
            Exit Function
        End If

        IsValidOnSubmit = True
    End Function

    Private Function IsValidOnChange(Box As TextBox) As Boolean
        IsValidOnChange = False

        If (Box.Text = "") Then
            Box.BackColor = Color.LightPink
            Exit Function
        End If

        If IsNumeric(Box.Text) = False Then
            Box.BackColor = Color.LightPink
            Exit Function
        End If

        Box.BackColor = Color.White
        IsValidOnChange = True
    End Function

    'plus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsValidOnSubmit() Then
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        End If
    End Sub

    'minus
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsValidOnSubmit() Then
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
    End Sub

    'multiple
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsValidOnSubmit() Then
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        End If
    End Sub

    'divide
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text = "0") Then
            TextBox1.BackColor = Color.LightPink
            MsgBox("Number 1 cannot be zero when dividing!")
            TextBox1.Focus()
            Exit Sub
        End If

        If (TextBox2.Text = "0") Then
            TextBox2.BackColor = Color.LightPink
            MsgBox("Number 2 cannot be zero when dividing!")
            TextBox2.Focus()
            Exit Sub
        End If

        If IsValidOnSubmit() Then
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        IsValidOnChange(TextBox1)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        IsValidOnChange(TextBox2)
    End Sub
End Class