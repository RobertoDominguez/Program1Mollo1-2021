Public Class PrimerParcial
    Dim vector As Vector = New Vector()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vector.OrdenarPorMultiplos(TextBox2.Text)
        Label6.Text = "Vector=" + vector.Descargar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vector.EliminarElementosUnicosEntreAyB(TextBox3.Text, TextBox4.Text)
        Label6.Text = "Vector=" + vector.Descargar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vector.Cargar(TextBox1.Text, 1, 10)
        Label1.Text = "Vector=" + vector.Descargar()
    End Sub

    Private Sub PrimerParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vector.Vector()
    End Sub


End Class