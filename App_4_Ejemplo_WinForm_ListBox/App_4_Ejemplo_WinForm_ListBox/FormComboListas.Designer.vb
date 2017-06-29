<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComboListas
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
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.lblTxt = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbTextos = New System.Windows.Forms.ComboBox()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.chkListTextos = New System.Windows.Forms.CheckedListBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(13, 33)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(215, 20)
        Me.txtTexto.TabIndex = 0
        '
        'lblTxt
        '
        Me.lblTxt.AutoSize = True
        Me.lblTxt.Location = New System.Drawing.Point(10, 9)
        Me.lblTxt.Name = "lblTxt"
        Me.lblTxt.Size = New System.Drawing.Size(75, 13)
        Me.lblTxt.TabIndex = 1
        Me.lblTxt.Text = "Texto a añadir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(13, 75)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(215, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTextos
        '
        Me.cmbTextos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTextos.FormattingEnabled = True
        Me.cmbTextos.Location = New System.Drawing.Point(13, 136)
        Me.cmbTextos.Name = "cmbTextos"
        Me.cmbTextos.Size = New System.Drawing.Size(215, 21)
        Me.cmbTextos.TabIndex = 3
        '
        'btnPasar
        '
        Me.btnPasar.Location = New System.Drawing.Point(13, 177)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(214, 23)
        Me.btnPasar.TabIndex = 4
        Me.btnPasar.Text = "Pasar"
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(13, 217)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(214, 23)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'chkListTextos
        '
        Me.chkListTextos.FormattingEnabled = True
        Me.chkListTextos.Location = New System.Drawing.Point(266, 33)
        Me.chkListTextos.Name = "chkListTextos"
        Me.chkListTextos.Size = New System.Drawing.Size(225, 199)
        Me.chkListTextos.TabIndex = 6
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(502, 33)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 225)
        Me.TrackBar1.TabIndex = 7
        '
        'FormComboListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 289)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.chkListTextos)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.cmbTextos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblTxt)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "FormComboListas"
        Me.Text = "FormComboListas"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents lblTxt As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbTextos As ComboBox
    Friend WithEvents btnPasar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents chkListTextos As CheckedListBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
