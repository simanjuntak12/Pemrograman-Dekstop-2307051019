<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Cmbjurusan = New System.Windows.Forms.ComboBox()
        Me.Cmbfakultas = New System.Windows.Forms.ComboBox()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Txtnip = New System.Windows.Forms.TextBox()
        Me.Btnproses = New System.Windows.Forms.Button()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Lblfakultas = New System.Windows.Forms.Label()
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Lblnip = New System.Windows.Forms.Label()
        Me.Rbtnlaki = New System.Windows.Forms.RadioButton()
        Me.Rbtnperempuan = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Cmbjurusan
        '
        Me.Cmbjurusan.FormattingEnabled = True
        Me.Cmbjurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.Cmbjurusan.Location = New System.Drawing.Point(252, 253)
        Me.Cmbjurusan.Name = "Cmbjurusan"
        Me.Cmbjurusan.Size = New System.Drawing.Size(374, 28)
        Me.Cmbjurusan.TabIndex = 19
        '
        'Cmbfakultas
        '
        Me.Cmbfakultas.FormattingEnabled = True
        Me.Cmbfakultas.Items.AddRange(New Object() {"Fmipa", "Fkip", "Feb"})
        Me.Cmbfakultas.Location = New System.Drawing.Point(252, 198)
        Me.Cmbfakultas.Name = "Cmbfakultas"
        Me.Cmbfakultas.Size = New System.Drawing.Size(374, 28)
        Me.Cmbfakultas.TabIndex = 18
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(252, 75)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(374, 26)
        Me.Txtnama.TabIndex = 17
        '
        'Txtnip
        '
        Me.Txtnip.Location = New System.Drawing.Point(252, 27)
        Me.Txtnip.Name = "Txtnip"
        Me.Txtnip.Size = New System.Drawing.Size(374, 26)
        Me.Txtnip.TabIndex = 16
        '
        'Btnproses
        '
        Me.Btnproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnproses.Location = New System.Drawing.Point(50, 323)
        Me.Btnproses.Name = "Btnproses"
        Me.Btnproses.Size = New System.Drawing.Size(88, 31)
        Me.Btnproses.TabIndex = 15
        Me.Btnproses.Text = "Process"
        Me.Btnproses.UseVisualStyleBackColor = True
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Location = New System.Drawing.Point(55, 261)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(66, 20)
        Me.Lbljurusan.TabIndex = 14
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Lblfakultas
        '
        Me.Lblfakultas.AutoSize = True
        Me.Lblfakultas.Location = New System.Drawing.Point(55, 206)
        Me.Lblfakultas.Name = "Lblfakultas"
        Me.Lblfakultas.Size = New System.Drawing.Size(70, 20)
        Me.Lblfakultas.TabIndex = 13
        Me.Lblfakultas.Text = "Fakultas"
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Location = New System.Drawing.Point(55, 81)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(51, 20)
        Me.Lblnama.TabIndex = 12
        Me.Lblnama.Text = "Nama"
        '
        'Lblnip
        '
        Me.Lblnip.AutoSize = True
        Me.Lblnip.Location = New System.Drawing.Point(55, 33)
        Me.Lblnip.Name = "Lblnip"
        Me.Lblnip.Size = New System.Drawing.Size(35, 20)
        Me.Lblnip.TabIndex = 11
        Me.Lblnip.Text = "NIP"
        '
        'Rbtnlaki
        '
        Me.Rbtnlaki.AutoSize = True
        Me.Rbtnlaki.Location = New System.Drawing.Point(252, 140)
        Me.Rbtnlaki.Name = "Rbtnlaki"
        Me.Rbtnlaki.Size = New System.Drawing.Size(99, 24)
        Me.Rbtnlaki.TabIndex = 20
        Me.Rbtnlaki.TabStop = True
        Me.Rbtnlaki.Text = "Laki - laki"
        Me.Rbtnlaki.UseVisualStyleBackColor = True
        '
        'Rbtnperempuan
        '
        Me.Rbtnperempuan.AutoSize = True
        Me.Rbtnperempuan.Location = New System.Drawing.Point(440, 140)
        Me.Rbtnperempuan.Name = "Rbtnperempuan"
        Me.Rbtnperempuan.Size = New System.Drawing.Size(116, 24)
        Me.Rbtnperempuan.TabIndex = 21
        Me.Rbtnperempuan.TabStop = True
        Me.Rbtnperempuan.Text = "Perempuan"
        Me.Rbtnperempuan.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 375)
        Me.Controls.Add(Me.Rbtnperempuan)
        Me.Controls.Add(Me.Rbtnlaki)
        Me.Controls.Add(Me.Cmbjurusan)
        Me.Controls.Add(Me.Cmbfakultas)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Txtnip)
        Me.Controls.Add(Me.Btnproses)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.Lblfakultas)
        Me.Controls.Add(Me.Lblnama)
        Me.Controls.Add(Me.Lblnip)
        Me.Name = "Form4"
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Txtnip As System.Windows.Forms.TextBox
    Friend WithEvents Btnproses As System.Windows.Forms.Button
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Lblfakultas As System.Windows.Forms.Label
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Lblnip As System.Windows.Forms.Label
    Friend WithEvents Rbtnlaki As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnperempuan As System.Windows.Forms.RadioButton
End Class
