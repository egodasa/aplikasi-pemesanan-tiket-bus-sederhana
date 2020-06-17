Imports System.Text
Public Class FMenu_Utama
    Private Sub Keluar(ByVal sender As Object, ByVal e As EventArgs)
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

    Private Sub Init(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Aplikasi.level = "Admin" Then
            MenuAdmin()
        ElseIf Aplikasi.level = "Kasir" Then
            MenuKasir()
        ElseIf Aplikasi.level = "Pimpinan" Then
            MenuPimpinan()
        End If
    End Sub

    Private Sub HasilAnalisa(ByVal sender As Object, ByVal e As EventArgs)
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-analisa.php"
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Bbus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bbus.Click
        FMobil.Show()
        Me.Hide()
    End Sub

    Private Sub Btiket_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btiket.Click
        FTiket.Show()
        Me.Hide()

    End Sub

    Private Sub Bpemesanan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bpemesanan.Click
        FPemesanan.Show()
        Me.Hide()
    End Sub

    Private Sub Bpengguna_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bpengguna.Click
        FPengguna.Show()
        Me.Hide()
    End Sub

    Private Sub Bkeluar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bkeluar.Click
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Blaporan_mobil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_mobil.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM tb_mobil")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_mobil") & "</td>")
            html_data.Append("<td class='table-td'>" & row("no_polisi") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jenis") & "</td>")
            html_data.Append("<td class='table-td'>" & row("merk") & "</td>")
            html_data.Append("<td class='table-td'>" & row("warna") & "</td>")
            html_data.Append("<td class='table-td'>" & row("bahan_bakar") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-mobil.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_mobil", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Blaporan_tiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_tiket.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM tb_tiket")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_tiket") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jurusan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("kelas") & "</td>")
            html_data.Append("<td class='table-td'>" & row("harga") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_bus") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_tiket") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-tiket.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_mobil", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Blaporan_pemesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan_pemesanan.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("Select [tb_pemesanan].[kode_pemesanan], [tb_tiket].[jurusan], [tb_pemesanan].[nm_pembeli], [tb_pemesanan].telpon, [tb_pemesanan].[tgl_transaksi], [tb_pemesanan].[tgl_berangkat], [tb_pemesanan].[jam_berangkat], [tb_pemesanan].[jumlah_beli], [tb_pemesanan].[no_bangku], [tb_pemesanan].[total_bayar] From ([tb_mobil] Inner Join [tb_pemesanan] On [tb_pemesanan].[kode_mobil] = [tb_mobil].[kode_mobil]) Inner Join [tb_tiket] On [tb_pemesanan].[kode_tiket] = [tb_tiket].[kode_tiket]")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_pemesanan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nm_pembeli") & "</td>")
            html_data.Append("<td class='table-td'>" & row("telpon") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jurusan") & "</td>")
            html_data.Append("<td class='table-td'>" & Convert.ToDateTime(row("tgl_transaksi")).ToString("dd-MM-yyyy") & "</td>")
            html_data.Append("<td class='table-td'>" & Convert.ToDateTime(row("tgl_berangkat")).ToString("dd-MM-yyyy") & " " & Convert.ToDateTime(row("jam_berangkat")).ToString("H:m") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_beli") & "</td>")
            html_data.Append("<td class='table-td'>" & row("no_bangku") & "</td>")
            html_data.Append("<td class='table-td'>" & row("total_bayar") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-pemesanan.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_mobil", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub
End Class