Public Class Bus
    Dim kd_domain As String
    Dim nm_domain As String
    Private Sub AturData()
        kd_domain = Tkode_tiket.Text
        nm_domain = Tjurusan.Text
    End Sub
    Private Sub ResetForm(sender As Object, e As EventArgs) Handles Bbatal.Click
        Tkode_tiket.Clear()
        Tjurusan.Clear()
        Tkode_tiket.ReadOnly = False
    End Sub

    Private Sub TampilkanData(Optional ByVal kata_kunci As String = "")
        Dim sql As String = "Select * FROM tbl_domain"

        If kata_kunci <> "" Then
            sql += " WHERE kd_domain LIKE '%" & kata_kunci & "%' OR nm_domain LIKE '%" & kata_kunci & "%' OR no_urut LIKE '%" & kata_kunci & "%'"
        End If
        DGtiket.DataSource = Aplikasi.Db.JalankanDanAmbilData(sql)
    End Sub
    Private Function CekKodeDomain()
        Dim data As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM tbl_domain WHERE kd_domain = '" & kd_domain & "'")
        If data.Rows.Count > 0 Then
            Return False
        Else Return True
        End If
    End Function
    Private Sub AmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGtiket.CellContentDoubleClick
        Dim data_terpilih As DataGridViewRow = DGtiket.CurrentRow
        Tkode_tiket.Text = data_terpilih.Cells("kd_domain").Value
        Tjurusan.Text = data_terpilih.Cells("nm_domain").Value
        Tkode_tiket.ReadOnly = True
    End Sub
    Private Sub ProsesTambahData(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Me.AturData()
        If CekKodeDomain() = False Then
            MessageBox.Show("Kode domain sudah ada!Silahkan pilih kode domain lain.")
            Tkode_tiket.Clear()
            Return
        End If
        Aplikasi.Db.JalankanSql("INSERT INTO tbl_domain VALUES ('" & kd_domain & "', '" & nm_domain & "')")
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
        Aplikasi.Db.JalankanSql("UPDATE tbl_domain SET nm_domain = '" & nm_domain & "' WHERE kd_domain = '" & kd_domain & "'")
        If Aplikasi.Db.ApakahError() Then
            MessageBox.Show("Error :" & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data berhasil diedit!")
            Bbatal.PerformClick()
            TampilkanData()
        End If
    End Sub
    Private Sub ProsesHapusData(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim kd_domain = DGtiket.CurrentRow.Cells("kd_domain").Value
        Aplikasi.Db.JalankanSql("DELETE FROM tbl_domain WHERE kd_domain = '" & kd_domain & "'")
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