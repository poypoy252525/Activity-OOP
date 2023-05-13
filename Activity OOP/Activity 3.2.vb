Public Class Activity3_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim tem As Double
        tem = Val(TextBox1.Text)
        If TextBox1.Text = "" Then
            TextBox2.Clear()
        ElseIf tem < 0 Then
            TextBox2.Text = "Ice"
        ElseIf tem >= 0 And tem <= 100 Then
            TextBox2.Text = "Water"
        Else
            TextBox2.Text = "Steam"
        End If
    End Sub
End Class