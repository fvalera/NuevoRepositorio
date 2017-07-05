﻿Imports App_WinForms_RRHH.Modelo
Public Class FormBusqueda

    Public listaEmpleados As List(Of Empleado)
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellidos.TextChanged
        BuscarEmpleado()
    End Sub

    Private Sub BuscarEmpleado()

        listResultados.Items.Clear()

        listaEmpleados = BuscarEmpleados(txtNombre.Text, txtApellidos.Text)

        For Each empleado As Empleado In listaEmpleados
            listResultados.Items.Add(empleado.nombre & " " & empleado.apellidos)
        Next

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim indiceABorrar As Integer

        For Each indice In listResultados.SelectedIndices
            indiceABorrar = EmpleadosCRUD.BuscarIndiceEmpleado(listaEmpleados(indice).nombre, listaEmpleados(indice).apellidos)
            EmpleadosCRUD.Eliminar(indiceABorrar)
        Next

        For Each indice In listResultados.SelectedIndices
            listResultados.Items.RemoveAt(indice)
        Next
        EmpleadosCRUD.Grabar()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim mdiPrincipal As MDIPrincipal

        mdiPrincipal = CType(Me.MdiParent, MDIPrincipal)

        mdiPrincipal.AbrirAlta()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click



    End Sub
End Class