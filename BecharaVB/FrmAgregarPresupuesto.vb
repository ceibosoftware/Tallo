Public Class FrmAgregarPresupuesto


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtDireccion.Text) Or String.IsNullOrEmpty(txtDni.Text) Or String.IsNullOrEmpty(txtPatente.Text) Or String.IsNullOrEmpty(cmbCombustible.Text) Or String.IsNullOrEmpty(txtMarca.Text) Or String.IsNullOrEmpty(txtModelo.Text) Or String.IsNullOrEmpty(txtKilometros.Text) Or String.IsNullOrEmpty(txtObservacion.Text) Or String.IsNullOrEmpty(dtpCaducidad.Text) Or String.IsNullOrEmpty(txtPrecioManoObra.Text) Or String.IsNullOrEmpty(txtPrecioRepuestos.Text) Or String.IsNullOrEmpty(txtPrecioFinal.Text) Then

            Return False

        End If
        Return True

    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
        Me.Dispose()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
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

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
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

    Private Sub txtPrecioManoObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioManoObra.KeyPress
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

    Private Sub txtPrecioRepuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioRepuestos.KeyPress
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

    Private Sub txtPrecioFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioFinal.KeyPress
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

    Private Sub txtKilometros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKilometros.KeyPress
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

    Private Sub FrmAgregarPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Select()
        cmbCombustible.SelectedIndex = 1
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class