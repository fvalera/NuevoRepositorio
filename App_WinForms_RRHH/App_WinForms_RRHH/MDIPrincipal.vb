Imports System.Windows.Forms
Imports App_WinForms_RRHH.Modelo

Public Class MDIPrincipal

    Private empleadosFichero As New EmpleadosFichero
    Private empleadosExcel As New EmpleadosExcel

    Dim frmAlta As Form_Alta
    Dim frmLista As FormBusqueda
    Private Sub AbrirFormulario(Of TForm As {Form, New})(ByRef form As Form)
        If form Is Nothing OrElse form.IsDisposed() Then
            form = New TForm
            form.MdiParent = Me
            form.Show()
        Else
            form.Show()
            ActivateMdiChild(form)
        End If
    End Sub
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        AbrirFormulario(Of FormBusqueda)(frmLista)
    End Sub
    Public Sub AbrirAlta()
        AbrirFormulario(Of Form_Alta)(frmAlta)
    End Sub
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AbrirFormulario(Of Form_Alta)(frmAlta)
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        AbrirFormulario(Of FormBusqueda)(frmLista)
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1
        EmpleadoToolStripMenuItem.Enabled = False
    End Sub


    'Código autogenerado
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Public Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        empleadosFichero.NombreFichero = DialogoAbrirFichero("csv")
        EmpleadosCRUD.Restaurar(empleadosFichero)
    End Sub

    Function DialogoAbrirFichero(extension As String) As String
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*." & extension & ")|*." & extension & "|Todos los archivos (*.*)|*.*"
        OpenFileDialog.CheckFileExists = True
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            EmpleadoToolStripMenuItem.Enabled = True
            Return OpenFileDialog.FileName
        Else
            Return ""
        End If
    End Function

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        empleadosFichero.NombreFichero = DialogoGuardarFichero("csv")
        EmpleadosCRUD.Grabar(empleadosFichero)
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        empleadosFichero.NombreFichero = DialogoGuardarFichero("csv")
        EmpleadosCRUD.Grabar(empleadosFichero)
    End Sub
    Function DialogoGuardarFichero(extension As String) As String
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = empleadosFichero.NombreFichero
        SaveFileDialog.Filter = "Archivos de texto (*." & extension & ")|*." & extension & "|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            Return SaveFileDialog.FileName
        Else
            Return ""
        End If
    End Function
    Private Sub ImportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarExcelToolStripMenuItem.Click
        empleadosFichero.NombreFichero = DialogoAbrirFichero("xls")
        EmpleadosCRUD.Restaurar(empleadosFichero)
    End Sub

    Private Sub ExportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarExcelToolStripMenuItem.Click
        empleadosFichero.NombreFichero = DialogoGuardarFichero("xls")
        EmpleadosCRUD.Grabar(empleadosFichero)
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer https://www.bbva.es")
    End Sub

    Private Sub CambiarFuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFuenteToolStripMenuItem.Click

        Dim dialogoFuente As New FontDialog

        If dialogoFuente.ShowDialog(Me) = DialogResult.OK Then
            Me.Font = dialogoFuente.Font
            For Each form In Me.MdiChildren
                form.Font = dialogoFuente.Font
            Next
        End If
    End Sub

End Class
