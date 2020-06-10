Public Class Menu_Utama
    Private Sub Keluar(sender As Object, e As EventArgs)
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserMenu(sender As Object, e As EventArgs)
        Pengguna.Show()
        Me.Hide()
    End Sub

    Private Sub DomainMenu(sender As Object, e As EventArgs)
        Bus.Show()
        Me.Hide()
    End Sub

    Private Sub PernyataanMenu(sender As Object, e As EventArgs)
        Pernyataan.Show()
        Me.Hide()
    End Sub

    Private Sub HasilAnalisa(sender As Object, e As EventArgs)
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-analisa.php"
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub KuisionerMenu(sender As Object, e As EventArgs)
        Kuisioner.Show()
        Me.Hide()
    End Sub
End Class