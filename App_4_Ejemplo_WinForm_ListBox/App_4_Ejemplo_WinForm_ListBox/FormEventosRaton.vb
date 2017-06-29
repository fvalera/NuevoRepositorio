Public Class FormEventosRaton

    Dim nuevoBoton As Button
    Dim listaBotones As List(Of Button)

    'Public Sub AlPulsarRaton(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Me.MouseMove

    '    Dim nuevoBoton As New Button
    '    nuevoBoton = New Button
    '    nuevoBoton.Size = New Size(20, 20)
    '    nuevoBoton.Text = "X"

    '    nuevoBoton.Parent = Me
    '    nuevoBoton.Location = e.Location

    'End Sub

    Public Sub Form_OnMouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

        nuevoBoton = New Button
        nuevoBoton.Size = New Size(20, 20)
        nuevoBoton.Text = "X"

        nuevoBoton.Parent = Me
        nuevoBoton.Location = e.Location + PictureBox1.Location

        nuevoBoton.BringToFront()

        AddHandler PictureBox1.MouseMove, AddressOf Form_OnMouseMove

    End Sub

    Public Sub Form_OnMouseMove(sender As Object, e As MouseEventArgs)

        nuevoBoton.Location = e.Location + PictureBox1.Location

    End Sub

    Public Sub Form_OnMouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        RemoveHandler PictureBox1.MouseMove, AddressOf Form_OnMouseMove
        nuevoBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold)

        listaBotones.Add(nuevoBoton)

        lblbotones.Text = "Nº Botones creados: " & listaBotones.Count
    End Sub

    Private Sub FormEventosRaton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaBotones = New List(Of Button)
    End Sub

    'Private Sub PictureBox1_OnMouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, PictureBox1.MouseEnter
    '    MsgBox("Entrando o Saliendo")
    'End Sub
End Class