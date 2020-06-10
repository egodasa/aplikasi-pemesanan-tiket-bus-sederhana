Public Class Pengguna
    Dim username As String
    Dim password As String
    Dim email As String
    Dim id_user As String
    Private Sub AturData()
        username = Tusername.Text
        password = Tpassword.Text
        email = Tnama_lengkap.Text
    End Sub
    Private Sub ResetForm(sender As Object, e As EventArgs) Handles Bbatal.Click
        Tusername.Clear()
        Tpassword.Clear()
        Tnama_lengkap.Clear()
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        DGpengguna.DataSource = Aplikasi.Db.JalankanDanAmbilData("SELECT id_user, username, email FROM tbl_user")
    End Sub

    Private Sub AmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGpengguna.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGpengguna.CurrentRow
        id_user = data_terpilih.Cells("id_user").Value
        Tusername.Text = data_terpilih.Cells("username").Value
        Tnama_lengkap.Text = data_terpilih.Cells("email").Value
    End Sub
    Private Sub ProsesTambahData(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        Aplikasi.Db.JalankanSql("INSERT INTO tbl_user (username, password, email) VALUES ('" & username & "', MD5('" & password & "'), '" & email & "')")
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
            Aplikasi.Db.JalankanSql("UPDATE tbl_user SET username = '" & username & "', password = MD5('" & password & "'), email = '" & email & "' WHERE id_user = '" & id_user & "'")
        Else
            Aplikasi.Db.JalankanSql("UPDATE tbl_user SET username = '" & username & "', email = '" & email & "' WHERE id_user = '" & id_user & "'")
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
        Dim kode = DGpengguna.CurrentRow.Cells("id_user").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tbl_user WHERE id_user = '" & kode & "'")
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