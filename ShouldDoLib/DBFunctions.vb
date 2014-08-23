Imports System.Data.SqlClient

Public Class DBFunctions
    Public Function executeCommand(ByVal query As String, Optional ByVal params As Generic.List(Of SqlParameter) = Nothing) As Integer
        Dim result As Integer = -1

        Dim connection As SqlConnection = New SqlConnection("Data Source=SEAN-MAIN;Initial Catalog=ShouldDo;Integrated Security=True;Pooling=False")
        Dim command As SqlCommand = connection.CreateCommand

        Using command
            command.CommandText = query
            command.CommandTimeout = 6
            command.CommandType = CommandType.Text
            If params IsNot Nothing Then
                command.Parameters.AddRange(params.ToArray)
            End If
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            result = command.ExecuteNonQuery
        End Using
        connection.Close()
        Return result
    End Function
    Public Function getDataTable(ByVal query As String, Optional ByVal params As Generic.List(Of SqlParameter) = Nothing)
        Dim connection As SqlConnection = New SqlConnection("Data Source=SEAN-MAIN;Initial Catalog=ShouldDo;Integrated Security=True;Pooling=False")
        Dim adapter As SqlDataAdapter = New SqlDataAdapter
        adapter.SelectCommand = connection.CreateCommand
        adapter.SelectCommand.CommandText = query
        adapter.SelectCommand.CommandTimeout = 6
        adapter.SelectCommand.CommandType = CommandType.Text

        If params IsNot Nothing Then
            adapter.SelectCommand.Parameters.AddRange(params.ToArray)
        End If

        connection.Open()
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function

    Public Function executeScalar(ByVal query As String, Optional ByVal params As Generic.List(Of SqlParameter) = Nothing) As Object
        Dim result As Object

        Dim connection As SqlConnection = New SqlConnection("Data Source=SEAN-MAIN;Initial Catalog=ShouldDo;Integrated Security=True;Pooling=False")
        Dim command As SqlCommand = connection.CreateCommand

        Using command
            command.CommandText = query
            command.CommandTimeout = 6
            command.CommandType = CommandType.Text
            If params IsNot Nothing Then
                command.Parameters.AddRange(params.ToArray)
            End If
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            result = command.ExecuteScalar
        End Using
        connection.Close()

        Return result
    End Function

    Public Function getLastIdent(Optional ByVal identCol As String = "ID")
        Dim ident As Integer = -1

        Dim query As String = "SELECT ISNULL(MAX(ID), 0) FROM ShouldDo"
        ident = Me.executeScalar(query)

        Return ident
    End Function
End Class
