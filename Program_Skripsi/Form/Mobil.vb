Public Class FMobil
    Dim kode_mobil As String
    Dim no_polisi As String
    Dim jenis As String
    Dim merk As String
    Dim warna As String
    Dim bahan_bakar As String
    Private Sub AturData()
        kode_mobil = Tkode_mobil.Text
        no_polisi = Tno_polisi.Text
        jenis = Tjenis.Text
        merk = Tmerk.Text
        warna = Twarna.Text
        bahan_bakar = Tbahan_bakar.Text
    End Sub
    Private Sub ResetForm(sender As Object, e As EventArgs) Handles Bbatal.Click
        Tkode_mobil.Clear()
        Tno_polisi.Clear()
        Tbahan_bakar.Clear()
        Tjenis.Clear()
        Tmerk.Clear()
        Twarna.Clear()
        Tkode_mobil.ReadOnly = False
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        Dim sql As String = "Select * FROM tb_mobil"

        If kata_kunci <> "" Then
            sql += " WHERE kode_mobil LIKE '%" & kata_kunci & "%' OR no_polisi LIKE '%" & kata_kunci & "%' OR merk LIKE '%" & kata_kunci & "%' OR bahan_bakar LIKE '%" & kata_kunci & "%'"
        End If
        DGmobil.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub
    Private Function CekKodeMobil()
        Dim data As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM tb_mobil WHERE kode_mobil = '" & kode_mobil & "'")
        If data.Rows.Count > 0 Then
            Return False
        Else Return True
        End If
    End Function
    Private Sub AmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGmobil.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGmobil.CurrentRow
        Tkode_mobil.Text = data_terpilih.Cells("kode_mobil").Value
        Tno_polisi.Text = data_terpilih.Cells("no_polisi").Value
        Tjenis.Text = data_terpilih.Cells("jenis").Value
        Tmerk.Text = data_terpilih.Cells("merk").Value
        Twarna.Text = data_terpilih.Cells("warna").Value
        Tbahan_bakar.Text = data_terpilih.Cells("bahan_bakar").Value
        Tkode_mobil.ReadOnly = True
    End Sub
    Private Sub ProsesTambahData(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        If CekKodeMobil() = False Then
            MessageBox.Show("Kode mobil sudah ada! Silahkan pilih kode mobil lain.")
            Tkode_mobil.Clear()
            Return
        End If
        Aplikasi.Db.JalankanSql("INSERT INTO tb_mobil VALUES ('" & kode_mobil & "', '" & no_polisi & "', '" & jenis & "', '" & merk & "', '" & warna & "', '" & bahan_bakar & "')")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil ditambahkan!")
            Bbatal.PerformClick()
            TampilkanData()
        End If
    End Sub
    Private Sub ProsesEditData(sender As Object, e As EventArgs) Handles Bedit.Click
        Me.AturData()
        Aplikasi.Db.JalankanSql("UPDATE tb_mobil SET no_polisi = '" & no_polisi & "', jenis = '" & jenis & "',merk = '" & merk & "', warna = '" & warna & "',bahan_bakar = '" & bahan_bakar & "' WHERE kode_mobil = '" & kode_mobil & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil diedit!")
            Bbatal.PerformClick()
            TampilkanData()
        End If
    End Sub
    Private Sub ProsesHapusData(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim kode_mobil = DGmobil.CurrentRow.Cells("kode_mobil").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tb_mobil WHERE kode_mobil = '" & kode_mobil & "'")
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

    Private Sub EventPencarian(sender As Object, e As KeyEventArgs) Handles Tcari.KeyUp
        TampilkanData(Tcari.Text)
    End Sub
End Class