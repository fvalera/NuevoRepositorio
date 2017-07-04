Imports App_WinForms_RRHH.Modelo
Public Class Form_Baja

    Private frmLista As New FormLista
    Private Sub ActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Baja Empleado"
    End Sub

    Private Sub DesctivarseFormulario(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EmpleadosCRUD.eliminar(frmLista.listaEmpleados)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmLista.ShowDialog(Me)
        lstEmpleados.Items.Clear()
        lstEmpleados.Items.AddRange(frmLista.listResultados.Items)
    End Sub
End Class