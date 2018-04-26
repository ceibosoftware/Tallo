Public Class FrmModificarAuto
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

    Private Sub FrmModificarAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)
        txtMarca.Select()
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

    Private Sub txtModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModelo.KeyPress
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


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class