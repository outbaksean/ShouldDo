Public Class ShouldDoCategory
    Private M_ID As Int64
    Private M_Name As String
    Private M_Description As String

    Public Sub New(ByVal name As String)
        M_Name = name
    End Sub

    Public ReadOnly Property ID() As Int64
        Get
            Return M_ID
        End Get
    End Property

    Public Property Name() As String
        Get
            Return M_Name
        End Get
        Set(ByVal value As String)
            M_Name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return M_Description
        End Get
        Set(ByVal value As String)
            M_Description = value
        End Set
    End Property

End Class
