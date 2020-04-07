Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Start Condition '
        btnHitung.Enabled = False
        btnReset.Enabled = False
        outputNikah.ReadOnly = True
        outputAnak.ReadOnly = True
        outputTHR.ReadOnly = True
        outputTransport.ReadOnly = True
        outputPajak.ReadOnly = True
        outputAsuransi.ReadOnly = True
        outputPendapatan.ReadOnly = True

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        If inputGajiPokok.Text = "" OrElse inputGajiPokok.Text <= 0 Then
            MsgBox("Masukan Gaji Pokok")
            inputGajiPokok.Focus()
            btnHitung.Enabled = False
        ElseIf inputGajiPokok.Text > 99999999 Then
            MsgBox("Gaji Melebihi Batas")
            inputGajiPokok.Clear()
            inputGajiPokok.Focus()
        ElseIf listAnak.Text = "" Then
            MsgBox("Masukan Jumlah Anak")
            listAnak.Focus()
            btnHitung.Enabled = False
        ElseIf listTahunKerja.Text = "" Then
            MsgBox("Masukan Jumlah Masa Kerja")
            listTahunKerja.Focus()
            btnHitung.Enabled = False
        ElseIf listHariKerja.Text = "" Then
            MsgBox("Masukan Jumlah Hari Kerja")
            listHariKerja.Focus()
        Else
            btnHitung.Enabled = True
            Dim Anak1 As Int32
            Dim Anak2 As Int32
            outputNikah.Text = inputGajiPokok.Text * 0.1
            Anak1 = inputGajiPokok.Text * 0.05
            Anak2 = (inputGajiPokok.Text * 0.05) * 2
            If listAnak.Text = "Belum Punya" Then
                outputAnak.Text = 0
            ElseIf listAnak.Text = "Satu Anak" Then
                outputAnak.Text = Anak1
            Else
                If listAnak.Text = "Dua Anak" Then
                    outputAnak.Text = Anak2
                End If
            End If
            outputTHR.Text = 25000 * labelDummyTahun.Text
            outputTransport.Text = listHariKerja.Text * 10000
            outputPajak.Text = (Val(inputGajiPokok.Text) + Val(outputNikah.Text) + Val(outputAnak.Text)) * 0.15
            outputAsuransi.Text = 20000
            outputPendapatan.Text = Val(inputGajiPokok.Text) + Val(outputNikah.Text) + Val(outputAnak.Text) + Val(outputTHR.Text) - Val(outputPajak.Text) + outputTransport.Text - Val(outputAsuransi.Text)
            ' Make button Reset Enable '
            btnReset.Enabled = True
        End If

    End Sub

    Private Sub listTahunKerja_LostFocus(sender As Object, e As EventArgs) Handles listTahunKerja.LostFocus

        btnHitung.Enabled = True

        If listTahunKerja.Text = "1 Tahun" Then
            labelDummyTahun.Text = 1
        End If
        If listTahunKerja.Text = "2 Tahun" Then
            labelDummyTahun.Text = 2
        End If
        If listTahunKerja.Text = "3 Tahun" Then
            labelDummyTahun.Text = 3
        End If
        If listTahunKerja.Text = "4 Tahun" Then
            labelDummyTahun.Text = 4
        End If
        If listTahunKerja.Text = "5 Tahun" Then
            labelDummyTahun.Text = 5
        End If
        If listTahunKerja.Text = "6 Tahun" Then
            labelDummyTahun.Text = 6
        End If
        If listTahunKerja.Text = "7 Tahun" Then
            labelDummyTahun.Text = 7
        End If
        If listTahunKerja.Text = "8 Tahun" Then
            labelDummyTahun.Text = 8
        End If
        If listTahunKerja.Text = "9 Tahun" Then
            labelDummyTahun.Text = 9
        End If
        If listTahunKerja.Text = "10 Tahun" Then
            labelDummyTahun.Text = 10
        End If
        If listTahunKerja.Text = "11 Tahun" Then
            labelDummyTahun.Text = 11
        End If
        If listTahunKerja.Text = "12 Tahun" Then
            labelDummyTahun.Text = 12
        End If
        If listTahunKerja.Text = "13 Tahun" Then
            labelDummyTahun.Text = 13
        End If
        If listTahunKerja.Text = "14 Tahun" Then
            labelDummyTahun.Text = 14
        End If
        If listTahunKerja.Text = "15 Tahun" Then
            labelDummyTahun.Text = 15
        End If

    End Sub

    Private Sub inputGajiPokok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inputGajiPokok.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Enter And Keys.Back) Then e.Handled = True
    End Sub

    Private Sub InputGajiPokok_LostFocus(sender As Object, e As EventArgs) Handles inputGajiPokok.LostFocus
        btnHitung.Enabled = True
    End Sub

    Private Sub listAnak_LostFocus(sender As Object, e As EventArgs) Handles listAnak.LostFocus
        btnHitung.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        inputGajiPokok.Clear()
        listAnak.SelectedIndex = -1
        listTahunKerja.SelectedIndex = -1
        listHariKerja.SelectedIndex = -1
        outputNikah.Clear()
        outputAnak.Clear()
        outputTHR.Clear()
        outputTransport.Clear()
        outputPajak.Clear()
        outputAsuransi.Clear()
        outputPendapatan.Clear()
        btnHitung.Enabled = False
        btnReset.Enabled = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
