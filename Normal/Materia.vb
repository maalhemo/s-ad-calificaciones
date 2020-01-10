Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Materia
    Dim nuevo As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mprincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Materia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta_materias()
        DataGridView1.DataSource = _dtvdatos

    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            TextBox4.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nuevo = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nuevo = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim conexion As New class_enter
        Dim datos As New class_materia
        _dtsdatos.Reset()
        datos.idmateria = TextBox1.Text
        If conexion.eliminardatos(datos) Then
            MessageBox.Show("datos eliminados")
            consulta_materias()
            DataGridView1.DataSource = _dtvdatos
        Else
            MessageBox.Show("datos no eliminados")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim conexion As New class_enter
        Dim datos As New class_materia
        _dtsdatos.Reset()
        datos.idmateria = TextBox1.Text
        datos.nomateria = TextBox2.Text
        datos.grado = TextBox3.Text
        datos.semestre = TextBox4.Text
        datos.idprofesor = TextBox5.Text

        If nuevo Then
            If conexion.insertardatos(datos) Then
                MessageBox.Show("datos guardados")
                consulta_materias()
                DataGridView1.DataSource = _dtvdatos
            Else
                MessageBox.Show("datos no guardados")
            End If
        Else
            datos.idmateria = TextBox1.Text

            If conexion.actualizardatos(datos) Then
                MessageBox.Show("datos actualizados")
                consulta_materias()
                DataGridView1.DataSource = _dtvdatos
            Else
                MessageBox.Show("datos no actualizados")
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Relacionprof_mate.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        letrass(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        numeross(e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        numeross(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        numeross(e)
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        numeross(e)
    End Sub
End Class