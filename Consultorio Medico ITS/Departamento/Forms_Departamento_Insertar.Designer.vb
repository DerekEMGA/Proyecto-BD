<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Departamento_Insertar
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
        Me.TextBox_Departamento = New System.Windows.Forms.TextBox()
        Me.Label_Departamento = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Button()
        Me.Button_Insertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Departamento
        '
        Me.TextBox_Departamento.Location = New System.Drawing.Point(155, 116)
        Me.TextBox_Departamento.Name = "TextBox_Departamento"
        Me.TextBox_Departamento.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Departamento.TabIndex = 0
        '
        'Label_Departamento
        '
        Me.Label_Departamento.AutoSize = True
        Me.Label_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Departamento.Location = New System.Drawing.Point(24, 116)
        Me.Label_Departamento.Name = "Label_Departamento"
        Me.Label_Departamento.Size = New System.Drawing.Size(112, 20)
        Me.Label_Departamento.TabIndex = 1
        Me.Label_Departamento.Text = "Departamento"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(16, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 2
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button_Insertar
        '
        Me.Button_Insertar.Location = New System.Drawing.Point(180, 217)
        Me.Button_Insertar.Name = "Button_Insertar"
        Me.Button_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Insertar.TabIndex = 3
        Me.Button_Insertar.Text = "Insertar"
        Me.Button_Insertar.UseVisualStyleBackColor = True
        '
        'Forms_Departamento_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Button_Insertar)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Label_Departamento)
        Me.Controls.Add(Me.TextBox_Departamento)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Departamento_Insertar"
        Me.Text = "Forms_Departamento_Insertar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Departamento As TextBox
    Friend WithEvents Label_Departamento As Label
    Friend WithEvents X As Button
    Friend WithEvents Button_Insertar As Button
End Class
