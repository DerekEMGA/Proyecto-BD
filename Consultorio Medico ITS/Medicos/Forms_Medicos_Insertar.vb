Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Medicos_Insertar
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





        Dim cmd As New SqlCommand("INSERT INTO MEDICOS(MEDICO_NUMERO_EMPLEADO,NOMBRE_MEDICO,EDAD_MEDICO,SEXO_MEDICO,Especilidad_Medico,NUMERO_CEDULA_MEDICO) VALUES
         ('" & Me.TextBox_Numero_Empleado.Text & "','" & Me.TextBox_Nombre.Text & "','" & Me.TextBox_Edad.Text & "','" & Me.TextBox_Sexo.Text & "','" & Me.TextBox_Especialidad.Text & "','" & Me.TextBox_Cedula.Text & "')", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Forms_Medicos_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class