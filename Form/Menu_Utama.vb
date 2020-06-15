Public Class FMenu_Utama
    Private Sub Keluar(sender As Object, e As EventArgs)
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub ResetMenu()
        Bbus.Enabled = True
        Btiket.Enabled = True
        Bpemesanan.Enabled = True
        Bpengguna.Enabled = True
        Blaporan_mobil.Enabled = True
        Blaporan_pemesanan.Enabled = True
        Blaporan_tiket.Enabled = True
    End Sub

    Private Sub MenuAdmin()
        Bbus.Enabled = True
        Btiket.Enabled = True
        Bpemesanan.Enabled = True
        Bpengguna.Enabled = True
        Blaporan_mobil.Enabled = True
        Blaporan_pemesanan.Enabled = True
        Blaporan_tiket.Enabled = True
    End Sub

    Private Sub MenuKasir()
        Bbus.Enabled = False
        Btiket.Enabled = False
        Bpemesanan.Enabled = True
        Bpengguna.Enabled = False
        Blaporan_mobil.Enabled = False
        Blaporan_pemesanan.Enabled = False
        Blaporan_tiket.Enabled = False
    End Sub

    Private Sub MenuPimpinan()
        Bbus.Enabled = False
        Btiket.Enabled = False
        Bpemesanan.Enabled = False
        Bpengguna.Enabled = False
        Blaporan_mobil.Enabled = True
        Blaporan_pemesanan.Enabled = True
        Blaporan_tiket.Enabled = True
    End Sub

    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        If Aplikasi.level = "Admin" Then
            MenuAdmin()
        ElseIf Aplikasi.level = "Kasir" Then
            MenuKasir()
        ElseIf Aplikasi.level = "Pimpinan" Then
            MenuPimpinan()
        End If
    End Sub

    Private Sub HasilAnalisa(sender As Object, e As EventArgs)
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-analisa.php"
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Bbus_Click(sender As Object, e As EventArgs) Handles Bbus.Click
        FMobil.Show()
        Me.Hide()
    End Sub

    Private Sub Btiket_Click(sender As Object, e As EventArgs) Handles Btiket.Click
        FTiket.Show()
        Me.Hide()

    End Sub

    Private Sub Bpemesanan_Click(sender As Object, e As EventArgs) Handles Bpemesanan.Click
        FPemesanan.Show()
        Me.Hide()
    End Sub

    Private Sub Bpengguna_Click(sender As Object, e As EventArgs) Handles Bpengguna.Click
        FPengguna.Show()
        Me.Hide()
    End Sub

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Blaporan_mobil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_mobil.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-mobil.html"
        Cetak_Laporan.data.Add("nama", "madam")
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Blaporan_tiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_tiket.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-tiket.html"
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Blaporan_pemesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_pemesanan.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-pemesanan.html"
        Cetak_Laporan.ShowDialog()
    End Sub
End Class