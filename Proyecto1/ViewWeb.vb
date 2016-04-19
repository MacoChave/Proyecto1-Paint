Public Class ViewWeb

    Private Sub ViewWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("file:///C:/Users/u/Desktop/Token-error_Page.html")
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class