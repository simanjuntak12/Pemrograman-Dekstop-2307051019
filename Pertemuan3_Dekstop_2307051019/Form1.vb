Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        Dim nama As String = TxtNama.Text
        Dim jurusan As String = Txtjurusan.Text
        Dim matakuliah As String = Txtmatakuliah.Text
        MessageBox.Show("Hallo " + nama + vbCrLf + "Anda mengambil Jurusan " + jurusan + vbCrLf + "Matakuliah " + matakuliah, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbljurusan.Click

    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged

    End Sub
End Class
