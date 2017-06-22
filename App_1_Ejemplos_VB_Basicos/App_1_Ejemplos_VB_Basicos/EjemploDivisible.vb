Module EjemploDivisible
    Sub Main()

        Dim x As Integer
        Dim contador As Integer

        Console.WriteLine("Escriba el numero")
        x = Console.ReadLine()

        contador = 1

        While contador <= 100

            If (contador Mod x = 0) Then

                Console.WriteLine(contador & " Es divisible entre " & x)

            End If

            contador = contador + 1
        End While

        Console.Read()

    End Sub

End Module
