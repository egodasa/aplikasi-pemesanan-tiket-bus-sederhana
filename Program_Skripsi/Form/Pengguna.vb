Public Class FPengguna
    Dim username As String
    Dim password As String
    Dim nama_lengkap As String
    Dim level As String
    Dim id_pengguna As String
    Private Sub AturData()
        username = Tusername.Text
        password = Tpassword.Text
        nama_lengkap = Tnama_lengkap.Text
        level = Clevel.Text
    End Sub
    Private Sub ResetForm(sender As Object, e As EventArgs) Handles Bbatal.Click
        Tusername.Clear()
        Tpassword.Clear()
        Tnama_lengkap.Clear()
        Clevel.SelectedIndex = -1
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        DGpengguna.DataSource = Aplikasi.Db.JalankanDanAmbilData("SELECT id_pengguna, username, nama_lengkap, level FROM tb_pengguna")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show(Aplikasi.Db.AmbilPesanError)
        End If
    End Sub

    Private Sub AmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGpengguna.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGpengguna.CurrentRow
        id_pengguna = data_terpilih.Cells("id_pengguna").Value
        Tusername.Text = data_terpilih.Cells("username").Value
        Tnama_lengkap.Text = data_terpilih.Cells("nama_lengkap").Value
        Clevel.Text = data_terpilih.Cells("level").Value
    End Sub
    Private Sub ProsesTambahData(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        Aplikasi.Db.JalankanSql("INSERT INTO tb_pengguna (username, password, nama_lengkap, level) VALUES ('" & username & "', '" & password & "', '" & nama_lengkap & "', '" & level & "')")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil ditambahkan!")
            TampilkanData()
            Bbatal.PerformClick()
        End If
    End Sub
    Private Sub ProsesEditData(sender As Object, e As EventArgs) Handles Bedit.Click
        Me.AturData()
        If password <> "" Then
            Aplikasi.Db.JalankanSql("UPDATE tb_pengguna SET username = '" & username & "', password = '" & password & "', nama_lengkap = '" & nama_lengkap & "', level = '" & level & "' WHERE id_pengguna = '" & id_pengguna & "'")
        Else
            Aplikasi.Db.JalankanSql("UPDATE tb_pengguna SET username = '" & username & "', nama_lengkap = '" & nama_lengkap & "', level = '" & level & "' WHERE id_pengguna = '" & id_pengguna & "'")
        End If
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil diedit!")
            TampilkanData()
            Bbatal.PerformClick()
        End If
    End Sub
    Private Sub ProsesHapusData(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim kode = DGpengguna.CurrentRow.Cells("id_pengguna").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tb_pengguna WHERE id_pengguna = '" & kode & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil dihapus!")
            TampilkanData()
        End If
    End Sub
    Private Sub Tutup(sender As Object, e As EventArgs) Handles Btutup.Click
        Aplikasi.TutupForm(Me)
    End Sub

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Bbatal.PerformClick()
        TampilkanData()
    End Sub
End Class