Public Class Form2
    ' Untuk menampilkan data yang diterima dari Form1
    ' Dengan catatan wajib berurutan sesuai data yang dikirim dari Form1
    Public Sub TampilkanData(nama As String, id As String, divisi As String,
                            kontak As String, minat As String, foto As Image)

        lblNamaValue.Text = nama
        lblIdValue.Text = id
        lblDivisiValue.Text = divisi
        lblKontakValue.Text = kontak
        lblMinatValue.Text = minat
        pbHasil.Image = foto

    End Sub

End Class