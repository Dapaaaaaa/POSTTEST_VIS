Public Class Form2

    Public Sub SetData(nama As String, umur As String, tglLahir As String,
                       noTelp As String, alamat As String, jenisKelamin As String,
                       hobby As String, foto As Image)

        ' Isi semua textbox dengan data dari Form1
        tbNama.Text = nama
        tbUmur.Text = umur
        tbJK.Text = jenisKelamin
        tbNoTelp.Text = noTelp
        tbAlamat.Text = alamat
        tbHobby.Text = hobby

        ' Tanggal lahir
        DateTimePicker1.Value = DateTime.Parse(tglLahir)

        ' Foto profil
        If foto IsNot Nothing Then
            PictureBox1.Image = foto
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

End Class