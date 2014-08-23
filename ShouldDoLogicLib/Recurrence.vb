Public Class Recurrence
    Private M_ID As Int64
    Private M_TimesPer As String
    Private M_PerType As PerType

    Public Sub New(ByVal name As String)
        M_TimesPer = name
    End Sub

    Public ReadOnly Property ID() As Int64
        Get
            Return M_ID
        End Get
    End Property

    Public Property TimesPer() As String
        Get
            Return M_TimesPer
        End Get
        Set(ByVal value As String)
            M_TimesPer = value
        End Set
    End Property

    Public Property PerType() As PerType
        Get
            Return M_PerType
        End Get
        Set(ByVal value As PerType)
            M_PerType = value
        End Set
    End Property

End Class
