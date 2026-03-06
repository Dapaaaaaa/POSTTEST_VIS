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
        listBuku = New ListView()
        GroupBox1 = New GroupBox()
        tbGenreBuku = New TextBox()
        tbJudulBuku = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnTambah = New Button()
        GroupBox2 = New GroupBox()
        tbJudulHapusBuku = New TextBox()
        Label3 = New Label()
        btnHapus = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' listBuku
        ' 
        listBuku.Activation = ItemActivation.OneClick
        listBuku.HoverSelection = True
        listBuku.Location = New Point(12, 266)
        listBuku.Name = "listBuku"
        listBuku.Size = New Size(506, 121)
        listBuku.TabIndex = 1
        listBuku.UseCompatibleStateImageBehavior = False
        listBuku.View = View.List
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbGenreBuku)
        GroupBox1.Controls.Add(tbJudulBuku)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(238, 248)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' tbGenreBuku
        ' 
        tbGenreBuku.Location = New Point(107, 81)
        tbGenreBuku.Name = "tbGenreBuku"
        tbGenreBuku.Size = New Size(125, 27)
        tbGenreBuku.TabIndex = 8
        ' 
        ' tbJudulBuku
        ' 
        tbJudulBuku.Location = New Point(107, 37)
        tbJudulBuku.Name = "tbJudulBuku"
        tbJudulBuku.Size = New Size(125, 27)
        tbJudulBuku.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 6
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 5
        Label1.Text = "Judul Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(138, 213)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tbJudulHapusBuku)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Location = New Point(276, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(242, 248)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' tbJudulHapusBuku
        ' 
        tbJudulHapusBuku.Location = New Point(111, 34)
        tbJudulHapusBuku.Name = "tbJudulHapusBuku"
        tbJudulHapusBuku.Size = New Size(125, 27)
        tbJudulHapusBuku.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 7
        Label3.Text = "Judul Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(142, 213)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 392)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(listBuku)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents listBuku As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbGenreBuku As TextBox
    Friend WithEvents tbJudulBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbJudulHapusBuku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button

End Class
