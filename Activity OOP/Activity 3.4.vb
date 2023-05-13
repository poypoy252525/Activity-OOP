Public Class Activity3_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            TextBox2.Text = ""
            Return
        End If

        Select Case TextBox1.Text
            Case "B", "b"
                TextBox2.Text = "Battleship"
            Case "C", "c"
                TextBox2.Text = "Cruiser"
            Case "D", "d"
                TextBox2.Text = "Destroyer"
            Case "F", "f"
                TextBox2.Text = "Frigate"
            Case Else
                TextBox2.Text = "Invalid Input!"
        End Select
    End Sub
End Class