<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangNhap))
        btDN = New Button()
        btThoat = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTK = New TextBox()
        txtMK = New TextBox()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btDN
        ' 
        btDN.BackColor = SystemColors.ControlLight
        btDN.Location = New Point(273, 279)
        btDN.Name = "btDN"
        btDN.Size = New Size(94, 29)
        btDN.TabIndex = 0
        btDN.Text = "Đăng nhập"
        btDN.UseVisualStyleBackColor = False
        ' 
        ' btThoat
        ' 
        btThoat.BackColor = SystemColors.ControlLight
        btThoat.Location = New Point(393, 279)
        btThoat.Name = "btThoat"
        btThoat.Size = New Size(94, 29)
        btThoat.TabIndex = 1
        btThoat.Text = "Thoát"
        btThoat.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(232, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 38)
        Label1.TabIndex = 3
        Label1.Text = "THUENHA.NET"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(288, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 4
        Label2.Text = "ĐĂNG NHẬP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Menu
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(160, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 19)
        Label3.TabIndex = 5
        Label3.Text = "Tài Khoản:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Menu
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(160, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 19)
        Label4.TabIndex = 6
        Label4.Text = "Mật Khẩu:"
        ' 
        ' txtTK
        ' 
        txtTK.Location = New Point(273, 167)
        txtTK.Name = "txtTK"
        txtTK.Size = New Size(228, 27)
        txtTK.TabIndex = 7
        ' 
        ' txtMK
        ' 
        txtMK.Location = New Point(273, 225)
        txtMK.Name = "txtMK"
        txtMK.Size = New Size(228, 27)
        txtMK.TabIndex = 8
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BorderStyle = BorderStyle.Fixed3D
        LinkLabel1.DisabledLinkColor = Color.White
        LinkLabel1.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = Color.Black
        LinkLabel1.LinkColor = SystemColors.Highlight
        LinkLabel1.Location = New Point(297, 326)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(164, 22)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Bạn chưa có tài khoản?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Cursor = Cursors.IBeam
        PictureBox1.Location = New Point(0, -12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 136)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' DangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(750, 398)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(txtMK)
        Controls.Add(txtTK)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btThoat)
        Controls.Add(btDN)
        Cursor = Cursors.Hand
        ForeColor = SystemColors.InactiveCaptionText
        Name = "DangNhap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btDN As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTK As TextBox
    Friend WithEvents txtMK As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox

End Class
