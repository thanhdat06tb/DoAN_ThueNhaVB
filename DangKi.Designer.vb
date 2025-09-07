<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangKi))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btDKTK = New Button()
        btExit = New Button()
        txtDKTK = New TextBox()
        txtDKMK = New TextBox()
        txtXTMK = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(209, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 38)
        Label1.TabIndex = 0
        Label1.Text = "THUENHA.NET"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(280, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 25)
        Label2.TabIndex = 1
        Label2.Text = "ĐĂNG KÍ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.MenuBar
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(50, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 19)
        Label3.TabIndex = 2
        Label3.Text = "Tài Khoản:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.MenuBar
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(50, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 19)
        Label4.TabIndex = 3
        Label4.Text = "Mật Khẩu:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.MenuBar
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(50, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 19)
        Label5.TabIndex = 4
        Label5.Text = "Xác Nhận Mật Khẩu:"
        ' 
        ' btDKTK
        ' 
        btDKTK.BackColor = Color.WhiteSmoke
        btDKTK.Location = New Point(241, 309)
        btDKTK.Name = "btDKTK"
        btDKTK.Size = New Size(94, 44)
        btDKTK.TabIndex = 5
        btDKTK.Text = "Đăng Kí"
        btDKTK.UseVisualStyleBackColor = False
        ' 
        ' btExit
        ' 
        btExit.BackColor = Color.WhiteSmoke
        btExit.Location = New Point(362, 309)
        btExit.Name = "btExit"
        btExit.Size = New Size(94, 44)
        btExit.TabIndex = 6
        btExit.Text = "Quay Lại"
        btExit.UseVisualStyleBackColor = False
        ' 
        ' txtDKTK
        ' 
        txtDKTK.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDKTK.Location = New Point(226, 136)
        txtDKTK.Name = "txtDKTK"
        txtDKTK.Size = New Size(252, 27)
        txtDKTK.TabIndex = 7
        ' 
        ' txtDKMK
        ' 
        txtDKMK.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDKMK.Location = New Point(226, 196)
        txtDKMK.Name = "txtDKMK"
        txtDKMK.Size = New Size(252, 27)
        txtDKMK.TabIndex = 8
        ' 
        ' txtXTMK
        ' 
        txtXTMK.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtXTMK.Location = New Point(226, 251)
        txtXTMK.Name = "txtXTMK"
        txtXTMK.Size = New Size(252, 27)
        txtXTMK.TabIndex = 9
        ' 
        ' DangKi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(651, 365)
        Controls.Add(txtXTMK)
        Controls.Add(txtDKMK)
        Controls.Add(txtDKTK)
        Controls.Add(btExit)
        Controls.Add(btDKTK)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Cursor = Cursors.Hand
        Name = "DangKi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btDKTK As Button
    Friend WithEvents btExit As Button
    Friend WithEvents txtDKTK As TextBox
    Friend WithEvents txtDKMK As TextBox
    Friend WithEvents txtXTMK As TextBox
End Class
