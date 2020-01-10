Public Class class_datos
    Private _idalumno As Integer
    Private _nomalumno As String
    Private _apaternoalumno As String
    Private _amaternoalumno As String
    Private _idmateria As Integer
    Public Property idalumno() As Integer
        Get
            Return _idalumno

        End Get
        Set(ByVal value As Integer)
            _idalumno = value
        End Set
    End Property

    Public Property nomalumno() As String
        Get
            Return _nomalumno

        End Get
        Set(ByVal value As String)
            _nomalumno = value
        End Set
    End Property

    Public Property apaternoalumno() As String
        Get
            Return _apaternoalumno

        End Get
        Set(ByVal value As String)
            _apaternoalumno = value
        End Set
    End Property


    Public Property amaternoalumno() As String
        Get
            Return _amaternoalumno

        End Get
        Set(ByVal value As String)
            _amaternoalumno = value
        End Set
    End Property

    Public Property idmateria() As Integer
        Get
            Return _idmateria

        End Get
        Set(ByVal value As Integer)
            _idmateria = value
        End Set
    End Property
End Class
