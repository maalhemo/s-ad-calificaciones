Imports MySql.Data.MySqlClient


Public Class Inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "server= localhost; Database=normal;  User Id=root ;Pwd=mario"
            conexion.Open()
            'MsgBox("conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT * FROM profesor WHERE nomprofesor='" + TextBox1.Text + "'AND contraseña='" + TextBox2.Text + "'"
        Dim r As MySqlDataReader
        r = comando.ExecuteReader
        If r.HasRows <> False Then
            r.Read()
            MsgBox(" Bienvenido ")
            Mprincipal.Show()
            Me.Hide()
        Else
            MsgBox("Error, Datos Incorrectos")
        End If

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conexion_global() Then
            MessageBox.Show("conectado")
        Else
            MessageBox.Show("no conectado")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        administrador.Show()
        Me.Hide()
    End Sub


End Class
