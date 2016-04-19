Imports System.IO
Imports System.Text

Public Class SetDatos
    Public Sub Set_Debugger()
        Dim logList As String
        'Form1.rchTxtDebug.Text = "Debugger..."
        For d As Integer = 0 To ListaBitacora.listaBitacora.Count - 1 Step 1
            'Form1.rchTxtDebug.Text = ListaBitacora.listaBitacora.Item(i)._origen & " -> " & ListaBitacora.listaBitacora.Item(i)._destino & ": " & ListaBitacora.listaBitacora.Item(i)._detalle & "" & Chr(13)
            'Form1.rchTxtDebug.Text = ListaBitacora.listaBitacora.Item(i)._detalle & "" & Chr(13)

            logList = logList + ListaBitacora.listaBitacora.Item(d)._origen & " -> " & ListaBitacora.listaBitacora.Item(d)._destino & ": " & ListaBitacora.listaBitacora.Item(d)._detalle & " " & vbCrLf
            Form1.TxtBoxDebugger.Text = logList
        Next
    End Sub

    Public Sub crearListaHtml()
        Dim html As String
        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "table.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Tabla de Token y Errores</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<h1>Token Reconocidos</h1>" & vbCrLf
        html += "<table class=" & Chr(34) & "tabla" & Chr(34) & ">" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<th>No</th>" & vbCrLf
        html += "<th>Id</th>" & vbCrLf
        html += "<th>Lexema</th>" & vbCrLf
        html += "<th>Token</th>" & vbCrLf
        html += "</tr>" & vbCrLf

        For t As Integer = 0 To ListaToken.listaToken.Count - 1 Step 1
            html += "<tr class = " & Chr(34) & ListaToken.listaToken.Item(t)._color & Chr(34) & ">" & vbCrLf
            html += "<th>" & t + 1 & "</th>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._id & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._lexema & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._token & "</td>" & vbCrLf
            html += "</tr>" & vbCrLf
        Next

        html += "</table>" & vbCrLf

        html += "<h1>Errores encontrados</h1>" & vbCrLf
        html += "<table class=" & Chr(34) & "tabla" & Chr(34) & ">" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<th>No</th>" & vbCrLf
        html += "<th>Fila</th>" & vbCrLf
        html += "<th>Columna</th>" & vbCrLf
        html += "<th>Caracter</th>" & vbCrLf
        html += "<th>Descripción</th>" & vbCrLf
        html += "</tr>" & vbCrLf

        For e As Integer = 0 To ListaError.listaError.Count - 1 Step 1
            html += "<tr>" & vbCrLf
            html += "<td>" & e + 1 & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(e)._fila & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(e)._columna & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(e)._caracter & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(e)._descripcion & "</td>" & vbCrLf
            html += "</tr>" & vbCrLf
        Next

        html += "</table>" & vbCrLf
        html += "<a href=" & Chr(34) & "C:\Users\u\Desktop\Debugger.txt" & Chr(34) & ">Ver listado de Debug</a>"
        html += "<footer><p>by @MacoChave</p></footer>" & vbCrLf
        html += "</body>" & vbCrLf
        html += "</html>"

        Dim path As String = "C:\Users\u\Desktop\Token-error_Page.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()

        ViewWeb.Show()
        Form1.Hide()
    End Sub

    Public Sub listadoDebugger()

        Dim path As String = "C:\Users\u\Desktop\Debugger.txt"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Form1.TxtBoxDebugger.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

End Class
