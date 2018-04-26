Imports MySql.Data.MySqlClient
Public Class FrmTrabajos

    Private Sub FrmTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)
        'TODO: This line of code loads data into the 'BecharaDataSet.ordentrabajo_has_tipotrabajo' table. You can move, or remove it, as needed.
        Me.Ordentrabajo_has_tipotrabajoTableAdapter.Fill(Me.BecharaDataSet.ordentrabajo_has_tipotrabajo)
        llenarGridView()
        'TODO: This line of code loads data into the 'BecharaDataSet.ordentrabajo_has_tipotrabajo' table. You can move, or remove it, as needed.
        Me.Ordentrabajo_has_tipotrabajoTableAdapter.Fill(Me.BecharaDataSet.ordentrabajo_has_tipotrabajo)


        'TODO: This line of code loads data into the 'BecharaDataSet.ordentrabajo' table. You can move, or remove it, as needed.
        Me.OrdentrabajoTableAdapter.Fill(Me.BecharaDataSet.ordentrabajo)

        'llena gridview ordes

        cargarGridOrdenes()
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
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
                nuevaOrden("terminado") = FrmNuevaOrdenDeTrabajo.chkTerminado.CheckState
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
                ordenTipo.EndEdit()
                'cargar tabla intermedia entre tipo trabajo y orden trabajo.

                For Index = 1 To FrmNuevaOrdenDeTrabajo.contador - 1
                    ordenTipo = Ordentrabajo_has_tipotrabajoBindingSource.AddNew()
                    ordenTipo("ordentrabajo_idOrdenTrabajo") = nuevaOrden("idOrdenTrabajo")
                    ordenTipo("tipotrabajo_idTipoTrabajo") = FrmNuevaOrdenDeTrabajo.idTipoTrabajo(Index)
                    ordenTipo("precio") = CDbl(FrmNuevaOrdenDeTrabajo.idPrecio(Index))
                    ordenTipo.EndEdit()
                    Console.WriteLine("Aca estoy")
                Next

                Ordentrabajo_has_tipotrabajoTableAdapter.Update(BecharaDataSet)
                Ordentrabajo_has_tipotrabajoTableAdapter.Fill(BecharaDataSet.ordentrabajo_has_tipotrabajo)
                FrmNuevaOrdenDeTrabajo.Dispose()
                llenarGridView()
                cargarGridOrdenes()
            Else
                FrmNuevaOrdenDeTrabajo.Dispose()
            End If


        Catch ex As ArgumentException
            MessageBox.Show("No se puede crear trabajo no hay clientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmNuevaOrdenDeTrabajo.Dispose()
        Catch es As Exception
            MessageBox.Show("Es necesario completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmNuevaOrdenDeTrabajo.Dispose()
        End Try

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
        DgvOrdenesTipos.Columns(0).Width = 182
    End Sub



    Private Sub cargarGridOrdenes()
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "SELECT  autos.modelo, clientes.nombre, clientes.apellido, ordentrabajo.observaciones, ordentrabajo.idOrdenTrabajo, ordentrabajo.fechaEntrada, ordentrabajo.fechaSalida, ordentrabajo.precioTotal,
                                ordentrabajo.precioManoObra, ordentrabajo.precioRespuesto, ordentrabajo.bechara, clientes.idCliente,autos.idAuto,ordentrabajo.terminado
                                FROM  ordentrabajo ,autos, clientes where ordentrabajo.clientes_idCliente = clientes.idCliente and ordentrabajo.autos_idAuto = autos.idAuto order by  ordentrabajo.idOrdenTrabajo desc"
        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try


        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        OrdentrabajoDataGridView.DataSource = dt
        OrdentrabajoDataGridView.Columns("idCliente").Visible = False
        OrdentrabajoDataGridView.Columns("idAuto").Visible = False
        OrdentrabajoDataGridView.Columns("observaciones").Visible = False
        OrdentrabajoDataGridView.Columns("idOrdenTrabajo").Visible = False

        For i = 0 To OrdentrabajoDataGridView.Columns.Count - 1
            OrdentrabajoDataGridView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        OrdentrabajoDataGridView.Columns(0).HeaderText = "Auto"
        OrdentrabajoDataGridView.Columns(1).HeaderText = "Nombre"
        OrdentrabajoDataGridView.Columns(2).HeaderText = "Apellido"
        OrdentrabajoDataGridView.Columns(5).HeaderText = "Fecha entrada"
        OrdentrabajoDataGridView.Columns(6).HeaderText = "Fecha salida"
        OrdentrabajoDataGridView.Columns(7).HeaderText = "Precio total"
        OrdentrabajoDataGridView.Columns(8).HeaderText = "Precio mano de obra"
        OrdentrabajoDataGridView.Columns(9).HeaderText = "Precio repuestos"
        OrdentrabajoDataGridView.Columns(10).HeaderText = "Bechara"
        OrdentrabajoDataGridView.Columns(13).HeaderText = "Terminado"
    End Sub


    Private Sub OrdentrabajoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdentrabajoDataGridView.CellClick


        Try
            Dim conexion As MySqlConnection = New MySqlConnection
            Dim comando As MySqlCommand = New MySqlCommand
            Dim observacion As MySqlCommand = New MySqlCommand
            comando.Connection = conexion

            comando.CommandText = "SELECT   tipotrabajo.nombre, ordentrabajo_has_tipotrabajo.precio
                               From   ordentrabajo_has_tipotrabajo ,tipotrabajo
                               where  ordentrabajo_has_tipotrabajo.ordentrabajo_idOrdentrabajo = @id and
                               ordentrabajo_has_tipotrabajo.tipotrabajo_idTipoTrabajo  = tipotrabajo.idTipoTrabajo"
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
            ' llenar datagrid tipoPRECIO
            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

            If (Not IsNothing(da.SelectCommand.Parameters.AddWithValue("id", OrdentrabajoDataGridView.CurrentRow.Cells(4).Value))) Then
                da.Fill(dt)
                DgvOrdenesTipos.DataSource = dt
            End If

            txtObservacion.Text = OrdentrabajoDataGridView.CurrentRow.Cells(3).Value.ToString
        Catch ex As NullReferenceException
            MessageBox.Show("No se ha creado ningun trabajo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch es As Exception

        End Try



    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = " SELECT  autos.modelo, clientes.nombre, clientes.apellido, ordentrabajo.observaciones, ordentrabajo.idOrdenTrabajo, ordentrabajo.fechaEntrada, ordentrabajo.fechaSalida, ordentrabajo.precioTotal, 
                                ordentrabajo.precioManoObra, ordentrabajo.precioRespuesto, ordentrabajo.bechara
                                From 
                                ordentrabajo , autos, clientes 
                                Where 
                                ordentrabajo.clientes_idCliente = clientes.idCliente And ordentrabajo.autos_idAuto = autos.idAuto And clientes.apellido LIKE '%' @apellido '%' "
        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try


        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)
        da.SelectCommand.Parameters.AddWithValue("apellido", textBox1.Text)
        da.Fill(dt)
        OrdentrabajoDataGridView.DataSource = dt

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Try
            If OrdentrabajoDataGridView.CurrentRow.Cells(13).Value <> True Then

                FrmMOdificarOrdenTrabajo.fechaEntrada.Value = OrdentrabajoDataGridView.CurrentRow.Cells(5).Value
                FrmMOdificarOrdenTrabajo.fechaSalida.Value = OrdentrabajoDataGridView.CurrentRow.Cells(6).Value
                FrmMOdificarOrdenTrabajo.txtObservaciones.Text = OrdentrabajoDataGridView.CurrentRow.Cells(3).Value.ToString
                FrmMOdificarOrdenTrabajo.txtRepuestos.Text = OrdentrabajoDataGridView.CurrentRow.Cells(9).Value.ToString
                FrmMOdificarOrdenTrabajo.txtManoObra.Text = OrdentrabajoDataGridView.CurrentRow.Cells(8).Value.ToString
                FrmMOdificarOrdenTrabajo.txtRepuestos.Text = OrdentrabajoDataGridView.CurrentRow.Cells(9).Value.ToString
                FrmMOdificarOrdenTrabajo.txtTotal.Text = OrdentrabajoDataGridView.CurrentRow.Cells(7).Value.ToString
                FrmMOdificarOrdenTrabajo.chkRepuestos.Checked = OrdentrabajoDataGridView.CurrentRow.Cells(10).Value
                FrmMOdificarOrdenTrabajo.llenarLtsClientes(OrdentrabajoDataGridView.CurrentRow.Cells(11).Value)
                FrmMOdificarOrdenTrabajo.llenarComboAutos(OrdentrabajoDataGridView.CurrentRow.Cells(12).Value, OrdentrabajoDataGridView.CurrentRow.Cells(11).Value)
                getTrabajos(OrdentrabajoDataGridView.CurrentRow.Cells(4).Value)
                Dim idOrden As Integer = OrdentrabajoDataGridView.CurrentRow.Cells(4).Value

                If (DialogResult.OK = FrmMOdificarOrdenTrabajo.ShowDialog()) Then
                    Dim Sql As String = "Update ordentrabajo Set ordentrabajo.observaciones='" & FrmMOdificarOrdenTrabajo.txtObservaciones.Text & "' , ordentrabajo.clientes_idCliente='" & FrmMOdificarOrdenTrabajo.ltsClientes.SelectedValue & "', 
                   ordentrabajo.autos_idAuto='" & FrmMOdificarOrdenTrabajo.ComboBox1.SelectedValue & "', ordentrabajo.bechara='" & FrmMOdificarOrdenTrabajo.chkRepuestos.CheckState & "', 
                    ordentrabajo.precioRespuesto='" & CDbl(FrmMOdificarOrdenTrabajo.txtRepuestos.Text) & "', 
                   ordentrabajo.precioTotal='" & CDbl(FrmMOdificarOrdenTrabajo.txtTotal.Text) & "' ,  
                    ordentrabajo.precioManoObra='" & CDbl(FrmMOdificarOrdenTrabajo.txtManoObra.Text) & "' ,
                   ordentrabajo.fechaEntrada='" & FrmMOdificarOrdenTrabajo.fechaEntrada.Value.ToString("yyyy-MM-dd") & "',  
                    ordentrabajo.fechaSalida='" & FrmMOdificarOrdenTrabajo.fechaSalida.Value.ToString("yyyy-MM-dd") & "', 
                   ordentrabajo.terminado='" & FrmMOdificarOrdenTrabajo.chkTerminado.CheckState & "'            
                    where  ordentrabajo.idOrdenTrabajo=" & OrdentrabajoDataGridView.CurrentRow.Cells(4).Value & ""
                    cargarOrdenTrabajo(Sql)
                    cargarGridOrdenes()


                    eliminarTrabajo(idOrden)



                    Dim tablaIntermedia As DataRowView
                    For Index = 0 To FrmMOdificarOrdenTrabajo.contador - 1
                        tablaIntermedia = Ordentrabajo_has_tipotrabajoBindingSource.AddNew()
                        tablaIntermedia("ordentrabajo_idOrdenTrabajo") = idOrden
                        tablaIntermedia("tipotrabajo_idTipoTrabajo") = FrmMOdificarOrdenTrabajo.idTipoTrabajo(Index)
                        tablaIntermedia("precio") = CDbl(FrmMOdificarOrdenTrabajo.idPrecio(Index))
                        tablaIntermedia.EndEdit()
                        Console.WriteLine("Aca estoy")
                    Next
                    Ordentrabajo_has_tipotrabajoTableAdapter.Update(BecharaDataSet)
                    Ordentrabajo_has_tipotrabajoTableAdapter.Fill(BecharaDataSet.ordentrabajo_has_tipotrabajo)
                    llenarGridView()
                    FrmMOdificarOrdenTrabajo.Dispose()
                Else
                    FrmMOdificarOrdenTrabajo.Dispose()
                End If
            Else
                MessageBox.Show("No se puede modificar este trabajo ha sido terminado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub getTrabajos(idOrdenTrabajo As Integer)
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "select * from ordentrabajo_has_tipotrabajo where ordentrabajo_has_tipotrabajo.ordentrabajo_idOrdenTrabajo='" & idOrdenTrabajo & "' "
        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)
        da.Fill(dt)

        For Each dr As DataRow In dt.Rows
            FrmMOdificarOrdenTrabajo.crearComboYtext()
            FrmMOdificarOrdenTrabajo.llenarCombos(dr("tipotrabajo_idTipoTrabajo"), dr("precio").ToString)
            FrmMOdificarOrdenTrabajo.contador += 1
        Next

    End Sub

    Private Sub eliminarTrabajo(idOrdenTrabajo As Integer)
        Dim query As String = "Delete  from ordentrabajo_has_tipotrabajo where ordentrabajo_has_tipotrabajo.ordentrabajo_idOrdenTrabajo='" & idOrdenTrabajo & "' "
        Dim connstring As String = "data source =localhost;user id=root; password='';database ='bechara'"
        Dim conexion As MySqlConnection = New MySqlConnection(connstring)
        conexion.Open()
        Dim comando As MySqlCommand = New MySqlCommand(query, conexion)
        Dim myreader As MySqlDataReader = comando.ExecuteReader()
        myreader.Read()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            Dim sql As String = "Delete  from ordentrabajo where ordentrabajo.idOrdenTrabajo = " & OrdentrabajoDataGridView.CurrentRow.Cells(4).Value & ""

            Dim result As Integer = MessageBox.Show("¿Esta seguro de eliminar la orden de trabajo de " + OrdentrabajoDataGridView.CurrentRow.Cells(1).Value.ToString + " " + OrdentrabajoDataGridView.CurrentRow.Cells(2).Value.ToString + " ?.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If result = DialogResult.Yes Then
                Dim contrasenia As New FrmContrasenia
                If (DialogResult.OK = FrmContrasenia.ShowDialog()) Then

                    cargarOrdenTrabajo(sql)
                    cargarGridOrdenes()
                    llenarGridView()
                End If
            ElseIf result = DialogResult.No Then

                End If

        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        FrmContrasenia.Dispose()
    End Sub
    Private Sub cargarOrdenTrabajo(sql As String)
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion
        comando.CommandText = sql

        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"

        Catch ex As Exception

        End Try


        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        OrdentrabajoDataGridView.DataSource = dt

    End Sub


End Class