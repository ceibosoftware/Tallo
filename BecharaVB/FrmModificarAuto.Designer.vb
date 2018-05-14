<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarAuto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarAuto))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCombustible = New System.Windows.Forms.ComboBox()
        Me.txtCorrea = New System.Windows.Forms.TextBox()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtAceiteMotor = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtFiltroHabitaculo = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtFiltroCombustible = New System.Windows.Forms.TextBox()
        Me.txtFiltroAire = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtFiltroAceite = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(541, 397)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(83, 31)
        Me.button2.TabIndex = 1
        Me.button2.Text = "cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.OliveDrab
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.check
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(444, 397)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 31)
        Me.button1.TabIndex = 0
        Me.button1.Text = "aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Controls.Add(Me.cmbTipoCombustible)
        Me.groupBox1.Controls.Add(Me.txtCorrea)
        Me.groupBox1.Controls.Add(Me.txtKilometraje)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.txtAceiteMotor)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.txtFiltroHabitaculo)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtFiltroCombustible)
        Me.groupBox1.Controls.Add(Me.txtFiltroAire)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.txtFiltroAceite)
        Me.groupBox1.Controls.Add(Me.txtColor)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.txtMarca)
        Me.groupBox1.Controls.Add(Me.txtPatente)
        Me.groupBox1.Controls.Add(Me.txtAnio)
        Me.groupBox1.Controls.Add(Me.txtModelo)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(33, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(627, 354)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "modificar auto"
        '
        'cmbTipoCombustible
        '
        Me.cmbTipoCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTipoCombustible.BackColor = System.Drawing.Color.OliveDrab
        Me.cmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoCombustible.FormattingEnabled = True
        Me.cmbTipoCombustible.Items.AddRange(New Object() {"Nafta", "Diesel", "GNC"})
        Me.cmbTipoCombustible.Location = New System.Drawing.Point(451, 280)
        Me.cmbTipoCombustible.Name = "cmbTipoCombustible"
        Me.cmbTipoCombustible.Size = New System.Drawing.Size(121, 26)
        Me.cmbTipoCombustible.TabIndex = 27
        '
        'txtCorrea
        '
        Me.txtCorrea.BackColor = System.Drawing.Color.OliveDrab
        Me.txtCorrea.ForeColor = System.Drawing.Color.Transparent
        Me.txtCorrea.Location = New System.Drawing.Point(165, 250)
        Me.txtCorrea.Name = "txtCorrea"
        Me.txtCorrea.Size = New System.Drawing.Size(118, 26)
        Me.txtCorrea.TabIndex = 5
        '
        'txtKilometraje
        '
        Me.txtKilometraje.BackColor = System.Drawing.Color.OliveDrab
        Me.txtKilometraje.ForeColor = System.Drawing.Color.Transparent
        Me.txtKilometraje.Location = New System.Drawing.Point(451, 237)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(118, 26)
        Me.txtKilometraje.TabIndex = 12
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(317, 243)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(92, 18)
        Me.label11.TabIndex = 22
        Me.label11.Text = "kilometraje"
        '
        'txtAceiteMotor
        '
        Me.txtAceiteMotor.BackColor = System.Drawing.Color.OliveDrab
        Me.txtAceiteMotor.ForeColor = System.Drawing.Color.Transparent
        Me.txtAceiteMotor.Location = New System.Drawing.Point(451, 200)
        Me.txtAceiteMotor.Name = "txtAceiteMotor"
        Me.txtAceiteMotor.Size = New System.Drawing.Size(118, 26)
        Me.txtAceiteMotor.TabIndex = 11
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(317, 202)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(104, 18)
        Me.label12.TabIndex = 21
        Me.label12.Text = "aceite motor"
        '
        'txtFiltroHabitaculo
        '
        Me.txtFiltroHabitaculo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroHabitaculo.ForeColor = System.Drawing.Color.Transparent
        Me.txtFiltroHabitaculo.Location = New System.Drawing.Point(451, 159)
        Me.txtFiltroHabitaculo.Name = "txtFiltroHabitaculo"
        Me.txtFiltroHabitaculo.Size = New System.Drawing.Size(118, 26)
        Me.txtFiltroHabitaculo.TabIndex = 10
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(317, 165)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(121, 18)
        Me.label9.TabIndex = 18
        Me.label9.Text = "filtro habitaculo"
        '
        'txtFiltroCombustible
        '
        Me.txtFiltroCombustible.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroCombustible.ForeColor = System.Drawing.Color.Transparent
        Me.txtFiltroCombustible.Location = New System.Drawing.Point(451, 83)
        Me.txtFiltroCombustible.Name = "txtFiltroCombustible"
        Me.txtFiltroCombustible.Size = New System.Drawing.Size(118, 26)
        Me.txtFiltroCombustible.TabIndex = 8
        '
        'txtFiltroAire
        '
        Me.txtFiltroAire.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroAire.ForeColor = System.Drawing.Color.Transparent
        Me.txtFiltroAire.Location = New System.Drawing.Point(451, 122)
        Me.txtFiltroAire.Name = "txtFiltroAire"
        Me.txtFiltroAire.Size = New System.Drawing.Size(118, 26)
        Me.txtFiltroAire.TabIndex = 9
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(317, 124)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(73, 18)
        Me.label10.TabIndex = 17
        Me.label10.Text = "filtro aire"
        '
        'txtFiltroAceite
        '
        Me.txtFiltroAceite.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroAceite.ForeColor = System.Drawing.Color.Transparent
        Me.txtFiltroAceite.Location = New System.Drawing.Point(451, 44)
        Me.txtFiltroAceite.Name = "txtFiltroAceite"
        Me.txtFiltroAceite.Size = New System.Drawing.Size(118, 26)
        Me.txtFiltroAceite.TabIndex = 7
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.OliveDrab
        Me.txtColor.ForeColor = System.Drawing.Color.Transparent
        Me.txtColor.Location = New System.Drawing.Point(165, 208)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(118, 26)
        Me.txtColor.TabIndex = 4
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(30, 210)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 18)
        Me.label6.TabIndex = 13
        Me.label6.Text = "color"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(317, 86)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(135, 18)
        Me.label7.TabIndex = 12
        Me.label7.Text = "filtro combustible"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(317, 51)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(90, 18)
        Me.label8.TabIndex = 11
        Me.label8.Text = "filtro aceite"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.OliveDrab
        Me.txtMarca.ForeColor = System.Drawing.Color.Transparent
        Me.txtMarca.Location = New System.Drawing.Point(165, 48)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(118, 26)
        Me.txtMarca.TabIndex = 0
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPatente.ForeColor = System.Drawing.Color.Transparent
        Me.txtPatente.Location = New System.Drawing.Point(165, 168)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(118, 26)
        Me.txtPatente.TabIndex = 3
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.OliveDrab
        Me.txtAnio.ForeColor = System.Drawing.Color.Transparent
        Me.txtAnio.Location = New System.Drawing.Point(165, 127)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(118, 26)
        Me.txtAnio.TabIndex = 2
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtModelo.ForeColor = System.Drawing.Color.Transparent
        Me.txtModelo.Location = New System.Drawing.Point(165, 87)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(118, 26)
        Me.txtModelo.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "marca"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(30, 89)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "modelo"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 170)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(30, 129)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "año"
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BecharaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 36)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "correa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "distribucion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 36)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "tipo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combustible"
        '
        'FrmModificarAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(697, 459)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModificarAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificar auto - tallo"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents txtCorrea As TextBox
    Public WithEvents txtKilometraje As TextBox
    Private WithEvents label11 As Label
    Public WithEvents txtAceiteMotor As TextBox
    Private WithEvents label12 As Label
    Public WithEvents txtFiltroHabitaculo As TextBox
    Private WithEvents label9 As Label
    Public WithEvents txtFiltroCombustible As TextBox
    Public WithEvents txtFiltroAire As TextBox
    Private WithEvents label10 As Label
    Public WithEvents txtFiltroAceite As TextBox
    Public WithEvents txtColor As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Public WithEvents txtMarca As TextBox
    Public WithEvents txtPatente As TextBox
    Public WithEvents txtAnio As TextBox
    Public WithEvents txtModelo As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents cmbTipoCombustible As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents Label13 As Label
End Class
