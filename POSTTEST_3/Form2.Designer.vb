<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        tbNama = New TextBox()
        tbUmur = New TextBox()
        tbJK = New TextBox()
        tbNoTelp = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        tbHobby = New TextBox()
        tbAlamat = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 4
        Label3.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(274, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 7
        Label4.Text = "Nomor Telepon"
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
        ' tbNama
        ' 
        tbNama.Location = New Point(426, 35)
        tbNama.Name = "tbNama"
        tbNama.ReadOnly = True
        tbNama.Size = New Size(430, 27)
        tbNama.TabIndex = 11
        ' 
        ' tbUmur
        ' 
        tbUmur.Location = New Point(426, 74)
        tbUmur.Name = "tbUmur"
        tbUmur.ReadOnly = True
        tbUmur.Size = New Size(430, 27)
        tbUmur.TabIndex = 12
        ' 
        ' tbJK
        ' 
        tbJK.Location = New Point(426, 154)
        tbJK.Name = "tbJK"
        tbJK.ReadOnly = True
        tbJK.Size = New Size(430, 27)
        tbJK.TabIndex = 13
        ' 
        ' tbNoTelp
        ' 
        tbNoTelp.Location = New Point(426, 194)
        tbNoTelp.Name = "tbNoTelp"
        tbNoTelp.ReadOnly = True
        tbNoTelp.Size = New Size(430, 27)
        tbNoTelp.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Location = New Point(426, 111)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(430, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(274, 240)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 17
        Label8.Text = "Hobby"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(274, 281)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 16
        Label9.Text = "Alamat"
        ' 
        ' tbHobby
        ' 
        tbHobby.Location = New Point(426, 237)
        tbHobby.Name = "tbHobby"
        tbHobby.ReadOnly = True
        tbHobby.Size = New Size(430, 27)
        tbHobby.TabIndex = 18
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(426, 278)
        tbAlamat.Name = "tbAlamat"
        tbAlamat.ReadOnly = True
        tbAlamat.Size = New Size(430, 27)
        tbAlamat.TabIndex = 19
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 411)
        Controls.Add(tbAlamat)
        Controls.Add(tbHobby)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(DateTimePicker1)
        Controls.Add(tbNoTelp)
        Controls.Add(tbJK)
        Controls.Add(tbUmur)
        Controls.Add(tbNama)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbUmur As TextBox
    Friend WithEvents tbJK As TextBox
    Friend WithEvents tbNoTelp As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbHobby As TextBox
    Friend WithEvents tbAlamat As TextBox

End Class
