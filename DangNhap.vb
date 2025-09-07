Imports Microsoft.Data.SqlClient
Public Class DangNhap
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btDN.Click
        Dim ketnoi As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True;TrustServerCertificate=True")
        Dim nhap As New SqlCommand
        Dim reader As SqlDataReader

        Try
            ketnoi.Open()
            nhap.Connection = ketnoi
            nhap.CommandText = "SELECT * FROM NguoiDung1 WHERE TenDangNhap = @MaNguoiDung AND MatKhau = @MatKhau"
            nhap.Parameters.AddWithValue("@MaNguoiDung", txtTK.Text)
            nhap.Parameters.AddWithValue("@MatKhau", txtMK.Text)
            reader = nhap.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Đăng nhập thành công!")
                Me.Hide()

                TrangChu.Show()
            Else
                MessageBox.Show("Đăng nhập sai!")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            If ketnoi.State = ConnectionState.Open Then ketnoi.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim DANGKI As New DangKi()
        DANGKI.ShowDialog()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        End
    End Sub

End Class
