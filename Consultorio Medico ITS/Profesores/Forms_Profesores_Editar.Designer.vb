<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Profesores_Editar
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
        Me.TextBox_Nombre_Profesor = New System.Windows.Forms.TextBox()
        Me.Label_Especialidad = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Button()
        Me.Label_Apellido_2 = New System.Windows.Forms.Label()
        Me.Label_Apellido_1 = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Departamento = New System.Windows.Forms.Label()
        Me.Label_Numero_Empleado = New System.Windows.Forms.Label()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellidos = New System.Windows.Forms.TextBox()
        Me.TextBox_Numero_Empleado = New System.Windows.Forms.TextBox()
        Me.Radio_Carrera = New System.Windows.Forms.RadioButton()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox_Nombre_Profesor
        '
        Me.TextBox_Nombre_Profesor.Location = New System.Drawing.Point(201, 216)
        Me.TextBox_Nombre_Profesor.Name = "TextBox_Nombre_Profesor"
        Me.TextBox_Nombre_Profesor.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Nombre_Profesor.TabIndex = 64
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(24, 218)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(65, 20)
        Me.Label_Especialidad.TabIndex = 63
        Me.Label_Especialidad.Text = "Nombre"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(28, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 62
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Label_Apellido_2
        '
        Me.Label_Apellido_2.AutoSize = True
        Me.Label_Apellido_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_2.Location = New System.Drawing.Point(24, 332)
        Me.Label_Apellido_2.Name = "Label_Apellido_2"
        Me.Label_Apellido_2.Size = New System.Drawing.Size(137, 20)
        Me.Label_Apellido_2.TabIndex = 61
        Me.Label_Apellido_2.Text = "Fecha Nacimiento"
        '
        'Label_Apellido_1
        '
        Me.Label_Apellido_1.AutoSize = True
        Me.Label_Apellido_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_1.Location = New System.Drawing.Point(24, 293)
        Me.Label_Apellido_1.Name = "Label_Apellido_1"
        Me.Label_Apellido_1.Size = New System.Drawing.Size(71, 20)
        Me.Label_Apellido_1.TabIndex = 60
        Me.Label_Apellido_1.Text = "Telefono"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(24, 253)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(73, 20)
        Me.Label_Nombre.TabIndex = 59
        Me.Label_Nombre.Text = "Apellidos"
        '
        'Label_Departamento
        '
        Me.Label_Departamento.AutoSize = True
        Me.Label_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Departamento.Location = New System.Drawing.Point(24, 180)
        Me.Label_Departamento.Name = "Label_Departamento"
        Me.Label_Departamento.Size = New System.Drawing.Size(112, 20)
        Me.Label_Departamento.TabIndex = 58
        Me.Label_Departamento.Text = "Departamento"
        '
        'Label_Numero_Empleado
        '
        Me.Label_Numero_Empleado.AutoSize = True
        Me.Label_Numero_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Numero_Empleado.Location = New System.Drawing.Point(24, 138)
        Me.Label_Numero_Empleado.Name = "Label_Numero_Empleado"
        Me.Label_Numero_Empleado.Size = New System.Drawing.Size(161, 20)
        Me.Label_Numero_Empleado.TabIndex = 57
        Me.Label_Numero_Empleado.Text = "Numero de empleado"
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(201, 334)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Fecha.TabIndex = 56
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.Location = New System.Drawing.Point(201, 295)
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Telefono.TabIndex = 55
        '
        'TextBox_Apellidos
        '
        Me.TextBox_Apellidos.Location = New System.Drawing.Point(201, 255)
        Me.TextBox_Apellidos.Name = "TextBox_Apellidos"
        Me.TextBox_Apellidos.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Apellidos.TabIndex = 54
        '
        'TextBox_Numero_Empleado
        '
        Me.TextBox_Numero_Empleado.Location = New System.Drawing.Point(201, 140)
        Me.TextBox_Numero_Empleado.Name = "TextBox_Numero_Empleado"
        Me.TextBox_Numero_Empleado.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Numero_Empleado.TabIndex = 53
        '
        'Radio_Carrera
        '
        Me.Radio_Carrera.AutoSize = True
        Me.Radio_Carrera.Checked = True
        Me.Radio_Carrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Carrera.Location = New System.Drawing.Point(301, 48)
        Me.Radio_Carrera.Name = "Radio_Carrera"
        Me.Radio_Carrera.Size = New System.Drawing.Size(157, 20)
        Me.Radio_Carrera.TabIndex = 86
        Me.Radio_Carrera.TabStop = True
        Me.Radio_Carrera.Text = "Numero de empleado"
        Me.Radio_Carrera.UseVisualStyleBackColor = True
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(532, 89)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 85
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(478, 49)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Buscar.TabIndex = 87
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Location = New System.Drawing.Point(581, 507)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 89
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Location = New System.Drawing.Point(454, 507)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 88
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(201, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 90
        '
        'Forms_Profesores_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.TextBox_Buscar)
        Me.Controls.Add(Me.Radio_Carrera)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.TextBox_Nombre_Profesor)
        Me.Controls.Add(Me.Label_Especialidad)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Label_Apellido_2)
        Me.Controls.Add(Me.Label_Apellido_1)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Departamento)
        Me.Controls.Add(Me.Label_Numero_Empleado)
        Me.Controls.Add(Me.TextBox_Fecha)
        Me.Controls.Add(Me.TextBox_Telefono)
        Me.Controls.Add(Me.TextBox_Apellidos)
        Me.Controls.Add(Me.TextBox_Numero_Empleado)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Profesores_Editar"
        Me.Text = "Forms_Profesores_Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Nombre_Profesor As TextBox
    Friend WithEvents Label_Especialidad As Label
    Friend WithEvents X As Button
    Friend WithEvents Label_Apellido_2 As Label
    Friend WithEvents Label_Apellido_1 As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Departamento As Label
    Friend WithEvents Label_Numero_Empleado As Label
    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Telefono As TextBox
    Friend WithEvents TextBox_Apellidos As TextBox
    Friend WithEvents TextBox_Numero_Empleado As TextBox
    Friend WithEvents Radio_Carrera As RadioButton
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_Buscar As TextBox
    Friend WithEvents Button1_Actualizar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
