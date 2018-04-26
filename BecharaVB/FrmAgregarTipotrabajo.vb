Public Class FrmAgregarTipotrabajo

    Private Sub FrmAgregarTipotrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Select()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar campo nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) Then

            Return False

        End If
        Return True

    End Function

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

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (key.Equals(Keys.Escape)) Then
            Me.Close()
        End If


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class