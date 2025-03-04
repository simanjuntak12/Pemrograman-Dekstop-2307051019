Public Class Form2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblnilai1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnkali.Click
        Dim nilai1 As Integer = CInt(Txtnilai1.Text)
        Dim nilai2 As Integer = CInt(Txtnilai2.Text)
        Dim hasil As Integer = nilai1 * nilai2
        Txthasil.Text = hasil
    End Sub

    Private Sub Btnbagi_Click(sender As Object, e As EventArgs) Handles Btnbagi.Click

    End Sub
End Class