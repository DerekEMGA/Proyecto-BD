Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class Forms_Consultas_Ver

    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub



    Public Sub Ver()
        conexion.Open()
        Dim dt As New SqlDataAdapter
        dt = New SqlDataAdapter("select citas_id_citas,num_receta,fecha,hora,cantidad_medicamento,observaciones ,id_medicamento,nombre from medicamentos_receta", conexion)
        Dim ds As New DataSet()

        dt.Fill(ds, "MEDICAMENTOS_RECETA")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "MEDICAMENTOS_RECETA"
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ver()
    End Sub

    Private Sub Forms_Consultas_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class