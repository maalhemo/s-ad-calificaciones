Module letras
    'funcion para recibir solo letras'
    'en el form solo selecciono de la parte de arriba el textbox'
    'en el cual deseo que sean ingresados las letras y tambien selecciono el key press'
    'bajo este pongo letrass(e)'
    Public Sub letrass(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
End Module
