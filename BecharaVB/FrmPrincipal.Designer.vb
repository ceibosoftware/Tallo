<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.clientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.autosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trabajosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tiposDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ordenDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.turnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.presupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Trabajos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposTrabajos = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbFiltroCliente = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtBuscaCliente = New System.Windows.Forms.TextBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.AutosTableAdapter = New BecharaVB.becharaDataSetTableAdapters.autosTableAdapter()
        Me.AutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientesToolStripMenuItem, Me.autosToolStripMenuItem, Me.trabajosToolStripMenuItem, Me.turnosToolStripMenuItem, Me.presupuestosToolStripMenuItem, Me.reportesToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'clientesToolStripMenuItem
        '
        Me.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem"
        Me.clientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.clientesToolStripMenuItem.Text = "Clientes"
        '
        'autosToolStripMenuItem
        '
        Me.autosToolStripMenuItem.Name = "autosToolStripMenuItem"
        Me.autosToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.autosToolStripMenuItem.Text = "Autos"
        '
        'trabajosToolStripMenuItem
        '
        Me.trabajosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tiposDeTrabajoToolStripMenuItem, Me.ordenDeTrabajoToolStripMenuItem})
        Me.trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem"
        Me.trabajosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.trabajosToolStripMenuItem.Text = "Trabajos "
        '
        'tiposDeTrabajoToolStripMenuItem
        '
        Me.tiposDeTrabajoToolStripMenuItem.Name = "tiposDeTrabajoToolStripMenuItem"
        Me.tiposDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.tiposDeTrabajoToolStripMenuItem.Text = "Trabajos realizados"
        '
        'ordenDeTrabajoToolStripMenuItem
        '
        Me.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem"
        Me.ordenDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ordenDeTrabajoToolStripMenuItem.Text = "Tipos de trabajo"
        '
        'turnosToolStripMenuItem
        '
        Me.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem"
        Me.turnosToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.turnosToolStripMenuItem.Text = "Turnos"
        '
        'presupuestosToolStripMenuItem
        '
        Me.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem"
        Me.presupuestosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.presupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'reportesToolStripMenuItem
        '
        Me.reportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Trabajos, Me.TiposTrabajos})
        Me.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem"
        Me.reportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.reportesToolStripMenuItem.Text = "Reportes"
        '
        'Trabajos
        '
        Me.Trabajos.Name = "Trabajos"
        Me.Trabajos.Size = New System.Drawing.Size(152, 22)
        Me.Trabajos.Text = "Trabajos"
        '
        'TiposTrabajos
        '
        Me.TiposTrabajos.Name = "TiposTrabajos"
        Me.TiposTrabajos.Size = New System.Drawing.Size(152, 22)
        Me.TiposTrabajos.Text = "Tipos trabajos"
        '
        'cmbFiltroCliente
        '
        Me.cmbFiltroCliente.DisplayMember = "Nombre"
        Me.cmbFiltroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroCliente.FormattingEnabled = True
        Me.cmbFiltroCliente.Items.AddRange(New Object() {"Nombre", "Apellido", "Direccion"})
        Me.cmbFiltroCliente.Location = New System.Drawing.Point(494, 85)
        Me.cmbFiltroCliente.Name = "cmbFiltroCliente"
        Me.cmbFiltroCliente.Size = New System.Drawing.Size(161, 21)
        Me.cmbFiltroCliente.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(404, 85)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 20)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Filtrar por :"
        '
        'txtBuscaCliente
        '
        Me.txtBuscaCliente.Location = New System.Drawing.Point(216, 85)
        Me.txtBuscaCliente.Name = "txtBuscaCliente"
        Me.txtBuscaCliente.Size = New System.Drawing.Size(156, 20)
        Me.txtBuscaCliente.TabIndex = 0
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Image = Global.BecharaVB.My.Resources.Resources.icono_eliminar
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(633, 436)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(108, 32)
        Me.button3.TabIndex = 4
        Me.button3.Text = "Eliminar cliente"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.editar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(507, 436)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(107, 32)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Modificar cliente"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.add
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(383, 436)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 32)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Agregar cliente"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.clientesDataGridView)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 134)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(773, 287)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Clientes"
        '
        'clientesDataGridView
        '
        Me.clientesDataGridView.AllowUserToAddRows = False
        Me.clientesDataGridView.AllowUserToDeleteRows = False
        Me.clientesDataGridView.AutoGenerateColumns = False
        Me.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn})
        Me.clientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.clientesDataGridView.Location = New System.Drawing.Point(32, 33)
        Me.clientesDataGridView.Name = "clientesDataGridView"
        Me.clientesDataGridView.ReadOnly = True
        Me.clientesDataGridView.Size = New System.Drawing.Size(714, 231)
        Me.clientesDataGridView.TabIndex = 0
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DireccionDataGridViewTextBoxColumn.Width = 170
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
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
        'AutosTableAdapter
        '
        Me.AutosTableAdapter.ClearBeforeFill = True
        '
        'AutosBindingSource
        '
        Me.AutosBindingSource.DataMember = "autos"
        Me.AutosBindingSource.DataSource = Me.BecharaDataSet
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Image = Global.BecharaVB.My.Resources.Resources.lupa
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label1.Location = New System.Drawing.Point(127, 84)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 18)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Buscar       "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 496)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmbFiltroCliente)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtBuscaCliente)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TALLER BECHARA"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents clientesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents autosToolStripMenuItem As ToolStripMenuItem
    Private WithEvents trabajosToolStripMenuItem As ToolStripMenuItem
    Private WithEvents tiposDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ordenDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents turnosToolStripMenuItem As ToolStripMenuItem
    Private WithEvents presupuestosToolStripMenuItem As ToolStripMenuItem
    Private WithEvents reportesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cmbFiltroCliente As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents txtBuscaCliente As TextBox
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents clientesDataGridView As DataGridView
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutosTableAdapter As becharaDataSetTableAdapters.autosTableAdapter
    Friend WithEvents AutosBindingSource As BindingSource
    Private WithEvents label1 As Label
    Friend WithEvents Trabajos As ToolStripMenuItem
    Friend WithEvents TiposTrabajos As ToolStripMenuItem
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
