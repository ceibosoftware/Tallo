﻿Public Class FrmModificarCliente
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtApellidoCliente.Text) Or String.IsNullOrEmpty(txtDireccionCliente.Text) Or String.IsNullOrEmpty(hola.Text) Or String.IsNullOrEmpty(txtDniCliente.Text) Or String.IsNullOrEmpty(txtTelefonoCliente.Text) Then

            Return False

        End If
        Return True

    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Me.Dispose()
        Close()
    End Sub

    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTelefonoCliente.MaxLength = 10
        hola.Select()
        txtDniCliente.MaxLength = 8
    End Sub





    Private Sub hola_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hola.KeyPress
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

    Private Sub txtApellidoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoCliente.KeyPress
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

    Private Sub txtDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDniCliente.KeyPress
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



    Private Sub txtTelefonoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoCliente.KeyPress
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