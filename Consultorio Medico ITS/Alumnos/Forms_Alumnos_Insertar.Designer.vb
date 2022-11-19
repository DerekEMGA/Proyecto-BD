<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Alumnos_Insertar
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
        Me.TextBox_Matricula = New System.Windows.Forms.TextBox()
        Me.TextBox_Carrera = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Paterno = New System.Windows.Forms.TextBox()
        Me.TextBox_Materno = New System.Windows.Forms.TextBox()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Semestre = New System.Windows.Forms.TextBox()
        Me.TextBox_Correo = New System.Windows.Forms.TextBox()
        Me.TextBox_Celular = New System.Windows.Forms.TextBox()
        Me.Label_Matricula = New System.Windows.Forms.Label()
        Me.Label_Carrera = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Apellido_1 = New System.Windows.Forms.Label()
        Me.Label_Apellido_2 = New System.Windows.Forms.Label()
        Me.Label_Fecha = New System.Windows.Forms.Label()
        Me.Label_Celular = New System.Windows.Forms.Label()
        Me.Label_Semestre = New System.Windows.Forms.Label()
        Me.Label_Correo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Button()
        Me.Button1_Insertar = New System.Windows.Forms.Button()
        Me.Label_Edad = New System.Windows.Forms.Label()
        Me.TextBox_Edad = New System.Windows.Forms.TextBox()
        Me.Label_Especialidad = New System.Windows.Forms.Label()
        Me.TextBox_Especialidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_Matricula
        '
        Me.TextBox_Matricula.Location = New System.Drawing.Point(189, 70)
        Me.TextBox_Matricula.Name = "TextBox_Matricula"
        Me.TextBox_Matricula.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Matricula.TabIndex = 0
        '
        'TextBox_Carrera
        '
        Me.TextBox_Carrera.Location = New System.Drawing.Point(189, 115)
        Me.TextBox_Carrera.Name = "TextBox_Carrera"
        Me.TextBox_Carrera.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Carrera.TabIndex = 1
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(189, 185)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Nombre.TabIndex = 3
        '
        'TextBox_Paterno
        '
        Me.TextBox_Paterno.Location = New System.Drawing.Point(189, 225)
        Me.TextBox_Paterno.Name = "TextBox_Paterno"
        Me.TextBox_Paterno.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Paterno.TabIndex = 4
        '
        'TextBox_Materno
        '
        Me.TextBox_Materno.Location = New System.Drawing.Point(189, 264)
        Me.TextBox_Materno.Name = "TextBox_Materno"
        Me.TextBox_Materno.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Materno.TabIndex = 5
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(189, 303)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Fecha.TabIndex = 6
        '
        'TextBox_Semestre
        '
        Me.TextBox_Semestre.Location = New System.Drawing.Point(189, 380)
        Me.TextBox_Semestre.Name = "TextBox_Semestre"
        Me.TextBox_Semestre.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Semestre.TabIndex = 7
        '
        'TextBox_Correo
        '
        Me.TextBox_Correo.Location = New System.Drawing.Point(189, 418)
        Me.TextBox_Correo.Name = "TextBox_Correo"
        Me.TextBox_Correo.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Correo.TabIndex = 8
        '
        'TextBox_Celular
        '
        Me.TextBox_Celular.Location = New System.Drawing.Point(189, 340)
        Me.TextBox_Celular.Name = "TextBox_Celular"
        Me.TextBox_Celular.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Celular.TabIndex = 10
        '
        'Label_Matricula
        '
        Me.Label_Matricula.AutoSize = True
        Me.Label_Matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Matricula.Location = New System.Drawing.Point(12, 68)
        Me.Label_Matricula.Name = "Label_Matricula"
        Me.Label_Matricula.Size = New System.Drawing.Size(73, 20)
        Me.Label_Matricula.TabIndex = 11
        Me.Label_Matricula.Text = "Matricula"
        '
        'Label_Carrera
        '
        Me.Label_Carrera.AutoSize = True
        Me.Label_Carrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Carrera.Location = New System.Drawing.Point(12, 110)
        Me.Label_Carrera.Name = "Label_Carrera"
        Me.Label_Carrera.Size = New System.Drawing.Size(62, 20)
        Me.Label_Carrera.TabIndex = 12
        Me.Label_Carrera.Text = "Carrera"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(12, 183)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.Label_Nombre.TabIndex = 13
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_Apellido_1
        '
        Me.Label_Apellido_1.AutoSize = True
        Me.Label_Apellido_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_1.Location = New System.Drawing.Point(12, 223)
        Me.Label_Apellido_1.Name = "Label_Apellido_1"
        Me.Label_Apellido_1.Size = New System.Drawing.Size(125, 20)
        Me.Label_Apellido_1.TabIndex = 14
        Me.Label_Apellido_1.Text = "Apellido Paterno"
        '
        'Label_Apellido_2
        '
        Me.Label_Apellido_2.AutoSize = True
        Me.Label_Apellido_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellido_2.Location = New System.Drawing.Point(12, 262)
        Me.Label_Apellido_2.Name = "Label_Apellido_2"
        Me.Label_Apellido_2.Size = New System.Drawing.Size(128, 20)
        Me.Label_Apellido_2.TabIndex = 15
        Me.Label_Apellido_2.Text = "Apellido Materno"
        '
        'Label_Fecha
        '
        Me.Label_Fecha.AutoSize = True
        Me.Label_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Fecha.Location = New System.Drawing.Point(12, 301)
        Me.Label_Fecha.Name = "Label_Fecha"
        Me.Label_Fecha.Size = New System.Drawing.Size(157, 20)
        Me.Label_Fecha.TabIndex = 16
        Me.Label_Fecha.Text = "Fecha de nacimiento"
        '
        'Label_Celular
        '
        Me.Label_Celular.AutoSize = True
        Me.Label_Celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Celular.Location = New System.Drawing.Point(12, 338)
        Me.Label_Celular.Name = "Label_Celular"
        Me.Label_Celular.Size = New System.Drawing.Size(58, 20)
        Me.Label_Celular.TabIndex = 17
        Me.Label_Celular.Text = "Celular"
        '
        'Label_Semestre
        '
        Me.Label_Semestre.AutoSize = True
        Me.Label_Semestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Semestre.Location = New System.Drawing.Point(12, 378)
        Me.Label_Semestre.Name = "Label_Semestre"
        Me.Label_Semestre.Size = New System.Drawing.Size(78, 20)
        Me.Label_Semestre.TabIndex = 18
        Me.Label_Semestre.Text = "Semestre"
        '
        'Label_Correo
        '
        Me.Label_Correo.AutoSize = True
        Me.Label_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Correo.Location = New System.Drawing.Point(12, 416)
        Me.Label_Correo.Name = "Label_Correo"
        Me.Label_Correo.Size = New System.Drawing.Size(57, 20)
        Me.Label_Correo.TabIndex = 19
        Me.Label_Correo.Text = "Correo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 20
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 22)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 21
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button1_Insertar
        '
        Me.Button1_Insertar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Insertar.Location = New System.Drawing.Point(581, 507)
        Me.Button1_Insertar.Name = "Button1_Insertar"
        Me.Button1_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Insertar.TabIndex = 22
        Me.Button1_Insertar.Text = "Insertar"
        Me.Button1_Insertar.UseVisualStyleBackColor = True
        '
        'Label_Edad
        '
        Me.Label_Edad.AutoSize = True
        Me.Label_Edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Edad.Location = New System.Drawing.Point(12, 453)
        Me.Label_Edad.Name = "Label_Edad"
        Me.Label_Edad.Size = New System.Drawing.Size(47, 20)
        Me.Label_Edad.TabIndex = 23
        Me.Label_Edad.Text = "Edad"
        '
        'TextBox_Edad
        '
        Me.TextBox_Edad.Location = New System.Drawing.Point(189, 455)
        Me.TextBox_Edad.Name = "TextBox_Edad"
        Me.TextBox_Edad.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Edad.TabIndex = 24
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(12, 148)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(99, 20)
        Me.Label_Especialidad.TabIndex = 25
        Me.Label_Especialidad.Text = "Especialidad"
        '
        'TextBox_Especialidad
        '
        Me.TextBox_Especialidad.Location = New System.Drawing.Point(189, 146)
        Me.TextBox_Especialidad.Name = "TextBox_Especialidad"
        Me.TextBox_Especialidad.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Especialidad.TabIndex = 26
        '
        'Forms_Alumnos_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.TextBox_Especialidad)
        Me.Controls.Add(Me.Label_Especialidad)
        Me.Controls.Add(Me.TextBox_Edad)
        Me.Controls.Add(Me.Label_Edad)
        Me.Controls.Add(Me.Button1_Insertar)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label_Correo)
        Me.Controls.Add(Me.Label_Semestre)
        Me.Controls.Add(Me.Label_Celular)
        Me.Controls.Add(Me.Label_Fecha)
        Me.Controls.Add(Me.Label_Apellido_2)
        Me.Controls.Add(Me.Label_Apellido_1)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Carrera)
        Me.Controls.Add(Me.Label_Matricula)
        Me.Controls.Add(Me.TextBox_Celular)
        Me.Controls.Add(Me.TextBox_Correo)
        Me.Controls.Add(Me.TextBox_Semestre)
        Me.Controls.Add(Me.TextBox_Fecha)
        Me.Controls.Add(Me.TextBox_Materno)
        Me.Controls.Add(Me.TextBox_Paterno)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Carrera)
        Me.Controls.Add(Me.TextBox_Matricula)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Alumnos_Insertar"
        Me.Text = "Forms_Insertar_Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Matricula As TextBox
    Friend WithEvents TextBox_Carrera As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Paterno As TextBox
    Friend WithEvents TextBox_Materno As TextBox
    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Semestre As TextBox
    Friend WithEvents TextBox_Correo As TextBox
    Friend WithEvents TextBox_Celular As TextBox
    Friend WithEvents Label_Matricula As Label
    Friend WithEvents Label_Carrera As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Apellido_1 As Label
    Friend WithEvents Label_Apellido_2 As Label
    Friend WithEvents Label_Fecha As Label
    Friend WithEvents Label_Celular As Label
    Friend WithEvents Label_Semestre As Label
    Friend WithEvents Label_Correo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents X As Button
    Friend WithEvents Button1_Insertar As Button
    Friend WithEvents Label_Edad As Label
    Friend WithEvents TextBox_Edad As TextBox
    Friend WithEvents Label_Especialidad As Label
    Friend WithEvents TextBox_Especialidad As TextBox
End Class
