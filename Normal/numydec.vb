Module numydec
    'funcion para recibir solo numeros decimales'
    'en el form solo selecciono de la parte de arriba el textbox'
    'en el cual deseo que sean ingresados los numeros decimales y tambien selecciono el key press'
    'bajo este pongo numydeci(e)'

    Function numydeci(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            numydeci = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                numydeci = True
            ElseIf IsNumeric(Texto) = True Then
                numydeci = False
            ElseIf IsNumeric(Texto) = False Then
                numydeci = True
            End If
        End If
        Return numydeci
    End Function
End Module