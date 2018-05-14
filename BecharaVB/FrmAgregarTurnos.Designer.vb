<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarTurnos))
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtapellidoturno = New System.Windows.Forms.TextBox()
        Me.txttelefonoturno = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtnombreturno = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbhorarioturno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservacionturno = New System.Windows.Forms.RichTextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.dtpFechaTurno = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(44, 171)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(115, 18)
        Me.label9.TabIndex = 26
        Me.label9.Text = "observaciónes"
        '
        'txtapellidoturno
        '
        Me.txtapellidoturno.BackColor = System.Drawing.Color.OliveDrab
        Me.txtapellidoturno.Location = New System.Drawing.Point(197, 90)
        Me.txtapellidoturno.Name = "txtapellidoturno"
        Me.txtapellidoturno.Size = New System.Drawing.Size(122, 26)
        Me.txtapellidoturno.TabIndex = 1
        '
        'txttelefonoturno
        '
        Me.txttelefonoturno.BackColor = System.Drawing.Color.OliveDrab
        Me.txttelefonoturno.Location = New System.Drawing.Point(197, 129)
        Me.txttelefonoturno.Name = "txttelefonoturno"
        Me.txttelefonoturno.Size = New System.Drawing.Size(122, 26)
        Me.txttelefonoturno.TabIndex = 2
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(44, 130)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(69, 18)
        Me.label10.TabIndex = 25
        Me.label10.Text = "telefono"
        '
        'txtnombreturno
        '
        Me.txtnombreturno.BackColor = System.Drawing.Color.OliveDrab
        Me.txtnombreturno.Location = New System.Drawing.Point(197, 51)
        Me.txtnombreturno.Name = "txtnombreturno"
        Me.txtnombreturno.Size = New System.Drawing.Size(122, 26)
        Me.txtnombreturno.TabIndex = 0
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(44, 92)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(63, 18)
        Me.label7.TabIndex = 22
        Me.label7.Text = "apellido"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(44, 57)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(66, 18)
        Me.label8.TabIndex = 21
        Me.label8.Text = "nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbhorarioturno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaTurno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtObservacionturno)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.txtapellidoturno)
        Me.GroupBox1.Controls.Add(Me.txtnombreturno)
        Me.GroupBox1.Controls.Add(Me.txttelefonoturno)
        Me.GroupBox1.Controls.Add(Me.label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(52, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 464)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "nuevo turno"
        '
        'cmbhorarioturno
        '
        Me.cmbhorarioturno.BackColor = System.Drawing.Color.OliveDrab
        Me.cmbhorarioturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbhorarioturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbhorarioturno.ForeColor = System.Drawing.Color.OliveDrab
        Me.cmbhorarioturno.FormattingEnabled = True
        Me.cmbhorarioturno.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00"})
        Me.cmbhorarioturno.Location = New System.Drawing.Point(197, 366)
        Me.cmbhorarioturno.Name = "cmbhorarioturno"
        Me.cmbhorarioturno.Size = New System.Drawing.Size(121, 26)
        Me.cmbhorarioturno.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "horario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "fecha Turno"
        '
        'txtObservacionturno
        '
        Me.txtObservacionturno.BackColor = System.Drawing.Color.OliveDrab
        Me.txtObservacionturno.Location = New System.Drawing.Point(197, 171)
        Me.txtObservacionturno.Name = "txtObservacionturno"
        Me.txtObservacionturno.Size = New System.Drawing.Size(286, 114)
        Me.txtObservacionturno.TabIndex = 3
        Me.txtObservacionturno.Text = ""
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(549, 525)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(82, 35)
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
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.check
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(443, 525)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(82, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'dtpFechaTurno
        '
        Me.dtpFechaTurno.CalendarForeColor = System.Drawing.Color.OliveDrab
        Me.dtpFechaTurno.Location = New System.Drawing.Point(197, 314)
        Me.dtpFechaTurno.Name = "dtpFechaTurno"
        Me.dtpFechaTurno.Size = New System.Drawing.Size(286, 26)
        Me.dtpFechaTurno.TabIndex = 4
        '
        'FrmAgregarTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 594)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar turno - tallo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label9 As Label
    Public WithEvents txtapellidoturno As TextBox
    Public WithEvents txttelefonoturno As TextBox
    Private WithEvents label10 As Label
    Public WithEvents txtnombreturno As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtObservacionturno As RichTextBox
    Private WithEvents Label2 As Label
    Friend WithEvents cmbhorarioturno As ComboBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Public WithEvents dtpFechaTurno As DateTimePicker
End Class
