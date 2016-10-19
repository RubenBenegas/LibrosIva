Public Class ContribuyenteForm
    Dim operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim MiContribuyente As New ContribuyenteClass

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If TextBox1.Text <> "" Then
            MiContribuyente.Id = CInt(TextBox1.Text)
        End If

        If TextBox2.Text = "" Then

            MessageBox.Show("Debe ingresar datos")
            Exit Sub

        End If
        MiContribuyente.numeroDocumento = TextBox2.Text
        MiContribuyente.idPersona = ComboBox1.SelectedItem
        MiContribuyente.tipoDocumento = TextBox3.Text
        MiContribuyente.tipoPersona = TextBox4.Text
        MiContribuyente.tipoClave = TextBox5.Text
        MiContribuyente.estadoClave = TextBox6.Text
        MiContribuyente.nombre = TextBox7.Text
        MiContribuyente.direccion = TextBox8.Text
        MiContribuyente.localidad = TextBox9.Text
        MiContribuyente.idProvincia = ComboBox2.SelectedIndex
        MiContribuyente.codPostal = TextBox10.Text
        MiContribuyente.idDependencia = TextBox11.Text
        MiContribuyente.mesCierre = TextBox12.Text
        MiContribuyente.fechaInscripcion = CDate(TextBox13.Text)

        Select Case operacion_

            Case "Alta"
                lst.InsertarContribuyentes(MiContribuyente)
                'lst.Add(MiContribuyente)
            Case "Elimina"
                lst.EliminarContribuyente(MiContribuyente)
                'lst.RemoveAt(indice_)
            Case "Modifica"
                lst.ActualizarPersona(MiContribuyente)
                ContribuyentesGrid.DataGridView1.RefreshEdit()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()

    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click

        ComboBox1.DataSource = MiContribuyente.listaCuits(TextBox2.Text)

        If ComboBox1.Items.Count = 1 Then
            llenarForm()
        End If
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        llenarForm()
    End Sub

    Private Sub llenarForm()

        MiContribuyente.datosCuit(ComboBox1.SelectedItem.ToString)

        TextBox2.Text = MiContribuyente.numeroDocumento
        ComboBox1.SelectedItem = MiContribuyente.idPersona
        TextBox3.Text = MiContribuyente.tipoDocumento
        TextBox4.Text = MiContribuyente.tipoPersona
        TextBox5.Text = MiContribuyente.tipoClave
        TextBox6.Text = MiContribuyente.estadoClave
        TextBox7.Text = MiContribuyente.nombre
        TextBox8.Text = MiContribuyente.direccion
        TextBox9.Text = MiContribuyente.localidad

        If MiContribuyente.idProvincia > 0 Then
            ComboBox2.SelectedIndex = CInt(MiContribuyente.idProvincia)
        End If

        TextBox10.Text = MiContribuyente.codPostal
        TextBox11.Text = MiContribuyente.idDependencia
        TextBox12.Text = MiContribuyente.mesCierre
        TextBox13.Text = MiContribuyente.fechaInscripcion


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class