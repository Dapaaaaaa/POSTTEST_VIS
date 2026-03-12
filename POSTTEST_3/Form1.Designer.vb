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
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        RBPerempuan = New RadioButton()
        RBLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBoxMemasak = New CheckBox()
        CheckBoxKuliner = New CheckBox()
        CheckBoxMenyanyi = New CheckBox()
        CheckBoxNgevlog = New CheckBox()
        CheckBoxMenari = New CheckBox()
        CheckBoxTravelling = New CheckBox()
        CheckBoxOlahraga = New CheckBox()
        CheckBoxNgoding = New CheckBox()
        CheckBoxMancing = New CheckBox()
        CheckBoxGaming = New CheckBox()
        btnCK = New Button()
        tbNama = New TextBox()
        tbUmur = New TextBox()
        tbNoTelp = New TextBox()
        tbAlamat = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(256, 352)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(12, 370)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(256, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(274, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(274, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(274, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 4
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(274, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 7
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(274, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 6
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(549, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RBPerempuan)
        GroupBox1.Controls.Add(RBLaki)
        GroupBox1.Location = New Point(274, 233)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(146, 131)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' RBPerempuan
        ' 
        RBPerempuan.AutoSize = True
        RBPerempuan.Location = New Point(20, 67)
        RBPerempuan.Name = "RBPerempuan"
        RBPerempuan.Size = New Size(104, 24)
        RBPerempuan.TabIndex = 1
        RBPerempuan.TabStop = True
        RBPerempuan.Text = "Perempuan"
        RBPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RBLaki
        ' 
        RBLaki.AutoSize = True
        RBLaki.Location = New Point(20, 37)
        RBLaki.Name = "RBLaki"
        RBLaki.Size = New Size(85, 24)
        RBLaki.TabIndex = 0
        RBLaki.TabStop = True
        RBLaki.Text = "Laki-laki"
        RBLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBoxMemasak)
        GroupBox2.Controls.Add(CheckBoxKuliner)
        GroupBox2.Controls.Add(CheckBoxMenyanyi)
        GroupBox2.Controls.Add(CheckBoxNgevlog)
        GroupBox2.Controls.Add(CheckBoxMenari)
        GroupBox2.Controls.Add(CheckBoxTravelling)
        GroupBox2.Controls.Add(CheckBoxOlahraga)
        GroupBox2.Controls.Add(CheckBoxNgoding)
        GroupBox2.Controls.Add(CheckBoxMancing)
        GroupBox2.Controls.Add(CheckBoxGaming)
        GroupBox2.Location = New Point(426, 233)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(430, 131)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' CheckBoxMemasak
        ' 
        CheckBoxMemasak.AutoSize = True
        CheckBoxMemasak.Location = New Point(332, 26)
        CheckBoxMemasak.Name = "CheckBoxMemasak"
        CheckBoxMemasak.Size = New Size(94, 24)
        CheckBoxMemasak.TabIndex = 11
        CheckBoxMemasak.Text = "Memasak"
        CheckBoxMemasak.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxKuliner
        ' 
        CheckBoxKuliner.AutoSize = True
        CheckBoxKuliner.Location = New Point(238, 86)
        CheckBoxKuliner.Name = "CheckBoxKuliner"
        CheckBoxKuliner.Size = New Size(77, 24)
        CheckBoxKuliner.TabIndex = 10
        CheckBoxKuliner.Text = "Kuliner"
        CheckBoxKuliner.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenyanyi
        ' 
        CheckBoxMenyanyi.AutoSize = True
        CheckBoxMenyanyi.Location = New Point(238, 56)
        CheckBoxMenyanyi.Name = "CheckBoxMenyanyi"
        CheckBoxMenyanyi.Size = New Size(94, 24)
        CheckBoxMenyanyi.TabIndex = 9
        CheckBoxMenyanyi.Text = "Menyanyi"
        CheckBoxMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNgevlog
        ' 
        CheckBoxNgevlog.AutoSize = True
        CheckBoxNgevlog.Location = New Point(238, 26)
        CheckBoxNgevlog.Name = "CheckBoxNgevlog"
        CheckBoxNgevlog.Size = New Size(88, 24)
        CheckBoxNgevlog.TabIndex = 8
        CheckBoxNgevlog.Text = "Ngevlog"
        CheckBoxNgevlog.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenari
        ' 
        CheckBoxMenari.AutoSize = True
        CheckBoxMenari.Location = New Point(129, 86)
        CheckBoxMenari.Name = "CheckBoxMenari"
        CheckBoxMenari.Size = New Size(77, 24)
        CheckBoxMenari.TabIndex = 7
        CheckBoxMenari.Text = "Menari"
        CheckBoxMenari.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxTravelling
        ' 
        CheckBoxTravelling.AutoSize = True
        CheckBoxTravelling.Location = New Point(129, 56)
        CheckBoxTravelling.Name = "CheckBoxTravelling"
        CheckBoxTravelling.Size = New Size(95, 24)
        CheckBoxTravelling.TabIndex = 6
        CheckBoxTravelling.Text = "Travelling"
        CheckBoxTravelling.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxOlahraga
        ' 
        CheckBoxOlahraga.AutoSize = True
        CheckBoxOlahraga.Location = New Point(129, 26)
        CheckBoxOlahraga.Name = "CheckBoxOlahraga"
        CheckBoxOlahraga.Size = New Size(92, 24)
        CheckBoxOlahraga.TabIndex = 5
        CheckBoxOlahraga.Text = "Olahraga"
        CheckBoxOlahraga.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNgoding
        ' 
        CheckBoxNgoding.AutoSize = True
        CheckBoxNgoding.Location = New Point(20, 86)
        CheckBoxNgoding.Name = "CheckBoxNgoding"
        CheckBoxNgoding.Size = New Size(90, 24)
        CheckBoxNgoding.TabIndex = 4
        CheckBoxNgoding.Text = "Ngoding"
        CheckBoxNgoding.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMancing
        ' 
        CheckBoxMancing.AutoSize = True
        CheckBoxMancing.Location = New Point(20, 56)
        CheckBoxMancing.Name = "CheckBoxMancing"
        CheckBoxMancing.Size = New Size(88, 24)
        CheckBoxMancing.TabIndex = 3
        CheckBoxMancing.Text = "Mancing"
        CheckBoxMancing.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxGaming
        ' 
        CheckBoxGaming.AutoSize = True
        CheckBoxGaming.Location = New Point(20, 26)
        CheckBoxGaming.Name = "CheckBoxGaming"
        CheckBoxGaming.Size = New Size(83, 24)
        CheckBoxGaming.TabIndex = 2
        CheckBoxGaming.Text = "Gaming"
        CheckBoxGaming.UseVisualStyleBackColor = True
        ' 
        ' btnCK
        ' 
        btnCK.Location = New Point(274, 370)
        btnCK.Name = "btnCK"
        btnCK.Size = New Size(582, 29)
        btnCK.TabIndex = 10
        btnCK.Text = "Cetak Kartu"
        btnCK.UseVisualStyleBackColor = True
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(426, 35)
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(430, 27)
        tbNama.TabIndex = 11
        ' 
        ' tbUmur
        ' 
        tbUmur.Location = New Point(426, 74)
        tbUmur.Name = "tbUmur"
        tbUmur.Size = New Size(430, 27)
        tbUmur.TabIndex = 12
        ' 
        ' tbNoTelp
        ' 
        tbNoTelp.Location = New Point(426, 154)
        tbNoTelp.Name = "tbNoTelp"
        tbNoTelp.Size = New Size(430, 27)
        tbNoTelp.TabIndex = 13
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(426, 194)
        tbAlamat.Name = "tbAlamat"
        tbAlamat.Size = New Size(430, 27)
        tbAlamat.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(426, 111)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(430, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 411)
        Controls.Add(DateTimePicker1)
        Controls.Add(tbAlamat)
        Controls.Add(tbNoTelp)
        Controls.Add(tbUmur)
        Controls.Add(tbNama)
        Controls.Add(btnCK)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCK As Button
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbUmur As TextBox
    Friend WithEvents tbNoTelp As TextBox
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents RBPerempuan As RadioButton
    Friend WithEvents RBLaki As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBoxKuliner As CheckBox
    Friend WithEvents CheckBoxMenyanyi As CheckBox
    Friend WithEvents CheckBoxNgevlog As CheckBox
    Friend WithEvents CheckBoxMenari As CheckBox
    Friend WithEvents CheckBoxTravelling As CheckBox
    Friend WithEvents CheckBoxOlahraga As CheckBox
    Friend WithEvents CheckBoxNgoding As CheckBox
    Friend WithEvents CheckBoxMancing As CheckBox
    Friend WithEvents CheckBoxGaming As CheckBox
    Friend WithEvents CheckBoxMemasak As CheckBox

End Class
