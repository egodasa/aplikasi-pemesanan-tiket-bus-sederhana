Public Class FTiket
    Dim kode_tiket As String
    Dim jurusan As String
    Dim jumlah_bus As String
    Dim kelas As String
    Dim harga As String
    Dim jumlah_tiket As String
    Private Sub AturData()
        kode_tiket = Tkode_tiket.Text
        jurusan = Tjurusan.Text
        jumlah_bus = Tjumlah_bus.Text
        kelas = Tkelas.Text
        harga = Tharga.Text
        jumlah_tiket = Tjumlah_tiket.Text
    End Sub
    Private Sub ResetForm(ByVal sender As Object, ByVal e As EventArgs) Handles Bbatal.Click
        Tkode_tiket.Text = Aplikasi.GenerateKode("tb_tiket", "kode_tiket", "TKT")
        Tjurusan.Clear()
        Tjumlah_tiket.Clear()
        Tjumlah_bus.Clear()
        Tkelas.Clear()
        Tharga.Clear()
        Tkode_tiket.ReadOnly = False
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        Dim sql As String = "Select * FROM tb_tiket"

        If kata_kunci <> "" Then
            sql += " WHERE kode_tiket LIKE '%" & kata_kunci & "%' OR jurusan LIKE '%" & kata_kunci & "%' OR kelas LIKE '%" & kata_kunci & "%'"
        End If
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show(Aplikasi.Db.AmbilPesanError)
        End If
        DGtiket.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub
    Private Function CekKodeTiket()
        Dim data As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM tb_tiket WHERE kode_tiket = '" & kode_tiket & "'")
        If data.Rows.Count > 0 Then
            Return False
        Else : Return True
        End If
    End Function
    Private Sub ProsesTambahData(ByVal sender As Object, ByVal e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        If CekKodeTiket() = False Then
            MessageBox.Show("Kode tiket sudah ada! Silahkan pilih kode tiket lain.")
            Tkode_tiket.Clear()
            Return
        End If
        Aplikasi.Db.JalankanSql("INSERT INTO tb_tiket VALUES ('" & kode_tiket & "', '" & jurusan & "', '" & kelas & "', " & harga & ", " & jumlah_bus & ", " & jumlah_tiket & ")")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil ditambahkan!")
            Bbatal.PerformClick()
            TampilkanData()
        End If
    End Sub
    Private Sub ProsesEditData(ByVal sender As Object, ByVal e As EventArgs) Handles Bedit.Click
        Me.AturData()
        Aplikasi.Db.JalankanSql("UPDATE tb_tiket SET jurusan = '" & jurusan & "', jumlah_bus = " & jumlah_bus & ",kelas = '" & kelas & "', harga = " & harga & ",jumlah_tiket = " & jumlah_tiket & " WHERE kode_tiket = '" & kode_tiket & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil diedit!")
            Bbatal.PerformClick()
            TampilkanData()
        End If
    End Sub
    Private Sub ProsesHapusData(ByVal sender As Object, ByVal e As EventArgs) Handles Bhapus.Click
        Dim kode_tiket = DGtiket.CurrentRow.Cells("kode_tiket").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tb_tiket WHERE kode_tiket = '" & kode_tiket & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil dihapus!")
            TampilkanData()
        End If
    End Sub
    Private Sub Tutup(ByVal sender As Object, ByVal e As EventArgs) Handles Btutup.Click
        Aplikasi.TutupForm(Me)
    End Sub
    Private Sub LoadForm(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Bbatal.PerformClick()
        TampilkanData()
    End Sub

    Private Sub EventPencarian(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tcari.KeyUp
        TampilkanData(Tcari.Text)
    End Sub

    Private Sub EventAmbilDetailData(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGtiket.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGtiket.CurrentRow
        Tkode_tiket.Text = data_terpilih.Cells("kode_tiket").Value
        Tjurusan.Text = data_terpilih.Cells("jurusan").Value
        Tjumlah_bus.Text = data_terpilih.Cells("jumlah_bus").Value
        Tkelas.Text = data_terpilih.Cells("kelas").Value
        Tharga.Text = data_terpilih.Cells("harga").Value
        Tjumlah_tiket.Text = data_terpilih.Cells("jumlah_tiket").Value
        Tkode_tiket.ReadOnly = True
    End Sub
End Class