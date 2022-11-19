
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Consultorio_Medico_ITS.Forms_Consultas_Insertar

Public Class Forms_Consulta_Insertar_Proxima


    Dim ver As Integer



    Dim strComando As String

    Dim adapter As SqlDataAdapter

    Dim data As DataSet




    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")





    Public Sub BuscarCita_Sin_Maestro()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM CITAS  WHERE ID_CITAS = '" & Me.TextBox_Id.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "CITAS")


        Me.TextBox_Medico.Text = ds.Tables("CITAS").Rows(0).Item(1)


        Me.TextBox_Alumno.Text = ds.Tables("CITAS").Rows(0).Item(3)




        conexion.Close()

    End Sub

    Public Sub BuscarCita_Sin_Alumno()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM CITAS  WHERE ID_CITAS = '" & Me.TextBox_Id.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "CITAS")


        Me.TextBox_Medico.Text = ds.Tables("CITAS").Rows(0).Item(1)


        Me.TextBox_Maestro.Text = ds.Tables("CITAS").Rows(0).Item(2)





        conexion.Close()

    End Sub


    Public Sub Medicamentos()

        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM MEDICAMENTOS_ALMACEN WHERE ID_MEDICAMENTO = '" & ver & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "MEDICAMENTOS_ALMACEN")


        Me.TextBox_Medicamento.Text = ds.Tables("MEDICAMENTOS_ALMACEN").Rows(0).Item(1)

        conexion.Close()

    End Sub

    Private Sub BuscarCarrera()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM MEDICAMENTOS_ALMACEN WHERE ID_MEDICAMENTO = '" & Me.TextBox_ID_Medicamento.Text & "'", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "MEDICAMENTOS_ALMACEN")

        Me.TextBox_Medicamento.Text = ds.Tables("MEDICAMENTOS_ALMACEN").Rows(0).Item(1)

        conexion.Close()

    End Sub




    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click

        BuscarCarrera()

    End Sub

    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim query As String = String.Empty


        Dim cmd As New SqlCommand("INSERT INTO MEDICAMENTOS_RECETA(CITAS_ID_CITAS,NUM_RECETA,FECHA,HORA,ID_MEDICAMENTO,OBSERVACIONES,CANTIDAD_MEDICAMENTO,NOMBRE) VALUES
         ('" & Me.TextBox_Id.Text & "',
         '" & Me.TextBox_Num_Receta.Text & "',
         '" & Me.TextBox_Fecha.Text & "',
         '" & Me.TextBox_Hora.Text & "',
         '" & Me.TextBox_ID_Medicamento.Text & "',
         '" & Me.TextBox_Observacion.Text & "',
         '" & Me.TextBox_Cantidad.Text & "',
         '" & Me.TextBox_Medicamento.Text & "'
         )", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Forms_Consulta_Insertar_Proxima_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class