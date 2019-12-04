Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Button3_Click(sender, e)
        Form1.Show()
        Me.Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Enter Proper Details")
        ElseIf (TextBox2.Text = "") Then
            MessageBox.Show("Enter Proper Details")
        Else
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            Form2.Show()
        End If
    End Sub

End Class