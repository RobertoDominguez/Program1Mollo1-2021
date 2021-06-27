Public Class Practico1Vectores
    Public Sub ejercicio1()
        Dim ve As Vector = New Vector()
        ve.Vector()

        ve.CargarEj1(TextBox1.Text, TextBox2.Text)
        Label1.Text = ve.Descargar()
    End Sub

    Public Sub ejercicio2()
        Dim ve As Vector = New Vector()
        ve.Vector()
        ve.CargarHasta(10)

        Label1.Text = ve.seleccionarPrimos()
        Label2.Text = ve.seleccionarNoPrimos()
    End Sub

    Public Sub ejercicio2P2()
        Dim ve As Vector = New Vector()
        ve.Vector()
        ve.Cargar(DataGridView1.Rows.Item(0))
        Label1.Text = ve.contarElementosSubmultiplosPorIndice()
    End Sub

    Public Sub ejercicio3P2()
        Dim ve As Vector = New Vector()
        ve.Vector()
        ve.Cargar(DataGridView1.Rows.Item(0))
        Label1.Text = ve.elementoMayorIndiceMultiplo(TextBox1.Text)
    End Sub

    Public Sub ejercicio8P2()
        Dim v1 As Vector = New Vector()
        Dim v2 As Vector = New Vector()
        v1.Vector()
        v2.Vector()

        v1.Cargar(DataGridView1.Rows.Item(0))
        v2.Cargar(DataGridView2.Rows.Item(0))

        Label1.Text = v1.Union(v2).Descargar()

    End Sub

    Public Sub ejercicio9P2()
        Dim v1 As Vector = New Vector()
        Dim v2 As Vector = New Vector()
        v1.Vector()

        v1.Cargar(DataGridView1.Rows.Item(0))
        v1.OrdenarPorCapicuasMenMay()

        Label1.Text = v1.Descargar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ejercicio9P2()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.Rows.Add()'
    End Sub
End Class