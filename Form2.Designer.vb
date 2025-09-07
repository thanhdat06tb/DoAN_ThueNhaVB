<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skHot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skHot))
        picSuKien5 = New PictureBox()
        picSuKien2 = New PictureBox()
        picSuKien3 = New PictureBox()
        picSuKien4 = New PictureBox()
        picSuKien1 = New PictureBox()
        CType(picSuKien5, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSuKien2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSuKien3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSuKien4, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSuKien1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picSuKien5
        ' 
        picSuKien5.Location = New Point(242, 231)
        picSuKien5.Name = "picSuKien5"
        picSuKien5.Size = New Size(125, 207)
        picSuKien5.SizeMode = PictureBoxSizeMode.Zoom
        picSuKien5.TabIndex = 11
        picSuKien5.TabStop = False
        ' 
        ' picSuKien2
        ' 
        picSuKien2.Location = New Point(405, 43)
        picSuKien2.Name = "picSuKien2"
        picSuKien2.Size = New Size(383, 202)
        picSuKien2.SizeMode = PictureBoxSizeMode.Zoom
        picSuKien2.TabIndex = 10
        picSuKien2.TabStop = False
        ' 
        ' picSuKien3
        ' 
        picSuKien3.Location = New Point(12, 231)
        picSuKien3.Name = "picSuKien3"
        picSuKien3.Size = New Size(221, 207)
        picSuKien3.SizeMode = PictureBoxSizeMode.Zoom
        picSuKien3.TabIndex = 9
        picSuKien3.TabStop = False
        ' 
        ' picSuKien4
        ' 
        picSuKien4.Location = New Point(390, 268)
        picSuKien4.Name = "picSuKien4"
        picSuKien4.Size = New Size(398, 170)
        picSuKien4.SizeMode = PictureBoxSizeMode.Zoom
        picSuKien4.TabIndex = 8
        picSuKien4.TabStop = False
        ' 
        ' picSuKien1
        ' 
        picSuKien1.Location = New Point(12, 43)
        picSuKien1.Name = "picSuKien1"
        picSuKien1.Size = New Size(355, 172)
        picSuKien1.SizeMode = PictureBoxSizeMode.Zoom
        picSuKien1.TabIndex = 7
        picSuKien1.TabStop = False
        ' 
        ' skHot
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(picSuKien5)
        Controls.Add(picSuKien2)
        Controls.Add(picSuKien3)
        Controls.Add(picSuKien4)
        Controls.Add(picSuKien1)
        Name = "skHot"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Giá Nhà Hot"
        CType(picSuKien5, ComponentModel.ISupportInitialize).EndInit()
        CType(picSuKien2, ComponentModel.ISupportInitialize).EndInit()
        CType(picSuKien3, ComponentModel.ISupportInitialize).EndInit()
        CType(picSuKien4, ComponentModel.ISupportInitialize).EndInit()
        CType(picSuKien1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picSuKien5 As PictureBox
    Friend WithEvents picSuKien2 As PictureBox
    Friend WithEvents picSuKien3 As PictureBox
    Friend WithEvents picSuKien4 As PictureBox
    Friend WithEvents picSuKien1 As PictureBox

    Private Sub picSuKien1_Click(sender As Object, e As EventArgs) Handles picSuKien1.Click
        picSuKien1.Image = Image.FromFile("C:\Users\Admin\OneDrive\Pictures\sk2.jpeg")
    End Sub
End Class
