<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kuisioner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kuisioner))
        Me.DGkuisioner = New System.Windows.Forms.DataGridView()
        Me.Btutup = New System.Windows.Forms.Button()
        Me.Bhapus = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGkuisioner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGkuisioner
        '
        Me.DGkuisioner.AllowUserToAddRows = False
        Me.DGkuisioner.AllowUserToDeleteRows = False
        Me.DGkuisioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGkuisioner.Location = New System.Drawing.Point(17, 65)
        Me.DGkuisioner.Name = "DGkuisioner"
        Me.DGkuisioner.ReadOnly = True
        Me.DGkuisioner.Size = New System.Drawing.Size(509, 218)
        Me.DGkuisioner.TabIndex = 49
        '
        'Btutup
        '
        Me.Btutup.BackColor = System.Drawing.Color.IndianRed
        Me.Btutup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btutup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btutup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btutup.Location = New System.Drawing.Point(440, 289)
        Me.Btutup.Name = "Btutup"
        Me.Btutup.Size = New System.Drawing.Size(86, 27)
        Me.Btutup.TabIndex = 48
        Me.Btutup.Text = "Tutup"
        Me.Btutup.UseVisualStyleBackColor = False
        '
        'Bhapus
        '
        Me.Bhapus.BackColor = System.Drawing.Color.IndianRed
        Me.Bhapus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bhapus.Location = New System.Drawing.Point(17, 289)
        Me.Bhapus.Name = "Bhapus"
        Me.Bhapus.Size = New System.Drawing.Size(86, 27)
        Me.Bhapus.TabIndex = 47
        Me.Bhapus.Text = "Hapus"
        Me.Bhapus.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 30)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Data Kuesioner"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 30)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "________________________________________________________"
        '
        'Kuisioner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(545, 325)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGkuisioner)
        Me.Controls.Add(Me.Btutup)
        Me.Controls.Add(Me.Bhapus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kuisioner"
        Me.Text = "Kuisioner"
        CType(Me.DGkuisioner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGkuisioner As DataGridView
    Friend WithEvents Btutup As Button
    Friend WithEvents Bhapus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
