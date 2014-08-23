
Module Module1

    Sub Main()
        'Dim myName As String = mySH.Name
        'ShouldDoManager.addShouldDoToDB()
        'Dim man As New ShouldDoLogicLib.ShouldDoManager
        Dim table As DataTable = ShouldDoDataLib.ShouldDoManager.GetPriority(3)
    End Sub

End Module
