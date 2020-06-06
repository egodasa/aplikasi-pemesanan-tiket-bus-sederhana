Public Class Kuisioner
    Private Sub Btutup_Click(sender As Object, e As EventArgs) Handles Btutup.Click
        Menu_Utama.Show()
        Me.Close()
    End Sub

    Private Sub TampilData()
        DGkuisioner.DataSource = Aplikasi.Db.JalankanDanAmbilData("Select tbl_kuesioner.*,
COUNT(tbl_jawaban_kuesioner.id_pernyataan) AS total_pernyataan, 
SUM(tbl_jawaban_kuesioner.skor) as total_skor 
FROM tbl_kuesioner 
JOIN tbl_jawaban_kuesioner ON tbl_kuesioner.id_kuesioner = tbl_jawaban_kuesioner.id_kuesioner GROUP BY tbl_kuesioner.id_kuesioner;")
        DGkuisioner.Columns(0).Visible = False
    End Sub

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub Bhapus_Click(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim id As String = DGkuisioner.CurrentRow.Cells(0).Value.ToString()
        Aplikasi.Db.JalankanSql("DELETE FROM tbl_kuesioner WHERE id_kuesioner = '" & id & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil dihapus")
            TampilData()
        End If
    End Sub
End Class