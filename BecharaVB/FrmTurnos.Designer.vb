<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TURNOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TURNOS))
        Me.mtturno = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.TurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnosTableAdapter = New BecharaVB.becharaDataSetTableAdapters.turnosTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvTurnos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservacionturnos = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtturno
        '
        Me.mtturno.BackColor = System.Drawing.Color.OliveDrab
        Me.mtturno.Location = New System.Drawing.Point(50, 319)
        Me.mtturno.Name = "mtturno"
        Me.mtturno.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "fecha "
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurnosBindingSource
        '
        Me.TurnosBindingSource.DataMember = "turnos"
        Me.TurnosBindingSource.DataSource = Me.BecharaDataSet
        '
        'TurnosTableAdapter
        '
        Me.TurnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajo_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuesto_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Me.TurnosTableAdapter
        Me.TableAdapterManager.UpdateOrder = BecharaVB.becharaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Image = Global.BecharaVB.My.Resources.Resources.eliminar
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(765, 602)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 32)
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
        Me.button2.Location = New System.Drawing.Point(673, 602)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(86, 32)
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
        Me.button1.Location = New System.Drawing.Point(586, 602)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(81, 32)
        Me.button1.TabIndex = 0
        Me.button1.Text = "agregar"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DgvTurnos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtObservacionturnos)
        Me.GroupBox1.Controls.Add(Me.mtturno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(82, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 518)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "turnos"
        '
        'DgvTurnos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        Me.DgvTurnos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTurnos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTurnos.GridColor = System.Drawing.Color.OliveDrab
        Me.DgvTurnos.Location = New System.Drawing.Point(50, 47)
        Me.DgvTurnos.Name = "DgvTurnos"
        Me.DgvTurnos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTurnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.YellowGreen
        Me.DgvTurnos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvTurnos.Size = New System.Drawing.Size(570, 242)
        Me.DgvTurnos.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "trabajo a realizar"
        '
        'txtObservacionturnos
        '
        Me.txtObservacionturnos.BackColor = System.Drawing.Color.OliveDrab
        Me.txtObservacionturnos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurnosBindingSource, "observaciones", True))
        Me.txtObservacionturnos.Location = New System.Drawing.Point(326, 319)
        Me.txtObservacionturnos.Name = "txtObservacionturnos"
        Me.txtObservacionturnos.ReadOnly = True
        Me.txtObservacionturnos.Size = New System.Drawing.Size(321, 162)
        Me.txtObservacionturnos.TabIndex = 32
        Me.txtObservacionturnos.Text = ""
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.BecharaVB.My.Resources.Resources.lupa1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(454, 602)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 32)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "ver todos los turnos"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TURNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BecharaVB.My.Resources.Resources.simple_1440_1024x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 656)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TURNOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "turnos - tallo"
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents mtturno As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents TurnosBindingSource As BindingSource
    Friend WithEvents TurnosTableAdapter As becharaDataSetTableAdapters.turnosTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtObservacionturnos As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvTurnos As DataGridView
    Private WithEvents Button4 As Button
End Class
