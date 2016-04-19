Public Class Form1
    Dim contador As Integer = 1
    Dim texto As String
    Dim analizador As New AnalizadorLexico()
    Dim crearArchivos As New SetDatos()

    Private Sub NuevaPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        Dim newPage As New TabPage()
        newPage.Text = "Pestaña " & contador
        newPage.Name = "Pestaña" & contador
        TabControl.TabPages.Add(newPage)
        addCaja(newPage, contador, "Puedes comenzar aquí...")
        TabControl.SelectedTab = newPage
        contador += 1
    End Sub

    Private Sub addCaja(newPage As Windows.Forms.TabPage, contador As Integer, texto As String)
        Dim newRichTextBox As New RichTextBox
        newRichTextBox.Text = texto
        newRichTextBox.Name = "rchTxtCaja" & contador
        newRichTextBox.Parent = newPage
        newRichTextBox.Size = New Size(386, 364)
        newRichTextBox.Location = New Point(4, 4)
        newRichTextBox.ForeColor = Color.Teal
        newPage.Controls.Add(newRichTextBox)
    End Sub

    Private Sub CerrarPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarPestañaToolStripMenuItem.Click
        TabControl.TabPages.Remove(TabControl.SelectedTab)
    End Sub

    Private Sub CerrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        TabControl.TabPages.Clear()
        contador = 1
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

        OpenFileDialog1.Title = "Seleccione un archivo"
        OpenFileDialog1.Filter = "Archivo JSON | *.json"
        OpenFileDialog1.ShowDialog()
        Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)

        Dim newPage As New TabPage()
        newPage.Text = "Pestaña " & contador
        newPage.Name = "Pestaña" & contador
        TabControl.TabPages.Add(newPage)
        addCaja(newPage, contador, sr.ReadToEnd)
        sr.Close()
        contador += 1

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim sfd As New SaveFileDialog
        sfd.Title = "Selecciona el destino"
        sfd.Filter = "Archivo JSON|*.json"
        sfd.ShowDialog()

        Dim sw As New IO.StreamWriter(sfd.FileName)
        sw.Write(RchTxtCaja0.Text)
        sw.Close()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("Proyecto 1" & Chr(13) & "Autor: Marco Antonio Fidencio Chávez Fuentes" & Chr(13) &
                        "Carne: 2010-20831" & Chr(13) & "Lenguajes Formales y de Programación 2016")
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        UserManual.Show()
    End Sub

    Private Sub btnAnalizar_Click(sender As Object, e As EventArgs) Handles btnAnalizar.Click
        texto = RchTxtCaja0.Text
        analizador.analizar(texto)
        'MessageBox.Show(richTex.Name)
    End Sub

    Private Function get_id_TabSelected() As Integer
        Dim selectTab As Integer = TabControl.SelectedIndex
        Return selectTab
    End Function

    Private Sub btnGenerarArchivos_Click(sender As Object, e As EventArgs) Handles btnGenerarArchivos.Click
        crearArchivos.crearListaHtml()
        crearArchivos.listadoDebugger()
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click

    End Sub

    Private Sub ListadoDeTokenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTokenToolStripMenuItem.Click
        'Chr(32): Caracter vacío
        'Chr(10): Retorno de carro
        'Chr(34): Comillas dobles
        'Chr(39): Comilla simple
        Dim token As String
        token = Chr(39) & "imagen" & Chr(34) & vbCrLf
        token += Chr(39) & "nombre" & Chr(34) & vbCrLf
        token += Chr(39) & "alto" & Chr(34) & vbCrLf
        token += Chr(39) & "ancho" & Chr(34) & vbCrLf
        token += Chr(39) & "formato" & Chr(34) & vbCrLf
        token += Chr(39) & "colores" & Chr(34) & vbCrLf
        token += Chr(39) & "y" & Chr(34) & vbCrLf
        token += Chr(39) & "x" & Chr(34) & vbCrLf
        token += Chr(39) & "color" & Chr(34) & vbCrLf
        token += "[0-9]" & vbCrLf
        token += Chr(34) & vbCrLf
        token += "(" & vbCrLf & ")" & vbCrLf
        token += "+" & vbCrLf & "+" & vbCrLf
        token += "*" & vbCrLf & "/" & vbCrLf
        token += "Caracter Vacío" & vbCrLf
        token += "Retorno" & vbCrLf
        token += "[" & vbCrLf & "]" & vbCrLf
        token += "{" & vbCrLf & "}" & vbCrLf
        token += ":" & vbCrLf & ","
        MessageBox.Show(token, "Lista de token validos")
    End Sub
End Class
