<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.outputPendapatan = New System.Windows.Forms.TextBox()
        Me.outputAsuransi = New System.Windows.Forms.TextBox()
        Me.outputPajak = New System.Windows.Forms.TextBox()
        Me.outputTransport = New System.Windows.Forms.TextBox()
        Me.outputTHR = New System.Windows.Forms.TextBox()
        Me.outputAnak = New System.Windows.Forms.TextBox()
        Me.outputNikah = New System.Windows.Forms.TextBox()
        Me.txtPendapatan = New System.Windows.Forms.Label()
        Me.txtAsuransi = New System.Windows.Forms.Label()
        Me.txtPajak = New System.Windows.Forms.Label()
        Me.txtTransport = New System.Windows.Forms.Label()
        Me.txtTHR = New System.Windows.Forms.Label()
        Me.txtAnak = New System.Windows.Forms.Label()
        Me.txtNikah = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listHariKerja = New System.Windows.Forms.ComboBox()
        Me.listTahunKerja = New System.Windows.Forms.ComboBox()
        Me.listAnak = New System.Windows.Forms.ComboBox()
        Me.inputGajiPokok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJmlAnak = New System.Windows.Forms.Label()
        Me.txtGajiPokok = New System.Windows.Forms.Label()
        Me.labelDummyTahun = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(32, 230)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(123, 31)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(161, 230)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 31)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(134, 153)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(163, 26)
        Me.btnHitung.TabIndex = 30
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.outputPendapatan)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.outputAsuransi)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.outputPajak)
        Me.GroupBox2.Controls.Add(Me.outputTransport)
        Me.GroupBox2.Controls.Add(Me.outputTHR)
        Me.GroupBox2.Controls.Add(Me.outputAnak)
        Me.GroupBox2.Controls.Add(Me.outputNikah)
        Me.GroupBox2.Controls.Add(Me.txtPendapatan)
        Me.GroupBox2.Controls.Add(Me.txtAsuransi)
        Me.GroupBox2.Controls.Add(Me.txtPajak)
        Me.GroupBox2.Controls.Add(Me.txtTransport)
        Me.GroupBox2.Controls.Add(Me.txtTHR)
        Me.GroupBox2.Controls.Add(Me.txtAnak)
        Me.GroupBox2.Controls.Add(Me.txtNikah)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 285)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'outputPendapatan
        '
        Me.outputPendapatan.Location = New System.Drawing.Point(161, 199)
        Me.outputPendapatan.Name = "outputPendapatan"
        Me.outputPendapatan.Size = New System.Drawing.Size(135, 20)
        Me.outputPendapatan.TabIndex = 22
        '
        'outputAsuransi
        '
        Me.outputAsuransi.Location = New System.Drawing.Point(161, 170)
        Me.outputAsuransi.Name = "outputAsuransi"
        Me.outputAsuransi.Size = New System.Drawing.Size(135, 20)
        Me.outputAsuransi.TabIndex = 21
        '
        'outputPajak
        '
        Me.outputPajak.Location = New System.Drawing.Point(161, 145)
        Me.outputPajak.Name = "outputPajak"
        Me.outputPajak.Size = New System.Drawing.Size(135, 20)
        Me.outputPajak.TabIndex = 20
        '
        'outputTransport
        '
        Me.outputTransport.Location = New System.Drawing.Point(161, 118)
        Me.outputTransport.Name = "outputTransport"
        Me.outputTransport.Size = New System.Drawing.Size(135, 20)
        Me.outputTransport.TabIndex = 19
        '
        'outputTHR
        '
        Me.outputTHR.Location = New System.Drawing.Point(161, 89)
        Me.outputTHR.Name = "outputTHR"
        Me.outputTHR.Size = New System.Drawing.Size(135, 20)
        Me.outputTHR.TabIndex = 18
        '
        'outputAnak
        '
        Me.outputAnak.Location = New System.Drawing.Point(161, 61)
        Me.outputAnak.Name = "outputAnak"
        Me.outputAnak.Size = New System.Drawing.Size(135, 20)
        Me.outputAnak.TabIndex = 17
        '
        'outputNikah
        '
        Me.outputNikah.Location = New System.Drawing.Point(161, 33)
        Me.outputNikah.Name = "outputNikah"
        Me.outputNikah.Size = New System.Drawing.Size(135, 20)
        Me.outputNikah.TabIndex = 16
        '
        'txtPendapatan
        '
        Me.txtPendapatan.AutoSize = True
        Me.txtPendapatan.Location = New System.Drawing.Point(29, 202)
        Me.txtPendapatan.Name = "txtPendapatan"
        Me.txtPendapatan.Size = New System.Drawing.Size(115, 13)
        Me.txtPendapatan.TabIndex = 15
        Me.txtPendapatan.Text = "Pendapatan Karyawan"
        '
        'txtAsuransi
        '
        Me.txtAsuransi.AutoSize = True
        Me.txtAsuransi.Location = New System.Drawing.Point(29, 173)
        Me.txtAsuransi.Name = "txtAsuransi"
        Me.txtAsuransi.Size = New System.Drawing.Size(72, 13)
        Me.txtAsuransi.TabIndex = 14
        Me.txtAsuransi.Text = "Polis Asuransi"
        '
        'txtPajak
        '
        Me.txtPajak.AutoSize = True
        Me.txtPajak.Location = New System.Drawing.Point(29, 148)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Size = New System.Drawing.Size(34, 13)
        Me.txtPajak.TabIndex = 13
        Me.txtPajak.Text = "Pajak"
        '
        'txtTransport
        '
        Me.txtTransport.AutoSize = True
        Me.txtTransport.Location = New System.Drawing.Point(29, 121)
        Me.txtTransport.Name = "txtTransport"
        Me.txtTransport.Size = New System.Drawing.Size(95, 13)
        Me.txtTransport.TabIndex = 12
        Me.txtTransport.Text = "Bantuan Transport"
        '
        'txtTHR
        '
        Me.txtTHR.AutoSize = True
        Me.txtTHR.Location = New System.Drawing.Point(29, 94)
        Me.txtTHR.Name = "txtTHR"
        Me.txtTHR.Size = New System.Drawing.Size(108, 13)
        Me.txtTHR.TabIndex = 11
        Me.txtTHR.Text = "Tunjangan Hari Raya"
        '
        'txtAnak
        '
        Me.txtAnak.AutoSize = True
        Me.txtAnak.Location = New System.Drawing.Point(29, 65)
        Me.txtAnak.Name = "txtAnak"
        Me.txtAnak.Size = New System.Drawing.Size(86, 13)
        Me.txtAnak.TabIndex = 10
        Me.txtAnak.Text = "Tunjangan Anak"
        '
        'txtNikah
        '
        Me.txtNikah.AutoSize = True
        Me.txtNikah.Location = New System.Drawing.Point(29, 36)
        Me.txtNikah.Name = "txtNikah"
        Me.txtNikah.Size = New System.Drawing.Size(117, 13)
        Me.txtNikah.TabIndex = 9
        Me.txtNikah.Text = "Tunjangan Suami / Istri"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listHariKerja)
        Me.GroupBox1.Controls.Add(Me.listTahunKerja)
        Me.GroupBox1.Controls.Add(Me.listAnak)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.inputGajiPokok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtJmlAnak)
        Me.GroupBox1.Controls.Add(Me.txtGajiPokok)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 197)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'listHariKerja
        '
        Me.listHariKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listHariKerja.FormattingEnabled = True
        Me.listHariKerja.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.listHariKerja.Location = New System.Drawing.Point(134, 124)
        Me.listHariKerja.Name = "listHariKerja"
        Me.listHariKerja.Size = New System.Drawing.Size(163, 21)
        Me.listHariKerja.TabIndex = 7
        '
        'listTahunKerja
        '
        Me.listTahunKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listTahunKerja.FormattingEnabled = True
        Me.listTahunKerja.Items.AddRange(New Object() {"1 Tahun", "2 Tahun", "3 Tahun", "4 Tahun", "5 Tahun", "6 Tahun", "7 Tahun", "8 Tahun", "9 Tahun", "10 Tahun", "11 Tahun", "12 Tahun", "13 Tahun", "14 Tahun", "15 Tahun"})
        Me.listTahunKerja.Location = New System.Drawing.Point(134, 93)
        Me.listTahunKerja.Name = "listTahunKerja"
        Me.listTahunKerja.Size = New System.Drawing.Size(163, 21)
        Me.listTahunKerja.TabIndex = 6
        '
        'listAnak
        '
        Me.listAnak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listAnak.FormattingEnabled = True
        Me.listAnak.Items.AddRange(New Object() {"Belum Punya", "Satu Anak", "Dua Anak"})
        Me.listAnak.Location = New System.Drawing.Point(134, 61)
        Me.listAnak.Name = "listAnak"
        Me.listAnak.Size = New System.Drawing.Size(163, 21)
        Me.listAnak.TabIndex = 5
        '
        'inputGajiPokok
        '
        Me.inputGajiPokok.Location = New System.Drawing.Point(134, 30)
        Me.inputGajiPokok.Name = "inputGajiPokok"
        Me.inputGajiPokok.Size = New System.Drawing.Size(163, 20)
        Me.inputGajiPokok.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Hari Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Masa Kerja"
        '
        'txtJmlAnak
        '
        Me.txtJmlAnak.AutoSize = True
        Me.txtJmlAnak.Location = New System.Drawing.Point(29, 66)
        Me.txtJmlAnak.Name = "txtJmlAnak"
        Me.txtJmlAnak.Size = New System.Drawing.Size(68, 13)
        Me.txtJmlAnak.TabIndex = 1
        Me.txtJmlAnak.Text = "Jumlah Anak"
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.AutoSize = True
        Me.txtGajiPokok.Location = New System.Drawing.Point(29, 33)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(59, 13)
        Me.txtGajiPokok.TabIndex = 0
        Me.txtGajiPokok.Text = "Gaji Pokok"
        '
        'labelDummyTahun
        '
        Me.labelDummyTahun.AutoSize = True
        Me.labelDummyTahun.Location = New System.Drawing.Point(725, 447)
        Me.labelDummyTahun.Name = "labelDummyTahun"
        Me.labelDummyTahun.Size = New System.Drawing.Size(0, 13)
        Me.labelDummyTahun.TabIndex = 33
        Me.labelDummyTahun.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 548)
        Me.Controls.Add(Me.labelDummyTahun)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Perhitungan Gaji Karyawan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents outputPendapatan As System.Windows.Forms.TextBox
    Friend WithEvents outputAsuransi As System.Windows.Forms.TextBox
    Friend WithEvents outputPajak As System.Windows.Forms.TextBox
    Friend WithEvents outputTransport As System.Windows.Forms.TextBox
    Friend WithEvents outputTHR As System.Windows.Forms.TextBox
    Friend WithEvents outputAnak As System.Windows.Forms.TextBox
    Friend WithEvents outputNikah As System.Windows.Forms.TextBox
    Friend WithEvents txtPendapatan As System.Windows.Forms.Label
    Friend WithEvents txtAsuransi As System.Windows.Forms.Label
    Friend WithEvents txtPajak As System.Windows.Forms.Label
    Friend WithEvents txtTransport As System.Windows.Forms.Label
    Friend WithEvents txtTHR As System.Windows.Forms.Label
    Friend WithEvents txtAnak As System.Windows.Forms.Label
    Friend WithEvents txtNikah As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listHariKerja As System.Windows.Forms.ComboBox
    Friend WithEvents listTahunKerja As System.Windows.Forms.ComboBox
    Friend WithEvents listAnak As System.Windows.Forms.ComboBox
    Friend WithEvents inputGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJmlAnak As System.Windows.Forms.Label
    Friend WithEvents txtGajiPokok As System.Windows.Forms.Label
    Friend WithEvents labelDummyTahun As System.Windows.Forms.Label

End Class
