Public Class Dibujo

    Private x As Integer
    Private y As Integer
    Private color As String

    Sub New()

    End Sub

    Sub New(x As Integer, y As Integer, color As String)
        Me.x = x
        Me.y = y
        Me.color = color
    End Sub

    Public Property _x As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            x = value
        End Set
    End Property

    Public Property _y As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property

    Public Property _color As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property
End Class
