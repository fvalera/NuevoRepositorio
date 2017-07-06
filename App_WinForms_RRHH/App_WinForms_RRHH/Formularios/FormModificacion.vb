Imports App_WinForms_RRHH.Modelo
Public Class FormModificacion

    Public empleadoOrigen As Empleado
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim empleadoModificado As Empleado
        empleadoModificado.nombre = txtNombre.Text
        empleadoModificado.apellidos = txtApellidos.Text
        empleadoModificado.genero = cmbGenero.SelectedIndex + 1
        empleadoModificado.categoria = domCategoría.SelectedIndex + 1

        EmpleadosCRUD.Actualizar(empleadoOrigen, empleadoModificado)

        Me.Close()

        MsgBox("Empleado modificado con éxito")
    End Sub

    Private Sub btnLimpiarAlta_Click(sender As Object, e As EventArgs) Handles btnLimpiarAlta.Click
        txtNombre.Clear()
        txtApellidos.Clear()
        cmbGenero.SelectedIndex = -1
        domCategoría.SelectedIndex = -1
        domCategoría.Text = ""
        numRetrFija.Value = 0
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellidos.TextChanged, cmbGenero.TextChanged, domCategoría.TextChanged, numRetrFija.TextChanged
        btnActualizar.Enabled = txtNombre.Text <> "" And
            txtApellidos.Text <> "" And
            cmbGenero.SelectedIndex >= 0 And
            domCategoría.SelectedIndex >= 0 _
            And numRetrFija.Value > 0
    End Sub
End Class