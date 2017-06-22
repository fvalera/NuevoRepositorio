Module EjemploSigno
    Sub Main()

        Dim x As Integer
        Dim y As Integer
        Dim comprobador As Boolean

        Console.WriteLine("Escriba el primer numero")
        x = Console.ReadLine()

        Console.WriteLine("Escriba el segundo numero")
        y = Console.ReadLine()

        Console.WriteLine("El valor maximo es: " & Math.Max(x, y))
        Console.WriteLine("El valor minimo es: " & Math.Min(x, y))

        Console.WriteLine("El signo del primer numero es: " & If(Math.Sign(x) >= 0, "Positivo", "Negativo"))
        Console.WriteLine("El signo del segundo numero es: " & If(Math.Sign(y) >= 0, "Positivo", "Negativo"))

        If Math.Sign(x) = Math.Sign(y) Then

            comprobador = True

        Else

            comprobador = False

        End If

        Select Case comprobador
            Case True
                Console.WriteLine("Los signos de ambos números son iguales")
            Case False
                Console.WriteLine("Los signos de ambos números son distintos")
        End Select

        Console.Read()

    End Sub

End Module
