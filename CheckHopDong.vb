Imports System.Data.SqlClient
Public Class CheckHopDong
    Dim LinkSQL As String = "Data Source=BUITHANHDAT88\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"
    Private Sub CheckHopDong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truyxuat As String = "SELECT * FROM HopDong1"
        Dim ketnoisql As New SqlConnection(LinkSQL)
        Dim Hienthi As New SqlDataAdapter(truyxuat, ketnoisql)
        Dim table As New DataTable()

        Try
            ketnoisql.Open()
            Hienthi.Fill(table)
            CheckHD.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            ketnoisql.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btxoaHD.Click
        If CheckHD.SelectedRows.Count > 0 Then
            Dim maHD As String = CheckHD.SelectedRows(0).Cells("MaHopDong").Value.ToString()
            Dim maNha As String = CheckHD.SelectedRows(0).Cells("MaNha").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn xoá hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    Dim ketnoisql As New SqlConnection(LinkSQL)
                    ketnoisql.Open()

                    Dim lenhXoa As String = "DELETE FROM HopDong1 WHERE MaHopDong = @MaHD"
                    Dim cmdXoa As New SqlCommand(lenhXoa, ketnoisql)
                    cmdXoa.Parameters.AddWithValue("@MaHD", maHD)
                    cmdXoa.ExecuteNonQuery()


                    Dim lenhCapNhat As String = "UPDATE Nha1 SET TinhTrang = N'Chưa thuê' WHERE MaNha = @MaNha"
                    Dim cmdCapNhat As New SqlCommand(lenhCapNhat, ketnoisql)
                    cmdCapNhat.Parameters.AddWithValue("@MaNha", maNha)
                    cmdCapNhat.ExecuteNonQuery()

                    ketnoisql.Close()

                    MessageBox.Show("Đã xoá hợp đồng và cập nhật tình trạng nhà thành công!")
                    CheckHopDong_Load(Nothing, Nothing) ' Load lại dữ liệu
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi xoá hợp đồng: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Vui lòng chọn một hợp đồng để xoá.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class