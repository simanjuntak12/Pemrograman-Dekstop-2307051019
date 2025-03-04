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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.lbljurusan = New System.Windows.Forms.Label()
        Me.Txtjurusan = New System.Windows.Forms.TextBox()
        Me.lblmatakuliah = New System.Windows.Forms.Label()
        Me.Txtmatakuliah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(84, 65)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(81, 29)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(181, 69)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(373, 26)
        Me.TxtNama.TabIndex = 1
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(246, 376)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(152, 36)
        Me.BtnProcess.TabIndex = 2
        Me.BtnProcess.Text = "Process"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'lbljurusan
        '
        Me.lbljurusan.AutoSize = True
        Me.lbljurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljurusan.Location = New System.Drawing.Point(73, 131)
        Me.lbljurusan.Name = "lbljurusan"
        Me.lbljurusan.Size = New System.Drawing.Size(104, 29)
        Me.lbljurusan.TabIndex = 3
        Me.lbljurusan.Text = "Jurusan"
        '
        'Txtjurusan
        '
        Me.Txtjurusan.Location = New System.Drawing.Point(183, 135)
        Me.Txtjurusan.Name = "Txtjurusan"
        Me.Txtjurusan.Size = New System.Drawing.Size(371, 26)
        Me.Txtjurusan.TabIndex = 4
        '
        'lblmatakuliah
        '
        Me.lblmatakuliah.AutoSize = True
        Me.lblmatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatakuliah.Location = New System.Drawing.Point(28, 191)
        Me.lblmatakuliah.Name = "lblmatakuliah"
        Me.lblmatakuliah.Size = New System.Drawing.Size(149, 29)
        Me.lblmatakuliah.TabIndex = 5
        Me.lblmatakuliah.Text = "Mata Kuliah"
        '
        'Txtmatakuliah
        '
        Me.Txtmatakuliah.Location = New System.Drawing.Point(181, 194)
        Me.Txtmatakuliah.Name = "Txtmatakuliah"
        Me.Txtmatakuliah.Size = New System.Drawing.Size(373, 26)
        Me.Txtmatakuliah.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 435)
        Me.Controls.Add(Me.Txtmatakuliah)
        Me.Controls.Add(Me.lblmatakuliah)
        Me.Controls.Add(Me.Txtjurusan)
        Me.Controls.Add(Me.lbljurusan)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents BtnProcess As System.Windows.Forms.Button
    Friend WithEvents lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Txtjurusan As System.Windows.Forms.TextBox
    Friend WithEvents lblmatakuliah As System.Windows.Forms.Label
    Friend WithEvents Txtmatakuliah As System.Windows.Forms.TextBox

End Class
