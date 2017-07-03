Imports App_WinForms_RRHH.Modelo
Public Class Form_Alta
    Private Sub btnGuardarAlta_Click(sender As Object, e As EventArgs) Handles btnGuardarAlta.Click

        Try
            Dim nuevoEmpleado As Empleado = New Empleado()

            ' Asignamos valores
            nuevoEmpleado.nombre = txtNombre.Text
            nuevoEmpleado.apellidos = txtApellidos.Text
            nuevoEmpleado.genero = cmbGenero.SelectedIndex + 1
            nuevoEmpleado.categoria = domCategoría.SelectedIndex + 1

            EmpleadosCRUD.Crear(nuevoEmpleado)

            Me.Close()
            MsgBox("Empleado creado:" & nuevoEmpleado.ToString)
        Catch ex As Exception
            MsgBox("Error al guardar")
        End Try
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellidos.TextChanged, cmbGenero.TextChanged, domCategoría.TextChanged, numRetrFija.TextChanged
        btnGuardarAlta.Enabled = txtNombre.Text <> "" And
            txtApellidos.Text <> "" And
            cmbGenero.SelectedIndex >= 0 And
            domCategoría.SelectedIndex >= 0 _
            And numRetrFija.Value > 0
    End Sub

    Private Sub btnLimpiarAlta_Click(sender As Object, e As EventArgs) Handles btnLimpiarAlta.Click
        txtNombre.Clear()
        txtApellidos.Clear()
        cmbGenero.SelectedIndex = -1
        domCategoría.SelectedIndex = -1
        domCategoría.Text = ""
        numRetrFija.Value = 0
    End Sub

    Private Sub ActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Alta Empleado"
    End Sub

    Private Sub DesctivarseFormulario(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub
End Class