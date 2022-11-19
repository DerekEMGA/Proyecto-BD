Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Departamento_Insertar
    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")


    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()

    End Sub







    Private Sub Button_Insertar_Click(sender As Object, e As EventArgs) Handles Button_Insertar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim query As String = String.Empty


        Dim cmd As New SqlCommand("INSERT INTO DEPARTAMENTO(DEPARTAMENTO) VALUES('" & Me.TextBox_Departamento.Text & "')", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Class