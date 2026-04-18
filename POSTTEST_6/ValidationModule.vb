Module ValidationModule

    Public Function IsKosong(nilai As String) As Boolean
        Return String.IsNullOrWhiteSpace(nilai)
    End Function

    Public Function IsAngkaPositif(nilai As String) As Boolean
        Dim hasil As Decimal
        Return Decimal.TryParse(nilai, hasil) AndAlso hasil >= 0
    End Function

    Public Function IsAngkaBulat(nilai As String) As Boolean
        Dim hasil As Integer
        Return Integer.TryParse(nilai, hasil) AndAlso hasil >= 0
    End Function

    Public Function ValidasiInput(nama As String, harga As String, stok As String) As String
        If IsKosong(nama) Then
            Return "Nama menu tidak boleh kosong!"
        End If
        If IsKosong(harga) OrElse Not IsAngkaPositif(harga) Then
            Return "Harga harus berupa angka positif!"
        End If
        If IsKosong(stok) OrElse Not IsAngkaBulat(stok) Then
            Return "Stok harus berupa angka bulat positif!"
        End If
        Return String.Empty
    End Function

End Module