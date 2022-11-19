Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Forms_Profesores_Editar


    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand

    Dim strComando As String

    Dim adapter As SqlDataAdapter

    Dim data As DataSet



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

        End If

    End Sub

    Private Sub BuscarCarrera()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM MAESTRO WHERE NUMERO_EMPLEADO = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "MAESTRO")


        Me.TextBox_Numero_Empleado.Text = ds.Tables("MAESTRO").Rows(0).Item(0)


        Me.ComboBox1.Text = ds.Tables("MAESTRO").Rows(0).Item(1)


        Me.TextBox_Nombre_Profesor.Text = ds.Tables("MAESTRO").Rows(0).Item(2)

        Me.TextBox_Apellidos.Text = ds.Tables("MAESTRO").Rows(0).Item(3)

        Me.TextBox_Telefono.Text = ds.Tables("MAESTRO").Rows(0).Item(4)


        Me.TextBox_Fecha.Text = ds.Tables("MAESTRO").Rows(0).Item(5)




        conexion.Close()

    End Sub



    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM MAESTRO WHERE NUMERO_EMPLEADO = '" & Me.TextBox_Buscar.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE MAESTRO SET 
NUMERO_EMPLEADO='" & Me.TextBox_Numero_Empleado.Text & "',
DEPARTAMENTO_DEPARTAMENTO='" & Me.ComboBox1.Text & "',
APELLIDOPATERNO='" & Me.TextBox_Nombre_Profesor.Text & "',
APELLIDOMATERNO='" & Me.TextBox_Apellidos.Text & "',
TELEFONO='" & Me.TextBox_Telefono.Text & "',
FECHANACIMIENTO='" & Me.TextBox_Fecha.Text & "' 
 WHERE NUMERO_EMPLEADO ='" & Me.TextBox_Numero_Empleado.Text & "'", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

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