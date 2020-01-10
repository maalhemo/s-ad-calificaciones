Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class entero_clase
    Private _adaptador As New MySqlDataAdapter
    Public Function insertarDatos(ByVal datos As class_cal) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO calificacion(idalumno,idmateria,tarea1,tarea2,tarea3,tarea4,tarea5,examen1,
tarea6,tarea7,tarea8,tarea9,tarea10,examen2,tarea11,tarea12,tarea13,tarea14,tarea15,examen3,
tarea16,tarea17,tarea18,tarea19,tarea20,examen4,tarea21,tarea22,tarea23,tarea24,tarea25,examen5,
extra1,extra2,extra3,extra4,extra5,extra6,extra7,extra8,extra9,extra10,extra11,extra12,extra13,extra14,extra15,califinal
)VALUES 
(@idalumno,@idmateria,@tarea1,@tarea2,@tarea3,@tarea4,@tarea5,@examen1,@tarea6,@tarea7,@tarea8,@tarea9,@tarea10,@examen2,
@tarea11,@tarea12,@tarea13,@tarea14,@tarea15,@examen3,@tarea16,@tarea17,@tarea18,@tarea19,@tarea20,@examen4,
@tarea21,@tarea22,@tarea23,@tarea24,@tarea25,@examen5,@extra1,@extra2,@extra3,@extra4,@extra5,@extra6,
@extra7,@extra8,@extra9,@extra10,@extra11,@extra12,@extra13,@extra14,@extra15,@califinal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@idalumno", MySqlDbType.Int16, 11).Value = datos.idalumno
            _adaptador.InsertCommand.Parameters.Add("@idmateria", MySqlDbType.Int16, 11).Value = datos.idmateria
            _adaptador.InsertCommand.Parameters.Add("@tarea1", MySqlDbType.Double).Value = datos.tarea1
            _adaptador.InsertCommand.Parameters.Add("@tarea2", MySqlDbType.Double).Value = datos.tarea2
            _adaptador.InsertCommand.Parameters.Add("@tarea3", MySqlDbType.Double).Value = datos.tarea3
            _adaptador.InsertCommand.Parameters.Add("@tarea4", MySqlDbType.Double).Value = datos.tarea4
            _adaptador.InsertCommand.Parameters.Add("@tarea5", MySqlDbType.Double).Value = datos.tarea5
            _adaptador.InsertCommand.Parameters.Add("@examen1", MySqlDbType.Double).Value = datos.examen1
            _adaptador.InsertCommand.Parameters.Add("@tarea6", MySqlDbType.Double).Value = datos.tarea6
            _adaptador.InsertCommand.Parameters.Add("@tarea7", MySqlDbType.Double).Value = datos.tarea7
            _adaptador.InsertCommand.Parameters.Add("@tarea8", MySqlDbType.Double).Value = datos.tarea8
            _adaptador.InsertCommand.Parameters.Add("@tarea9", MySqlDbType.Double).Value = datos.tarea9
            _adaptador.InsertCommand.Parameters.Add("@tarea10", MySqlDbType.Double).Value = datos.tarea10
            _adaptador.InsertCommand.Parameters.Add("@examen2", MySqlDbType.Double).Value = datos.examen2
            _adaptador.InsertCommand.Parameters.Add("@tarea11", MySqlDbType.Double).Value = datos.tarea11
            _adaptador.InsertCommand.Parameters.Add("@tarea12", MySqlDbType.Double).Value = datos.tarea12
            _adaptador.InsertCommand.Parameters.Add("@tarea13", MySqlDbType.Double).Value = datos.tarea13
            _adaptador.InsertCommand.Parameters.Add("@tarea14", MySqlDbType.Double).Value = datos.tarea14
            _adaptador.InsertCommand.Parameters.Add("@tarea15", MySqlDbType.Double).Value = datos.tarea15
            _adaptador.InsertCommand.Parameters.Add("@examen3", MySqlDbType.Double).Value = datos.examen3
            _adaptador.InsertCommand.Parameters.Add("@tarea16", MySqlDbType.Double).Value = datos.tarea16
            _adaptador.InsertCommand.Parameters.Add("@tarea17", MySqlDbType.Double).Value = datos.tarea17
            _adaptador.InsertCommand.Parameters.Add("@tarea18", MySqlDbType.Double).Value = datos.tarea18
            _adaptador.InsertCommand.Parameters.Add("@tarea19", MySqlDbType.Double).Value = datos.tarea19
            _adaptador.InsertCommand.Parameters.Add("@tarea20", MySqlDbType.Double).Value = datos.tarea20
            _adaptador.InsertCommand.Parameters.Add("@examen4", MySqlDbType.Double).Value = datos.examen4
            _adaptador.InsertCommand.Parameters.Add("@tarea21", MySqlDbType.Double).Value = datos.tarea21
            _adaptador.InsertCommand.Parameters.Add("@tarea22", MySqlDbType.Double).Value = datos.tarea22
            _adaptador.InsertCommand.Parameters.Add("@tarea23", MySqlDbType.Double).Value = datos.tarea23
            _adaptador.InsertCommand.Parameters.Add("@tarea24", MySqlDbType.Double).Value = datos.tarea24
            _adaptador.InsertCommand.Parameters.Add("@tarea25", MySqlDbType.Double).Value = datos.tarea25
            _adaptador.InsertCommand.Parameters.Add("@examen5", MySqlDbType.Double).Value = datos.examen5


            _adaptador.InsertCommand.Parameters.Add("@extra1", MySqlDbType.Double).Value = datos.extra1
            _adaptador.InsertCommand.Parameters.Add("@extra2", MySqlDbType.Double).Value = datos.extra2
            _adaptador.InsertCommand.Parameters.Add("@extra3", MySqlDbType.Double).Value = datos.extra3
            _adaptador.InsertCommand.Parameters.Add("@extra4", MySqlDbType.Double).Value = datos.extra4
            _adaptador.InsertCommand.Parameters.Add("@extra5", MySqlDbType.Double).Value = datos.extra5
            _adaptador.InsertCommand.Parameters.Add("@extra6", MySqlDbType.Double).Value = datos.extra6
            _adaptador.InsertCommand.Parameters.Add("@extra7", MySqlDbType.Double).Value = datos.extra7
            _adaptador.InsertCommand.Parameters.Add("@extra8", MySqlDbType.Double).Value = datos.extra8
            _adaptador.InsertCommand.Parameters.Add("@extra9", MySqlDbType.Double).Value = datos.extra9
            _adaptador.InsertCommand.Parameters.Add("@extra10", MySqlDbType.Double).Value = datos.extra10
            _adaptador.InsertCommand.Parameters.Add("@extra11", MySqlDbType.Double).Value = datos.extra11
            _adaptador.InsertCommand.Parameters.Add("@extra12", MySqlDbType.Double).Value = datos.extra12
            _adaptador.InsertCommand.Parameters.Add("@extra13", MySqlDbType.Double).Value = datos.extra13
            _adaptador.InsertCommand.Parameters.Add("@extra14", MySqlDbType.Double).Value = datos.extra14
            _adaptador.InsertCommand.Parameters.Add("@extra15", MySqlDbType.Double).Value = datos.extra15
            _adaptador.InsertCommand.Parameters.Add("@califinal", MySqlDbType.Double).Value = datos.califinal
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
    Public Function actualizarDatos(ByVal datos As class_cal) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.UpdateCommand = New MySqlCommand("update calificacion set idalumno=@idalumno,idmateria=@idmateria,
tarea1=@tarea1,tarea2=@tarea2,tarea3=@tarea3,tarea4=@tarea4,tarea5=@tarea5,examen1=@examen1,
tarea6=@tarea6,tarea7=@tarea7,tarea8=@tarea8,tarea9=@tarea9,tarea10=@tarea10,examen2=@examen2,
tarea11=@tarea11,tarea12=@tarea12,tarea13=@tarea13,tarea14=@tarea14,tarea15=@tarea15,examen3=@examen3,
tarea16=@tarea16,tarea17=@tarea17,tarea18=@tarea18,tarea19=@tarea19,tarea20=@tarea20,examen4=@examen4,
tarea21=@tarea21,tarea22=@tarea22,tarea23=@tarea23,tarea24=@tarea24,tarea25=@tarea25,examen5=@examen5,
extra1=@extra1,extra2=@extra2,extra3=@extra3,extra4=@extra4,extra5=@extra5,extra6=@extra6,extra7=@extra7,
extra8=@extra8,extra9=@extra9,extra10=@extra10,extra11=@extra11,extra12=@extra12,extra13=@extra13,extra14=@extra14,
extra15=@extra15,califinal=@califinal where idalumno=@idalumno", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idalumno", MySqlDbType.Int16).Value = datos.idalumno
            _adaptador.UpdateCommand.Parameters.Add("@idmateria", MySqlDbType.Int16).Value = datos.idmateria
            _adaptador.UpdateCommand.Parameters.Add("@tarea1", MySqlDbType.Double).Value = datos.tarea1
            _adaptador.UpdateCommand.Parameters.Add("@tarea2", MySqlDbType.Double).Value = datos.tarea2
            _adaptador.UpdateCommand.Parameters.Add("@tarea3", MySqlDbType.Double).Value = datos.tarea3
            _adaptador.UpdateCommand.Parameters.Add("@tarea4", MySqlDbType.Double).Value = datos.tarea4
            _adaptador.UpdateCommand.Parameters.Add("@tarea5", MySqlDbType.Double).Value = datos.tarea5
            _adaptador.UpdateCommand.Parameters.Add("@examen1", MySqlDbType.Double).Value = datos.examen1
            _adaptador.UpdateCommand.Parameters.Add("@tarea6", MySqlDbType.Double).Value = datos.tarea6
            _adaptador.UpdateCommand.Parameters.Add("@tarea7", MySqlDbType.Double).Value = datos.tarea7
            _adaptador.UpdateCommand.Parameters.Add("@tarea8", MySqlDbType.Double).Value = datos.tarea8
            _adaptador.UpdateCommand.Parameters.Add("@tarea9", MySqlDbType.Double).Value = datos.tarea9
            _adaptador.UpdateCommand.Parameters.Add("@tarea10", MySqlDbType.Double).Value = datos.tarea10
            _adaptador.UpdateCommand.Parameters.Add("@examen2", MySqlDbType.Double).Value = datos.examen2
            _adaptador.UpdateCommand.Parameters.Add("@tarea11", MySqlDbType.Double).Value = datos.tarea11
            _adaptador.UpdateCommand.Parameters.Add("@tarea12", MySqlDbType.Double).Value = datos.tarea12
            _adaptador.UpdateCommand.Parameters.Add("@tarea13", MySqlDbType.Double).Value = datos.tarea13
            _adaptador.UpdateCommand.Parameters.Add("@tarea14", MySqlDbType.Double).Value = datos.tarea14
            _adaptador.UpdateCommand.Parameters.Add("@tarea15", MySqlDbType.Double).Value = datos.tarea15
            _adaptador.UpdateCommand.Parameters.Add("@examen3", MySqlDbType.Double).Value = datos.examen3
            _adaptador.UpdateCommand.Parameters.Add("@tarea16", MySqlDbType.Double).Value = datos.tarea16
            _adaptador.UpdateCommand.Parameters.Add("@tarea17", MySqlDbType.Double).Value = datos.tarea17
            _adaptador.UpdateCommand.Parameters.Add("@tarea18", MySqlDbType.Double).Value = datos.tarea18
            _adaptador.UpdateCommand.Parameters.Add("@tarea19", MySqlDbType.Double).Value = datos.tarea19
            _adaptador.UpdateCommand.Parameters.Add("@tarea20", MySqlDbType.Double).Value = datos.tarea20
            _adaptador.UpdateCommand.Parameters.Add("@examen4", MySqlDbType.Double).Value = datos.examen4
            _adaptador.UpdateCommand.Parameters.Add("@tarea21", MySqlDbType.Double).Value = datos.tarea21
            _adaptador.UpdateCommand.Parameters.Add("@tarea22", MySqlDbType.Double).Value = datos.tarea22
            _adaptador.UpdateCommand.Parameters.Add("@tarea23", MySqlDbType.Double).Value = datos.tarea23
            _adaptador.UpdateCommand.Parameters.Add("@tarea24", MySqlDbType.Double).Value = datos.tarea24
            _adaptador.UpdateCommand.Parameters.Add("@tarea25", MySqlDbType.Double).Value = datos.tarea25
            _adaptador.UpdateCommand.Parameters.Add("@examen5", MySqlDbType.Double).Value = datos.examen5

            _adaptador.UpdateCommand.Parameters.Add("@extra1", MySqlDbType.Double).Value = datos.extra1
            _adaptador.UpdateCommand.Parameters.Add("@extra2", MySqlDbType.Double).Value = datos.extra2
            _adaptador.UpdateCommand.Parameters.Add("@extra3", MySqlDbType.Double).Value = datos.extra3
            _adaptador.UpdateCommand.Parameters.Add("@extra4", MySqlDbType.Double).Value = datos.extra4
            _adaptador.UpdateCommand.Parameters.Add("@extra5", MySqlDbType.Double).Value = datos.extra5
            _adaptador.UpdateCommand.Parameters.Add("@extra6", MySqlDbType.Double).Value = datos.extra6
            _adaptador.UpdateCommand.Parameters.Add("@extra7", MySqlDbType.Double).Value = datos.extra7
            _adaptador.UpdateCommand.Parameters.Add("@extra8", MySqlDbType.Double).Value = datos.extra8
            _adaptador.UpdateCommand.Parameters.Add("@extra9", MySqlDbType.Double).Value = datos.extra9
            _adaptador.UpdateCommand.Parameters.Add("@extra10", MySqlDbType.Double).Value = datos.extra10
            _adaptador.UpdateCommand.Parameters.Add("@extra11", MySqlDbType.Double).Value = datos.extra11
            _adaptador.UpdateCommand.Parameters.Add("@extra12", MySqlDbType.Double).Value = datos.extra12
            _adaptador.UpdateCommand.Parameters.Add("@extra13", MySqlDbType.Double).Value = datos.extra13
            _adaptador.UpdateCommand.Parameters.Add("@extra14", MySqlDbType.Double).Value = datos.extra14
            _adaptador.UpdateCommand.Parameters.Add("@extra15", MySqlDbType.Double).Value = datos.extra15
            _adaptador.UpdateCommand.Parameters.Add("@califinal", MySqlDbType.Double).Value = datos.califinal
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
    Public Function eliminarDatos(ByVal datos As class_cal) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from calificacion where idalumno=@idalumno", _conexion)
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
