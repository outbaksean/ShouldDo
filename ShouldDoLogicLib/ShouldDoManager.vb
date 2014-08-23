Public Class ShouldDoManager
    Public Shared Function getAllShouldDos() As Generic.List(Of ShouldDo)
        Dim shouldDos As Generic.List(Of ShouldDo) = Nothing

        Dim table As DataTable = ShouldDoDataLib.ShouldDoManager.GetAllShouldDos
        For Each row As DataRow In table.Rows
            Dim id As Int64 = -1
            If Not row.IsNull("ID") Then    'else throw exception
                id = row.Item("ID")
            End If
            Dim name As String = ""
            If Not row.IsNull("Name") Then    'else throw exception
                name = row.Item("Name")
            End If
            Dim desc As String = ""
            If Not row.IsNull("Description") Then    'else throw exception
                desc = row.Item("Description")
            End If
            Dim priority As Int64 = -1
            If Not row.IsNull("Priority") Then    'else throw exception
                priority = row.Item("Priority")
            End If
            Dim schedule As Int64 = -1
            If Not row.IsNull("Schedule") Then    'else throw exception
                schedule = row.Item("Schedule")
            End If
            Dim recurrence As Int64 = -1
            If Not row.IsNull("Recurrence") Then    'else throw exception
                recurrence = row.Item("Recurrence")
            End If
            Dim isDone As Boolean = False
            If Not row.IsNull("isDone") Then    'else throw exception
                isDone = row.Item("isDone")
            End If
            'TODO: eval FKs
            If shouldDos Is Nothing Then
                shouldDos = New Generic.List(Of ShouldDo)
            End If
            shouldDos.Add(New ShouldDo(id, name, desc, Nothing, Nothing, False, Nothing))
        Next
        Return shouldDos
    End Function


End Class
