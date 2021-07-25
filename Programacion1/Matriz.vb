Public Class Matriz
    Const MAXF = 100
    Const MAXC = 100
    Private x(MAXF, MAXC) As Integer
    Private f, c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub RetDim(ByRef nf As Integer, ByRef nc As Integer)
        nf = f : nc = c
    End Sub
    Public Function Descargar(f1 As Integer, c1 As Integer) As Integer
        Return x(f1, c1)
    End Function
    Public Sub Dimen(nf As Integer, nc As Integer)
        f = nf : c = nc
    End Sub
    Public Sub Cargar(f1 As Integer, c1 As Integer, ele As Integer)
        x(f1, c1) = ele
    End Sub
    Public Sub Cargar(nf As Integer, nc As Integer, vi As Integer, r As Integer)
        Dim i, f1, c1 As Integer
        f = nf : c = nc : i = 0
        For f1 = 1 To f
            For c1 = 1 To c
                i = i + 1
                x(f1, c1) = vi + (i - 1) * r
            Next
        Next
    End Sub
    Public Sub CargarR(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim i, f1, c1 As Integer
        f = nf : c = nc : i = 0
        For f1 = 1 To f
            For c1 = 1 To c
                i = i + 1
                x(f1, c1) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    'cargado binario el de abajo
    'Public Sub Cargar(nf As Integer, nc As Integer, vi As Integer, r As Integer)
    'Dim i, f1, c1 As Integer
    'f = nf : c = nc : i = 0
    'For f1 = 1 To f
    'For c1 = 1 To c
    'i = i + 1
    'x(f1, c1) = 2 ^ (i - 1) 'formula de sistema binario 2^(i -1)
    'Next
    'Next
    'End Sub
    Public Function Descargar() As String
        Dim i, f1, c1 As Integer
        Dim s As String
        s = ""
        For f1 = 1 To f
            For c1 = 1 To c
                s = s + Str(x(f1, c1)) + "|"
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function









    Public Sub DimensionarDataGrid(grilla As DataGridView)

        For i = 1 To grilla.Columns.Count
            grilla.Columns.RemoveAt(0)
        Next



        For i = 1 To c
            grilla.Columns.Add(i.ToString, i.ToString)
        Next

        For i = 1 To f - 1

            grilla.Rows.Add()
        Next

    End Sub


    Public Sub cargarDesdeDataGrid(grilla As DataGridView)
        For i = 1 To f
            For j = 1 To c
                x(i, j) = grilla.Rows.Item(i - 1).Cells.Item(j - 1).Value
            Next
        Next
    End Sub

    Public Sub descargar(grilla As DataGridView)
        For i = 1 To f
            For j = 1 To c
                grilla.Rows.Item(i - 1).Cells.Item(j - 1).Value = x(i, j).ToString
            Next
        Next
    End Sub

    Public Function SumatoriaDiagonalPrincipal()
        Dim sum = 0
        For i = 1 To 3
            sum = sum + x(i, i)
        Next
        Return sum
    End Function

    Public Function SumatoriaMatriz()
        Dim sum = 0
        For i = 1 To 3
            For j = 1 To 3
                sum = sum + x(i, j)
            Next
        Next
        Return sum
    End Function

    Public Sub CargarRandom(a As Integer, b As Integer)
        For i = 1 To f
            For j = 1 To c
                x(i, j) = a + Rnd() * (b - a)
            Next
        Next
    End Sub

    Public Sub CargarMatriz1()
        Dim contador = 1
        For j = 1 To c
            If (j Mod 2 = 0) Then
                For i = f To 1 Step -1
                    x(i, j) = contador
                    contador = contador + 1
                Next
            Else
                For i = 1 To f
                    x(i, j) = contador
                    contador = contador + 1
                Next
            End If

        Next
    End Sub

    Public Sub CargarMatriz2()
        Dim contador = 1
        For i = 1 To c
            If (i Mod 2 = 0) Then
                For j = f To 1 Step -1
                    x(i, j) = contador
                    contador = contador + 1
                Next
            Else
                For j = 1 To f
                    x(i, j) = contador
                    contador = contador + 1
                Next
            End If
        Next
    End Sub

    Public Function Ejercicio1Practico1()
        Dim resultado As Double
        Dim restando = True
        resultado = 0

        For i = f To 1 Step -1
            For j = c To 1 Step -1
                Dim num As NEnt = New NEnt
                num.Cargar(x(i, j))

                If (num.VerifPri) Then
                    If (restando) Then
                        resultado = resultado - Math.Sqrt(num.Descargar)
                        restando = False
                    Else
                        resultado = resultado + Math.Sqrt(num.Descargar)
                        restando = True
                    End If

                End If
            Next
        Next

        Return resultado
    End Function

    Public Sub Ejercicio11Practico1()

        Dim contador = 0

        For j = c To 1 Step -1
            For i = f To 1 Step -1
                contador = contador + 1
                x(i, j) = contador
            Next
        Next

    End Sub

End Class
