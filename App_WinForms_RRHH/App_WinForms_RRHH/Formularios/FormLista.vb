Imports App_WinForms_RRHH.Modelo
Public Class FormLista

    Public listaEmpleados As List(Of Empleado)
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cmbNombre.TextChanged, cmbApellidos.TextChanged
        BuscarEmpleado()
    End Sub

    Private Sub BuscarEmpleado()

        listResultados.Items.Clear()

        listaEmpleados = BuscarEmpleados(cmbNombre.Text, cmbApellidos.Text)

        For Each empleado As Empleado In listaEmpleados
            listResultados.Items.Add(empleado.nombre & " " & empleado.apellidos)
        Next

    End Sub
End Class