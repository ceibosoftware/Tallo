<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarNuevoAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarNuevoAuto))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.listClientes = New System.Windows.Forms.ListBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.cmbTipoCombustible = New System.Windows.Forms.ComboBox()
        Me.txtCorrea = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.AutosTableAdapter = New BecharaVB.becharaDataSetTableAdapters.autosTableAdapter()
        Me.AutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(582, 561)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 31)
        Me.button2.TabIndex = 2
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
        Me.button1.Location = New System.Drawing.Point(492, 561)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 31)
        Me.button1.TabIndex = 1
        Me.button1.Text = "aceptar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.txtDni)
        Me.groupBox1.Controls.Add(Me.Label16)
        Me.groupBox1.Controls.Add(Me.Label15)
        Me.groupBox1.Controls.Add(Me.txtbuscar)
        Me.groupBox1.Controls.Add(Me.listClientes)
        Me.groupBox1.Controls.Add(Me.cmbTipoCombustible)
        Me.groupBox1.Controls.Add(Me.txtCorrea)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.label14)
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
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(37, 40)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(643, 492)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "agregar auto"
        '
        'txtDni
        '
        Me.txtDni.BackColor = System.Drawing.Color.OliveDrab
        Me.txtDni.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(150, 262)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(142, 26)
        Me.txtDni.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(80, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 18)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "dni"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Image = Global.BecharaVB.My.Resources.Resources.lupa1
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Location = New System.Drawing.Point(10, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 18)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "buscar cliente     "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.OliveDrab
        Me.txtbuscar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(150, 48)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(155, 26)
        Me.txtbuscar.TabIndex = 0
        '
        'listClientes
        '
        Me.listClientes.BackColor = System.Drawing.Color.OliveDrab
        Me.listClientes.DataSource = Me.ClientesBindingSource
        Me.listClientes.DisplayMember = "apellido"
        Me.listClientes.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClientes.ForeColor = System.Drawing.Color.Black
        Me.listClientes.FormattingEnabled = True
        Me.listClientes.ItemHeight = 18
        Me.listClientes.Location = New System.Drawing.Point(150, 90)
        Me.listClientes.Name = "listClientes"
        Me.listClientes.Size = New System.Drawing.Size(142, 166)
        Me.listClientes.TabIndex = 1
        Me.listClientes.ValueMember = "idCliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BecharaDataSet
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbTipoCombustible
        '
        Me.cmbTipoCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTipoCombustible.BackColor = System.Drawing.Color.OliveDrab
        Me.cmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoCombustible.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCombustible.FormattingEnabled = True
        Me.cmbTipoCombustible.Items.AddRange(New Object() {"Nafta", "Diesel", "GNC"})
        Me.cmbTipoCombustible.Location = New System.Drawing.Point(476, 311)
        Me.cmbTipoCombustible.Name = "cmbTipoCombustible"
        Me.cmbTipoCombustible.Size = New System.Drawing.Size(121, 26)
        Me.cmbTipoCombustible.TabIndex = 13
        '
        'txtCorrea
        '
        Me.txtCorrea.BackColor = System.Drawing.Color.OliveDrab
        Me.txtCorrea.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrea.Location = New System.Drawing.Point(476, 349)
        Me.txtCorrea.Name = "txtCorrea"
        Me.txtCorrea.Size = New System.Drawing.Size(122, 26)
        Me.txtCorrea.TabIndex = 14
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(323, 352)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(144, 18)
        Me.label13.TabIndex = 26
        Me.label13.Text = "correa distribución"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(323, 312)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(130, 18)
        Me.label14.TabIndex = 25
        Me.label14.Text = "tipo combustible"
        '
        'txtKilometraje
        '
        Me.txtKilometraje.BackColor = System.Drawing.Color.OliveDrab
        Me.txtKilometraje.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilometraje.Location = New System.Drawing.Point(476, 269)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(122, 26)
        Me.txtKilometraje.TabIndex = 12
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(323, 274)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(92, 18)
        Me.label11.TabIndex = 22
        Me.label11.Text = "kilometraje"
        '
        'txtAceiteMotor
        '
        Me.txtAceiteMotor.BackColor = System.Drawing.Color.OliveDrab
        Me.txtAceiteMotor.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAceiteMotor.Location = New System.Drawing.Point(476, 232)
        Me.txtAceiteMotor.Name = "txtAceiteMotor"
        Me.txtAceiteMotor.Size = New System.Drawing.Size(122, 26)
        Me.txtAceiteMotor.TabIndex = 11
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(323, 233)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(104, 18)
        Me.label12.TabIndex = 21
        Me.label12.Text = "aceite motor"
        '
        'txtFiltroHabitaculo
        '
        Me.txtFiltroHabitaculo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroHabitaculo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroHabitaculo.Location = New System.Drawing.Point(476, 191)
        Me.txtFiltroHabitaculo.Name = "txtFiltroHabitaculo"
        Me.txtFiltroHabitaculo.Size = New System.Drawing.Size(122, 26)
        Me.txtFiltroHabitaculo.TabIndex = 10
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(323, 196)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(121, 18)
        Me.label9.TabIndex = 18
        Me.label9.Text = "filtro habitaculo"
        '
        'txtFiltroCombustible
        '
        Me.txtFiltroCombustible.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroCombustible.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCombustible.Location = New System.Drawing.Point(476, 115)
        Me.txtFiltroCombustible.Name = "txtFiltroCombustible"
        Me.txtFiltroCombustible.Size = New System.Drawing.Size(122, 26)
        Me.txtFiltroCombustible.TabIndex = 8
        '
        'txtFiltroAire
        '
        Me.txtFiltroAire.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroAire.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAire.Location = New System.Drawing.Point(476, 154)
        Me.txtFiltroAire.Name = "txtFiltroAire"
        Me.txtFiltroAire.Size = New System.Drawing.Size(122, 26)
        Me.txtFiltroAire.TabIndex = 9
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(323, 155)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(73, 18)
        Me.label10.TabIndex = 17
        Me.label10.Text = "filtro aire"
        '
        'txtFiltroAceite
        '
        Me.txtFiltroAceite.BackColor = System.Drawing.Color.OliveDrab
        Me.txtFiltroAceite.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAceite.Location = New System.Drawing.Point(476, 76)
        Me.txtFiltroAceite.Name = "txtFiltroAceite"
        Me.txtFiltroAceite.Size = New System.Drawing.Size(122, 26)
        Me.txtFiltroAceite.TabIndex = 7
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.OliveDrab
        Me.txtColor.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(151, 456)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(141, 26)
        Me.txtColor.TabIndex = 6
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(80, 456)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(45, 18)
        Me.label6.TabIndex = 13
        Me.label6.Text = "color"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(323, 117)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(135, 18)
        Me.label7.TabIndex = 12
        Me.label7.Text = "filtro combustible"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(323, 82)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(90, 18)
        Me.label8.TabIndex = 11
        Me.label8.Text = "filtro aceite"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.OliveDrab
        Me.txtMarca.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(150, 296)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(142, 26)
        Me.txtMarca.TabIndex = 2
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.Color.OliveDrab
        Me.txtPatente.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatente.Location = New System.Drawing.Point(150, 416)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(142, 26)
        Me.txtPatente.TabIndex = 5
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.OliveDrab
        Me.txtAnio.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(151, 375)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(141, 26)
        Me.txtAnio.TabIndex = 4
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtModelo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(150, 335)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(142, 26)
        Me.txtModelo.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(80, 299)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "marca"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(80, 335)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 18)
        Me.label5.TabIndex = 4
        Me.label5.Text = "modelo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(80, 99)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 18)
        Me.label1.TabIndex = 0
        Me.label1.Text = "cliente"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(80, 419)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 18)
        Me.label4.TabIndex = 3
        Me.label4.Text = "patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(80, 375)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 18)
        Me.label3.TabIndex = 2
        Me.label3.Text = "año"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AutosTableAdapter
        '
        Me.AutosTableAdapter.ClearBeforeFill = True
        '
        'AutosBindingSource
        '
        Me.AutosBindingSource.DataMember = "autos"
        Me.AutosBindingSource.DataSource = Me.BecharaDataSet
        '
        'FrmAgregarNuevoAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 628)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarNuevoAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar auto - tallo"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label13 As Label
    Private WithEvents label14 As Label
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents label9 As Label
    Private WithEvents label10 As Label
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Public WithEvents txtMarca As TextBox
    Public WithEvents txtPatente As TextBox
    Public WithEvents txtAnio As TextBox
    Public WithEvents txtModelo As TextBox
    Public WithEvents txtCorrea As TextBox
    Public WithEvents txtColor As TextBox
    Public WithEvents txtKilometraje As TextBox
    Public WithEvents txtAceiteMotor As TextBox
    Public WithEvents txtFiltroHabitaculo As TextBox
    Public WithEvents txtFiltroCombustible As TextBox
    Public WithEvents txtFiltroAire As TextBox
    Public WithEvents txtFiltroAceite As TextBox
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents AutosTableAdapter As becharaDataSetTableAdapters.autosTableAdapter
    Friend WithEvents AutosBindingSource As BindingSource
    Friend WithEvents cmbTipoCombustible As ComboBox
    Friend WithEvents listClientes As ListBox
    Friend WithEvents txtbuscar As TextBox
    Private WithEvents Label15 As Label
    Public WithEvents txtDni As TextBox
    Private WithEvents Label16 As Label
End Class
