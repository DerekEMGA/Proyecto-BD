Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Alumnos_Editar



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
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM ALUMNO WHERE MATRICULA = '" & Me.TextBox_Buscar.Text & "' ", conexion)

            Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "ALUMNO")


        Me.TextBox_Matricula.Text = ds.Tables("ALUMNO").Rows(0).Item(0)


        Me.TextBox_Carrera.Text = ds.Tables("ALUMNO").Rows(0).Item(2)


        Me.TextBox_Especialidad.Text = ds.Tables("ALUMNO").Rows(0).Item(1)

        Me.TextBox_Nombre.Text = ds.Tables("ALUMNO").Rows(0).Item(3)

        Me.TextBox_Paterno.Text = ds.Tables("ALUMNO").Rows(0).Item(4)


        Me.TextBox_Materno.Text = ds.Tables("ALUMNO").Rows(0).Item(5)


        Me.TextBox_Fecha.Text = ds.Tables("ALUMNO").Rows(0).Item(7)


        Me.TextBox_Celular.Text = ds.Tables("ALUMNO").Rows(0).Item(8)


        Me.TextBox_Semestre.Text = ds.Tables("ALUMNO").Rows(0).Item(9)


        Me.TextBox_Correo.Text = ds.Tables("ALUMNO").Rows(0).Item(11)

        Me.TextBox_Edad.Text = ds.Tables("ALUMNO").Rows(0).Item(6)


        conexion.Close()

    End Sub

    Private Sub limpiar()


        Me.TextBox_Carrera.Text = String.Empty
        Me.TextBox_Especialidad.Text = String.Empty


    End Sub

    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        Try

            Dim nombre_Alumno As New SqlDataAdapter("SELECT ID_CITAS FROM CITAS WHERE ALUMNO_MATRICULA='" & Me.TextBox_Matricula.Text & "' ", conexion)

            Dim ds As New DataSet()

            Dim sd As Int16

            nombre_Alumno.Fill(ds, "ALUMNO")


            Label1.Text = ds.Tables("ALUMNO").Rows(0).Item(0)

            MsgBox("El alumno tiene citas , no se puede eliminar", MsgBoxStyle.Information, "Comprobar")

        Catch ex As Exception

            conexion.Open()







            Dim cmd As New SqlCommand("DELETE FROM ALUMNO WHERE MATRICULA='" & Me.TextBox_Matricula.Text & "'AND
ESPECIALIDAD_ESPECIALIDAD='" & Me.TextBox_Especialidad.Text & "' AND
ESPECIALIDAD_CARRERA='" & Me.TextBox_Carrera.Text & "' AND 
NOMBRE='" & Me.TextBox_Nombre.Text & "'AND
APELLIDO_PATERNO='" & Me.TextBox_Paterno.Text & "'AND
APELLIDO_MATERNOS='" & Me.TextBox_Materno.Text & "'AND
EDAD='" & Me.TextBox_Edad.Text & "'AND
FECHA_NACIMIENTO='" & Me.TextBox_Fecha.Text & "'AND
CELULAR='" & Me.TextBox_Celular.Text & "' AND
SEMESTRE='" & Me.TextBox_Semestre.Text & "' AND
CORREO='" & Me.TextBox_Correo.Text & "'  ", conexion)

            cmd.ExecuteNonQuery()


            MsgBox("Eliminado correctamente", vbInformation, "Aviso")


            conexion.Close()





        End Try



    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE ALUMNO SET MATRICULA='" & Me.TextBox_Matricula.Text & "',
ESPECIALIDAD_ESPECIALIDAD='" & Me.TextBox_Especialidad.Text & "',
ESPECIALIDAD_CARRERA='" & Me.TextBox_Carrera.Text & "',
NOMBRE='" & Me.TextBox_Nombre.Text & "',
APELLIDO_PATERNO='" & Me.TextBox_Paterno.Text & "',
APELLIDO_MATERNOS='" & Me.TextBox_Materno.Text & "',
EDAD='" & Me.TextBox_Edad.Text & "',
FECHA_NACIMIENTO='" & Me.TextBox_Fecha.Text & "',
CELULAR='" & Me.TextBox_Celular.Text & "',
SEMESTRE='" & Me.TextBox_Semestre.Text & "',
CORREO='" & Me.TextBox_Correo.Text & "' 
WHERE MATRICULA='" & Me.TextBox_Matricula.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Forms_Alumnos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class