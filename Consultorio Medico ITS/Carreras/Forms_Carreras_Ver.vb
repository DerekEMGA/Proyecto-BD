Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Forms_Carreras_Ver


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub Button1_Ver_Click(sender As Object, e As EventArgs)
        Ver()
    End Sub

    Public Sub Ver()
        conexion.Open()
        Dim dt As New SqlDataAdapter
        dt = New SqlDataAdapter("SELECT * FROM ESPECIALIDAD", conexion)
        Dim ds As New DataSet()

        dt.Fill(ds, "ESPECIALIDAD")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "ESPECIALIDAD"
        conexion.Close()
    End Sub

    Private Sub Forms_Carreras_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultorio_medicoDataSet1.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.Consultorio_medicoDataSet1.Especialidad)

    End Sub
End Class