
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Forms_Medicamentos_Editar
    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click

        If Radio_Almacen.Checked = True Then
            BuscarCarrera()
        Else MsgBox("Datos no encontrados", MsgBoxStyle.Exclamation, "Confirmado")

        End If

        If TextBox_Buscar.Text = String.Empty Then
            limpiar()
        End If

    End Sub


    Private Sub BuscarCarrera()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM MEDICAMENTOS_ALMACEN WHERE ID_MEDICAMENTO = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "MEDICAMENTOS_ALMACEN")

        Me.TextBox_Id_Medicamento.Text = ds.Tables("MEDICAMENTOS_ALMACEN").Rows(0).Item(0)

        Me.TextBox_Nombre.Text = ds.Tables("MEDICAMENTOS_ALMACEN").Rows(0).Item(1)

        conexion.Close()

    End Sub

    Private Sub limpiar()


        Me.TextBox_Id_Medicamento.Text = String.Empty
        Me.TextBox_Nombre.Text = String.Empty


    End Sub

    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM MEDICAMENTOS_ALMACEN WHERE ID_MEDICAMENTO = '" & Me.TextBox_Id_Medicamento.Text & "' AND NOMBRE='" & Me.TextBox_Nombre.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE MEDICAMENTOS_ALMACEN SET ID_MEDICAMENTO = '" & Me.TextBox_Id_Medicamento.Text & "', NOMBRE='" & Me.TextBox_Nombre.Text & "' WHERE ID_MEDICAMENTO='" & Me.TextBox_Buscar.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Forms_Medicamentos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class