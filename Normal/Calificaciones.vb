Imports MySql.Data.MySqlClient
Public Class Calificaciones

    Dim nuevo As Boolean
    Dim adaptador As New MySqlDataAdapter
    Private CadenaConexion As String = "DataBase= normal; User Id=root; Password= mario; DataSource=localhost"

    Private Function Buscar(idalumno As String) As DataRow

        If (String.IsNullOrEmpty(idalumno)) Then
            Throw New ArgumentNullException("idalumno")
        End If

        Dim returnValue As DataRow = Nothing
        Using cnn As New MySqlConnection(CadenaConexion)
            Dim cmd As MySqlCommand = cnn.CreateCommand()

            cmd.CommandText = "SELECT * FROM calificacion WHERE idalumno=@idalumno"
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
    Private Function Buscar1(idalumno As String) As DataRow

        If (String.IsNullOrEmpty(idalumno)) Then
            Throw New ArgumentNullException("idalumno")
        End If

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
    Private Function Buscar2(idmateria As String) As DataRow

        If (String.IsNullOrEmpty(idmateria)) Then
            Throw New ArgumentNullException("idmateria")
        End If

        Dim returnValue As DataRow = Nothing
        Using cnn As New MySqlConnection(CadenaConexion)
            Dim cmd As MySqlCommand = cnn.CreateCommand()

            cmd.CommandText = "SELECT * FROM materia WHERE idmateria=@idmateria"
            cmd.Parameters.AddWithValue("@idmateria", idmateria)

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
        Alumno.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As New entero_clase
        Dim datos As New class_cal

        _dtsdatocalif.Reset()
        datos.idalumno = TextBox1.Text
        datos.idmateria = TextBox2.Text
        datos.tarea1 = TextBox3.Text
        datos.tarea2 = TextBox4.Text
        datos.tarea3 = TextBox5.Text
        datos.tarea4 = TextBox6.Text
        datos.tarea5 = TextBox7.Text
        datos.examen1 = TextBox8.Text
        datos.tarea6 = TextBox9.Text
        datos.tarea7 = TextBox10.Text
        datos.tarea8 = TextBox11.Text
        datos.tarea9 = TextBox12.Text
        datos.tarea10 = TextBox13.Text
        datos.examen2 = TextBox14.Text
        datos.tarea11 = TextBox15.Text
        datos.tarea12 = TextBox16.Text
        datos.tarea13 = TextBox17.Text
        datos.tarea14 = TextBox18.Text
        datos.tarea15 = TextBox19.Text
        datos.examen3 = TextBox20.Text
        datos.tarea16 = TextBox21.Text
        datos.tarea17 = TextBox22.Text
        datos.tarea18 = TextBox23.Text
        datos.tarea19 = TextBox24.Text
        datos.tarea20 = TextBox25.Text
        datos.examen4 = TextBox26.Text
        datos.tarea21 = TextBox27.Text
        datos.tarea22 = TextBox28.Text
        datos.tarea23 = TextBox29.Text
        datos.tarea24 = TextBox30.Text
        datos.tarea25 = TextBox31.Text
        datos.examen5 = TextBox32.Text

        datos.califinal = TextBox38.Text
        datos.extra1 = TextBox41.Text
        datos.extra2 = TextBox42.Text
        datos.extra3 = TextBox43.Text
        datos.extra4 = TextBox44.Text
        datos.extra5 = TextBox45.Text
        datos.extra6 = TextBox46.Text
        datos.extra7 = TextBox47.Text
        datos.extra8 = TextBox48.Text
        datos.extra9 = TextBox49.Text
        datos.extra10 = TextBox50.Text
        datos.extra11 = TextBox51.Text
        datos.extra12 = TextBox52.Text
        datos.extra13 = TextBox53.Text
        datos.extra14 = TextBox54.Text
        datos.extra15 = TextBox55.Text


        If nuevo Then
            If conexion.insertarDatos(datos) Then
                MessageBox.Show("datos guardados")
                consulta_califinal()

            Else
                MessageBox.Show("datos no guardados")
            End If
        Else
            datos.idalumno = TextBox1.Text
        End If

        If conexion.actualizarDatos(datos) Then
            MessageBox.Show("datos actualizados")
            consulta_califinal()

        Else
            MessageBox.Show("datos no actualizados")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim t3, t4, t5, t6, t7, t8, t41, t42, t43, t39, t40, t56, t57, t58 As Double

        _dtsdatocalif.Reset()

        t3 = TextBox3.Text
        t4 = TextBox4.Text
        t5 = TextBox5.Text
        t6 = TextBox6.Text
        t7 = TextBox7.Text
        t8 = TextBox8.Text
        t39 = TextBox39.Text
        t40 = TextBox40.Text
        t41 = TextBox41.Text
        t42 = TextBox42.Text
        t43 = TextBox43.Text
        t56 = TextBox56.Text
        t57 = TextBox57.Text
        t58 = TextBox58.Text
        TextBox33.Text = (((((t3 + t4 + t5 + t6 + t7) / 5) * (t39)) + (t8 * t40) + (t41 * t56) + (t42 * t57) + (t43 * t58)) / 10)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim t9, t10, t11, t12, t13, t14, t39, t40, t44, t45, t46, t56, t57, t58 As Double
        t9 = TextBox9.Text
        t10 = TextBox10.Text
        t11 = TextBox11.Text
        t12 = TextBox12.Text
        t13 = TextBox13.Text
        t14 = TextBox14.Text
        t39 = TextBox39.Text
        t40 = TextBox40.Text
        t44 = TextBox44.Text
        t45 = TextBox45.Text
        t46 = TextBox46.Text
        t56 = TextBox56.Text
        t57 = TextBox57.Text
        t58 = TextBox58.Text

        TextBox34.Text = (((((t9 + t10 + t11 + t12 + t13) / 5) * (t39)) + (t14 * t40) + (t44 * t56) + (t45 * t57) + (t46 * t58)) / 10)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim t15, t16, t17, t18, t19, t20, t39, t40, t47, t48, t49, t56, t57, t58 As Double
        t15 = TextBox9.Text
        t16 = TextBox10.Text
        t17 = TextBox11.Text
        t18 = TextBox12.Text
        t19 = TextBox13.Text
        t20 = TextBox14.Text
        t39 = TextBox39.Text
        t40 = TextBox40.Text
        t47 = TextBox47.Text
        t48 = TextBox48.Text
        t49 = TextBox49.Text
        t56 = TextBox56.Text
        t57 = TextBox57.Text
        t58 = TextBox58.Text

        TextBox35.Text = (((((t15 + t16 + t17 + t18 + t19) / 5) * (t39)) + (t20 * t40) + (t47 * t56) + (t48 * t57) + (t49 * t58)) / 10)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim t21, t22, t23, t24, t25, t26, t39, t40, t50, t51, t52, t56, t57, t58 As Double
        t21 = TextBox9.Text
        t22 = TextBox10.Text
        t23 = TextBox11.Text
        t24 = TextBox12.Text
        t25 = TextBox13.Text
        t26 = TextBox14.Text
        t39 = TextBox39.Text
        t40 = TextBox40.Text
        t50 = TextBox50.Text
        t51 = TextBox51.Text
        t52 = TextBox52.Text
        t56 = TextBox56.Text
        t57 = TextBox57.Text
        t58 = TextBox58.Text

        TextBox36.Text = (((((t21 + t22 + t23 + t24 + t25) / 5) * (t39)) + (t26 * t40) + (t50 * t56) + (t51 * t57) + (t52 * t58)) / 10)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim t27, t28, t29, t30, t31, t32, t39, t40, t53, t54, t55, t56, t57, t58 As Double
        t27 = TextBox27.Text
        t28 = TextBox28.Text
        t29 = TextBox29.Text
        t30 = TextBox30.Text
        t31 = TextBox31.Text
        t32 = TextBox32.Text
        t39 = TextBox39.Text
        t40 = TextBox40.Text
        t53 = TextBox53.Text
        t54 = TextBox54.Text
        t55 = TextBox55.Text
        t56 = TextBox56.Text
        t57 = TextBox57.Text
        t58 = TextBox58.Text

        TextBox37.Text = (((((t27 + t28 + t29 + t30 + t31) / 5) * (t39)) + (t32 * t40) + (t53 * t56) + (t54 * t57) + (t55 * t58)) / 10)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim t33, t34, t35, t36, t37 As Double
        t33 = TextBox33.Text
        t34 = TextBox34.Text
        t35 = TextBox35.Text
        t36 = TextBox36.Text
        t37 = TextBox37.Text


        TextBox38.Text = (t33 + t34 + t35 + t36 + t37) / 5
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        nuevo = True
        TextBox1.Focus()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        nuevo = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim conexion As New entero_clase
        Dim datos As New class_cal
        _dtsdatocalif.Reset()
        datos.idalumno = TextBox1.Text
        If conexion.eliminarDatos(datos) Then
            MessageBox.Show("datos eliminados")
            consulta_califinal()

        Else
            MessageBox.Show("datos no eliminados")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Vistacalificaciones.Show()
        Me.Hide()
    End Sub



    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim row As DataRow = Buscar(TextBox1.Text)

            If (row Is Nothing) Then
                MessageBox.Show("Id no tiene registro de calificaciones o no esta registrado.")

                Return
            End If

            TextBox2.Text = Convert.ToString(row("idmateria"))
            TextBox3.Text = Convert.ToString(row("tarea1"))
            TextBox4.Text = Convert.ToString(row("tarea2"))
            TextBox5.Text = Convert.ToString(row("tarea3"))
            TextBox6.Text = Convert.ToString(row("tarea4"))
            TextBox7.Text = Convert.ToString(row("tarea5"))
            TextBox8.Text = Convert.ToString(row("examen1"))
            TextBox9.Text = Convert.ToString(row("tarea6"))
            TextBox10.Text = Convert.ToString(row("tarea7"))
            TextBox11.Text = Convert.ToString(row("tarea8"))
            TextBox12.Text = Convert.ToString(row("tarea9"))
            TextBox13.Text = Convert.ToString(row("tarea10"))
            TextBox14.Text = Convert.ToString(row("examen2"))
            TextBox15.Text = Convert.ToString(row("tarea11"))
            TextBox16.Text = Convert.ToString(row("tarea12"))
            TextBox17.Text = Convert.ToString(row("tarea13"))
            TextBox18.Text = Convert.ToString(row("tarea14"))
            TextBox19.Text = Convert.ToString(row("tarea15"))
            TextBox20.Text = Convert.ToString(row("examen3"))
            TextBox21.Text = Convert.ToString(row("tarea16"))
            TextBox22.Text = Convert.ToString(row("tarea17"))
            TextBox23.Text = Convert.ToString(row("tarea18"))
            TextBox24.Text = Convert.ToString(row("tarea19"))
            TextBox25.Text = Convert.ToString(row("tarea20"))
            TextBox26.Text = Convert.ToString(row("examen4"))
            TextBox27.Text = Convert.ToString(row("tarea21"))
            TextBox28.Text = Convert.ToString(row("tarea22"))
            TextBox29.Text = Convert.ToString(row("tarea23"))
            TextBox30.Text = Convert.ToString(row("tarea24"))
            TextBox31.Text = Convert.ToString(row("tarea25"))
            TextBox32.Text = Convert.ToString(row("examen5"))
            TextBox38.Text = Convert.ToString(row("califinal"))
            TextBox41.Text = Convert.ToString(row("extra1"))
            TextBox42.Text = Convert.ToString(row("extra2"))
            TextBox43.Text = Convert.ToString(row("extra3"))
            TextBox44.Text = Convert.ToString(row("extra4"))
            TextBox45.Text = Convert.ToString(row("extra5"))
            TextBox46.Text = Convert.ToString(row("extra6"))
            TextBox47.Text = Convert.ToString(row("extra7"))
            TextBox48.Text = Convert.ToString(row("extra8"))
            TextBox49.Text = Convert.ToString(row("extra9"))
            TextBox50.Text = Convert.ToString(row("extra10"))
            TextBox51.Text = Convert.ToString(row("extra11"))
            TextBox52.Text = Convert.ToString(row("extra12"))
            TextBox53.Text = Convert.ToString(row("extra13"))
            TextBox54.Text = Convert.ToString(row("extra14"))
            TextBox55.Text = Convert.ToString(row("extra15"))


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Dim row As DataRow = Buscar1(TextBox1.Text)

            If (row Is Nothing) Then
                MessageBox.Show("No hay registros que coincidan con el ID especificado.")
                Return
            End If

            TextBox59.Text = Convert.ToString(row("nomalumno"))
            TextBox60.Text = Convert.ToString(row("apaternoalumno"))
            TextBox61.Text = Convert.ToString(row("amaternoalumno"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        numeross(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        numeross(e)
    End Sub
    Private Sub TextBox3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox3.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox4.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox5_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox5.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox6_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox6.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox7_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox7.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox8_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox8.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox9_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox9.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox10_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox10.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox11_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox11.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox12_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox12.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox13_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox13.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox14_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox14.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox15_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox15.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox16_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox16.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox17_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox17.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox17.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox18_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox18.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox18.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox19_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox19.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox19.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox20_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox20.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox20.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox21_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox21.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox21.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox22_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox22.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox22.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox23_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox23.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox23.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox24_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox24.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox24.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox25_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox25.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox25.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox26_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox26.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox26.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox27_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox27.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox27.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox28_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox28.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox28.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox29_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox29.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox30_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox30.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox30.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox31_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox31.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox31.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox32_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox32.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox32.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox33_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox33.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox33.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox34_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox34.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox34.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox35_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox35.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox35.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox36_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox36.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox36.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox37_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox37.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox37.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox38_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox38.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox38.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox39_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox39.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox39.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox40_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox40.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox40.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox41_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox41.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox41.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox42_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox42.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox42.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox43_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox43.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox43.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox44_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox44.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox44.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox45_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox45.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox45.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox46_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox46.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox46.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox47_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox47.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox47.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox48_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox48.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox48.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox49_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox49.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox49.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox50_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox50.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox50.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox51_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox51.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox51.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox52_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox52.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox52.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox53_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox53.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox53.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox54_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox54.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox54.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox55_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox55.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox55.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox56_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox56.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox56.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox57_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox57.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox57.Text & CChar(eventArgs.KeyChar))
    End Sub
    Private Sub TextBox58_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox58.KeyPress
        eventArgs.Handled = numydeci(eventArgs.KeyChar, TextBox58.Text & CChar(eventArgs.KeyChar))
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = ""
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = 0
        TextBox20.Text = 0
        TextBox21.Text = 0
        TextBox22.Text = 0
        TextBox23.Text = 0
        TextBox24.Text = 0
        TextBox25.Text = 0
        TextBox26.Text = 0
        TextBox27.Text = 0
        TextBox28.Text = 0
        TextBox29.Text = 0
        TextBox30.Text = 0
        TextBox31.Text = 0
        TextBox32.Text = 0
        TextBox33.Text = 0
        TextBox34.Text = 0
        TextBox35.Text = 0
        TextBox36.Text = 0
        TextBox37.Text = 0
        TextBox38.Text = 0
        TextBox39.Text = 0
        TextBox40.Text = 0

        TextBox41.Text = 0
        TextBox42.Text = 0
        TextBox43.Text = 0
        TextBox44.Text = 0
        TextBox45.Text = 0
        TextBox46.Text = 0
        TextBox47.Text = 0
        TextBox48.Text = 0
        TextBox49.Text = 0
        TextBox50.Text = 0
        TextBox51.Text = 0
        TextBox52.Text = 0
        TextBox53.Text = 0
        TextBox54.Text = 0
        TextBox55.Text = 0
        TextBox56.Text = 0
        TextBox57.Text = 0
        TextBox58.Text = 0
        TextBox59.Text = ""
        TextBox60.Text = ""
        TextBox61.Text = ""
        TextBox62.Text = ""
        TextBox63.Text = ""
        TextBox64.Text = ""

    End Sub

    Private Sub Calificaciones_Load(sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consulta_califinal()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim row As DataRow = Buscar2(TextBox2.Text)

            If (row Is Nothing) Then
                MessageBox.Show("Hecho, puede hacer una nueva consulta o registro.")

                Return
            End If

            TextBox62.Text = Convert.ToString(row("nomateria"))
            TextBox63.Text = Convert.ToString(row("grado"))
            TextBox64.Text = Convert.ToString(row("semestre"))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class