Module numeros
    'funcion para recibir solo numeros'
    'en el form solo selecciono de la parte de arriba el textbox'
    'en el cual deseo que sean ingresados los numeros y tambien selecciono el key press'
    'bajo este pongo numeross(e)'
    Public Sub numeross(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module
