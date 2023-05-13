Public Class Activity3_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim grade As Double

        grade = Val(TextBox1.Text)

        If TextBox1.Text = "" Then
            TextBox2.Text = ""
            Return
        End If

        Select Case grade
            Case 98 To 100
                TextBox2.Text = "1.00"
            Case 95 To 97
                TextBox2.Text = "1.25"
            Case 92 To 94
                TextBox2.Text = "1.50"
            Case 89 To 91
                TextBox2.Text = "1.75"
            Case 85 To 88
                TextBox2.Text = "2.00"
            Case 82 To 84
                TextBox2.Text = "2.25"
            Case 80 To 81
                TextBox2.Text = "2.50"
            Case 77 To 79
                TextBox2.Text = "2.75"
            Case 75 To 76
                TextBox2.Text = "3.00"
            Case Else
                TextBox2.Text = "Out of range"
        End Select
    End Sub
End Class