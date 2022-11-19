
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Consultorio_Medico_ITS.Forms_Consulta_Insertar_Proxima
Public Class Forms_Consultas_Insertar

    Private dv As New DataView

    Public comprobar As String




    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")

    Private currentForm As Form = Nothing
    Public Sub openContenedor(contenedor As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = contenedor
        contenedor.TopLevel = False
        contenedor.FormBorderStyle = FormBorderStyle.None
        contenedor.Dock = DockStyle.Fill

        contenedor.BringToFront()
        contenedor.Show()


    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Forms_Consultas_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultorio_medicoDataSet1.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.Consultorio_medicoDataSet1.Citas)
        'TODO: esta línea de código carga datos en la tabla 'Consultorio_medicoDataSet.Revision' Puede moverla o quitarla según sea necesario.
        Me.RevisionTableAdapter.Fill(Me.Consultorio_medicoDataSet.Revision)

        Dim da As New SqlDataAdapter("SELECT * FROM CITAS", conexion)

        Dim ds As New DataSet

        da.Fill(ds)

        dv.Table = ds.Tables(0)

        DataGridView1.DataSource = dv

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        dv.RowFilter = String.Format("Fecha='" & Me.TextBox1.Text & "'", TextBox1.Text)
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        TextBox_Id_Cita.Text = DataGridView1.Item(0, i).Value()
        TextBox_Fecha.Text = DataGridView1.Item(4, i).Value()
        TextBox_Hora.Text = DataGridView1.Item(5, i).Value()

        comprobar = TextBox_Id_Cita.Text

        Forms_Consulta_Insertar_Proxima.TextBox_Id.Text = comprobar
        Forms_Consulta_Insertar_Proxima.TextBox_Fecha.Text = TextBox_Fecha.Text
        Forms_Consulta_Insertar_Proxima.TextBox_Hora.Text = TextBox_Hora.Text
        Forms_Consulta_Insertar_Proxima.TextBox_Num_Receta.Text = comprobar
    End Sub

    Private Sub Button_Insertar_Click(sender As Object, e As EventArgs) Handles Button_Insertar.Click
        Nueva_Consulta()


        If RadioButton1.Checked = True Then
            Forms_Consulta_Insertar_Proxima.BuscarCita_Sin_Maestro()
            Forms_Consulta_Insertar_Proxima.TextBox_Maestro.Text = " "
        Else 'MsgBox("Datos no encontrados", MsgBoxStyle.Exclamation, "Confirmado")

        End If

        If RadioButton2.Checked = True Then
            Forms_Consulta_Insertar_Proxima.BuscarCita_Sin_Alumno()
            Forms_Consulta_Insertar_Proxima.TextBox_Alumno.Text = " "

        End If

    End Sub

    Public Sub Nueva_Consulta()
        conexion.Open()
        Dim cmd As New SqlCommand("SELECT ID_CITAS FROM CITAS WHERE ID_CITAS='" & Me.comprobar & "' ", conexion)

        cmd.ExecuteNonQuery()


        If comprobar = TextBox_Id_Cita.Text Then
            Forms_Consulta_Insertar_Proxima.Show()


        End If
        conexion.Close()



    End Sub






End Class