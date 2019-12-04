Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Form5.TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Enter Proper Details")

        ElseIf (TextBox2.Text = "") Then
            MessageBox.Show("Enter Proper Details")

        ElseIf RadioButton1.Checked = True Then
            Form3.Show()
            Me.Hide()
            TextBox1.Text = ""
        Else
            Form4.Show()
            Me.Hide()
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.totalAmount = 0 Then
            TextBox2.Text = Form1.TextBoxPRC.Text
        Else
            TextBox2.Text = Form1.totalAmount
        End If
    End Sub
End Class