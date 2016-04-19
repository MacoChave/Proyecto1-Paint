
Public Class Token
    Private id As Integer
    Private lexema As String
    Private token As String
    Private color As String

    Sub New()

    End Sub

    Sub New(id As Integer, lexema As String, token As String, color As String)
        Me.id = id
        Me.lexema = lexema
        Me.token = token
        Me.color = color
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _lexema As String
        Get
            Return lexema
        End Get
        Set(value As String)
            lexema = value
        End Set
    End Property

    Public Property _token As String
        Get
            Return token
        End Get
        Set(value As String)
            token = value
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
