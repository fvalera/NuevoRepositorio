Imports System.Data.OleDb
Namespace Modelo


    Public Class EmpleadosExcel
        Implements IPersistenciaEmpleados
        Private _nombreFichero As String

        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object

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
            oExcel = CreateObject("Excel.Application")
            oLibro = oExcel.Workbooks.Add
            oHoja = oLibro.Worksheets(1)

            oHoja.Range("A1").Value = "Nombre"
            oHoja.Range("B1").Value = "Apellidos"
            oHoja.Range("C1").Value = "Género"
            oHoja.Range("D1").Value = "Categoría"

            Dim arrayDatos(99, 3) As String
            Dim r As Integer

            For r = 0 To arrayEmpleados.Length - 1
                arrayDatos(r, 0) = arrayEmpleados(r).nombre
                arrayDatos(r, 1) = arrayEmpleados(r).apellidos
                arrayDatos(r, 2) = arrayEmpleados(r).genero
                arrayDatos(r, 3) = arrayEmpleados(r).categoria
            Next

            oHoja.Range("A2").Resize(100, 4).Value() = arrayDatos

            oLibro.SaveAs(nombreFichero)

            oExcel.Quit()

            Return True

        End Function

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            Dim listaEmpleados As List(Of Empleado) = New List(Of Empleado)
            Dim fila As Integer = 2

            While DameValorCelda(_nombreFichero, "Hoja1", "A", fila) <> ""
                Dim empleado As Empleado = New Empleado(DameValorCelda(_nombreFichero, "Hoja1", "A", fila), DameValorCelda(_nombreFichero, "Hoja1", "B", fila), DameValorCelda(_nombreFichero, "Hoja1", "C", fila), DameValorCelda(_nombreFichero, "Hoja1", "D", fila).ToString)

                listaEmpleados.Add(empleado)

                fila = fila + 1
            End While

            arrayEmpleados = listaEmpleados.ToArray

            Return True
        End Function

        Public Shared Function DameValorCelda(nombreFichero As String, hoja As String, columna As String, fila As Integer) As String
            If (Not (IO.File.Exists(nombreFichero))) Then

                Throw New IO.FileNotFoundException("No existe el fichero especificado")

            End If

            If String.IsNullOrEmpty(hoja) OrElse String.IsNullOrEmpty(columna) OrElse (fila < 1) OrElse (fila > 65536) Then

                Throw New ArgumentException("Argumentos/valores no válidos")

            End If

            Dim cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Extended Properties='Excel 12.0 Xml;HDR=No';" & "Data Source=" & nombreFichero
            Using conex As New OleDbConnection(cadenaConexion)
                Dim cmd As OleDbCommand = conex.CreateCommand()
                Dim celda As String = columna & fila

                cmd.CommandText = String.Format("SELECT F1 FROM [{0}${1}:{2}]", hoja, celda, celda)

                'MsgBox(cmd.CommandText)

                conex.Open()

                Dim valor As Object

                Try
                    valor = cmd.ExecuteScalar()
                Catch ex As Exception
                    valor = ""
                End Try


                Return Convert.ToString(valor)

            End Using
        End Function

    End Class
End Namespace
