<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtSearch = New TextBox()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtDeskripsi = New TextBox()
        cmbFilter = New ComboBox()
        cmbKategori = New ComboBox()
        dgvMenu = New DataGridView()
        lblStatus = New Label()
        btnTambah = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnBersihkan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnKasir = New Button()
        CType(dgvMenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(145, 46)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Masukan Data Yang Mau Dicari"
        txtSearch.Size = New Size(335, 27)
        txtSearch.TabIndex = 0
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(145, 110)
        txtKode.Name = "txtKode"
        txtKode.PlaceholderText = "Masukan Kode"
        txtKode.Size = New Size(238, 27)
        txtKode.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(145, 174)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukan Nama"
        txtNama.Size = New Size(238, 27)
        txtNama.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(145, 238)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Masukan Harga"
        txtHarga.Size = New Size(238, 27)
        txtHarga.TabIndex = 3
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(145, 302)
        txtStok.Name = "txtStok"
        txtStok.PlaceholderText = "Masukan Stok"
        txtStok.Size = New Size(238, 27)
        txtStok.TabIndex = 4
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(145, 366)
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Masukan Deskripsi"
        txtDeskripsi.Size = New Size(238, 27)
        txtDeskripsi.TabIndex = 5
        ' 
        ' cmbFilter
        ' 
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(740, 46)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(225, 28)
        cmbFilter.TabIndex = 6
        ' 
        ' cmbKategori
        ' 
        cmbKategori.FormattingEnabled = True
        cmbKategori.Location = New Point(496, 46)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(225, 28)
        cmbKategori.TabIndex = 7
        ' 
        ' dgvMenu
        ' 
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMenu.Location = New Point(399, 80)
        dgvMenu.Name = "dgvMenu"
        dgvMenu.RowHeadersWidth = 51
        dgvMenu.Size = New Size(566, 317)
        dgvMenu.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 14F)
        lblStatus.Location = New Point(354, 9)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(268, 32)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status yang akan tampil"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(89, 409)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 29)
        btnTambah.TabIndex = 10
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(251, 409)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(150, 29)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(413, 409)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 29)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(575, 409)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(150, 29)
        btnBersihkan.TabIndex = 13
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(40, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 25)
        Label1.TabIndex = 14
        Label1.Text = "Cari"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(40, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 25)
        Label2.TabIndex = 15
        Label2.Text = "Kode"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(40, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 16
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(40, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 25)
        Label4.TabIndex = 17
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(40, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 25)
        Label5.TabIndex = 18
        Label5.Text = "Stok"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(40, 365)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 25)
        Label6.TabIndex = 19
        Label6.Text = "Deskripsi"
        ' 
        ' btnKasir
        ' 
        btnKasir.Location = New Point(737, 409)
        btnKasir.Name = "btnKasir"
        btnKasir.Size = New Size(150, 29)
        btnKasir.TabIndex = 20
        btnKasir.Text = "Menu Kasir"
        btnKasir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(977, 450)
        Controls.Add(btnKasir)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBersihkan)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnTambah)
        Controls.Add(lblStatus)
        Controls.Add(dgvMenu)
        Controls.Add(cmbKategori)
        Controls.Add(cmbFilter)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(txtSearch)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnKasir As Button

End Class
