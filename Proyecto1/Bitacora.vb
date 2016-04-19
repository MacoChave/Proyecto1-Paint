Public Class Bitacora
    Private origen As String
    Private destino As String
    Private detalle As String

    Sub New()

    End Sub

    Sub New(origen As String, destino As String, detalle As String)
        Me.origen = origen
        Me.destino = destino
        Me.detalle = detalle
    End Sub

    Public Property _origen As String
        Get
            Return origen
        End Get
        Set(value As String)
            origen = value
        End Set
    End Property

    Public Property _destino As String
        Get
            Return destino
        End Get
        Set(value As String)
            destino = value
        End Set
    End Property

    Public Property _detalle As String
        Get
            Return detalle
        End Get
        Set(value As String)
            detalle = value
        End Set
    End Property
End Class
