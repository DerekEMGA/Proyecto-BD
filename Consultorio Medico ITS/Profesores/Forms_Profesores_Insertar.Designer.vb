<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Profesores_Insertar
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
        Me.Button1_Insertar = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_Apellido_2 = New System.Windows.Forms.Label()
        Me.Label_Apellido_1 = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Departamento = New System.Windows.Forms.Label()
        Me.Label_Numero_Empleado = New System.Windows.Forms.Label()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellidos = New System.Windows.Forms.TextBox()
        Me.TextBox_Numero_Empleado = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox_Nombre_Profesor
        '
        Me.TextBox_Nombre_Profesor.Location = New System.Drawing.Point(189, 141)
        Me.TextBox_Nombre_Profesor.Name = "TextBox_Nombre_Profesor"
        Me.TextBox_Nombre_Profesor.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Nombre_Profesor.TabIndex = 51
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(12, 143)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(65, 20)
        Me.Label_Especialidad.TabIndex = 50
        Me.Label_Especialidad.Text = "Nombre"
        '
        'Button1_Insertar
        '
        Me.Button1_Insertar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Insertar.Location = New System.Drawing.Point(581, 502)
        Me.Button1_Insertar.Name = "Button1_Insertar"
        Me.Button1_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Insertar.TabIndex = 47
        Me.Button1_Insertar.Text = "Insertar"
        Me.Button1_Insertar.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 17)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 46
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 45
        '
        'Label_Apellido_2
        '
        Me.Label_Apellido_2.AutoSize = True
        Me.Label_Apellido_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_2.Location = New System.Drawing.Point(12, 257)
        Me.Label_Apellido_2.Name = "Label_Apellido_2"
        Me.Label_Apellido_2.Size = New System.Drawing.Size(137, 20)
        Me.Label_Apellido_2.TabIndex = 40
        Me.Label_Apellido_2.Text = "Fecha Nacimiento"
        '
        'Label_Apellido_1
        '
        Me.Label_Apellido_1.AutoSize = True
        Me.Label_Apellido_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_1.Location = New System.Drawing.Point(12, 218)
        Me.Label_Apellido_1.Name = "Label_Apellido_1"
        Me.Label_Apellido_1.Size = New System.Drawing.Size(71, 20)
        Me.Label_Apellido_1.TabIndex = 39
        Me.Label_Apellido_1.Text = "Telefono"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(12, 178)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(73, 20)
        Me.Label_Nombre.TabIndex = 38
        Me.Label_Nombre.Text = "Apellidos"
        '
        'Label_Departamento
        '
        Me.Label_Departamento.AutoSize = True
        Me.Label_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Departamento.Location = New System.Drawing.Point(12, 105)
        Me.Label_Departamento.Name = "Label_Departamento"
        Me.Label_Departamento.Size = New System.Drawing.Size(112, 20)
        Me.Label_Departamento.TabIndex = 37
        Me.Label_Departamento.Text = "Departamento"
        '
        'Label_Numero_Empleado
        '
        Me.Label_Numero_Empleado.AutoSize = True
        Me.Label_Numero_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Numero_Empleado.Location = New System.Drawing.Point(12, 63)
        Me.Label_Numero_Empleado.Name = "Label_Numero_Empleado"
        Me.Label_Numero_Empleado.Size = New System.Drawing.Size(161, 20)
        Me.Label_Numero_Empleado.TabIndex = 36
        Me.Label_Numero_Empleado.Text = "Numero de empleado"
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(189, 259)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Fecha.TabIndex = 31
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.Location = New System.Drawing.Point(189, 220)
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Telefono.TabIndex = 30
        '
        'TextBox_Apellidos
        '
        Me.TextBox_Apellidos.Location = New System.Drawing.Point(189, 180)
        Me.TextBox_Apellidos.Name = "TextBox_Apellidos"
        Me.TextBox_Apellidos.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Apellidos.TabIndex = 29
        '
        'TextBox_Numero_Empleado
        '
        Me.TextBox_Numero_Empleado.Location = New System.Drawing.Point(189, 65)
        Me.TextBox_Numero_Empleado.Name = "TextBox_Numero_Empleado"
        Me.TextBox_Numero_Empleado.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Numero_Empleado.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 52
        '
        'Forms_Profesores_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox_Nombre_Profesor)
        Me.Controls.Add(Me.Label_Especialidad)
        Me.Controls.Add(Me.Button1_Insertar)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Label10)
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
        Me.Name = "Forms_Profesores_Insertar"
        Me.Text = "Forms_Profesores_Insertar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Nombre_Profesor As TextBox
    Friend WithEvents Label_Especialidad As Label
    Friend WithEvents Button1_Insertar As Button
    Friend WithEvents X As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_Apellido_2 As Label
    Friend WithEvents Label_Apellido_1 As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Departamento As Label
    Friend WithEvents Label_Numero_Empleado As Label
    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Telefono As TextBox
    Friend WithEvents TextBox_Apellidos As TextBox
    Friend WithEvents TextBox_Numero_Empleado As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
