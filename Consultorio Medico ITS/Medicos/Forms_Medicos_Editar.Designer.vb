<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Medicos_Editar
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
        Me.TextBox_Cedula = New System.Windows.Forms.TextBox()
        Me.TextBox_Especialidad = New System.Windows.Forms.TextBox()
        Me.TextBox_Sexo = New System.Windows.Forms.TextBox()
        Me.TextBox_Edad = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Numero_Empleado = New System.Windows.Forms.TextBox()
        Me.Label_Cedula = New System.Windows.Forms.Label()
        Me.Label_Especialidad = New System.Windows.Forms.Label()
        Me.Label_Sexo = New System.Windows.Forms.Label()
        Me.Label_Edad = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Num_Empleado = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Button()
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Radio_Carrera = New System.Windows.Forms.RadioButton()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_Cedula
        '
        Me.TextBox_Cedula.Location = New System.Drawing.Point(206, 331)
        Me.TextBox_Cedula.Name = "TextBox_Cedula"
        Me.TextBox_Cedula.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Cedula.TabIndex = 41
        '
        'TextBox_Especialidad
        '
        Me.TextBox_Especialidad.Location = New System.Drawing.Point(206, 277)
        Me.TextBox_Especialidad.Name = "TextBox_Especialidad"
        Me.TextBox_Especialidad.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Especialidad.TabIndex = 40
        '
        'TextBox_Sexo
        '
        Me.TextBox_Sexo.Location = New System.Drawing.Point(206, 220)
        Me.TextBox_Sexo.Name = "TextBox_Sexo"
        Me.TextBox_Sexo.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Sexo.TabIndex = 39
        '
        'TextBox_Edad
        '
        Me.TextBox_Edad.Location = New System.Drawing.Point(206, 168)
        Me.TextBox_Edad.Name = "TextBox_Edad"
        Me.TextBox_Edad.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Edad.TabIndex = 38
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(206, 119)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Nombre.TabIndex = 37
        '
        'TextBox_Numero_Empleado
        '
        Me.TextBox_Numero_Empleado.Location = New System.Drawing.Point(206, 69)
        Me.TextBox_Numero_Empleado.Name = "TextBox_Numero_Empleado"
        Me.TextBox_Numero_Empleado.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Numero_Empleado.TabIndex = 36
        '
        'Label_Cedula
        '
        Me.Label_Cedula.AutoSize = True
        Me.Label_Cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Cedula.Location = New System.Drawing.Point(12, 331)
        Me.Label_Cedula.Name = "Label_Cedula"
        Me.Label_Cedula.Size = New System.Drawing.Size(138, 20)
        Me.Label_Cedula.TabIndex = 35
        Me.Label_Cedula.Text = "Numero de cedula"
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(12, 275)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(99, 20)
        Me.Label_Especialidad.TabIndex = 34
        Me.Label_Especialidad.Text = "Especialidad"
        '
        'Label_Sexo
        '
        Me.Label_Sexo.AutoSize = True
        Me.Label_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sexo.Location = New System.Drawing.Point(12, 220)
        Me.Label_Sexo.Name = "Label_Sexo"
        Me.Label_Sexo.Size = New System.Drawing.Size(45, 20)
        Me.Label_Sexo.TabIndex = 33
        Me.Label_Sexo.Text = "Sexo"
        '
        'Label_Edad
        '
        Me.Label_Edad.AutoSize = True
        Me.Label_Edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Edad.Location = New System.Drawing.Point(12, 168)
        Me.Label_Edad.Name = "Label_Edad"
        Me.Label_Edad.Size = New System.Drawing.Size(47, 20)
        Me.Label_Edad.TabIndex = 32
        Me.Label_Edad.Text = "Edad"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(12, 119)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.Label_Nombre.TabIndex = 31
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_Num_Empleado
        '
        Me.Label_Num_Empleado.AutoSize = True
        Me.Label_Num_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Num_Empleado.Location = New System.Drawing.Point(12, 67)
        Me.Label_Num_Empleado.Name = "Label_Num_Empleado"
        Me.Label_Num_Empleado.Size = New System.Drawing.Size(161, 20)
        Me.Label_Num_Empleado.TabIndex = 30
        Me.Label_Num_Empleado.Text = "Numero de empleado"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(12, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 29
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Actualizar.Location = New System.Drawing.Point(581, 507)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 60
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Eliminar.Location = New System.Drawing.Point(478, 507)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 59
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Radio_Carrera
        '
        Me.Radio_Carrera.AutoSize = True
        Me.Radio_Carrera.Checked = True
        Me.Radio_Carrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Carrera.Location = New System.Drawing.Point(396, 41)
        Me.Radio_Carrera.Name = "Radio_Carrera"
        Me.Radio_Carrera.Size = New System.Drawing.Size(157, 20)
        Me.Radio_Carrera.TabIndex = 58
        Me.Radio_Carrera.TabStop = True
        Me.Radio_Carrera.Text = "Numero de empleado"
        Me.Radio_Carrera.UseVisualStyleBackColor = True
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(552, 116)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 57
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(478, 69)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(149, 20)
        Me.TextBox_Buscar.TabIndex = 56
        '
        'Forms_Medicos_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.Radio_Carrera)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.TextBox_Buscar)
        Me.Controls.Add(Me.TextBox_Cedula)
        Me.Controls.Add(Me.TextBox_Especialidad)
        Me.Controls.Add(Me.TextBox_Sexo)
        Me.Controls.Add(Me.TextBox_Edad)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Numero_Empleado)
        Me.Controls.Add(Me.Label_Cedula)
        Me.Controls.Add(Me.Label_Especialidad)
        Me.Controls.Add(Me.Label_Sexo)
        Me.Controls.Add(Me.Label_Edad)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Num_Empleado)
        Me.Controls.Add(Me.X)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicos_Editar"
        Me.Text = "Forms_Medicos_Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Cedula As TextBox
    Friend WithEvents TextBox_Especialidad As TextBox
    Friend WithEvents TextBox_Sexo As TextBox
    Friend WithEvents TextBox_Edad As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Numero_Empleado As TextBox
    Friend WithEvents Label_Cedula As Label
    Friend WithEvents Label_Especialidad As Label
    Friend WithEvents Label_Sexo As Label
    Friend WithEvents Label_Edad As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Num_Empleado As Label
    Friend WithEvents X As Button
    Friend WithEvents Button1_Actualizar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Radio_Carrera As RadioButton
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_Buscar As TextBox
End Class
