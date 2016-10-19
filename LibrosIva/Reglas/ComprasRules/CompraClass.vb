Public Class CompraClass

    Dim Id_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Dim idContribuyente_ As Integer

    Public Property IdContribuyente() As Integer
        Get
            Return idContribuyente_
        End Get
        Set(ByVal value As Integer)
            idContribuyente_ = value
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

    Dim categoriaIva_ As Integer
    Public Property categoriaIva() As Integer
        Get
            Return categoriaIva_
        End Get
        Set(ByVal value As Integer)
            categoriaIva_ = value
        End Set
    End Property

    Dim cuit_ As Integer
    Public Property cuit() As Integer
        Get
            Return cuit_
        End Get
        Set(ByVal value As Integer)
            cuit_ = value
        End Set
    End Property

    Dim idComprobante_ As Integer
    Public Property idComprobante() As Integer
        Get
            Return idComprobante_
        End Get
        Set(ByVal value As Integer)
            idComprobante_ = value
        End Set
    End Property

    Dim puntoVenta_ As Integer
    Public Property puntoVenta() As Integer
        Get
            Return puntoVenta_
        End Get
        Set(ByVal value As Integer)
            puntoVenta_ = value
        End Set
    End Property

    Dim numeroComprobante_ As Integer
    Public Property numeroComprobante() As Integer
        Get
            Return numeroComprobante_
        End Get
        Set(ByVal value As Integer)
            numeroComprobante_ = value
        End Set
    End Property

    Dim fechaEmision_ As Date
    Public Property fechaEmision() As Date
        Get
            Return fechaEmision_
        End Get
        Set(ByVal value As Date)
            fechaEmision_ = value
        End Set
    End Property

    Dim fechaRegistro_ As Date
    Public Property fechaRegistro() As Date
        Get
            Return fechaRegistro_
        End Get
        Set(ByVal value As Date)
            fechaRegistro_ = value
        End Set
    End Property

    Dim total_ As Decimal
    Public Property total() As Decimal
        Get
            Return total_
        End Get
        Set(ByVal value As Decimal)
            total_ = value
        End Set
    End Property

    Public ReadOnly Property nombreCateg() As String

        Get
            If categoriaIva_ < 0 Then
                Return ""
            End If

            Return categorias(CInt(categoriaIva_))
        End Get
    End Property

    Dim categorias() As String = _
    {"IVA Responsable Inscripto", _
    "IVA Responsable no Inscripto", _
    "IVA no Responsable"}
End Class
