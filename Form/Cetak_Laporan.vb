Imports DotLiquid
Public Class Cetak_Laporan
    Public url As String
    Public data As Hash
    Public Sub AmbilDataLaporan()
        Dim template As Template = template.Parse(url)
        Dim result As String = template.Render(data)
        WBcetak.DocumentText = System.IO.File.ReadAllText(url)
    End Sub

    Public Sub CetakLaporan()
        WBcetak.ShowPrintPreviewDialog()
    End Sub

    Private Sub Keluar(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub AksiCetak(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        CetakLaporan()
    End Sub

    Private Sub AksiMuatUlang(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        AmbilDataLaporan()
    End Sub

    Private Sub BukaForm(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AmbilDataLaporan()
    End Sub
End Class