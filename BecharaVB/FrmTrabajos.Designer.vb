<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrabajos
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
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvOrdenesTipos = New System.Windows.Forms.DataGridView()
        Me.OrdentrabajoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdentrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.Ordentrabajo_has_tipotrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdentrabajoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesClientesAutos = New BecharaVB.ordenesClientesAutos()
        Me.OrdentrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.ordentrabajoTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.AutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdentrabajoTableAdapter1 = New BecharaVB.ordenesClientesAutosTableAdapters.ordentrabajoTableAdapter()
        Me.TableAdapterManager1 = New BecharaVB.ordenesClientesAutosTableAdapters.TableAdapterManager()
        Me.Ordentrabajo_has_tipotrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.DgvOrdenesTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdentrabajoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdentrabajoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesClientesAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Location = New System.Drawing.Point(451, 352)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 32)
        Me.button3.TabIndex = 30
        Me.button3.Text = "Eliminar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(329, 352)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 32)
        Me.button2.TabIndex = 29
        Me.button2.Text = "Modificar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(213, 352)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 32)
        Me.button1.TabIndex = 28
        Me.button1.Text = "Agregar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Cliente", "Matricula", "Modelo"})
        Me.comboBox1.Location = New System.Drawing.Point(474, 12)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(161, 21)
        Me.comboBox1.TabIndex = 24
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(388, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 13)
        Me.label2.TabIndex = 27
        Me.label2.Text = "Filtrar por :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(70, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 26
        Me.label1.Text = "Buscar"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(155, 9)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(156, 20)
        Me.textBox1.TabIndex = 25
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.DgvOrdenesTipos)
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.OrdentrabajoDataGridView)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Location = New System.Drawing.Point(23, 54)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(789, 463)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Trabajos"
        '
        'DgvOrdenesTipos
        '
        Me.DgvOrdenesTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrdenesTipos.Location = New System.Drawing.Point(213, 188)
        Me.DgvOrdenesTipos.Name = "DgvOrdenesTipos"
        Me.DgvOrdenesTipos.Size = New System.Drawing.Size(367, 129)
        Me.DgvOrdenesTipos.TabIndex = 31
        '
        'OrdentrabajoDataGridView
        '
        Me.OrdentrabajoDataGridView.AllowUserToOrderColumns = True
        Me.OrdentrabajoDataGridView.AutoGenerateColumns = False
        Me.OrdentrabajoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdentrabajoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.OrdentrabajoDataGridView.DataSource = Me.OrdentrabajoBindingSource
        Me.OrdentrabajoDataGridView.Location = New System.Drawing.Point(24, 19)
        Me.OrdentrabajoDataGridView.Name = "OrdentrabajoDataGridView"
        Me.OrdentrabajoDataGridView.Size = New System.Drawing.Size(753, 139)
        Me.OrdentrabajoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idOrdenTrabajo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idOrdenTrabajo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn2.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaEntrada"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaEntrada"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaSalida"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaSalida"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precioTotal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "precioTotal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precioManoObra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "precioManoObra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "precioRespuesto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "precioRespuesto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "bechara"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "bechara"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "clientes_idCliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "clientes_idCliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "autos_idAuto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "autos_idAuto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'OrdentrabajoBindingSource
        '
        Me.OrdentrabajoBindingSource.DataMember = "ordentrabajo"
        Me.OrdentrabajoBindingSource.DataSource = Me.BecharaDataSet
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ordentrabajo_has_tipotrabajoBindingSource
        '
        Me.Ordentrabajo_has_tipotrabajoBindingSource.DataMember = "ordentrabajo_has_tipotrabajo"
        Me.Ordentrabajo_has_tipotrabajoBindingSource.DataSource = Me.BecharaDataSet
        '
        'OrdentrabajoBindingSource1
        '
        Me.OrdentrabajoBindingSource1.DataMember = "ordentrabajo"
        Me.OrdentrabajoBindingSource1.DataSource = Me.OrdenesClientesAutos
        '
        'OrdenesClientesAutos
        '
        Me.OrdenesClientesAutos.DataSetName = "ordenesClientesAutos"
        Me.OrdenesClientesAutos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdentrabajoTableAdapter
        '
        Me.OrdentrabajoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajo_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajoTableAdapter = Me.OrdentrabajoTableAdapter
        Me.TableAdapterManager.presupuesto_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BecharaVB.becharaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrdentrabajoTableAdapter1
        '
        Me.OrdentrabajoTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.autosTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.clientesTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = BecharaVB.ordenesClientesAutosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ordentrabajo_has_tipotrabajoTableAdapter
        '
        Me.Ordentrabajo_has_tipotrabajoTableAdapter.ClearBeforeFill = True
        '
        'FrmTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 517)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FrmTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTrabajos"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.DgvOrdenesTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdentrabajoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdentrabajoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesClientesAutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents OrdentrabajoBindingSource As BindingSource
    Friend WithEvents OrdentrabajoTableAdapter As becharaDataSetTableAdapters.ordentrabajoTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutosBindingSource As BindingSource
    Friend WithEvents OrdenesClientesAutos As ordenesClientesAutos
    Friend WithEvents OrdentrabajoBindingSource1 As BindingSource
    Friend WithEvents OrdentrabajoTableAdapter1 As ordenesClientesAutosTableAdapters.ordentrabajoTableAdapter
    Friend WithEvents TableAdapterManager1 As ordenesClientesAutosTableAdapters.TableAdapterManager
    Friend WithEvents OrdentrabajoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Ordentrabajo_has_tipotrabajoBindingSource As BindingSource
    Friend WithEvents Ordentrabajo_has_tipotrabajoTableAdapter As becharaDataSetTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter
    Friend WithEvents DgvOrdenesTipos As DataGridView
End Class
