<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckHopDong
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
        CheckHD = New DataGridView()
        btxoaHD = New Button()
        Button2 = New Button()
        CType(CheckHD, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckHD
        ' 
        CheckHD.BorderStyle = BorderStyle.None
        CheckHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CheckHD.Location = New Point(0, 0)
        CheckHD.Name = "CheckHD"
        CheckHD.RowHeadersWidth = 51
        CheckHD.Size = New Size(800, 632)
        CheckHD.TabIndex = 0
        ' 
        ' btxoaHD
        ' 
        btxoaHD.BackColor = SystemColors.Control
        btxoaHD.Location = New Point(525, 638)
        btxoaHD.Name = "btxoaHD"
        btxoaHD.Size = New Size(94, 51)
        btxoaHD.TabIndex = 1
        btxoaHD.Text = "Xoá hợp đồng"
        btxoaHD.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.Location = New Point(656, 638)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 51)
        Button2.TabIndex = 2
        Button2.Text = "Quay lại"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckHopDong
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 690)
        Controls.Add(Button2)
        Controls.Add(btxoaHD)
        Controls.Add(CheckHD)
        Name = "CheckHopDong"
        Text = "CheckHopDong"
        CType(CheckHD, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CheckHD As DataGridView
    Friend WithEvents btxoaHD As Button
    Friend WithEvents Button2 As Button
End Class
