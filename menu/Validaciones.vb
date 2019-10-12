Module Validaciones

    '-----------------------------------------------------------------------------------------------------------------
    'Validar usuarios
    Public Function Validar_texto(ByVal tecla As Short) As Short
        'instr comparar cadenas
        If InStr("0123456789", Chr(tecla)) = 0 Then
            Validar_texto = 0
        Else
            Validar_texto = tecla
        End If
    End Function
    Public Function validar_clave(ByVal clave As String) As Boolean
        Dim may, min, num, ce, longitud As Boolean

        If clave.Length >= 8 Then
            For i As Integer = 0 To clave.Length - 1
                If Char.IsNumber(clave(i)) Then
                    num = True

                ElseIf Char.IsUpper(clave(i)) Then
                    may = True

                ElseIf Char.IsLower(clave(i)) Then
                    min = True

                Else
                    ce = True
                End If

            Next
            If num And may And min And ce Then
                Return True
            End If

        Else

            Return False

        End If

    End Function

    'Public Function cedula(ByVal cedulas As String) As Boolean
    '    Dim guion, letra As Boolean

    '    If cedulas.Length = 15 Then
    '        For i As Integer = 0 To cedulas.Length - 1
    '            If Char.IsUpper(cedulas(i)) Then
    '                letra = True
    '            End If

    '        Next
    '        If letra Then
    '            Return True
    '        End If
    '    Else
    '        Return False

    '    End If

    'End Function


End Module
