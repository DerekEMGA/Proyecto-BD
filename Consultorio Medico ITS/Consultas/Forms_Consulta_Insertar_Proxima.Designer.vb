<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Consulta_Insertar_Proxima
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forms_Consulta_Insertar_Proxima))
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Hora = New System.Windows.Forms.TextBox()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.TextBox_Num_Receta = New System.Windows.Forms.TextBox()
        Me.TextBox_Observacion = New System.Windows.Forms.TextBox()
        Me.Label_Observacion = New System.Windows.Forms.Label()
        Me.Label_Fecha = New System.Windows.Forms.Label()
        Me.Label_Hora = New System.Windows.Forms.Label()
        Me.Label_Id = New System.Windows.Forms.Label()
        Me.Label_Num_receta = New System.Windows.Forms.Label()
        Me.Button_Guardar = New System.Windows.Forms.Button()
        Me.Label_Maestro = New System.Windows.Forms.Label()
        Me.Label_Alumno = New System.Windows.Forms.Label()
        Me.Label_Medicamento = New System.Windows.Forms.Label()
        Me.Label_Medico = New System.Windows.Forms.Label()
        Me.TextBox_Maestro = New System.Windows.Forms.TextBox()
        Me.TextBox_Alumno = New System.Windows.Forms.TextBox()
        Me.TextBox_Medicamento = New System.Windows.Forms.TextBox()
        Me.TextBox_Medico = New System.Windows.Forms.TextBox()
        Me.Label_Cantidad = New System.Windows.Forms.Label()
        Me.Label_Id_Medicamento = New System.Windows.Forms.Label()
        Me.TextBox_Cantidad = New System.Windows.Forms.TextBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_ID_Medicamento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(402, 58)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Fecha.TabIndex = 0
        '
        'TextBox_Hora
        '
        Me.TextBox_Hora.Location = New System.Drawing.Point(554, 58)
        Me.TextBox_Hora.Name = "TextBox_Hora"
        Me.TextBox_Hora.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Hora.TabIndex = 1
        '
        'TextBox_Id
        '
        Me.TextBox_Id.Location = New System.Drawing.Point(79, 58)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Id.TabIndex = 2
        '
        'TextBox_Num_Receta
        '
        Me.TextBox_Num_Receta.Location = New System.Drawing.Point(250, 58)
        Me.TextBox_Num_Receta.Name = "TextBox_Num_Receta"
        Me.TextBox_Num_Receta.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Num_Receta.TabIndex = 3
        '
        'TextBox_Observacion
        '
        Me.TextBox_Observacion.Location = New System.Drawing.Point(66, 158)
        Me.TextBox_Observacion.Multiline = True
        Me.TextBox_Observacion.Name = "TextBox_Observacion"
        Me.TextBox_Observacion.Size = New System.Drawing.Size(396, 383)
        Me.TextBox_Observacion.TabIndex = 4
        '
        'Label_Observacion
        '
        Me.Label_Observacion.AutoSize = True
        Me.Label_Observacion.Location = New System.Drawing.Point(63, 142)
        Me.Label_Observacion.Name = "Label_Observacion"
        Me.Label_Observacion.Size = New System.Drawing.Size(67, 13)
        Me.Label_Observacion.TabIndex = 5
        Me.Label_Observacion.Text = "Observacion"
        '
        'Label_Fecha
        '
        Me.Label_Fecha.AutoSize = True
        Me.Label_Fecha.Location = New System.Drawing.Point(399, 42)
        Me.Label_Fecha.Name = "Label_Fecha"
        Me.Label_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Label_Fecha.TabIndex = 6
        Me.Label_Fecha.Text = "Fecha"
        '
        'Label_Hora
        '
        Me.Label_Hora.AutoSize = True
        Me.Label_Hora.Location = New System.Drawing.Point(551, 42)
        Me.Label_Hora.Name = "Label_Hora"
        Me.Label_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Label_Hora.TabIndex = 7
        Me.Label_Hora.Text = "Hora"
        '
        'Label_Id
        '
        Me.Label_Id.AutoSize = True
        Me.Label_Id.Location = New System.Drawing.Point(83, 42)
        Me.Label_Id.Name = "Label_Id"
        Me.Label_Id.Size = New System.Drawing.Size(79, 13)
        Me.Label_Id.TabIndex = 8
        Me.Label_Id.Text = "Numero de cita"
        '
        'Label_Num_receta
        '
        Me.Label_Num_receta.AutoSize = True
        Me.Label_Num_receta.Location = New System.Drawing.Point(252, 42)
        Me.Label_Num_receta.Name = "Label_Num_receta"
        Me.Label_Num_receta.Size = New System.Drawing.Size(92, 13)
        Me.Label_Num_receta.TabIndex = 9
        Me.Label_Num_receta.Text = "Numero de receta"
        '
        'Button_Guardar
        '
        Me.Button_Guardar.Location = New System.Drawing.Point(847, 588)
        Me.Button_Guardar.Name = "Button_Guardar"
        Me.Button_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Guardar.TabIndex = 10
        Me.Button_Guardar.Text = "Guardar"
        Me.Button_Guardar.UseVisualStyleBackColor = True
        '
        'Label_Maestro
        '
        Me.Label_Maestro.AutoSize = True
        Me.Label_Maestro.Location = New System.Drawing.Point(631, 196)
        Me.Label_Maestro.Name = "Label_Maestro"
        Me.Label_Maestro.Size = New System.Drawing.Size(45, 13)
        Me.Label_Maestro.TabIndex = 18
        Me.Label_Maestro.Text = "Maestro"
        '
        'Label_Alumno
        '
        Me.Label_Alumno.AutoSize = True
        Me.Label_Alumno.Location = New System.Drawing.Point(500, 196)
        Me.Label_Alumno.Name = "Label_Alumno"
        Me.Label_Alumno.Size = New System.Drawing.Size(42, 13)
        Me.Label_Alumno.TabIndex = 17
        Me.Label_Alumno.Text = "Alumno"
        '
        'Label_Medicamento
        '
        Me.Label_Medicamento.AutoSize = True
        Me.Label_Medicamento.Location = New System.Drawing.Point(500, 359)
        Me.Label_Medicamento.Name = "Label_Medicamento"
        Me.Label_Medicamento.Size = New System.Drawing.Size(71, 13)
        Me.Label_Medicamento.TabIndex = 16
        Me.Label_Medicamento.Text = "Medicamento"
        '
        'Label_Medico
        '
        Me.Label_Medico.AutoSize = True
        Me.Label_Medico.Location = New System.Drawing.Point(781, 196)
        Me.Label_Medico.Name = "Label_Medico"
        Me.Label_Medico.Size = New System.Drawing.Size(42, 13)
        Me.Label_Medico.TabIndex = 15
        Me.Label_Medico.Text = "Medico"
        '
        'TextBox_Maestro
        '
        Me.TextBox_Maestro.Location = New System.Drawing.Point(629, 212)
        Me.TextBox_Maestro.Name = "TextBox_Maestro"
        Me.TextBox_Maestro.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Maestro.TabIndex = 14
        '
        'TextBox_Alumno
        '
        Me.TextBox_Alumno.Location = New System.Drawing.Point(496, 212)
        Me.TextBox_Alumno.Name = "TextBox_Alumno"
        Me.TextBox_Alumno.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Alumno.TabIndex = 13
        '
        'TextBox_Medicamento
        '
        Me.TextBox_Medicamento.Location = New System.Drawing.Point(501, 375)
        Me.TextBox_Medicamento.Name = "TextBox_Medicamento"
        Me.TextBox_Medicamento.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Medicamento.TabIndex = 12
        '
        'TextBox_Medico
        '
        Me.TextBox_Medico.Location = New System.Drawing.Point(784, 212)
        Me.TextBox_Medico.Name = "TextBox_Medico"
        Me.TextBox_Medico.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_Medico.TabIndex = 11
        '
        'Label_Cantidad
        '
        Me.Label_Cantidad.AutoSize = True
        Me.Label_Cantidad.Location = New System.Drawing.Point(807, 359)
        Me.Label_Cantidad.Name = "Label_Cantidad"
        Me.Label_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Label_Cantidad.TabIndex = 26
        Me.Label_Cantidad.Text = "Cantidad"
        '
        'Label_Id_Medicamento
        '
        Me.Label_Id_Medicamento.AutoSize = True
        Me.Label_Id_Medicamento.Location = New System.Drawing.Point(631, 359)
        Me.Label_Id_Medicamento.Name = "Label_Id_Medicamento"
        Me.Label_Id_Medicamento.Size = New System.Drawing.Size(127, 13)
        Me.Label_Id_Medicamento.TabIndex = 25
        Me.Label_Id_Medicamento.Text = "Numero del medicamento"
        '
        'TextBox_Cantidad
        '
        Me.TextBox_Cantidad.Location = New System.Drawing.Point(754, 375)
        Me.TextBox_Cantidad.Multiline = True
        Me.TextBox_Cantidad.Name = "TextBox_Cantidad"
        Me.TextBox_Cantidad.Size = New System.Drawing.Size(168, 183)
        Me.TextBox_Cantidad.TabIndex = 22
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(629, 401)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 28
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_ID_Medicamento
        '
        Me.TextBox_ID_Medicamento.Location = New System.Drawing.Point(629, 375)
        Me.TextBox_ID_Medicamento.Name = "TextBox_ID_Medicamento"
        Me.TextBox_ID_Medicamento.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_ID_Medicamento.TabIndex = 29
        '
        'Forms_Consulta_Insertar_Proxima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(934, 623)
        Me.Controls.Add(Me.TextBox_ID_Medicamento)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.Label_Cantidad)
        Me.Controls.Add(Me.Label_Id_Medicamento)
        Me.Controls.Add(Me.TextBox_Cantidad)
        Me.Controls.Add(Me.Label_Maestro)
        Me.Controls.Add(Me.Label_Alumno)
        Me.Controls.Add(Me.Label_Medicamento)
        Me.Controls.Add(Me.Label_Medico)
        Me.Controls.Add(Me.TextBox_Maestro)
        Me.Controls.Add(Me.TextBox_Alumno)
        Me.Controls.Add(Me.TextBox_Medicamento)
        Me.Controls.Add(Me.TextBox_Medico)
        Me.Controls.Add(Me.Button_Guardar)
        Me.Controls.Add(Me.Label_Num_receta)
        Me.Controls.Add(Me.Label_Id)
        Me.Controls.Add(Me.Label_Hora)
        Me.Controls.Add(Me.Label_Fecha)
        Me.Controls.Add(Me.Label_Observacion)
        Me.Controls.Add(Me.TextBox_Observacion)
        Me.Controls.Add(Me.TextBox_Num_Receta)
        Me.Controls.Add(Me.TextBox_Id)
        Me.Controls.Add(Me.TextBox_Hora)
        Me.Controls.Add(Me.TextBox_Fecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 662)
        Me.MinimumSize = New System.Drawing.Size(950, 662)
        Me.Name = "Forms_Consulta_Insertar_Proxima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Hora As TextBox
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents TextBox_Num_Receta As TextBox
    Friend WithEvents TextBox_Observacion As TextBox
    Friend WithEvents Label_Observacion As Label
    Friend WithEvents Label_Fecha As Label
    Friend WithEvents Label_Hora As Label
    Friend WithEvents Label_Id As Label
    Friend WithEvents Label_Num_receta As Label
    Friend WithEvents Button_Guardar As Button
    Friend WithEvents Label_Maestro As Label
    Friend WithEvents Label_Alumno As Label
    Friend WithEvents Label_Medicamento As Label
    Friend WithEvents Label_Medico As Label
    Friend WithEvents TextBox_Maestro As TextBox
    Friend WithEvents TextBox_Alumno As TextBox
    Friend WithEvents TextBox_Medicamento As TextBox
    Friend WithEvents TextBox_Medico As TextBox
    Friend WithEvents Label_Cantidad As Label
    Friend WithEvents Label_Id_Medicamento As Label
    Friend WithEvents TextBox_Cantidad As TextBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_ID_Medicamento As TextBox
End Class
