Public Class Form1
    Function cariBuku(ByVal judul As String) As Integer
        Dim i As Integer
        For i = 0 To jumlahBuku - 1
            If judulBuku(i) = judul Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub tampilkanBuku()
        listBuku.Items.Clear()
        Dim i As Integer
        For i = 0 To jumlahBuku - 1
            listBuku.Items.Add(judulBuku(i) & " (" & genreBuku(i) & ")")
        Next
    End Sub

    Public Sub tambahBuku(ByVal judul As String, ByVal genre As String)
        judulBuku(jumlahBuku) = judul.Trim
        genreBuku(jumlahBuku) = genre.Trim

        jumlahBuku += 1
    End Sub

    Public Sub hapusBuku(ByVal judul As String)

        Dim index As Integer = cariBuku(judul)

        If index <> -1 Then
            For i = index To jumlahBuku - 2
                judulBuku(i) = judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next
            jumlahBuku -= 1
        End If

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = tbJudulBuku.Text.Trim
        Dim genre As String = tbGenreBuku.Text.Trim

        tambahBuku(judul, genre)
        tampilkanBuku()

        tbJudulBuku.Clear()
        tbGenreBuku.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = tbJudulHapusBuku.Text.Trim
        hapusBuku(judul)
        tampilkanBuku()
        tbJudulBuku.Clear()
        tbGenreBuku.Clear()
    End Sub

End Class
