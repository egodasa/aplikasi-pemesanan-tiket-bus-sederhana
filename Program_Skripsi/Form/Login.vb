Public Class Aplikasi
    Public Db As New Db()
    Public level As String
    Public username As String
    Public url_laporan As String = "http://localhost/laporan_program_cobit/"
    Public Sub TutupForm(ByVal form As Form)
        Menu_Utama.Show()
        form.Close()
    End Sub
    Private Sub Keluar(sender As Object, e As EventArgs) Handles Breset.Click
        Db.TutupKoneksi()
        Me.Close()
    End Sub

    Private Sub ResetLogin()
        Tusername.Clear()
        Tpassword.Clear()
    End Sub

    Private Sub Login(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Dim username As String = Tusername.Text
        Dim password As String = Tpassword.Text
        Dim cek_login As New DataTable
        cek_login = Db.JalankanDanAmbilData("SELECT * FROM tbl_user WHERE username = '" & username & "' AND password = md5('" & password & "')")
        If Db.ApakahError Then
            MessageBox.Show("Error : " & Db.AmbilPesanError)
            Return
        End If
        If cek_login.Rows.Count = 0 Then
            MessageBox.Show("Username atau password salah!", "Peringatan")
        Else
            Me.username = username
            MessageBox.Show("Selamat datang, " & username, "Pesan")
            Me.Hide()
            Menu_Utama.Show()
        End If
        ResetLogin()
    End Sub

    Public Function GenerateKode(ByVal tabel As String, ByVal kolom As String, ByVal prefix As String)
        Dim no_nota As String
        Dim nomor As DataTable = Db.JalankanDanAmbilData("SELECT CONCAT('" & prefix & "', LPAD((right(" & kolom & ", 6) + 1), 6, '0')) AS kode FROM `" & tabel & "` ORDER BY `" & kolom & "` DESC LIMIT 1")
        If nomor.Rows.Count = 0 Then
            no_nota = prefix & "000001"
        Else
            no_nota = nomor.Rows(0).Item("kode")
        End If
        Return no_nota
    End Function

    Private Sub Aplikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        IsiKuisioner.Show()
        Me.Hide()
    End Sub
End Class