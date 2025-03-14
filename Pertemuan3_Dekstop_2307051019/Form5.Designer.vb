<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Txtnilai1 = New System.Windows.Forms.TextBox()
        Me.Txtnilai2 = New System.Windows.Forms.TextBox()
        Me.Rbtnkali = New System.Windows.Forms.RadioButton()
        Me.Rbtnbagi = New System.Windows.Forms.RadioButton()
        Me.Rbtntambah = New System.Windows.Forms.RadioButton()
        Me.Btnhitung = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Rbtnkurang = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txthasil = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtnilai1
        '
        Me.Txtnilai1.Location = New System.Drawing.Point(57, 38)
        Me.Txtnilai1.Name = "Txtnilai1"
        Me.Txtnilai1.Size = New System.Drawing.Size(380, 26)
        Me.Txtnilai1.TabIndex = 0
        '
        'Txtnilai2
        '
        Me.Txtnilai2.Location = New System.Drawing.Point(57, 160)
        Me.Txtnilai2.Name = "Txtnilai2"
        Me.Txtnilai2.Size = New System.Drawing.Size(380, 26)
        Me.Txtnilai2.TabIndex = 1
        '
        'Rbtnkali
        '
        Me.Rbtnkali.AutoSize = True
        Me.Rbtnkali.Location = New System.Drawing.Point(93, 102)
        Me.Rbtnkali.Name = "Rbtnkali"
        Me.Rbtnkali.Size = New System.Drawing.Size(45, 24)
        Me.Rbtnkali.TabIndex = 3
        Me.Rbtnkali.TabStop = True
        Me.Rbtnkali.Text = "X"
        Me.Rbtnkali.UseVisualStyleBackColor = True
        '
        'Rbtnbagi
        '
        Me.Rbtnbagi.AutoSize = True
        Me.Rbtnbagi.Location = New System.Drawing.Point(184, 102)
        Me.Rbtnbagi.Name = "Rbtnbagi"
        Me.Rbtnbagi.Size = New System.Drawing.Size(38, 24)
        Me.Rbtnbagi.TabIndex = 4
        Me.Rbtnbagi.TabStop = True
        Me.Rbtnbagi.Text = "/"
        Me.Rbtnbagi.UseVisualStyleBackColor = True
        '
        'Rbtntambah
        '
        Me.Rbtntambah.AutoSize = True
        Me.Rbtntambah.Location = New System.Drawing.Point(274, 102)
        Me.Rbtntambah.Name = "Rbtntambah"
        Me.Rbtntambah.Size = New System.Drawing.Size(43, 24)
        Me.Rbtntambah.TabIndex = 5
        Me.Rbtntambah.TabStop = True
        Me.Rbtntambah.Text = "+"
        Me.Rbtntambah.UseVisualStyleBackColor = True
        '
        'Btnhitung
        '
        Me.Btnhitung.Location = New System.Drawing.Point(26, 177)
        Me.Btnhitung.Name = "Btnhitung"
        Me.Btnhitung.Size = New System.Drawing.Size(380, 46)
        Me.Btnhitung.TabIndex = 6
        Me.Btnhitung.Text = "Hitung"
        Me.Btnhitung.UseVisualStyleBackColor = True
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(57, 301)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(380, 58)
        Me.Btnreset.TabIndex = 7
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'Rbtnkurang
        '
        Me.Rbtnkurang.AutoSize = True
        Me.Rbtnkurang.Location = New System.Drawing.Point(357, 102)
        Me.Rbtnkurang.Name = "Rbtnkurang"
        Me.Rbtnkurang.Size = New System.Drawing.Size(39, 24)
        Me.Rbtnkurang.TabIndex = 8
        Me.Rbtnkurang.TabStop = True
        Me.Rbtnkurang.Text = "-"
        Me.Rbtnkurang.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Txthasil)
        Me.Panel1.Controls.Add(Me.Btnhitung)
        Me.Panel1.Location = New System.Drawing.Point(31, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 353)
        Me.Panel1.TabIndex = 9
        '
        'Txthasil
        '
        Me.Txthasil.Location = New System.Drawing.Point(26, 239)
        Me.Txthasil.Name = "Txthasil"
        Me.Txthasil.Size = New System.Drawing.Size(380, 26)
        Me.Txthasil.TabIndex = 10
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 379)
        Me.Controls.Add(Me.Rbtnkurang)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.Rbtntambah)
        Me.Controls.Add(Me.Rbtnbagi)
        Me.Controls.Add(Me.Rbtnkali)
        Me.Controls.Add(Me.Txtnilai2)
        Me.Controls.Add(Me.Txtnilai1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnilai1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnilai2 As System.Windows.Forms.TextBox
    Friend WithEvents Rbtnkali As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnbagi As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtntambah As System.Windows.Forms.RadioButton
    Friend WithEvents Btnhitung As System.Windows.Forms.Button
    Friend WithEvents Btnreset As System.Windows.Forms.Button
    Friend WithEvents Rbtnkurang As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txthasil As System.Windows.Forms.TextBox
End Class
