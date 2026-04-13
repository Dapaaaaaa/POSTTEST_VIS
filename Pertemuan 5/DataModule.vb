Imports MySqlConnector

Module DataModule

    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeJenis, jenis FROM tb_jenis ORDER BY kodeJenis ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchJenis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeJenis, jenis FROM tb_jenis WHERE kodeJenis LIKE @keyword OR jenis LIKE @keyword ORDER BY kodeJenis ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetJenisByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeJenis, jenis FROM tb_jenis WHERE kodeJenis = @kodeJenis"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kodeJenis", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_jenis WHERE kodeJenis = @kodeJenis"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanJenis(kode As String, namaJenis As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_jenis (kodeJenis, jenis) VALUES (@kodeJenis, @jenis)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    cmd.Parameters.AddWithValue("@jenis", namaJenis)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahJenis(kode As String, namaJenis As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_jenis SET jenis = @jenis WHERE kodeJenis = @kodeJenis"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    cmd.Parameters.AddWithValue("@jenis", namaJenis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusJenis(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_jenis WHERE kodeJenis = @kodeJenis"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllBuku() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tb_buku.kodeBuku, tb_jenis.jenis AS 'Jenis Buku', " &
                                 "tb_buku.judul, tb_buku.pengarang, tb_buku.penerbit, " &
                                 "tb_buku.jumlahBuku, tb_buku.deskripsi " &
                                 "FROM tb_buku " &
                                 "INNER JOIN tb_jenis ON tb_buku.kodeJenis = tb_jenis.kodeJenis " &
                                 "ORDER BY tb_buku.kodeBuku ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchBuku(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tb_buku.kodeBuku, tb_jenis.jenis AS 'Jenis Buku', " &
                                 "tb_buku.judul, tb_buku.pengarang, tb_buku.penerbit, " &
                                 "tb_buku.jumlahBuku, tb_buku.deskripsi " &
                                 "FROM tb_buku " &
                                 "INNER JOIN tb_jenis ON tb_buku.kodeJenis = tb_jenis.kodeJenis " &
                                 "WHERE tb_buku.judul LIKE @keyword OR tb_buku.penerbit LIKE @keyword OR tb_buku.pengarang LIKE @keyword " &
                                 "ORDER BY tb_buku.kodeBuku ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeBukuSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_buku WHERE kodeBuku = @kodeBuku"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeBuku", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanBuku(kode As String, kodeJenis As String, judul As String, pengarang As String, penerbit As String, jumlah As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_buku (kodeBuku, kodeJenis, judul, pengarang, penerbit, jumlahBuku, deskripsi) " &
                                 "VALUES (@kode, @kodeJenis, @judul, @pengarang, @penerbit, @jumlah, @deskripsi)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeJenis", kodeJenis)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@pengarang", pengarang)
                    cmd.Parameters.AddWithValue("@penerbit", penerbit)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahBuku(kode As String, kodeJenis As String, judul As String, pengarang As String, penerbit As String, jumlah As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_buku SET kodeJenis = @kodeJenis, judul = @judul, " &
                                 "pengarang = @pengarang, penerbit = @penerbit, " &
                                 "jumlahBuku = @jumlah, deskripsi = @deskripsi " &
                                 "WHERE kodeBuku = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeJenis", kodeJenis)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@pengarang", pengarang)
                    cmd.Parameters.AddWithValue("@penerbit", penerbit)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusBuku(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_buku WHERE kodeBuku = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetBukuByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_buku WHERE kodeBuku = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module