<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Departamento_Editar
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
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Radio_Departamento = New System.Windows.Forms.RadioButton()
        Me.X = New System.Windows.Forms.Button()
        Me.TextBox_Departamento = New System.Windows.Forms.TextBox()
        Me.Label_Departamento = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Location = New System.Drawing.Point(290, 329)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 21
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Location = New System.Drawing.Point(163, 329)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 20
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Radio_Departamento
        '
        Me.Radio_Departamento.AutoSize = True
        Me.Radio_Departamento.Checked = True
        Me.Radio_Departamento.Location = New System.Drawing.Point(67, 99)
        Me.Radio_Departamento.Name = "Radio_Departamento"
        Me.Radio_Departamento.Size = New System.Drawing.Size(92, 17)
        Me.Radio_Departamento.TabIndex = 19
        Me.Radio_Departamento.TabStop = True
        Me.Radio_Departamento.Text = "Departamento"
        Me.Radio_Departamento.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(12, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 18
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'TextBox_Departamento
        '
        Me.TextBox_Departamento.Location = New System.Drawing.Point(145, 223)
        Me.TextBox_Departamento.Name = "TextBox_Departamento"
        Me.TextBox_Departamento.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Departamento.TabIndex = 15
        '
        'Label_Departamento
        '
        Me.Label_Departamento.AutoSize = True
        Me.Label_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Departamento.Location = New System.Drawing.Point(17, 223)
        Me.Label_Departamento.Name = "Label_Departamento"
        Me.Label_Departamento.Size = New System.Drawing.Size(112, 20)
        Me.Label_Departamento.TabIndex = 12
        Me.Label_Departamento.Text = "Departamento"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(184, 98)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Forms_Departamento_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.Radio_Departamento)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.TextBox_Departamento)
        Me.Controls.Add(Me.Label_Departamento)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Departamento_Editar"
        Me.Text = "Forms_Departamento_Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1_Actualizar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Radio_Departamento As RadioButton
    Friend WithEvents X As Button
    Friend WithEvents TextBox_Departamento As TextBox
    Friend WithEvents Label_Departamento As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
