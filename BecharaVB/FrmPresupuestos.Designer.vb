<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPresupuestos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresupuestos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.PresupuestoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.presupuestoTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BecharaDataSet1 = New BecharaVB.becharaDataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BecharaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.PresupuestoDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1104, 442)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "presupuestos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "trabajo a realizar:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.OliveDrab
        Me.txtObservacion.ForeColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(187, 302)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.Size = New System.Drawing.Size(331, 114)
        Me.txtObservacion.TabIndex = 33
        Me.txtObservacion.Text = ""
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        Me.PresupuestoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PresupuestoDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PresupuestoDataGridView.GridColor = System.Drawing.Color.OliveDrab
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(48, 43)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.ReadOnly = True
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(1018, 253)
        Me.PresupuestoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn6.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "patente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "patente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "kilometraje"
        Me.DataGridViewTextBoxColumn8.HeaderText = "kilometraje"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "combustible"
        Me.DataGridViewTextBoxColumn9.HeaderText = "combustible"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "precioRespuesto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "precio de respuestos $"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "precioManoObra"
        Me.DataGridViewTextBoxColumn13.HeaderText = "precio mano de obra $"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "precioTotal"
        Me.DataGridViewTextBoxColumn12.HeaderText = "precio total $"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn10.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechaCaducidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fecha de caducidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.BecharaDataSet
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(809, 518)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(76, 32)
        Me.button3.TabIndex = 2
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
        Me.button2.Location = New System.Drawing.Point(719, 518)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(82, 32)
        Me.button2.TabIndex = 1
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
        Me.button1.Location = New System.Drawing.Point(632, 518)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 32)
        Me.button1.TabIndex = 0
        Me.button1.Text = "agregar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajo_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuesto_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BecharaVB.becharaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.BecharaVB.My.Resources.Resources.download
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(935, 518)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "descargar presupuesto"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BecharaDataSet1
        '
        Me.BecharaDataSet1.DataSetName = "becharaDataSet"
        Me.BecharaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1181, 585)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPresupuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "presupuestos - tallo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BecharaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As becharaDataSetTableAdapters.presupuestoTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDataGridView As DataGridView
    Private WithEvents Button4 As Button
    Friend WithEvents BecharaDataSet1 As becharaDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObservacion As RichTextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
