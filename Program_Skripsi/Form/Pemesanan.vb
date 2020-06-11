Public Class FPemesanan
    Private Function GenerateKodePemesanan()
        Return 0
    End Function
    Private Sub SetKodePemesanan()

    End Sub
    Private Sub TampilDetailLogin()

    End Sub
    Private Sub TampilDetailMobil()

    End Sub
    Private Sub TampilDetailTiket()

    End Sub
    Private Sub HitungPembayaran()

    End Sub
    Private Sub SimpanPemesanan()

    End Sub
    Private Sub CetakPemesanan()

    End Sub
    Private Sub HapusPemesanan()

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