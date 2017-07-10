Public Class FormExcel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos CSV (*.csv)|*.txt|Todos los archivos (*.*)|*.*"
        OpenFileDialog.CheckFileExists = True
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            TextBox1.Text = FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = LectorExcel.DameValorCelda(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Escritor.NuevoExcelFijo(TextBox1.Text)
    End Sub
End Class