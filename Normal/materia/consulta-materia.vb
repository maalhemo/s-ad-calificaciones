Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module consulta_materia
    Private _adaptador As New MySqlDataAdapter
    Public _dtsdatos As New DataSet
    Public _dtvdatos As New DataView

    Public Sub consulta_materias()
        Try
            conexion_global()
            _adaptador.SelectCommand = New MySqlCommand("select * from materia", _conexion)
            _adaptador.Fill(_dtsdatos)
            _dtvdatos.Table = _dtsdatos.Tables(0)
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
