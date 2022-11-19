Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Form_Citas_Insertar


    Dim comando As SqlCommand


    Dim contador As Double


    Dim Fecha As String

    Dim Hora As String

    Dim strComando As String

    Dim adapter As SqlDataAdapter

    Dim data As DataSet

    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub




    Private Sub Forms_Profesores_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox2.Text = "Selecione"
        ComboBox1.Text = "Selecione"



    End Sub



    Private Sub Forms_Alumnos_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox3.Text = "Selecione"

    End Sub







    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Fecha = DateTimePicker1.Text

        Label2.Text = DateTimePicker1.Text

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged




        Label3.Text = DateTimePicker2.Value.ToShortTimeString

        Hora = Label3.Text



    End Sub









    Private Sub Form_Citas_Insertar_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove


        If ComboBox1.Text = "Selecione" Then

            Label4.Text = "Nombre"



        Else

            Dim nombre_medico As New SqlDataAdapter("SELECT NOMBRE_MEDICO FROM MEDICOS WHERE MEDICO_NUMERO_EMPLEADO= '" & ComboBox1.Text & "' ", conexion)

            Dim Ls As New DataSet()

            nombre_medico.Fill(Ls, "MEDICOS")


            Label4.Text = Ls.Tables("MEDICOS").Rows(0).Item(0)



        End If


        If ComboBox2.Text = "Selecione" Then

            Label6.Text = "Nombre"

            Label8.Text = "Apellido"

        Else
            Dim nombre_Profesor As New SqlDataAdapter("SELECT APELLIDOPATERNO,APELLIDOMATERNO FROM MAESTRO WHERE NUMERO_EMPLEADO= '" & ComboBox2.Text & "' ", conexion)

            Dim ds As New DataSet()

            nombre_Profesor.Fill(ds, "MAESTRO")


            Label6.Text = ds.Tables("MAESTRO").Rows(0).Item(0)

            Label8.Text = ds.Tables("MAESTRO").Rows(0).Item(1)

        End If



        If ComboBox3.Text = "Selecione" Then

            Label7.Text = "Nombre"
            Label9.Text = "Apellido"

        Else
            Dim nombre_Alumno As New SqlDataAdapter("SELECT NOMBRE,APELLIDO_PATERNO FROM ALUMNO WHERE MATRICULA = '" & ComboBox3.Text & "' ", conexion)

            Dim ds As New DataSet()

            nombre_Alumno.Fill(ds, "ALUMNO")


            Me.Label7.Text = ds.Tables("ALUMNO").Rows(0).Item(0)


            Me.Label9.Text = ds.Tables("ALUMNO").Rows(0).Item(1)



        End If

        Dim ID_CITAS As New SqlDataAdapter("SELECT TOP(1) ID_CITAS FROM CITAS ORDER BY ID_CITAS DESC ", conexion)

        Dim contador As Double

        Dim contador_1 As String

        Dim ps As New DataSet()

        ID_CITAS.Fill(ps, "CITAS")


        contador_1 = ps.Tables("CITAS").Rows(0).Item(0)


        contador = 1 + contador_1


        Label5.Text = contador

    End Sub

    Private Sub Form_Citas_Insertar_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.MouseEnter

    End Sub



    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click

        strComando = "SELECT NUMERO_EMPLEADO FROM MAESTRO"

            adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
            data = New DataSet
            adapter.Fill(data)

            ComboBox2.DataSource = data.Tables(0)
            ComboBox2.DisplayMember = "NUMERO_EMPLEADO"

        ComboBox3.Text = "Selecione"
    End Sub

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click

        strComando = "SELECT MATRICULA FROM ALUMNO"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data)
        ComboBox3.DataSource = data.Tables(0)
        ComboBox3.DisplayMember = "MATRICULA"

        ComboBox2.Text = "Selecione"

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click

        strComando = "SELECT MEDICO_NUMERO_EMPLEADO FROM MEDICOS"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data, "MEDICOS")
        ComboBox1.Text = "Selecione"
        ComboBox1.DataSource = data.Tables(0)
        ComboBox1.DisplayMember = "MEDICO_NUMERO_EMPLEADO"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ComboBox2.Text = "selecione" Then

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Dim query As String = String.Empty


            Dim cmd As New SqlCommand("INSERT INTO CITAS(MEDICOS_MEDICO_NUMERO_EMPLEADO,ALUMNO_MATRICULA,FECHA,HORA) VALUES
         ('" & Me.ComboBox1.Text & "','" & Me.ComboBox3.Text & "','" & Me.Fecha & "','" & Hora & "'
         )", conexion)

            cmd.ExecuteNonQuery()



            MsgBox("Datos ingresados correctamente del alumno", MsgBoxStyle.Information, "Confirmar")

            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If

        End If

        If ComboBox3.Text = "Selecione" Then


            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Dim query As String = String.Empty


            Dim cmd As New SqlCommand("INSERT INTO CITAS(MEDICOS_MEDICO_NUMERO_EMPLEADO,MAESTRO_NUMERO_EMPLEADO,FECHA,HORA) VALUES
         ('" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Fecha & "','" & Hora & "')", conexion)

            cmd.ExecuteNonQuery()



            MsgBox("Datos ingresados correctamente del profesor", MsgBoxStyle.Information, "Confirmar")

            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If


        End If

    End Sub
End Class