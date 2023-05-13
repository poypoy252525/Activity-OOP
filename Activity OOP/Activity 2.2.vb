Public Class Activity2_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim f As Double

        f = Val(TextBox1.Text)
        TextBox2.Text = ((f - 32) * 5 / 9).ToString("F3")
    End Sub
End Class