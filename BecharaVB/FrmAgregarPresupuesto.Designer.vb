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
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(41, 25)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(543, 564)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos del nuevo Presupuesto"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(34, 247)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(468, 126)
        Me.txtObservacion.TabIndex = 9
        Me.txtObservacion.Text = ""
        '
        'txtPrecioRepuestos
        '
        Me.txtPrecioRepuestos.Location = New System.Drawing.Point(199, 429)
        Me.txtPrecioRepuestos.Name = "txtPrecioRepuestos"
        Me.txtPrecioRepuestos.Size = New System.Drawing.Size(118, 24)
        Me.txtPrecioRepuestos.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 435)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 18)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Precio de Repuestos $"
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(199, 468)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(118, 24)
        Me.txtPrecioFinal.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 18)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Precio Final $"
        '
        'txtPrecioManoObra
        '
        Me.txtPrecioManoObra.Location = New System.Drawing.Point(199, 385)
        Me.txtPrecioManoObra.Name = "txtPrecioManoObra"
        Me.txtPrecioManoObra.Size = New System.Drawing.Size(118, 24)
        Me.txtPrecioManoObra.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Precio Mano de Obra $"
        '
        'cmbCombustible
        '
        Me.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.Label12.Size = New System.Drawing.Size(130, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Trabajos a realizar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Combustible"
        '
        'txtKilometros
        '
        Me.txtKilometros.Location = New System.Drawing.Point(381, 145)
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(121, 24)
        Me.txtKilometros.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Kilometros"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(381, 104)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 24)
        Me.txtModelo.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(381, 66)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(121, 24)
        Me.txtMarca.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Marca"
        '
        'dtpCaducidad
        '
        Me.dtpCaducidad.Location = New System.Drawing.Point(199, 513)
        Me.dtpCaducidad.Name = "dtpCaducidad"
        Me.dtpCaducidad.Size = New System.Drawing.Size(257, 24)
        Me.dtpCaducidad.TabIndex = 13
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(47, 518)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(143, 18)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Fecha de Caducidad"
        '
        'txtApellido
        '
        Me.txtApellido.AcceptsReturn = True
        Me.txtApellido.Location = New System.Drawing.Point(148, 59)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(118, 24)
        Me.txtApellido.TabIndex = 1
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(148, 180)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(118, 24)
        Me.txtPatente.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(148, 139)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(118, 24)
        Me.txtDireccion.TabIndex = 3
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(148, 99)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(118, 24)
        Me.txtDni.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(118, 24)
        Me.txtNombre.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Apellido"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 142)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "DNI"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 18)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(31, 183)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 102)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Direccion"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.icono_eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(491, 618)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 35)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.tilde
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(385, 618)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(78, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Aceptar"
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
        Me.Name = "FrmAgregarPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR PRESUPUESTO"
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
