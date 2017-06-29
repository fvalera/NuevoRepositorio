Public Class FormComboListas
    Private Sub FormComboListas_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        For i = 0 To My.Application.OpenForms.Count - 1
            lblTxt.Text += My.Application.OpenForms.Item(i).Text & vbCrLf
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtTexto.Text.Length > 0 Then
            cmbTextos.Items.Add(txtTexto.Text)
            txtTexto.Text = ""
            txtTexto.Focus()
        End If
    End Sub

    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click
        If chkListTextos.Items.Count < TrackBar1.Value Then
            chkListTextos.Items.Add(cmbTextos.SelectedItem)
            cmbTextos.Items.Remove(cmbTextos.SelectedItem)
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click

        For x = 0 To chkListTextos.CheckedItems.Count - 1
            cmbTextos.Items.Add(chkListTextos.CheckedItems.Item(0))
            chkListTextos.Items.Remove(chkListTextos.CheckedItems.Item(0))
        Next

    End Sub
End Class