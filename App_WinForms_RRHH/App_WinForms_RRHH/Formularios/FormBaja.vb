Public Class Form_Baja
    Private Sub ActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Baja Empleado"
    End Sub

    Private Sub DesctivarseFormulario(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub

End Class