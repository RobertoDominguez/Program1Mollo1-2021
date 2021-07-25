Public Class Matrices

    Dim matriz As Matriz = New Matriz()


    Private Sub Matrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matriz.Matriz()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        matriz.Dimen(TextBox1.Text, TextBox2.Text)
        matriz.DimensionarDataGrid(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        matriz.cargarDesdeDataGrid(DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        matriz.CargarRandom(1, 20)
        matriz.descargar(DataGridView1)
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        Label1.Text = matriz.Ejercicio1Practico1()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        matriz.cargarDesdeDataGrid(DataGridView1)
    End Sub

    Private Sub Ejercicio11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio11ToolStripMenuItem.Click
        matriz.Ejercicio11Practico1()
        matriz.descargar(DataGridView1)
    End Sub
End Class