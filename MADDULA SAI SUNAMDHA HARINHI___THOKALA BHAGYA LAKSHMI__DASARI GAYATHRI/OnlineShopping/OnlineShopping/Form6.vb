Imports System.Data.SqlClient
Imports System.IO
Public Class Form6
    Dim connection As New SqlConnection("Server=.\SQLEXPRESS;Database=TestDB;Integrated Security=true")
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("select * from table_viewer", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = table
        Dim imgc As New DataGridViewImageColumn
        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Public Sub ExecuteMyquery(MyCommand As SqlCommand, MyMessage As String)
        connection.Open()
        If (MyCommand.ExecuteNonQuery = 1) Then
            MessageBox.Show(MyMessage)
        Else
            MessageBox.Show("query not executed")
        End If
        connection.Close()
        populatedatagridview("")
    End Sub
    Public Sub populatedatagridview(valueToSearch As String)
        Dim selectquery As String = "SELECT * FROM table_viewer WHERE CONCAT (id,name,description,price,quantity,totalamount) like '%" & valueToSearch & "%' "
        Dim command As New SqlCommand(selectquery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Form1.totalAmount <> 0 Then
                Form1.totalAmount = Form1.totalAmount - Val(TextBoxta.Text)
            End If
            Dim deletequery As String = "DELETE FROM table_viewer  WHERE id=" & TextBoxID.Text
            Dim command As New SqlCommand(deletequery, connection)
            ExecuteMyquery(command, "Image Deleted")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxprci.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBoxQty.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBoxta.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Form1.totalAmount = Form1.totalAmount - Val(TextBoxta.Text)
            Dim updatequery As String = "UPDATE table_viewer SET quantity ='" & TextBoxQty.Text & "',totalamount ='" & Val(Val(TextBoxQty.Text) * Val(TextBoxprci.Text)) & "' WHERE id=" & TextBoxID.Text
            Dim command As New SqlCommand(updatequery, connection)
            Form1.totalAmount = Form1.totalAmount + Val(Val(TextBoxQty.Text) * Val(TextBoxprci.Text))
            ExecuteMyquery(command, "Image Updated")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Button2_Click(sender, e)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        TextBoxID.Text = ""
        TextBoxprci.Text = ""
        TextBoxQty.Text = ""
        TextBoxta.Text = ""
        Form1.Show()
    End Sub
End Class