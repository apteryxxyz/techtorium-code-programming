Public Class Lab09
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the list and start a new order
        ListBox1.Items.Clear()
        ListBox1.Items.Add("-=-= Food Order =-=-")

        'for each checkbox, check if checked, if it is then add the food to the list
        If (CheckBox1.Checked) Then
            ListBox1.Items.Add("Pizza")
        End If
        If (CheckBox2.Checked) Then
            ListBox1.Items.Add("Hamburger")
        End If
        If (CheckBox3.Checked) Then
            ListBox1.Items.Add("Chicken Burger")
        End If

        'if chips is checked, check if tomato sauce is selected, if it is add sauce else chips only 
        If (CheckBox4.Checked) Then
            If (CheckBox5.Checked) Then
                ListBox1.Items.Add("Chips with tomato sauce")
            Else
                ListBox1.Items.Add("Chips only, no tomato sauce")
            End If
        End If

        'start the drinks order
        ListBox1.Items.Add("-=-= Drinks Order =-=-")
        'if all radio buttons are unchecked then say no drinks, else add the drink of the selected radio button
        If (RadioButton1.Checked = False) And (RadioButton2.Checked = False) And (RadioButton3.Checked = False) Then
            ListBox1.Items.Add("No Drinks")
        Else
            If (RadioButton1.Checked) Then
                ListBox1.Items.Add("Coke")
            End If

            If (RadioButton2.Checked) Then
                ListBox1.Items.Add("L&P")
            End If

            If (RadioButton3.Checked) Then
                ListBox1.Items.Add("Milkshake")
            End If
        End If

    End Sub
End Class