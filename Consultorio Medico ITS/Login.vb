Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Login

    Private ReadOnly Tabla As Object
    Dim conexion As New SqlConnection

    Dim estado As String

#Region "Conexion a la base de datos"


    Public Sub conectar()
        Try
            conexion.ConnectionString = "Data Source=DEREK-EMIR\SQLEXPRESS;Initial Catalog=consultorio_medico;User ID=sa;Password=1550"
            conexion.Open()
            estado = "conectado"

        Catch ex As Exception

            estado = "La interfaz no esta activa"
            Txt_Usuario.Text = "LLENAR"
            Txt_Contraseña.Text = "LLENAR"

        End Try
    End Sub

#End Region





#Region "Boton entrar"


    Private Sub Btn_Entrar_Click(sender As Object, e As EventArgs) Handles Btn_Entrar.Click

        Try

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()

            End If

            Dim query As String = String.Empty

            'Comando para el select de la tabla usuarios y que recibe los textos de los cuadros
            'de usuario y el de contraseña
            query = "SELECT * FROM usuarios WHERE Nombre='" & Txt_Usuario.Text & "' AND Password_1='" & Txt_Contraseña.Text & "'"


            Dim comando As SqlCommand

            'Variable de tipo mysqlcommando recibe los datos de a variable query
            'y la conexion a la base de datos

            comando = New SqlCommand(query, conexion)

            Dim tabla As SqlDataReader

            'la variable tabla recibe el comando con el query y la conexion
            'y se le da el atributo para poder leerlo

            tabla = comando.ExecuteReader

            Dim cantidad As Integer = 0

            'leer lo que esta dentro de la variable tabla y lo lea de una fila en 
            'una fila
            While tabla.Read
                cantidad += 1
            End While

            'si cantidad encuentra algun dato que sea igual al txt_usuario
            'Y el txt_Contraseña

            If cantidad = 1 Then
                MsgBox("Usuario y contraseña Correctos")

                Me.Hide()
                'El Me.Hide() esconde el Login.vb cuando lo encuentra

                Principal.Show()

                'Mostrar el menu general de la base de datos

            ElseIf cantidad > 1 Then

                MsgBox("Error datos duplicados")
                'Muestra si encuentra datos duplicaos


                Txt_Usuario.Text = ""
                Txt_Contraseña.Text = ""

            ElseIf Txt_Contraseña.Text = "" Or Txt_Usuario.Text = "" Then
                MsgBox("Algun campo de usuario o contraseña esta vacio porfavor de comprobar los datos")
                'Comprueba y le dice al usuario si tiene algun campo vacio


                Txt_Usuario.Text = ""
                Txt_Contraseña.Text = ""
            Else
                MsgBox("Usuario y contraseña no validos")
                'Si el usuario no es valido le dice al usuario con un mensaje


                Txt_Usuario.Text = ""
                Txt_Contraseña.Text = ""
            End If
            conexion.Close()


        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            'Limpiar y desechar el cache de la conexion1 a la base de datps
            conexion.Dispose()



        End Try
    End Sub


#End Region




#Region "Boton salir"

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
        'Boton salir con el Me.Close() cierra la pantalla del Login.vb
    End Sub
#End Region

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        Label1.Text = estado

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        conexion.Close()

    End Sub

    Private Sub Btn_Programador_Click(sender As Object, e As EventArgs) Handles Btn_Programador.Click

        Me.Hide()

        Principal.show()

    End Sub
End Class
