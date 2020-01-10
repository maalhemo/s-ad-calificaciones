Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_ente
    Private _adaptador As New MySqlDataAdapter
    Public Function insertarDatos(ByVal datos As class_prof) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO profesor(idprofesor,nomprofesor,contraseña)values(@idprofesor,@nomprofesor,@contraseña)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@idprofesor", MySqlDbType.Int16, 11).Value = datos.idprofesor
            _adaptador.InsertCommand.Parameters.Add("@nomprofesor", MySqlDbType.VarChar, 45).Value = datos.nomprofesor
            _adaptador.InsertCommand.Parameters.Add("@contraseña", MySqlDbType.VarChar, 45).Value = datos.contraseña


            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    Public Function actualizarDatos(ByVal datos As class_prof) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.UpdateCommand = New MySqlCommand("update profesor set idprofesor=@idprofesor,nomprofesor=@nomprofesor,contraseña=@contraseña, where idprofesor=@idprofesor", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idprofesor", MySqlDbType.Int16, 11).Value = datos.idprofesor
            _adaptador.UpdateCommand.Parameters.Add("@nomprofesor", MySqlDbType.VarChar, 45).Value = datos.nomprofesor
            _adaptador.UpdateCommand.Parameters.Add("@contraseña", MySqlDbType.VarChar, 45).Value = datos.contraseña


            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function
    Public Function eliminardatos(ByVal datos As class_prof) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from profesor where idprofesor=@idprofesor", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@idprofesor", MySqlDbType.Int16, 11).Value = datos.idprofesor
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

End Class
