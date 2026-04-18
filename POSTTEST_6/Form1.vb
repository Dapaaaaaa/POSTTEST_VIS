Public Class Form1

    ' Function 
    Sub SetStatus(pesan As String)
        lblStatus.Text = pesan
    End Sub

    Sub ShowError(pesan As String)
        MessageBox.Show(pesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Function Confirm(pesan As String) As Boolean
        Return MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Private selectedKode As String = ""

    ' load form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKategori.Items.AddRange({"Kopi", "Snack"})
        cmbFilter.Items.AddRange({"Semua", "Kopi", "Snack"})
        cmbFilter.SelectedIndex = 0

        LoadData()
    End Sub

    ' Load data dari database ke DataGridView
    Sub LoadData()
        dgvMenu.DataSource = GetAllMenu()
        SetStatus("Data berhasil dimuat")
    End Sub

    ' Cari data berdasarkan inputan di txtSearch dan filter di cmbFilter
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvMenu.DataSource = SearchMenu(txtSearch.Text, cmbFilter.Text)
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        dgvMenu.DataSource = SearchMenu(txtSearch.Text, cmbFilter.Text)
    End Sub

    ' Pilih data di DataGridView untuk ditampilkan di form input
    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex < 0 Then Return

        Dim row = dgvMenu.Rows(e.RowIndex)

        selectedKode = row.Cells("id_menu").Value.ToString()
        txtKode.Text = selectedKode
        txtNama.Text = row.Cells("nama_menu").Value.ToString()
        cmbKategori.Text = row.Cells("kategori_menu").Value.ToString()
        txtHarga.Text = Convert.ToDecimal(row.Cells("Harga_menu").Value).ToString("0")
        txtStok.Text = row.Cells("stok_menu").Value.ToString()
        txtDeskripsi.Text = row.Cells("deskripsi_menu").Value.ToString()

        txtKode.Enabled = False
    End Sub

    ' Tambah data baru ke database
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim pesan = ValidasiInput(txtNama.Text, txtHarga.Text, txtStok.Text)
        If pesan <> "" Then
            ShowError(pesan)
            Exit Sub
        End If

        If IsKosong(txtKode.Text) Then
            ShowError("Kode tidak boleh kosong")
            Exit Sub
        End If

        If KodeSudahAda(txtKode.Text) Then
            ShowError("Kode sudah ada")
            Exit Sub
        End If

        If SimpanMenu(txtKode.Text, txtNama.Text, cmbKategori.Text,
                  Decimal.Parse(txtHarga.Text), Integer.Parse(txtStok.Text),
                  txtDeskripsi.Text) Then

            SetStatus("Data berhasil ditambahkan")
            Bersihkan()
            LoadData()
        End If
    End Sub

    ' Update data yang sudah ada di database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedKode = "" Then
            ShowError("Pilih data dulu")
            Exit Sub
        End If

        Dim pesan = ValidasiInput(txtNama.Text, txtHarga.Text, txtStok.Text)
        If pesan <> "" Then
            ShowError(pesan)
            Exit Sub
        End If

        If UbahMenu(selectedKode, txtNama.Text, cmbKategori.Text,
                Decimal.Parse(txtHarga.Text), Integer.Parse(txtStok.Text),
                txtDeskripsi.Text) Then

            SetStatus("Data berhasil diupdate")
            Bersihkan()
            LoadData()
        End If
    End Sub

    ' Hapus data yang sudah ada di database
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedKode = "" Then
            ShowError("Pilih data dulu")
            Exit Sub
        End If

        If Confirm("Yakin hapus data ini?") Then
            If HapusMenu(selectedKode) Then
                SetStatus("Data berhasil dihapus")
                Bersihkan()
                LoadData()
            End If
        End If
    End Sub

    ' Bersihkan form input untuk menambah data baru
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        Bersihkan()
        SetStatus("Form dibersihkan")
    End Sub

    Sub Bersihkan()
        selectedKode = ""
        txtKode.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
        txtDeskripsi.Text = ""
        cmbKategori.SelectedIndex = -1
        txtKode.Enabled = True
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged

    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click

    End Sub
End Class