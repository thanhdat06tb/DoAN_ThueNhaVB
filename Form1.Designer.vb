<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skGiaTot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skGiaTot))
        picGT3 = New PictureBox()
        picGT1 = New PictureBox()
        picGT2 = New PictureBox()
        picGT4 = New PictureBox()
        picGT6 = New PictureBox()
        picGT5 = New PictureBox()
        CType(picGT3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGT1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGT2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGT4, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGT6, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGT5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picGT3
        ' 
        picGT3.Location = New Point(12, 260)
        picGT3.Name = "picGT3"
        picGT3.Size = New Size(164, 178)
        picGT3.SizeMode = PictureBoxSizeMode.StretchImage
        picGT3.TabIndex = 0
        picGT3.TabStop = False
        ' 
        ' picGT1
        ' 
        picGT1.Location = New Point(12, 49)
        picGT1.Name = "picGT1"
        picGT1.Size = New Size(264, 187)
        picGT1.SizeMode = PictureBoxSizeMode.StretchImage
        picGT1.TabIndex = 1
        picGT1.TabStop = False
        ' 
        ' picGT2
        ' 
        picGT2.Location = New Point(305, 49)
        picGT2.Name = "picGT2"
        picGT2.Size = New Size(189, 187)
        picGT2.SizeMode = PictureBoxSizeMode.StretchImage
        picGT2.TabIndex = 2
        picGT2.TabStop = False
        ' 
        ' picGT4
        ' 
        picGT4.Location = New Point(213, 260)
        picGT4.Name = "picGT4"
        picGT4.Size = New Size(208, 178)
        picGT4.SizeMode = PictureBoxSizeMode.StretchImage
        picGT4.TabIndex = 3
        picGT4.TabStop = False
        ' 
        ' picGT6
        ' 
        picGT6.Location = New Point(473, 260)
        picGT6.Name = "picGT6"
        picGT6.Size = New Size(291, 178)
        picGT6.SizeMode = PictureBoxSizeMode.StretchImage
        picGT6.TabIndex = 4
        picGT6.TabStop = False
        ' 
        ' picGT5
        ' 
        picGT5.Location = New Point(527, 49)
        picGT5.Name = "picGT5"
        picGT5.Size = New Size(237, 187)
        picGT5.SizeMode = PictureBoxSizeMode.StretchImage
        picGT5.TabIndex = 5
        picGT5.TabStop = False
        ' 
        ' skGiaTot
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(picGT5)
        Controls.Add(picGT6)
        Controls.Add(picGT4)
        Controls.Add(picGT2)
        Controls.Add(picGT1)
        Controls.Add(picGT3)
        Name = "skGiaTot"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Thuê NHà Giá Tốt"
        CType(picGT3, ComponentModel.ISupportInitialize).EndInit()
        CType(picGT1, ComponentModel.ISupportInitialize).EndInit()
        CType(picGT2, ComponentModel.ISupportInitialize).EndInit()
        CType(picGT4, ComponentModel.ISupportInitialize).EndInit()
        CType(picGT6, ComponentModel.ISupportInitialize).EndInit()
        CType(picGT5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picGT3 As PictureBox
    Friend WithEvents picGT1 As PictureBox
    Friend WithEvents picGT2 As PictureBox
    Friend WithEvents picGT4 As PictureBox
    Friend WithEvents picGT6 As PictureBox
    Friend WithEvents picGT5 As PictureBox
End Class
