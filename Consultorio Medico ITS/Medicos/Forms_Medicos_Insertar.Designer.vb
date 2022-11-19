<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Medicos_Insertar
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
        Me.Button_Insertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Cedula
        '
        Me.TextBox_Cedula.Location = New System.Drawing.Point(206, 331)
        Me.TextBox_Cedula.Name = "TextBox_Cedula"
        Me.TextBox_Cedula.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Cedula.TabIndex = 27
        '
        'TextBox_Especialidad
        '
        Me.TextBox_Especialidad.Location = New System.Drawing.Point(206, 277)
        Me.TextBox_Especialidad.Name = "TextBox_Especialidad"
        Me.TextBox_Especialidad.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Especialidad.TabIndex = 26
        '
        'TextBox_Sexo
        '
        Me.TextBox_Sexo.Location = New System.Drawing.Point(206, 220)
        Me.TextBox_Sexo.Name = "TextBox_Sexo"
        Me.TextBox_Sexo.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Sexo.TabIndex = 25
        '
        'TextBox_Edad
        '
        Me.TextBox_Edad.Location = New System.Drawing.Point(206, 168)
        Me.TextBox_Edad.Name = "TextBox_Edad"
        Me.TextBox_Edad.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Edad.TabIndex = 24
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(206, 119)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Nombre.TabIndex = 23
        '
        'TextBox_Numero_Empleado
        '
        Me.TextBox_Numero_Empleado.Location = New System.Drawing.Point(206, 69)
        Me.TextBox_Numero_Empleado.Name = "TextBox_Numero_Empleado"
        Me.TextBox_Numero_Empleado.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_Numero_Empleado.TabIndex = 22
        '
        'Label_Cedula
        '
        Me.Label_Cedula.AutoSize = True
        Me.Label_Cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Cedula.Location = New System.Drawing.Point(12, 331)
        Me.Label_Cedula.Name = "Label_Cedula"
        Me.Label_Cedula.Size = New System.Drawing.Size(138, 20)
        Me.Label_Cedula.TabIndex = 21
        Me.Label_Cedula.Text = "Numero de cedula"
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(12, 275)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(99, 20)
        Me.Label_Especialidad.TabIndex = 20
        Me.Label_Especialidad.Text = "Especialidad"
        '
        'Label_Sexo
        '
        Me.Label_Sexo.AutoSize = True
        Me.Label_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sexo.Location = New System.Drawing.Point(12, 220)
        Me.Label_Sexo.Name = "Label_Sexo"
        Me.Label_Sexo.Size = New System.Drawing.Size(45, 20)
        Me.Label_Sexo.TabIndex = 19
        Me.Label_Sexo.Text = "Sexo"
        '
        'Label_Edad
        '
        Me.Label_Edad.AutoSize = True
        Me.Label_Edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Edad.Location = New System.Drawing.Point(12, 168)
        Me.Label_Edad.Name = "Label_Edad"
        Me.Label_Edad.Size = New System.Drawing.Size(47, 20)
        Me.Label_Edad.TabIndex = 18
        Me.Label_Edad.Text = "Edad"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(12, 119)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(65, 20)
        Me.Label_Nombre.TabIndex = 17
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_Num_Empleado
        '
        Me.Label_Num_Empleado.AutoSize = True
        Me.Label_Num_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Num_Empleado.Location = New System.Drawing.Point(12, 67)
        Me.Label_Num_Empleado.Name = "Label_Num_Empleado"
        Me.Label_Num_Empleado.Size = New System.Drawing.Size(161, 20)
        Me.Label_Num_Empleado.TabIndex = 16
        Me.Label_Num_Empleado.Text = "Numero de empleado"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(12, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 15
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button_Insertar
        '
        Me.Button_Insertar.Location = New System.Drawing.Point(271, 412)
        Me.Button_Insertar.Name = "Button_Insertar"
        Me.Button_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Insertar.TabIndex = 14
        Me.Button_Insertar.Text = "Insertar"
        Me.Button_Insertar.UseVisualStyleBackColor = True
        '
        'Forms_Medicos_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
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
        Me.Controls.Add(Me.Button_Insertar)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicos_Insertar"
        Me.Text = "Forms_Medicos_Insertar"
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
    Friend WithEvents Button_Insertar As Button
End Class
