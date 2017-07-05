<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificacion
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
        Me.numRetrFija = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiarAlta = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.domCategoría = New System.Windows.Forms.DomainUpDown()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.numRetrFija, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numRetrFija
        '
        Me.numRetrFija.DecimalPlaces = 2
        Me.numRetrFija.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numRetrFija.Location = New System.Drawing.Point(90, 173)
        Me.numRetrFija.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numRetrFija.Name = "numRetrFija"
        Me.numRetrFija.Size = New System.Drawing.Size(152, 20)
        Me.numRetrFija.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Retr. Fija:"
        '
        'btnLimpiarAlta
        '
        Me.btnLimpiarAlta.Location = New System.Drawing.Point(179, 220)
        Me.btnLimpiarAlta.Name = "btnLimpiarAlta"
        Me.btnLimpiarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarAlta.TabIndex = 21
        Me.btnLimpiarAlta.Text = "Limpiar"
        Me.btnLimpiarAlta.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.Location = New System.Drawing.Point(55, 220)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'domCategoría
        '
        Me.domCategoría.Items.Add("Jefe de Equipo")
        Me.domCategoría.Items.Add("Técnico")
        Me.domCategoría.Items.Add("Administrativo")
        Me.domCategoría.Location = New System.Drawing.Point(90, 131)
        Me.domCategoría.Name = "domCategoría"
        Me.domCategoría.Size = New System.Drawing.Size(152, 20)
        Me.domCategoría.TabIndex = 19
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Varón", "Mujer", "Hermafrodita"})
        Me.cmbGenero.Location = New System.Drawing.Point(90, 92)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(152, 21)
        Me.cmbGenero.TabIndex = 18
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(90, 54)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(152, 20)
        Me.txtApellidos.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Categoría:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Género:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(35, 57)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lblApellidos.TabIndex = 13
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(40, 21)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre:"
        '
        'FormModificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.numRetrFija)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiarAlta)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.domCategoría)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FormModificacion"
        Me.Text = "FormModificacion"
        CType(Me.numRetrFija, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numRetrFija As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiarAlta As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents domCategoría As DomainUpDown
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombre As Label
End Class
