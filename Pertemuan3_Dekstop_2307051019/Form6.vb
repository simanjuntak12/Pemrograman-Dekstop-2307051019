Public Class Form6

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbljurusan.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Lblmatakuliah.Click

    End Sub

    Private Sub Grbselectcase_Enter(sender As Object, e As EventArgs) Handles Grbselectcase.Enter

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbJurusan.Items.Add("Sistem Informasi")
        CbJurusan.Items.Add("Managemen Informatika")
        CbJurusan.Items.Add("Ilmu Komputer")
    End Sub

    Private Sub cbjurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjurusan.SelectedIndexChanged
        Dim jurusan As String = cbjurusan.SelectedItem
        cbmatakuliah.Items.Clear()

        Select Case (jurusan)
            Case "Sistem Informasi"
                cbmatakuliah.Items.Add("Logika Informasi")
                cbmatakuliah.Items.Add("Matematika Diskrit")
                cbmatakuliah.Items.Add("Aljabar Linear")
            Case "Managemen Informatika"
                cbmatakuliah.Items.Add("Pemrograman dekstop")
                cbmatakuliah.Items.Add("OOP")
                cbmatakuliah.Items.Add("Pemrograman Web")
            Case "Ilmu Komputer"
                cbmatakuliah.Items.Add("Kecerdasan Buatan")
                cbmatakuliah.Items.Add("Iot")
                cbmatakuliah.Items.Add("Robotika")
        End Select
    End Sub

    Private Sub Looping_Enter(sender As Object, e As EventArgs) Handles Looping.Enter

    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Btnfornext_Click(sender As Object, e As EventArgs) Handles Btnfornext.Click

        'untuk nilai i sama dengan 1 sampai 10, maka
        'tambahkan nilai i kedalam litbox
        For i = 1 To 10

            ListBox1.Items.Add(i)
        Next i
    End Sub

    Private Sub Btndowhile_Click(sender As Object, e As EventArgs) Handles Btndowhile.Click
        'definisikan variabel i dengan nilai 1
        Dim i As Integer = 1

        'lakukan ketika nilai 1 kurang dari 10
        Do While (i < 10)
            ListBox1.Items.Add(i)
            i = i + 1
        Loop

    End Sub

    Private Sub Btnwhile_Click(sender As Object, e As EventArgs) Handles Btnwhile.Click

    End Sub
End Class