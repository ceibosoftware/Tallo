Public Class FrmContrasenia
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If etContrasenia.Text = "mecanica2017" Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dispose()
        Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim modifiers As Keys = (keyData And Keys.Modifiers)
        Dim key As Keys = (keyData And Keys.KeyCode)
        If (key.Equals(Keys.Enter)) Then
            If etContrasenia.Text = "mecanica2017" Then
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FrmContrasenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etContrasenia.PasswordChar = "*"
        etContrasenia.Select()
    End Sub
End Class