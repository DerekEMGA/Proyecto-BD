<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Carreras_Insertar
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
        Me.Button1_Insertar = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Carrera_Carreras_Insertar = New System.Windows.Forms.Label()
        Me.Especialidad_Carreras_Insertar = New System.Windows.Forms.Label()
        Me.Carrera_Insertar_Txt = New System.Windows.Forms.TextBox()
        Me.Especialidad_Insertar_Txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1_Insertar
        '
        Me.Button1_Insertar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Insertar.Location = New System.Drawing.Point(581, 507)
        Me.Button1_Insertar.Name = "Button1_Insertar"
        Me.Button1_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Insertar.TabIndex = 1
        Me.Button1_Insertar.Text = "Insertar"
        Me.Button1_Insertar.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(12, 11)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 4
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Carrera_Carreras_Insertar
        '
        Me.Carrera_Carreras_Insertar.AutoSize = True
        Me.Carrera_Carreras_Insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carrera_Carreras_Insertar.Location = New System.Drawing.Point(8, 94)
        Me.Carrera_Carreras_Insertar.Name = "Carrera_Carreras_Insertar"
        Me.Carrera_Carreras_Insertar.Size = New System.Drawing.Size(66, 20)
        Me.Carrera_Carreras_Insertar.TabIndex = 5
        Me.Carrera_Carreras_Insertar.Text = "Carrera:"
        '
        'Especialidad_Carreras_Insertar
        '
        Me.Especialidad_Carreras_Insertar.AutoSize = True
        Me.Especialidad_Carreras_Insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Especialidad_Carreras_Insertar.Location = New System.Drawing.Point(8, 165)
        Me.Especialidad_Carreras_Insertar.Name = "Especialidad_Carreras_Insertar"
        Me.Especialidad_Carreras_Insertar.Size = New System.Drawing.Size(103, 20)
        Me.Especialidad_Carreras_Insertar.TabIndex = 6
        Me.Especialidad_Carreras_Insertar.Text = "Especialidad:"
        '
        'Carrera_Insertar_Txt
        '
        Me.Carrera_Insertar_Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carrera_Insertar_Txt.Location = New System.Drawing.Point(130, 88)
        Me.Carrera_Insertar_Txt.Name = "Carrera_Insertar_Txt"
        Me.Carrera_Insertar_Txt.Size = New System.Drawing.Size(205, 26)
        Me.Carrera_Insertar_Txt.TabIndex = 7
        '
        'Especialidad_Insertar_Txt
        '
        Me.Especialidad_Insertar_Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Especialidad_Insertar_Txt.Location = New System.Drawing.Point(130, 159)
        Me.Especialidad_Insertar_Txt.Name = "Especialidad_Insertar_Txt"
        Me.Especialidad_Insertar_Txt.Size = New System.Drawing.Size(205, 26)
        Me.Especialidad_Insertar_Txt.TabIndex = 8
        '
        'Forms_Carreras_Insertar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Especialidad_Insertar_Txt)
        Me.Controls.Add(Me.Carrera_Insertar_Txt)
        Me.Controls.Add(Me.Especialidad_Carreras_Insertar)
        Me.Controls.Add(Me.Carrera_Carreras_Insertar)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Button1_Insertar)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Carreras_Insertar"
        Me.Text = "Forms_Carreras_Insertar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1_Insertar As Button
    Friend WithEvents X As Button
    Friend WithEvents Carrera_Carreras_Insertar As Label
    Friend WithEvents Especialidad_Carreras_Insertar As Label
    Friend WithEvents Carrera_Insertar_Txt As TextBox
    Friend WithEvents Especialidad_Insertar_Txt As TextBox
End Class
