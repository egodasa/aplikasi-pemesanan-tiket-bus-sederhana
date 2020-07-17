Public Class FPemesanan
    Private data_mobil As DataTable
    Private data_tiket As DataTable
    Private Sub KurangiStokTiket()
        Aplikasi.Db.JalankanSql("UPDATE tb_tiket SET jumlah_tiket = [jumlah_tiket] - 1 WHERE kode_tiket ='" & Ckode_tiket.SelectedValue & "'")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show(Aplikasi.Db.AmbilPesanError)
            Stop
        End If
    End Sub
    Private Sub AmbilDataMobil()
        data_mobil = Aplikasi.Db.JalankanDanAmbilData("SELECT *, kode_mobil & ' - ' & merk & ' - ' & jenis & ' - ' & no_polisi AS keterangan FROM tb_mobil ORDER BY kode_mobil")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show(Aplikasi.Db.AmbilPesanError)
            Stop
        End If
        Ckode_mobil.ValueMember = "kode_mobil"
        Ckode_mobil.DisplayMember = "keterangan"
        Ckode_mobil.DataSource = data_mobil
        
    End Sub
    Private Sub AmbilDataTiket()
        data_tiket = Aplikasi.Db.JalankanDanAmbilData("SELECT *, kode_tiket & ' - ' & jurusan & ' - ' & kelas AS keterangan FROM tb_tiket ORDER BY kode_tiket")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show(Aplikasi.Db.AmbilPesanError)
            Stop
        End If
        Ckode_tiket.ValueMember = "kode_tiket"
        Ckode_tiket.DisplayMember = "keterangan"
        Ckode_tiket.DataSource = data_tiket
    End Sub
    Private Sub SetKodePemesanan()
        Tkode_pemesanan.Text = Aplikasi.GenerateKode("tb_pemesanan", "kode_pemesanan", "PJ-TKT-", 6)
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
            Dim data_terpilih As DataRow = data_tiket.Rows(indeks_tiket)
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
        If Ttotal_bayar.Text <> "" And Tdibayar.Text <> "" Then
            kembalian = Val(Tdibayar.Text) - Val(Ttotal_bayar.Text)
            If kembalian < 0 Then
                kembalian = 0
            End If
        End If
        Tsisa.Text = kembalian
    End Sub
    Private Sub SimpanPemesanan()
        If Tnm_pembeli.Text <> "" And Ttelpon.Text <> "" And Ckode_tiket.SelectedIndex >= 0 And Ckode_mobil.SelectedIndex >= 0 And Tno_bangku.Text <> "" And Tjumlah_beli.Text <> "" And Ttotal_bayar.Text <> "" And Tdibayar.Text <> "" Then
            Aplikasi.Db.JalankanSql("INSERT INTO tb_pemesanan VALUES ('" & Tkode_pemesanan.Text & "','" & Ckode_tiket.SelectedValue & "','" & Ttelpon.Text & "', " & Aplikasi.id_pengguna & ", '" & Tnm_pembeli.Text & "', #" & Ttgl_transaksi.Value.ToString("yyyy-MM-dd") & "#, #" & Ttgl_berangkat.Value.ToString("yyyy-MM-dd") & "#, #" & Tjam_berangkat.Value.ToString("H:m") & "#, '" & Ckode_mobil.SelectedValue & "', " & Tjumlah_beli.Text & ", '" & Tno_bangku.Text & "', " & Ttotal_bayar.Text & ", " & Tdibayar.Text & ")")
            If Aplikasi.Db.ApakahError() Then
                MessageBox.Show("Data pemesanan tidak dapat disimpan! Silahkan ulangi lagi.")
                MessageBox.Show(Aplikasi.Db.AmbilPesanError)
            Else
                CetakPemesanan(Tkode_pemesanan.Text)
                KurangiStokTiket()
                Bbatal.PerformClick()
                MessageBox.Show("Data berhasil disimpan!")
            End If
        Else
            MessageBox.Show("Silahkan isi semua data pemesanan!")
        End If
    End Sub
    Private Sub CetakPemesanan(ByVal kode_tiket As String)
        Dim sql As String = "Select [tb_pemesanan].[kode_pemesanan], [tb_pemesanan].[total_bayar], [tb_pemesanan].[no_bangku], [tb_pemesanan].[nm_pembeli], [tb_pemesanan].telpon, [tb_pemesanan].[tgl_transaksi], [tb_pemesanan].[tgl_berangkat], [tb_pemesanan].[jam_berangkat], [tb_tiket].[kode_tiket], [tb_tiket].jurusan, [tb_tiket].kelas, [tb_tiket].[jumlah_tiket], [tb_mobil].[kode_mobil], [tb_mobil].jenis, [tb_mobil].merk, [tb_mobil].[no_polisi]" &
                            " From (([tb_pemesanan] Inner Join [tb_mobil] On [tb_pemesanan].[kode_mobil] = [tb_mobil].[kode_mobil]) Inner Join [tb_tiket] On [tb_tiket].[kode_tiket] = [tb_pemesanan].[kode_tiket]) Inner Join [tb_pengguna] On [tb_pemesanan].[id_pengguna] = [tb_pengguna].[id_pengguna] WHERE [tb_pemesanan].[kode_pemesanan] = '" & kode_tiket & "'"
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData(sql)
        Dim data_tiket As DataRow = data_tmp.Rows(0)
        Cetak_Laporan.SetData("kode_pemesanan", data_tiket.Item("kode_pemesanan"))
        Cetak_Laporan.SetData("nm_pembeli", data_tiket.Item("nm_pembeli"))
        Cetak_Laporan.SetData("no_bangku", data_tiket.Item("no_bangku"))
        Cetak_Laporan.SetData("telpon", data_tiket.Item("telpon"))
        Cetak_Laporan.SetData("tgl_berangkat", Convert.ToDateTime(data_tiket.Item("tgl_berangkat")).ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("jurusan", data_tiket.Item("jurusan"))
        Cetak_Laporan.SetData("jam_berangkat", Convert.ToDateTime(data_tiket.Item("jam_berangkat")).ToString("H:m"))
        Cetak_Laporan.SetData("no_polisi", data_tiket.Item("no_polisi"))
        Cetak_Laporan.SetData("total_bayar", data_tiket.Item("total_bayar"))
        Cetak_Laporan.url = Aplikasi.url_laporan & "tiket.html"
        Cetak_Laporan.ShowDialog()
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
    Private Sub TampilDataPemesanan(Optional ByVal kata_kunci As String = "")
        Dim sql As String = "Select [tb_pemesanan].[kode_pemesanan], [tb_pemesanan].[nm_pembeli], [tb_pemesanan].telpon, [tb_pemesanan].[tgl_transaksi], [tb_pemesanan].[tgl_berangkat], [tb_pemesanan].[jam_berangkat], [tb_tiket].[kode_tiket], [tb_tiket].jurusan, [tb_tiket].kelas, [tb_tiket].[jumlah_tiket], [tb_mobil].[kode_mobil], [tb_mobil].jenis, [tb_mobil].merk, [tb_mobil].[no_polisi]" &
                            " From (([tb_pemesanan] Inner Join [tb_mobil] On [tb_pemesanan].[kode_mobil] = [tb_mobil].[kode_mobil]) Inner Join [tb_tiket] On [tb_tiket].[kode_tiket] = [tb_pemesanan].[kode_tiket]) Inner Join [tb_pengguna] On [tb_pemesanan].[id_pengguna] = [tb_pengguna].[id_pengguna]"
        If kata_kunci <> "" Then
            sql += " WHERE tb_pemesanan.kode_pemesanan LIKE '%" & kata_kunci & "%' OR tb_pemesanan.nm_pembeli LIKE '%" & kata_kunci & "%' OR tb_pemesanan.telpon LIKE '%" & kata_kunci & "%' OR tb_pemesanan.no_bangku LIKE '%" & kata_kunci & "%'"
        End If
        DGpemesanan.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDetailLogin()
        TampilDataPemesanan()
        SetKodePemesanan()
        AmbilDataMobil()
        AmbilDataTiket()
        Bbatal.PerformClick()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bsimpan.Click
        Dim kode_tiket As String = Tkode_pemesanan.Text
        SimpanPemesanan()
        TampilDataPemesanan()
        Bbatal.PerformClick()
    End Sub

    Private Sub Bbatal_Click(sender As Object, e As EventArgs) Handles Bbatal.Click
        ResetDataMobil()
        ResetDataPembeli()
        ResetDataTiket()
        ResetPembayaran()
        SetKodePemesanan()
    End Sub

    Private Sub Btutup_Click(sender As Object, e As EventArgs) Handles Btutup.Click
        FMenu_Utama.Show()
        Me.Close()
    End Sub

    Private Sub EventTampilkanDetailMobil(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckode_mobil.SelectionChangeCommitted
        If Ckode_mobil.SelectedIndex >= 0 Then
            TampilDetailMobil()
        Else
            ResetDataMobil()
        End If
    End Sub
    Private Sub EventTampilkanDetailTiket(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckode_tiket.SelectionChangeCommitted
        If Ckode_tiket.SelectedIndex >= 0 Then
            TampilDetailTiket()
        Else
            ResetDataTiket()
        End If

    End Sub

    Private Sub EventHitungJumlahBayar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tjumlah_beli.TextChanged
        HitungTotalBayar()
        If Tdibayar.Text <> "" Then
            HitungKembalian()
        End If
    End Sub

    Private Sub EventKembalian(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tdibayar.TextChanged
        HitungKembalian()
    End Sub

    Private Sub EventCetakTiket(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CetakPemesanan(DGpemesanan.CurrentRow.Cells("kode_pemesanan").Value)
    End Sub
End Class