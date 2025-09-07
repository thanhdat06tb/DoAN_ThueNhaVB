<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formChiTietNha1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formChiTietNha1))
        picNha1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Label6 = New Label()
        btQuayLaip1 = New Button()
        CType(picNha1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picNha1
        ' 
        picNha1.BackgroundImage = CType(resources.GetObject("picNha1.BackgroundImage"), Image)
        picNha1.BackgroundImageLayout = ImageLayout.Stretch
        picNha1.Location = New Point(12, 44)
        picNha1.Name = "picNha1"
        picNha1.Size = New Size(285, 395)
        picNha1.TabIndex = 0
        picNha1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(303, 44)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(309, 162)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(618, 44)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(313, 162)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(524, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 23)
        Label1.TabIndex = 3
        Label1.Text = "Căn hộ chung cư cao cấp :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F)
        Label2.Location = New Point(359, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 19)
        Label2.TabIndex = 4
        Label2.Text = "Diện tích :   100m2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.2F)
        Label3.Location = New Point(359, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 19)
        Label3.TabIndex = 5
        Label3.Text = "Địa chỉ:   Diêm Tỉnh, Thái Thụy, Thái Bình"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 10.2F)
        Label4.Location = New Point(359, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(364, 19)
        Label4.TabIndex = 6
        Label4.Text = "Ghi chú: Căn hộ sạch sẽ,Thoáng mát, Tiện ích đầy đủ"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10.2F)
        Label5.Location = New Point(359, 377)
        Label5.Name = "Label5"
        Label5.Size = New Size(253, 19)
        Label5.TabIndex = 7
        Label5.Text = "Giá thuê: 9,000,000 ( 9 triệu đồng )"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(851, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 51)
        Button1.TabIndex = 8
        Button1.Text = "Thuê"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(499, 405)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(112, 25)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "0369038160"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 10.2F)
        Label6.Location = New Point(359, 410)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 19)
        Label6.TabIndex = 10
        Label6.Text = "Liên hệ SĐT hỗ trợ:"
        ' 
        ' btQuayLaip1
        ' 
        btQuayLaip1.Location = New Point(3, 4)
        btQuayLaip1.Name = "btQuayLaip1"
        btQuayLaip1.Size = New Size(94, 29)
        btQuayLaip1.TabIndex = 11
        btQuayLaip1.Text = "Quay lại"
        btQuayLaip1.UseVisualStyleBackColor = True
        ' 
        ' formChiTietNha1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(958, 473)
        Controls.Add(btQuayLaip1)
        Controls.Add(Label6)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(picNha1)
        Name = "formChiTietNha1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formChiTietNha1"
        CType(picNha1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picNha1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents btQuayLaip1 As Button

    Private Sub btQuayLaip1_Click(sender As Object, e As EventArgs) Handles btQuayLaip1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Bạn muốn thuê căn hộ này chứ?")
        HopDongthuenha.ShowDialog()
    End Sub
End Class
