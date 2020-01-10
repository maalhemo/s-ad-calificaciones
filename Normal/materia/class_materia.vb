Public Class class_materia
    Private _idmateria As Integer
    Private _nomateria As String
    Private _grado As Integer
    Private _semestre As Integer
    Private _idprofesor As Integer

    Public Property idmateria() As Integer
        Get
            Return _idmateria

        End Get
        Set(ByVal value As Integer)
            _idmateria = value
        End Set
    End Property

    Public Property nomateria() As String
        Get
            Return _nomateria

        End Get
        Set(ByVal value As String)
            _nomateria = value
        End Set
    End Property

    Public Property grado() As Integer
        Get
            Return _grado

        End Get
        Set(ByVal value As Integer)
            _grado = value
        End Set
    End Property

    Public Property semestre() As Integer
        Get
            Return _semestre

        End Get
        Set(ByVal value As Integer)
            _semestre = value
        End Set
    End Property

    Public Property idprofesor() As Integer
        Get
            Return _idprofesor

        End Get
        Set(ByVal value As Integer)
            _idprofesor = value
        End Set
    End Property

End Class
