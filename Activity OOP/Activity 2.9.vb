Public Class Activity2_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        output.Text = Val(num1.Text) / Val(num2.Text)
    End Sub
End Class