Public Class FPemesanan
    Private data_mobil As DataTable
    Private data_tiket As DataTable
    Private Sub AmbilDataMobil()
        data_mobil = Aplikasi.Db.JalankanDanAmbilData("SELECT *, CONCAT(merk, ' - ', jenis, ' - ', no_polisi) AS keterangan FROM tb_mobil ORDER BY kode_mobil")
        Ckode_mobil.DataSource = data_mobil
        Ckode_mobil.ValueMember = "kode_mobil"
        Ckode_mobil.DisplayMember = "keterangan"
    End Sub
    Private Sub AmbilDataTiket()
        data_tiket = Aplikasi.Db.JalankanDanAmbilData("SELECT *, CONCAT(jurusan, ' - ', kelas) AS keterangan FROM tb_tiker ORDER BY kode_tiket")
        Ckode_tiket.DataSource = data_tiket
        Ckode_mobil.ValueMember = "kode_tiket"
        Ckode_mobil.DisplayMember = "keterangan"
    End Sub
    Private Function GenerateKodePemesanan()
        Return 0
    End Function
    Private Sub SetKodePemesanan()
        Tkode_pemesanan.Text = GenerateKodePemesanan()
    End Sub
    Private Sub TampilDetailLogin()
        Tnama_kasir.Text = Aplikasi.nama_lengkap
    End Sub
    Private Sub TampilDetailMobil()
        Dim indeks_mobil As Integer = Ckode_mobil.SelectedIndex
        If indeks_mobil >= 0 Then
            Dim data_terpilih As DataRow = data_mobil.Rows(indeks_mobil)
            Tno_polisi.Text = data_terpilih.Item("no_polisi")
            Tjenis.Text = data_terpilih.Item("jenis")
            Tmerk.Text = data_terpilih.Item("merk")
            Twarna.Text = data_terpilih.Item("warna")
            Tbahan_bakar.Text = data_terpilih.Item("bahan_bakar")
        Else
            ResetDataMobil()
        End If
    End Sub
    Private Sub TampilDetailTiket()
        Dim indeks_tiket As Integer = Ckode_tiket.SelectedIndex
        If indeks_tiket >= 0 Then
            Dim data_terpilih As DataRow = data_mobil.Rows(indeks_tiket)
            Tjurusan.Text = data_terpilih.Item("jurusan")
            Tkelas.Text = data_terpilih.Item("kelas")
            Tharga.Text = data_terpilih.Item("harga")
            Tjumlah_bus.Text = data_terpilih.Item("jumlah_bus")
        Else
            ResetDataTiket()
        End If
    End Sub
    Private Sub HitungTotalBayar()
        Dim total_bayar As Integer
        If Tjumlah_beli.Text <> "" And Ckode_tiket.SelectedIndex >= 0 Then
            total_bayar = Val(Tjumlah_beli.Text) * Val(Tharga.Text)
        End If
        Ttotal_bayar.Text = total_bayar
    End Sub
    Private Sub HitungKembalian()
        Dim kembalian As Integer
        If Ttotal_bayar.Text <> "" And Tdibayar.Text Then
            kembalian = Val(Ttotal_bayar.Text) - Val(Tdibayar.Text)
        End If
        Tsisa.Text = kembalian
    End Sub
    Private Sub SimpanPemesanan()
        If Tnm_pembeli.Text <> "" And Ttelpon.Text <> "" And Ckode_tiket.SelectedIndex >= 0 And Ckode_mobil.SelectedIndex >= 0 And Tno_bangku.Text <> "" And Tjumlah_beli.Text <> "" And Ttotal_bayar.Text <> "" And Tdibayar.Text <> "" Then
            Aplikasi.Db.JalankanSql("INSERT INTO tb_pemesanan VALUES ('" & Tkode_pemesanan.Text & "', '" & Tnm_pembeli.Text & "','" & Ckode_tiket.SelectedValue & "', '" & Ttelpon.Text & "','" & Ttgl_transaksi.Value.ToString("yyyy-MM-dd") & "', '" & Ttgl_berangkat.Value.ToString("yyyy-MM-dd") & "','" & Tjam_berangkat.Value.ToString("H:m") & "', '" & Ckode_mobil.SelectedValue & "','" & Tjumlah_beli.Text & "', '" & Tno_bangku.Text & "','" & Ttotal_bayar.Text & "', '" & Tdibayar.Text & "','" & Aplikasi.id_pengguna & "')")
            If Aplikasi.Db.ApakahError() Then
                MessageBox.Show("Data pemesanan tidak dapat disimpan! Silahkan ulangi lagi.")
            Else
                Bbatal.PerformClick()
                MessageBox.Show("Data berhasil disimpan!")
            End If
        Else
            MessageBox.Show("Silahkan isi semua data pemesanan!")
        End If
    End Sub
    Private Sub CetakPemesanan()

    End Sub
    Private Sub HapusPemesanan()
        Dim data_terpilih As String = DGpemesanan.CurrentRow.Cells("kode_pemesanan").Value.ToString()
        Aplikasi.Db.JalankanSql("DELETE FROM tb_pemesanan WHERE kode_pemesanan = '" & data_terpilih & "'")
        TampilDataPemesanan()
        MessageBox.Show("Data berhasil dihapus!", "Pesan")
    End Sub
    Private Sub ResetPembayaran()
        Ttotal_bayar.Clear()
        Tdibayar.Clear()
        Tsisa.Clear()
    End Sub
    Private Sub ResetDataPembeli()
        Tnm_pembeli.Clear()
        Ttelpon.Clear()
        Ttgl_berangkat.ResetText()
        Ttgl_transaksi.ResetText()
        Tjam_berangkat.ResetText()
        Tno_bangku.Clear()
        Tjumlah_beli.Clear()
    End Sub
    Private Sub ResetDataMobil()
        Ckode_mobil.SelectedIndex = -1
        Tno_polisi.Clear()
        Tjenis.Clear()
        Tmerk.Clear()
        Twarna.Clear()
        Tbahan_bakar.Clear()
    End Sub
    Private Sub ResetDataTiket()
        Ckode_tiket.SelectedIndex = -1
        Tjurusan.Clear()
        Tjumlah_bus.Clear()
        Tkelas.Clear()
        Tharga.Clear()
    End Sub
    Private Sub TampilDataPemesanan()
        Dim sql As String = "SELECT * FROM tb_pemesanan"
        DGpemesanan.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub
    Private Sub PencarianDataPemesanan(ByVal kata_kunci As String)
        Dim sql As String = "SELECT * FROM tb_pemesanan"
        If kata_kunci <> vbEmpty Then
            sql += " WHERE kode_pemesanan LIKE '%" & kata_kunci & "%' OR nm_pembeli LIKE '%" & kata_kunci & "%' OR telpon LIKE '%" & kata_kunci & "%' OR  no_bangku LIKE '%" & kata_kunci & "%'"
        End If
        DGpemesanan.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bsimpan_Click(sender As Object, e As EventArgs) Handles Bsimpan.Click
        SimpanPemesanan()
        CetakPemesanan()
    End Sub

    Private Sub Bbatal_Click(sender As Object, e As EventArgs) Handles Bbatal.Click
        GenerateKodePemesanan()
        ResetDataMobil()
        ResetDataPembeli()
        ResetDataTiket()
        ResetPembayaran()
    End Sub

    Private Sub Btutup_Click(sender As Object, e As EventArgs) Handles Btutup.Click
        FMenu_Utama.Show()
        Me.Close()
    End Sub
End Class