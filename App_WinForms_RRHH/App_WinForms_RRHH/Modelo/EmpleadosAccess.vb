Imports System.Data.OleDb
Namespace Modelo
    Public Class EmpleadosAccess
        Implements IPersistenciaEmpleados
        Private _nombreFichero As String

        Public Property nombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Return _nombreFichero
            End Get
            Set(value As String)
                If value = "" Then
                    Throw New Exception("No se ha establecido el nombre del fichero")
                Else
                    _nombreFichero = value
                End If
            End Set
        End Property

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Dim cadenaConexion = Constantes.CADENA_CONEX_ACCESS & nombreFichero

            Using conexionDB As New OleDbConnection(cadenaConexion)

                Try
                    conexionDB.Open()

                    For Each empleado As Empleado In arrayEmpleados
                        Dim sql As String

                        sql = "INSERT INTO Empleado(Nombre,Apellidos,Genero,Categoría) VALUES('" & empleado.nombre & "','" & empleado.apellidos & "','" & empleado.genero & "','" & empleado.categoria & "')"

                        Dim comando As OleDbCommand = New OleDbCommand(sql, conexionDB)

                        comando.ExecuteNonQuery()
                    Next

                Catch ex As Exception
                    MsgBox("Error al exportar Access: " & nombreFichero)
                    Return False
                End Try

                conexionDB.Close()
                conexionDB.Dispose()

            End Using

        End Function

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar

            Dim listaEmpleados As New List(Of Empleado)

            Dim cadenaConexion = Constantes.CADENA_CONEX_ACCESS & nombreFichero

            Using conexionDB As New OleDbConnection(cadenaConexion)

                Try
                    Dim sql As String
                    sql = "SELECT Nombre, Apellidos, Genero, Categoría FROM Empleado ORDER BY Nombre, Apellidos ASC;"

                    Dim comando As OleDbCommand = New OleDbCommand(sql, conexionDB)
                    conexionDB.Open()

                    Dim dataReader As OleDbDataReader
                    dataReader = comando.ExecuteReader()

                    Do While dataReader.Read()

                        Dim empleado As New Empleado
                        empleado.nombre = dataReader(0)
                        empleado.apellidos = dataReader(1)
                        empleado.genero = dataReader(2)
                        empleado.categoria = dataReader(3)

                        listaEmpleados.Add(empleado)
                    Loop
                    dataReader.Close()

                Catch ex As Exception
                    MsgBox("Error al exportar Access: " & nombreFichero)
                    Return False
                End Try

                arrayEmpleados = listaEmpleados.ToArray()
                Return True

                conexionDB.Close()
                conexionDB.Dispose()

            End Using

        End Function
    End Class
End Namespace

