Imports System.IO

Public Class ContribuyenteClass
    Dim provincias() As String = _
{"Ciudad Autónoma de Buenos Aires", _
"Buenos Aires", _
"Catamara", _
"Córdoba", _
"Corrientes", _
"Entre Ríos", _
"Jujuy", _
"Mendoza", _
"La Rioja", _
"Salta", _
"San Juan", _
"San Luis", _
"Santa Fe", _
"Santiago del Estero", _
"Tucumán", _
"Chaco", _
"Chubut", _
"Formosa", _
"Misiones", _
"Neuquén", _
"La Pampa", _
"Río Negro", _
"Santa Cruz", _
"Tierra del Fuego"}

    Dim Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Dim idPersona_ As Long
    Public Property idPersona() As Long
        Get
            Return idPersona_
        End Get
        Set(ByVal value As Long)
            idPersona_ = value
        End Set
    End Property

    Dim tipoDocumento_ As String
    Public Property tipoDocumento() As String
        Get
            Return tipoDocumento_
        End Get
        Set(ByVal value As String)
            tipoDocumento_ = value
        End Set
    End Property

    Dim numeroDocumento_ As Integer

    Public Property numeroDocumento() As Integer
        Get
            Return numeroDocumento_
        End Get
        Set(ByVal value As Integer)
            numeroDocumento_ = value
        End Set
    End Property

    Dim tipoPersona_ As String
    Public Property tipoPersona() As String
        Get
            Return tipoPersona_
        End Get
        Set(ByVal value As String)
            tipoPersona_ = value
        End Set
    End Property

    Dim tipoClave_ As String
    Public Property tipoClave() As String
        Get
            Return tipoClave_
        End Get
        Set(ByVal value As String)
            tipoClave_ = value
        End Set
    End Property

    Dim estadoClave_ As String
    Public Property estadoClave() As String
        Get
            Return estadoClave_
        End Get
        Set(ByVal value As String)
            estadoClave_ = value
        End Set
    End Property

    Dim nombre_ As String
    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Dim direccion_ As String
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Dim localidad_ As String
    Public Property localidad() As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property

    Dim idProvincia_ As Integer
    Public Property idProvincia() As Integer
        Get
            Return idProvincia_
        End Get
        Set(ByVal value As Integer)
            idProvincia_ = value
        End Set
    End Property

    Dim codPostal_ As Integer
    Public Property codPostal() As Integer
        Get
            Return codPostal_
        End Get
        Set(ByVal value As Integer)
            codPostal_ = value
        End Set
    End Property

    Dim idDependencia_ As Integer
    Public Property idDependencia() As Integer
        Get
            Return idDependencia_
        End Get
        Set(ByVal value As Integer)
            idDependencia_ = value
        End Set
    End Property

    Dim mesCierre_ As Integer
    Public Property mesCierre() As Integer
        Get
            Return mesCierre_
        End Get
        Set(ByVal value As Integer)
            mesCierre_ = value
        End Set
    End Property

    Dim fechaInscripcion_ As DateTime
    Public Property fechaInscripcion() As DateTime
        Get
            Return fechaInscripcion_
        End Get
        Set(ByVal value As DateTime)
            fechaInscripcion_ = value
        End Set
    End Property

    Dim nombreProvincia_ As String
    Public ReadOnly Property nombreProvincia() As String

        Get
            If idProvincia_ < 0 Then
                Return ""
            End If

            Return provincias(CInt(idProvincia_))
        End Get
    End Property

    Function listaCuits(ByVal dni As String) As Array

        'Para guardar la repuesta del AFIP
        Dim cRespuesta As String = ""

        Dim oPadron As Object

        'Para Consultar por DNI
        Dim cDNI_URL As String = "https://soa.afip.gob.ar/sr-padron/v2/personas/"

        If dni.Length < 8 Then
            MsgBox("LA LONGITUD DEL NUMERO DE DOCUMENTO NO ES CORRECTA.")
            Return listaCuits
        End If

        'Creo y Valido el Objeto oPadron
        oPadron = CreateObject("MSXML2.XMLHTTP")

        If oPadron Is Nothing Then
            MsgBox("NO SE PUDO CREAR EL OBJETO PADRON.")
            Return listaCuits
        End If

        'Llamo al Web Service del Afip
        Try
            oPadron.OPEN("GET", cDNI_URL + dni, False)
            oPadron.SEND()

        Catch
            MsgBox("EL SERVIDOR NO RESPONDE O NO HAY CONEXION A INTERNET." + vbCrLf + "NO SE PUEDE VALIDAR EL CUIT CON EL PADRON DE AFIP.")
            Return listaCuits

        End Try

        'Se recibe la repuesta en cRepuesta
        cRespuesta = oPadron.ResponseText()

        'Si el status es diferente a 200, ocurri¢ algún error de conectividad con el WS
        If oPadron.Status <> 200 Then
            MsgBox("*** ERROR ***;oPadron.Status = " + CStr(oPadron.Status) + " " + oPadron.StatusText)
            Return listaCuits
        End If

        'Grabo la Respuesta en un Archivo TXT, PARA poder Consultarla
        Dim objWriter As New StreamWriter(CurDir().Substring(0, CurDir().Length - 18) & "listaCuits.txt")
        objWriter.Write(cRespuesta)
        objWriter.Close()

        'Libero el objeto para que el Garbage Colector lo elimine completamente.
        oPadron = Nothing

        If jsonElement("success", cRespuesta) = "false" Then
            MsgBox(jsonElement("mensaje", cRespuesta))
            Return listaCuits
        End If

        Dim inicio, fin As Integer

        inicio = cRespuesta.IndexOf("[") + 1
        fin = cRespuesta.IndexOf("]")

        listaCuits = cRespuesta.Substring(inicio, fin - inicio).Split(",")

        'Retorno la lista de cuits obtenidos a partir de un dni.
        Return listaCuits

    End Function

    Public Sub datosCuit(ByVal cuit As String)

        Dim oPadron As Object

        'Para Consultar por CUIT
        Dim cCUIT_URL As String = "https://soa.afip.gob.ar/sr-padron/v2/persona/"

        'Guardo la repuesta del AFIP
        Dim cRespuesta As String = ""

        If cuit.Length <> 11 Then
            MsgBox("LA LONGITUD DEL NUMERO DE CUIT NO ES CORRECTA.")
            Return
        End If

        'Creo y Valido el Objeto oPadron
        oPadron = CreateObject("MSXML2.XMLHTTP")

        If oPadron Is Nothing Then
            MsgBox("NO SE PUDO CREAR EL OBJETO PADRON.")
            Return
        End If

        'Llamo al Web Service del Afip
        Try
            'Consulta por CUIT
            oPadron.OPEN("GET", cCUIT_URL + cuit, False)
            oPadron.SEND()

        Catch
            MsgBox("EL SERVIDOR NO RESPONDE O NO HAY CONEXION A INTERNET." + vbCrLf + "NO SE PUEDE VALIDAR EL CUIT CON EL PADRON DE AFIP.")
            Return

        End Try

        'Se recibe la repuesta en cRepuesta
        cRespuesta = oPadron.ResponseText()

        'Si el status es diferente a 200, ocurri¢ algún error de conectividad con el WS
        If oPadron.Status <> 200 Then
            MsgBox("*** ERROR ***;oPadron.Status = " + CStr(oPadron.Status) + " " + oPadron.StatusText)
            Return
        End If

        'Grabo la Respuesta en un Archivo TXT, PARA poder Consultarla
        Dim objWriter As New StreamWriter(CurDir().Substring(0, CurDir().Length - 18) & "datosCuit.txt")
        objWriter.Write(cRespuesta)
        objWriter.Close()

        'Libero el objeto para que el Garbage Colector lo elimine completamente.
        oPadron = Nothing

        Dim nro As String

        idPersona_ = CLng(jsonElement("idPersona", cRespuesta))
        tipoDocumento_ = jsonElement("tipoDocumento", cRespuesta)
        numeroDocumento_ = CInt(jsonElement("numeroDocumento", cRespuesta))
        tipoPersona_ = jsonElement("tipoPersona", cRespuesta)
        tipoClave_ = jsonElement("tipoClave", cRespuesta)
        estadoClave_ = jsonElement("estadoClave", cRespuesta)
        nombre_ = jsonElement("nombre", cRespuesta)
        direccion_ = jsonElement("direccion", cRespuesta)
        localidad_ = jsonElement("localidad", cRespuesta)

        nro = jsonElement("idProvincia", cRespuesta)
        If nro <> "" Then
            idProvincia_ = CInt(nro)
        End If

        nro = jsonElement("codPostal", cRespuesta)
        If nro <> "" Then
            codPostal_ = CInt(nro)
        End If

        nro = jsonElement("idDependencia", cRespuesta)
        If nro <> "" Then
            idDependencia_ = CInt(nro)
        End If

        nro = jsonElement("mesCierre", cRespuesta)
        If nro <> "" Then
            mesCierre_ = CInt(nro)
        End If

        nro = jsonElement("fechaInscripcion", cRespuesta)
        If nro <> "" Then
            fechaInscripcion_ = CDate(nro)
        End If

    End Sub

    Private Function jsonElement(ByVal elemento As String, ByVal json As String) As String

        Dim valor As String = ""
        Dim inicio, fin As Integer
        Dim busca As Integer

        busca = json.IndexOf(elemento)

        If busca = -1 Then Return valor

        inicio = busca + elemento.Length + 2

        Dim x As Integer
        Dim car As Char

        'Ubico el primer caracter del valor descartando comienzo de json y comienzo array
        For x = inicio To json.Length - 1
            car = json.Substring(x, 1)

            If car <> Chr(34) And car <> "{" And car <> "[" Then
                inicio = x
                Exit For
            End If
        Next

        'Ubico el último caracter del valor.
        For x = inicio To json.Length - 1
            car = json.Substring(x, 1)

            If car = Chr(34) Or car = "," Or car = "]" Or car = "}" Then
                fin = x - 1
                Exit For
            End If
        Next

        valor = json.Substring(inicio, fin - inicio + 1)

        Return valor

    End Function
End Class
