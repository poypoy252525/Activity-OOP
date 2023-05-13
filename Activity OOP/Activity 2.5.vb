Public Class Activity2_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p, s, y As Double
        p = Val(price.Text)
        s = Val(service.Text)
        y = Val(yd.Text)
        TextBox4.Text = ((p - s) / y).ToString("F2")
    End Sub
End Class