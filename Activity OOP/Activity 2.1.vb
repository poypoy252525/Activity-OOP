Public Class Activity2_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dollar As Double
        dollar = Val(TextBox1.Text)
        TextBox2.Text = dollar * 56.47
    End Sub
End Class