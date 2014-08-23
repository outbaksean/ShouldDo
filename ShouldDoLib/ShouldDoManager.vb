Imports System.Data.SqlClient

Public Class ShouldDoManager
    'Public Shared Function createShouldDo(ByVal name As String, Optional ByVal desc As String = Nothing) 
    '    newShouldDo = New ShouldDo(name, desc)
    '    addShouldDoToDB(name, desc)
    '    newShouldDo.ID = getlastIdent()
    '    Return newShouldDo
    'End Function

    'Private Shared Sub addShouldDoToDB(ByVal name As String, ByVal desc As String)
    '    Dim query As String
    '    Dim params As New Generic.List(Of SqlParameter)
    '    Dim db As New DBFunctions
    '    Dim result As Integer
    '    Dim fields As String = "name"
    '    Dim fieldsV As String = "@name"
    '    params.Add(New SqlParameter("name", name))
    '    If desc IsNot Nothing Then
    '        fields = fields & ", description"
    '        fieldsV = fieldsV & ", @description"
    '        params.Add(New SqlParameter("description", desc))
    '    End If
    '    query = "insert into shoulddo (" & fields & ") values (" & fieldsV & ")"


    '    result = db.executeCommand(query, params)
    'End Sub

    Public Shared Function GetAllShouldDos() As DataTable
        Dim shouldDos As DataTable = Nothing
        Dim query As String
        Dim db As New DBFunctions
        query = "select * from ShouldDo"
        shouldDos = db.getDataTable(query)

        Return shouldDos
    End Function

    Public Shared Function GetPriority(ByVal ID As Int64) As DataTable
        Dim priority As DataTable = Nothing
        Dim query As String
        Dim params As New Generic.List(Of SqlParameter)
        Dim db As New DBFunctions

        params.Add(New SqlParameter("ID", SqlDbType.BigInt) With {.Value = ID})
        query = "select * from priority where ID = @ID"

        priority = db.getDataTable(query, params)

        Return priority
    End Function

    Public Shared Function GetSchedule(ByVal ID As Int64) As DataTable
        Dim schedule As DataTable = Nothing
        Dim query As String
        Dim params As New Generic.List(Of SqlParameter)
        Dim db As New DBFunctions

        params.Add(New SqlParameter("ID", SqlDbType.BigInt) With {.Value = ID})
        query = "select * from schedule where ID = @ID"

        schedule = db.getDataTable(query, params)

        Return schedule
    End Function

    Public Shared Function GetRecurrence(ByVal ID As Int64) As DataTable
        Dim recurrence As DataTable = Nothing
        Dim query As String
        Dim params As New Generic.List(Of SqlParameter)
        Dim db As New DBFunctions

        params.Add(New SqlParameter("ID", SqlDbType.BigInt) With {.Value = ID})
        query = "select * from recurrence where ID = @ID"

        recurrence = db.getDataTable(query, params)

        Return recurrence
    End Function

    Public Shared Function GetPerType(ByVal ID As Int64) As DataTable
        Dim perType As DataTable = Nothing
        Dim query As String
        Dim params As New Generic.List(Of SqlParameter)
        Dim db As New DBFunctions

        params.Add(New SqlParameter("ID", SqlDbType.BigInt) With {.Value = ID})
        query = "select * from perType where ID = @ID"

        perType = db.getDataTable(query, params)

        Return perType
    End Function

    Private Shared Function getlastIdent() As Integer
        Dim ident As Integer = -1
        Dim db As New DBFunctions
        ident = db.getLastIdent

        Return ident
    End Function
End Class
