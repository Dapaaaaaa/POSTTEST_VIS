Imports MySqlConnector
Module DataModule
    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeJenis, jenis FROM

tbjenis ORDER BY kodeJenis ASC"

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
    Public Function SearchJenis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
"SELECT kodeJenis, jenis FROM tbjenis " & "WHERE
kodeJenis LIKE @keyword OR jenis LIKE @keyword " & "ORDER BY
kodeJenis ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword &
"%")

                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt
    End Function
    Public Function GetJenisByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeJenis, jenis FROM

tbjenis WHERE kodeJenis = @kodeJenis"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kodeJenis", kode)

                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt
    End Function
    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbjenis WHERE

kodeJenis = @kodeJenis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    Dim jumlah As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return True
        End Try
    End Function
    Public Function SimpanJenis(kode As String, namaJenis As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbjenis (kodeJenis,

jenis) VALUES (@kodeJenis, @jenis)"

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
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End Try
    End Function
    Public Function UbahJenis(kode As String, namaJenis As String) As Boolean
        Try
            Dim query As String = "UPDATE tbjenis SET jenis = @jenis

WHERE kodeJenis = @kodeJenis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
                    cmd.Parameters.AddWithValue("@jenis", namaJenis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End Try
    End Function
    Public Function HapusJenis(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbjenis WHERE
                                   kodeJenis = @kodeJenis"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeJenis", kode)
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