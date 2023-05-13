Public Class Activity2_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        output.Text = Math.Sqrt(2 * Val(req.Text) * Val(suc.Text) / Val(inv.Text)).ToString("F3")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class