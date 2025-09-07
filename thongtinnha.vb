Imports System.Data.SqlClient
Public Class thongtinnha
    Dim connectionString As String = "Data Source=BUITHANHDAT88\SQLEXPRESS;Initial Catalog=BTLvisual;Integrated Security=True"
    Private Sub FormDanhSachNha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM Nha1"
        Dim conn As New SqlConnection(connectionString)
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()

        adapter.Fill(table)




    End Sub



    Private Sub link1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link1.LinkClicked
        formChiTietNha1.Show()
    End Sub


    Private Sub link2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link2.LinkClicked
        formChiTietNha2.Show()
    End Sub

    Private Sub link3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link3.LinkClicked
        fromChiTietNha3.Show()
    End Sub

    Private Sub link4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link4.LinkClicked
        formChiTietNha4.Show()
    End Sub

    Private Sub link5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link5.LinkClicked
        formChiTietNha5.Show()
    End Sub

    Private Sub link6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link6.LinkClicked
        formChiTietNha6.Show()
    End Sub

    Private Sub btQuayLai_Click(sender As Object, e As EventArgs) Handles btQuayLai.Click
        Me.Close()
    End Sub

    Private Sub btTimKiem_Click(sender As Object, e As EventArgs) Handles btTimKiem.Click
        Dim conn As New SqlConnection(connectionString)
        Dim tuKhoa As String = txtTimKiem.Text.Trim()
        Dim query As String = ""
        txtTimKiem.Visible = True
        txtTimKiem.Focus()

        Dim gia As Double
        If Double.TryParse(tuKhoa, gia) Then
            query = "SELECT * FROM Nha1 WHERE GiaThue = @gia"
        Else
            query = "SELECT * FROM Nha1 WHERE LoaiNha LIKE '%' + @loai + '%'"
        End If

        Try
            conn.Open()
            Dim cmd As New SqlCommand(query, conn)

            If Double.TryParse(tuKhoa, gia) Then
                cmd.Parameters.AddWithValue("@gia", gia)
            Else
                cmd.Parameters.AddWithValue("@loai", tuKhoa)
            End If

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            formLocNha.DataLocNha1.DataSource = table

            formLocNha.DataLocNha1.Visible = True
            formLocNha.Show()

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged

    End Sub
End Class