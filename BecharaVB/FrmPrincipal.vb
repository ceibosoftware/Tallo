Imports MySql.Data.MySqlClient


Public Class principal
    Public conexion As New MySqlConnection

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection("data source =localhost;user id=root; password='';database ='bechara'")
        cmbFiltroCliente.Select()
        cmbFiltroCliente.SelectedIndex = 1
    End Sub



    Public Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarCliente.ShowDialog()) Then
            Dim nuevocliente As DataRowView

            'AGREGA CLIENTE
            nuevocliente = ClientesBindingSource.AddNew()
            nuevocliente("nombre") = FrmAgregarCliente.txtNombre.Text
            nuevocliente("apellido") = FrmAgregarCliente.txtApellidoCliente.Text
            nuevocliente("direccion") = FrmAgregarCliente.txtDireccionCliente.Text
            nuevocliente("telefono") = FrmAgregarCliente.txtTelefonoCliente.Text
            nuevocliente("fechaNacimiento") = FrmAgregarCliente.dtpCliente.Value
            nuevocliente("dni") = FrmAgregarCliente.txtDniCliente.Text

            nuevocliente.EndEdit()
            ClientesTableAdapter.Update(BecharaDataSet)
            ClientesTableAdapter.Fill(BecharaDataSet.clientes)

        End If
        FrmAgregarCliente.Dispose()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)
        Me.AutosTableAdapter.Fill(Me.BecharaDataSet.autos)

        cmbFiltroCliente.SelectedIndex = 1
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click


        Try
            Dim clienteActual As DataRowView = ClientesBindingSource.Current
            Dim autoActual As DataRowView = AutosBindingSource.Current
            Dim result As Integer = MessageBox.Show("¿Esta seguro de eliminar al cliente " + clienteActual("nombre") + " " + clienteActual("apellido") + " ?. Se eliminaràn todos sus autos", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                Dim contrasenia As New FrmContrasenia
                If (DialogResult.OK = FrmContrasenia.ShowDialog()) Then

                    clienteActual.Delete()
                    ' ClientesTableAdapter.Delete(clienteActual("idCliente"), clienteActual("nombre"), clienteActual("apellido"), clienteActual("direccion"), clienteActual("telefono"), clienteActual("fechaNacimiento"), clienteActual("dni"))
                    ClientesTableAdapter.Update(BecharaDataSet.clientes)
                    ClientesTableAdapter.Fill(BecharaDataSet.clientes)
                    AutosTableAdapter.Update(BecharaDataSet.autos)
                    AutosTableAdapter.Fill(BecharaDataSet.autos)
                ElseIf result = DialogResult.No Then
                End If
            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



        FrmContrasenia.Dispose()



    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try

            Dim cliente As DataRowView = ClientesBindingSource.Current

            FrmModificarCliente.hola.Text = cliente("nombre")
            FrmModificarCliente.txtApellidoCliente.Text = cliente("apellido")
            FrmModificarCliente.txtDireccionCliente.Text = cliente("direccion")
            FrmModificarCliente.txtTelefonoCliente.Text = cliente("telefono")
            FrmModificarCliente.dtpCliente.Text = cliente("fechaNacimiento")
            FrmModificarCliente.txtDniCliente.Text = cliente("dni")


            If (DialogResult.OK = FrmModificarCliente.ShowDialog()) Then



                cliente("nombre") = FrmModificarCliente.hola.Text
                cliente("apellido") = FrmModificarCliente.txtApellidoCliente.Text
                cliente("direccion") = FrmModificarCliente.txtDireccionCliente.Text
                cliente("telefono") = FrmModificarCliente.txtTelefonoCliente.Text
                cliente("fechaNacimiento") = FrmModificarCliente.dtpCliente.Value
                cliente("dni") = FrmModificarCliente.txtDniCliente.Text


                cliente.EndEdit()
                ClientesTableAdapter.Update(BecharaDataSet)
                ClientesTableAdapter.Fill(BecharaDataSet.clientes)
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub autosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles autosToolStripMenuItem.Click
        Dim frmAuto As New FrmAuto()
        frmAuto.ShowDialog()
    End Sub

    Private Sub ordenDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ordenDeTrabajoToolStripMenuItem.Click
        Dim frmTipoTrabajo As New FrmTipoDeTrabajo()
        frmTipoTrabajo.ShowDialog()
    End Sub

    Private Sub tiposDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tiposDeTrabajoToolStripMenuItem.Click
        Dim frmTrabajo As New FrmTrabajos()
        frmTrabajo.ShowDialog()
    End Sub

    Private Sub turnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles turnosToolStripMenuItem.Click
        Dim frmTurno As New TURNOS()
        frmTurno.ShowDialog()
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaCliente.TextChanged

        Try
            Dim filtro As String
            filtro = cmbFiltroCliente.SelectedItem.ToString


            If filtro = "Nombre" Then
                ClientesBindingSource.Filter = "nombre like '*" & txtBuscaCliente.Text & "*'"

            ElseIf filtro = "Apellido" Then
                ClientesBindingSource.Filter = "apellido like '*" & txtBuscaCliente.Text & "*'"



            Else
                ClientesBindingSource.Filter = "Direccion like '*" & txtBuscaCliente.Text & "*'"

            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un filtro de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscaCliente.Clear()
        End Try

    End Sub



    Private Sub presupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles presupuestosToolStripMenuItem.Click
        Dim frmPresupuesto As New FrmPresupuestos()
        frmPresupuesto.ShowDialog()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.A) Then
            FrmAgregarCliente.ShowDialog()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.M) Then
            FrmModificarCliente.ShowDialog()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.E) Then
            button3.PerformClick()
            txtBuscaCliente.Clear()
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



    Private Sub TiposTrabajos_Click(sender As Object, e As EventArgs) Handles TiposTrabajos.Click
        FrmReporteTipoTrabajo.ShowDialog()
    End Sub

    Private Sub cmbFiltroCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroCliente.SelectedIndexChanged
        txtBuscaCliente.Focus()
    End Sub

    Private Sub Trabajos_Click(sender As Object, e As EventArgs) Handles Trabajos.Click
        FrmReporteTrabajos.ShowDialog()
    End Sub
End Class


