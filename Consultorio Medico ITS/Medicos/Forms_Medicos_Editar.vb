Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class Forms_Medicos_Editar

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
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM MEDICOS WHERE MEDICO_NUMERO_EMPLEADO = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "MEDICOS")

        Me.TextBox_Numero_Empleado.Text = ds.Tables("MEDICOS").Rows(0).Item(0)

        Me.TextBox_Nombre.Text = ds.Tables("MEDICOS").Rows(0).Item(1)

        Me.TextBox_Edad.Text = ds.Tables("MEDICOS").Rows(0).Item(2)

        Me.TextBox_Sexo.Text = ds.Tables("MEDICOS").Rows(0).Item(3)

        Me.TextBox_Especialidad.Text = ds.Tables("MEDICOS").Rows(0).Item(4)

        Me.TextBox_Cedula.Text = ds.Tables("MEDICOS").Rows(0).Item(5)

        conexion.Close()

    End Sub

    Private Sub limpiar()


        Me.TextBox_Especialidad.Text = String.Empty



    End Sub

    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM ESPECIALIDAD WHERE 
MEDICO_NUMERO_EMPLEADO='" & Me.TextBox_Numero_Empleado.Text & "'  AND NOMBRE_MEDICO='" & Me.TextBox_Nombre.Text & "' AND EDAD_MEDICO='" & Me.TextBox_Edad.Text & "' AND SEXO_MEDICO='" & Me.TextBox_Sexo.Text & "' AND Especilidad_Medico='" & Me.TextBox_Especialidad.Text & "' AND NUMERO_CEDULA_MEDICO='" & Me.TextBox_Cedula.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE MEDICOS SET MEDICO_NUMERO_EMPLEADO='" & Me.TextBox_Numero_Empleado.Text & "' , NOMBRE_MEDICO='" & Me.TextBox_Nombre.Text & "' , EDAD_MEDICO='" & Me.TextBox_Edad.Text & "' , SEXO_MEDICO='" & Me.TextBox_Sexo.Text & "' , Especilidad_Medico='" & Me.TextBox_Especialidad.Text & "' , NUMERO_CEDULA_MEDICO='" & Me.TextBox_Cedula.Text & "'WHERE MEDICO_NUMERO_EMPLEADO = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Forms_Medicos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class