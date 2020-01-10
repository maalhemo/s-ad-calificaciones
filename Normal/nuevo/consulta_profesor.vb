Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module consulta_profesor
    Private _adaptador As New MySqlDataAdapter
    Public _dtsdat As New DataSet
    Public _dtvdat As New DataView

    Public Sub consulta_prof()
        Try
            conexion_global()
            _adaptador.SelectCommand = New MySqlCommand("select * from profesor", _conexion)
            _adaptador.Fill(_dtsdat)
            _dtvdat.Table = _dtsdat.Tables(0)
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
