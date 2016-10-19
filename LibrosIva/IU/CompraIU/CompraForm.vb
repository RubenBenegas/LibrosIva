Imports System.IO

Public Class CompraForm

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

    Dim MiCompra As New CompraClass

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If TextBox1.Text <> "" Then
            MiCompra.Id = CInt(TextBox1.Text)
        End If

        If TextBox2.Text = "" Then

            MessageBox.Show("Debe ingresar datos")
            Exit Sub

        End If
        MiCompra.IdContribuyente = TextBox2.Text
        MiCompra.nombre = TextBox3.Text
        MiCompra.categoriaIva = ComboBox1.SelectedIndex
        MiCompra.cuit = TextBox4.Text
        MiCompra.idComprobante = TextBox5.Text
        MiCompra.puntoVenta = TextBox6.Text
        MiCompra.numeroComprobante = TextBox7.Text
        MiCompra.fechaEmision = TextBox8.Text
        MiCompra.fechaRegistro = TextBox9.Text
        MiCompra.total = TextBox10.Text

        Select Case operacion_

            Case "Alta"
                lstCompras.InsertarPersonas(MiCompra)

            Case "Elimina"
                lstCompras.EliminarPersona(MiCompra)

            Case "Modifica"
                lstCompras.ActualizarPersona(MiCompra)

                ComprasGrid.DataGridView1.RefreshEdit()

        End Select

        Me.Close()
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click

        Me.Close()

    End Sub

End Class