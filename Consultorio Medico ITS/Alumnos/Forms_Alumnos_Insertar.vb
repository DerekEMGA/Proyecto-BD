Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class Forms_Alumnos_Insertar


    Dim comando As SqlCommand


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")


    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Button1_Insertar_Click(sender As Object, e As EventArgs) Handles Button1_Insertar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim query As String = String.Empty


        Dim cmd As New SqlCommand("INSERT INTO ALUMNO(MATRICULA,ESPECIALIDAD_ESPECIALIDAD,ESPECIALIDAD_CARRERA,NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNOS,EDAD,FECHA_NACIMIENTO,CELULAR,SEMESTRE,CORREO) VALUES
         ('" & Me.TextBox_Matricula.Text & "','" & Me.TextBox_Especialidad.Text & "','" & Me.TextBox_Carrera.Text & "','" & Me.TextBox_Nombre.Text & "','" & Me.TextBox_Paterno.Text & "','" & Me.TextBox_Materno.Text & "',
         '" & Me.TextBox_Edad.Text & "','" & Me.TextBox_Fecha.Text & "','" & Me.TextBox_Celular.Text & "','" & Me.TextBox_Semestre.Text & "','" & Me.TextBox_Correo.Text & "')", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Forms_Alumnos_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class