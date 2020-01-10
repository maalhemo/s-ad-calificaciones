Public Class class_prof
    Private _idprofesor As Integer
    Private _nomprofesor As String
    Private _contraseña As String

    Public Property idprofesor() As Integer
        Get
            Return _idprofesor

        End Get
        Set(ByVal value As Integer)
            _idprofesor = value
        End Set
    End Property

    Public Property nomprofesor() As String
        Get
            Return _nomprofesor

        End Get
        Set(ByVal value As String)
            _nomprofesor = value
        End Set
    End Property

    Public Property contraseña() As String
        Get
            Return _contraseña

        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property
End Class
