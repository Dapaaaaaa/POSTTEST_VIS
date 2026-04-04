Public Class Form1

    ' Untuk validasi input sebelum menampilkan Form2
    Function ValidasiInput() As Boolean

        Dim valid As Boolean = True

        ' Reset semua error
        ErrorProvider1.Clear()

        ' Nama
        If tbNama.Text = "" Then
            ErrorProvider1.SetError(tbNama, "Nama tidak boleh kosong")
            valid = False
        End If

        ' ID
        If tbIdAnggota.Text = "" Then
            ErrorProvider1.SetError(tbIdAnggota, "ID tidak boleh kosong")
            valid = False
        End If

        ' Email
        If tbEmail.Text = "" Then
            ErrorProvider1.SetError(tbEmail, "Email tidak boleh kosong")
            valid = False
        End If

        ' Alamat
        If tbAlamat.Text = "" Then
            ErrorProvider1.SetError(tbAlamat, "Alamat tidak boleh kosong")
            valid = False
        End If

        ' Telepon
        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format telepon salah")
            valid = False
        End If

        ' Jenis Kelamin
        If Not rbLakilaki.Checked And Not rbPerempuan.Checked Then
            ErrorProvider1.SetError(rbPerempuan, "Pilih jenis kelamin")
            valid = False
        End If

        ' Divisi
        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Pilih divisi")
            valid = False
        End If

        ' Minat (checkbox)
        Dim adaCek As Boolean = False
        For Each ctrl As Control In gbMinatAktivitas.Controls
            If TypeOf ctrl Is CheckBox AndAlso CType(ctrl, CheckBox).Checked Then
                adaCek = True
            End If
        Next

        If Not adaCek Then
            ErrorProvider1.SetError(gbMinatAktivitas, "Pilih minimal 1 minat")
            valid = False
        End If

        Return valid

    End Function

    ' Untuk membatasi input hanya huruf, spasi, dan kontrol (backspace, delete, dll)
    Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Untuk membatasi input hanya angka dan kontrol (backspace, delete, dll)
    Private Sub tbIdAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIdAnggota.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Untuk OpenFileDialog foto dengan filter hanya gambar
    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        ofdFoto.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofdFoto.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(ofdFoto.FileName)
        End If
    End Sub

    ' Ambil minat dari checkbox yang dicentang
    Function AmbilMinat() As String
        Dim hasil As String = ""

        For Each ctrl As Control In gbMinatAktivitas.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hasil &= ctrl.Text & ", "
                End If
            End If
        Next

        Return hasil
    End Function

    ' Tombol Cetak untuk menampilkan Form2 dengan data yang diinput
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not ValidasiInput() Then Exit Sub

        Dim konfirmasi = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then

            Dim f2 As New Form2

            f2.TampilkanData(
                tbNama.Text,
                tbIdAnggota.Text,
                ComboBox1.Text,
                mtbTelepon.Text,
                AmbilMinat(),
                pbProfil.Image
            )

            f2.Show()

        End If

    End Sub

    ' Untuk menustrip untuk Input Data dan Lihat Kartu
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = tpDataUtama
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        TabControl1.SelectedTab = tpProfilAktivitas
    End Sub

    ' Menu untuk menyimpan data ke file teks dan membuka data dari file teks
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click

        If sfdSimpan.ShowDialog() = DialogResult.OK Then

            Dim jk As String = ""
            If rbLakilaki.Checked Then
                jk = "Laki-laki"
            ElseIf rbPerempuan.Checked Then
                jk = "Perempuan"
            End If

            Dim peran As String = ""
            If rbKetua.Checked Then peran = "Ketua"
            If rbWakilKetua.Checked Then peran = "Wakil Ketua"
            If rbSekben.Checked Then peran = "Sekben"
            If rbAnggota.Checked Then peran = "Anggota"

            Dim minat As String = AmbilMinat()

            Dim data As String =
            tbNama.Text & "|" &
            tbIdAnggota.Text & "|" &
            dtpTglLahir.Value.ToString() & "|" &
            jk & "|" &
            ComboBox1.Text & "|" &
            mtbTelepon.Text & "|" &
            tbEmail.Text & "|" &
            tbAlamat.Text & "|" &
            peran & "|" &
            minat

            IO.File.WriteAllText(sfdSimpan.FileName, data)

            MessageBox.Show("Data berhasil disimpan")

        End If

    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click

        Dim ofd As New OpenFileDialog

        If ofd.ShowDialog() = DialogResult.OK Then

            Dim isi = IO.File.ReadAllText(ofd.FileName)
            Dim data = isi.Split("|"c)

            If data.Length >= 10 Then

                tbNama.Text = data(0)
                tbIdAnggota.Text = data(1)
                dtpTglLahir.Value = DateTime.Parse(data(2))

                ' Jenis Kelamin
                If data(3) = "Laki-laki" Then
                    rbLakilaki.Checked = True
                Else
                    rbPerempuan.Checked = True
                End If

                ComboBox1.Text = data(4)
                mtbTelepon.Text = data(5)
                tbEmail.Text = data(6)
                tbAlamat.Text = data(7)

                ' Peran
                If data(8) = "Ketua" Then rbKetua.Checked = True
                If data(8) = "Wakil Ketua" Then rbWakilKetua.Checked = True
                If data(8) = "Sekben" Then rbSekben.Checked = True
                If data(8) = "Anggota" Then rbAnggota.Checked = True

                ' Minat (checkbox)
                Dim minatList = data(9).Split(","c)

                For Each ctrl As Control In gbMinatAktivitas.Controls
                    If TypeOf ctrl Is CheckBox Then
                        Dim chk As CheckBox = CType(ctrl, CheckBox)
                        chk.Checked = False
                        For Each m In minatList
                            If chk.Text.Trim = m.Trim Then
                                chk.Checked = True
                            End If
                        Next
                    End If
                Next

            Else
                MessageBox.Show("Data tidak lengkap")
            End If

        End If

    End Sub

    ' Menu untuk keluar dari aplikasi dengan konfirmasi
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        If MessageBox.Show("Yakin keluar?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
