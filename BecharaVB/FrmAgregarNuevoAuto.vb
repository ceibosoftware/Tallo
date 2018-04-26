Public Class FrmAgregarNuevoAuto


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK

        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtMarca.Text) Or String.IsNullOrEmpty(txtModelo.Text) Or String.IsNullOrEmpty(txtAnio.Text) Or String.IsNullOrEmpty(txtFiltroAceite.Text) Or String.IsNullOrEmpty(txtFiltroAire.Text) Or String.IsNullOrEmpty(txtFiltroCombustible.Text) Or String.IsNullOrEmpty(txtFiltroHabitaculo.Text) Or String.IsNullOrEmpty(txtAceiteMotor.Text) Or String.IsNullOrEmpty(txtKilometraje.Text) Or String.IsNullOrEmpty(txtCorrea.Text) Or String.IsNullOrEmpty(txtColor.Text) Or String.IsNullOrWhiteSpace(cmbTipoCombustible.SelectedItem) Then

            Return False

        End If
        Return True
    End Function
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
        Me.Dispose()
    End Sub

    Private Sub FrmAgregarNuevoAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)
        txtbuscar.Select()
        cmbTipoCombustible.SelectedIndex = 1
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            Dim cliente As DataRowView = ClientesBindingSource.Current
            AutosBindingSource.Filter = "clientes_idcliente = " & cliente("nombre")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilometraje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKilometraje.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim cadena As String
        cadena = txtbuscar.Text.Trim
        If cadena.Length > 0 Then


            ClientesBindingSource.Filter = "apellido like '*" & cadena & "*' "

        Else
            ClientesBindingSource.Filter = ""
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub listClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listClientes.SelectedIndexChanged
        Try
            Dim cliente As DataRowView = ClientesBindingSource.Current
            txtDni.Text = cliente("dni").ToString
        Catch ex As Exception

        End Try

    End Sub


End Class