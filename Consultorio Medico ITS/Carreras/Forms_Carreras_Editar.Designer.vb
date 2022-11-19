<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Carreras_Editar
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
        Me.Label_Carrera = New System.Windows.Forms.Label()
        Me.Label_Especialidad = New System.Windows.Forms.Label()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.TextBox_Carrera = New System.Windows.Forms.TextBox()
        Me.TextBox_Especialidad = New System.Windows.Forms.TextBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Radio_Carrera = New System.Windows.Forms.RadioButton()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Carrera
        '
        Me.Label_Carrera.AutoSize = True
        Me.Label_Carrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Carrera.Location = New System.Drawing.Point(15, 224)
        Me.Label_Carrera.Name = "Label_Carrera"
        Me.Label_Carrera.Size = New System.Drawing.Size(62, 20)
        Me.Label_Carrera.TabIndex = 1
        Me.Label_Carrera.Text = "Carrera"
        '
        'Label_Especialidad
        '
        Me.Label_Especialidad.AutoSize = True
        Me.Label_Especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Especialidad.Location = New System.Drawing.Point(15, 279)
        Me.Label_Especialidad.Name = "Label_Especialidad"
        Me.Label_Especialidad.Size = New System.Drawing.Size(99, 20)
        Me.Label_Especialidad.TabIndex = 2
        Me.Label_Especialidad.Text = "Especialidad"
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(145, 102)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Buscar.TabIndex = 3
        '
        'TextBox_Carrera
        '
        Me.TextBox_Carrera.Location = New System.Drawing.Point(120, 226)
        Me.TextBox_Carrera.Name = "TextBox_Carrera"
        Me.TextBox_Carrera.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Carrera.TabIndex = 4
        '
        'TextBox_Especialidad
        '
        Me.TextBox_Especialidad.Location = New System.Drawing.Point(120, 281)
        Me.TextBox_Especialidad.Name = "TextBox_Especialidad"
        Me.TextBox_Especialidad.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Especialidad.TabIndex = 5
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Buscar.Location = New System.Drawing.Point(12, 99)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 6
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(19, 13)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 7
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Radio_Carrera
        '
        Me.Radio_Carrera.AutoSize = True
        Me.Radio_Carrera.Checked = True
        Me.Radio_Carrera.Location = New System.Drawing.Point(415, 100)
        Me.Radio_Carrera.Name = "Radio_Carrera"
        Me.Radio_Carrera.Size = New System.Drawing.Size(59, 17)
        Me.Radio_Carrera.TabIndex = 8
        Me.Radio_Carrera.TabStop = True
        Me.Radio_Carrera.Text = "Carrera"
        Me.Radio_Carrera.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Location = New System.Drawing.Point(120, 364)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 10
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Actualizar.Location = New System.Drawing.Point(249, 364)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 11
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Forms_Carreras_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.Radio_Carrera)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.TextBox_Especialidad)
        Me.Controls.Add(Me.TextBox_Carrera)
        Me.Controls.Add(Me.TextBox_Buscar)
        Me.Controls.Add(Me.Label_Especialidad)
        Me.Controls.Add(Me.Label_Carrera)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 566)
        Me.Name = "Forms_Carreras_Editar"
        Me.Text = "Editar Carreras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Carrera As Label
    Friend WithEvents Label_Especialidad As Label
    Friend WithEvents TextBox_Buscar As TextBox
    Friend WithEvents TextBox_Carrera As TextBox
    Friend WithEvents TextBox_Especialidad As TextBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents X As Button
    Friend WithEvents Radio_Carrera As RadioButton
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Button1_Actualizar As Button
End Class
