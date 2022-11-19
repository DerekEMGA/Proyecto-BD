<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btn_Entrar = New System.Windows.Forms.Button()
        Me.Btn_Programador = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Entrar
        '
        Me.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Entrar.Location = New System.Drawing.Point(225, 255)
        Me.Btn_Entrar.Name = "Btn_Entrar"
        Me.Btn_Entrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Entrar.TabIndex = 0
        Me.Btn_Entrar.Text = "Entrar"
        Me.Btn_Entrar.UseVisualStyleBackColor = True
        '
        'Btn_Programador
        '
        Me.Btn_Programador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Programador.Location = New System.Drawing.Point(397, 426)
        Me.Btn_Programador.Name = "Btn_Programador"
        Me.Btn_Programador.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Programador.TabIndex = 1
        Me.Btn_Programador.Text = "Programador"
        Me.Btn_Programador.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(98, 154)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(68, 20)
        Me.Usuario.TabIndex = 2
        Me.Usuario.Text = "Usuario:"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.Location = New System.Drawing.Point(98, 212)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(96, 20)
        Me.Contraseña.TabIndex = 3
        Me.Contraseña.Text = "Contraseña:"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(214, 156)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Usuario.TabIndex = 4
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.Location = New System.Drawing.Point(214, 214)
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Contraseña.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Contraseña.TabIndex = 5
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Location = New System.Drawing.Point(323, 255)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Txt_Contraseña)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Btn_Programador)
        Me.Controls.Add(Me.Btn_Entrar)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Consultorio Medico ITS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Entrar As Button
    Friend WithEvents Btn_Programador As Button
    Friend WithEvents Usuario As Label
    Friend WithEvents Contraseña As Label
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Txt_Contraseña As TextBox
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Label1 As Label
End Class
