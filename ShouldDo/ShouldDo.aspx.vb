Public Class ShouldDo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim shouldDos As Generic.List(Of ShouldDoLogicLib.ShouldDo)
        shouldDos = ShouldDoLogicLib.ShouldDoManager.getAllShouldDos
        For Each ShouldDo As ShouldDoLogicLib.ShouldDo In shouldDos
            Dim sdb As ShouldDoBox
            sdb = LoadControl("~/ShouldDoBox.ascx")
            sdb.ShouldDo = ShouldDo
            AddHandler sdb.sdDone, AddressOf Me.ShouldDo_Done
            plhShouldDo.Controls.Add(sdb)
        Next
    End Sub

    Private Sub ShouldDo_Done(sender As Object, e As EventArgs)
        lblOut.Text = "CLICKED!"
    End Sub

    'Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    'End Sub


End Class