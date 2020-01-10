Imports MySql.Data.MySqlClient
Imports System.Data
Public Class admin
    Dim nuevo As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As New class_ente
        Dim datos As New class_prof
        datos.idprofesor = TextBox1.Text
        datos.nomprofesor = TextBox2.Text
        datos.contraseña = TextBox3.Text



        If nuevo Then
            If conexion.insertarDatos(datos) Then
                MessageBox.Show("datos guardados")
                consulta_prof()
                DataGridView1.DataSource = _dtvdat
            Else
                MessageBox.Show("datos no guardados")
            End If
        Else
            datos.idprofesor = TextBox1.Text

            If conexion.actualizarDatos(datos) Then
                MessageBox.Show("datos actualizados")
                consulta_prof()
                DataGridView1.DataSource = _dtvdat
            Else
                MessageBox.Show("datos no actualizados")
            End If

        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As New class_ente
        Dim datos As New class_prof
        _dtsdat.Reset()
        datos.idprofesor = TextBox1.Text
        If conexion.eliminardatos(datos) Then
            MessageBox.Show("datos eliminados")
            consulta_prof()
            DataGridView1.DataSource = _dtvdat
        Else
            MessageBox.Show("datos no eliminados")
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta_prof()
        DataGridView1.DataSource = _dtvdat
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nuevo = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nuevo = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Materia.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        letrass(e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Mprincipal.Show()
        Me.Hide()
    End Sub
End Class