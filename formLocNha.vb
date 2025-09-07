Imports System.Data.SqlClient


Public Class formLocNha
    Dim chuoiKetNoi As String = "Data Source=BUITHANHDAT88\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"
    ' HÀM CHÍNH: lọc theo loại nhà
    Private Sub LoadNhaTheoLoai(loai As String)
        Dim query As String = "SELECT * FROM Nha1 WHERE LoaiNha = @LoaiNha"

        Using ketNoi As New SqlConnection(chuoiKetNoi)
            Using cmd As New SqlCommand(query, ketNoi)
                cmd.Parameters.AddWithValue("@LoaiNha", loai)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                ketNoi.Open()
                adapter.Fill(dt)
                ketNoi.Close()

                DataLocNha1.DataSource = dt
            End Using
        End Using
    End Sub

    ' Nút Lọc Chung cư
    Private Sub btnLocChungCu_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadNhaTheoLoai("Chung cư")
    End Sub

    ' Nút Lọc Nhà trọ
    Private Sub btnLocNhaTro_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadNhaTheoLoai("Trọ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
