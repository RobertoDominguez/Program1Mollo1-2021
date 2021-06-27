Imports Microsoft.VisualBasic

Public Class NEnt
    Private n As Integer
    Public Sub NEnt()
        n = 0
    End Sub
    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub
    Public Function Descargar() As Integer
        Return n
    End Function
    Public Function Fact() As Double
        Dim i As Integer
        Dim f As Double
        If n > 0 Then
            f = 1
            For i = n To 1 Step -1
                f = f * i
            Next
        Else
            f = 1
        End If
        Return f
    End Function
    Public Sub Cargar()
        n = Rnd() * 100

    End Sub
    Public Function VerifPar() As Boolean
        Return n Mod 2 = 0
    End Function
    Public Function VerifPri() As Boolean
        Dim c As Integer 'contador'
        Dim r As Integer 'var auxiliar'
        Dim i As Integer 'variable de los ciclos'
        c = 0
        For i = 1 To n
            r = n Mod i
            If r = 0 Then
                c = c + 1

            End If

        Next
        Return c = 2

    End Function
    Public Function VerifPri1() As Boolean
        Dim r As Integer
        Dim b As Boolean
        Dim i As Integer
        If n > 1 Then
            i = 1
            Do
                i = i + 1
                r = n Mod i

            Loop Until r = 0
            b = n = i
        Else
            b = False

        End If
        Return b

    End Function
    Public Function VerifMulti(a1 As NEnt) As Boolean
        Return n Mod a1.n = 0


    End Function
    Public Function VerifCapicua() As Boolean
        Dim nu As Integer 'numero nuevo'
        Dim dig As Integer
        Dim na As Integer
        Dim b As Boolean
        b = False
        na = n
        nu = 0
        While n > 0
            dig = na Mod 10
            nu = nu * 10 + dig
            na = na \ 10
        End While
        If n = nu Then
            b = True
        End If
        Return b
    End Function

End Class