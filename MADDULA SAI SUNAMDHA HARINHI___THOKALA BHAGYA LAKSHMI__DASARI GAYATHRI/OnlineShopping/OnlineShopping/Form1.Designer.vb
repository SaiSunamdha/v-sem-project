<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDESC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxPRC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_INSERT = New System.Windows.Forms.Button()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.TextBoxSEARCH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_FIND = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Buttonview = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(179, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(248, 90)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(200, 41)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxNAME
        '
        Me.TextBoxNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNAME.Location = New System.Drawing.Point(248, 180)
        Me.TextBoxNAME.Name = "TextBoxNAME"
        Me.TextBoxNAME.Size = New System.Drawing.Size(200, 41)
        Me.TextBoxNAME.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(136, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME:"
        '
        'TextBoxDESC
        '
        Me.TextBoxDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDESC.Location = New System.Drawing.Point(248, 314)
        Me.TextBoxDESC.Multiline = True
        Me.TextBoxDESC.Name = "TextBoxDESC"
        Me.TextBoxDESC.Size = New System.Drawing.Size(200, 93)
        Me.TextBoxDESC.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(35, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESCRIPTION:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(650, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "//////////"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 446)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1396, 367)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBoxPRC
        '
        Me.TextBoxPRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPRC.Location = New System.Drawing.Point(248, 253)
        Me.TextBoxPRC.Name = "TextBoxPRC"
        Me.TextBoxPRC.Size = New System.Drawing.Size(200, 41)
        Me.TextBoxPRC.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(126, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PRICE :"
        '
        'BTN_INSERT
        '
        Me.BTN_INSERT.BackColor = System.Drawing.Color.Green
        Me.BTN_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INSERT.ForeColor = System.Drawing.Color.White
        Me.BTN_INSERT.Location = New System.Drawing.Point(970, 80)
        Me.BTN_INSERT.Name = "BTN_INSERT"
        Me.BTN_INSERT.Size = New System.Drawing.Size(170, 41)
        Me.BTN_INSERT.TabIndex = 11
        Me.BTN_INSERT.Text = "INSERT"
        Me.BTN_INSERT.UseVisualStyleBackColor = False
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackColor = System.Drawing.Color.Green
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE.Location = New System.Drawing.Point(970, 134)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(170, 41)
        Me.BTN_UPDATE.TabIndex = 12
        Me.BTN_UPDATE.Text = "UPDATE"
        Me.BTN_UPDATE.UseVisualStyleBackColor = False
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackColor = System.Drawing.Color.Green
        Me.BTN_DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.ForeColor = System.Drawing.Color.White
        Me.BTN_DELETE.Location = New System.Drawing.Point(970, 187)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(170, 47)
        Me.BTN_DELETE.TabIndex = 13
        Me.BTN_DELETE.Text = "DELETE"
        Me.BTN_DELETE.UseVisualStyleBackColor = False
        '
        'TextBoxSEARCH
        '
        Me.TextBoxSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSEARCH.Location = New System.Drawing.Point(913, 12)
        Me.TextBoxSEARCH.Name = "TextBoxSEARCH"
        Me.TextBoxSEARCH.Size = New System.Drawing.Size(267, 41)
        Me.TextBoxSEARCH.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(783, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SEARCH:"
        '
        'BTN_FIND
        '
        Me.BTN_FIND.BackColor = System.Drawing.Color.Green
        Me.BTN_FIND.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FIND.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_FIND.Location = New System.Drawing.Point(488, 94)
        Me.BTN_FIND.Name = "BTN_FIND"
        Me.BTN_FIND.Size = New System.Drawing.Size(71, 38)
        Me.BTN_FIND.TabIndex = 16
        Me.BTN_FIND.Text = "FIND "
        Me.BTN_FIND.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(970, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "BUY NOW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(600, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(970, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(970, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 39)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "ADD TO CART"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(761, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "QUANTITY"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(894, 354)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 39)
        Me.TextBox1.TabIndex = 21
        '
        'Buttonview
        '
        Me.Buttonview.BackColor = System.Drawing.Color.Green
        Me.Buttonview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonview.Location = New System.Drawing.Point(970, 406)
        Me.Buttonview.Name = "Buttonview"
        Me.Buttonview.Size = New System.Drawing.Size(170, 38)
        Me.Buttonview.TabIndex = 22
        Me.Buttonview.Text = "VIEW CART"
        Me.Buttonview.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.OnlineShopping.My.Resources.Resources.fghh__2_
        Me.ClientSize = New System.Drawing.Size(1393, 813)
        Me.Controls.Add(Me.Buttonview)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_FIND)
        Me.Controls.Add(Me.TextBoxSEARCH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_INSERT)
        Me.Controls.Add(Me.TextBoxPRC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxDESC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDESC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxPRC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_INSERT As Button
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents TextBoxSEARCH As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_FIND As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Buttonview As Button
End Class
