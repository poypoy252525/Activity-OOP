Public Class Activity3_9

    Private Sub ClearAllCheckbox()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ClearAllCheckbox()
        If RadioButton1.Checked Then
            CheckBox1.Checked = True
            CheckBox5.Checked = True
            TextBox1.Text = "P1,500"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ClearAllCheckbox()
        If RadioButton2.Checked Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            TextBox1.Text = "P1,700"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            TextBox1.Text = "P2,000"
        End If
    End Sub
End Class