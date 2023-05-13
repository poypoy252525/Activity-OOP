Public Class Activity3_8

    Private Sub Activity3_8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num1.Text = 0
        num2.Text = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ans.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ans.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ans.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ans.Text = Val(num1.Text) / Val(num2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class