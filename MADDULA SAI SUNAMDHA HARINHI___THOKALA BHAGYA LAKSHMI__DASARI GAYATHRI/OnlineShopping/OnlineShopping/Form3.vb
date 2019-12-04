Imports System.Data.SqlClient
Imports System.IO
Public Class Form3
    Dim connection As New SqlConnection("Server=.\SQLEXPRESS;Database=TestDB;Integrated Security=true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Enter Proper Details")

        ElseIf (TextBox2.Text = "") Then
            MessageBox.Show("Enter Proper Details")
        ElseIf (TextBox3.Text = "") Then
            MessageBox.Show("Enter Proper Details")
        ElseIf (TextBox4.Text = "") Then
            MessageBox.Show("Enter Proper Details")
        ElseIf (TextBox5.Text = "") Then
            MessageBox.Show("Enter Proper Details")

        Else
            MessageBox.Show("Payment done Sucessfully")
            If Form1.totalAmount <> 0 Then
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim sql As String
                    sql = "DROP TABLE TABLE_VIEWER"
                    Dim command As New SqlCommand(sql, connection)
                    command.ExecuteNonQuery()
                    sql = "CREATE TABLE TABLE_VIEWER(ID INT IDENTITY(1,1) PRIMARY KEY,NAME VARCHAR(10),DESCRIPTION VARCHAR(30),THE_IMAGE IMAGE,PRICE INT,QUANTITY INT,TotalAmount INT)"
                    Dim command2 As New SqlCommand(sql, connection)
                    command2.ExecuteNonQuery()
                    Form6.populatedatagridview("")
                End If
            End If
        Me.Hide()
        Form1.totalAmount = 0
        Form1.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class