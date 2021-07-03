Public Class Vector
    Const Max = 100
    Private v(Max) As Integer
    Private n As Integer
    Public Sub Vector() 'constructor'
        n = 0
    End Sub

    Public Sub Vector(_n As Integer, v2() As Integer) 'constructor'
        n = _n
        For i = 1 To n
            v(i) = v2(i)
        Next
    End Sub

    Public Sub Vaciar()
        n = 0
    End Sub

    Public Function ObtenerN() As Integer
        Return n
    End Function
    Public Sub Cargar(n1 As Integer, a As Integer, b As Integer) 'randomicamente'
        Dim i As Integer
        n = n1
        For i = 1 To n
            v(i) = a + Rnd() * (b - a)
        Next
    End Sub

    Public Sub Cargar(dato As Integer)
        n = n + 1
        v(n) = dato
    End Sub

    Public Sub Cargar(pos As Integer, dato As Integer)

        For i = n To pos Step -1
            v(i + 1) = v(i)
        Next
        v(pos) = dato
        n = n + 1
    End Sub

    Public Sub Poner(indice As Integer, num As Integer)
        v(indice) = num
    End Sub

    Public Sub Cargar(data As DataGridViewRow) 'Por DataGridView Fila'
        Dim i As Integer
        n = data.Cells.Count
        For i = 0 To (n - 1)
            v(i + 1) = data.Cells.Item(i).Value
        Next
    End Sub

    Public Sub Cargar(dimension As Integer, data As DataGridViewRow) 'Por DataGridView Fila'
        Dim i As Integer
        n = dimension
        For i = 0 To (n - 1)
            v(i + 1) = data.Cells.Item(i).Value
        Next
    End Sub

    Public Sub Descargar(data As DataGridViewRow) 'Por DataGridView Fila'
        Dim i As Integer
        For i = 0 To (n - 1)
            data.Cells.Item(i).Value = v(i + 1)
        Next
    End Sub
    Public Function Descargar() As String
        Dim s As String
        Dim i As Integer
        s = ""
        For i = 1 To n
            s = s + Str(v(i)) + ";"
        Next
        Return s

    End Function

    Public Sub Eliminar(pos As Integer)
        n = n - 1
        For i = pos To n
            v(i) = v(i + 1)
        Next
    End Sub

    Public Function Acumular() As Integer
        Dim f As Integer
        Dim i As Integer
        f = 0
        For i = 1 To n
            f = f + v(i)
        Next
        Return f
    End Function
    Public Function Promedio() As Double
        Dim f As Double
        f = Acumular() / n
        Return f
    End Function
    Public Function DevMedia() As Double
        Dim f As Double
        Dim p As Double
        Dim dv As Double

        f = 0
        p = Promedio()
        For i = 1 To n
            f = f + Math.Abs(p - v(i))
        Next
        dv = f / n
        Return dv


    End Function
    Public Sub Aprobados(R As Vector)
        Dim ir As Integer
        Dim i As Integer
        ir = 0
        For i = 1 To n
            If v(i) > 51 Then
                ir = ir + 1
                R.v(ir) = v(i)
            End If
        Next
        R.n = ir

    End Sub
    Public Sub Primos(R As Vector)
        Dim ir As Integer
        Dim i As Integer
        Dim nu As NEnt
        nu = New NEnt
        ir = 0
        For i = 1 To n
            nu.Cargar(v(i))
            If nu.VerifPri() Then
                ir = ir + 1
                R.v(ir) = v(i)
            End If
        Next
        R.n = ir

    End Sub

    Public Function Descargar(i As Integer) As Integer
        Return v(i)
    End Function
    Public Function RetDim() As Integer
        Return n
    End Function
    Public Function ContPri() As Integer
        Dim n1 As NEnt
        Dim c, i As Integer
        n1 = New NEnt
        c = 0
        For i = 1 To n
            n1.Cargar(v(i))
            If n1.VerifPri() = True Then
                c = c + 1
            End If
        Next
        Return c


    End Function
    Public Function Mayor() As Integer
        Dim may As Integer 'toma dos porque, piensa que le v1 ya es el mayor y va preguntando'
        may = v(1)
        For i = 2 To n
            If v(i) > may Then
                may = v(i)
            End If
        Next
        Return may

    End Function
    Public Sub SelectPares(ByRef vr As Vector)
        Dim i As Integer
        Dim n1 As NEnt
        n1 = New NEnt
        vr.n = 0
        For i = 1 To n
            n1.Cargar(v(i))
            If n1.VerifPar() Then
                vr.n = vr.n + 1
                vr.v((vr.n)) = v(i)
            End If
        Next
    End Sub
    Public Function BusSec() As Integer
        Dim p As Integer
        Dim i As Integer
        Dim nu As NEnt
        nu = New NEnt()
        p = 0 : i = 1
        While (i <= n) And (p = 0)
            nu.Cargar(v(i))
            If nu.VerifPri() Then
                p = i
            Else


            End If
        End While
    End Function

    Public Sub CargarHasta(ne As Integer)
        n = ne
        For i = 1 To n
            v(i) = i
        Next
    End Sub

    Public Sub CargarEj1(ne As Integer, b As Integer)
        n = ne
        For i = 1 To n
            v(i) = b ^ (i - 1)
        Next
    End Sub

    Public Function seleccionarPrimos() As String
        Dim s As String
        Dim i As Integer
        s = ""
        For i = 1 To n
            Dim n As NEnt = New NEnt()
            n.Cargar(v(i))
            If (n.VerifPri()) Then
                s = s + Str(v(i)) + ";"
            End If
        Next
        Return s
    End Function

    Public Function seleccionarNoPrimos() As String
        Dim s As String
        Dim i As Integer
        s = ""
        For i = 1 To n
            Dim n As NEnt = New NEnt()
            n.Cargar(v(i))
            If (Not n.VerifPri()) Then
                s = s + Str(v(i)) + ";"
            End If
        Next
        Return s
    End Function

    Public Function contarElementosSubmultiplosPorIndice() As Integer
        Dim i As Integer
        Dim contador As Integer
        For i = 1 To n
            Dim num As NEnt = New NEnt()
            Dim elemI As NEnt = New NEnt()
            num.Cargar(v(i))
            elemI.Cargar(i)
            If (num.VerifMulti(elemI)) Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function


    Public Function elementoMayorIndiceMultiplo(multiplo As Integer) As Integer
        Dim i As Integer
        Dim mayor As Integer
        mayor = 0
        For i = 1 To n
            Dim num As NEnt = New NEnt()
            Dim elemI As NEnt = New NEnt()
            num.Cargar(multiplo)
            elemI.Cargar(i)
            If (elemI.VerifMulti(num)) Then
                If (v(i) > mayor) Then
                    mayor = v(i)
                End If
            End If
        Next
        Return mayor
    End Function

    Public Function Interseccion(v2 As Vector) As Vector
        Dim v3 As Vector = New Vector()
        Dim i, j As Integer
        v3.Vector()

        For i = 1 To n
            Dim elementoV1 As Integer
            elementoV1 = v(i)
            For j = 1 To v2.ObtenerN
                Dim elementoV2 As Integer
                elementoV2 = v2.Descargar(j)
                If (elementoV1 = elementoV2) Then
                    v3.Cargar(elementoV2)
                End If
            Next
        Next
        Return v3
    End Function

    Public Function Existe(elem As Integer) As Boolean
        Dim i As Integer

        For i = 1 To n
            If (v(i) = elem) Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Function Union(v2 As Vector) As Vector
        Dim v3 As Vector = New Vector()
        Dim i, j As Integer
        v3.Vector()

        For i = 1 To n
            v3.Cargar(v(i))
        Next

        For j = 1 To v2.ObtenerN
            If (Not v3.Existe(v2.Descargar(j))) Then
                v3.Cargar(v2.Descargar(j))
            End If
        Next

        Return v3
    End Function

    Public Sub OrdenarAscendentemente()
        Dim i, j As Integer

        For i = 1 To n
            For j = i To n
                If (v(i) > v(j)) Then
                    Dim aux As Integer
                    aux = v(i)
                    v(i) = v(j)
                    v(j) = aux
                End If


            Next
        Next

    End Sub

    Public Sub OrdenarPorCapicuasMenMay()
        Dim v1 As Vector = New Vector() 'capicuas
        Dim v2 As Vector = New Vector() 'no capicuas
        v1.Vector()
        v2.Vector()

        Dim i As Integer
        For i = 1 To n
            Dim num As NEnt = New NEnt()
            num.NEnt()
            num.Cargar(v(i))

            If (num.VerifCapicua()) Then
                v1.Cargar(num.Descargar())
            Else
                v2.Cargar(num.Descargar())
            End If
        Next

        v1.OrdenarAscendentemente()
        v2.OrdenarAscendentemente()

        Vaciar()

        For i = 1 To v1.RetDim()
            Cargar(v1.Descargar(i))
        Next

        For i = 1 To v2.RetDim()
            Cargar(v2.Descargar(i))
        Next

    End Sub

    Public Sub OrdenarPorMultiplosConRango(a As Integer, b As Integer, m As Integer)


        For i = a To b
            For j = i To b
                Dim indice As Integer
                indice = i - a + 1
                If (indice Mod m = 0) Then
                    If (v(i) > v(j)) Then
                        Dim aux As Integer
                        aux = v(i)
                        v(i) = v(j)
                        v(j) = aux
                    End If
                End If
            Next
        Next

    End Sub


    Public Function IndiceMenor() As Integer
        Dim menor = 10000
        Dim indiceMen As Integer
        For i = 1 To n
            If (menor > v(i)) Then
                menor = v(i)
                indiceMen = i
            End If
        Next
        Return indiceMen
    End Function

    Public Function IndiceMayor() As Integer
        Dim mayor = 0
        Dim indiceMay As Integer
        For i = 1 To n
            If (mayor < v(i)) Then
                mayor = v(i)
                indiceMay = i
            End If
        Next
        Return indiceMay
    End Function

    Public Sub ElementosMenMayFrec(a As Integer, b As Integer)
        Dim v1 As Vector = New Vector() 'frecuencias
        v1.Vector()
        For i = a To b
            v1.Cargar(1)
        Next

        For i = a To b
            For j = i To b
                If (v(i) = v(j)) Then
                    v1.Poner(i, v1.Descargar(i) + 1)
                End If
            Next
        Next

        Dim indMenorF, indMayorF As Integer
        indMenorF = v1.IndiceMenor()
        indMayorF = v1.IndiceMayor()

        Dim MenorF, MayorF As Integer
        MenorF = v(indMenorF + a - 1)
        MayorF = v(indMayorF + a - 1)

    End Sub

    Public Sub OrdenarEntreAyBBurbuja(a As Integer, b As Integer)
        For i = a To b
            For j = i To b
                If (v(i) > v(j)) Then
                    Dim aux = v(i)
                    v(i) = v(j)
                    v(j) = aux
                End If
            Next
        Next
    End Sub

    Public Sub InsertarVectorEnPosicionP(v2 As Vector, p As Integer)
        For i = v2.RetDim To 1 Step -1
            Cargar(p, v2.Descargar(i))
        Next
    End Sub

    Public Sub EliminarElementosEntreAYB(a As Integer, b As Integer)
        For i = a To b
            Eliminar(a)
        Next
    End Sub

    Public Function ContarElementosDiferentesEntreAyB(a As Integer, b As Integer) As Integer
        Dim contador As Integer
        contador = 0
        Dim v2 As Vector = New Vector()
        v2.Vector(n, v)

        v2.OrdenarEntreAyBBurbuja(a, b)
        For i = a To b - 1
            If (v2.Descargar(i) <> v2.Descargar(i + 1)) Then
                contador = contador + 1
            End If
        Next
        Return contador + 1
    End Function

    Public Function ElementoMenosRepetidoEntreAyB(a As Integer, b As Integer) As Integer
        Dim contadorMenor, contador, elemento As Integer
        contadorMenor = 9999
        contador = 0
        elemento = 0
        Dim v2 As Vector = New Vector()
        v2.Vector(n, v)

        v2.OrdenarEntreAyBBurbuja(a, b)
        For i = a To b - 1
            For j = i To b - 1
                If (v2.Descargar(i) = v2.Descargar(i + 1)) Then
                    contador = contador + 1
                End If
            Next
            contador = contador + 1
            If ((v2.Descargar(i) <> v2.Descargar(i - 1)) And (contador < contadorMenor)) Then
                contadorMenor = contador
                elemento = v2.Descargar(i)
            End If
            contador = 0
        Next

        Return elemento
    End Function

    Public Sub OrdenarPorMultiplos(m As Integer)
        For i = 1 To n
            For j = i To n
                If ((i Mod m = 0) And (j Mod m = 0)) Then
                    If (v(i) > v(j)) Then
                        Dim aux = v(i)
                        v(i) = v(j)
                        v(j) = aux
                    End If
                End If
            Next
        Next
    End Sub

    Public Function EsUnico(posicion As Integer) As Boolean
        Dim contador = 0

        For i = 1 To n
            If (v(posicion) = v(i)) Then
                contador = contador + 1
            End If
        Next
        Return contador = 1
    End Function

    Public Function EsUnicoEntreAyB(posicion As Integer, a As Integer, b As Integer) As Boolean
        Dim contador = 0

        For i = a To b
            If (v(posicion) = v(i)) Then
                contador = contador + 1
            End If
        Next
        Return contador = 1
    End Function

    Public Sub EliminarElementosUnicosEntreAyB(a As Integer, b As Integer)
        Dim contador = 0
        For i = a To b
            If (EsUnicoEntreAyB(i - contador, a, b - contador)) Then
                Eliminar(i - contador)
                contador = contador + 1
            End If
        Next
    End Sub



End Class