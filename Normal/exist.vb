Imports MySql.Data.MySqlClient
Module exist
    Public Function Existe(ByVal idalumno As Integer) As Boolean
        Using conn As New MySqlConnection("DataBase= normal; User Id=root; Password= mario; DataSource=localhost")
            Dim query = "SELECT COUNT(*) FROM alumno WHERE Idalumno=@Idalumno"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Idalumno", idalumno)
            conn.Open()

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                Return False
            Else
                Return True
            End If
        End Using
    End Function
End Module
