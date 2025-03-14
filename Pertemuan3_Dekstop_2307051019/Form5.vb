Public Class Form5

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtnkali.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtnbagi.CheckedChanged

    End Sub

    Private Sub Txtnilai1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnilai1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtnilai2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnilai2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Btnhitung_Click(sender As Object, e As EventArgs) Handles Btnhitung.Click
        Dim nilai1 As Integer = CInt(Txtnilai1.Text)
        Dim nilai2 As Integer = CInt(Txtnilai2.Text)
        Dim hasil As Integer

        If (Rbtnkali.Checked) Then
            hasil = nilai1 * nilai2
        ElseIf (Rbtnbagi.Checked) Then
            hasil = nilai1 / nilai2
        ElseIf (Rbtntambah.Checked) Then
            hasil = nilai1 + nilai2
        ElseIf (Rbtnkurang.Checked) Then
            hasil = nilai1 - nilai2
        End If
        Txthasil.Text = hasil

    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        Txtnilai1.Text = ""
        Txtnilai2.Text = ""
        Rbtnkali.Checked = False
        Rbtnbagi.Checked = False
        Rbtntambah.Checked = False
        Rbtnkurang.Checked = False
        Txthasil.Text = ""
        Txtnilai1.Focus()

    End Sub

    Private Sub Txthasil_TextChanged(sender As Object, e As EventArgs) Handles Txthasil.TextChanged

    End Sub

    Private Sub Txtnilai2_TextChanged(sender As Object, e As EventArgs) Handles Txtnilai2.TextChanged

    End Sub

    Private Sub Rbtntambah_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtntambah.CheckedChanged

    End Sub

    Private Sub Rbtnkurang_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtnkurang.CheckedChanged

    End Sub

    Private Sub Txtnilai1_TextChanged(sender As Object, e As EventArgs) Handles Txtnilai1.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class