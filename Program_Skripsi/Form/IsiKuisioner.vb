Public Class IsiKuisioner
    Private Sub ResetForm()
        Tnm.Clear()
        Tusia.Value = 0
        Cjk.SelectedIndex = -1
        DGkuisioner.DataSource = Nothing
    End Sub
    Private Sub TampilKuisioner()
        Dim data_kuisioner As DataTable = Aplikasi.Db.JalankanDanAmbilData("select tbl_pernyataan.*, tbl_domain.nm_domain from tbl_pernyataan join tbl_domain on tbl_pernyataan.kd_domain = tbl_domain.kd_domain ORDER BY tbl_domain.kd_domain ASC")
        DGkuisioner.DataSource = Nothing
        For i = 0 To (data_kuisioner.Rows.Count - 1)
            DGkuisioner.Rows.Add(data_kuisioner.Rows(i).Item("id_pernyataan"), data_kuisioner.Rows(i).Item("isi_pernyataan"), data_kuisioner.Rows(i).Item("nm_domain"), "-", "-", "-", "-", "-")
        Next
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilKuisioner()
        With DGkuisioner
            .RowTemplate.MinimumHeight = 100
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        End With

        For i = 3 To 7
            With DGkuisioner.Columns(i)
                .DefaultCellStyle.BackColor = Color.Blue
            End With
        Next


    End Sub

    Private Sub DGkuisioner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGkuisioner.CellClick
        If e.ColumnIndex > 2 Then
            For i = 3 To 7
                With DGkuisioner.Rows(e.RowIndex).Cells(i)
                    .Value = "-"
                    .Style.BackColor = Color.Blue
                End With
            Next
            With DGkuisioner.Rows(e.RowIndex).Cells(e.ColumnIndex)
                .Value = "X"
                .Style.BackColor = Color.Yellow
            End With
        End If
    End Sub

    Private Sub SimpanKuisioner(sender As Object, e As EventArgs) Handles Bsimpan.Click
        If CekDataDiri() Then
            If CekKuisioner() Then
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengirim kuisioner? Pastikan semua pernyataan sudah diisi", "Peringatan!", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    ' Simpan data diri kuisioner terlebih dahulu
                    Aplikasi.Db.JalankanSql("INSERT INTO tbl_kuesioner (nm_responden, usia_responden, jk_responden, tanggal) VALUES ('" & Tnm.Text & "', '" & Cusia.Text & "', '" & Cjk.Text & "', CURDATE())")
                    If Aplikasi.Db.ApakahError Then
                        MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
                        Return
                    End If

                    Dim id_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT LAST_INSERT_ID() AS id")
                    Dim id As String = id_tmp.Rows(0).Item("id")

                    ' simpan isi kuisioner
                    For i = 0 To (DGkuisioner.Rows.Count - 1)
                        Dim nilai As Integer
                        For k = 3 To 7
                            If DGkuisioner.Rows(i).Cells(k).Value.ToString() = "X" Then
                                nilai = k - 2
                                Aplikasi.Db.JalankanSql("INSERT INTO tbl_jawaban_kuesioner (id_kuesioner, skor, id_pernyataan) VALUES ('" & id & "', '" & nilai & "', '" & DGkuisioner.Rows(i).Cells(0).Value & "')")
                                If Aplikasi.Db.ApakahError Then
                                    MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
                                    Return
                                End If
                                Exit For
                            End If
                        Next
                    Next
                    MessageBox.Show("Data kuisioner Anda sudah disimpan. Terima kasih.")
                    Aplikasi.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Masih ada pernyataan yang belum diisi!")
            End If
        Else
            MessageBox.Show("Silahkan isi data diri terlebih dahulu!")
        End If
    End Sub

    Private Function CekDataDiri()
        Return Tnm.Text <> "" And Cusia.Text <> "" And Cjk.Text <> ""
    End Function

    Private Function CekKuisioner()
        Dim hasil As Boolean
        For i = 0 To (DGkuisioner.Rows.Count - 1)
            hasil = False
            For k = 3 To 7
                If DGkuisioner.Rows(i).Cells(k).Value.ToString() = "X" Then
                    hasil = True
                    Exit For
                End If
            Next
            If hasil = False Then
                Return hasil
            End If
        Next
        Return hasil
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup kuisioner? Jawaban yang sudah diisi tidak akan disimpan.", "Peringatan!", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Aplikasi.Show()
            Me.Close()
        End If
    End Sub

End Class
