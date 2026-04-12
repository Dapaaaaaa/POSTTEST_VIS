Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
        Char.IsWhiteSpace(e.KeyChar) OrElse
        Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
    Public Function ValidasiJenisBuku(ep As ErrorProvider,
txtKodeJenis As TextBox, txtJenis As TextBox) As Boolean

        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKodeJenis,
                                                   "Kode Jenis tidak boleh kosong")

        Dim jenisValid As Boolean = ValidasiTextBox(ep, txtJenis,
                                                    "Jenis Buku tidak boleh kosong")
        Return kodeValid And jenisValid
    End Function
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module