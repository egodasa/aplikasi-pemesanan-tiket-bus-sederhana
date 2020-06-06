<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IsiKuisioner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IsiKuisioner))
        Me.DGkuisioner = New System.Windows.Forms.DataGridView()
        Me.pernyataan_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isi_pernyataan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_pernyataan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilai_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilai_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilai_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilai_4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilai_5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tnm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cjk = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cusia = New System.Windows.Forms.ComboBox()
        CType(Me.DGkuisioner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGkuisioner
        '
        Me.DGkuisioner.AllowUserToAddRows = False
        Me.DGkuisioner.AllowUserToDeleteRows = False
        Me.DGkuisioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGkuisioner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pernyataan_id, Me.isi_pernyataan, Me.jenis_pernyataan, Me.nilai_1, Me.nilai_2, Me.nilai_3, Me.nilai_4, Me.nilai_5})
        Me.DGkuisioner.Location = New System.Drawing.Point(22, 116)
        Me.DGkuisioner.Name = "DGkuisioner"
        Me.DGkuisioner.ReadOnly = True
        Me.DGkuisioner.Size = New System.Drawing.Size(958, 337)
        Me.DGkuisioner.TabIndex = 0
        '
        'pernyataan_id
        '
        Me.pernyataan_id.HeaderText = "id"
        Me.pernyataan_id.Name = "pernyataan_id"
        Me.pernyataan_id.ReadOnly = True
        Me.pernyataan_id.Visible = False
        '
        'isi_pernyataan
        '
        Me.isi_pernyataan.HeaderText = "Isi Pernyataan"
        Me.isi_pernyataan.Name = "isi_pernyataan"
        Me.isi_pernyataan.ReadOnly = True
        '
        'jenis_pernyataan
        '
        Me.jenis_pernyataan.HeaderText = "Domain"
        Me.jenis_pernyataan.Name = "jenis_pernyataan"
        Me.jenis_pernyataan.ReadOnly = True
        '
        'nilai_1
        '
        Me.nilai_1.HeaderText = "Tidak Setuju"
        Me.nilai_1.Name = "nilai_1"
        Me.nilai_1.ReadOnly = True
        '
        'nilai_2
        '
        Me.nilai_2.HeaderText = "Kurang Setuju"
        Me.nilai_2.Name = "nilai_2"
        Me.nilai_2.ReadOnly = True
        '
        'nilai_3
        '
        Me.nilai_3.HeaderText = "Cukup Setuju"
        Me.nilai_3.Name = "nilai_3"
        Me.nilai_3.ReadOnly = True
        '
        'nilai_4
        '
        Me.nilai_4.HeaderText = "Setuju"
        Me.nilai_4.Name = "nilai_4"
        Me.nilai_4.ReadOnly = True
        '
        'nilai_5
        '
        Me.nilai_5.HeaderText = "Sangat Setuju"
        Me.nilai_5.Name = "nilai_5"
        Me.nilai_5.ReadOnly = True
        '
        'Tnm
        '
        Me.Tnm.Location = New System.Drawing.Point(141, 25)
        Me.Tnm.Name = "Tnm"
        Me.Tnm.Size = New System.Drawing.Size(143, 20)
        Me.Tnm.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nama Responden"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Usia Responden"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(569, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Cjk
        '
        Me.Cjk.FormattingEnabled = True
        Me.Cjk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.Cjk.Location = New System.Drawing.Point(664, 25)
        Me.Cjk.Name = "Cjk"
        Me.Cjk.Size = New System.Drawing.Size(143, 21)
        Me.Cjk.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(441, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Silahkan klik pada kolom pilihan (biru) sampai warna kolomnya berubah"
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.OrangeRed
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(825, 459)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(155, 39)
        Me.Bsimpan.TabIndex = 37
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(22, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 39)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Tutup"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 30)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Daftar Pernyataan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(958, 30)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "_________________________________________________________________________________" &
    "________________________"
        '
        'Cusia
        '
        Me.Cusia.FormattingEnabled = True
        Me.Cusia.Items.AddRange(New Object() {"17 - 25 Tahun", "26 - 45 Tahun", "> 46 Tahun"})
        Me.Cusia.Location = New System.Drawing.Point(414, 25)
        Me.Cusia.Name = "Cusia"
        Me.Cusia.Size = New System.Drawing.Size(143, 21)
        Me.Cusia.TabIndex = 61
        '
        'IsiKuisioner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(993, 511)
        Me.Controls.Add(Me.Cusia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cjk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tnm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGkuisioner)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IsiKuisioner"
        Me.Text = "Kuisioner"
        CType(Me.DGkuisioner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGkuisioner As DataGridView
    Friend WithEvents Tnm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cjk As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pernyataan_id As DataGridViewTextBoxColumn
    Friend WithEvents isi_pernyataan As DataGridViewTextBoxColumn
    Friend WithEvents jenis_pernyataan As DataGridViewTextBoxColumn
    Friend WithEvents nilai_1 As DataGridViewTextBoxColumn
    Friend WithEvents nilai_2 As DataGridViewTextBoxColumn
    Friend WithEvents nilai_3 As DataGridViewTextBoxColumn
    Friend WithEvents nilai_4 As DataGridViewTextBoxColumn
    Friend WithEvents nilai_5 As DataGridViewTextBoxColumn
    Friend WithEvents Cusia As ComboBox
End Class
