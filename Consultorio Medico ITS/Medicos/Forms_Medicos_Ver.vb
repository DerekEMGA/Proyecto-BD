
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Forms_Medicos_Ver
    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Public Sub Ver()
        conexion.Open()
        Dim dt As New SqlDataAdapter
        dt = New SqlDataAdapter("select * from medicos", conexion)
        Dim ds As New DataSet()

        dt.Fill(ds, "medicos")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "medicos"
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ver()
    End Sub

End Class