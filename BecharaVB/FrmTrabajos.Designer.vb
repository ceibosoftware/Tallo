<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrabajos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrabajos))
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.OrdentrabajoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DgvOrdenesTipos = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OrdentrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.OrdentrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.ordentrabajoTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.BecharaDataSet1 = New BecharaVB.becharaDataSet()
        Me.Ordentrabajo_has_tipotrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ordentrabajo_has_tipotrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.OrdentrabajoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOrdenesTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(985, 574)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(74, 32)
        Me.button3.TabIndex = 3
        Me.button3.Text = "eliminar"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = Global.BecharaVB.My.Resources.Resources.editar
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(893, 574)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(86, 32)
        Me.button2.TabIndex = 2
        Me.button2.Text = "modificar"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.OliveDrab
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.BecharaVB.My.Resources.Resources.add
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(806, 574)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(81, 32)
        Me.button1.TabIndex = 1
        Me.button1.Text = "agregar "
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(637, 47)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(156, 20)
        Me.textBox1.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.txtObservacion)
        Me.groupBox1.Controls.Add(Me.OrdentrabajoDataGridView)
        Me.groupBox1.Controls.Add(Me.DgvOrdenesTipos)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(39, 106)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1144, 438)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "trabajos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "observaciones"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.OliveDrab
        Me.txtObservacion.Location = New System.Drawing.Point(716, 300)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.Size = New System.Drawing.Size(331, 114)
        Me.txtObservacion.TabIndex = 32
        Me.txtObservacion.Text = ""
        '
        'OrdentrabajoDataGridView
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        Me.OrdentrabajoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OrdentrabajoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdentrabajoDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.OrdentrabajoDataGridView.GridColor = System.Drawing.Color.OliveDrab
        Me.OrdentrabajoDataGridView.Location = New System.Drawing.Point(103, 42)
        Me.OrdentrabajoDataGridView.Name = "OrdentrabajoDataGridView"
        Me.OrdentrabajoDataGridView.ReadOnly = True
        Me.OrdentrabajoDataGridView.Size = New System.Drawing.Size(944, 241)
        Me.OrdentrabajoDataGridView.TabIndex = 0
        '
        'DgvOrdenesTipos
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        Me.DgvOrdenesTipos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvOrdenesTipos.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvOrdenesTipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvOrdenesTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OliveDrab
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvOrdenesTipos.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvOrdenesTipos.GridColor = System.Drawing.Color.OliveDrab
        Me.DgvOrdenesTipos.Location = New System.Drawing.Point(103, 303)
        Me.DgvOrdenesTipos.Name = "DgvOrdenesTipos"
        Me.DgvOrdenesTipos.ReadOnly = True
        Me.DgvOrdenesTipos.Size = New System.Drawing.Size(370, 114)
        Me.DgvOrdenesTipos.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Image = Global.BecharaVB.My.Resources.Resources.lupa1
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label1.Location = New System.Drawing.Point(448, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(182, 18)
        Me.label1.TabIndex = 31
        Me.label1.Text = "buscar por apellido       "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'BecharaDataSet1
        '
        Me.BecharaDataSet1.DataSetName = "becharaDataSet"
        Me.BecharaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ordentrabajo_has_tipotrabajoBindingSource
        '
        Me.Ordentrabajo_has_tipotrabajoBindingSource.DataMember = "ordentrabajo_has_tipotrabajo"
        Me.Ordentrabajo_has_tipotrabajoBindingSource.DataSource = Me.BecharaDataSet
        '
        'Ordentrabajo_has_tipotrabajoTableAdapter
        '
        Me.Ordentrabajo_has_tipotrabajoTableAdapter.ClearBeforeFill = True
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
        'FrmTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 636)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "trabajos - tallo"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.OrdentrabajoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOrdenesTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label1 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents OrdentrabajoBindingSource As BindingSource
    Friend WithEvents OrdentrabajoTableAdapter As becharaDataSetTableAdapters.ordentrabajoTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DgvOrdenesTipos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents BecharaDataSet1 As becharaDataSet
    Friend WithEvents Ordentrabajo_has_tipotrabajoBindingSource As BindingSource
    Friend WithEvents Ordentrabajo_has_tipotrabajoTableAdapter As becharaDataSetTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter
    Friend WithEvents OrdentrabajoDataGridView As DataGridView
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
    Private WithEvents Label3 As Label
    Friend WithEvents txtObservacion As RichTextBox
End Class
