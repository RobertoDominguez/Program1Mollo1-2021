Public Class Practico2Vectores
    Dim vector1 As Vector = New Vector()
    Dim vector2 As Vector = New Vector()

    Private Sub Practico2Vectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vector1.Vector()
        vector2.Vector()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vector1.Cargar(8, 1, 10)
        vector2.Cargar(8, 1, 10)

        vector1.Descargar(DataGridView1.Rows.Item(0))
        vector2.Descargar(DataGridView2.Rows.Item(0))
    End Sub

    Private Sub Pregunta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta1ToolStripMenuItem.Click
        vector1.OrdenarEntreAyBBurbuja(TextBox1.Text, TextBox2.Text)
        Label1.Text = vector1.Descargar()
    End Sub

    Private Sub Pregunta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta2ToolStripMenuItem.Click
        vector1.InsertarVectorEnPosicionP(vector2, TextBox1.Text)
        Label1.Text = vector1.Descargar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vector1.Cargar(TextBox3.Text, DataGridView1.Rows.Item(0))
        vector2.Cargar(TextBox4.Text, DataGridView2.Rows.Item(0))
    End Sub

    Private Sub Pregunta3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta3ToolStripMenuItem.Click
        vector1.EliminarElementosEntreAYB(TextBox1.Text, TextBox2.Text)
        Label1.Text = vector1.Descargar()
    End Sub

    Private Sub Pregunta4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta4ToolStripMenuItem.Click
        Label1.Text = vector1.ContarElementosDiferentesEntreAyB(TextBox1.Text,
        TextBox2.Text)
    End Sub

    Private Sub Pregunta5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta5ToolStripMenuItem.Click
        Label1.Text = vector1.ElementoMenosRepetidoEntreAyB(TextBox1.Text,
        TextBox2.Text)
    End Sub
End Class