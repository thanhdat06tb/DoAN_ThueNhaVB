<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSKchinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSKchinh))
        butSKHot = New Button()
        butSKgt = New Button()
        SuspendLayout()
        ' 
        ' butSKHot
        ' 
        butSKHot.Location = New Point(22, 8)
        butSKHot.Name = "butSKHot"
        butSKHot.Size = New Size(94, 29)
        butSKHot.TabIndex = 4
        butSKHot.Text = "Hot"
        butSKHot.UseVisualStyleBackColor = True
        ' 
        ' butSKgt
        ' 
        butSKgt.Location = New Point(139, 8)
        butSKgt.Name = "butSKgt"
        butSKgt.Size = New Size(94, 29)
        butSKgt.TabIndex = 5
        butSKgt.Text = "Giá tốt"
        butSKgt.UseVisualStyleBackColor = True
        ' 
        ' frmSKchinh
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1341, 770)
        Controls.Add(butSKgt)
        Controls.Add(butSKHot)
        Name = "frmSKchinh"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sự kiện"
        ResumeLayout(False)
    End Sub
    Friend WithEvents butSKHot As Button
    Friend WithEvents butSKgt As Button
End Class
