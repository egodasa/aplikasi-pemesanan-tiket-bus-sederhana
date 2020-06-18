<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTiket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FTiket))
        Me.DGtiket = New System.Windows.Forms.DataGridView()
        Me.Tjumlah_tiket = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tjumlah_bus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tharga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tkelas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Btutup = New System.Windows.Forms.Button()
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.Bhapus = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Tjurusan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tkode_tiket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGtiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGtiket
        '
        Me.DGtiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtiket.Location = New System.Drawing.Point(21, 86)
        Me.DGtiket.Name = "DGtiket"
        Me.DGtiket.Size = New System.Drawing.Size(528, 150)
        Me.DGtiket.TabIndex = 95
        '
        'Tjumlah_tiket
        '
        Me.Tjumlah_tiket.Location = New System.Drawing.Point(369, 334)
        Me.Tjumlah_tiket.Name = "Tjumlah_tiket"
        Me.Tjumlah_tiket.Size = New System.Drawing.Size(163, 20)
        Me.Tjumlah_tiket.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(277, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Jumlah Tiket"
        '
        'Tjumlah_bus
        '
        Me.Tjumlah_bus.Location = New System.Drawing.Point(125, 334)
        Me.Tjumlah_bus.Name = "Tjumlah_bus"
        Me.Tjumlah_bus.Size = New System.Drawing.Size(129, 20)
        Me.Tjumlah_bus.TabIndex = 91
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Jumlah Bus"
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(369, 297)
        Me.Tharga.Name = "Tharga"
        Me.Tharga.Size = New System.Drawing.Size(163, 20)
        Me.Tharga.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(277, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Harga"
        '
        'Tkelas
        '
        Me.Tkelas.Location = New System.Drawing.Point(369, 263)
        Me.Tkelas.Name = "Tkelas"
        Me.Tkelas.Size = New System.Drawing.Size(163, 20)
        Me.Tkelas.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(277, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Pencarian"
        '
        'Tcari
        '
        Me.Tcari.Location = New System.Drawing.Point(124, 60)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(425, 20)
        Me.Tcari.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 30)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Data Tiket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 30)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "___________________________________________________________"
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.RoyalBlue
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(332, 374)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(86, 27)
        Me.Bedit.TabIndex = 81
        Me.Bedit.Text = "Edit"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Btutup
        '
        Me.Btutup.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btutup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btutup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btutup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btutup.Location = New System.Drawing.Point(124, 374)
        Me.Btutup.Name = "Btutup"
        Me.Btutup.Size = New System.Drawing.Size(86, 27)
        Me.Btutup.TabIndex = 80
        Me.Btutup.Text = "Tutup"
        Me.Btutup.UseVisualStyleBackColor = False
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.RoyalBlue
        Me.Bbatal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bbatal.Location = New System.Drawing.Point(230, 374)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(86, 27)
        Me.Bbatal.TabIndex = 79
        Me.Bbatal.Text = "Batal"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'Bhapus
        '
        Me.Bhapus.BackColor = System.Drawing.Color.RoyalBlue
        Me.Bhapus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bhapus.Location = New System.Drawing.Point(20, 374)
        Me.Bhapus.Name = "Bhapus"
        Me.Bhapus.Size = New System.Drawing.Size(86, 27)
        Me.Bhapus.TabIndex = 78
        Me.Bhapus.Text = "Hapus"
        Me.Bhapus.UseVisualStyleBackColor = False
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.RoyalBlue
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(437, 374)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(86, 27)
        Me.Bsimpan.TabIndex = 77
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Tjurusan
        '
        Me.Tjurusan.Location = New System.Drawing.Point(125, 297)
        Me.Tjurusan.Name = "Tjurusan"
        Me.Tjurusan.Size = New System.Drawing.Size(129, 20)
        Me.Tjurusan.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Jurusan"
        '
        'Tkode_tiket
        '
        Me.Tkode_tiket.Location = New System.Drawing.Point(125, 263)
        Me.Tkode_tiket.Name = "Tkode_tiket"
        Me.Tkode_tiket.Size = New System.Drawing.Size(129, 20)
        Me.Tkode_tiket.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Kode Tiket"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(544, 30)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "___________________________________________________________"
        '
        'FTiket2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(570, 418)
        Me.Controls.Add(Me.DGtiket)
        Me.Controls.Add(Me.Tjumlah_tiket)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tjumlah_bus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tharga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tkelas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tcari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bedit)
        Me.Controls.Add(Me.Btutup)
        Me.Controls.Add(Me.Bbatal)
        Me.Controls.Add(Me.Bhapus)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Tjurusan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tkode_tiket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FTiket2"
        Me.Text = "Data Tiket"
        CType(Me.DGtiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGtiket As System.Windows.Forms.DataGridView
    Friend WithEvents Tjumlah_tiket As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tjumlah_bus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tharga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tkelas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Btutup As System.Windows.Forms.Button
    Friend WithEvents Bbatal As System.Windows.Forms.Button
    Friend WithEvents Bhapus As System.Windows.Forms.Button
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents Tjurusan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tkode_tiket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
