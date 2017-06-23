Imports AppConsolaEjemplosPOO_2

Public MustInherit Class Figura
    Implements IConAreaCalculable
    Implements IPerimetroCalculable

    Protected _area As Single
    Protected aviso As FuncionAviso

    Private ReadOnly Property Area As Single Implements IConAreaCalculable.Area
        Get
            Return _area
        End Get
    End Property

    Public MustOverride Function CalcularArea() As Single Implements IConAreaCalculable.CalcularArea
    Public MustOverride Function CalcularPerimetro() As Single Implements IPerimetroCalculable.CalcularPerimetro

    Public Overridable Sub Mostrar()
        Console.WriteLine("Mostrando figura")
    End Sub

    Public Delegate Sub FuncionAviso()



End Class
