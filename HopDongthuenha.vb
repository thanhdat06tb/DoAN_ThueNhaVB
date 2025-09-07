Imports System.Data.SqlClient
Public Class HopDongthuenha
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btLuuHopDong.Click
        ' Kiểm tra dữ liệu đầu vào
        If String.IsNullOrWhiteSpace(txtMaHD.Text) OrElse
       String.IsNullOrWhiteSpace(txtMaKhach.Text) OrElse
       String.IsNullOrWhiteSpace(txtMaNha.Text) OrElse
       String.IsNullOrWhiteSpace(txtTongTien.Text) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Chuỗi kết nối
        Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"
        Try
            Using conn As New SqlConnection(connectionString)

                conn.Open()
                ' Kiểm tra MaKhach có tồn tại trong bảng diboKhach1 không
                Dim checkQuery As String = "SELECT COUNT(*) FROM Khach1 WHERE MaKhach = @MaKhach"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@MaKhach", txtMaKhach.Text)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                End Using

                Dim Enabledidentityinsert As String = "SET IDENTITY_INSERT Khach1 ON"
                Using EnabledCmd As New SqlCommand(Enabledidentityinsert, conn)
                    EnabledCmd.ExecuteNonQuery()
                End Using
                Try
                    ' Thêm mới MaKhach vào Khach1 nếu không tồn tại
                    Dim insertKhachQuery As String = "INSERT INTO Khach1 (MaKhach, HoTen, SDT, DiaChi) VALUES (@MaKhach, @HoTen, @SDT, @DiaChi)"
                    Using insertKhachCmd As New SqlCommand(insertKhachQuery, conn)
                        insertKhachCmd.Parameters.AddWithValue("@MaKhach", txtMaKhach.Text)
                        insertKhachCmd.Parameters.AddWithValue("@HoTen", If(String.IsNullOrWhiteSpace(txtHoTen.Text), "Khách vãng lai", txtHoTen.Text)) ' Giả sử có txtHoTen
                        insertKhachCmd.Parameters.AddWithValue("@SDT", If(String.IsNullOrWhiteSpace(txtSDT.Text), DBNull.Value, txtSDT.Text)) ' Giả sử có txtSDT
                        insertKhachCmd.Parameters.AddWithValue("@DiaChi", If(String.IsNullOrWhiteSpace(txtDiaChi.Text), DBNull.Value, txtDiaChi.Text)) ' Giả sử có txtDiaChi
                        insertKhachCmd.ExecuteNonQuery()
                    End Using
                Finally






                    ' Thực hiện INSERT vào bảng HopDong1
                    Dim query As String = "INSERT INTO HopDong1 (MaHopDong, MaKhach, MaNha, NgayKy, NgayHetHan, TienThue) VALUES (@MaHopDong, @MaKhach, @MaNha, @NgayKy, @NgayHetHan, @TienThue)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@MaHopDong", txtMaHD.Text)
                        cmd.Parameters.AddWithValue("@MaKhach", txtMaKhach.Text)
                        cmd.Parameters.AddWithValue("@MaNha", txtMaNha.Text)
                        cmd.Parameters.AddWithValue("@NgayKy", dateKi.Value)
                        cmd.Parameters.AddWithValue("@NgayHetHan", dateHetHan.Value)
                        cmd.Parameters.AddWithValue("@TienThue", Convert.ToDecimal(txtTongTien.Text))
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Lưu hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                    Dim disableidentityinsert As String = "SET IDENTITY_INSERT Khach1 Off"
                    Using disableCmd As New SqlCommand(disableidentityinsert, conn)
                        disableCmd.ExecuteNonQuery()
                    End Using
                End Try
            End Using
            Using conn1 As New SqlConnection(connectionString)
                    Try
                        conn1.Open()

                        ' Giả sử bạn đã lưu hợp đồng ở đây
                        ' ...

                        ' Cập nhật tình trạng nhà
                        Dim queryUpdate As String = "UPDATE Nha1 SET TinhTrang = 'Đã thuê' WHERE MaNha = @maNha"
                    Using cmdUpdate As New SqlCommand(queryUpdate, conn1)
                        cmdUpdate.Parameters.AddWithValue("@maNha", txtMaNha.Text.Trim())
                        Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()
                        MessageBox.Show("Cập nhật tình trạng nhà, số dòng ảnh hưởng: " & rowsAffected)
                    End Using

                Catch ex As Exception
                        MessageBox.Show("Lỗi: " & ex.Message)
                    End Try
                End Using

                ' Xóa form sau khi lưu
                txtMaHD.Clear()
            txtMaKhach.Clear()
            txtMaNha.Clear()
            txtTongTien.Clear()
            txtGiaThue.Clear()
            If Not String.IsNullOrWhiteSpace(txtHoTen.Text) Then txtHoTen.Clear()
            If Not String.IsNullOrWhiteSpace(txtSDT.Text) Then txtSDT.Clear()
            If Not String.IsNullOrWhiteSpace(txtDiaChi.Text) Then txtDiaChi.Clear()
            dateKi.Value = DateTime.Now
            dateHetHan.Value = DateTime.Now
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btCheckHD_Click(sender As Object, e As EventArgs) Handles btCheckHD.Click
        Me.Close()
        CheckHopDong.ShowDialog()
    End Sub

    Private Sub btThoatHD_Click(sender As Object, e As EventArgs) Handles btThoatHD.Click
        Me.Close()
    End Sub
End Class
