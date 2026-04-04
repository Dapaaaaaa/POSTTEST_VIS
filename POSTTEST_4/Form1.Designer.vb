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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        pbLogo = New PictureBox()
        TabControl1 = New TabControl()
        tpDataUtama = New TabPage()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        rbPerempuan = New RadioButton()
        rbLakilaki = New RadioButton()
        Label2 = New Label()
        dtpTglLahir = New DateTimePicker()
        Label1 = New Label()
        tbIdAnggota = New TextBox()
        lblId = New Label()
        tbNama = New TextBox()
        lblNama = New Label()
        tpKontakInfo = New TabPage()
        tbAlamat = New TextBox()
        Label6 = New Label()
        tbEmail = New TextBox()
        Label5 = New Label()
        mtbTelepon = New MaskedTextBox()
        Label4 = New Label()
        tpProfilAktivitas = New TabPage()
        gbMinatAktivitas = New GroupBox()
        cbCyber = New CheckBox()
        cbDevops = New CheckBox()
        cbMobile = New CheckBox()
        cbAPI = New CheckBox()
        cbDatabase = New CheckBox()
        cbBackend = New CheckBox()
        cbFrontend = New CheckBox()
        cbUiUx = New CheckBox()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbSekben = New RadioButton()
        rbWakilKetua = New RadioButton()
        rbKetua = New RadioButton()
        btnFoto = New Button()
        pbProfil = New PictureBox()
        ofdFoto = New OpenFileDialog()
        btnCetak = New Button()
        sfdSimpan = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        lblJudul = New Label()
        MenuStrip1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tpDataUtama.SuspendLayout()
        tpKontakInfo.SuspendLayout()
        tpProfilAktivitas.SuspendLayout()
        gbMinatAktivitas.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(735, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(12, 77)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(190, 296)
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogo.TabIndex = 2
        pbLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontakInfo)
        TabControl1.Controls.Add(tpProfilAktivitas)
        TabControl1.Location = New Point(208, 77)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(510, 265)
        TabControl1.TabIndex = 3
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.Controls.Add(ComboBox1)
        tpDataUtama.Controls.Add(Label3)
        tpDataUtama.Controls.Add(rbPerempuan)
        tpDataUtama.Controls.Add(rbLakilaki)
        tpDataUtama.Controls.Add(Label2)
        tpDataUtama.Controls.Add(dtpTglLahir)
        tpDataUtama.Controls.Add(Label1)
        tpDataUtama.Controls.Add(tbIdAnggota)
        tpDataUtama.Controls.Add(lblId)
        tpDataUtama.Controls.Add(tbNama)
        tpDataUtama.Controls.Add(lblNama)
        tpDataUtama.Location = New Point(4, 29)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(502, 232)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "Data Utama"
        tpDataUtama.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Frontend", "Backend", "Fullstack"})
        ComboBox1.Location = New Point(108, 147)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(155, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 9
        Label3.Text = "Divisi"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(199, 117)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakilaki
        ' 
        rbLakilaki.AutoSize = True
        rbLakilaki.Location = New Point(108, 117)
        rbLakilaki.Name = "rbLakilaki"
        rbLakilaki.Size = New Size(85, 24)
        rbLakilaki.TabIndex = 7
        rbLakilaki.TabStop = True
        rbLakilaki.Text = "Laki-laki"
        rbLakilaki.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 6
        Label2.Text = "Jenis Kelamin"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.CustomFormat = ""
        dtpTglLahir.Location = New Point(108, 83)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(155, 27)
        dtpTglLahir.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 4
        Label1.Text = "Tanggal Lahir"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbIdAnggota
        ' 
        tbIdAnggota.Location = New Point(108, 47)
        tbIdAnggota.Name = "tbIdAnggota"
        tbIdAnggota.PlaceholderText = "Input ID Anggota"
        tbIdAnggota.Size = New Size(155, 27)
        tbIdAnggota.TabIndex = 3
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(6, 50)
        lblId.Name = "lblId"
        lblId.Size = New Size(86, 20)
        lblId.TabIndex = 2
        lblId.Text = "ID Anggota"
        lblId.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(108, 14)
        tbNama.Name = "tbNama"
        tbNama.PlaceholderText = "Input Nama"
        tbNama.Size = New Size(155, 27)
        tbNama.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(6, 17)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' tpKontakInfo
        ' 
        tpKontakInfo.Controls.Add(tbAlamat)
        tpKontakInfo.Controls.Add(Label6)
        tpKontakInfo.Controls.Add(tbEmail)
        tpKontakInfo.Controls.Add(Label5)
        tpKontakInfo.Controls.Add(mtbTelepon)
        tpKontakInfo.Controls.Add(Label4)
        tpKontakInfo.Location = New Point(4, 29)
        tpKontakInfo.Name = "tpKontakInfo"
        tpKontakInfo.Padding = New Padding(3)
        tpKontakInfo.Size = New Size(502, 232)
        tpKontakInfo.TabIndex = 1
        tpKontakInfo.Text = "Kontak Info"
        tpKontakInfo.UseVisualStyleBackColor = True
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(108, 80)
        tbAlamat.Name = "tbAlamat"
        tbAlamat.PlaceholderText = "Input Alamat"
        tbAlamat.Size = New Size(140, 27)
        tbAlamat.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 6
        Label6.Text = "Alamat"
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(108, 47)
        tbEmail.Name = "tbEmail"
        tbEmail.PlaceholderText = "ytta@gmail.com"
        tbEmail.Size = New Size(140, 27)
        tbEmail.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 50)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(108, 14)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(140, 27)
        mtbTelepon.TabIndex = 3
        mtbTelepon.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 2
        Label4.Text = "Telepon"
        ' 
        ' tpProfilAktivitas
        ' 
        tpProfilAktivitas.Controls.Add(gbMinatAktivitas)
        tpProfilAktivitas.Controls.Add(gbPeran)
        tpProfilAktivitas.Controls.Add(btnFoto)
        tpProfilAktivitas.Controls.Add(pbProfil)
        tpProfilAktivitas.Location = New Point(4, 29)
        tpProfilAktivitas.Name = "tpProfilAktivitas"
        tpProfilAktivitas.Padding = New Padding(3)
        tpProfilAktivitas.Size = New Size(502, 232)
        tpProfilAktivitas.TabIndex = 2
        tpProfilAktivitas.Text = "Profil Aktivitas"
        tpProfilAktivitas.UseVisualStyleBackColor = True
        ' 
        ' gbMinatAktivitas
        ' 
        gbMinatAktivitas.Controls.Add(cbCyber)
        gbMinatAktivitas.Controls.Add(cbDevops)
        gbMinatAktivitas.Controls.Add(cbMobile)
        gbMinatAktivitas.Controls.Add(cbAPI)
        gbMinatAktivitas.Controls.Add(cbDatabase)
        gbMinatAktivitas.Controls.Add(cbBackend)
        gbMinatAktivitas.Controls.Add(cbFrontend)
        gbMinatAktivitas.Controls.Add(cbUiUx)
        gbMinatAktivitas.Location = New Point(138, 104)
        gbMinatAktivitas.Name = "gbMinatAktivitas"
        gbMinatAktivitas.Size = New Size(349, 117)
        gbMinatAktivitas.TabIndex = 4
        gbMinatAktivitas.TabStop = False
        gbMinatAktivitas.Text = "Minat Aktivitas"
        ' 
        ' cbCyber
        ' 
        cbCyber.AutoSize = True
        cbCyber.Location = New Point(224, 56)
        cbCyber.Name = "cbCyber"
        cbCyber.Size = New Size(125, 24)
        cbCyber.TabIndex = 8
        cbCyber.Text = "Cyber Security"
        cbCyber.UseVisualStyleBackColor = True
        ' 
        ' cbDevops
        ' 
        cbDevops.AutoSize = True
        cbDevops.Location = New Point(224, 26)
        cbDevops.Name = "cbDevops"
        cbDevops.Size = New Size(113, 24)
        cbDevops.TabIndex = 7
        cbDevops.Text = "DevOps Dev"
        cbDevops.UseVisualStyleBackColor = True
        ' 
        ' cbMobile
        ' 
        cbMobile.AutoSize = True
        cbMobile.Location = New Point(115, 86)
        cbMobile.Name = "cbMobile"
        cbMobile.Size = New Size(108, 24)
        cbMobile.TabIndex = 5
        cbMobile.Text = "Mobile Dev"
        cbMobile.UseVisualStyleBackColor = True
        ' 
        ' cbAPI
        ' 
        cbAPI.AutoSize = True
        cbAPI.Location = New Point(115, 56)
        cbAPI.Name = "cbAPI"
        cbAPI.Size = New Size(53, 24)
        cbAPI.TabIndex = 4
        cbAPI.Text = "API"
        cbAPI.UseVisualStyleBackColor = True
        ' 
        ' cbDatabase
        ' 
        cbDatabase.AutoSize = True
        cbDatabase.Location = New Point(115, 26)
        cbDatabase.Name = "cbDatabase"
        cbDatabase.Size = New Size(94, 24)
        cbDatabase.TabIndex = 3
        cbDatabase.Text = "Database"
        cbDatabase.UseVisualStyleBackColor = True
        ' 
        ' cbBackend
        ' 
        cbBackend.AutoSize = True
        cbBackend.Location = New Point(6, 86)
        cbBackend.Name = "cbBackend"
        cbBackend.Size = New Size(87, 24)
        cbBackend.TabIndex = 2
        cbBackend.Text = "Backend"
        cbBackend.UseVisualStyleBackColor = True
        ' 
        ' cbFrontend
        ' 
        cbFrontend.AutoSize = True
        cbFrontend.Location = New Point(6, 56)
        cbFrontend.Name = "cbFrontend"
        cbFrontend.Size = New Size(90, 24)
        cbFrontend.TabIndex = 1
        cbFrontend.Text = "Frontend"
        cbFrontend.UseVisualStyleBackColor = True
        ' 
        ' cbUiUx
        ' 
        cbUiUx.AutoSize = True
        cbUiUx.Location = New Point(6, 26)
        cbUiUx.Name = "cbUiUx"
        cbUiUx.Size = New Size(70, 24)
        cbUiUx.TabIndex = 0
        cbUiUx.Text = "UI/UX"
        cbUiUx.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbSekben)
        gbPeran.Controls.Add(rbWakilKetua)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(137, 6)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(350, 92)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(133, 56)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 3
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbSekben
        ' 
        rbSekben.AutoSize = True
        rbSekben.Location = New Point(133, 26)
        rbSekben.Name = "rbSekben"
        rbSekben.Size = New Size(198, 24)
        rbSekben.TabIndex = 2
        rbSekben.TabStop = True
        rbSekben.Text = "Sekretaris dan Bendahara"
        rbSekben.UseVisualStyleBackColor = True
        ' 
        ' rbWakilKetua
        ' 
        rbWakilKetua.AutoSize = True
        rbWakilKetua.Location = New Point(6, 56)
        rbWakilKetua.Name = "rbWakilKetua"
        rbWakilKetua.Size = New Size(108, 24)
        rbWakilKetua.TabIndex = 1
        rbWakilKetua.TabStop = True
        rbWakilKetua.Text = "Wakil Ketua"
        rbWakilKetua.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 26)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnFoto
        ' 
        btnFoto.Location = New Point(6, 192)
        btnFoto.Name = "btnFoto"
        btnFoto.Size = New Size(125, 29)
        btnFoto.TabIndex = 1
        btnFoto.Text = "Upload Foto"
        btnFoto.UseVisualStyleBackColor = True
        ' 
        ' pbProfil
        ' 
        pbProfil.Location = New Point(6, 6)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(125, 180)
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(208, 344)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(506, 29)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' sfdSimpan
        ' 
        sfdSimpan.Tag = ""
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F)
        lblJudul.Location = New Point(12, 42)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(181, 32)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Komunitas Web"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 387)
        Controls.Add(btnCetak)
        Controls.Add(TabControl1)
        Controls.Add(pbLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        tpKontakInfo.ResumeLayout(False)
        tpKontakInfo.PerformLayout()
        tpProfilAktivitas.ResumeLayout(False)
        gbMinatAktivitas.ResumeLayout(False)
        gbMinatAktivitas.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents tpKontakInfo As TabPage
    Friend WithEvents tpProfilAktivitas As TabPage
    Friend WithEvents tbIdAnggota As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakilaki As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFoto As Button
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbSekben As RadioButton
    Friend WithEvents rbWakilKetua As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents gbMinatAktivitas As GroupBox
    Friend WithEvents cbCyber As CheckBox
    Friend WithEvents cbDevops As CheckBox
    Friend WithEvents cbMobile As CheckBox
    Friend WithEvents cbAPI As CheckBox
    Friend WithEvents cbDatabase As CheckBox
    Friend WithEvents cbBackend As CheckBox
    Friend WithEvents cbFrontend As CheckBox
    Friend WithEvents cbUiUx As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents sfdSimpan As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblJudul As Label

End Class
