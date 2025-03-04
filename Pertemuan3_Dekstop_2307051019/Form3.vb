Public Class Form3

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblnip.Click
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtnip.TextChanged
       
    End Sub

    Private Sub Btnproses_Click(sender As Object, e As EventArgs) Handles Btnproses.Click
        Dim nip As String = Txtnip.Text
        Dim nama As String = Txtnama.Text
        Dim fakultas As String = Cmbfakultas.SelectedItem
        Dim jurusan As String = Cmbjurusan.SelectedItem
        MessageBox.Show("Hai : " + nip + vbCrLf + "Nip : " + nama + vbCrLf + "Fakultas : " + fakultas + vbCrLf + "Jurusan : " + jurusan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class