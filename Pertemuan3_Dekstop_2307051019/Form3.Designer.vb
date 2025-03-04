<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Lblnip = New System.Windows.Forms.Label()
        Me.Lblnama = New System.Windows.Forms.Label()
        Me.Lblfakultas = New System.Windows.Forms.Label()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Btnproses = New System.Windows.Forms.Button()
        Me.Txtnip = New System.Windows.Forms.TextBox()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Cmbfakultas = New System.Windows.Forms.ComboBox()
        Me.Cmbjurusan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Lblnip
        '
        Me.Lblnip.AutoSize = True
        Me.Lblnip.Location = New System.Drawing.Point(63, 45)
        Me.Lblnip.Name = "Lblnip"
        Me.Lblnip.Size = New System.Drawing.Size(35, 20)
        Me.Lblnip.TabIndex = 2
        Me.Lblnip.Text = "NIP"
        '
        'Lblnama
        '
        Me.Lblnama.AutoSize = True
        Me.Lblnama.Location = New System.Drawing.Point(63, 93)
        Me.Lblnama.Name = "Lblnama"
        Me.Lblnama.Size = New System.Drawing.Size(51, 20)
        Me.Lblnama.TabIndex = 3
        Me.Lblnama.Text = "Nama"
        '
        'Lblfakultas
        '
        Me.Lblfakultas.AutoSize = True
        Me.Lblfakultas.Location = New System.Drawing.Point(63, 153)
        Me.Lblfakultas.Name = "Lblfakultas"
        Me.Lblfakultas.Size = New System.Drawing.Size(70, 20)
        Me.Lblfakultas.TabIndex = 4
        Me.Lblfakultas.Text = "Fakultas"
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Location = New System.Drawing.Point(63, 208)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(66, 20)
        Me.Lbljurusan.TabIndex = 5
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Btnproses
        '
        Me.Btnproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnproses.Location = New System.Drawing.Point(58, 270)
        Me.Btnproses.Name = "Btnproses"
        Me.Btnproses.Size = New System.Drawing.Size(88, 31)
        Me.Btnproses.TabIndex = 6
        Me.Btnproses.Text = "Process"
        Me.Btnproses.UseVisualStyleBackColor = True
        '
        'Txtnip
        '
        Me.Txtnip.Location = New System.Drawing.Point(260, 39)
        Me.Txtnip.Name = "Txtnip"
        Me.Txtnip.Size = New System.Drawing.Size(374, 26)
        Me.Txtnip.TabIndex = 7
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(260, 87)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(374, 26)
        Me.Txtnama.TabIndex = 8
        '
        'Cmbfakultas
        '
        Me.Cmbfakultas.FormattingEnabled = True
        Me.Cmbfakultas.Items.AddRange(New Object() {"Fmipa", "Fkip", "Feb"})
        Me.Cmbfakultas.Location = New System.Drawing.Point(260, 145)
        Me.Cmbfakultas.Name = "Cmbfakultas"
        Me.Cmbfakultas.Size = New System.Drawing.Size(374, 28)
        Me.Cmbfakultas.TabIndex = 9
        '
        'Cmbjurusan
        '
        Me.Cmbjurusan.FormattingEnabled = True
        Me.Cmbjurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.Cmbjurusan.Location = New System.Drawing.Point(260, 200)
        Me.Cmbjurusan.Name = "Cmbjurusan"
        Me.Cmbjurusan.Size = New System.Drawing.Size(374, 28)
        Me.Cmbjurusan.TabIndex = 10
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 379)
        Me.Controls.Add(Me.Cmbjurusan)
        Me.Controls.Add(Me.Cmbfakultas)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Txtnip)
        Me.Controls.Add(Me.Btnproses)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.Lblfakultas)
        Me.Controls.Add(Me.Lblnama)
        Me.Controls.Add(Me.Lblnip)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Lblnip As System.Windows.Forms.Label
    Friend WithEvents Lblnama As System.Windows.Forms.Label
    Friend WithEvents Lblfakultas As System.Windows.Forms.Label
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Btnproses As System.Windows.Forms.Button
    Friend WithEvents Txtnip As System.Windows.Forms.TextBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Cmbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbjurusan As System.Windows.Forms.ComboBox
End Class
