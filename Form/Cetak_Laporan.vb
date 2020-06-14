Public Class Cetak_Laporan
    Public url As String
    Public Sub AmbilDataLaporan()
        WBcetak.Navigate(url)
    End Sub
    Public Sub CetakLaporan()
        WBcetak.ShowPrintPreviewDialog()
    End Sub

    Private Sub Keluar(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub AksiCetak(sender As Object, e As EventArgs) Handles Button2.Click
        CetakLaporan()
    End Sub

    Private Sub AksiMuatUlang(sender As Object, e As EventArgs) Handles Button1.Click
        AmbilDataLaporan()
    End Sub

    Private Sub BukaForm(sender As Object, e As EventArgs) Handles MyBase.Load
        AmbilDataLaporan()
        Console.WriteLine(url)
    End Sub
End Class