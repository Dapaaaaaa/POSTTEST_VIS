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
        lblDivisi = New Label()
        lblNama = New Label()
        lblKontak = New Label()
        lblMinat = New Label()
        lblId = New Label()
        pbHasil = New PictureBox()
        CType(pbHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.Location = New Point(70, 249)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(45, 20)
        lblDivisi.TabIndex = 0
        lblDivisi.Text = "Divisi"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(70, 269)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(70, 289)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(55, 20)
        lblKontak.TabIndex = 2
        lblKontak.Text = "Kontak"
        ' 
        ' lblMinat
        ' 
        lblMinat.Location = New Point(70, 309)
        lblMinat.MaximumSize = New Size(200, 0)
        lblMinat.Name = "lblMinat"
        lblMinat.Size = New Size(161, 54)
        lblMinat.TabIndex = 3
        lblMinat.Text = "Minat"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(70, 229)
        lblId.Name = "lblId"
        lblId.Size = New Size(24, 20)
        lblId.TabIndex = 4
        lblId.Text = "ID"
        ' 
        ' pbHasil
        ' 
        pbHasil.Location = New Point(70, 74)
        pbHasil.Name = "pbHasil"
        pbHasil.Size = New Size(125, 135)
        pbHasil.TabIndex = 5
        pbHasil.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(283, 450)
        Controls.Add(pbHasil)
        Controls.Add(lblId)
        Controls.Add(lblMinat)
        Controls.Add(lblKontak)
        Controls.Add(lblNama)
        Controls.Add(lblDivisi)
        Name = "Form2"
        Text = "Form2"
        CType(pbHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblMinat As Label
    Friend WithEvents lblId As Label
    Friend WithEvents pbHasil As PictureBox
End Class
