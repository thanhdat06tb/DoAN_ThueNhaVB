Imports Microsoft.Data.SqlClient

Public Class DangKi
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"


    Private Sub btnDKT_Click(sender As Object, e As EventArgs) Handles btDKTK.Click

        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True;TrustServerCertificate=True")
        Try
            conn.Open()
            If txtDKMK.Text <> txtXTMK.Text Then
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim query As String = "INSERT INTO NguoiDung1 (TenDangNhap, MatKhau) VALUES (@TenDangNhap, @MatKhau)"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@TenDangNhap", txtDKTK.Text)
            cmd.Parameters.AddWithValue("@MatKhau", txtDKMK.Text)
            cmd.Parameters.AddWithValue("@XacThucMK", txtXTMK.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Đăng ký thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Hide()
        DangNhap.Show()

    End Sub
End Class