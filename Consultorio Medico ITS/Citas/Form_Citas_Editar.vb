
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form_Citas_Editar


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

        If RadioButton1.Checked = True Then
            BuscarCarrera_Alumno()
        Else 'MsgBox("Datos no encontrados", MsgBoxStyle.Exclamation, "Confirmado")

        End If

        If RadioButton2.Checked = True Then
            BuscarCarrera_Maestro()
        End If

    End Sub



    Private Sub BuscarCarrera_Alumno()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM CITAS  WHERE ID_CITAS = '" & Me.ComboBox1.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "CITAS")


        Me.TextBox_Id_Cita.Text = ds.Tables("CITAS").Rows(0).Item(0)


        Me.ComboBox2.Text = ds.Tables("CITAS").Rows(0).Item(1)




        Me.ComboBox4.Text = ds.Tables("CITAS").Rows(0).Item(3)

        Me.TextBox_Fecha.Text = ds.Tables("CITAS").Rows(0).Item(4)


        Me.TextBox_Hora.Text = ds.Tables("CITAS").Rows(0).Item(5)



        ComboBox3.Text = "Selecione"
        conexion.Close()

    End Sub

    Private Sub BuscarCarrera_Maestro()
        conexion.Open()
        Dim datos_Carrera As New SqlDataAdapter("SELECT * FROM CITAS  WHERE ID_CITAS = '" & Me.ComboBox1.Text & "' ", conexion)

        Dim ds As New DataSet()

        datos_Carrera.Fill(ds, "CITAS")


        Me.TextBox_Id_Cita.Text = ds.Tables("CITAS").Rows(0).Item(0)


        Me.ComboBox2.Text = ds.Tables("CITAS").Rows(0).Item(1)


        Me.ComboBox3.Text = ds.Tables("CITAS").Rows(0).Item(2)

        Me.ComboBox4.Text = ds.Tables("CITAS").Rows(0).Item(3)

        Me.TextBox_Fecha.Text = ds.Tables("CITAS").Rows(0).Item(4)


        Me.TextBox_Hora.Text = ds.Tables("CITAS").Rows(0).Item(5)


        ComboBox4.Text = "Selecione"

        conexion.Close()

    End Sub



    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM CITAS WHERE ID_CITAS = '" & Me.TextBox_Id_Cita.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE CITAS SET 
ID_CITAS='" & Me.TextBox_Id_Cita.Text & "',
MEDICOS_MEDICO_NUMERO_EMPLEADO='" & Me.ComboBox2.Text & "',
MAESTRO_NUMERO_EMPLEADO='" & Me.ComboBox3.Text & "',
ALUMNO_MATRICULA='" & Me.ComboBox4.Text & "',
FECHA='" & Me.TextBox_Fecha.Text & "',
HORA='" & Me.TextBox_Hora.Text & "'
         WHERE ID_CITAS='" & Me.ComboBox1.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub




    Private Sub Forms_Citas_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strComando = "SELECT ID_CITAS FROM CITAS"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data, "CITAS")
        ComboBox1.Text = "Selecione"
        ComboBox1.DataSource = data.Tables(0)
        ComboBox1.DisplayMember = "ID_CITAS"

    End Sub
    Private Sub Forms_Medicos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Text = "Selecione"
        strComando = "SELECT MEDICO_NUMERO_EMPLEADO FROM MEDICOS"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data, "MEDICOS")

        ComboBox2.DataSource = data.Tables(0)
        ComboBox2.DisplayMember = "MEDICO_NUMERO_EMPLEADO"

    End Sub

    Private Sub Forms_Profesores_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strComando = "SELECT NUMERO_EMPLEADO FROM MAESTRO"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data)
        ComboBox3.DataSource = data.Tables(0)
        ComboBox3.DisplayMember = "NUMERO_EMPLEADO"

    End Sub

    Private Sub Forms_Alumnos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strComando = "SELECT MATRICULA FROM ALUMNO"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data)
        ComboBox4.DataSource = data.Tables(0)
        ComboBox4.DisplayMember = "MATRICULA"

    End Sub
End Class