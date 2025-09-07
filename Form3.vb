Imports Microsoft.Data.SqlClient
Public Class frmMG
    Private Sub btnThue_Click(sender As Object, e As EventArgs) Handles btThueMG.Click
        If dataMT.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataMT.SelectedRows(0)
            Dim hoTen As String = selectedRow.Cells("HoTenMG").Value.ToString()
            MessageBox.Show("Bạn đã chọn thuê " & hoTen)
        Else
            MessageBox.Show("Vui lòng chọn một cá nhân để thuê!")
        End If
    End Sub

    Private Sub btDanhGiaMG_Click(sender As Object, e As EventArgs) Handles btDanhGiaMG.Click
        txtDanhGia.Show()
        btGuiDG.Show()
        btThoatDG.Show()
        txtDanhGia.Text = ""
        txtDanhGia.Focus()
    End Sub

    Private Sub btGuiDG_Click(sender As Object, e As EventArgs) Handles btGuiDG.Click
        Dim danhgia As String = txtDanhGia.Text = ""
        MsgBox("Bạn có muốn gửi đánh giá này chứ?", MessageBoxButtons.YesNo, "Thông báo")
        MsgBox("Đã gửi đánh giá của bạn!", MessageBoxButtons.YesNo, " Thông báo")
        txtDanhGia.Focus()
        txtDanhGia.Clear()

    End Sub

    Private Sub btThoatDG_Click(sender As Object, e As EventArgs) Handles btThoatDG.Click
        Me.Close()
    End Sub

    Private Sub txtDanhGia_TextChanged(sender As Object, e As EventArgs) Handles txtDanhGia.TextChanged

    End Sub
End Class