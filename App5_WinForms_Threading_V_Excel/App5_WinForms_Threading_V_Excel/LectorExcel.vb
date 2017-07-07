Imports System.Data.OleDb
Public Class LectorExcel
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

            MsgBox(cmd.CommandText)

            conex.Open()

            Dim valor As Object

            valor = cmd.ExecuteScalar()

            Return Convert.ToString(valor)

        End Using
    End Function
End Class
