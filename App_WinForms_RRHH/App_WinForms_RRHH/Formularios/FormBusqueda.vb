Imports App_WinForms_RRHH.Modelo
Public Class FormBusqueda

    Public listaEmpleados As List(Of Empleado)
    Private empleado As Empleado
    Public frmMod As FormModificacion

    Private Sub AbrirFormulario(Of TForm As {Form, New})(ByRef form As Form)
        If form Is Nothing OrElse form.IsDisposed() Then
            form = New TForm
            form.MdiParent = MDIPrincipal
            form.Show()
        Else
            form.Show()
            ActivateMdiChild(form)
        End If
    End Sub
    Private Sub AbrirFormMod(ByRef form As Form)
        form = New FormModificacion
        form.MdiParent = MDIPrincipal
        form.Show()
    End Sub
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
            listaEmpleados.RemoveAt(indice)
        Next
        EmpleadosCRUD.Grabar()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim mdiPrincipal As MDIPrincipal

        mdiPrincipal = CType(Me.MdiParent, MDIPrincipal)

        mdiPrincipal.AbrirAlta()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        For Each indice In listResultados.SelectedIndices
            AbrirFormMod(frmMod)
            frmMod.txtNombre.Text = listaEmpleados(indice).nombre
            frmMod.txtApellidos.Text = listaEmpleados(indice).apellidos
            frmMod.cmbGenero.Text = listaEmpleados(indice).genero.ToString
            frmMod.domCategoría.Text = listaEmpleados(indice).categoria.ToString
            frmMod.empleadoOrigen = listaEmpleados(indice)
        Next
    End Sub

    Private Sub FormBusqueda_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        BuscarEmpleado()
    End Sub
End Class