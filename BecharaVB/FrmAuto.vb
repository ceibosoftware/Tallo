Imports MySql.Data.MySqlClient

Public Class FrmAuto
    Private Sub AutosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AutosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub FrmAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.autos' table. You can move, or remove it, as needed.
        Me.AutosTableAdapter1.Fill(Me.DataSet1.autos)
        'TODO: This line of code loads data into the 'DataSet1.autos' table. You can move, or remove it, as needed.
        Me.AutosTableAdapter1.Fill(Me.DataSet1.autos)
        'TODO: This line of code loads data into the 'BecharaDataSet.autos' table. You can move, or remove it, as needed.
        Me.AutosTableAdapter.Fill(Me.BecharaDataSet.autos)
        cmbFiltroAuto.SelectedIndex = 1
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarNuevoAuto.ShowDialog()) Then
            Dim nuevoAuto As DataRowView
            'Dim cliente As DataRowView = ClientesBindingSource.AddNew()
            'AGREGA AUTO
            nuevoAuto = AutosBindingSource.AddNew()
            nuevoAuto("clientes_idCliente") = FrmAgregarNuevoAuto.listClientes.SelectedValue
            nuevoAuto("marca") = FrmAgregarNuevoAuto.txtMarca.Text
            nuevoAuto("patente") = FrmAgregarNuevoAuto.txtPatente.Text
            nuevoAuto("modelo") = FrmAgregarNuevoAuto.txtModelo.Text
            nuevoAuto("anio") = FrmAgregarNuevoAuto.txtAnio.Text
            nuevoAuto("color") = FrmAgregarNuevoAuto.txtColor.Text
            nuevoAuto("filtroAceite") = FrmAgregarNuevoAuto.txtFiltroAceite.Text
            nuevoAuto("filtroAire") = FrmAgregarNuevoAuto.txtFiltroAire.Text
            nuevoAuto("filtroCombustible") = FrmAgregarNuevoAuto.txtFiltroCombustible.Text
            nuevoAuto("filtroHabitaculo") = FrmAgregarNuevoAuto.txtFiltroHabitaculo.Text
            nuevoAuto("aceiteMotor") = FrmAgregarNuevoAuto.txtAceiteMotor.Text
            nuevoAuto("kilometraje") = FrmAgregarNuevoAuto.txtKilometraje.Text
            nuevoAuto("distribucion") = FrmAgregarNuevoAuto.txtCorrea.Text
            nuevoAuto("tipoCombustible") = FrmAgregarNuevoAuto.cmbTipoCombustible.SelectedItem

            nuevoAuto.EndEdit()
            AutosTableAdapter.Update(BecharaDataSet)
            AutosTableAdapter.Fill(BecharaDataSet.autos)
            FrmAgregarNuevoAuto.Dispose()
        End If
        AutosTableAdapter1.Fill(DataSet1.autos)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Try

            Dim auto As DataRowView = AutosBindingSource.Current


            FrmModificarAuto.txtMarca.Text = auto("marca")
            FrmModificarAuto.txtModelo.Text = auto("modelo")
            FrmModificarAuto.txtAnio.Text = auto("anio")
            FrmModificarAuto.txtColor.Text = auto("color")
            FrmModificarAuto.txtFiltroAceite.Text = auto("filtroAceite")
            FrmModificarAuto.txtFiltroAire.Text = auto("filtroAire")
            FrmModificarAuto.txtFiltroCombustible.Text = auto("filtroCombustible")
            FrmModificarAuto.txtFiltroHabitaculo.Text = auto("filtroHabitaculo")
            FrmModificarAuto.txtAceiteMotor.Text = auto("aceiteMotor")
            FrmModificarAuto.txtKilometraje.Text = auto("kilometraje")
            FrmModificarAuto.txtCorrea.Text = auto("distribucion")
            '  FrmModificarAuto.cmbTipoCombustible.SelectedIndex = auto("tipoCombustible")
            FrmModificarAuto.txtPatente.Text = auto("patente")


            If (DialogResult.OK = FrmModificarAuto.ShowDialog()) Then


                auto("patente") = FrmModificarAuto.txtPatente.Text
                auto("marca") = FrmModificarAuto.txtMarca.Text
                auto("modelo") = FrmModificarAuto.txtModelo.Text
                auto("anio") = FrmModificarAuto.txtAnio.Text
                auto("color") = FrmModificarAuto.txtColor.Text
                auto("filtroAceite") = FrmModificarAuto.txtFiltroAceite.Text
                auto("filtroAire") = FrmModificarAuto.txtFiltroAire.Text
                auto("filtroCombustible") = FrmModificarAuto.txtFiltroCombustible.Text
                auto("filtroHabitaculo") = FrmModificarAuto.txtFiltroHabitaculo.Text
                auto("aceiteMotor") = FrmModificarAuto.txtAceiteMotor.Text
                auto("kilometraje") = FrmModificarAuto.txtKilometraje.Text
                auto("distribucion") = FrmModificarAuto.txtCorrea.Text
                auto("tipoCombustible") = FrmModificarAuto.cmbTipoCombustible.Text



                auto.EndEdit()
                AutosTableAdapter.Update(BecharaDataSet)
                AutosTableAdapter.Fill(BecharaDataSet.autos)
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try

            Dim query As String = "Delete  from autos where autos.idAuto='" & AutosDataGridView.CurrentRow.Cells(15).Value & "' "
            Dim connstring As String = "data source =localhost;user id=root; password='';database ='bechara'"
            Dim conexion As MySqlConnection = New MySqlConnection(connstring)


            Dim result As Integer = MessageBox.Show("¿Está seguro de eliminar el auto de  " + AutosDataGridView.CurrentRow.Cells(13).Value.ToString + " " + AutosDataGridView.CurrentRow.Cells(14).Value.ToString + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                Dim contrasenia As New FrmContrasenia
                If (DialogResult.OK = FrmContrasenia.ShowDialog()) Then

                    conexion.Open()
                    Dim comando As MySqlCommand = New MySqlCommand(query, conexion)
                    Dim myreader As MySqlDataReader = comando.ExecuteReader()
                    myreader.Read()

                    AutosTableAdapter1.Fill(DataSet1.autos)

                ElseIf result = DialogResult.No Then
                End If
            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        FrmContrasenia.Dispose()
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarAuto.TextChanged
        Try
            Dim filtro As String
            filtro = cmbFiltroAuto.SelectedItem.ToString


            If filtro = "Patente" Then

                AutosBindingSource.Filter = "patente like '*" & txtBuscarAuto.Text & "*'"

            ElseIf filtro = "Modelo" Then

                AutosBindingSource.Filter = "modelo like '*" & txtBuscarAuto.Text & "*'"



            Else

                AutosBindingSource.Filter = "apellido like '*" & txtBuscarAuto.Text & "*'"

            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un filtro de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscarAuto.Clear()
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.A) Then
            FrmAgregarNuevoAuto.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.M) Then
            FrmModificarAuto.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.E) Then
            button3.PerformClick()
        End If

        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




End Class