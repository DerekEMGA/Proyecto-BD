Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Forms_Departamento_Editar
    Dim ver As SqlDataAdapter

    Dim comando As SqlCommand

    Dim strComando As String

    Dim adapter As SqlDataAdapter

    Dim data As DataSet

    Dim conexion As New SqlConnection("Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550")



    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub






    Dim comando_Eliminar As New SqlCommand

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("DELETE FROM DEPARTAMENTO WHERE DEPARTAMENTO = '" & Me.TextBox_Departamento.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Eliminado correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub Button1_Actualizar_Click(sender As Object, e As EventArgs) Handles Button1_Actualizar.Click


        conexion.Open()



        Dim cmd As New SqlCommand("UPDATE DEPARTAMENTO SET DEPARTAMENTO = '" & Me.TextBox_Departamento.Text & "' WHERE DEPARTAMENTO='" & Me.ComboBox1.Text & "' ", conexion)

        cmd.ExecuteNonQuery()


        MsgBox("Actualizados correctamente", vbInformation, "Aviso")


        conexion.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged




        conexion.Close()
    End Sub

    Private Sub Forms_Departamento_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strComando = "SELECT * FROM DEPARTAMENTO"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data)
        ComboBox1.DataSource = data.Tables(0)
        ComboBox1.DisplayMember = "DEPARTAMENTO"

    End Sub

    Private Sub Radio_Departamento_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Departamento.CheckedChanged

    End Sub
End Class