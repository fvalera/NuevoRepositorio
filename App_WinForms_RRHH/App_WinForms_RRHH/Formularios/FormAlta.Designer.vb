<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Alta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.domCategoría = New System.Windows.Forms.DomainUpDown()
        Me.btnGuardarAlta = New System.Windows.Forms.Button()
        Me.btnLimpiarAlta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numRetrFija = New System.Windows.Forms.NumericUpDown()
        CType(Me.numRetrFija, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(12, 65)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lblApellidos.TabIndex = 1
        Me.lblApellidos.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Género:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Categoría:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(67, 62)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(152, 20)
        Me.txtApellidos.TabIndex = 5
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Varón", "Mujer", "Hermafrodita"})
        Me.cmbGenero.Location = New System.Drawing.Point(67, 100)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(152, 21)
        Me.cmbGenero.TabIndex = 6
        '
        'domCategoría
        '
        Me.domCategoría.Items.Add("Jefe de Equipo")
        Me.domCategoría.Items.Add("Técnico")
        Me.domCategoría.Items.Add("Administrativo")
        Me.domCategoría.Location = New System.Drawing.Point(67, 139)
        Me.domCategoría.Name = "domCategoría"
        Me.domCategoría.Size = New System.Drawing.Size(152, 20)
        Me.domCategoría.TabIndex = 7
        '
        'btnGuardarAlta
        '
        Me.btnGuardarAlta.Enabled = False
        Me.btnGuardarAlta.Location = New System.Drawing.Point(32, 228)
        Me.btnGuardarAlta.Name = "btnGuardarAlta"
        Me.btnGuardarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAlta.TabIndex = 8
        Me.btnGuardarAlta.Text = "Guardar"
        Me.btnGuardarAlta.UseVisualStyleBackColor = True
        '
        'btnLimpiarAlta
        '
        Me.btnLimpiarAlta.Location = New System.Drawing.Point(156, 228)
        Me.btnLimpiarAlta.Name = "btnLimpiarAlta"
        Me.btnLimpiarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarAlta.TabIndex = 9
        Me.btnLimpiarAlta.Text = "Limpiar"
        Me.btnLimpiarAlta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Retr. Fija:"
        '
        'numRetrFija
        '
        Me.numRetrFija.DecimalPlaces = 2
        Me.numRetrFija.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numRetrFija.Location = New System.Drawing.Point(67, 181)
        Me.numRetrFija.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numRetrFija.Name = "numRetrFija"
        Me.numRetrFija.Size = New System.Drawing.Size(152, 20)
        Me.numRetrFija.TabIndex = 11
        '
        'Form_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 323)
        Me.Controls.Add(Me.numRetrFija)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLimpiarAlta)
        Me.Controls.Add(Me.btnGuardarAlta)
        Me.Controls.Add(Me.domCategoría)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form_Alta"
        Me.Text = "Alta Empleado"
        CType(Me.numRetrFija, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents domCategoría As DomainUpDown
    Friend WithEvents btnGuardarAlta As Button
    Friend WithEvents btnLimpiarAlta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents numRetrFija As NumericUpDown
End Class
