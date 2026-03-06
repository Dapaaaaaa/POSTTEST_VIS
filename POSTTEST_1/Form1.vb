Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double

        'Validasi Input angka yang dikirim
        If Double.TryParse(tbIPS.Text, ips) Then

            If ips < 0 Or ips > 4 Then
                MessageBox.Show("Masukkan angka IP Semester antara 0 dan 4!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbIPS.Clear()
                tbIPS.Focus()
                Exit Sub
            End If

            totalIPS += ips
                jumlahSemester += 1

                Dim ipk As Double = totalIPS / jumlahSemester
                tbIPK.Text = ipk.ToString("0.00")

                ' Menentukan Predikat
                If ipk >= 2.0 And ipk <= 2.75 Then
                    labelPredikat.Text = "Predikat: Cukup"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    labelPredikat.Text = "Predikat: Memuaskan"
                ElseIf ipk > 3.0 Then
                    labelPredikat.Text = "Predikat: Sangat Memuaskan"
                Else
                    labelPredikat.Text = ""
                End If

                ' Kosongkan input
                tbIPS.Clear()
                tbIPS.Focus()

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPS = 0
        jumlahSemester = 0
        tbIPS.Clear()
        tbIPK.Clear()
        labelPredikat.Text = ""

        tbIPS.Focus()
    End Sub

End Class
