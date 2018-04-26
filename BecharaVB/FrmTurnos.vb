Imports MySql.Data.MySqlClient
Public Class TURNOS
    Dim BindingT As New BindingSource
    Dim turnoActual As DataRowView
    Dim LoadTurnos As String = "SELECT turnos.idTurno, turnos.nombre ,turnos.apellido ,turnos.telefono , turnos.observaciones, turnos.fechaTurno
                                ,turnos.horario 
                                FROM turnos "

    Private Sub TurnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub FrmTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.turnos' table. You can move, or remove it, as needed.
        Me.TurnosTableAdapter.Fill(Me.BecharaDataSet.turnos)
        EliminarFechas()
        cargarGridTurnos(LoadTurnos)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarTurnos.ShowDialog()) Then
            Dim nuevoTurno As DataRowView
            nuevoTurno = TurnosBindingSource.AddNew()

            'AGREGA PRESUPUESTO

            nuevoTurno("nombre") = FrmAgregarTurnos.txtnombreturno.Text
            nuevoTurno("apellido") = FrmAgregarTurnos.txtapellidoturno.Text
            nuevoTurno("telefono") = FrmAgregarTurnos.txttelefonoturno.Text
            nuevoTurno("observaciones") = FrmAgregarTurnos.txtObservacionturno.Text
            nuevoTurno("fechaTurno") = FrmAgregarTurnos.dtpFechaTurno.Value.ToString
            nuevoTurno("horario") = FrmAgregarTurnos.cmbhorarioturno.Text



            nuevoTurno.EndEdit()
            TurnosTableAdapter.Update(BecharaDataSet)
            TurnosTableAdapter.Fill(BecharaDataSet.turnos)
            cargarGridTurnos(LoadTurnos)

        End If
        FrmAgregarTurnos.Dispose()
    End Sub



    Private Sub EliminarFechas()


        'ELIMINAR TURNOS AUTOMATICAMENTE

        For id = 0 To 50

            turnoActual = TurnosBindingSource.Current
            If (Not IsNothing(turnoActual)) Then
                Dim fechaActual = turnoActual("fechaTurno")
                Dim fechaReal As Date = Now.Date
                Dim result As Integer = Date.Compare(fechaActual, fechaReal)
                Dim relationship As String

                Console.WriteLine(result)
                If result = -1 Then
                    relationship = "se vencio el turno y se elimina"
                    turnoActual.Delete()

                Else
                    relationship = "turno esta en tiempo"
                    TurnosBindingSource.MoveNext()

                End If

                Console.WriteLine("" + fechaActual + "; " + relationship)
            End If
        Next


        TurnosTableAdapter.Update(BecharaDataSet.turnos)
        TurnosTableAdapter.Fill(BecharaDataSet.turnos)
        cargarGridTurnos(LoadTurnos)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Try
            'MODIFICA TURNOS
            Dim turno As DataRowView = TurnosBindingSource.Current

            Dim id As Integer = DgvTurnos.CurrentRow.Cells(0).Value
            FrmModificarTurnos.txtnombreturno.Text = DgvTurnos.CurrentRow.Cells(1).Value.ToString
            FrmModificarTurnos.txtapellidoturno.Text = DgvTurnos.CurrentRow.Cells(2).Value.ToString
            FrmModificarTurnos.txttelefonoturno.Text = DgvTurnos.CurrentRow.Cells(3).Value.ToString
            FrmModificarTurnos.txtObservacionturno.Text = DgvTurnos.CurrentRow.Cells(4).Value.ToString
            FrmModificarTurnos.dtpFechaTurno.Value = DgvTurnos.CurrentRow.Cells(5).Value
            'FrmModificarTurnos.cmbhorarioturno.Text = turno("horario")

            If (DialogResult.OK = FrmModificarTurnos.ShowDialog()) Then
                Dim Sql As String = "Update turnos Set turnos.nombre='" & FrmModificarTurnos.txtnombreturno.Text & "' , turnos.apellido='" & FrmModificarTurnos.txtapellidoturno.Text & "', turnos.telefono='" & FrmModificarTurnos.txttelefonoturno.Text & "', turnos.observaciones='" & FrmModificarTurnos.txtObservacionturno.Text & "',  turnos.horario='" & FrmModificarTurnos.cmbhorarioturno.Text & "',turnos.fechaTurno='" & FrmModificarTurnos.dtpFechaTurno.Value.ToString("yyyy-MM-dd") & "'  where turnos.idTurno=" & DgvTurnos.CurrentRow.Cells(0).Value & ""
                cargarGridTurnos(Sql)
                cargarGridTurnos(LoadTurnos)
            End If

        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        'ELIMINAR

        Try
            Dim sql As String = "Delete  from turnos where turnos.idTurno = " & DgvTurnos.CurrentRow.Cells(0).Value & ""

            Dim result As Integer = MessageBox.Show("¿Esta seguro de eliminar el turno de " + DgvTurnos.CurrentRow.Cells(1).Value.ToString + " ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If result = DialogResult.Yes Then
                Dim contrasenia As New FrmContrasenia
                If (DialogResult.OK = FrmContrasenia.ShowDialog()) Then

                    cargarGridTurnos(sql)
                    cargarGridTurnos(LoadTurnos)

                End If
            ElseIf result = DialogResult.No Then

            End If


        Catch ex As Exception
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        FrmContrasenia.Dispose()
    End Sub



    Private Sub cargarGridTurnos(sql As String)

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
        DgvTurnos.DataSource = dt

        If DgvTurnos.RowCount <> 0 Then
            DgvTurnos.Columns("idTurno").Visible = False
            DgvTurnos.Columns("observaciones").Visible = False
            DgvTurnos.Columns(1).HeaderText = "Nombre"
            DgvTurnos.Columns(2).HeaderText = "Apellido"
            DgvTurnos.Columns(3).HeaderText = "Telefono"
            DgvTurnos.Columns(5).HeaderText = "Fecha"
            DgvTurnos.Columns(6).HeaderText = "Horario"
        End If
    End Sub

    Private Sub mtturno_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtturno.DateSelected

        'FILTRAR POR FECHA
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim observacion As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "SELECT turnos.idTurno,turnos.nombre ,turnos.apellido ,turnos.telefono , turnos.observaciones, turnos.fechaTurno
                               , turnos.horario 
                               FROM turnos where fechaTurno = @id"

        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        If (Not IsNothing(da.SelectCommand.Parameters.AddWithValue("id", e.Start.ToString("yyyy-MM-dd")))) Then
            da.Fill(dt)
            DgvTurnos.DataSource = dt
        End If

    End Sub

    Private Sub DgvTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTurnos.CellClick
        txtObservacionturnos.Text = DgvTurnos.CurrentRow.Cells(4).Value.ToString
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.A) Then
            FrmAgregarTurnos.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.M) Then
            FrmModificarTurnos.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.E) Then
            button3.PerformClick()
        End If

        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'FILTRAR POR FECHA

        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim observacion As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = "SELECT turnos.idTurno,turnos.nombre ,turnos.apellido ,turnos.telefono , turnos.observaciones, turnos.fechaTurno
                               , turnos.horario 
                               FROM turnos "

        Try
            conexion.ConnectionString = "data source =localhost;user id=root; password='';database ='bechara'"
        Catch ex As Exception

        End Try

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DgvTurnos.DataSource = dt
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No hay turnos para mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information
                            )
        End If
    End Sub


End Class