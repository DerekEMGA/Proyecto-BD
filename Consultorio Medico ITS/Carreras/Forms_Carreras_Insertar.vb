Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Carreras_Insertar


    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")


    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()

    End Sub


    Private Sub CargarDatos()

        Dim datos As New SqlDataAdapter("SELECT * FROM ESPECIALIDAD", conexion)
        Dim ds As New DataSet()
        datos.Fill(ds, "Especialidad")

    End Sub




    Private Sub Button1_Insertar_Click(sender As Object, e As EventArgs) Handles Button1_Insertar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim query As String = String.Empty


        Dim cmd As New SqlCommand("INSERT INTO ESPECIALIDAD(CARRERA,ESPECIALIDAD) VALUES('" & Me.Carrera_Insertar_Txt.Text & "','" & Me.Especialidad_Insertar_Txt.Text & "')", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Forms_Carreras_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class