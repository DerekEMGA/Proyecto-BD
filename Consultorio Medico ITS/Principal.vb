Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()

    End Sub

    Public Sub hideSubmenu()
        Panel_Carreras.Visible = False
        Panel_Consultas.Visible = False
        Panel_Alumnos.Visible = False
        Panel_Departamento.Visible = False
        Panel_Medicos.Visible = False

    End Sub


End Class