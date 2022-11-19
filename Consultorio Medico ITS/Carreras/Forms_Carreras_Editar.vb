Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Carreras_Editar



    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click

        If Radio_Carrera.Checked = True Then
            BuscarCarrera()
        Else MsgBox("Datos no encontrados", MsgBoxStyle.Exclamation, "Confirmado")

        End If

        If TextBox_Buscar.Text = String.Empty Then
            limpiar()
        End If

    End Sub


    Private Sub BuscarCarrera()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM ESPECIALIDAD WHERE CARRERA = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "ESPECIALIDAD")

        Me.TextBox_Carrera.Text = ds.Tables("ESPECIALIDAD").Rows(0).Item(0)

        Me.TextBox_Especialidad.Text = ds.Tables("ESPECIALIDAD").Rows(0).Item(1)

        conexion.Close()

    End Sub

    Private Sub limpiar()


        Me.TextBox_Carrera.Text = String.Empty
        Me.TextBox_Especialidad.Text = String.Empty


    End Sub

    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM ESPECIALIDAD WHERE CARRERA = '" & Me.TextBox_Carrera.Text & "' AND ESPECIALIDAD='" & Me.TextBox_Especialidad.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


            MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE ESPECIALIDAD SET CARRERA = '" & Me.TextBox_Carrera.Text & "', ESPECIALIDAD='" & Me.TextBox_Especialidad.Text & "' WHERE CARRERA='" & Me.TextBox_Carrera.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Forms_Carreras_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class