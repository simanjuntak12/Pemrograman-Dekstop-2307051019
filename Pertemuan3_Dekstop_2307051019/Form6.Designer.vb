<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.cbmatakuliah = New System.Windows.Forms.ComboBox()
        Me.Lbljurusan = New System.Windows.Forms.Label()
        Me.Lblmatakuliah = New System.Windows.Forms.Label()
        Me.Grbselectcase = New System.Windows.Forms.GroupBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.Looping = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.Btnfornext = New System.Windows.Forms.Button()
        Me.Btndowhile = New System.Windows.Forms.Button()
        Me.Btnwhile = New System.Windows.Forms.Button()
        Me.Grbselectcase.SuspendLayout()
        Me.Looping.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbmatakuliah
        '
        Me.cbmatakuliah.FormattingEnabled = True
        Me.cbmatakuliah.Location = New System.Drawing.Point(133, 96)
        Me.cbmatakuliah.Name = "cbmatakuliah"
        Me.cbmatakuliah.Size = New System.Drawing.Size(223, 28)
        Me.cbmatakuliah.TabIndex = 1
        '
        'Lbljurusan
        '
        Me.Lbljurusan.AutoSize = True
        Me.Lbljurusan.Location = New System.Drawing.Point(34, 46)
        Me.Lbljurusan.Name = "Lbljurusan"
        Me.Lbljurusan.Size = New System.Drawing.Size(66, 20)
        Me.Lbljurusan.TabIndex = 2
        Me.Lbljurusan.Text = "Jurusan"
        '
        'Lblmatakuliah
        '
        Me.Lblmatakuliah.AutoSize = True
        Me.Lblmatakuliah.Location = New System.Drawing.Point(22, 99)
        Me.Lblmatakuliah.Name = "Lblmatakuliah"
        Me.Lblmatakuliah.Size = New System.Drawing.Size(92, 20)
        Me.Lblmatakuliah.TabIndex = 3
        Me.Lblmatakuliah.Text = "Mata Kuliah"
        '
        'Grbselectcase
        '
        Me.Grbselectcase.Controls.Add(Me.cbjurusan)
        Me.Grbselectcase.Location = New System.Drawing.Point(-3, 0)
        Me.Grbselectcase.Name = "Grbselectcase"
        Me.Grbselectcase.Size = New System.Drawing.Size(462, 158)
        Me.Grbselectcase.TabIndex = 4
        Me.Grbselectcase.TabStop = False
        Me.Grbselectcase.Text = "Select Case"
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(136, 43)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(223, 28)
        Me.cbjurusan.TabIndex = 5
        '
        'Looping
        '
        Me.Looping.Controls.Add(Me.Btnwhile)
        Me.Looping.Controls.Add(Me.Btndowhile)
        Me.Looping.Controls.Add(Me.Btnfornext)
        Me.Looping.Controls.Add(Me.Btnreset)
        Me.Looping.Controls.Add(Me.ListBox1)
        Me.Looping.Location = New System.Drawing.Point(-3, 187)
        Me.Looping.Name = "Looping"
        Me.Looping.Size = New System.Drawing.Size(462, 189)
        Me.Looping.TabIndex = 6
        Me.Looping.TabStop = False
        Me.Looping.Text = "Looping"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(15, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 144)
        Me.ListBox1.TabIndex = 0
        '
        'Btnreset
        '
        Me.Btnreset.BackColor = System.Drawing.Color.LightCoral
        Me.Btnreset.Location = New System.Drawing.Point(223, 43)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(85, 26)
        Me.Btnreset.TabIndex = 6
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = False
        '
        'Btnfornext
        '
        Me.Btnfornext.Location = New System.Drawing.Point(223, 75)
        Me.Btnfornext.Name = "Btnfornext"
        Me.Btnfornext.Size = New System.Drawing.Size(85, 26)
        Me.Btnfornext.TabIndex = 7
        Me.Btnfornext.Text = "For..Next"
        Me.Btnfornext.UseVisualStyleBackColor = True
        '
        'Btndowhile
        '
        Me.Btndowhile.Location = New System.Drawing.Point(223, 107)
        Me.Btndowhile.Name = "Btndowhile"
        Me.Btndowhile.Size = New System.Drawing.Size(85, 26)
        Me.Btndowhile.TabIndex = 8
        Me.Btndowhile.Text = "Do..While"
        Me.Btndowhile.UseVisualStyleBackColor = True
        '
        'Btnwhile
        '
        Me.Btnwhile.Location = New System.Drawing.Point(223, 139)
        Me.Btnwhile.Name = "Btnwhile"
        Me.Btnwhile.Size = New System.Drawing.Size(85, 26)
        Me.Btnwhile.TabIndex = 9
        Me.Btnwhile.Text = "While..."
        Me.Btnwhile.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 388)
        Me.Controls.Add(Me.Looping)
        Me.Controls.Add(Me.Lblmatakuliah)
        Me.Controls.Add(Me.Lbljurusan)
        Me.Controls.Add(Me.cbmatakuliah)
        Me.Controls.Add(Me.Grbselectcase)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Grbselectcase.ResumeLayout(False)
        Me.Looping.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbmatakuliah As System.Windows.Forms.ComboBox
    Friend WithEvents Lbljurusan As System.Windows.Forms.Label
    Friend WithEvents Lblmatakuliah As System.Windows.Forms.Label
    Friend WithEvents Grbselectcase As System.Windows.Forms.GroupBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Looping As System.Windows.Forms.GroupBox
    Friend WithEvents Btnwhile As System.Windows.Forms.Button
    Friend WithEvents Btndowhile As System.Windows.Forms.Button
    Friend WithEvents Btnfornext As System.Windows.Forms.Button
    Friend WithEvents Btnreset As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
