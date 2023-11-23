Public Class cProveedor
    Private Id_proveedor As Integer
    Private Nombre As String
    Private Nit As Integer
    Private Razon As String
    Private Direccion As String
    Private Ciudad As String
    Private Telfono As Integer
    Private Contacto As Integer
    Private Email As String
    Private Fecha_Mod As DateTime
    Private Fecha_Creac As DateTime

    Public Property _Id_proveedor As Integer
        Get
            Return Id_proveedor
        End Get
        Set(value As Integer)
            Id_proveedor = value
        End Set
    End Property

    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property _Nit As Integer
        Get
            Return Nit
        End Get
        Set(value As Integer)
            Nit = value
        End Set
    End Property

    Public Property _Razon As String
        Get
            Return Razon
        End Get
        Set(value As String)
            Razon = value
        End Set
    End Property

    Public Property _Direccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property _Ciudad As String
        Get
            Return Ciudad
        End Get
        Set(value As String)
            Ciudad = value
        End Set
    End Property

    Public Property _Telfono As Integer
        Get
            Return Telfono
        End Get
        Set(value As Integer)
            Telfono = value
        End Set
    End Property

    Public Property _Contacto As Integer
        Get
            Return Contacto
        End Get
        Set(value As Integer)
            Contacto = value
        End Set
    End Property

    Public Property _Email As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

    Public Property _Fecha_Mod As Date
        Get
            Return Fecha_Mod
        End Get
        Set(value As Date)
            Fecha_Mod = value
        End Set
    End Property

    Public Property _Fecha_Creac As Date
        Get
            Return Fecha_Creac
        End Get
        Set(value As Date)
            Fecha_Creac = value
        End Set
    End Property
End Class
