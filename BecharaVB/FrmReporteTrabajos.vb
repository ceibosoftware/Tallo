Public Class FrmReporteTrabajos
    Private Sub FrmReporteTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RptClienteTrabajo.clientes' table. You can move, or remove it, as needed.
        Me.clientesTableAdapter.Fill(Me.RptClienteTrabajo.clientes)


        Me.repor.RefreshReport()
        Me.repor.RefreshReport()
    End Sub


    Private Sub cmbreporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreporte.SelectedIndexChanged

        Try
            Dim filtro As String
            filtro = cmbreporte.SelectedItem.ToString



            If filtro = "Repuestos Bechara" Then
                chkBechara2.Visible = True
                dtpfecha1.Visible = False
                dtpfecha2.Visible = False


            Else filtro = "Fecha"
                chkBechara2.Visible = False
                dtpfecha1.Visible = True
                dtpfecha2.Visible = True

            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un filtro de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub chkBechara_CheckedChanged(sender As Object, e As EventArgs) Handles chkBechara2.CheckedChanged
        If chkBechara2.Checked = True Then
            Me.clientesTableAdapter.filtroPorBechara(Me.RptClienteTrabajo.clientes, True)
            Me.repor.RefreshReport()

        ElseIf chkBechara2.Checked = False Then
            Me.clientesTableAdapter.filtroPorBechara(Me.RptClienteTrabajo.clientes, False)
            Me.repor.RefreshReport()


        End If
    End Sub

    Private Sub dtpfecha1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha1.ValueChanged

        Me.clientesTableAdapter.filtroPorFecha(Me.RptClienteTrabajo.clientes, dtpfecha1.Value.ToString, dtpfecha2.Value.ToString)
        Me.repor.RefreshReport()

        dtpfecha2.Value = dtpfecha1.Value
    End Sub


    Private Sub dtpfecha2_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha2.ValueChanged

        Me.clientesTableAdapter.filtroPorFecha(Me.RptClienteTrabajo.clientes, dtpfecha1.Value.ToString, dtpfecha2.Value.ToString)
        Me.repor.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.clientesTableAdapter.Fill(Me.RptClienteTrabajo.clientes)
        Me.repor.RefreshReport()
        chkBechara2.Checked = False
        chkBechara2.Visible = False
        dtpfecha1.Visible = False
        dtpfecha2.Visible = False
        ' cmbreporte.SelectedIndex = -1

    End Sub
End Class


