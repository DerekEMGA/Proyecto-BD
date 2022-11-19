<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Citas_Editar
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
        Me.X = New System.Windows.Forms.Button()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label_Profesor = New System.Windows.Forms.Label()
        Me.Label_Fecha = New System.Windows.Forms.Label()
        Me.Label_Hora = New System.Windows.Forms.Label()
        Me.Label_Fecha_Cita = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Medico = New System.Windows.Forms.Label()
        Me.Label_Numero_Cita = New System.Windows.Forms.Label()
        Me.TextBox_Hora = New System.Windows.Forms.TextBox()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Id_Cita = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 79
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(552, 93)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 78
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Actualizar.Location = New System.Drawing.Point(581, 507)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 82
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Eliminar.Location = New System.Drawing.Point(489, 507)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 81
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(506, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 84
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(302, 213)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox4.TabIndex = 97
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(302, 178)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox3.TabIndex = 96
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(302, 140)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox2.TabIndex = 95
        '
        'Label_Profesor
        '
        Me.Label_Profesor.AutoSize = True
        Me.Label_Profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Profesor.Location = New System.Drawing.Point(19, 176)
        Me.Label_Profesor.Name = "Label_Profesor"
        Me.Label_Profesor.Size = New System.Drawing.Size(249, 20)
        Me.Label_Profesor.TabIndex = 94
        Me.Label_Profesor.Text = "Numero de empleado del profesor"
        '
        'Label_Fecha
        '
        Me.Label_Fecha.AutoSize = True
        Me.Label_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Fecha.Location = New System.Drawing.Point(19, 329)
        Me.Label_Fecha.Name = "Label_Fecha"
        Me.Label_Fecha.Size = New System.Drawing.Size(0, 20)
        Me.Label_Fecha.TabIndex = 93
        '
        'Label_Hora
        '
        Me.Label_Hora.AutoSize = True
        Me.Label_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hora.Location = New System.Drawing.Point(19, 290)
        Me.Label_Hora.Name = "Label_Hora"
        Me.Label_Hora.Size = New System.Drawing.Size(44, 20)
        Me.Label_Hora.TabIndex = 92
        Me.Label_Hora.Text = "Hora"
        '
        'Label_Fecha_Cita
        '
        Me.Label_Fecha_Cita.AutoSize = True
        Me.Label_Fecha_Cita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Fecha_Cita.Location = New System.Drawing.Point(19, 251)
        Me.Label_Fecha_Cita.Name = "Label_Fecha_Cita"
        Me.Label_Fecha_Cita.Size = New System.Drawing.Size(54, 20)
        Me.Label_Fecha_Cita.TabIndex = 91
        Me.Label_Fecha_Cita.Text = "Fecha"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(19, 211)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(154, 20)
        Me.Label_Nombre.TabIndex = 90
        Me.Label_Nombre.Text = "Matricula del alumno"
        '
        'Label_Medico
        '
        Me.Label_Medico.AutoSize = True
        Me.Label_Medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Medico.Location = New System.Drawing.Point(19, 138)
        Me.Label_Medico.Name = "Label_Medico"
        Me.Label_Medico.Size = New System.Drawing.Size(241, 20)
        Me.Label_Medico.TabIndex = 89
        Me.Label_Medico.Text = "Numero de empleado del medico"
        '
        'Label_Numero_Cita
        '
        Me.Label_Numero_Cita.AutoSize = True
        Me.Label_Numero_Cita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Numero_Cita.Location = New System.Drawing.Point(19, 96)
        Me.Label_Numero_Cita.Name = "Label_Numero_Cita"
        Me.Label_Numero_Cita.Size = New System.Drawing.Size(116, 20)
        Me.Label_Numero_Cita.TabIndex = 88
        Me.Label_Numero_Cita.Text = "Numero de cita"
        '
        'TextBox_Hora
        '
        Me.TextBox_Hora.Location = New System.Drawing.Point(302, 290)
        Me.TextBox_Hora.Name = "TextBox_Hora"
        Me.TextBox_Hora.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Hora.TabIndex = 87
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(302, 253)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Fecha.TabIndex = 86
        '
        'TextBox_Id_Cita
        '
        Me.TextBox_Id_Cita.Location = New System.Drawing.Point(302, 96)
        Me.TextBox_Id_Cita.Name = "TextBox_Id_Cita"
        Me.TextBox_Id_Cita.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Id_Cita.TabIndex = 85
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(511, 141)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton1.TabIndex = 98
        Me.RadioButton1.Text = "Alumno"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(511, 177)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 20)
        Me.RadioButton2.TabIndex = 99
        Me.RadioButton2.Text = "Profesor"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form_Citas_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label_Profesor)
        Me.Controls.Add(Me.Label_Fecha)
        Me.Controls.Add(Me.Label_Hora)
        Me.Controls.Add(Me.Label_Fecha_Cita)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Medico)
        Me.Controls.Add(Me.Label_Numero_Cita)
        Me.Controls.Add(Me.TextBox_Hora)
        Me.Controls.Add(Me.TextBox_Fecha)
        Me.Controls.Add(Me.TextBox_Id_Cita)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Button_Buscar)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Form_Citas_Editar"
        Me.Text = "Form_Citas_Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents X As Button
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button1_Actualizar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label_Profesor As Label
    Friend WithEvents Label_Fecha As Label
    Friend WithEvents Label_Hora As Label
    Friend WithEvents Label_Fecha_Cita As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Medico As Label
    Friend WithEvents Label_Numero_Cita As Label
    Friend WithEvents TextBox_Hora As TextBox
    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Id_Cita As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
