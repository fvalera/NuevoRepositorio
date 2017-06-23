Public Class CálculoAreasPerimetrosFiguras
    Private Sub NumAncho_ValueChanged(sender As NumericUpDown, e As EventArgs) Handles NumAncho.ValueChanged, NumAlto.ValueChanged
        Dim rec_1 As Rectangulo = New Rectangulo(NumAlto.Value, NumAncho.Value)

        NumArea.Value = rec_1.CalcularArea
        NumPer.Value = rec_1.CalcularPerimetro
    End Sub

    Private Sub CheckedChanged(sender As RadioButton, e As EventArgs) Handles RadRectangulo.CheckedChanged
        If RadRectangulo.Checked Then
            GroupRectangulo.Visible = True
            GroupCirculo.Visible = False
            GroupCirculo.ResumeLayout()
        Else
            GroupRectangulo.Visible = False
            GroupCirculo.Visible = True
        End If
    End Sub



    Private Sub NumRadio_ValueChanged(sender As Object, e As EventArgs) Handles NumRadio.ValueChanged
        Dim circ_1 = New Circulo(NumRadio.Value)

        NumAreaCirc.Value = circ_1.CalcularArea
        NumPerCirc.Value = circ_1.CalcularPerimetro
    End Sub

    Private Sub NumAncho_ValueChanged(sender As Object, e As EventArgs) Handles NumAncho.ValueChanged, NumAlto.ValueChanged

    End Sub

    Private Sub CbxTipoCalculoRec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTipoCalculoRec.SelectedIndexChanged, NumAnchoTab.ValueChanged, NumAltoTab.ValueChanged
        Dim rec_1 As Rectangulo = New Rectangulo(NumAltoTab.Value, NumAnchoTab.Value)

        If CbxTipoCalculoRec.SelectedIndex = 0 Then
            NumResRec.Value = rec_1.CalcularArea
        Else
            NumResRec.Value = rec_1.CalcularPerimetro
        End If

    End Sub

    Private Sub Cbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCirc.SelectedIndexChanged, NumRadioTab.ValueChanged
        Dim cir_1 As Circulo = New Circulo(NumRadioTab.Value)

        If CbxCirc.SelectedIndex = 0 Then
            NumResCirc.Value = cir_1.CalcularArea
        Else
            NumResCirc.Value = cir_1.CalcularPerimetro
        End If
    End Sub
End Class
