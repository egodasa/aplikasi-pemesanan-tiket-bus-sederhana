Public Class FMenu_Utama
    Private Sub Keluar(sender As Object, e As EventArgs)
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load

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
        FPemesanan.Show()
        Me.Hide()
    End Sub

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        Aplikasi.Show()
        Me.Close()
    End Sub
End Class