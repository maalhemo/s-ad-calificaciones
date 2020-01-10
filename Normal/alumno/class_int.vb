Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_int
    Private _adaptador As New MySqlDataAdapter
    Public Function insertarDatos(ByVal datos As class_datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO alumno(idalumno,nomalumno,apaternoalumno,amaternoalumno,idmateria)values(@idalumno,@nomalumno,@apaternoalumno,@amaternoalumno,@idmateria)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@idalumno", MySqlDbType.Int16, 11).Value = datos.idalumno
            _adaptador.InsertCommand.Parameters.Add("@nomalumno", MySqlDbType.VarChar, 45).Value = datos.nomalumno
            _adaptador.InsertCommand.Parameters.Add("@apaternoalumno", MySqlDbType.VarChar, 45).Value = datos.apaternoalumno
            _adaptador.InsertCommand.Parameters.Add("@amaternoalumno", MySqlDbType.VarChar, 45).Value = datos.amaternoalumno
            _adaptador.InsertCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria


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
    Public Function actualizarDatos(ByVal datos As class_datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.UpdateCommand = New MySqlCommand("update alumno set idalumno=@idalumno,nomalumno=@nomalumno,apaternoalumno=@apaternoalumno,amaternoalumno=@amaternoalumno,idmateria=@idmateria where idalumno=@idalumno", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idalumno", MySqlDbType.Int16, 11).Value = datos.idalumno
            _adaptador.UpdateCommand.Parameters.Add("@nomalumno", MySqlDbType.VarChar, 45).Value = datos.nomalumno
            _adaptador.UpdateCommand.Parameters.Add("@apaternoalumno", MySqlDbType.VarChar, 45).Value = datos.apaternoalumno
            _adaptador.UpdateCommand.Parameters.Add("@amaternoalumno", MySqlDbType.VarChar, 45).Value = datos.amaternoalumno
            _adaptador.UpdateCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria

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
    Public Function eliminarDatos(ByVal datos As class_datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from alumno where idalumno=@idalumno", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@idalumno", MySqlDbType.Int16).Value = datos.idalumno
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
