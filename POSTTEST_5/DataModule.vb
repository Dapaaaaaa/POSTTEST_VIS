Imports MySqlConnector
Imports System.Data

Module DataModule

    ' ─── READ ALL ───────────────────────────────────────────────────────────────

    Public Function GetAllMenu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id_menu, nama_menu, kategori_menu, harga_menu, stok_menu, deskripsi_menu
                 FROM tb_menu ORDER BY kategori_menu, nama_menu ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ─── SEARCH ─────────────────────────────────────────────────────────────────

    Public Function SearchMenu(keyword As String, kategori_menu As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id_menu, nama_menu, kategori_menu, harga_menu, stok_menu, deskripsi_menu
                 FROM tb_menu WHERE
                 (id_menu LIKE @keyword OR nama_menu LIKE @keyword OR deskripsi_menu LIKE @keyword)"

            If kategori_menu <> "Semua" Then
                query &= " AND kategori_menu = @kategori_menu"
            End If

            query &= " ORDER BY kategori_menu, nama_menu ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    If kategori_menu <> "Semua" Then
                        da.SelectCommand.Parameters.AddWithValue("@kategori_menu", kategori_menu)
                    End If
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ─── GET BY KODE ────────────────────────────────────────────────────────────

    Public Function GetMenuByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id_menu, nama_menu, kategori_menu, harga_menu, stok_menu, deskripsi_menu
                 FROM tb_menu WHERE id_menu = @id_menu"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id_menu", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ─── CEK KODE SUDAH ADA ─────────────────────────────────────────────────────

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_menu WHERE id_menu = @id_menu"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_menu", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    ' ─── CREATE ─────────────────────────────────────────────────────────────────

    Public Function SimpanMenu(kode As String, nama_menu As String, kategori_menu As String,
                                harga_menu As Decimal, stok_menu As Integer, deskripsi_menu As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_menu (id_menu, nama_menu, kategori_menu, harga_menu, stok_menu, deskripsi_menu)
                 VALUES (@kode, @nama_menu, @kategori_menu, @harga_menu, @stok_menu, @deskripsi_menu)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama_menu", nama_menu)
                    cmd.Parameters.AddWithValue("@kategori_menu", kategori_menu)
                    cmd.Parameters.AddWithValue("@harga_menu", harga_menu)
                    cmd.Parameters.AddWithValue("@stok_menu", stok_menu)
                    cmd.Parameters.AddWithValue("@deskripsi_menu", deskripsi_menu)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ─── UPDATE ─────────────────────────────────────────────────────────────────

    Public Function UbahMenu(kode As String, nama_menu As String, kategori_menu As String,
                              harga_menu As Decimal, stok_menu As Integer, deskripsi_menu As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_menu SET nama_menu=@nama_menu, kategori_menu=@kategori_menu,
                 harga_menu=@harga_menu, stok_menu=@stok_menu, deskripsi_menu=@deskripsi_menu
                 WHERE id_menu = @kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama_menu", nama_menu)
                    cmd.Parameters.AddWithValue("@kategori_menu", kategori_menu)
                    cmd.Parameters.AddWithValue("@harga_menu", harga_menu)
                    cmd.Parameters.AddWithValue("@stok_menu", stok_menu)
                    cmd.Parameters.AddWithValue("@deskripsi_menu", deskripsi_menu)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ─── DELETE ─────────────────────────────────────────────────────────────────

    Public Function HapusMenu(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_menu WHERE id_menu = @id_menu"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_menu", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module