Imports MySql.Data.MySqlClient
Imports System.Data
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Alumno
    
    Dim datos As DataSet
    Dim nuevo As Boolean
    Dim adaptador As New MySqlDataAdapter
    Private CadenaConexion As String = "DataBase= normal; User Id=root; Password= mario; DataSource=localhost"

    Private Function Buscar(idalumno As String) As DataRow

        If (String.IsNullOrEmpty(idalumno)) Then
            Throw New ArgumentNullException("idalumno")
        End If

        ' Declaramos la variable que devolverá la función, que
        ' en principio indica que no existe ningún registro
        ' que coincida con el ID especificado.
        '
        Dim returnValue As DataRow = Nothing
        Using cnn As New MySqlConnection(CadenaConexion)
            Dim cmd As MySqlCommand = cnn.CreateCommand()

            cmd.CommandText = "SELECT * FROM alumno WHERE idalumno=@idalumno"
            cmd.Parameters.AddWithValue("@idalumno", idalumno)

            Dim da As New MySqlDataAdapter(cmd)
            Using dt As New DataTable()
                da.Fill(dt)

                If (dt.Rows.Count > 0) Then
                    returnValue = dt.Rows(0)
                End If

            End Using

        End Using
        Return returnValue

    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Calificaciones.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Mprincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        nuevo = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        nuevo = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New class_int
        Dim datos As New class_datos

        dtsdatos.Reset()
        datos.idalumno = TextBox1.Text
        datos.nomalumno = TextBox2.Text
        datos.apaternoalumno = TextBox3.Text
        datos.amaternoalumno = TextBox4.Text



        If nuevo Then
            If conexion.insertarDatos(datos) Then
                MessageBox.Show("datos guardados")
                consulta_datos()

            Else
                MessageBox.Show("datos no guardados")
            End If
        Else
            datos.idalumno = TextBox1.Text


        End If

        If conexion.actualizarDatos(datos) Then
            MessageBox.Show("datos actualizados")
            consulta_datos()

        Else
            MessageBox.Show("datos no actualizados")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As New class_int
        Dim datos As New class_datos
        dtsdatos.Reset()
        datos.idalumno = TextBox1.Text
        If conexion.eliminarDatos(datos) Then
            MessageBox.Show("datos eliminados")
            consulta_datos()

        Else
            MessageBox.Show("datos no eliminados")
        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ver_alumnos.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim row As DataRow = Buscar(TextBox1.Text)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")

                Return
            End If

            TextBox2.Text = Convert.ToString(row("nomalumno"))
            TextBox3.Text = Convert.ToString(row("apaternoalumno"))
            TextBox4.Text = Convert.ToString(row("amaternoalumno"))
            TextBox5.Text = Convert.ToString(row("idmateria"))
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        letrass(e)

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        letrass(e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        letrass(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        numeross(e)
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        numeross(e)
    End Sub

End Class