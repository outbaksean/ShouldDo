Public Class ShouldDoBox
    Inherits System.Web.UI.UserControl

    Private M_ShouldDo As ShouldDoLogicLib.ShouldDo
    Public Property ShouldDo() As ShouldDoLogicLib.ShouldDo
        Get
            Return M_ShouldDo
        End Get
        Set(ByVal value As ShouldDoLogicLib.ShouldDo)
            M_ShouldDo = value
            lblShouldDo.Text = M_ShouldDo.ToString
        End Set
    End Property


    Public Event sdDone(sender As Object, e As EventArgs)

    'Public Custom Event Done As EventHandler
    '    AddHandler(value As EventHandler)
    '        AddHandler btnDone.Click, value
    '    End AddHandler

    '    RemoveHandler(value As EventHandler)
    '        RemoveHandler btnDone.Click, value
    '    End RemoveHandler

    '    RaiseEvent(sender As Object, e As EventArgs)

    '    End RaiseEvent
    'End Event

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        RaiseEvent sdDone(Me, e)
    End Sub
End Class

'Public Class ShouldDoBoxDoneEventArgs
'    Inherits EventArgs

'    Private M_ShouldDoId As Int64
'    Public ReadOnly Property ShouldDoID() As Int64
'        Get
'            Return M_ShouldDoId
'        End Get
'    End Property

'    Public Sub New(ByVal shouldDoID As Int64)
'        M_ShouldDoId = shouldDoID
'    End Sub

'    Public Delegate Sub ShouldDoBoxDoneEventHandler(sender As Object, e As ShouldDoBoxDoneEventArgs)

'End Class