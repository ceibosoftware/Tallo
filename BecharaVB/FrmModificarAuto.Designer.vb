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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCombustible = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorrea = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
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
        Me.groupBox1.SuspendLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.icono_eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(549, 397)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 31)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.tilde
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(444, 397)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 31)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.cmbTipoCombustible)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtCorrea)
        Me.groupBox1.Controls.Add(Me.label13)
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
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(33, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(627, 354)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos Del Auto a Modificar"
        '
        'cmbTipoCombustible
        '
        Me.cmbTipoCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCombustible.FormattingEnabled = True
        Me.cmbTipoCombustible.Items.AddRange(New Object() {"Nafta", "Diesel", "GNC"})
        Me.cmbTipoCombustible.Location = New System.Drawing.Point(451, 280)
        Me.cmbTipoCombustible.Name = "cmbTipoCombustible"
        Me.cmbTipoCombustible.Size = New System.Drawing.Size(121, 26)
        Me.cmbTipoCombustible.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tipo Combustible"
        '
        'txtCorrea
        '
        Me.txtCorrea.Location = New System.Drawing.Point(165, 250)
        Me.txtCorrea.Name = "txtCorrea"
        Me.txtCorrea.Size = New System.Drawing.Size(118, 24)
        Me.txtCorrea.TabIndex = 5
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(28, 249)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(136, 18)
        Me.label13.TabIndex = 26
        Me.label13.Text = "Correa Distribución"
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(451, 237)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(118, 24)
        Me.txtKilometraje.TabIndex = 12
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(317, 243)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(82, 18)
        Me.label11.TabIndex = 22
        Me.label11.Text = "Kilometraje"
        '
        'txtAceiteMotor
        '
        Me.txtAceiteMotor.Location = New System.Drawing.Point(451, 200)
        Me.txtAceiteMotor.Name = "txtAceiteMotor"
        Me.txtAceiteMotor.Size = New System.Drawing.Size(118, 24)
        Me.txtAceiteMotor.TabIndex = 11
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(317, 202)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(92, 18)
        Me.label12.TabIndex = 21
        Me.label12.Text = "Aceite Motor"
        '
        'txtFiltroHabitaculo
        '
        Me.txtFiltroHabitaculo.Location = New System.Drawing.Point(451, 159)
        Me.txtFiltroHabitaculo.Name = "txtFiltroHabitaculo"
        Me.txtFiltroHabitaculo.Size = New System.Drawing.Size(118, 24)
        Me.txtFiltroHabitaculo.TabIndex = 10
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(317, 165)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(115, 18)
        Me.label9.TabIndex = 18
        Me.label9.Text = "Filtro Habitaculo"
        '
        'txtFiltroCombustible
        '
        Me.txtFiltroCombustible.Location = New System.Drawing.Point(451, 83)
        Me.txtFiltroCombustible.Name = "txtFiltroCombustible"
        Me.txtFiltroCombustible.Size = New System.Drawing.Size(118, 24)
        Me.txtFiltroCombustible.TabIndex = 8
        '
        'txtFiltroAire
        '
        Me.txtFiltroAire.Location = New System.Drawing.Point(451, 122)
        Me.txtFiltroAire.Name = "txtFiltroAire"
        Me.txtFiltroAire.Size = New System.Drawing.Size(118, 24)
        Me.txtFiltroAire.TabIndex = 9
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(317, 124)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(70, 18)
        Me.label10.TabIndex = 17
        Me.label10.Text = "Filtro Aire"
        '
        'txtFiltroAceite
        '
        Me.txtFiltroAceite.Location = New System.Drawing.Point(451, 44)
        Me.txtFiltroAceite.Name = "txtFiltroAceite"
        Me.txtFiltroAceite.Size = New System.Drawing.Size(118, 24)
        Me.txtFiltroAceite.TabIndex = 7
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(165, 208)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(118, 24)
        Me.txtColor.TabIndex = 4
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(30, 210)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 18)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Color"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(317, 86)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(128, 18)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Filtro Combustible"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(317, 51)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(85, 18)
        Me.label8.TabIndex = 11
        Me.label8.Text = "Filtro Aceite"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(165, 48)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(118, 24)
        Me.txtMarca.TabIndex = 0
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(165, 168)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(118, 24)
        Me.txtPatente.TabIndex = 3
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(165, 127)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(118, 24)
        Me.txtAnio.TabIndex = 2
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(165, 87)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(118, 24)
        Me.txtModelo.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Marca"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(30, 89)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(58, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Modelo"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 170)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(30, 129)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Año"
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
        Me.Name = "FrmModificarAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICAR AUTO"
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
    Private WithEvents label13 As Label
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
End Class
