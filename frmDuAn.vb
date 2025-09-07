Public Class frmDuAn

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        picanhTo4.Show()
        lbtext11.Show()
        lbtex12.Show()
        lbtex13.Show()
        lbtext31.Hide()
        Lbtext32.Hide()
        lbtext33.Hide()
        Label41.Hide()
        Label42.Hide()
        Label43.Hide()
        lb21.Hide()
        lb22.Hide()
        lb23.Hide()



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        picanhTo4.Hide()
        picanhTo2.Show()
        lbtext11.Hide()
        lbtex12.Hide()
        lbtex13.Hide()
        lb21.Show()
        lb22.Show()
        lb23.Show()
        lbtext31.Hide()
        Lbtext32.Hide()
        lbtext33.Hide()
        Label41.Hide()
        Label42.Hide()
        Label43.Hide()



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        picanhTo2.Hide()
        picanhTo3.Show()
        lbtext11.Hide()
        lbtex12.Hide()
        lbtex13.Hide()
        lb21.Hide()
        lb22.Hide()
        lb23.Hide()
        lbtext31.Show()
        Lbtext32.Show()
        lbtext33.Show()
        Label41.Hide()
        Label42.Hide()
        Label43.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        picanhTo3.Hide()
        picanhTo1.Show()
        lbtext11.Hide()
        lbtex12.Hide()
        lbtex13.Hide()
        lb21.Hide()
        lb22.Hide()
        lb23.Hide()
        lbtext31.Hide()
        Lbtext32.Hide()
        lbtext33.Hide()
        Label41.Show()
        Label42.Show()
        Label43.Show()
    End Sub

    Private Sub frmDuAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class