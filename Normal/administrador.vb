Public Class administrador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "superadministrador" And TextBox2.Text = "adminnormal1207" Then
            admin.Show()
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else MsgBox("Datos incorrectos", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("revise su manual de usuario, o envie un correo a: the_poudle@hotmail.com")
    End Sub
End Class