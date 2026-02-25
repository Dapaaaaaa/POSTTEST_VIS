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
        labelIPS = New Label()
        tbIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        tbIPK = New TextBox()
        labelIPK = New Label()
        labelPredikat = New Label()
        SuspendLayout()
        ' 
        ' labelIPS
        ' 
        labelIPS.AutoSize = True
        labelIPS.Location = New Point(144, 123)
        labelIPS.Name = "labelIPS"
        labelIPS.Size = New Size(86, 20)
        labelIPS.TabIndex = 0
        labelIPS.Text = "IP Semester"
        ' 
        ' tbIPS
        ' 
        tbIPS.Location = New Point(269, 120)
        tbIPS.Name = "tbIPS"
        tbIPS.Size = New Size(194, 27)
        tbIPS.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(269, 153)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(369, 153)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' tbIPK
        ' 
        tbIPK.Location = New Point(269, 206)
        tbIPK.Name = "tbIPK"
        tbIPK.ReadOnly = True
        tbIPK.Size = New Size(194, 27)
        tbIPK.TabIndex = 4
        ' 
        ' labelIPK
        ' 
        labelIPK.AutoSize = True
        labelIPK.Location = New Point(144, 209)
        labelIPK.Name = "labelIPK"
        labelIPK.Size = New Size(106, 20)
        labelIPK.TabIndex = 5
        labelIPK.Text = "IPK Akumulatif"
        ' 
        ' labelPredikat
        ' 
        labelPredikat.AutoSize = True
        labelPredikat.Location = New Point(269, 253)
        labelPredikat.Name = "labelPredikat"
        labelPredikat.Size = New Size(0, 20)
        labelPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(labelPredikat)
        Controls.Add(labelIPK)
        Controls.Add(tbIPK)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(tbIPS)
        Controls.Add(labelIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelIPS As Label
    Friend WithEvents tbIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents tbIPK As TextBox
    Friend WithEvents labelIPK As Label
    Friend WithEvents labelPredikat As Label

End Class
