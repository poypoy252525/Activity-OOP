Public Class Activity2_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim volume, r As Double
        r = Val(TextBox1.Text)
        volume = 4 / 3 * Math.PI * (r * r * r)
        TextBox2.Text = volume.ToString("F4")
    End Sub
End Class