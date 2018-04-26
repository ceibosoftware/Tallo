<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteTipoTrabajo
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ordentrabajo_has_tipotrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptTiposTrabajos = New BecharaVB.RptTiposTrabajos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ordentrabajo_has_tipotrabajoTableAdapter = New BecharaVB.RptTiposTrabajosTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.chkBechara2 = New System.Windows.Forms.CheckBox()
        Me.cmbreporte = New System.Windows.Forms.ComboBox()
        CType(Me.ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptTiposTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ordentrabajo_has_tipotrabajoBindingSource
        '
        Me.ordentrabajo_has_tipotrabajoBindingSource.DataMember = "ordentrabajo_has_tipotrabajo"
        Me.ordentrabajo_has_tipotrabajoBindingSource.DataSource = Me.RptTiposTrabajos
        '
        'RptTiposTrabajos
        '
        Me.RptTiposTrabajos.DataSetName = "RptTiposTrabajos"
        Me.RptTiposTrabajos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.ordentrabajo_has_tipotrabajoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BecharaVB.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(936, 602)
        Me.ReportViewer1.TabIndex = 0
        '
        'ordentrabajo_has_tipotrabajoTableAdapter
        '
        Me.ordentrabajo_has_tipotrabajoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(194, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ver Todos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Location = New System.Drawing.Point(517, 1)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha2.TabIndex = 10
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Location = New System.Drawing.Point(289, 2)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha1.TabIndex = 9
        '
        'chkBechara2
        '
        Me.chkBechara2.AutoSize = True
        Me.chkBechara2.Location = New System.Drawing.Point(289, 5)
        Me.chkBechara2.Name = "chkBechara2"
        Me.chkBechara2.Size = New System.Drawing.Size(66, 17)
        Me.chkBechara2.TabIndex = 8
        Me.chkBechara2.Text = "Bechara"
        Me.chkBechara2.UseVisualStyleBackColor = True
        Me.chkBechara2.Visible = False
        '
        'cmbreporte
        '
        Me.cmbreporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreporte.FormattingEnabled = True
        Me.cmbreporte.Items.AddRange(New Object() {"Fecha"})
        Me.cmbreporte.Location = New System.Drawing.Point(12, 0)
        Me.cmbreporte.Name = "cmbreporte"
        Me.cmbreporte.Size = New System.Drawing.Size(164, 21)
        Me.cmbreporte.TabIndex = 7
        '
        'FrmReporteTipoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpfecha2)
        Me.Controls.Add(Me.dtpfecha1)
        Me.Controls.Add(Me.chkBechara2)
        Me.Controls.Add(Me.cmbreporte)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmReporteTipoTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReporteTipoTrabajo"
        CType(Me.ordentrabajo_has_tipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptTiposTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Rpttrabajos As RptTrabajos
    Friend WithEvents ordentrabajo_has_tipotrabajoBindingSource As BindingSource
    Friend WithEvents RptTiposTrabajos As RptTiposTrabajos
    Friend WithEvents ordentrabajo_has_tipotrabajoTableAdapter As RptTiposTrabajosTableAdapters.ordentrabajo_has_tipotrabajoTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpfecha2 As DateTimePicker
    Friend WithEvents dtpfecha1 As DateTimePicker
    Friend WithEvents chkBechara2 As CheckBox
    Friend WithEvents cmbreporte As ComboBox
End Class
