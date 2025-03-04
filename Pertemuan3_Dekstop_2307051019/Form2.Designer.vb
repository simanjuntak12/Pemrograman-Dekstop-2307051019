<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblnilai1 = New System.Windows.Forms.Label()
        Me.Txtnilai1 = New System.Windows.Forms.TextBox()
        Me.Txtnilai2 = New System.Windows.Forms.TextBox()
        Me.lblnilai2 = New System.Windows.Forms.Label()
        Me.Txthasil = New System.Windows.Forms.TextBox()
        Me.Lblhasil = New System.Windows.Forms.Label()
        Me.Btnkali = New System.Windows.Forms.Button()
        Me.Btnbagi = New System.Windows.Forms.Button()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.Btnkurang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnilai1
        '
        Me.lblnilai1.AutoSize = True
        Me.lblnilai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnilai1.Location = New System.Drawing.Point(28, 41)
        Me.lblnilai1.Name = "lblnilai1"
        Me.lblnilai1.Size = New System.Drawing.Size(81, 29)
        Me.lblnilai1.TabIndex = 0
        Me.lblnilai1.Text = "Nilai1"
        '
        'Txtnilai1
        '
        Me.Txtnilai1.Location = New System.Drawing.Point(115, 45)
        Me.Txtnilai1.Name = "Txtnilai1"
        Me.Txtnilai1.Size = New System.Drawing.Size(337, 26)
        Me.Txtnilai1.TabIndex = 1
        '
        'Txtnilai2
        '
        Me.Txtnilai2.Location = New System.Drawing.Point(115, 103)
        Me.Txtnilai2.Name = "Txtnilai2"
        Me.Txtnilai2.Size = New System.Drawing.Size(337, 26)
        Me.Txtnilai2.TabIndex = 3
        '
        'lblnilai2
        '
        Me.lblnilai2.AutoSize = True
        Me.lblnilai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnilai2.Location = New System.Drawing.Point(28, 99)
        Me.lblnilai2.Name = "lblnilai2"
        Me.lblnilai2.Size = New System.Drawing.Size(81, 29)
        Me.lblnilai2.TabIndex = 2
        Me.lblnilai2.Text = "Nilai2"
        '
        'Txthasil
        '
        Me.Txthasil.Location = New System.Drawing.Point(115, 226)
        Me.Txthasil.Name = "Txthasil"
        Me.Txthasil.Size = New System.Drawing.Size(337, 26)
        Me.Txthasil.TabIndex = 5
        '
        'Lblhasil
        '
        Me.Lblhasil.AutoSize = True
        Me.Lblhasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhasil.Location = New System.Drawing.Point(28, 222)
        Me.Lblhasil.Name = "Lblhasil"
        Me.Lblhasil.Size = New System.Drawing.Size(72, 29)
        Me.Lblhasil.TabIndex = 4
        Me.Lblhasil.Text = "Hasil"
        '
        'Btnkali
        '
        Me.Btnkali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnkali.Location = New System.Drawing.Point(33, 150)
        Me.Btnkali.Name = "Btnkali"
        Me.Btnkali.Size = New System.Drawing.Size(67, 56)
        Me.Btnkali.TabIndex = 6
        Me.Btnkali.Text = "X"
        Me.Btnkali.UseVisualStyleBackColor = True
        '
        'Btnbagi
        '
        Me.Btnbagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbagi.Location = New System.Drawing.Point(128, 150)
        Me.Btnbagi.Name = "Btnbagi"
        Me.Btnbagi.Size = New System.Drawing.Size(60, 56)
        Me.Btnbagi.TabIndex = 7
        Me.Btnbagi.Text = "/"
        Me.Btnbagi.UseVisualStyleBackColor = True
        '
        'Btntambah
        '
        Me.Btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntambah.Location = New System.Drawing.Point(220, 150)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(68, 56)
        Me.Btntambah.TabIndex = 8
        Me.Btntambah.Text = "+"
        Me.Btntambah.UseVisualStyleBackColor = True
        '
        'Btnkurang
        '
        Me.Btnkurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnkurang.Location = New System.Drawing.Point(315, 150)
        Me.Btnkurang.Name = "Btnkurang"
        Me.Btnkurang.Size = New System.Drawing.Size(67, 56)
        Me.Btnkurang.TabIndex = 9
        Me.Btnkurang.Text = "-"
        Me.Btnkurang.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 313)
        Me.Controls.Add(Me.Btnkurang)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.Btnbagi)
        Me.Controls.Add(Me.Btnkali)
        Me.Controls.Add(Me.Txthasil)
        Me.Controls.Add(Me.Lblhasil)
        Me.Controls.Add(Me.Txtnilai2)
        Me.Controls.Add(Me.lblnilai2)
        Me.Controls.Add(Me.Txtnilai1)
        Me.Controls.Add(Me.lblnilai1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnilai1 As System.Windows.Forms.Label
    Friend WithEvents Txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnilai2 As System.Windows.Forms.TextBox
    Friend WithEvents lblnilai2 As System.Windows.Forms.Label
    Friend WithEvents Txthasil As System.Windows.Forms.TextBox
    Friend WithEvents Lblhasil As System.Windows.Forms.Label
    Friend WithEvents Btnkali As System.Windows.Forms.Button
    Friend WithEvents Btnbagi As System.Windows.Forms.Button
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents Btnkurang As System.Windows.Forms.Button
End Class
