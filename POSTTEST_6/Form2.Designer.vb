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
        cmbMenu = New ComboBox()
        txtHarga = New TextBox()
        numJumlah = New NumericUpDown()
        txtTotal = New TextBox()
        dgvPesanan = New DataGridView()
        btnPesan = New Button()
        CType(numJumlah, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbMenu
        ' 
        cmbMenu.FormattingEnabled = True
        cmbMenu.Location = New Point(167, 53)
        cmbMenu.Name = "cmbMenu"
        cmbMenu.Size = New Size(151, 28)
        cmbMenu.TabIndex = 0
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(240, 159)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 1
        ' 
        ' numJumlah
        ' 
        numJumlah.Location = New Point(235, 290)
        numJumlah.Name = "numJumlah"
        numJumlah.Size = New Size(150, 27)
        numJumlah.TabIndex = 2
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(240, 336)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 3
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.Location = New Point(424, 157)
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.RowHeadersWidth = 51
        dgvPesanan.Size = New Size(300, 188)
        dgvPesanan.TabIndex = 4
        ' 
        ' btnPesan
        ' 
        btnPesan.Location = New Point(341, 388)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(94, 29)
        btnPesan.TabIndex = 5
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnPesan)
        Controls.Add(dgvPesanan)
        Controls.Add(txtTotal)
        Controls.Add(numJumlah)
        Controls.Add(txtHarga)
        Controls.Add(cmbMenu)
        Name = "Form2"
        Text = "Form2"
        CType(numJumlah, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents numJumlah As NumericUpDown
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents btnPesan As Button
End Class
