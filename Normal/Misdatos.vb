Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Misdatos
    Dim CONEXION As New MySqlConnection(" DataBase= normal; User Id=root; Password= mario; DataSource=localhost")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mprincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Vistacalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Intentar conectar a la DB.
            CONEXION.Open()
            Dim cmd As New MySqlCommand("Select materia.idmateria,nomateria,grado,semestre,profesor.idprofesor,nomprofesor from materia inner join profesor on materia.idprofesor=profesor.idprofesor", CONEXION)
            Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd
            DataGridView1.DataSource = bs
            drd.Close()
            CONEXION.Close()
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox y cerramos la aplicacion.
            MessageBox.Show("No se pudo conectar con la DB.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Materia.Show()
        Me.Hide()
    End Sub
End Class