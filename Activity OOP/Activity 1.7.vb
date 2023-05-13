Public Class Activity1_7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Text = "Radio Button 1 clicked"
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox2.Text = "Radio Button 2 clicked"
        Else
            TextBox2.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox3.Text = "Radio Button 3 clicked"
        Else
            TextBox3.Clear()
        End If
    End Sub
End Class