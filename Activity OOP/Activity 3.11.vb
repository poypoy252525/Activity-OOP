Public Class Activity3_11

    Dim bill As Integer

    Private Sub uncheckAllCheckbox()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        uncheckAllCheckbox()
        If RadioButton1.Checked Then
            bill = 12000
            CheckBox1.Checked = True
            CheckBox3.Checked = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        uncheckAllCheckbox()
        If RadioButton2.Checked Then
            bill = 1000
            CheckBox3.Checked = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            bill = 700
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim noExam As Integer
        noExam = Val(TextBox1.Text)
        TextBox2.Text = noExam * bill
    End Sub
End Class