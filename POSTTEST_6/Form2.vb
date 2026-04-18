Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ambil data dari database untuk ditampilkan di DataGridView
        cmbMenu.DataSource = GetMenuForOrder()
        cmbMenu.DisplayMember = "nama_menu"
        cmbMenu.ValueMember = "id_menu"

        LoadDataPesanan()
    End Sub

    Private Sub dgvPesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentClick

    End Sub

    ' Hitung otomatis saat menu ganti
    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        ' Cek apakah nilai yang dipilih valid
        If cmbMenu.SelectedValue IsNot Nothing AndAlso Not IsDBNull(cmbMenu.SelectedValue) Then
            ' Ambil harga menu yang dipilih dan tampilkan di txtHarga
            txtHarga.Text = GetHargaMenu(cmbMenu.SelectedValue.ToString()).ToString("0")
            hitungTotal()
        End If
    End Sub

    Sub hitungTotal()
        Dim harga As Decimal
        Dim jumlah As Integer
        Decimal.TryParse(txtHarga.Text, harga)
        Integer.TryParse(numJumlah.Value.ToString(), jumlah)
        txtTotal.Text = (harga * jumlah).ToString("0")
    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    ' Hitung total harga berdasarkan harga dan jumlah secara otomatis
    Private Sub numJumlah_ValueChanged(sender As Object, e As EventArgs) Handles numJumlah.ValueChanged
        HitungTotal()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    ' Simpan data pesanan ke database saat tombol Pesan diklik
    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        ' Panggil fungsi simpan di DataModule
        If SimpanPesanan(cmbMenu.SelectedValue.ToString(), CInt(numJumlah.Value), CDec(txtTotal.Text)) Then
            MessageBox.Show("Pesanan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataPesanan()
        End If
    End Sub

    Sub LoadDataPesanan()
        dgvPesanan.DataSource = GetAllPesanan()
    End Sub
End Class