Namespace Modelo

    ' CRUD
    ' Create, Read, Update, Delete
    ' Crear, Leer, Actualizar, Eliminar
    Module EmpleadosCRUD
        Private listaEmpleados As List(Of Empleado)

        Public Sub Restaurar()
            listaEmpleados = New List(Of Empleado)()

            Dim arrayEmpleados() As Empleado
            arrayEmpleados = listaEmpleados.ToArray()
            EmpleadosFichero.LeerFichero(arrayEmpleados)
            listaEmpleados = arrayEmpleados.ToList()
        End Sub
        Sub Crear(nuevoEmpleado As Empleado)
            ' Asignamos nuevo empleado
            listaEmpleados.Add(nuevoEmpleado)
        End Sub
        Sub Grabar()
            EmpleadosFichero.GrabarFichero(listaEmpleados.ToArray())
        End Sub
        Function Cantidad() As Integer
            Return listaEmpleados.Count
        End Function
        Function Leer(indice As Integer) As Empleado
            Return listaEmpleados(indice)
        End Function
        Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado)
            nombre = nombre.ToUpper
            apellido = apellido.ToUpper
            BuscarEmpleados = New List(Of Empleado)

            For index = 0 To listaEmpleados.Count - 1
                Dim encontradoN As Boolean = False
                Dim encontradoA As Boolean = False

                If nombre = "" Or (nombre <> "" And listaEmpleados(index).nombre.ToUpper.Contains(nombre)) Then
                    encontradoN = True
                End If

                If apellido = "" Or (apellido <> "" And listaEmpleados(index).apellidos.ToUpper.Contains(apellido)) Then
                    encontradoA = True
                End If

                If encontradoA And encontradoN Then
                    BuscarEmpleados.Add(listaEmpleados(index))
                End If
            Next
        End Function

        Public Function BuscarIndiceEmpleado(nombre As String, apellidos As String) As Integer
            Dim indice As Integer
            Dim encontrado As Boolean = False
            For i = 0 To listaEmpleados.Count - 1
                If encontrado = False Then
                    If listaEmpleados(i).nombre = nombre And listaEmpleados(i).apellidos = apellidos Then
                        indice = i
                        encontrado = True
                    Else
                        indice = -1
                    End If
                End If
            Next
            Return indice
        End Function
        Sub Actualizar(indice As Integer, empleado As Empleado)
            listaEmpleados(indice) = empleado
        End Sub

        Sub Eliminar(indice As Integer)
            If indice >= 0 Then
                listaEmpleados.RemoveAt(indice)
            End If
        End Sub

        Sub eliminar(empleados As List(Of Empleado))
            For Each empleado As Empleado In empleados
                listaEmpleados.Remove(empleado)
            Next
        End Sub

    End Module
End Namespace