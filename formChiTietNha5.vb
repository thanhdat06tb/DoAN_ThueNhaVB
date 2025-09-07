Public Class formChiTietNha5
    Private Sub btQuayLaip5_Click(sender As Object, e As EventArgs) Handles btQuayLaip5.Click
        Me.Close()
    End Sub

    Private Sub btThueNha2_Click(sender As Object, e As EventArgs) Handles btThueNha2.Click
        MsgBox("Bạn muốn thuê căn hộ này chứ?")
        HopDongthuenha.ShowDialog()
    End Sub

End Class