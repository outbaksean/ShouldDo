Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ShouldDoLib

<TestClass()> Public Class ShouldDoTest

    <TestMethod()> Public Sub TestGetPriority()
        Dim priority As New DataTable
        priority = ShouldDoDataLib.ShouldDoManager.GetPriority(3L)
        Dim p As String
        p = priority.Rows(0).Item("Name")
        Assert.AreEqual("Low", p)
    End Sub

    <TestMethod()> Public Sub TestGetSchedule()
        Dim schedule As New DataTable
        schedule = ShouldDoDataLib.ShouldDoManager.GetSchedule(1L)
        Dim p As String
        p = schedule.Rows(0).Item("Name")
        Assert.AreEqual("Sched 1", p)
    End Sub

    <TestMethod()> Public Sub TestGetRecurrence()
        Dim recurrence As New DataTable
        recurrence = ShouldDoDataLib.ShouldDoManager.GetRecurrence(3L)
        Dim p As Integer
        p = recurrence.Rows(0).Item("TimesPer")
        Assert.AreEqual(4, p)
    End Sub

    <TestMethod()> Public Sub TestGetPerType()
        Dim perType As New DataTable
        perType = ShouldDoDataLib.ShouldDoManager.GetPerType(3L)
        Dim p As String
        p = perType.Rows(0).Item("Name")
        Assert.AreEqual("Monthly", p)
    End Sub


End Class