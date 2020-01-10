Imports MySql.Data.MySqlClient
Imports System.Data
Public Class buscar_alumno

    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim row As DataRow = Buscar(TextBox1.Text)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                Return
            End If
            TextBox2.Text = Convert.ToString(row("idalumno"))
            TextBox3.Text = Convert.ToString(row("nomalumno"))
            TextBox4.Text = Convert.ToString(row("apaternoalumno"))
            TextBox5.Text = Convert.ToString(row("amaternoalumno"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        numeross(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        numeross(e)
    End Sub
End Class