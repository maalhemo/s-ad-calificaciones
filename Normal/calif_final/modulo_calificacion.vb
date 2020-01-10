Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module modulo_calificacion
    Private _adaptador As New MySqlDataAdapter
    Public _dtsdatocalif As New DataSet
    Public _dtvdatocalif As New DataView

    Public Sub consulta_califinal()
        Try
            conexion_global()
            _adaptador.SelectCommand = New MySqlCommand("select * from calificacion", _conexion)
            _adaptador.Fill(_dtsdatocalif)
            _dtvdatocalif.Table = _dtsdatocalif.Tables(0)
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
