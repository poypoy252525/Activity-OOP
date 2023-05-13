Public Class Activity3_7

    Dim n1, n2 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged
        n1 = Val(num1.Text)
    End Sub

    Private Sub num2_TextChanged(sender As Object, e As EventArgs) Handles num2.TextChanged
        n2 = Val(num2.Text)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ans.Text = n1 + n2
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ans.Text = n1 - n2
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ans.Text = n1 * n2
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            ans.Text = n1 / n2
        End If
    End Sub

    Private Sub Activity3_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = 0
        n2 = 0
        num1.Text = n1
        num2.Text = n2

    End Sub

End Class