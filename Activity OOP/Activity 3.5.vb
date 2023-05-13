Public Class Activity3_5
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim richter As Double
        richter = Val(TextBox1.Text)
        If TextBox1.Text = "" Then
            TextBox2.Clear()
            Return
        End If

        If richter < 5 Then
            TextBox2.Text = "Little or no damage"
        ElseIf richter >= 5 And richter <= 5.5 Then
            TextBox2.Text = "Some damage"
        ElseIf richter >= 5.6 And richter <= 6.5 Then
            TextBox2.Text = "Serious damage"
        ElseIf richter >= 6.6 And richter <= 7.5 Then
            TextBox2.Text = "Disaster"
        ElseIf richter > 7.5 Then
            TextBox2.Text = "Catastrophe"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class