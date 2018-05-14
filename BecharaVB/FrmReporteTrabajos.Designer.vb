<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteTrabajos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteTrabajos))
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptClienteTrabajo = New BecharaVB.RptClienteTrabajo()
        Me.repor = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.clientesTableAdapter = New BecharaVB.RptClienteTrabajoTableAdapters.clientesTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmbreporte = New System.Windows.Forms.ComboBox()
        Me.chkBechara2 = New System.Windows.Forms.CheckBox()
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptClienteTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.RptClienteTrabajo
        '
        'RptClienteTrabajo
        '
        Me.RptClienteTrabajo.DataSetName = "RptClienteTrabajo"
        Me.RptClienteTrabajo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'repor
        '
        Me.repor.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.clientesBindingSource
        Me.repor.LocalReport.DataSources.Add(ReportDataSource1)
        Me.repor.LocalReport.ReportEmbeddedResource = "BecharaVB.Report3.rdlc"
        Me.repor.Location = New System.Drawing.Point(0, 24)
        Me.repor.Name = "repor"
        Me.repor.Size = New System.Drawing.Size(944, 631)
        Me.repor.TabIndex = 0
        '
        'clientesTableAdapter
        '
        Me.clientesTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmbreporte
        '
        Me.cmbreporte.BackColor = System.Drawing.Color.OliveDrab
        Me.cmbreporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbreporte.ForeColor = System.Drawing.Color.OliveDrab
        Me.cmbreporte.FormattingEnabled = True
        Me.cmbreporte.Items.AddRange(New Object() {"Fecha", "Repuestos Bechara"})
        Me.cmbreporte.Location = New System.Drawing.Point(12, 2)
        Me.cmbreporte.Name = "cmbreporte"
        Me.cmbreporte.Size = New System.Drawing.Size(164, 21)
        Me.cmbreporte.TabIndex = 2
        '
        'chkBechara2
        '
        Me.chkBechara2.AutoSize = True
        Me.chkBechara2.Location = New System.Drawing.Point(297, 4)
        Me.chkBechara2.Name = "chkBechara2"
        Me.chkBechara2.Size = New System.Drawing.Size(66, 17)
        Me.chkBechara2.TabIndex = 3
        Me.chkBechara2.Text = "Bechara"
        Me.chkBechara2.UseVisualStyleBackColor = True
        Me.chkBechara2.Visible = False
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Location = New System.Drawing.Point(297, 1)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha1.TabIndex = 4
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Location = New System.Drawing.Point(519, 1)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(202, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ver todos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmReporteTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 655)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpfecha2)
        Me.Controls.Add(Me.dtpfecha1)
        Me.Controls.Add(Me.chkBechara2)
        Me.Controls.Add(Me.cmbreporte)
        Me.Controls.Add(Me.repor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReporteTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporte trabajos - tallo"
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptClienteTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rpttrabajos As RptTrabajos
    Friend WithEvents clientesBindingSource As BindingSource
    Friend WithEvents RptClienteTrabajo As RptClienteTrabajo
    Friend WithEvents clientesTableAdapter As RptClienteTrabajoTableAdapters.clientesTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmbreporte As ComboBox
    Friend WithEvents chkBechara2 As CheckBox
    Friend WithEvents dtpfecha1 As DateTimePicker
    Friend WithEvents dtpfecha2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Private WithEvents repor As Microsoft.Reporting.WinForms.ReportViewer
End Class
