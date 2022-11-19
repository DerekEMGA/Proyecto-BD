Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form_Citas_Ver


    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub



    Public Sub Ver()
        conexion.Open()
        Dim dt As New SqlDataAdapter
        dt = New SqlDataAdapter("SELECT * FROM CITAS", conexion)
        Dim ds As New DataSet()

        dt.Fill(ds, "CITAS")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CITAS"
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ver()
    End Sub
End Class