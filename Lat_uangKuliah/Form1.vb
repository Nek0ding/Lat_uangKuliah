Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_jurusan.Items.Add("Sistem Informasi")
        cmb_jurusan.Items.Add("Akuntansi")
        cmb_jurusan.Items.Add("Psikologi")
        cmb_jurusan.Items.Add("Manajemen")
    End Sub

    Private Sub cmb_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jurusan.SelectedIndexChanged
        Dim pilihan = cmb_jurusan.SelectedItem
        Select Case pilihan
            Case "Sistem Informasi"

                output_uangKuliah.Text = "5000000"
                Dim uang_kuliah = Int(output_uangKuliah.Text)
                Dim uang_diskon = uang_kuliah * 20 / 100
                If btn_regular.Checked Then
                    diskon.Text = "0"
                End If
                If btn_beasiswa.Checked Then
                    diskon.Text = uang_diskon
                End If
            Case "Akuntansi"
                output_uangKuliah.Text = "4000000"
                Dim uang_kuliah = Int(output_uangKuliah.Text)
                Dim uang_diskon = uang_kuliah * 20 / 100
                If btn_regular.Checked Then
                    diskon.Text = "0"
                End If
                If btn_beasiswa.Checked Then
                    diskon.Text = uang_diskon
                End If
            Case "Psikologi"
                output_uangKuliah.Text = "6000000"
                Dim uang_kuliah = Int(output_uangKuliah.Text)
                Dim uang_diskon = uang_kuliah * 20 / 100
                If btn_regular.Checked Then
                    diskon.Text = "0"
                End If
                If btn_beasiswa.Checked Then
                    diskon.Text = uang_diskon
                End If
            Case "Manajemen"
                output_uangKuliah.Text = "5000000"
                Dim uang_kuliah = Int(output_uangKuliah.Text)
                Dim uang_diskon = uang_kuliah * 20 / 100
                If btn_regular.Checked Then
                    diskon.Text = "0"
                End If
                If btn_beasiswa.Checked Then
                    diskon.Text = uang_diskon
                End If
        End Select
    End Sub

    Private Sub btn_regular_CheckedChanged(sender As Object, e As EventArgs) Handles btn_regular.CheckedChanged
        If btn_regular.Checked Then
            diskon.Text = "0"
        End If
    End Sub

    Private Sub btn_beasiswa_CheckedChanged(sender As Object, e As EventArgs) Handles btn_beasiswa.CheckedChanged
        Dim uang_kuliah = Int(output_uangKuliah.Text)
        Dim uang_diskon = uang_kuliah * 20 / 100
        If btn_beasiswa.Checked Then
            diskon.Text = uang_diskon
        End If
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim uang_kuliah = Int(output_uangKuliah.Text)
        Dim uang_diskon = Int(diskon.Text)
        Dim total_harga = uang_kuliah - uang_diskon
        total.Text = total_harga
    End Sub

    Private Sub btn_selesai_Click(sender As Object, e As EventArgs) Handles btn_selesai.Click
        Close()
    End Sub
End Class
