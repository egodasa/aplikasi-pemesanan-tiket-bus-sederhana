Public Class FPemesanan
    Private data_mobil As DataTable
    Private data_tiket As DataTable
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
        Tkode_pemesanan.Text = Aplikasi.GenerateKode("tb_pemesanan", "kode_tiket", "PJ-TKT-")
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
            Aplikasi.Db.JalankanSql("INSERT INTO tb_pemesanan VALUES ('" & Tkode_pemesanan.Text & "', '" & Tnm_pembeli.Text & "','" & Ckode_tiket.SelectedValue & "', '" & Ttelpon.Text & "', '" & Ttgl_transaksi.Value.ToString("yyyy-MM-dd") & "', '" & Ttgl_berangkat.Value.ToString("yyyy-MM-dd") & "','" & Tjam_berangkat.Value.ToString("H:m") & "', '" & Ckode_mobil.SelectedValue & "', " & Tjumlah_beli.Text & ", '" & Tno_bangku.Text & "', " & Ttotal_bayar.Text & ", " & Tdibayar.Text & "," & Aplikasi.id_pengguna & ")")
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
        TampilDetailLogin()
        TampilDataPemesanan()
        SetKodePemesanan()
        AmbilDataMobil()
        AmbilDataTiket()
        Bbatal.PerformClick()
    End Sub

    Private Sub Bsimpan_Click(sender As Object, e As EventArgs) Handles Bsimpan.Click
        SimpanPemesanan()
        CetakPemesanan()
    End Sub

    Private Sub Bbatal_Click(sender As Object, e As EventArgs) Handles Bbatal.Click
        ResetDataMobil()
        ResetDataPembeli()
        ResetDataTiket()
        ResetPembayaran()
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

    Private Sub EventHitungJumlahBayar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tjumlah_beli.KeyUp
        HitungTotalBayar()
    End Sub

    Private Sub EventHitungSisa(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tdibayar.KeyDown
        HitungKembalian()
    End Sub
End Class