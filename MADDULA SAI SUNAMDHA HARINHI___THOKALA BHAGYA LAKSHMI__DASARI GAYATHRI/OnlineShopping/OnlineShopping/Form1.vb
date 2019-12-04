Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Form1
    Dim connection As New SqlConnection("Server=.\SQLEXPRESS;Database=TestDB;Integrated Security=true")
    Public totalAmount As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*.PNG;.*.GIF)|*.jpg;*.png;*.gif"
        Try
            If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(opf.FileName)
            End If
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Catch f As Exception
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalAmount = 0
        Dim command As New SqlCommand("select * from table_img", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 150
        DataGridView1.DataSource = table
        Dim imgc As New DataGridViewImageColumn
        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(3).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxNAME.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxDESC.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxPRC.Text = DataGridView1.CurrentRow.Cells(4).Value
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
    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Try
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img() As Byte
            img = ms.ToArray()
            Dim insertquery As String = "INSERT INTO table_img(name,description,the_image,price)VALUES('" & TextBoxNAME.Text & "','" & TextBoxDESC.Text & "',@img,'" & TextBoxPRC.Text & "')"
            Dim command As New SqlCommand(insertquery, connection)
            command.Parameters.Add("@img", SqlDbType.Image).Value = img
            ExecuteMyquery(command, "Image Inserted")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img() As Byte
            img = ms.ToArray()
            Dim updatequery As String = "UPDATE table_img SET name ='" & TextBoxNAME.Text & "',description ='" & TextBoxDESC.Text & "' ,the_image=@img,price='" & TextBoxPRC.Text & "' WHERE id=" & TextBoxID.Text
            Dim command As New SqlCommand(updatequery, connection)
            command.Parameters.Add("@img", SqlDbType.Image).Value = img
            ExecuteMyquery(command, "Image Updated")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            Dim deletequery As String = "DELETE FROM table_img  WHERE id=" & TextBoxID.Text
            Dim command As New SqlCommand(deletequery, connection)
            ExecuteMyquery(command, "Image Deleted")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub populatedatagridview(valueToSearch As String)
        Dim selectquery As String = "SELECT * FROM table_img WHERE CONCAT (id,name,description,price) like '%" & valueToSearch & "%' "
        Dim command As New SqlCommand(selectquery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 150
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
    Private Sub TextBoxSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSEARCH.TextChanged
        populatedatagridview(TextBoxSEARCH.Text)
    End Sub
    Private Sub BTN_FIND_Click(sender As Object, e As EventArgs) Handles BTN_FIND.Click
        Dim command As New SqlCommand("SELECT * FROM table_img WHERE id = @id", connection)
        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If (table.Rows.Count <= 0) Then
            MessageBox.Show("no data found")
        Else
            TextBoxID.Text = table.Rows(0)(0).ToString()
            TextBoxNAME.Text = table.Rows(0)(1).ToString()
            TextBoxDESC.Text = table.Rows(0)(2).ToString()
            TextBoxPRC.Text = table.Rows(0)(4).ToString()
            Dim img() As Byte
            img = table.Rows(0)(3)
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If totalAmount = 0 Then
            Form2.TextBox2.Text = Val(TextBoxPRC.Text)
        Else
            Form2.TextBox2.Text = totalAmount
        End If
        Form5.Show()
        Me.Hide()
        Form6.Hide()
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxNAME.Text = ""
        TextBoxDESC.Text = ""
        TextBoxID.Text = ""
        TextBoxPRC.Text = ""
        TextBoxSEARCH.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            totalAmount = totalAmount + Val(TextBox1.Text) * Val(TextBoxPRC.Text)
            Try
                Dim ms As New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim img() As Byte
                img = ms.ToArray()
                Dim insertquery As String = "INSERT INTO table_viewer(name,description,the_image,price,quantity,totalamount)VALUES('" & TextBoxNAME.Text & "','" & TextBoxDESC.Text & "',@img,'" & TextBoxPRC.Text & "','" & TextBox1.Text & "','" & Val(Val(TextBox1.Text) * Val(TextBoxPRC.Text)) & "')"
                Dim command As New SqlCommand(insertquery, connection)
                command.Parameters.Add("@img", SqlDbType.Image).Value = img
                ExecuteMyquery(command, "Image Inserted")
            Catch ex As Exception
            End Try
            TextBox1.Text = ""
        Else
            MsgBox("Enter quantity")
        End If
    End Sub
    Private Sub Buttonview_Click(sender As Object, e As EventArgs) Handles Buttonview.Click
        Form6.populatedatagridview("")
        Form6.Show()
        Me.Hide()
    End Sub
End Class
