Imports System.Data.OleDb
Namespace Modelo
    Public Class EmpleadosGenerador
        Implements IPersistenciaEmpleados

        Public Property nombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Throw New NotImplementedException()
        End Function

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            ReDim arrayEmpleados(100)

            For i = 1 To 100
                Dim nuevoEmpleado As New Empleado(DameNombreAleatorio, DameApellidoAleatorio() & " " & DameApellidoAleatorio(), Rnd() * 2 + 1, Rnd() * 2 + 1)

                arrayEmpleados(i) = nuevoEmpleado

            Next

        End Function

        Function DameNombreAleatorio() As String
            Dim nombres() = New String() {"Juan", "Pepe", "Pedro", "Germán", "Fernando", "Óscar", "Sergi", "Luis"}
            Return nombres(Rnd() * (nombres.Length - 1))
        End Function

        Function DameApellidoAleatorio() As String
            Dim apellidos() = New String() {"Valera", "Guardiola", "Caballero", "Payán", "Sanín", "Trofiño", "Casas", "Pérez", "Torres", "Berlanga", "Pobes", "Ferrari", "Morros"}
            Return apellidos(Rnd() * (apellidos.Length - 1))
        End Function
    End Class
End Namespace