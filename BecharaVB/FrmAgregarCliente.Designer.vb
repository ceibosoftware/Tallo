<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCliente
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpCliente = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.icono_eliminar1
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(383, 389)
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
        Me.button1.Location = New System.Drawing.Point(290, 389)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.dtpCliente)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtApellidoCliente)
        Me.groupBox1.Controls.Add(Me.txtTelefonoCliente)
        Me.groupBox1.Controls.Add(Me.txtDireccionCliente)
        Me.groupBox1.Controls.Add(Me.txtDniCliente)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(21, 36)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(465, 328)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos del nuevo cliente"
        '
        'dtpCliente
        '
        Me.dtpCliente.Location = New System.Drawing.Point(131, 243)
        Me.dtpCliente.Name = "dtpCliente"
        Me.dtpCliente.Size = New System.Drawing.Size(258, 24)
        Me.dtpCliente.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(0, 243)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(128, 18)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Fecha Nacimiento"
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.AcceptsReturn = True
        Me.txtApellidoCliente.Location = New System.Drawing.Point(130, 76)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(118, 24)
        Me.txtApellidoCliente.TabIndex = 1
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(131, 196)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(118, 24)
        Me.txtTelefonoCliente.TabIndex = 4
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(130, 155)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(118, 24)
        Me.txtDireccionCliente.TabIndex = 3
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(130, 115)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(118, 24)
        Me.txtDniCliente.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(130, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(118, 24)
        Me.txtNombre.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(53, 76)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Apellido"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(53, 115)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "DNI"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(53, 43)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 18)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(53, 199)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(66, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Telefono"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(53, 161)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Direccion"
        '
        'FrmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 448)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.DoubleBuffered = True
        Me.Name = "FrmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR CLIENTE"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Public WithEvents txtNombre As TextBox
    Public WithEvents dtpCliente As DateTimePicker
    Public WithEvents txtApellidoCliente As TextBox
    Public WithEvents txtTelefonoCliente As TextBox
    Public WithEvents txtDireccionCliente As TextBox
    Public WithEvents txtDniCliente As TextBox
End Class
