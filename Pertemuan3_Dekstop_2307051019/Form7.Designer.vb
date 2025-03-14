<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Rbtnperempuan = New System.Windows.Forms.RadioButton()
        Me.Rbtnlaki = New System.Windows.Forms.RadioButton()
        Me.Cmbjurusan = New System.Windows.Forms.ComboBox()
        Me.Cmbfakultas = New System.Windows.Forms.ComboBox()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Txtnip = New System.Windows.Forms.TextBox()
        Me.Btnproses = New System.Windows.Forms.Button()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Lblfakultas = New System.Windows.Forms.Label()
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Lblnip = New System.Windows.Forms.Label()
        Me.Lblnilai = New System.Windows.Forms.Label()
        Me.Lbltugas = New System.Windows.Forms.Label()
        Me.Txttugas = New System.Windows.Forms.TextBox()
        Me.Txtuts = New System.Windows.Forms.TextBox()
        Me.Lbluts = New System.Windows.Forms.Label()
        Me.Txtuas = New System.Windows.Forms.TextBox()
        Me.Lbluas = New System.Windows.Forms.Label()
        Me.Txtgrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Rbtnperempuan
        '
        Me.Rbtnperempuan.AutoSize = True
        Me.Rbtnperempuan.Location = New System.Drawing.Point(419, 134)
        Me.Rbtnperempuan.Name = "Rbtnperempuan"
        Me.Rbtnperempuan.Size = New System.Drawing.Size(116, 24)
        Me.Rbtnperempuan.TabIndex = 32
        Me.Rbtnperempuan.TabStop = True
        Me.Rbtnperempuan.Text = "Perempuan"
        Me.Rbtnperempuan.UseVisualStyleBackColor = True
        '
        'Rbtnlaki
        '
        Me.Rbtnlaki.AutoSize = True
        Me.Rbtnlaki.Location = New System.Drawing.Point(231, 134)
        Me.Rbtnlaki.Name = "Rbtnlaki"
        Me.Rbtnlaki.Size = New System.Drawing.Size(99, 24)
        Me.Rbtnlaki.TabIndex = 31
        Me.Rbtnlaki.TabStop = True
        Me.Rbtnlaki.Text = "Laki - laki"
        Me.Rbtnlaki.UseVisualStyleBackColor = True
        '
        'Cmbjurusan
        '
        Me.Cmbjurusan.FormattingEnabled = True
        Me.Cmbjurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.Cmbjurusan.Location = New System.Drawing.Point(231, 247)
        Me.Cmbjurusan.Name = "Cmbjurusan"
        Me.Cmbjurusan.Size = New System.Drawing.Size(374, 28)
        Me.Cmbjurusan.TabIndex = 30
        '
        'Cmbfakultas
        '
        Me.Cmbfakultas.FormattingEnabled = True
        Me.Cmbfakultas.Items.AddRange(New Object() {"Fmipa", "Fkip", "Feb"})
        Me.Cmbfakultas.Location = New System.Drawing.Point(231, 192)
        Me.Cmbfakultas.Name = "Cmbfakultas"
        Me.Cmbfakultas.Size = New System.Drawing.Size(374, 28)
        Me.Cmbfakultas.TabIndex = 29
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(231, 69)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(374, 26)
        Me.Txtnama.TabIndex = 28
        '
        'Txtnip
        '
        Me.Txtnip.Location = New System.Drawing.Point(231, 21)
        Me.Txtnip.Name = "Txtnip"
        Me.Txtnip.Size = New System.Drawing.Size(374, 26)
        Me.Txtnip.TabIndex = 27
        '
        'Btnproses
        '
        Me.Btnproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnproses.Location = New System.Drawing.Point(29, 362)
        Me.Btnproses.Name = "Btnproses"
        Me.Btnproses.Size = New System.Drawing.Size(88, 31)
        Me.Btnproses.TabIndex = 26
        Me.Btnproses.Text = "Process"
        Me.Btnproses.UseVisualStyleBackColor = True
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Location = New System.Drawing.Point(34, 255)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(66, 20)
        Me.Lbljurusan.TabIndex = 25
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Lblfakultas
        '
        Me.Lblfakultas.AutoSize = True
        Me.Lblfakultas.Location = New System.Drawing.Point(34, 200)
        Me.Lblfakultas.Name = "Lblfakultas"
        Me.Lblfakultas.Size = New System.Drawing.Size(70, 20)
        Me.Lblfakultas.TabIndex = 24
        Me.Lblfakultas.Text = "Fakultas"
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Location = New System.Drawing.Point(34, 75)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(51, 20)
        Me.Lblnama.TabIndex = 23
        Me.Lblnama.Text = "Nama"
        '
        'Lblnip
        '
        Me.Lblnip.AutoSize = True
        Me.Lblnip.Location = New System.Drawing.Point(34, 27)
        Me.Lblnip.Name = "Lblnip"
        Me.Lblnip.Size = New System.Drawing.Size(35, 20)
        Me.Lblnip.TabIndex = 22
        Me.Lblnip.Text = "NIP"
        '
        'Lblnilai
        '
        Me.Lblnilai.AutoSize = True
        Me.Lblnilai.Location = New System.Drawing.Point(38, 319)
        Me.Lblnilai.Name = "Lblnilai"
        Me.Lblnilai.Size = New System.Drawing.Size(38, 20)
        Me.Lblnilai.TabIndex = 33
        Me.Lblnilai.Text = "Nilai"
        '
        'Lbltugas
        '
        Me.Lbltugas.AutoSize = True
        Me.Lbltugas.Location = New System.Drawing.Point(118, 319)
        Me.Lbltugas.Name = "Lbltugas"
        Me.Lbltugas.Size = New System.Drawing.Size(53, 20)
        Me.Lbltugas.TabIndex = 34
        Me.Lbltugas.Text = "Tugas"
        '
        'Txttugas
        '
        Me.Txttugas.Location = New System.Drawing.Point(175, 318)
        Me.Txttugas.Name = "Txttugas"
        Me.Txttugas.Size = New System.Drawing.Size(96, 26)
        Me.Txttugas.TabIndex = 35
        '
        'Txtuts
        '
        Me.Txtuts.Location = New System.Drawing.Point(312, 318)
        Me.Txtuts.Name = "Txtuts"
        Me.Txtuts.Size = New System.Drawing.Size(96, 26)
        Me.Txtuts.TabIndex = 37
        '
        'Lbluts
        '
        Me.Lbluts.AutoSize = True
        Me.Lbluts.Location = New System.Drawing.Point(275, 319)
        Me.Lbluts.Name = "Lbluts"
        Me.Lbluts.Size = New System.Drawing.Size(34, 20)
        Me.Lbluts.TabIndex = 36
        Me.Lbluts.Text = "Uts"
        '
        'Txtuas
        '
        Me.Txtuas.Location = New System.Drawing.Point(452, 318)
        Me.Txtuas.Name = "Txtuas"
        Me.Txtuas.Size = New System.Drawing.Size(96, 26)
        Me.Txtuas.TabIndex = 39
        '
        'Lbluas
        '
        Me.Lbluas.AutoSize = True
        Me.Lbluas.Location = New System.Drawing.Point(412, 319)
        Me.Lbluas.Name = "Lbluas"
        Me.Lbluas.Size = New System.Drawing.Size(38, 20)
        Me.Lbluas.TabIndex = 38
        Me.Lbluas.Text = "Uas"
        '
        'Txtgrade
        '
        Me.Txtgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtgrade.Location = New System.Drawing.Point(578, 318)
        Me.Txtgrade.Name = "Txtgrade"
        Me.Txtgrade.Size = New System.Drawing.Size(96, 28)
        Me.Txtgrade.TabIndex = 40
        Me.Txtgrade.Text = "-GRADE-"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 410)
        Me.Controls.Add(Me.Txtgrade)
        Me.Controls.Add(Me.Txtuas)
        Me.Controls.Add(Me.Lbluas)
        Me.Controls.Add(Me.Txtuts)
        Me.Controls.Add(Me.Lbluts)
        Me.Controls.Add(Me.Txttugas)
        Me.Controls.Add(Me.Lbltugas)
        Me.Controls.Add(Me.Lblnilai)
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
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rbtnperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnlaki As System.Windows.Forms.RadioButton
    Friend WithEvents Cmbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Txtnip As System.Windows.Forms.TextBox
    Friend WithEvents Btnproses As System.Windows.Forms.Button
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Lblfakultas As System.Windows.Forms.Label
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Lblnip As System.Windows.Forms.Label
    Friend WithEvents Lblnilai As System.Windows.Forms.Label
    Friend WithEvents Lbltugas As System.Windows.Forms.Label
    Friend WithEvents Txttugas As System.Windows.Forms.TextBox
    Friend WithEvents Txtuts As System.Windows.Forms.TextBox
    Friend WithEvents Lbluts As System.Windows.Forms.Label
    Friend WithEvents Txtuas As System.Windows.Forms.TextBox
    Friend WithEvents Lbluas As System.Windows.Forms.Label
    Friend WithEvents Txtgrade As System.Windows.Forms.TextBox
End Class
