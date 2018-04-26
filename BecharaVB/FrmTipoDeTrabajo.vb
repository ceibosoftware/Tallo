﻿Public Class FrmTipoDeTrabajo


    Private Sub FrmTipoDeTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.tipotrabajo' table. You can move, or remove it, as needed.
        Me.TipotrabajoTableAdapter.Fill(Me.BecharaDataSet.tipotrabajo)
        textBox2.Select()
        comboBox2.SelectedIndex = 0
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarTipotrabajo.ShowDialog()) Then
            Dim nuevoTipotrabajo As DataRowView

            'AGREGA tipotrabajo
            nuevoTipotrabajo = TipotrabajoBindingSource.AddNew()
            nuevoTipotrabajo("nombre") = FrmAgregarTipotrabajo.txtNombre.Text

            nuevoTipotrabajo.EndEdit()
            TipotrabajoTableAdapter.Update(BecharaDataSet)
            TipotrabajoTableAdapter.Fill(BecharaDataSet.tipotrabajo)
            FrmAgregarTipotrabajo.Dispose()
        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim tipoTrabajo As DataRowView = TipotrabajoBindingSource.Current

        Try
            FrmModificarTipoTrabajo.txtNombretrabajo.Text = tipoTrabajo("nombre")

            If (DialogResult.OK = FrmModificarTipoTrabajo.ShowDialog()) Then
                tipoTrabajo("nombre") = FrmModificarTipoTrabajo.txtNombretrabajo.Text
                tipoTrabajo.EndEdit()
                TipotrabajoTableAdapter.Update(BecharaDataSet)
                TipotrabajoTableAdapter.Fill(BecharaDataSet.tipotrabajo)
                FrmModificarTipoTrabajo.Dispose()
            Else
                FrmModificarTipoTrabajo.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show("Error , no hay registros para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim trabajoActual As DataRowView = TipotrabajoBindingSource.Current
        Console.WriteLine("current " + TipotrabajoBindingSource.Current.ToString)
        Dim result As Integer = MessageBox.Show("¿Esta seguro de eliminar  trabajo " + trabajoActual("nombre"), "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        Try
            Dim contrasenia As New FrmContrasenia
            If (DialogResult.OK = FrmContrasenia.ShowDialog()) Then
                If result = DialogResult.Yes Then
                    trabajoActual.Delete()
                    TipotrabajoTableAdapter.Update(BecharaDataSet)
                    TipotrabajoTableAdapter.Fill(BecharaDataSet.tipotrabajo)

                End If



            End If
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar, existen trabajos realizados con este tipo de trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TipotrabajoTableAdapter.Fill(BecharaDataSet.tipotrabajo)
        End Try
        FrmContrasenia.Dispose()
    End Sub
End Class