<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtPengarang = New TextBox()
        txtPenerbit = New TextBox()
        txtJumlah = New TextBox()
        cbJenis = New ComboBox()
        txtCari = New TextBox()
        txtDeskripsi = New TextBox()
        dgvBuku = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kode Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(291, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 2
        Label3.Text = "Judul"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 3
        Label4.Text = "Pengarang"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 5
        Label6.Text = "Penerbit"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(633, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 6
        Label7.Text = "Deskripsi"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(150, 25)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(125, 27)
        txtKodeBuku.TabIndex = 7
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(150, 93)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 27)
        txtJudul.TabIndex = 8
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(150, 139)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(125, 27)
        txtPengarang.TabIndex = 9
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(150, 203)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(125, 27)
        txtPenerbit.TabIndex = 10
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(150, 254)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(125, 27)
        txtJumlah.TabIndex = 11
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Location = New Point(387, 25)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(151, 28)
        cbJenis.TabIndex = 12
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(53, 318)
        txtCari.Multiline = True
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari Data"
        txtCari.Size = New Size(721, 27)
        txtCari.TabIndex = 13
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(566, 61)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(208, 202)
        txtDeskripsi.TabIndex = 14
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(53, 351)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(721, 87)
        dgvBuku.TabIndex = 15
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(123, 287)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Tambah"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(273, 287)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 17
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(407, 287)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 18
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(550, 287)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 19
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvBuku)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtCari)
        Controls.Add(cbJenis)
        Controls.Add(txtJumlah)
        Controls.Add(txtPenerbit)
        Controls.Add(txtPengarang)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
