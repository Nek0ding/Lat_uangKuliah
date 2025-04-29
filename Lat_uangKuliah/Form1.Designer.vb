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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        cmb_jurusan = New ComboBox()
        OpenFileDialog1 = New OpenFileDialog()
        output_uangKuliah = New TextBox()
        btn_regular = New RadioButton()
        btn_beasiswa = New RadioButton()
        diskon = New TextBox()
        total = New TextBox()
        btn_hitung = New Button()
        btn_selesai = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 48)
        Label1.TabIndex = 0
        Label1.Text = "TRANSAKSI PEMBAYARAN KULIAH"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 30)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 30)
        Label3.TabIndex = 2
        Label3.Text = "Jurusan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(46, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 30)
        Label4.TabIndex = 3
        Label4.Text = "Uang Kuliah"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(46, 293)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 30)
        Label5.TabIndex = 4
        Label5.Text = "Diskon"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(46, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 30)
        Label6.TabIndex = 5
        Label6.Text = "Jenis"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(46, 349)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 30)
        Label7.TabIndex = 6
        Label7.Text = "Total"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(206, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 31)
        TextBox1.TabIndex = 7
        ' 
        ' cmb_jurusan
        ' 
        cmb_jurusan.FormattingEnabled = True
        cmb_jurusan.Location = New Point(206, 131)
        cmb_jurusan.Name = "cmb_jurusan"
        cmb_jurusan.Size = New Size(177, 33)
        cmb_jurusan.TabIndex = 8
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' output_uangKuliah
        ' 
        output_uangKuliah.Location = New Point(206, 188)
        output_uangKuliah.Name = "output_uangKuliah"
        output_uangKuliah.ReadOnly = True
        output_uangKuliah.Size = New Size(173, 31)
        output_uangKuliah.TabIndex = 9
        ' 
        ' btn_regular
        ' 
        btn_regular.AutoSize = True
        btn_regular.Location = New Point(206, 236)
        btn_regular.Name = "btn_regular"
        btn_regular.Size = New Size(96, 29)
        btn_regular.TabIndex = 10
        btn_regular.TabStop = True
        btn_regular.Text = "Regular"
        btn_regular.UseVisualStyleBackColor = True
        ' 
        ' btn_beasiswa
        ' 
        btn_beasiswa.AutoSize = True
        btn_beasiswa.Location = New Point(372, 236)
        btn_beasiswa.Name = "btn_beasiswa"
        btn_beasiswa.Size = New Size(107, 29)
        btn_beasiswa.TabIndex = 11
        btn_beasiswa.TabStop = True
        btn_beasiswa.Text = "Beasiswa"
        btn_beasiswa.UseVisualStyleBackColor = True
        ' 
        ' diskon
        ' 
        diskon.Location = New Point(206, 294)
        diskon.Name = "diskon"
        diskon.ReadOnly = True
        diskon.Size = New Size(173, 31)
        diskon.TabIndex = 12
        ' 
        ' total
        ' 
        total.Location = New Point(206, 350)
        total.Name = "total"
        total.ReadOnly = True
        total.Size = New Size(173, 31)
        total.TabIndex = 13
        ' 
        ' btn_hitung
        ' 
        btn_hitung.Location = New Point(566, 146)
        btn_hitung.Name = "btn_hitung"
        btn_hitung.Size = New Size(163, 52)
        btn_hitung.TabIndex = 14
        btn_hitung.Text = "Hitung"
        btn_hitung.UseVisualStyleBackColor = True
        ' 
        ' btn_selesai
        ' 
        btn_selesai.Location = New Point(566, 262)
        btn_selesai.Name = "btn_selesai"
        btn_selesai.Size = New Size(163, 52)
        btn_selesai.TabIndex = 15
        btn_selesai.Text = "Selesai"
        btn_selesai.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_selesai)
        Controls.Add(btn_hitung)
        Controls.Add(total)
        Controls.Add(diskon)
        Controls.Add(btn_beasiswa)
        Controls.Add(btn_regular)
        Controls.Add(output_uangKuliah)
        Controls.Add(cmb_jurusan)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmb_jurusan As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents output_uangKuliah As TextBox
    Friend WithEvents btn_regular As RadioButton
    Friend WithEvents btn_beasiswa As RadioButton
    Friend WithEvents diskon As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents btn_hitung As Button
    Friend WithEvents btn_selesai As Button

End Class
