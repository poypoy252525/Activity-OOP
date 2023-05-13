Public Class Activity3_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim speed As Integer
        speed = Val(TextBox1.Text)
        If TextBox1.Text = "" Then
            TextBox2.Clear()
        ElseIf speed > 1100 Then
            TextBox2.Text = "It's a civilian aircraft!"
        ElseIf speed >= 500 And speed <= 1100 Then
            TextBox2.Text = "It's a military aircraft!"
        ElseIf speed < 500 Then
            TextBox2.Text = "It's a bird!"
        End If
    End Sub
End Class