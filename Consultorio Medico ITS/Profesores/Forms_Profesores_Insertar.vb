
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Forms_Profesores_Insertar


    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand

    Dim strComando As String

    Dim adapter As SqlDataAdapter

    Dim data As DataSet

    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")


    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Button1_Insertar_Click(sender As Object, e As EventArgs) Handles Button1_Insertar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim query As String = String.Empty


        Dim cmd As New SqlCommand("INSERT INTO MAESTRO(NUMERO_EMPLEADO,DEPARTAMENTO_DEPARTAMENTO,APELLIDOPATERNO,APELLIDOMATERNO,TELEFONO,FECHANACIMIENTO) VALUES
         ('" & Me.TextBox_Numero_Empleado.Text & "','" & Me.ComboBox1.Text & "','" & Me.TextBox_Nombre_Profesor.Text & "','" & Me.TextBox_Apellidos.Text & "','" & Me.TextBox_Telefono.Text & "','" & Me.TextBox_Fecha.Text & "')", conexion)

        cmd.ExecuteNonQuery()



        MsgBox("Datos ingresados correctamente...", MsgBoxStyle.Information, "Confirmar")

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Forms_Departamento_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strComando = "SELECT * FROM DEPARTAMENTO"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        Data = New DataSet
        adapter.Fill(Data)
        ComboBox1.DataSource = Data.Tables(0)
        ComboBox1.DisplayMember = "DEPARTAMENTO"

    End Sub

End Class
