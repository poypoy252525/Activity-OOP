Public Class Activity3_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox2.Clear()
        ElseIf TextBox1.Text = "A" Or TextBox1.Text = "a" Or TextBox1.Text = "E" Or TextBox1.Text = "e" Or TextBox1.Text = "I" Or TextBox1.Text = "i" Or TextBox1.Text = "O" Or TextBox1.Text = "o" Or TextBox1.Text = "U" Or TextBox1.Text = "u" Then
            TextBox2.Text = "It's a Vowel!"
        Else
            TextBox2.Text = "It's a Consonant"
        End If
    End Sub
End Class