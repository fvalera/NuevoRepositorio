<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CálculoAreasPerimetrosFiguras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadCirculo = New System.Windows.Forms.RadioButton()
        Me.RadRectangulo = New System.Windows.Forms.RadioButton()
        Me.GroupRectangulo = New System.Windows.Forms.GroupBox()
        Me.GroupCirculo = New System.Windows.Forms.GroupBox()
        Me.NumPerCirc = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumAreaCirc = New System.Windows.Forms.NumericUpDown()
        Me.NumRadio = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumPer = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumArea = New System.Windows.Forms.NumericUpDown()
        Me.NumAlto = New System.Windows.Forms.NumericUpDown()
        Me.NumAncho = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupRectangulo.SuspendLayout()
        Me.GroupCirculo.SuspendLayout()
        CType(Me.NumPerCirc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAreaCirc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadCirculo)
        Me.GroupBox1.Controls.Add(Me.RadRectangulo)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecciona una figura"
        '
        'RadCirculo
        '
        Me.RadCirculo.AutoSize = True
        Me.RadCirculo.Location = New System.Drawing.Point(20, 59)
        Me.RadCirculo.Name = "RadCirculo"
        Me.RadCirculo.Size = New System.Drawing.Size(59, 17)
        Me.RadCirculo.TabIndex = 1
        Me.RadCirculo.Text = "Círculo"
        Me.RadCirculo.UseVisualStyleBackColor = True
        '
        'RadRectangulo
        '
        Me.RadRectangulo.AutoSize = True
        Me.RadRectangulo.Checked = True
        Me.RadRectangulo.Location = New System.Drawing.Point(20, 35)
        Me.RadRectangulo.Name = "RadRectangulo"
        Me.RadRectangulo.Size = New System.Drawing.Size(80, 17)
        Me.RadRectangulo.TabIndex = 0
        Me.RadRectangulo.TabStop = True
        Me.RadRectangulo.Text = "Rectángulo"
        Me.RadRectangulo.UseVisualStyleBackColor = True
        '
        'GroupRectangulo
        '
        Me.GroupRectangulo.Controls.Add(Me.NumPer)
        Me.GroupRectangulo.Controls.Add(Me.Label4)
        Me.GroupRectangulo.Controls.Add(Me.NumArea)
        Me.GroupRectangulo.Controls.Add(Me.NumAlto)
        Me.GroupRectangulo.Controls.Add(Me.NumAncho)
        Me.GroupRectangulo.Controls.Add(Me.Label3)
        Me.GroupRectangulo.Controls.Add(Me.Label2)
        Me.GroupRectangulo.Controls.Add(Me.Label1)
        Me.GroupRectangulo.Location = New System.Drawing.Point(32, 133)
        Me.GroupRectangulo.Name = "GroupRectangulo"
        Me.GroupRectangulo.Size = New System.Drawing.Size(252, 168)
        Me.GroupRectangulo.TabIndex = 1
        Me.GroupRectangulo.TabStop = False
        Me.GroupRectangulo.Text = "Rectangulo"
        '
        'GroupCirculo
        '
        Me.GroupCirculo.Controls.Add(Me.NumPerCirc)
        Me.GroupCirculo.Controls.Add(Me.Label5)
        Me.GroupCirculo.Controls.Add(Me.NumAreaCirc)
        Me.GroupCirculo.Controls.Add(Me.NumRadio)
        Me.GroupCirculo.Controls.Add(Me.Label6)
        Me.GroupCirculo.Controls.Add(Me.Label8)
        Me.GroupCirculo.Location = New System.Drawing.Point(31, 133)
        Me.GroupCirculo.Name = "GroupCirculo"
        Me.GroupCirculo.Size = New System.Drawing.Size(252, 168)
        Me.GroupCirculo.TabIndex = 8
        Me.GroupCirculo.TabStop = False
        Me.GroupCirculo.Text = "Circulo"
        Me.GroupCirculo.Visible = False
        '
        'NumPerCirc
        '
        Me.NumPerCirc.DecimalPlaces = 2
        Me.NumPerCirc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPerCirc.Location = New System.Drawing.Point(69, 110)
        Me.NumPerCirc.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumPerCirc.Name = "NumPerCirc"
        Me.NumPerCirc.ReadOnly = True
        Me.NumPerCirc.Size = New System.Drawing.Size(120, 20)
        Me.NumPerCirc.TabIndex = 7
        Me.NumPerCirc.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Perímetro:"
        '
        'NumAreaCirc
        '
        Me.NumAreaCirc.DecimalPlaces = 2
        Me.NumAreaCirc.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumAreaCirc.Location = New System.Drawing.Point(69, 80)
        Me.NumAreaCirc.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumAreaCirc.Name = "NumAreaCirc"
        Me.NumAreaCirc.ReadOnly = True
        Me.NumAreaCirc.Size = New System.Drawing.Size(120, 20)
        Me.NumAreaCirc.TabIndex = 5
        Me.NumAreaCirc.ThousandsSeparator = True
        '
        'NumRadio
        '
        Me.NumRadio.DecimalPlaces = 2
        Me.NumRadio.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumRadio.Location = New System.Drawing.Point(66, 20)
        Me.NumRadio.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumRadio.Name = "NumRadio"
        Me.NumRadio.Size = New System.Drawing.Size(120, 20)
        Me.NumRadio.TabIndex = 3
        Me.NumRadio.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Area:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Radio:"
        '
        'NumPer
        '
        Me.NumPer.DecimalPlaces = 2
        Me.NumPer.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPer.Location = New System.Drawing.Point(69, 110)
        Me.NumPer.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumPer.Name = "NumPer"
        Me.NumPer.ReadOnly = True
        Me.NumPer.Size = New System.Drawing.Size(120, 20)
        Me.NumPer.TabIndex = 7
        Me.NumPer.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Perímetro:"
        '
        'NumArea
        '
        Me.NumArea.DecimalPlaces = 2
        Me.NumArea.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumArea.Location = New System.Drawing.Point(69, 80)
        Me.NumArea.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumArea.Name = "NumArea"
        Me.NumArea.ReadOnly = True
        Me.NumArea.Size = New System.Drawing.Size(120, 20)
        Me.NumArea.TabIndex = 5
        Me.NumArea.ThousandsSeparator = True
        '
        'NumAlto
        '
        Me.NumAlto.DecimalPlaces = 2
        Me.NumAlto.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumAlto.Location = New System.Drawing.Point(69, 49)
        Me.NumAlto.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumAlto.Name = "NumAlto"
        Me.NumAlto.Size = New System.Drawing.Size(120, 20)
        Me.NumAlto.TabIndex = 4
        Me.NumAlto.ThousandsSeparator = True
        '
        'NumAncho
        '
        Me.NumAncho.DecimalPlaces = 2
        Me.NumAncho.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumAncho.Location = New System.Drawing.Point(69, 20)
        Me.NumAncho.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumAncho.Name = "NumAncho"
        Me.NumAncho.Size = New System.Drawing.Size(120, 20)
        Me.NumAncho.TabIndex = 3
        Me.NumAncho.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancho:"
        '
        'CálculoAreasPerimetrosFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 313)
        Me.Controls.Add(Me.GroupCirculo)
        Me.Controls.Add(Me.GroupRectangulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CálculoAreasPerimetrosFiguras"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupRectangulo.ResumeLayout(False)
        Me.GroupRectangulo.PerformLayout()
        Me.GroupCirculo.ResumeLayout(False)
        Me.GroupCirculo.PerformLayout()
        CType(Me.NumPerCirc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAreaCirc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAncho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadCirculo As RadioButton
    Friend WithEvents RadRectangulo As RadioButton
    Friend WithEvents GroupRectangulo As GroupBox
    Friend WithEvents NumArea As NumericUpDown
    Friend WithEvents NumAlto As NumericUpDown
    Friend WithEvents NumAncho As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumPer As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupCirculo As GroupBox
    Friend WithEvents NumPerCirc As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumAreaCirc As NumericUpDown
    Friend WithEvents NumRadio As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
