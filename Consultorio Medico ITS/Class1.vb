
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Class1

    Dim conexion As New SqlConnection

    Public Sub conectar()
        Try
            conexion.ConnectionString = "Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550"
            conexion.Open()

        Catch ex As Exception



        End Try
    End Sub


    Public Function getDataTable(ByVal query As String) As DataTable
        Dim dt As DataTable
        conectar()
        dt = Me.executeReader(query)


        Return dt

    End Function


    Private Function executeReader(query As String) As DataTable
        Dim cmd As New SqlCommand(query, conexion)
        Dim dt As New DataTable

        dt.Load(cmd.ExecuteReader)

        Return dt

    End Function

    Public Sub desconectar()
        If conexion.State <> ConnectionState.Closed Then
            conexion.Close()

        End If

    End Sub
End Class
