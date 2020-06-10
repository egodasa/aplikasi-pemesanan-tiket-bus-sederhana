Imports MySql.Data.MySqlClient
Public Class Db
    Private ReadOnly url_koneksi As String = "server=localhost;user=root;database=db_bus;port=3306;password=mysql;"
    Private koneksi As New MySqlConnection
    Private is_error As Boolean ' jika ada koneksi atau proses query error, maka nilai is error akan bernilai false
    Private pesan_error As String = Nothing ' semua pesan error akan dimasukkan ke variabel ini
    ' jika koneksi berhasil, maka method ini menghasilkan nilai true
    Public Sub New(Optional ByVal url_koneksi As String = Nothing)
        If IsNothing(url_koneksi) = False Then
            Me.url_koneksi = url_koneksi
        End If
    End Sub
    Private Sub ResetError()
        is_error = False
        pesan_error = Nothing
    End Sub
    Public Function ApakahError()
        Return is_error
    End Function
    Public Function AmbilPesanError()
        Return pesan_error
    End Function
    Public Function BuatKoneksi()
        ResetError()
        ' Informasi yang digunakan untuk terhubung ke database
        koneksi = New MySqlConnection(url_koneksi) ' variabel yang menampung koneksi ke database
        If koneksi.State = ConnectionState.Closed Then
            Try
                Console.WriteLine("Mencoba terhubung ke database")
                koneksi.Open() ' membuka koneksi ke mysql
            Catch ex As Exception
                Console.WriteLine(ex.ToString()) ' jika gagal terhubung, maka tampilkan pesan error di console
                is_error = True
                pesan_error = ex.ToString()
            End Try
        End If
        Console.WriteLine("Berhasil terhubung")
        Return Not is_error
    End Function
    Public Sub TutupKoneksi() ' fungsi untuk menutup koneksi
        If koneksi.State = ConnectionState.Open Then
            Console.WriteLine("Koneksi ditutup")
            koneksi.Close()
        End If
    End Sub
    Public Function JalankanSql(ByVal sql As String) ' fungsi untuk menjalankan query sql. hanya menjalankan saja
        ResetError()
        If BuatKoneksi() Then
            Dim cmd As New MySqlCommand
            Try
                cmd = New MySqlCommand(sql, koneksi)
                cmd.Connection = koneksi
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                pesan_error = "Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message
                is_error = True
            Finally
                TutupKoneksi()
            End Try
        End If
        Return Me
    End Function
    ' fungsi untuk menjalankan query select dan mengembalikan data berupa dataset
    Public Function JalankanDanAmbilData(ByVal sql As String)
        ResetError()
        If BuatKoneksi() Then
            Try
                Dim da = New MySqlDataAdapter(sql, koneksi)
                Dim ds = New DataSet
                da.Fill(ds)
                TutupKoneksi()
                Return ds.Tables(0)
            Catch ex As Exception
                pesan_error = "Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message
                is_error = True
            End Try
        End If
        Return Nothing
    End Function
End Class
