Public Class Form7

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Lbluts.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txtuas.TextChanged

    End Sub

    Private Sub Lbluas_Click(sender As Object, e As EventArgs) Handles Lbluas.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txtuts.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txttugas.TextChanged

    End Sub

    Private Sub Lbltugas_Click(sender As Object, e As EventArgs) Handles Lbltugas.Click

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnproses_Click(sender As Object, e As EventArgs) Handles Btnproses.Click
        Dim nip As String = Txtnip.Text
        Dim nama As String = Txtnama.Text
        Dim fakultas As String = Cmbfakultas.SelectedItem
        Dim jurusan As String = Cmbjurusan.SelectedItem
        Dim kelamin As String = ""
        If Rbtnlaki.Checked Then
            kelamin = "Laki-laki"
        ElseIf Rbtnperempuan.Checked Then
            kelamin = "Perempuan"
        End If

        Dim tugas As Double = 0
        Dim uts As Double = 0
        Dim uas As Double = 0
        Dim nilaiAkhir As Double
        Dim grade As String = " "

        If Double.TryParse(Txttugas.Text, tugas) AndAlso Double.TryParse(Txtuts.Text, uts) AndAlso Double.TryParse(Txtuas.Text, uas) Then
        End If

        nilaiAkhir = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)


        If nilaiAkhir >= 78 Then
            grade = "A"
        ElseIf nilaiAkhir >= 65 Then
            grade = "B"
        ElseIf nilaiAkhir >= 50 Then
            grade = "C"
        ElseIf nilaiAkhir >= 40 Then
            grade = "D"
        Else
            grade = "E"
        End If

        If MessageBox.Show("Hai: " + nama + vbCrLf + "NIP: " + nip + vbCrLf + "Fakultas: " + fakultas + vbCrLf + "Jurusan: " + jurusan + vbCrLf + "Jenis Kelamin: " + kelamin + vbCrLf + "Nilai Akhir: " + nilaiAkhir.ToString("0.00") + vbCrLf + "Grade: " + grade, "Informasi: ", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
        Else : MessageBox.Show("Harap masukkan nilai yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class