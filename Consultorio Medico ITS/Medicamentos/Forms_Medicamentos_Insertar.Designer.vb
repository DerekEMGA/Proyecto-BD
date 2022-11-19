<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Medicamentos_Insertar
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
        Me.Button1_Insertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(161, 160)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(205, 26)
        Me.TextBox_Nombre.TabIndex = 14
        '
        'TextBox_Id_Medicamento
        '
        Me.TextBox_Id_Medicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Id_Medicamento.Location = New System.Drawing.Point(161, 89)
        Me.TextBox_Id_Medicamento.Name = "TextBox_Id_Medicamento"
        Me.TextBox_Id_Medicamento.Size = New System.Drawing.Size(205, 26)
        Me.TextBox_Id_Medicamento.TabIndex = 13
        '
        'Label_Nombre
        '
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(10, 166)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(103, 20)
        Me.Label_Nombre.TabIndex = 12
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_Id_Medicamento
        '
        Me.Label_Id_Medicamento.AutoSize = True
        Me.Label_Id_Medicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id_Medicamento.Location = New System.Drawing.Point(10, 95)
        Me.Label_Id_Medicamento.Name = "Label_Id_Medicamento"
        Me.Label_Id_Medicamento.Size = New System.Drawing.Size(128, 20)
        Me.Label_Id_Medicamento.TabIndex = 11
        Me.Label_Id_Medicamento.Text = "Id_Medicamento"
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(14, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 10
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Button1_Insertar
        '
        Me.Button1_Insertar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1_Insertar.Location = New System.Drawing.Point(583, 508)
        Me.Button1_Insertar.Name = "Button1_Insertar"
        Me.Button1_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button1_Insertar.TabIndex = 9
        Me.Button1_Insertar.Text = "Insertar"
        Me.Button1_Insertar.UseVisualStyleBackColor = True
        '
        'Forms_Medicamentos_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Id_Medicamento)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_Id_Medicamento)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Button1_Insertar)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicamentos_Insertar"
        Me.Text = "Forms_Medicamentos_Insertar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Id_Medicamento As TextBox
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Id_Medicamento As Label
    Friend WithEvents X As Button
    Friend WithEvents Button1_Insertar As Button
End Class
