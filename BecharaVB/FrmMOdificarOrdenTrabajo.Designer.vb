<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMOdificarOrdenTrabajo
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
        Me.cmbAutos = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.ltsClientes = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.precios = New System.Windows.Forms.GroupBox()
        Me.chkRepuestos = New System.Windows.Forms.CheckBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtManoObra = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtRepuestos = New System.Windows.Forms.TextBox()
        Me.tipotrabajo = New System.Windows.Forms.GroupBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.btnElimtipo = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.fechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.chkTerminado = New System.Windows.Forms.CheckBox()
        Me.cmbAutos.SuspendLayout()
        Me.precios.SuspendLayout()
        Me.tipotrabajo.SuspendLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAutos
        '
        Me.cmbAutos.BackColor = System.Drawing.Color.Transparent
        Me.cmbAutos.Controls.Add(Me.txtObservaciones)
        Me.cmbAutos.Controls.Add(Me.Label11)
        Me.cmbAutos.Controls.Add(Me.fechaSalida)
        Me.cmbAutos.Controls.Add(Me.Label10)
        Me.cmbAutos.Controls.Add(Me.txtBuscar)
        Me.cmbAutos.Controls.Add(Me.ltsClientes)
        Me.cmbAutos.Controls.Add(Me.ComboBox1)
        Me.cmbAutos.Controls.Add(Me.precios)
        Me.cmbAutos.Controls.Add(Me.tipotrabajo)
        Me.cmbAutos.Controls.Add(Me.label5)
        Me.cmbAutos.Controls.Add(Me.label4)
        Me.cmbAutos.Controls.Add(Me.fechaEntrada)
        Me.cmbAutos.Controls.Add(Me.label1)
        Me.cmbAutos.Controls.Add(Me.label2)
        Me.cmbAutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAutos.Location = New System.Drawing.Point(12, 12)
        Me.cmbAutos.Name = "cmbAutos"
        Me.cmbAutos.Size = New System.Drawing.Size(922, 627)
        Me.cmbAutos.TabIndex = 16
        Me.cmbAutos.TabStop = False
        Me.cmbAutos.Text = "Nuevo Trabajo"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(130, 340)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(264, 114)
        Me.txtObservaciones.TabIndex = 32
        Me.txtObservaciones.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 316)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Fecha Salida"
        '
        'fechaSalida
        '
        Me.fechaSalida.Location = New System.Drawing.Point(133, 310)
        Me.fechaSalida.Name = "fechaSalida"
        Me.fechaSalida.Size = New System.Drawing.Size(200, 24)
        Me.fechaSalida.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = Global.BecharaVB.My.Resources.Resources.lupa
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(41, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Buscar       "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(133, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(200, 24)
        Me.txtBuscar.TabIndex = 26
        '
        'ltsClientes
        '
        Me.ltsClientes.FormattingEnabled = True
        Me.ltsClientes.ItemHeight = 18
        Me.ltsClientes.Location = New System.Drawing.Point(133, 58)
        Me.ltsClientes.Name = "ltsClientes"
        Me.ltsClientes.Size = New System.Drawing.Size(200, 184)
        Me.ltsClientes.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 26)
        Me.ComboBox1.TabIndex = 24
        '
        'precios
        '
        Me.precios.Controls.Add(Me.chkRepuestos)
        Me.precios.Controls.Add(Me.txtTotal)
        Me.precios.Controls.Add(Me.label7)
        Me.precios.Controls.Add(Me.txtManoObra)
        Me.precios.Controls.Add(Me.label8)
        Me.precios.Controls.Add(Me.label6)
        Me.precios.Controls.Add(Me.txtRepuestos)
        Me.precios.Location = New System.Drawing.Point(25, 460)
        Me.precios.Name = "precios"
        Me.precios.Size = New System.Drawing.Size(375, 142)
        Me.precios.TabIndex = 22
        Me.precios.TabStop = False
        Me.precios.Text = "Precios"
        '
        'chkRepuestos
        '
        Me.chkRepuestos.AutoSize = True
        Me.chkRepuestos.Location = New System.Drawing.Point(278, 32)
        Me.chkRepuestos.Name = "chkRepuestos"
        Me.chkRepuestos.Size = New System.Drawing.Size(82, 22)
        Me.chkRepuestos.TabIndex = 19
        Me.chkRepuestos.Text = "Bechara"
        Me.chkRepuestos.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(178, 109)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(94, 24)
        Me.txtTotal.TabIndex = 18
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 72)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(162, 18)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Precio Mano de Obra $"
        '
        'txtManoObra
        '
        Me.txtManoObra.Location = New System.Drawing.Point(178, 69)
        Me.txtManoObra.Name = "txtManoObra"
        Me.txtManoObra.ReadOnly = True
        Me.txtManoObra.Size = New System.Drawing.Size(94, 24)
        Me.txtManoObra.TabIndex = 14
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 30)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(147, 18)
        Me.label8.TabIndex = 15
        Me.label8.Text = "Precio Respuestos $"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 18)
        Me.label6.TabIndex = 17
        Me.label6.Text = "Precio Total $"
        '
        'txtRepuestos
        '
        Me.txtRepuestos.Location = New System.Drawing.Point(178, 30)
        Me.txtRepuestos.Name = "txtRepuestos"
        Me.txtRepuestos.ReadOnly = True
        Me.txtRepuestos.Size = New System.Drawing.Size(94, 24)
        Me.txtRepuestos.TabIndex = 16
        '
        'tipotrabajo
        '
        Me.tipotrabajo.Controls.Add(Me.chkTerminado)
        Me.tipotrabajo.Controls.Add(Me.button2)
        Me.tipotrabajo.Controls.Add(Me.btnElimtipo)
        Me.tipotrabajo.Controls.Add(Me.label9)
        Me.tipotrabajo.Controls.Add(Me.button3)
        Me.tipotrabajo.Controls.Add(Me.label3)
        Me.tipotrabajo.Controls.Add(Me.button1)
        Me.tipotrabajo.Location = New System.Drawing.Point(423, 35)
        Me.tipotrabajo.Name = "tipotrabajo"
        Me.tipotrabajo.Size = New System.Drawing.Size(473, 567)
        Me.tipotrabajo.TabIndex = 21
        Me.tipotrabajo.TabStop = False
        Me.tipotrabajo.Text = "Tipo de Trabajo"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.icono_eliminar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(378, 521)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(90, 37)
        Me.button2.TabIndex = 17
        Me.button2.Text = "Cancelar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'btnElimtipo
        '
        Me.btnElimtipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnElimtipo.Location = New System.Drawing.Point(379, 45)
        Me.btnElimtipo.Name = "btnElimtipo"
        Me.btnElimtipo.Size = New System.Drawing.Size(79, 26)
        Me.btnElimtipo.TabIndex = 21
        Me.btnElimtipo.Text = "Eliminar"
        Me.btnElimtipo.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(169, 22)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(63, 18)
        Me.label9.TabIndex = 20
        Me.label9.Text = "Precio $"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Image = Global.BecharaVB.My.Resources.Resources.tilde
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(289, 521)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(83, 37)
        Me.button3.TabIndex = 16
        Me.button3.Text = "Aceptar"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button3.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(26, 23)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(62, 18)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Nombre"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(293, 45)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(79, 26)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Agregar "
        Me.button1.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(19, 343)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(108, 18)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Observaciónes"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 280)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(102, 18)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Fecha entrada"
        '
        'fechaEntrada
        '
        Me.fechaEntrada.Location = New System.Drawing.Point(133, 280)
        Me.fechaEntrada.Name = "fechaEntrada"
        Me.fechaEntrada.Size = New System.Drawing.Size(200, 24)
        Me.fechaEntrada.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 58)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 18)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Clientes con auto"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(86, 251)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Auto"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ordentrabajo_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuesto_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BecharaVB.becharaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'chkTerminado
        '
        Me.chkTerminado.AutoSize = True
        Me.chkTerminado.Location = New System.Drawing.Point(146, 529)
        Me.chkTerminado.Name = "chkTerminado"
        Me.chkTerminado.Size = New System.Drawing.Size(98, 22)
        Me.chkTerminado.TabIndex = 23
        Me.chkTerminado.Text = "Terminado"
        Me.chkTerminado.UseVisualStyleBackColor = True
        '
        'FrmMOdificarOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(960, 655)
        Me.Controls.Add(Me.cmbAutos)
        Me.DoubleBuffered = True
        Me.Name = "FrmMOdificarOrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMOdificarOrdenTrabajo"
        Me.cmbAutos.ResumeLayout(False)
        Me.cmbAutos.PerformLayout()
        Me.precios.ResumeLayout(False)
        Me.precios.PerformLayout()
        Me.tipotrabajo.ResumeLayout(False)
        Me.tipotrabajo.PerformLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents cmbAutos As GroupBox
    Friend WithEvents txtObservaciones As RichTextBox
    Private WithEvents Label11 As Label
    Public WithEvents fechaSalida As DateTimePicker
    Private WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents ltsClientes As ListBox
    Private WithEvents precios As GroupBox
    Public WithEvents txtTotal As TextBox
    Private WithEvents label7 As Label
    Public WithEvents txtManoObra As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label6 As Label
    Public WithEvents txtRepuestos As TextBox
    Private WithEvents tipotrabajo As GroupBox
    Private WithEvents button2 As Button
    Private WithEvents btnElimtipo As Button
    Private WithEvents button3 As Button
    Private WithEvents label9 As Label
    Private WithEvents label3 As Label
    Private WithEvents button1 As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Public WithEvents fechaEntrada As DateTimePicker
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Public WithEvents ComboBox1 As ComboBox
    Friend WithEvents chkRepuestos As CheckBox
    Friend WithEvents chkTerminado As CheckBox
End Class
