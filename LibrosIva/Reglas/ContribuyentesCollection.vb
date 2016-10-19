Imports System.ComponentModel
Imports System.Text

Public Class ContribuyentesCollection

    Inherits BindingList(Of ContribuyenteClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New ContribuyenteClass

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
        Me.TraerContribuyentes()
    End Sub

    Public Function TraerContribuyentes() As ContribuyentesCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiPersona As ContribuyenteClass

        objBaseDatos.objTabla = "contribuyentes"
        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            MiPersona = New ContribuyenteClass

            MiPersona.Id = CInt(dr("Id"))
            MiPersona.idPersona = CLng(dr("IdPersona"))
            MiPersona.tipoDocumento = dr("TipoDocumento")
            MiPersona.numeroDocumento = CInt(dr("NumeroDocumento"))
            MiPersona.tipoPersona = dr("TipoPersona")
            MiPersona.tipoClave = dr("TipoClave")
            MiPersona.estadoClave = dr("EstadoClave")
            MiPersona.nombre = dr("Nombre")
            MiPersona.direccion = dr("Direccion")
            MiPersona.localidad = dr("Localidad")
            MiPersona.idProvincia = CInt(dr("IdProvincia"))
            MiPersona.codPostal = CInt(dr("CodigoPostal"))
            MiPersona.idDependencia = CInt(dr("IdDependencia"))
            MiPersona.mesCierre = CInt(dr("MesCierre"))
            MiPersona.fechaInscripcion = dr("FechaInscripcion")

            Me.Add(MiPersona)
        Next

        Return Me

    End Function

    Public Sub InsertarContribuyentes(ByVal MiPersona As ContribuyenteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base Contribuyentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "contribuyentes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(IdPersona")
        vSQL.Append(",TipoDocumento")
        vSQL.Append(",NumeroDocumento")
        vSQL.Append(",TipoPersona")
        vSQL.Append(",TipoClave")
        vSQL.Append(",EstadoClave")
        vSQL.Append(",Nombre")
        vSQL.Append(",Direccion")
        vSQL.Append(",Localidad")
        vSQL.Append(",IdProvincia")
        vSQL.Append(",CodigoPostal")
        vSQL.Append(",IdDependencia")
        vSQL.Append(",MesCierre")
        vSQL.Append(",FechaInscripcion)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiPersona.idPersona & "'")
        vSQL.Append(",'" & MiPersona.tipoDocumento & "'")
        vSQL.Append(",'" & MiPersona.numeroDocumento & "'")
        vSQL.Append(",'" & MiPersona.tipoPersona & "'")
        vSQL.Append(",'" & MiPersona.tipoClave & "'")
        vSQL.Append(",'" & MiPersona.estadoClave & "'")
        vSQL.Append(",'" & MiPersona.nombre & "'")
        vSQL.Append(",'" & MiPersona.direccion & "'")
        vSQL.Append(",'" & MiPersona.localidad & "'")
        vSQL.Append(",'" & MiPersona.idProvincia & "'")
        vSQL.Append(",'" & MiPersona.codPostal & "'")
        vSQL.Append(",'" & MiPersona.idDependencia & "'")
        vSQL.Append(",'" & MiPersona.mesCierre & "'")
        vSQL.Append(",'" & MiPersona.fechaInscripcion.ToString("s") & "')")

        'Agrego MiPersona en la tabla Contribuyentes.
        MiPersona.Id = objBaseDatos.Insertar(vSQL.ToString)

        'Agrego MiPersona en la colección actual.
        Me.Add(MiPersona)

    End Sub

    Public Sub EliminarPersona(ByVal MiPersona As ContribuyenteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base Contribuyentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "contribuyentes"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiPersona.Id)

        If resultado Then

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiPersona.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarPersona(ByVal MiPersona As ContribuyenteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base Contribuyentes.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "contribuyentes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("IdPersona='" & MiPersona.idPersona.ToString & "'")
        vSQL.Append(",TipoDocumento='" & MiPersona.tipoDocumento & "'")
        vSQL.Append(",NumeroDocumento='" & MiPersona.numeroDocumento.ToString & "'")
        vSQL.Append(",TipoPersona='" & MiPersona.tipoPersona & "'")
        vSQL.Append(",TipoClave='" & MiPersona.tipoClave & "'")
        vSQL.Append(",EstadoClave='" & MiPersona.estadoClave & "'")
        vSQL.Append(",Nombre='" & MiPersona.nombre & "'")
        vSQL.Append(",Direccion='" & MiPersona.direccion & "'")
        vSQL.Append(",Localidad='" & MiPersona.localidad & "'")
        vSQL.Append(",IdProvincia='" & MiPersona.idProvincia.ToString & "'")
        vSQL.Append(",CodigoPostal='" & MiPersona.codPostal.ToString & "'")
        vSQL.Append(",IdDependencia='" & MiPersona.idDependencia.ToString & "'")
        vSQL.Append(",MesCierre='" & MiPersona.mesCierre.ToString & "'")
        vSQL.Append(",FechaInscripcion='" & MiPersona.fechaInscripcion.ToString("s") & "'")

        'Actualizo la tabla Contribuyentes con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiPersona.Id)

        If resultado Then
            'El código a continuación sirve para localizar el ítem en la lista
            'en este caso un persona.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiPersona.Id)) = MiPersona
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub

End Class
