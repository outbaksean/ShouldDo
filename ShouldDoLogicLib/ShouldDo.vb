Public Class ShouldDo
    'Implements IShouldDo


    Private M_ID As Int64
    Private M_Name As String
    Private m_Desc As String
    Private M_Priority As Priority
    Private M_Schedule As Schedule
    Private M_Recurrence As Recurrence
    Private M_IsDone As Boolean
    Private M_Categories As Generic.List(Of ShouldDoCategory)

    Public Sub New(ByVal id As Int64, ByVal name As String, ByVal desc As String, ByVal priority As Priority, ByVal recurrence As Recurrence, ByVal isDone As Boolean, ByVal cats As Generic.List(Of ShouldDoCategory))
        M_ID = id
        M_Name = name
        m_Desc = desc
        M_Priority = priority
        M_Schedule = Schedule
        M_Recurrence = recurrence
        M_IsDone = isDone
        M_Categories = Categories
    End Sub

    Public Overrides Function ToString() As String
        Dim out As String
        out = "ID: " & M_ID.ToString & " Name: " & M_Name & " Description: " & m_Desc
        Return out
    End Function
#Region "Properties"
    Public ReadOnly Property ID() As Int64 'Implements IShouldDo.ID
        Get
            Return M_ID
        End Get
    End Property

    Public Property Name() As String 'Implements IShouldDo.Name
        Get
            Return M_Name
        End Get
        Set(ByVal value As String)
            M_Name = value
        End Set
    End Property

    Public Property Desc() As String 'Implements IShouldDo.Desc
        Get
            Return m_Desc
        End Get
        Set(ByVal value As String)
            m_Desc = value
        End Set
    End Property

    Public Property Priority() As Priority 'Implements IShouldDo.Priority
        Get
            Return M_Priority
        End Get
        Set(ByVal value As Priority)
            M_Priority = value
        End Set
    End Property

    Public Property Schedule() As Schedule 'Implements IShouldDo.Schedule
        Get
            Return M_Schedule
        End Get
        Set(ByVal value As Schedule)
            M_Schedule = value
        End Set
    End Property

    Public Property Recurrence() As Recurrence 'Implements IShouldDo.Recurrance
        Get
            Return M_Recurrence
        End Get
        Set(ByVal value As Recurrence)
            M_Recurrence = value
        End Set
    End Property

    Public Property IsDone() As Boolean 'Implements IShouldDo.IsDone
        Get
            Return M_IsDone
        End Get
        Set(ByVal value As Boolean)
            M_IsDone = value
        End Set
    End Property

    Public Property Categories() As Generic.List(Of ShouldDoCategory)
        Get
            Return M_Categories
        End Get
        Set(ByVal value As Generic.List(Of ShouldDoCategory))
            M_Categories = value
        End Set
    End Property
#End Region
End Class
