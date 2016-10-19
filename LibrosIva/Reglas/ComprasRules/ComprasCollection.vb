Imports System.ComponentModel
Imports System.Text

Public Class ComprasCollection
    Inherits BindingList(Of CompraClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New CompraClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function

    Public Sub New()
        Me.TraerPersonas()
    End Sub

    Public Function TraerPersonas() As ComprasCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiCompra As CompraClass

        objBaseDatos.objTabla = "IvaCompras"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiCompra = New CompraClass

            MiCompra.Id = (dr("Id"))
            MiCompra.IdContribuyente = (dr("IdContribuyente"))
            MiCompra.nombre = (dr("Nombre"))
            MiCompra.categoriaIva = (dr("CategIva"))
            MiCompra.cuit = (dr("Cuit"))
            MiCompra.idComprobante = (dr("IdComprobante"))
            MiCompra.puntoVenta = (dr("PuntoVenta"))
            MiCompra.numeroComprobante = (dr("NumeroComprobante"))
            MiCompra.fechaEmision = (dr("FechaEmision"))
            MiCompra.fechaRegistro = (dr("FechaRegistro"))
            MiCompra.total = (dr("Total"))



            Me.Add(MiCompra)
        Next

        Return Me

    End Function

    Public Sub InsertarPersonas(ByVal MiCompra As CompraClass)


        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "IvaCompras"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdContribuyente")
        vSQL.Append(",Nombre")
        vSQL.Append(",CategIva")
        vSQL.Append(",Cuit")
        vSQL.Append(",IdComprobante")
        vSQL.Append(",PuntoVenta")
        vSQL.Append(",NumeroComprobante")
        vSQL.Append(",FechaEmision")
        vSQL.Append(",FechaRegistro")
        vSQL.Append(",Total)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiCompra.idContribuyente & "'")
        vSQL.Append(",'" & MiCompra.nombre & "'")
        vSQL.Append(",'" & MiCompra.categoriaIva & "'")
        vSQL.Append(",'" & MiCompra.cuit & "'")
        vSQL.Append(",'" & MiCompra.idComprobante & "'")
        vSQL.Append(",'" & MiCompra.puntoVenta & "'")
        vSQL.Append(",'" & MiCompra.numeroComprobante & "'")
        vSQL.Append(",'" & MiCompra.fechaEmision & "'")
        vSQL.Append(",'" & MiCompra.fechaRegistro & "'")
        vSQL.Append(",'" & MiCompra.total & "')")

        MiCompra.Id = objBaseDatos.Insertar(vSQL.ToString)

        Me.Add(MiCompra)

    End Sub

    Public Sub EliminarPersona(ByVal MiCompra As CompraClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "IvaCompras"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiCompra.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCompra)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiCompra.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarPersona(ByVal MiCompra As CompraClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "IvaCompras"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("IdContribuyente='" & MiCompra.IdContribuyente.ToString & "'")
        vSQL.Append(",Nombre='" & MiCompra.nombre & "'")
        vSQL.Append(",CategIva='" & MiCompra.categoriaIva.ToString & "'")
        vSQL.Append(",Cuit='" & MiCompra.cuit.ToString & "'")
        vSQL.Append(",IdComprobante='" & MiCompra.idComprobante.ToString & "'")
        vSQL.Append(",PuntoVenta='" & MiCompra.puntoVenta.ToString & "'")
        vSQL.Append(",NumeroComprobante='" & MiCompra.numeroComprobante.ToString & "'")
        vSQL.Append(",FechaEmision='" & MiCompra.fechaEmision.ToString & "'")
        vSQL.Append(",FechaRegistro='" & MiCompra.fechaRegistro.ToString & "'")
        vSQL.Append(",Total='" & MiCompra.total.ToString & "'")

        Dim resultado As Boolean
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiCompra.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCompra)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiCompra.Id)) = MiCompra
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub
End Class

