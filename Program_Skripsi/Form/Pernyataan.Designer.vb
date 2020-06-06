<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pernyataan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pernyataan))
        Me.DGpernyataan = New System.Windows.Forms.DataGridView()
        Me.Tisi_pernyataan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ckd_domain = New System.Windows.Forms.ComboBox()
        Me.Btutup = New System.Windows.Forms.Button()
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.Bhapus = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGpernyataan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGpernyataan
        '
        Me.DGpernyataan.AllowUserToAddRows = False
        Me.DGpernyataan.AllowUserToDeleteRows = False
        Me.DGpernyataan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpernyataan.Location = New System.Drawing.Point(19, 251)
        Me.DGpernyataan.Name = "DGpernyataan"
        Me.DGpernyataan.ReadOnly = True
        Me.DGpernyataan.Size = New System.Drawing.Size(444, 150)
        Me.DGpernyataan.TabIndex = 46
        '
        'Tisi_pernyataan
        '
        Me.Tisi_pernyataan.Location = New System.Drawing.Point(123, 88)
        Me.Tisi_pernyataan.Multiline = True
        Me.Tisi_pernyataan.Name = "Tisi_pernyataan"
        Me.Tisi_pernyataan.Size = New System.Drawing.Size(340, 124)
        Me.Tisi_pernyataan.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 17)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Isi Pernyataan"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 17)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Domain"
        '
        'Ckd_domain
        '
        Me.Ckd_domain.DisplayMember = "nm_domain"
        Me.Ckd_domain.FormattingEnabled = True
        Me.Ckd_domain.Location = New System.Drawing.Point(123, 58)
        Me.Ckd_domain.Name = "Ckd_domain"
        Me.Ckd_domain.Size = New System.Drawing.Size(340, 21)
        Me.Ckd_domain.TabIndex = 75
        Me.Ckd_domain.ValueMember = "kd_domain"
        '
        'Btutup
        '
        Me.Btutup.BackColor = System.Drawing.Color.IndianRed
        Me.Btutup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btutup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btutup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btutup.Location = New System.Drawing.Point(377, 416)
        Me.Btutup.Name = "Btutup"
        Me.Btutup.Size = New System.Drawing.Size(86, 27)
        Me.Btutup.TabIndex = 78
        Me.Btutup.Text = "Tutup"
        Me.Btutup.UseVisualStyleBackColor = False
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.IndianRed
        Me.Bbatal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bbatal.Location = New System.Drawing.Point(19, 218)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(86, 27)
        Me.Bbatal.TabIndex = 77
        Me.Bbatal.Text = "Batal"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'Bhapus
        '
        Me.Bhapus.BackColor = System.Drawing.Color.IndianRed
        Me.Bhapus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bhapus.Location = New System.Drawing.Point(19, 416)
        Me.Bhapus.Name = "Bhapus"
        Me.Bhapus.Size = New System.Drawing.Size(86, 27)
        Me.Bhapus.TabIndex = 76
        Me.Bhapus.Text = "Hapus"
        Me.Bhapus.UseVisualStyleBackColor = False
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.IndianRed
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(377, 218)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(86, 27)
        Me.Bsimpan.TabIndex = 75
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.IndianRed
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(199, 218)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(86, 27)
        Me.Bedit.TabIndex = 79
        Me.Bedit.Text = "Edit"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 30)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Data Pernyataan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(454, 30)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "_________________________________________________"
        '
        'Pernyataan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(475, 455)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Bedit)
        Me.Controls.Add(Me.Ckd_domain)
        Me.Controls.Add(Me.Btutup)
        Me.Controls.Add(Me.Tisi_pernyataan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Bbatal)
        Me.Controls.Add(Me.Bhapus)
        Me.Controls.Add(Me.DGpernyataan)
        Me.Controls.Add(Me.Bsimpan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pernyataan"
        Me.Text = "Data Pernyataan"
        CType(Me.DGpernyataan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGpernyataan As DataGridView
    Friend WithEvents Tisi_pernyataan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Ckd_domain As ComboBox
    Friend WithEvents Btutup As Button
    Friend WithEvents Bbatal As Button
    Friend WithEvents Bhapus As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Bedit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
