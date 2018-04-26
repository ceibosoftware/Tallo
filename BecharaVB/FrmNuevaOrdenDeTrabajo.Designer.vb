<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevaOrdenDeTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.fechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.ltsClientes = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.precios = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtManoObra = New System.Windows.Forms.TextBox()
        Me.txtRepuestos = New System.Windows.Forms.TextBox()
        Me.chkRepuestos = New System.Windows.Forms.CheckBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tipotrabajo = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cmbTipotrabajo = New System.Windows.Forms.ComboBox()
        Me.TipotrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.btnElimTipo = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.AutosTableAdapter = New BecharaVB.becharaDataSetTableAdapters.autosTableAdapter()
        Me.TipotrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.tipotrabajoTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnEliminar.SuspendLayout()
        Me.precios.SuspendLayout()
        Me.tipotrabajo.SuspendLayout()
        CType(Me.TipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(422, 567)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 37)
        Me.button2.TabIndex = 17
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Location = New System.Drawing.Point(278, 567)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 37)
        Me.button3.TabIndex = 16
        Me.button3.Text = "Aceptar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Controls.Add(Me.Label11)
        Me.btnEliminar.Controls.Add(Me.fechaSalida)
        Me.btnEliminar.Controls.Add(Me.fechaEntrada)
        Me.btnEliminar.Controls.Add(Me.Label10)
        Me.btnEliminar.Controls.Add(Me.txtBuscar)
        Me.btnEliminar.Controls.Add(Me.txtObservaciones)
        Me.btnEliminar.Controls.Add(Me.ltsClientes)
        Me.btnEliminar.Controls.Add(Me.ComboBox1)
        Me.btnEliminar.Controls.Add(Me.precios)
        Me.btnEliminar.Controls.Add(Me.tipotrabajo)
        Me.btnEliminar.Controls.Add(Me.label5)
        Me.btnEliminar.Controls.Add(Me.label4)
        Me.btnEliminar.Controls.Add(Me.label1)
        Me.btnEliminar.Controls.Add(Me.label2)
        Me.btnEliminar.Location = New System.Drawing.Point(22, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(818, 600)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Nuevo Trabajo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha Salida"
        '
        'fechaSalida
        '
        Me.fechaSalida.Location = New System.Drawing.Point(115, 248)
        Me.fechaSalida.Name = "fechaSalida"
        Me.fechaSalida.Size = New System.Drawing.Size(200, 20)
        Me.fechaSalida.TabIndex = 29
        '
        'fechaEntrada
        '
        Me.fechaEntrada.Location = New System.Drawing.Point(115, 223)
        Me.fechaEntrada.Name = "fechaEntrada"
        Me.fechaEntrada.Size = New System.Drawing.Size(200, 20)
        Me.fechaEntrada.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(116, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(200, 20)
        Me.txtBuscar.TabIndex = 26
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(116, 287)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(201, 86)
        Me.txtObservaciones.TabIndex = 24
        Me.txtObservaciones.Text = ""
        '
        'ltsClientes
        '
        Me.ltsClientes.FormattingEnabled = True
        Me.ltsClientes.Location = New System.Drawing.Point(116, 67)
        Me.ltsClientes.Name = "ltsClientes"
        Me.ltsClientes.Size = New System.Drawing.Size(200, 95)
        Me.ltsClientes.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 177)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'precios
        '
        Me.precios.Controls.Add(Me.txtTotal)
        Me.precios.Controls.Add(Me.txtManoObra)
        Me.precios.Controls.Add(Me.txtRepuestos)
        Me.precios.Controls.Add(Me.chkRepuestos)
        Me.precios.Controls.Add(Me.label7)
        Me.precios.Controls.Add(Me.label8)
        Me.precios.Controls.Add(Me.label6)
        Me.precios.Location = New System.Drawing.Point(19, 379)
        Me.precios.Name = "precios"
        Me.precios.Size = New System.Drawing.Size(336, 138)
        Me.precios.TabIndex = 22
        Me.precios.TabStop = False
        Me.precios.Text = "Precios"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(158, 96)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(93, 20)
        Me.txtTotal.TabIndex = 22
        '
        'txtManoObra
        '
        Me.txtManoObra.Location = New System.Drawing.Point(158, 62)
        Me.txtManoObra.Name = "txtManoObra"
        Me.txtManoObra.ReadOnly = True
        Me.txtManoObra.Size = New System.Drawing.Size(93, 20)
        Me.txtManoObra.TabIndex = 21
        '
        'txtRepuestos
        '
        Me.txtRepuestos.Location = New System.Drawing.Point(157, 28)
        Me.txtRepuestos.Name = "txtRepuestos"
        Me.txtRepuestos.ReadOnly = True
        Me.txtRepuestos.Size = New System.Drawing.Size(94, 20)
        Me.txtRepuestos.TabIndex = 20
        '
        'chkRepuestos
        '
        Me.chkRepuestos.AutoSize = True
        Me.chkRepuestos.Location = New System.Drawing.Point(255, 30)
        Me.chkRepuestos.Name = "chkRepuestos"
        Me.chkRepuestos.Size = New System.Drawing.Size(66, 17)
        Me.chkRepuestos.TabIndex = 19
        Me.chkRepuestos.Text = "Bechara"
        Me.chkRepuestos.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(34, 70)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(117, 13)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Precio Mano de Obra $"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(34, 31)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(105, 13)
        Me.label8.TabIndex = 15
        Me.label8.Text = "Precio Respuestos $"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(34, 103)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(73, 13)
        Me.label6.TabIndex = 17
        Me.label6.Text = "Precio Total $"
        '
        'tipotrabajo
        '
        Me.tipotrabajo.Controls.Add(Me.txtPrecio)
        Me.tipotrabajo.Controls.Add(Me.cmbTipotrabajo)
        Me.tipotrabajo.Controls.Add(Me.btnElimTipo)
        Me.tipotrabajo.Controls.Add(Me.label9)
        Me.tipotrabajo.Controls.Add(Me.label3)
        Me.tipotrabajo.Controls.Add(Me.button1)
        Me.tipotrabajo.Location = New System.Drawing.Point(377, 20)
        Me.tipotrabajo.Name = "tipotrabajo"
        Me.tipotrabajo.Size = New System.Drawing.Size(416, 479)
        Me.tipotrabajo.TabIndex = 21
        Me.tipotrabajo.TabStop = False
        Me.tipotrabajo.Text = "Tipo de Trabajo"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(169, 45)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 24
        '
        'cmbTipotrabajo
        '
        Me.cmbTipotrabajo.DataSource = Me.TipotrabajoBindingSource
        Me.cmbTipotrabajo.DisplayMember = "nombre"
        Me.cmbTipotrabajo.FormattingEnabled = True
        Me.cmbTipotrabajo.Location = New System.Drawing.Point(26, 46)
        Me.cmbTipotrabajo.Name = "cmbTipotrabajo"
        Me.cmbTipotrabajo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipotrabajo.TabIndex = 23
        Me.cmbTipotrabajo.ValueMember = "idTipoTrabajo"
        '
        'TipotrabajoBindingSource
        '
        Me.TipotrabajoBindingSource.DataMember = "tipotrabajo"
        Me.TipotrabajoBindingSource.DataSource = Me.BecharaDataSetBindingSource
        '
        'BecharaDataSetBindingSource
        '
        Me.BecharaDataSetBindingSource.DataSource = Me.BecharaDataSet
        Me.BecharaDataSetBindingSource.Position = 0
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnElimTipo
        '
        Me.btnElimTipo.BackColor = System.Drawing.Color.LightCoral
        Me.btnElimTipo.Location = New System.Drawing.Point(349, 46)
        Me.btnElimTipo.Name = "btnElimTipo"
        Me.btnElimTipo.Size = New System.Drawing.Size(61, 23)
        Me.btnElimTipo.TabIndex = 21
        Me.btnElimTipo.Text = "Eliminar"
        Me.btnElimTipo.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(166, 29)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(46, 13)
        Me.label9.TabIndex = 20
        Me.label9.Text = "Precio $"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(23, 30)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Nombre"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(288, 46)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(54, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Agregar "
        Me.button1.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(32, 287)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(78, 13)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Observaciónes"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(33, 223)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Fecha"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(33, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Cliente"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(33, 177)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Auto"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BecharaDataSet
        '
        'AutosBindingSource
        '
        Me.AutosBindingSource.DataMember = "autos"
        Me.AutosBindingSource.DataSource = Me.BecharaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AutosTableAdapter
        '
        Me.AutosTableAdapter.ClearBeforeFill = True
        '
        'TipotrabajoTableAdapter
        '
        Me.TipotrabajoTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmNuevaOrdenDeTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 621)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Name = "FrmNuevaOrdenDeTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNuevaOrdenDeTrabajo"
        Me.btnEliminar.ResumeLayout(False)
        Me.btnEliminar.PerformLayout()
        Me.precios.ResumeLayout(False)
        Me.precios.PerformLayout()
        Me.tipotrabajo.ResumeLayout(False)
        Me.tipotrabajo.PerformLayout()
        CType(Me.TipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button3 As Button
    Private WithEvents btnEliminar As GroupBox
    Private WithEvents precios As GroupBox
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label6 As Label
    Private WithEvents tipotrabajo As GroupBox
    Private WithEvents label9 As Label
    Private WithEvents label3 As Label
    Private WithEvents button1 As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents AutosBindingSource As BindingSource
    Friend WithEvents AutosTableAdapter As becharaDataSetTableAdapters.autosTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ltsClientes As ListBox
    Friend WithEvents BecharaDataSetBindingSource As BindingSource
    Friend WithEvents TipotrabajoBindingSource As BindingSource
    Friend WithEvents TipotrabajoTableAdapter As becharaDataSetTableAdapters.tipotrabajoTableAdapter
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnElimTipo As Button
    Friend WithEvents cmbTipotrabajo As ComboBox
    Friend WithEvents txtObservaciones As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents chkRepuestos As CheckBox
    Friend WithEvents txtRepuestos As TextBox
    Friend WithEvents txtManoObra As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents fechaEntrada As DateTimePicker
    Private WithEvents Label11 As Label
    Friend WithEvents fechaSalida As DateTimePicker
    Friend WithEvents txtPrecio As TextBox
End Class
