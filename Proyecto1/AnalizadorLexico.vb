
Public Class AnalizadorLexico
    'CONTROL DE TRANSICIONES
    Dim estado As Integer

    'CONTROL DE TOKEN
    Dim caracter As Char
    Dim tipoCaracter As Integer
    Dim lexema As String
    Dim token As String
    Dim id As Integer
    Dim color As String
    Dim tokenReconocido As New Token

    'CONTROL DE DEBUGGER
    Dim origenEstado As String
    Dim destinoEstado As String
    Dim detalleEstado As String
    Dim debugger As New Bitacora

    'CONTROL DE ERRORES
    Dim fila As Integer
    Dim columna As Integer
    Dim setDatos As New SetDatos()
    Dim errorEncontrado As New Errores

    Public Sub analizar(texto As String)
        estado = 0
        fila = 1
        columna = 1
        texto = texto + "#"
        ListaToken.listaToken.Clear()
        ListaError.listaError.Clear()
        ListaBitacora.listaBitacora.Clear()
        For i As Integer = 0 To texto.Length - 1 Step 1
            caracter = texto.Chars(i)
            tipoCaracter = get_TipoCaracter(caracter)
            Select Case estado
                Case 0 'A
                    Select Case tipoCaracter
                        Case 1 ' ABRIR LLAVE -> E
                            lexema = caracter
                            token = "APERTURA LLAVE"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 2 ' CERRAR LLAVE - E
                            lexema = caracter
                            token = "CIERRE LLAVE"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 3 ' ABRIR CORCHETES -> E
                            lexema = caracter
                            token = "APERTURA CORCHETE"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 4 ' CERRAR CORCHETES -> E
                            lexema = caracter
                            token = "CIERRE CORCHETE"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 6 ' [0-9] -> D
                            lexema = caracter
                            token = "DIGITO"
                            id = tipoCaracter
                            color = "blue"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 7 ' COMILLA -> B
                            lexema = caracter
                            token = "COMENTARIO"
                            id = tipoCaracter
                            color = "red"
                            estado = 1
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "B"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 8 ' COMILLAS -> C
                            lexema = caracter
                            estado = 2
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "C"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 9 ' DOS PUNTOS -> E
                            lexema = caracter
                            token = "DOS PUNTOS"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 10 ' COMA -> E
                            lexema = caracter
                            token = "COMA"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 11 ' ABRIR PARENTESIS - > D
                            lexema = caracter
                            token = "ABRIR PARENTESIS"
                            id = tipoCaracter
                            color = "orange"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 12 ' CERRAR PARENTESIS - > D
                            lexema = caracter
                            token = "CERRAR PARENTESIS"
                            id = tipoCaracter
                            color = "orange"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 13 ' SUMA - > D
                            lexema = caracter
                            token = "SUMA"
                            color = "orange"
                            id = tipoCaracter
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 14 ' RESTA - > D
                            lexema = caracter
                            token = "RESTA"
                            id = tipoCaracter
                            color = "orange"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 15 ' MULTIPLICACION - > D
                            lexema = caracter
                            token = "MULTIPLICACIÓN"
                            id = tipoCaracter
                            color = "orange"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 16 ' DIVISIÓN - > D
                            lexema = caracter
                            token = "DIVISIÓN"
                            id = tipoCaracter
                            color = "orange"
                            estado = 3
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "D"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 17 ' RETORNO - > E
                            lexema = "RETORNO"
                            token = "RETORNO"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna = 1
                            fila += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = token
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 18 ' VACIO -> E
                            lexema = "'" & caracter & "'"
                            token = "' '"
                            id = tipoCaracter
                            color = "green"
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "E"
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 19 'FIN DE CADENA
                            MessageBox.Show("Análisis Léxico concluido" & vbCrLf & "satisfactoriamente.")
                        Case 20 'TABULACION
                            columna += 4
                            debugger = New Bitacora
                            debugger._origen = "A"
                            debugger._destino = "A"
                            debugger._detalle = "Tabulador"
                        Case Else
                            errorEncontrado = New Errores
                            errorEncontrado._caracter = caracter
                            errorEncontrado._columna = columna
                            errorEncontrado._descripcion = "Desconocido"
                            errorEncontrado._fila = fila
                            ListaError.listaError.Add(errorEncontrado)
                            columna += 1
                    End Select
                Case 1 'B
                    Select Case tipoCaracter
                        Case 7 ' ' -> F ACEPTO
                            lexema = lexema + caracter
                            debugger = New Bitacora
                            debugger._detalle = "Aceptación con " & lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                            estado = 5
                            columna += 1
                            lexema = Nothing
                        Case Else
                            errorEncontrado = New Errores
                            errorEncontrado._caracter = caracter
                            errorEncontrado._columna = columna
                            errorEncontrado._descripcion = "Desconocido"
                            errorEncontrado._fila = fila
                            ListaError.listaError.Add(errorEncontrado)
                            columna += 1
                    End Select
                Case 2 'C
                    Select Case tipoCaracter
                        Case 5 ' [a-z] -> G
                            lexema = lexema + caracter
                            estado = 6
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "C"
                            debugger._destino = "G"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case Else
                            errorEncontrado = New Errores
                            errorEncontrado._caracter = caracter
                            errorEncontrado._columna = columna
                            errorEncontrado._descripcion = "Desconocido"
                            errorEncontrado._fila = fila
                            ListaError.listaError.Add(errorEncontrado)
                            columna += 1
                    End Select
                Case 3 'D
                    Select Case tipoCaracter
                        Case 6 ' [0-9] -> D 
                            lexema = lexema + caracter
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 11 ' ABRIR PARENTESIS -> D ACEPTO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "ABRIR PARENTESIS"
                            id = tipoCaracter
                            color = "orange"
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 12 ' CERRAR PARENTESIS -> D ACETPO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "CERRAR PARENTESIS"
                            id = tipoCaracter
                            color = "orange"
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 13 ' SUMA -> D ACEPTO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "SUMA"
                            id = tipoCaracter
                            color = "green"
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 14 ' RESTA -> D ACEPTO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "RESTA"
                            id = tipoCaracter
                            color = "orange"
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 15 ' MULTIPLICACIÓN -> D ACEPTO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "MULTIPLICACIÓN"
                            color = "green"
                            id = tipoCaracter
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 16 ' DIVICIÓN -> D ACEPTO ANTES
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            lexema = caracter
                            token = "DIVISIÓN"
                            id = tipoCaracter
                            color = "orange"
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "D"
                            debugger._destino = "D"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case Else 'OTRO CARACTER -> A ACEPTO
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            debugger = New Bitacora
                            debugger._detalle = lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                            estado = 0
                            token = Nothing
                            lexema = Nothing
                            i -= 1
                    End Select
                Case 4 ' E ACEPTO
                    tokenReconocido = New Token
                    tokenReconocido._id = id
                    tokenReconocido._lexema = lexema
                    tokenReconocido._token = token
                    tokenReconocido._color = color
                    ListaToken.listaToken.Add(tokenReconocido)

                    debugger = New Bitacora
                    debugger._detalle = "Aceptación con " & lexema
                    ListaBitacora.listaBitacora.Add(debugger)
                    estado = 0
                    lexema = Nothing
                    i -= 1
                Case 5 'F
                    Select Case tipoCaracter
                        Case 5 ' [a-z] -> H
                            estado = 7
                            lexema = lexema + caracter
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "F"
                            debugger._destino = "H"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 6 ' [0-9] -> H
                            estado = 7
                            lexema = lexema + caracter
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "F"
                            debugger._destino = "H"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case Else
                            tokenReconocido = New Token
                            tokenReconocido._id = id
                            tokenReconocido._lexema = lexema
                            tokenReconocido._token = token
                            tokenReconocido._color = color
                            ListaToken.listaToken.Add(tokenReconocido)
                            estado = 0
                            i -= 1
                    End Select
                Case 6 'G
                    Select Case tipoCaracter
                        Case 5 ' [a-z] -> G
                            lexema = lexema + caracter
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "G"
                            debugger._destino = "G"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 8 ' " -> E ACEPTO
                            lexema = lexema + caracter
                            estado = 4
                            columna += 1
                            debugger = New Bitacora
                            debugger._detalle = "Aceptacion con " & lexema
                            ListaBitacora.listaBitacora.Add(debugger)
                            'VERIFICAR PALABRA RESERVADA O TEXTO
                            If (lexema.Equals("imagen")) Then
                                token = "Reservada imagen"
                                id = 21
                                Color = "purple"
                            ElseIf (lexema.Equals("nombre")) Then
                                token = "Reservada nombre"
                                id = 22
                                Color = "purple"
                            ElseIf (lexema.Equals("alto")) Then
                                token = "Reservada alto"
                                id = 23
                                Color = "purple"
                            ElseIf (lexema.Equals("ancho")) Then
                                token = "Reservada ancho"
                                id = 24
                                Color = "purple"
                            ElseIf (lexema.Equals("formato")) Then
                                token = "Reservada formato"
                                id = 25
                                Color = "purple"
                            ElseIf (lexema.Equals("colores")) Then
                                token = "Reservada colores"
                                id = 26
                                Color = "purple"
                            ElseIf (lexema.Equals("y")) Then
                                token = "Reservada y"
                                id = 27
                                Color = "purple"
                            ElseIf (lexema.Equals("x")) Then
                                token = "Reservada x"
                                id = 28
                                Color = "purple"
                            ElseIf (lexema.Equals("color")) Then
                                token = "Reservada color"
                                id = 29
                                Color = "purple"
                            Else
                                token = "Texto"
                                id = 30
                                Color = "yellow"
                            End If
                        Case Else
                            errorEncontrado = New Errores
                            errorEncontrado._caracter = caracter
                            errorEncontrado._columna = columna
                            errorEncontrado._descripcion = "Desconocido"
                            errorEncontrado._fila = fila
                            ListaError.listaError.Add(errorEncontrado)
                            columna += 1
                    End Select
                Case 7 'H -- ACEPTACION
                    Select Case tipoCaracter
                        Case 5 ' [a-z] -> H
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "H"
                            debugger._destino = "H"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case 6 ' [0-9] -> H
                            columna += 1
                            debugger = New Bitacora
                            debugger._origen = "H"
                            debugger._destino = "H"
                            debugger._detalle = caracter
                            ListaBitacora.listaBitacora.Add(debugger)
                        Case Else
                            estado = 0
                            lexema = Nothing
                            i -= 1
                    End Select
            End Select
        Next

        setDatos.Set_Debugger()

    End Sub

    Private Function get_TipoCaracter(caracter As Char) As Integer
        Dim indiceCaracter As Integer
        Select Case caracter
            Case "{" 'ABRIR LLAVE
                indiceCaracter = 1
            Case "}" 'CERRAR LLAVE
                indiceCaracter = 2
            Case "[" 'ABRIR CORCHETES
                indiceCaracter = 3
            Case "]" 'CERRAR CORCHETES
                indiceCaracter = 4
            Case "a" To "z" 'LETRA MINUSCULA
                indiceCaracter = 5
            Case "0" To "9" 'NUMERO
                indiceCaracter = 6
            Case Chr(39) 'COMILLA
                indiceCaracter = 7
            Case Chr(34) 'COMILLAS DOBLES
                indiceCaracter = 8
            Case ":" 'DOS PUNTOS"
                indiceCaracter = 9
            Case "," 'COMA
                indiceCaracter = 10
            Case "(" 'ABRIR PARENTESIS
                indiceCaracter = 11
            Case ")" 'CERRAR PARENTESIS
                indiceCaracter = 12
            Case "+" 'SUMA
                indiceCaracter = 13
            Case "-" 'RESTA
                indiceCaracter = 14
            Case "*" 'MULTIPLICACIÓN
                indiceCaracter = 15
            Case "/" 'DIVICION
                indiceCaracter = 16
            Case Chr(10) 'RETORNO
                indiceCaracter = 17
            Case Chr(32) 'VACIO
                indiceCaracter = 18
            Case "#" 'FIN DE CADENA
                indiceCaracter = 19
            Case Chr(9) 'TABULACION
                indiceCaracter = 20
        End Select
        Return indiceCaracter
    End Function
End Class
