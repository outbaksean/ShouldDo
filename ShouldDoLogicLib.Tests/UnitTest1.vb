Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestGetAllShouldDos()
        Dim shouldDos As Generic.List(Of ShouldDo)
        shouldDos = ShouldDoLogicLib.ShouldDoManager.getAllShouldDos()
        Dim name As String
        'TODO: finish this test
        name = shouldDos(0).Name
        Dim name2 As String = shouldDos(1).Name
        Assert.AreEqual("test", name)
        Assert.AreEqual("TestShouldDo 1", name2)
    End Sub

End Class