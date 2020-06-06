Public Class Pernyataan
    Dim id_pernyataan As String
    Dim kd_domain As String
    Dim isi_pernyataan As String
    Private Sub AturData()
        kd_domain = Ckd_domain.Text
        isi_pernyataan = Tisi_pernyataan.Text
    End Sub
    Private Sub ResetForm(sender As Object, e As EventArgs) Handles Bbatal.Click
        Ckd_domain.SelectedIndex = -1
        Tisi_pernyataan.Clear()
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        Dim sql As String = "Select tbl_pernyataan.id_pernyataan, tbl_pernyataan.kd_domain, tbl_domain.nm_domain, tbl_pernyataan.isi_pernyataan FROM tbl_pernyataan join tbl_domain on tbl_pernyataan.kd_domain = tbl_domain.kd_domain"
        DGpernyataan.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub

    Private Sub AmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGpernyataan.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGpernyataan.CurrentRow
        id_pernyataan = data_terpilih.Cells("id_pernyataan").Value
        Ckd_domain.Text = data_terpilih.Cells("kd_domain").Value
        Tisi_pernyataan.Text = data_terpilih.Cells("isi_pernyataan").Value
    End Sub
    Private Sub ProsesTambahData(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        Dim sql As String = "INSERT INTO tbl_pernyataan (kd_domain, isi_pernyataan) VALUES ('" & kd_domain & "', '" & isi_pernyataan & "')"
        Aplikasi.Db.JalankanSql(sql)
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil ditambahkan!")
            TampilkanData()
            Bbatal.PerformClick()
        End If
    End Sub
    Private Sub ProsesEditData(sender As Object, e As EventArgs) Handles Bedit.Click
        Me.AturData()
        Dim sql As String = "UPDATE tbl_pernyataan SET kd_domain = '" & kd_domain & "', isi_pernyataan = '" & isi_pernyataan & "' WHERE id_pernyataan = '" & id_pernyataan & "'"
        Aplikasi.Db.JalankanSql(sql)
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil diedit!")
            TampilkanData()
            Bbatal.PerformClick()
        End If
    End Sub
    Private Sub ProsesHapusData(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim kode = DGpernyataan.CurrentRow.Cells("id_pernyataan").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tbl_pernyataan WHERE id_pernyataan = '" & kode & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil dihapus!")
            TampilkanData()
        End If
    End Sub
    Private Sub Tutup(sender As Object, e As EventArgs) Handles Btutup.Click
        Aplikasi.TutupForm(Me)
    End Sub

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Ckd_domain.DataSource = Aplikasi.Db.JalankanDanAmbilData("SELECT kd_domain, CONCAT(kd_domain, ' - ', nm_domain) AS nm_domain FROM tbl_domain ORDER BY kd_domain")
        Bbatal.PerformClick()
        TampilkanData()
    End Sub
End Class