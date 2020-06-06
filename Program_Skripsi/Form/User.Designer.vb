<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Tusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGuser = New System.Windows.Forms.DataGridView()
        Me.Btutup = New System.Windows.Forms.Button()
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.Bhapus = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tusername
        '
        Me.Tusername.Location = New System.Drawing.Point(119, 59)
        Me.Tusername.Name = "Tusername"
        Me.Tusername.Size = New System.Drawing.Size(256, 20)
        Me.Tusername.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username"
        '
        'Tpassword
        '
        Me.Tpassword.Location = New System.Drawing.Point(119, 85)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpassword.Size = New System.Drawing.Size(256, 20)
        Me.Tpassword.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'DGuser
        '
        Me.DGuser.AllowUserToAddRows = False
        Me.DGuser.AllowUserToDeleteRows = False
        Me.DGuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGuser.Location = New System.Drawing.Point(17, 177)
        Me.DGuser.Name = "DGuser"
        Me.DGuser.ReadOnly = True
        Me.DGuser.Size = New System.Drawing.Size(358, 144)
        Me.DGuser.TabIndex = 25
        '
        'Btutup
        '
        Me.Btutup.BackColor = System.Drawing.Color.IndianRed
        Me.Btutup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btutup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btutup.ForeColor = System.Drawing.Color.White
        Me.Btutup.Location = New System.Drawing.Point(289, 327)
        Me.Btutup.Name = "Btutup"
        Me.Btutup.Size = New System.Drawing.Size(86, 27)
        Me.Btutup.TabIndex = 47
        Me.Btutup.Text = "Tutup"
        Me.Btutup.UseVisualStyleBackColor = False
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.IndianRed
        Me.Bbatal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbatal.ForeColor = System.Drawing.Color.White
        Me.Bbatal.Location = New System.Drawing.Point(17, 144)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(86, 27)
        Me.Bbatal.TabIndex = 46
        Me.Bbatal.Text = "Batal"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'Bhapus
        '
        Me.Bhapus.BackColor = System.Drawing.Color.IndianRed
        Me.Bhapus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus.ForeColor = System.Drawing.Color.White
        Me.Bhapus.Location = New System.Drawing.Point(17, 327)
        Me.Bhapus.Name = "Bhapus"
        Me.Bhapus.Size = New System.Drawing.Size(86, 27)
        Me.Bhapus.TabIndex = 45
        Me.Bhapus.Text = "Hapus"
        Me.Bhapus.UseVisualStyleBackColor = False
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.IndianRed
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.Color.White
        Me.Bsimpan.Location = New System.Drawing.Point(289, 144)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(86, 27)
        Me.Bsimpan.TabIndex = 44
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.IndianRed
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.Color.White
        Me.Bedit.Location = New System.Drawing.Point(152, 144)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(86, 27)
        Me.Bedit.TabIndex = 54
        Me.Bedit.Text = "Edit"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(119, 111)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(256, 20)
        Me.Temail.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 30)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Data User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 30)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "________________________________________"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(389, 369)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Temail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bedit)
        Me.Controls.Add(Me.Btutup)
        Me.Controls.Add(Me.Bbatal)
        Me.Controls.Add(Me.Bhapus)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.DGuser)
        Me.Controls.Add(Me.Tpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tusername)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User"
        Me.Text = "Data User"
        CType(Me.DGuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGuser As DataGridView
    Friend WithEvents Btutup As Button
    Friend WithEvents Bbatal As Button
    Friend WithEvents Bhapus As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Bedit As Button
    Friend WithEvents Temail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
