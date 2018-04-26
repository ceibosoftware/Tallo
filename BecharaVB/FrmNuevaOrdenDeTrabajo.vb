Imports MySql.Data.MySqlClient
Imports System.Drawing.Color


Public Class FrmNuevaOrdenDeTrabajo
    Public repuestosBechara As Boolean
    Dim sumaMano As Double = 0
    Dim combo(10) As ComboBox
    Dim textbox(10) As TextBox

    ' Dim restaMano As Double
    Public contador As Integer = 1
    Dim posicionX As Integer = 26
    Dim posicionY As Integer = 46
    Dim cLeft As Integer = 1
    Dim txtBox As New TextBox()
    Dim sql As String
    Dim adaptador As MySqlDataAdapter
    Dim clientes As DataSet
    Dim conexion As New MySqlConnection("data source =localhost;user id=root; password='';database ='bechara'")

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("No se pueden dejar en blanco los campos de precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub FrmNuevaOrdenDeTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.tipotrabajo' table. You can move, or remove it, as needed.
        Me.TipotrabajoTableAdapter.Fill(Me.BecharaDataSet.tipotrabajo)
        Dim conexion As New MySqlConnection("data source =localhost;user id=root; password='';database ='bechara'")
        'TODO: This line of code loads data into the 'BecharaDataSet.autos' table. You can move, or remove it, as needed.
        Me.AutosTableAdapter.Fill(Me.BecharaDataSet.autos)
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)

        txtRepuestos.Text = 0.ToString

        sql = "select * from clientes"
        adaptador = New MySqlDataAdapter(sql, conexion)
        clientes = New DataSet
        clientes.Tables.Add("clientes")
        adaptador.Fill(clientes.Tables("clientes"))
        ltsClientes.DataSource = ClientesBindingSource
        ltsClientes.DisplayMember = "nombre"
        ltsClientes.ValueMember = "idCliente"



    End Sub


    Private Sub ListBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ltsClientes.SelectedValueChanged
        Dim autos As New DataSet
        Dim sql As String = "select * from autos where autos.clientes_idCliente = @id"
        adaptador = New MySqlDataAdapter(sql, conexion)
        adaptador.SelectCommand.Parameters.AddWithValue("id", ltsClientes.SelectedValue)
        autos.Tables.Add("autos")
        adaptador.Fill(autos.Tables("autos"))
        ComboBox1.DataSource = autos.Tables("autos")
        ComboBox1.DisplayMember = "modelo"
        ComboBox1.ValueMember = "idAuto"
    End Sub

    Private Sub crearComboYtext()

        Try

            combo(contador) = New ComboBox
            posicionY += 40
            combo(contador).Location = New Point(posicionX, posicionY)
            combo(contador).Size() = New Size(121, 21)
            combo(contador).Visible = True
            combo(contador).Name = "cmbTipotrabajo" & contador
            tipotrabajo.Controls.Add(combo(contador))
            textbox(contador) = New TextBox
            textbox(contador).Location = New Point(txtPrecio.Left, posicionY)
            textbox(contador).Size() = New Size(100, 21)
            textbox(contador).Visible = True
            textbox(contador).Name = "txtPrecio" & contador
            tipotrabajo.Controls.Add(textbox(contador))

            AddHandler textbox(contador).TextChanged, AddressOf sumaManoObra
            AddHandler textbox(contador).KeyPress, AddressOf solonumero

        Catch ex As IndexOutOfRangeException
            MessageBox.Show("No se pueden agregar tantos tipos de trabajo")
            contador -= 1
        End Try


    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        crearComboYtext()

        Dim sql As String = "select * from tipotrabajo"
        Dim tipoTrabajo As DataSet = New DataSet
        adaptador = New MySqlDataAdapter(sql, conexion)
        tipoTrabajo.Tables.Add("tipotrabajo")
        adaptador.Fill(tipoTrabajo.Tables("tipotrabajo"))
        combo(contador).DataSource = tipoTrabajo.Tables("tipotrabajo")
        combo(contador).DisplayMember = "nombre"
        combo(contador).ValueMember = "idTipoTrabajo"

        contador += 1
    End Sub

    Private Sub btnElimTipo_Click(sender As Object, e As EventArgs) Handles btnElimTipo.Click
        Try
            tipotrabajo.Controls.Remove(textbox(contador - 1))
            tipotrabajo.Controls.Remove(combo(contador - 1))
            posicionY -= 40
            contador -= 1
            calcularManoObra()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Se debe tener al menos un trabajo realizado")

        End Try

    End Sub
    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        calcularManoObra()
    End Sub
    Private Sub sumaManoObra(sender As Object, e As EventArgs)
        calcularManoObra()

    End Sub


    Private Sub calcularManoObra()
        Dim precio As Double = 0
        For Each txt As TextBox In tipotrabajo.Controls.OfType(Of TextBox)
            If txt.Text <> "" Then
                precio += CDbl(txt.Text)
            End If
        Next
        txtManoObra.Text = precio.ToString
    End Sub



    Private Sub calcularTotal()
        Dim total As Double
        If txtManoObra.Text <> "" Then
            total += CDbl(txtManoObra.Text)
        End If
        If txtRepuestos.Text <> "" Then
            total += (CDbl(txtRepuestos.Text))
        End If
        txtTotal.Text = total.ToString
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub solonumero(sender As Object, e As KeyPressEventArgs)
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


    Private Sub txtRepuestos_TextChanged_1(sender As Object, e As EventArgs) Handles txtRepuestos.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtManoObra_TextChanged_1(sender As Object, e As EventArgs) Handles txtManoObra.TextChanged
        calcularTotal()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim cadena As String
        cadena = txtBuscar.Text.Trim
        If cadena.Length > 0 Then


            ClientesBindingSource.Filter = "nombre like '*" & cadena & "*' "

        Else
            ClientesBindingSource.Filter = ""
        End If
    End Sub

    Private Sub chkRepuestos_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepuestos.CheckedChanged
        If chkRepuestos.Checked Then
            txtRepuestos.ReadOnly = False
            repuestosBechara = True

        Else
            txtRepuestos.ReadOnly = True
            repuestosBechara = False
            txtRepuestos.Text = 0.ToString
        End If
    End Sub

    Private Sub txtRepuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepuestos.KeyPress
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

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
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

    Private Sub txtManoObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtManoObra.KeyPress
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

    Public Function idTipoTrabajo(index As Integer)
        Return combo(index).SelectedValue
    End Function

    Public Function idPrecio(index As Integer)
        Return textbox(index).Text
    End Function

    Private Function Valida() As Boolean

        For Each txt As TextBox In tipotrabajo.Controls.OfType(Of TextBox)

            If String.IsNullOrEmpty(txt.Text) Then

                Return False

            End If
        Next
        Return True


    End Function


End Class