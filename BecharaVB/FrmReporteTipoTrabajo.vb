Public Class FrmReporteTipoTrabajo
    Private Sub FrmReporteTipoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Rpttrabajos.ordentrabajo_has_tipotrabajo' table. You can move, or remove it, as needed.
        Me.ordentrabajo_has_tipotrabajoTableAdapter.Fill(Me.RptTiposTrabajos.ordentrabajo_has_tipotrabajo)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmbreporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreporte.SelectedIndexChanged

        Try
            Dim filtro As String
            filtro = cmbreporte.SelectedItem.ToString






            If filtro = "Fecha" Then
                chkBechara2.Visible = False
                dtpfecha1.Visible = True
                dtpfecha2.Visible = True

            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un filtro de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub dtpfecha1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha1.ValueChanged

        Me.ordentrabajo_has_tipotrabajoTableAdapter.FillByFechas(Me.RptTiposTrabajos.ordentrabajo_has_tipotrabajo, dtpfecha1.Value.ToString, dtpfecha2.Value.ToString)
        Me.ReportViewer1.RefreshReport()

        dtpfecha2.Value = dtpfecha1.Value
    End Sub


    Private Sub dtpfecha2_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha2.ValueChanged

        Me.ordentrabajo_has_tipotrabajoTableAdapter.FillByFechas(Me.RptTiposTrabajos.ordentrabajo_has_tipotrabajo, dtpfecha1.Value.ToString, dtpfecha2.Value.ToString)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ordentrabajo_has_tipotrabajoTableAdapter.Fill(Me.RptTiposTrabajos.ordentrabajo_has_tipotrabajo)
        Me.ReportViewer1.RefreshReport()

        dtpfecha1.Visible = False
        dtpfecha2.Visible = False
        ' cmbreporte.SelectedIndex = -1

    End Sub
End Class