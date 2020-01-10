Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module conexion
    Public _cadena As String
    Public _conexion As New MySqlConnection
    Public Function conexion_global() As Boolean
        Dim estado As Boolean = True
        Try
            _cadena = ("DataBase= normal; User Id=root; Password= mario; DataSource=localhost")
            _conexion = New MySqlConnection(_cadena)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        End Try
        Return estado
    End Function
    Public Sub cerrar()
        _conexion.Close()
    End Sub
End Module


