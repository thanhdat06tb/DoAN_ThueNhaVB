Imports System.Data.SqlClient
Imports System.Diagnostics
Public Class TrangChu
    Dim connectionString As String = "Data Source=BUITHANHDAT88\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim DANGNHAP As New DangNhap
        DANGNHAP.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Hide()
        Dim DANGKI As New DangKi
        DANGKI.ShowDialog()
    End Sub
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Dim xacNhan = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo)
        If xacNhan = DialogResult.Yes Then

            Me.Close()
            DangNhap.Show()
            DangNhap.txtTK.Clear()
            DangNhap.txtMK.Clear()
            DangNhap.txtTK.Focus()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        For Each frm As Form In Application.OpenForms.OfType(Of Form)().ToList()
            If frm IsNot Me Then
                frm.Close()
            End If
        Next
        Dim fTrangChu As New TrangChu()
        fTrangChu.Show()
    End Sub



    Private Sub FormSuKien_Load(sender As Object, e As EventArgs) Handles btSuKien.Click
        Me.Hide()
        Dim frm As New frmSKchinh()
        AddHandler frm.FormClosed, AddressOf FormSuKien_Dong
        frm.Show()
    End Sub

    Private Sub FormSuKien_Dong(sender As Object, e As FormClosedEventArgs)
        Me.Show()
    End Sub




    Private Sub DanhSáchMôiGiớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchMôiGiớiToolStripMenuItem.Click

        frmMG.Show()
        Dim truyvan As String = "SELECT * FROM MoiGioi1"
        Dim sqlketnoi As New SqlConnection(connectionString)
        Dim adapter As New SqlDataAdapter(truyvan, sqlketnoi)
        Dim table As New DataTable()

        Try
            sqlketnoi.Open()
            adapter.Fill(table)
            frmMG.dataMT.Visible = True
            frmMG.dataMT.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            sqlketnoi.Close()
        End Try
    End Sub



    Private Sub ĐangTriểnKhaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐangTriểnKhaiToolStripMenuItem.Click
        Me.Hide()
        Dim frmda1 As New frmDuAn()
        AddHandler frmda1.FormClosed, AddressOf FormSuKien_Dong
        frmda1.Show()

    End Sub

    Private Sub ĐangBảoDưỡngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐangBảoDưỡngToolStripMenuItem.Click
        Me.Hide()
        Dim frmda2 As New duan2()
        AddHandler frmda2.FormClosed, AddressOf FormSuKien_Dong
        frmda2.Show()
    End Sub

    Private Sub MuaBánToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuaBánToolStripMenuItem.Click
        HopDongthuenha.Show()
    End Sub

    Private Sub TấtCảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TấtCảToolStripMenuItem.Click
        thongtinnha.ShowDialog()
    End Sub


    Private Sub KiểuNhàToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KiểuNhàToolStripMenuItem1.Click
        formLocNha.ShowDialog()
    End Sub



    Private Sub btnZaloHoTro_Click(sender As Object, e As EventArgs) Handles lhZaLo.Click
        ' Link Zalo hỗ trợ - thay bằng số điện thoại thật hoặc OA link
        Dim zaloHoTroLink As String = "https://zalo.me/0369038160"

        Try
            Process.Start(New ProcessStartInfo("https://zalo.me/0369383168") With {.UseShellExecute = True})
            Process.Start(zaloHoTroLink)
        Catch ex As Exception
            MessageBox.Show("Không thể mở liên kết Zalo: " & ex.Message)
        End Try
    End Sub

    Private Sub FbBùiThànhĐạtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FbBùiThànhĐạtToolStripMenuItem.Click
        Dim FBHoTroLink As String = "https://facebook.com/0369383168"

        Try
            Process.Start(New ProcessStartInfo("https://facebook.me/0369383168") With {.UseShellExecute = True})
            Process.Start(FBHoTroLink)
        Catch ex As Exception
            MessageBox.Show("Không thể mở liên kết Zalo: " & ex.Message)
        End Try
    End Sub

End Class