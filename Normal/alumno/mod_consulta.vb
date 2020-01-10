Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module mod_consulta
    Private _adaptador As New MySqlDataAdapter
    Public dtsdatos As New DataSet
    Public dtvdatos As New DataView

    Public Sub consulta_datos()
        Try
            conexion_global()
            _adaptador.SelectCommand = New MySqlCommand("select * from alumno", _conexion)
            _adaptador.Fill(dtsdatos)
            dtvdatos.Table = dtsdatos.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()

        End Try
    End Sub

End Module
