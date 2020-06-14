Public Class Aplikasi
    Public Db As New Db()
    Public id_pengguna As String
    Public level As String
    Public nama_lengkap As String
    Public username As String
    Public url_laporan As String = Application.StartupPath & "\"
    Public Sub TutupForm(ByVal form As Form)
        FMenu_Utama.Show()
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
        cek_login = Db.JalankanDanAmbilData("SELECT * FROM tb_pengguna WHERE username = '" & username & "' AND password = '" & password & "'")
        If Db.ApakahError Then
            MessageBox.Show("Error : " & Db.AmbilPesanError)
            Return
        End If
        If cek_login.Rows.Count = 0 Then
            MessageBox.Show("Username atau password salah!", "Peringatan")
        Else
            Me.username = username
            Me.level = cek_login.Rows(0).Item("jenis_level")
            Me.nama_lengkap = cek_login.Rows(0).Item("nama_lengkap")
            Me.id_pengguna = cek_login.Rows(0).Item("id_pengguna")
            MessageBox.Show("Selamat datang, " & username, "Pesan")
            Me.Hide()
            FMenu_Utama.Show()
        End If
        ResetLogin()
    End Sub

    Public Function GenerateKode(ByVal tabel As String, ByVal kolom As String, ByVal prefix As String)
        Dim no_nota As String
        Dim nomor As DataTable = Db.JalankanDanAmbilData("SELECT TOP 1 " & kolom & " AS kode FROM " & tabel & " ORDER BY " & kolom & " DESC")
        If Db.ApakahError Then
            MessageBox.Show(Db.AmbilPesanError)
            Return ""
        Else
            If nomor.Rows.Count = 0 Then
                no_nota = prefix & "000001"
            Else
                Dim no_nota_tmp As Integer = Val(nomor.Rows(0).Item("kode").ToString().Substring(6)) + 1
                no_nota = prefix & no_nota_tmp.ToString.PadLeft(6, "0")
            End If
            Return no_nota
        End If

    End Function

    Private Sub Aplikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class