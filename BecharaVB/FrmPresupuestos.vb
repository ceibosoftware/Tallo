Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmPresupuestos
    Dim presupuestoActual As DataRowView


    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub FrmPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.presupuesto' table. You can move, or remove it, as needed.
        Me.PresupuestoTableAdapter.Fill(Me.BecharaDataSet.presupuesto)

        EliminarFechas()

    End Sub

    Private Sub PresupuestoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellContentClick

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarPresupuesto.ShowDialog()) Then
            Dim nuevoPresupuesto As DataRowView
            nuevoPresupuesto = PresupuestoBindingSource.AddNew()

            'AGREGA PRESUPUESTO

            nuevoPresupuesto("nombre") = FrmAgregarPresupuesto.txtNombre.Text
            nuevoPresupuesto("apellido") = FrmAgregarPresupuesto.txtApellido.Text
            nuevoPresupuesto("direccion") = FrmAgregarPresupuesto.txtDireccion.Text
            nuevoPresupuesto("patente") = FrmAgregarPresupuesto.txtPatente.Text
            nuevoPresupuesto("marca") = FrmAgregarPresupuesto.txtMarca.Text
            nuevoPresupuesto("modelo") = FrmAgregarPresupuesto.txtModelo.Text
            nuevoPresupuesto("kilometraje") = FrmAgregarPresupuesto.txtKilometros.Text
            nuevoPresupuesto("combustible") = FrmAgregarPresupuesto.cmbCombustible.Text
            nuevoPresupuesto("observaciones") = FrmAgregarPresupuesto.txtObservacion.Text
            nuevoPresupuesto("fechaCaducidad") = FrmAgregarPresupuesto.dtpCaducidad.Value
            nuevoPresupuesto("precioTotal") = FrmAgregarPresupuesto.txtPrecioFinal.Text
            nuevoPresupuesto("precioManoObra") = FrmAgregarPresupuesto.txtPrecioManoObra.Text
            nuevoPresupuesto("precioRespuesto") = FrmAgregarPresupuesto.txtPrecioRepuestos.Text


            nuevoPresupuesto.EndEdit()
            PresupuestoTableAdapter.Update(BecharaDataSet)
            PresupuestoTableAdapter.Fill(BecharaDataSet.presupuesto)
            FrmAgregarPresupuesto.Dispose()
        End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click

        'ELIMINA PRESUPUESTO
        Try
            presupuestoActual = PresupuestoBindingSource.Current

            Dim result As Integer = MessageBox.Show("¿Está seguro de eliminar el presupuesto de  " + presupuestoActual("nombre") + " " + presupuestoActual("apellido") + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then


                presupuestoActual.Delete()
                PresupuestoTableAdapter.Update(BecharaDataSet.presupuesto)
                PresupuestoTableAdapter.Fill(BecharaDataSet.presupuesto)

            ElseIf result = DialogResult.No Then

            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


    Private Sub EliminarFechas()


        'ELIMINAR PRESUPUESTOS AUTOMATICAMENTE
        ' Dim contadorPresupuestosEliminados As Integer = 0



        For id = 0 To PresupuestoDataGridView.RowCount

            presupuestoActual = PresupuestoBindingSource.Current
            '    Dim id = presupuestoActual("idPresupuesto")
            Dim i As Integer
            If (Not IsNothing(presupuestoActual)) Then


                Dim fechaActual = presupuestoActual("fechaCaducidad")
                Dim fechaReal As Date = Now
                Dim result As Integer = DateTime.Compare(fechaActual, fechaReal)
                Dim relationship As String

                If result < 0 Then
                    relationship = "se vencio el presupuesto y se elimina"
                    presupuestoActual.Delete()
                    '  contadorPresupuestosEliminados = contadorPresupuestosEliminados + 1

                Else
                    relationship = "presupuesto esta en tiempo"
                    PresupuestoBindingSource.MoveNext()

                End If

                Console.WriteLine("" + fechaActual + "; " + relationship)
            End If
        Next

        PresupuestoTableAdapter.Update(BecharaDataSet.presupuesto)
        PresupuestoTableAdapter.Fill(BecharaDataSet.presupuesto)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try
            'MODIFICA PRESUPUESTO
            Dim presupuesto As DataRowView = PresupuestoBindingSource.Current

            FrmModificarPresupuesto.txtNombre.Text = presupuesto("nombre")
            FrmModificarPresupuesto.txtApellido.Text = presupuesto("apellido")
            FrmModificarPresupuesto.txtDni.Text = presupuesto("direccion")
            FrmModificarPresupuesto.txtPatente.Text = presupuesto("patente")
            FrmModificarPresupuesto.txtMarca.Text = presupuesto("marca")
            FrmModificarPresupuesto.txtModelo.Text = presupuesto("modelo")
            FrmModificarPresupuesto.txtKilometros.Text = presupuesto("kilometraje")
            FrmModificarPresupuesto.cmbCombustible.Text = presupuesto("combustible")
            FrmModificarPresupuesto.txtObservacion.Text = presupuesto("observaciones")
            FrmModificarPresupuesto.dtpCaducidad.Value = presupuesto("fechaCaducidad")
            FrmModificarPresupuesto.txtPrecioFinal.Text = presupuesto("precioTotal")
            FrmModificarPresupuesto.txtPrecioManoObra.Text = presupuesto("precioManoObra")
            FrmModificarPresupuesto.txtPrecioRepuestos.Text = presupuesto("precioRespuesto")


            If (DialogResult.OK = FrmModificarPresupuesto.ShowDialog()) Then



                presupuesto("nombre") = FrmModificarPresupuesto.txtNombre.Text
                presupuesto("apellido") = FrmModificarPresupuesto.txtApellido.Text
                presupuesto("direccion") = FrmModificarPresupuesto.txtDni.Text
                presupuesto("patente") = FrmModificarPresupuesto.txtPatente.Text
                presupuesto("marca") = FrmModificarPresupuesto.txtMarca.Text
                presupuesto("modelo") = FrmModificarPresupuesto.txtModelo.Text
                presupuesto("kilometraje") = FrmModificarPresupuesto.txtKilometros.Text
                presupuesto("combustible") = FrmModificarPresupuesto.cmbCombustible.Text
                presupuesto("observaciones") = FrmModificarPresupuesto.txtObservacion.Text
                presupuesto("fechaCaducidad") = FrmModificarPresupuesto.dtpCaducidad.Value
                presupuesto("precioTotal") = FrmModificarPresupuesto.txtPrecioFinal.Text
                presupuesto("precioManoObra") = FrmModificarPresupuesto.txtPrecioManoObra.Text
                presupuesto("precioRespuesto") = FrmModificarPresupuesto.txtPrecioRepuestos.Text

                presupuesto.EndEdit()
                PresupuestoTableAdapter.Update(BecharaDataSet)
                PresupuestoTableAdapter.Fill(BecharaDataSet.presupuesto)
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("No hay regístros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        'CREACION DEL PDF
        Dim presupuesto As DataRowView = PresupuestoBindingSource.Current

        If Not IsNothing(presupuesto) Then
            Dim SaveFileDialog1 = New SaveFileDialog()
            Dim OpenFileDialog1 = New OpenFileDialog()
            SaveFileDialog1.DefaultExt = "pdf"
            If SaveFileDialog1.ShowDialog = Me.DialogResult.OK Then
                Try
                    Dim DOCUMENTO As New Document

                    Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                    DOCUMENTO.Open()


                    Dim objImagePdf As Image


                    ' Crea la imagen
                    '   objImagePdf = Image.GetInstance("C:\3.jpg")
                    'Cambia el tamaño de la imagen
                    '   objImagePdf.ScaleToFit(500, 500)
                    ' Se indica que la imagen debe almacenarse como fondo
                    ' objImagePdf.Alignment = iTextSharp.text.Image.UNDERLYING
                    ' Coloca la imagen en una posición absoluta
                    'objImagePdf.SetAbsolutePosition(80, 280)

                    ' Imprime la imagen como fondo de página

                    ' DOCUMENTO.Add(objImagePdf)

                    'titulo
                    DOCUMENTO.Add(New Paragraph("PRESUPUESTO TALLER BECHARA"))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("-----------------------------------------------------------------------------"))
                    DOCUMENTO.Add(New Paragraph("Guiñazu 370 - Lujàn de Cuyo"))
                    DOCUMENTO.Add(New Paragraph("Horarios de Atencìon: Lunes a Viernes de 9:00 a 13:00hs y Sàbados de 9:00 a 13:00hs "))
                    DOCUMENTO.Add(New Paragraph("Teléfono: 2615934312"))
                    DOCUMENTO.Add(New Paragraph("-----------------------------------------------------------------------------"))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Fecha de Emisiòn: " + Now))
                    DOCUMENTO.Add(New Paragraph("Presupuesto vàlido hasta: " + presupuesto("fechaCaducidad").ToString))
                    DOCUMENTO.Add(New Paragraph("-----------------------------------------------------------------------------"))


                    'letra
                    Dim _standardFont As iTextSharp.text.Font = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                    Dim tblPrueba As PdfPTable = New PdfPTable(3)
                    tblPrueba.WidthPercentage = 100

                    'contenido
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Nombre: " + presupuesto("nombre").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Apellido: " + presupuesto("apellido").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Direcciòn: " + presupuesto("direccion").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Patente: " + presupuesto("patente").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Marca: " + presupuesto("marca").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Modelo: " + presupuesto("modelo").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Kilometraje: " + presupuesto("kilometraje").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Combustible: " + presupuesto("combustible").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("Trabajo a realizar: " + presupuesto("observaciones").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("-----------------------------------------------------------------------------"))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("PrecioTotal: $ " + presupuesto("precioTotal").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("PrecioManoObra: $ " + presupuesto("precioManoObra").ToString))
                    DOCUMENTO.Add(Chunk.NEWLINE)
                    DOCUMENTO.Add(New Paragraph("PrecioRespuesto: $" + presupuesto("precioRespuesto").ToString))
                    DOCUMENTO.Add(tblPrueba)

                    DOCUMENTO.Close()
                    MessageBox.Show("Se ha guardado el presupuesto.", "Èxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MessageBox.Show("No hay presupuestos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        End If

    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.A) Then
            FrmAgregarPresupuesto.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.M) Then
            FrmModificarPresupuesto.Show()
        End If
        If (modifiers.Equals(Keys.Control)) AndAlso key.Equals(Keys.E) Then
            button3.PerformClick()
        End If
        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        txtObservacion.Text = PresupuestoDataGridView.CurrentRow.Cells(11).Value.ToString
    End Sub

    Private Sub txtObservacion_TextChanged(sender As Object, e As EventArgs) Handles txtObservacion.TextChanged

    End Sub
End Class