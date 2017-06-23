Public Class Circulo
    Inherits Figura

    Public radio As Single
    Public tipoFuncion As CuandoSeCalculaArea

    Public Delegate Sub CuandoSeCalculaArea()

    Public Sub New(radio As Single)
        Me.radio = radio
    End Sub

    Public Sub New(radio As Single, funcion As CuandoSeCalculaArea)
        Me.radio = radio
        tipoFuncion = funcion
    End Sub

    Public Overrides Function CalcularArea() As Single
        _area = radio * radio * Math.PI
        Return _area
    End Function
    Public Overrides Function CalcularPerimetro() As Single
        Return radio * 2 * Math.PI
    End Function
    Public Overrides Sub Mostrar()
        Console.WriteLine("Radio:     " & radio)
        Console.WriteLine(", Area:      " & CalcularArea())
        'Console.WriteLine("Perimetro: " & CalcularPerimetro())
    End Sub


End Class
