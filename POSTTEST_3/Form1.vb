Public Class Form1

    'Buat Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Pilih Foto"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    'Validasi Nama hanya huruf dan spasi
    Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse
                e.KeyChar = " "c OrElse
                e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Nama hanya boleh diisi huruf!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Validasi Umur hanya angka
    Private Sub tbUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUmur.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Umur hanya boleh diisi angka!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Validasi Nomor Telepon hanya angka

    Private Sub tbNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNoTelp.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Nomor telepon hanya boleh diisi angka!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Validasi Alamat hanya huruf, angka, spasi, dan beberapa karakter umum
    Private Sub btnCK_Click(sender As Object, e As EventArgs) Handles btnCK.Click

        'Validasi Foto
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan upload Foto Profil.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validasi Nama 
        If String.IsNullOrWhiteSpace(tbNama.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan isi Nama Lengkap.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNama.Focus()
            Return
        End If

        'Validasi Umur
        If String.IsNullOrWhiteSpace(tbUmur.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan isi Umur.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUmur.Focus()
            Return
        End If

        '4. Validasi Nomor Telepon
        If String.IsNullOrWhiteSpace(tbNoTelp.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan isi Nomor Telepon.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNoTelp.Focus()
            Return
        End If

        '5. Validasi Alamat
        If String.IsNullOrWhiteSpace(tbAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan isi Alamat.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbAlamat.Focus()
            Return
        End If

        '6. Validasi Jenis Kelamin
        If Not RBLaki.Checked AndAlso Not RBPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan pilih Jenis Kelamin.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        '7. Validasi Hobby (minimal 1 dicentang)
        Dim adaHobby As Boolean = CheckBoxGaming.Checked OrElse
                                  CheckBoxOlahraga.Checked OrElse
                                  CheckBoxNgevlog.Checked OrElse
                                  CheckBoxMemasak.Checked OrElse
                                  CheckBoxMancing.Checked OrElse
                                  CheckBoxTravelling.Checked OrElse
                                  CheckBoxMenyanyi.Checked OrElse
                                  CheckBoxNgoding.Checked OrElse
                                  CheckBoxMenari.Checked OrElse
                                  CheckBoxKuliner.Checked

        If Not adaHobby Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbNewLine & "Silakan pilih minimal 1 Hobby.",
                            "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Jika semua validasi lolos, lanjutkan ke Form2
        Dim hobbyList As New List(Of String)
        If CheckBoxGaming.Checked Then hobbyList.Add("Gaming")
        If CheckBoxOlahraga.Checked Then hobbyList.Add("Olahraga")
        If CheckBoxNgevlog.Checked Then hobbyList.Add("Ngevlog")
        If CheckBoxMemasak.Checked Then hobbyList.Add("Memasak")
        If CheckBoxMancing.Checked Then hobbyList.Add("Mancing")
        If CheckBoxTravelling.Checked Then hobbyList.Add("Travelling")
        If CheckBoxMenyanyi.Checked Then hobbyList.Add("Menyanyi")
        If CheckBoxNgoding.Checked Then hobbyList.Add("Ngoding")
        If CheckBoxMenari.Checked Then hobbyList.Add("Menari")
        If CheckBoxKuliner.Checked Then hobbyList.Add("Kuliner")

        Dim hobby As String = String.Join(", ", hobbyList)
        Dim jenisKelamin As String = If(RBLaki.Checked, "Laki-laki", "Perempuan")

        Dim f2 As New Form2()
        f2.SetData(
            tbNama.Text.Trim(),
            tbUmur.Text.Trim(),
            DateTimePicker1.Value.ToString("dd MMMM yyyy"),
            tbNoTelp.Text.Trim(),
            tbAlamat.Text.Trim(),
            jenisKelamin,
            hobby,
            PictureBox1.Image
        )
        f2.Show()
    End Sub

End Class