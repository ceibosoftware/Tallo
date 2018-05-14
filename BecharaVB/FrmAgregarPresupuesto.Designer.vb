<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarPresupuesto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarPresupuesto))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.txtPrecioRepuestos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrecioManoObra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCombustible = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKilometros = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.txtObservacion)
        Me.groupBox1.Controls.Add(Me.txtPrecioRepuestos)
        Me.groupBox1.Controls.Add(Me.Label14)
        Me.groupBox1.Controls.Add(Me.txtPrecioFinal)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Controls.Add(Me.txtPrecioManoObra)
        Me.groupBox1.Controls.Add(Me.Label11)
        Me.groupBox1.Controls.Add(Me.cmbCombustible)
        Me.groupBox1.Controls.Add(Me.Label12)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.txtKilometros)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.txtModelo)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtMarca)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.dtpCaducidad)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtApellido)
        Me.groupBox1.Controls.Add(Me.txtPatente)
        Me.groupBox1.Controls.Add(Me.txtDireccion)
        Me.groupBox1.Controls.Add(Me.txtDni)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(41, 25)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(543, 564)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "agregar presupuesto"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.OliveDrab
        Me.txtObservacion.Location = New System.Drawing.Point(34, 247)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(468, 126)
        Me.txtObservacion.TabIndex = 9
        Me.txtObservacion.Text = ""
        '
        'txtPrecioRepuestos
        '
        Me.txtPrecioRepuestos.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPrecioRepuestos.Location = New System.Drawing.Point(215, 427)
        Me.txtPrecioRepuestos.Name = "txtPrecioRepuestos"
        Me.txtPrecioRepuestos.Size = New System.Drawing.Size(118, 26)
        Me.txtPrecioRepuestos.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 435)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(170, 18)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "precio de repuestos $"
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPrecioFinal.Location = New System.Drawing.Point(215, 471)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(118, 26)
        Me.txtPrecioFinal.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 18)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "precio final $"
        '
        'txtPrecioManoObra
        '
        Me.txtPrecioManoObra.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPrecioManoObra.Location = New System.Drawing.Point(215, 385)
        Me.txtPrecioManoObra.Name = "txtPrecioManoObra"
        Me.txtPrecioManoObra.Size = New System.Drawing.Size(118, 26)
        Me.txtPrecioManoObra.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "precio mano de obra $"
        '
        'cmbCombustible
        '
        Me.cmbCombustible.BackColor = System.Drawing.Color.OliveDrab
        Me.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCombustible.ForeColor = System.Drawing.Color.White
        Me.cmbCombustible.FormattingEnabled = True
        Me.cmbCombustible.Items.AddRange(New Object() {"Nafta", "GNC", "Diesel"})
        Me.cmbCombustible.Location = New System.Drawing.Point(381, 28)
        Me.cmbCombustible.Name = "cmbCombustible"
        Me.cmbCombustible.Size = New System.Drawing.Size(121, 26)
        Me.cmbCombustible.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "trabajos a realizar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "combustible"
        '
        'txtKilometros
        '
        Me.txtKilometros.BackColor = System.Drawing.Color.OliveDrab
        Me.txtKilometros.Location = New System.Drawing.Point(381, 145)
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(121, 26)
        Me.txtKilometros.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "kilometros"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtModelo.Location = New System.Drawing.Point(381, 104)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 26)
        Me.txtModelo.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "modelo"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.OliveDrab
        Me.txtMarca.Location = New System.Drawing.Point(381, 66)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(121, 26)
        Me.txtMarca.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "marca"
        '
        'dtpCaducidad
        '
        Me.dtpCaducidad.CalendarForeColor = System.Drawing.Color.OliveDrab
        Me.dtpCaducidad.CalendarMonthBackground = System.Drawing.Color.OliveDrab
        Me.dtpCaducidad.Location = New System.Drawing.Point(215, 510)
        Me.dtpCaducidad.Name = "dtpCaducidad"
        Me.dtpCaducidad.Size = New System.Drawing.Size(257, 26)
        Me.dtpCaducidad.TabIndex = 13
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(47, 518)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(149, 18)
        Me.label6.TabIndex = 10
        Me.label6.Text = "fecha de caducidad"
        '
        'txtApellido
        '
        Me.txtApellido.AcceptsReturn = True
        Me.txtApellido.BackColor = System.Drawing.Color.OliveDrab
        Me.txtApellido.Location = New System.Drawing.Point(148, 59)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(118, 26)
        Me.txtApellido.TabIndex = 1
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPatente.Location = New System.Drawing.Point(148, 180)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(118, 26)
        Me.txtPatente.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.OliveDrab
        Me.txtDireccion.Location = New System.Drawing.Point(148, 139)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(118, 26)
        Me.txtDireccion.TabIndex = 3
        '
        'txtDni
        '
        Me.txtDni.BackColor = System.Drawing.Color.OliveDrab
        Me.txtDni.Location = New System.Drawing.Point(148, 99)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(118, 26)
        Me.txtDni.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.OliveDrab
        Me.txtNombre.Location = New System.Drawing.Point(148, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(118, 26)
        Me.txtNombre.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "apellido"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 142)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(29, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "dni"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 18)
        Me.label1.TabIndex = 0
        Me.label1.Text = "nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(31, 183)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 102)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "direccion"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(491, 618)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(81, 35)
        Me.button2.TabIndex = 1
        Me.button2.Text = "cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.check
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(385, 618)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(78, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'FrmAgregarPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 656)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.button1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar presupuesto"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Public WithEvents dtpCaducidad As DateTimePicker
    Private WithEvents label6 As Label
    Public WithEvents txtApellido As TextBox
    Public WithEvents txtPatente As TextBox
    Public WithEvents txtDireccion As TextBox
    Public WithEvents txtDni As TextBox
    Public WithEvents txtNombre As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Friend WithEvents Label12 As Label
    Private WithEvents Label10 As Label
    Public WithEvents txtKilometros As TextBox
    Private WithEvents Label9 As Label
    Public WithEvents txtModelo As TextBox
    Private WithEvents Label8 As Label
    Public WithEvents txtMarca As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents cmbCombustible As ComboBox
    Public WithEvents txtPrecioRepuestos As TextBox
    Private WithEvents Label14 As Label
    Public WithEvents txtPrecioFinal As TextBox
    Private WithEvents Label13 As Label
    Public WithEvents txtPrecioManoObra As TextBox
    Private WithEvents Label11 As Label
    Friend WithEvents txtObservacion As RichTextBox
End Class
