Imports MySql.Data.MySqlClient
Public Class FrmTrabajos

    Private Sub FrmTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGridView()
        'TODO: This line of code loads data into the 'BecharaDataSet.ordentrabajo_has_tipotrabajo' table. You can move, or remove it, as needed.
        Me.Ordentrabajo_has_tipotrabajoTableAdapter.Fill(Me.BecharaDataSet.ordentrabajo_has_tipotrabajo)


        'TODO: This line of code loads data into the 'BecharaDataSet.ordentrabajo' table. You can move, or remove it, as needed.
        Me.OrdentrabajoTableAdapter.Fill(Me.BecharaDataSet.ordentrabajo)


    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        If (DialogResult.OK = FrmNuevaOrdenDeTrabajo.ShowDialog()) Then
            Dim nuevaOrden As DataRowView
            Dim ordenTipo As DataRowView

            'AGREGA Orden

            nuevaOrden = OrdentrabajoBindingSource.AddNew()
            nuevaOrden("clientes_idCliente") = FrmNuevaOrdenDeTrabajo.ltsClientes.SelectedValue
            nuevaOrden("autos_idAuto") = FrmNuevaOrdenDeTrabajo.ComboBox1.SelectedValue
            nuevaOrden("precioRespuesto") = CDbl(FrmNuevaOrdenDeTrabajo.txtRepuestos.Text)
            nuevaOrden("precioManoObra") = CDbl(FrmNuevaOrdenDeTrabajo.txtManoObra.Text)
            nuevaOrden("precioTotal") = CDbl(FrmNuevaOrdenDeTrabajo.txtTotal.Text)
            nuevaOrden("fechaEntrada") = FrmNuevaOrdenDeTrabajo.fechaEntrada.Value
            nuevaOrden("fechaSalida") = FrmNuevaOrdenDeTrabajo.fechaSalida.Value
            nuevaOrden("observaciones") = FrmNuevaOrdenDeTrabajo.txtObservaciones.Text
            nuevaOrden("bechara") = FrmNuevaOrdenDeTrabajo.repuestosBechara
            nuevaOrden.EndEdit()
            OrdentrabajoTableAdapter.Update(BecharaDataSet)
            OrdentrabajoTableAdapter.Fill(BecharaDataSet.ordentrabajo)
            OrdentrabajoBindingSource.MoveLast()
            nuevaOrden = OrdentrabajoBindingSource.Current
            'agregar primer combo

            ordenTipo = Ordentrabajo_has_tipotrabajoBindingSource.AddNew()
            ordenTipo("ordentrabajo_idOrdenTrabajo") = nuevaOrden("idOrdenTrabajo")
            ordenTipo("tipotrabajo_idTipoTrabajo") = FrmNuevaOrdenDeTrabajo.cmbTipotrabajo.SelectedValue
            ordenTipo("precio") = CDbl(FrmNuevaOrdenDeTrabajo.txtPrecio.Text)

            'cargar tabla intermedia entre tipo trabajo y orden trabajo.
            For Index = 1 To FrmNuevaOrdenDeTrabajo.contador - 1
                ordenTipo = Ordentrabajo_has_tipotrabajoBindingSource.AddNew()
                ordenTipo("ordentrabajo_idOrdenTrabajo") = nuevaOrden("idOrdenTrabajo")
                ordenTipo("tipotrabajo_idTipoTrabajo") = FrmNuevaOrdenDeTrabajo.idTipoTrabajo(Index)
                ordenTipo("precio") = CDbl(FrmNuevaOrdenDeTrabajo.idPrecio(Index))

            Next

            ordenTipo.EndEdit()
            Ordentrabajo_has_tipotrabajoTableAdapter.Update(BecharaDataSet)
            Ordentrabajo_has_tipotrabajoTableAdapter.Fill(BecharaDataSet.ordentrabajo_has_tipotrabajo)
            FrmNuevaOrdenDeTrabajo.Dispose()
            llenarGridView()
        End If

    End Sub



    Private Sub OrdentrabajoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrdentrabajoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub llenarGridView()
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "SELECT   tipotrabajo.nombre, ordentrabajo_has_tipotrabajo.precio
                                FROM     ordentrabajo_has_tipotrabajo ,tipotrabajo, ordentrabajo
                                where  ordentrabajo_has_tipotrabajo.ordentrabajo_idOrdentrabajo = ordentrabajo.idOrdentrabajo and
                                ordentrabajo_has_tipotrabajo.tipotrabajo_idTipoTrabajo  = tipotrabajo.idTipoTrabajo"
        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try


        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DgvOrdenesTipos.DataSource = dt
    End Sub

    Private Sub OrdentrabajoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdentrabajoDataGridView.CellClick
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "SELECT   tipotrabajo.nombre, ordentrabajo_has_tipotrabajo.precio
                               From   ordentrabajo_has_tipotrabajo ,tipotrabajo
                               where  ordentrabajo_has_tipotrabajo.ordentrabajo_idOrdentrabajo = @id and
                               ordentrabajo_has_tipotrabajo.tipotrabajo_idTipoTrabajo  = tipotrabajo.idTipoTrabajo"
        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try


        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        If (Not IsNothing(da.SelectCommand.Parameters.AddWithValue("id", OrdentrabajoDataGridView.CurrentCell.Value))) Then
            da.Fill(dt)
            DgvOrdenesTipos.DataSource = dt
        End If
    End Sub


End Class