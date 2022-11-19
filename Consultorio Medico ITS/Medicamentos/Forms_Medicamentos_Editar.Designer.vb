<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Medicamentos_Editar
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
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Id_Medicamento = New System.Windows.Forms.TextBox()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_Id_Medicamento = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Button()
        Me.Button1_Actualizar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Radio_Almacen = New System.Windows.Forms.RadioButton()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(174, 259)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(205, 26)
        Me.TextBox_Nombre.TabIndex = 19
        '
        'TextBox_Id_Medicamento
        '
        Me.TextBox_Id_Medicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Id_Medicamento.Location = New System.Drawing.Point(174, 188)
        Me.TextBox_Id_Medicamento.Name = "TextBox_Id_Medicamento"
        Me.TextBox_Id_Medicamento.Size = New System.Drawing.Size(205, 26)
        Me.TextBox_Id_Medicamento.TabIndex = 18
        '
        'Label_Nombre
        '
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(23, 265)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(103, 20)
        Me.Label_Nombre.TabIndex = 17
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_Id_Medicamento
        '
        Me.Label_Id_Medicamento.AutoSize = True
        Me.Label_Id_Medicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id_Medicamento.Location = New System.Drawing.Point(23, 194)
        Me.Label_Id_Medicamento.Name = "Label_Id_Medicamento"
        Me.Label_Id_Medicamento.Size = New System.Drawing.Size(128, 20)
        Me.Label_Id_Medicamento.TabIndex = 16
        Me.Label_Id_Medicamento.Text = "Id_Medicamento"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(27, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 15
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button1_Actualizar
        '
        Me.Button1_Actualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Actualizar.Location = New System.Drawing.Point(303, 339)
        Me.Button1_Actualizar.Name = "Button1_Actualizar"
        Me.Button1_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Actualizar.TabIndex = 21
        Me.Button1_Actualizar.Text = "Actualizar"
        Me.Button1_Actualizar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Location = New System.Drawing.Point(174, 339)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 20
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Radio_Almacen
        '
        Me.Radio_Almacen.AutoSize = True
        Me.Radio_Almacen.Checked = True
        Me.Radio_Almacen.Location = New System.Drawing.Point(429, 78)
        Me.Radio_Almacen.Name = "Radio_Almacen"
        Me.Radio_Almacen.Size = New System.Drawing.Size(104, 17)
        Me.Radio_Almacen.TabIndex = 24
        Me.Radio_Almacen.TabStop = True
        Me.Radio_Almacen.Text = "Id_Medicamento"
        Me.Radio_Almacen.UseVisualStyleBackColor = True
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Buscar.Location = New System.Drawing.Point(26, 77)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 23
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(159, 80)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(220, 20)
        Me.TextBox_Buscar.TabIndex = 22
        '
        'Forms_Medicamentos_Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Radio_Almacen)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.TextBox_Buscar)
        Me.Controls.Add(Me.Button1_Actualizar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Id_Medicamento)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Id_Medicamento)
        Me.Controls.Add(Me.X)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicamentos_Editar"
        Me.Text = "Forms_Medicamentos_Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Id_Medicamento As TextBox
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Id_Medicamento As Label
    Friend WithEvents X As Button
    Friend WithEvents Button1_Actualizar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Radio_Almacen As RadioButton
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_Buscar As TextBox
End Class
