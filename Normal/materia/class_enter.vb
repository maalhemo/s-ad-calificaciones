Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_enter
    Private _adaptador As New MySqlDataAdapter
    Public Function insertardatos(ByVal datos As class_materia) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO materia(idmateria,nomateria,grado,semestre,idprofesor)values(@idmateria,@nomateria,@grado,@semestre,@idprofesor)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria
            _adaptador.InsertCommand.Parameters.Add("@nomateria", MySqlDbType.VarChar, 45).Value = datos.nomateria
            _adaptador.InsertCommand.Parameters.Add("@grado", MySqlDbType.Int16, 11).Value = datos.grado
            _adaptador.InsertCommand.Parameters.Add("@semestre", MySqlDbType.Int16, 11).Value = datos.semestre
            _adaptador.InsertCommand.Parameters.Add("@idprofesor", MySqlDbType.Int16, 11).Value = datos.idprofesor

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
    Public Function actualizardatos(ByVal datos As class_materia) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.UpdateCommand = New MySqlCommand("update materia set idmateria=@idmateria,nomateria=@nomateria,grado=@grado,semestre=@semestre,idprofesor=@idprofesor where idmateria=@idmateria", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria
            _adaptador.UpdateCommand.Parameters.Add("@nomateria", MySqlDbType.VarChar, 45).Value = datos.nomateria
            _adaptador.UpdateCommand.Parameters.Add("@grado", MySqlDbType.Int16, 11).Value = datos.grado
            _adaptador.UpdateCommand.Parameters.Add("@semestre", MySqlDbType.Int16, 11).Value = datos.semestre
            _adaptador.UpdateCommand.Parameters.Add("@idprofesor", MySqlDbType.Int16, 11).Value = datos.idprofesor


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
    Public Function eliminardatos(ByVal datos As class_materia) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from materia where idmateria=@idmateria", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria
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
