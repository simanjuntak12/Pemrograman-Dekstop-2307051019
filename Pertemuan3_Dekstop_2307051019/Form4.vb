Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnproses_Click(sender As Object, e As EventArgs) Handles Btnproses.Click
        Dim nip As String = Txtnip.Text
        Dim nama As String = Txtnama.Text
        Dim fakultas As String = Cmbfakultas.SelectedItem
        Dim jurusan As String = Cmbjurusan.SelectedItem
        Dim kelamin As String = " "
        If Rbtnlaki.Checked Then
            kelamin = "Laki-laki"
        ElseIf Rbtnperempuan.Checked Then
            kelamin = "Perempuan"
        End If
        MessageBox.Show("Hai: " + nama + vbCrLf + "NIP: " + nip + vbCrLf + "Fakultas: " + fakultas + vbCrLf + "Jurusan: " + jurusan + vbCrLf + "Jenis Kelamin: " + kelamin, "Informasi: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class