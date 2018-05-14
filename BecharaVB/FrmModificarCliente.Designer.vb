<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarCliente))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpCliente = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.hola = New System.Windows.Forms.TextBox()
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
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(410, 365)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(92, 35)
        Me.button2.TabIndex = 1
        Me.button2.Text = "cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.OliveDrab
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.check
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(309, 365)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(86, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "aceptar"
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
        Me.groupBox1.Controls.Add(Me.hola)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(26, 29)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(476, 302)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "modificar cliente"
        '
        'dtpCliente
        '
        Me.dtpCliente.Location = New System.Drawing.Point(163, 217)
        Me.dtpCliente.Name = "dtpCliente"
        Me.dtpCliente.Size = New System.Drawing.Size(283, 26)
        Me.dtpCliente.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(29, 222)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(134, 18)
        Me.label6.TabIndex = 10
        Me.label6.Text = "fecha nacimiento"
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.AcceptsReturn = True
        Me.txtApellidoCliente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtApellidoCliente.Location = New System.Drawing.Point(163, 62)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(118, 26)
        Me.txtApellidoCliente.TabIndex = 1
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(163, 182)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(118, 26)
        Me.txtTelefonoCliente.TabIndex = 4
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtDireccionCliente.Location = New System.Drawing.Point(163, 141)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(118, 26)
        Me.txtDireccionCliente.TabIndex = 3
        '
        'txtDniCliente
        '
        Me.txtDniCliente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtDniCliente.Location = New System.Drawing.Point(163, 101)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(118, 26)
        Me.txtDniCliente.TabIndex = 2
        '
        'hola
        '
        Me.hola.BackColor = System.Drawing.Color.OliveDrab
        Me.hola.Location = New System.Drawing.Point(163, 26)
        Me.hola.Name = "hola"
        Me.hola.Size = New System.Drawing.Size(118, 26)
        Me.hola.TabIndex = 0
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
        Me.label5.Location = New System.Drawing.Point(31, 102)
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
        Me.label4.Location = New System.Drawing.Point(29, 183)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(69, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "telefono"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "direccion"
        '
        'FrmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 435)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModificarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificar cliente - tallo"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents dtpCliente As DateTimePicker
    Private WithEvents label6 As Label
    Public WithEvents txtApellidoCliente As TextBox
    Public WithEvents txtTelefonoCliente As TextBox
    Public WithEvents txtDireccionCliente As TextBox
    Public WithEvents hola As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Public WithEvents txtDniCliente As TextBox
End Class
