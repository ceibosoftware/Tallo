Public Class FrmAgregarTurnos
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtnombreturno.Text) Or String.IsNullOrEmpty(txtapellidoturno.Text) Or String.IsNullOrEmpty(txtObservacionturno.Text) Or String.IsNullOrEmpty(dtpFechaTurno.Text) Or String.IsNullOrEmpty(txttelefonoturno.Text) Or String.IsNullOrEmpty(cmbhorarioturno.Text) Then

            Return False

        End If
        Return True

    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
        Me.Dispose()
    End Sub

    Private Sub txttelefonoturno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoturno.KeyPress
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

    Private Sub txtnombreturno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreturno.KeyPress
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

    Private Sub txtapellidoturno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidoturno.KeyPress
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

    Private Sub FrmAgregarTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnombreturno.Select()
        cmbhorarioturno.SelectedIndex = 1
        txttelefonoturno.MaxLength = 10
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