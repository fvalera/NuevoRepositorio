<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEventosRaton
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblbotones = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pulsar para añadir botón"
        '
        'lblbotones
        '
        Me.lblbotones.AutoSize = True
        Me.lblbotones.Location = New System.Drawing.Point(162, 12)
        Me.lblbotones.Name = "lblbotones"
        Me.lblbotones.Size = New System.Drawing.Size(61, 13)
        Me.lblbotones.TabIndex = 1
        Me.lblbotones.Text = "Nº Botones"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "https://cyclinglive.files.wordpress.com/2016/01/paco-mancebo-biografia2.jpg"
        Me.PictureBox1.Location = New System.Drawing.Point(26, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(529, 320)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormEventosRaton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 399)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblbotones)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEventosRaton"
        Me.Text = "FormEventosRaton"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblbotones As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
