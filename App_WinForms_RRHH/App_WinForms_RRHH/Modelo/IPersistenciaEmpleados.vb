Namespace Modelo
    Public Interface IPersistenciaEmpleados

        Property nombreFichero As String
        Function Exportar(ByVal arrayEmpleados() As Empleado) As Boolean
        Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean

    End Interface
End Namespace
