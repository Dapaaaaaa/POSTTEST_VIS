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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKodeJenis = New TextBox()
        txtJenis = New TextBox()
        txtSearch = New TextBox()
        dgvJenis = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(89, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kode Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(89, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 2
        Label3.Text = "Cari Buku"
        ' 
        ' txtKodeJenis
        ' 
        txtKodeJenis.Location = New Point(173, 66)
        txtKodeJenis.Name = "txtKodeJenis"
        txtKodeJenis.PlaceholderText = "Masukan Kode Jenis"
        txtKodeJenis.Size = New Size(300, 27)
        txtKodeJenis.TabIndex = 3
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(173, 115)
        txtJenis.Name = "txtJenis"
        txtJenis.PlaceholderText = "Masukan Jenis"
        txtJenis.Size = New Size(300, 27)
        txtJenis.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(173, 174)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Masukan Untuk mencari Buku"
        txtSearch.Size = New Size(300, 27)
        txtSearch.TabIndex = 5
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(73, 262)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.RowHeadersWidth = 51
        dgvJenis.Size = New Size(400, 188)
        dgvJenis.TabIndex = 6
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(73, 227)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(173, 227)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(279, 227)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(379, 227)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvJenis)
        Controls.Add(txtSearch)
        Controls.Add(txtJenis)
        Controls.Add(txtKodeJenis)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Data Perpustakaan"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
