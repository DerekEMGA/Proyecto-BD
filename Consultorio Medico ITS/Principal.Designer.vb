<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
#Region "Codigo Forms Principal"
    'No mover, se mueve automaticamente con el Principal.vb[Diseño]
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel_Profesores As Panel
    Friend WithEvents Button_Ver_Profesores As Button
    Friend WithEvents Button_Editar_Profesores As Button
    Friend WithEvents Button_Insertar_Profesores As Button
    Friend WithEvents Button1_Profesores As Button
    Friend WithEvents Button_Consulta As Button
    Friend WithEvents Panel_Consultas_1 As Panel
    Friend WithEvents Button_Ver_Consultas As Button
    Friend WithEvents Button_Insertar_Consulta As Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.l = New System.Windows.Forms.Panel()
        Me.Panel_Consultas_1 = New System.Windows.Forms.Panel()
        Me.Button_Ver_Consultas = New System.Windows.Forms.Button()
        Me.Button_Insertar_Consulta = New System.Windows.Forms.Button()
        Me.Button_Consulta = New System.Windows.Forms.Button()
        Me.Panel_Profesores = New System.Windows.Forms.Panel()
        Me.Button_Ver_Profesores = New System.Windows.Forms.Button()
        Me.Button_Editar_Profesores = New System.Windows.Forms.Button()
        Me.Button_Insertar_Profesores = New System.Windows.Forms.Button()
        Me.Button1_Profesores = New System.Windows.Forms.Button()
        Me.Panel_Consultas = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Ver_Cita = New System.Windows.Forms.Button()
        Me.Editar_Cita = New System.Windows.Forms.Button()
        Me.Nueva_Cita = New System.Windows.Forms.Button()
        Me.Button1_Citas = New System.Windows.Forms.Button()
        Me.Panel_Medicamentos = New System.Windows.Forms.Panel()
        Me.Ver_Medicamentos = New System.Windows.Forms.Button()
        Me.Editar_Medicamentos = New System.Windows.Forms.Button()
        Me.Insertar_Medicamentos = New System.Windows.Forms.Button()
        Me.Button1_Medicamentos = New System.Windows.Forms.Button()
        Me.Panel_Medicos = New System.Windows.Forms.Panel()
        Me.Ver_Medicos = New System.Windows.Forms.Button()
        Me.Editar_Medicos = New System.Windows.Forms.Button()
        Me.Insertar_Medicos = New System.Windows.Forms.Button()
        Me.Button1_Medicos = New System.Windows.Forms.Button()
        Me.Panel_Departamento = New System.Windows.Forms.Panel()
        Me.Ver_Departamento = New System.Windows.Forms.Button()
        Me.Editar_Departamento = New System.Windows.Forms.Button()
        Me.Insertar_Departamento = New System.Windows.Forms.Button()
        Me.Departamento = New System.Windows.Forms.Button()
        Me.Panel_Alumnos = New System.Windows.Forms.Panel()
        Me.Ver_Alumnos = New System.Windows.Forms.Button()
        Me.Editar_Alumnos = New System.Windows.Forms.Button()
        Me.Insertar_Alumnos = New System.Windows.Forms.Button()
        Me.Button1_Alumnos = New System.Windows.Forms.Button()
        Me.Panel_Carreras = New System.Windows.Forms.Panel()
        Me.Ver_Carreras = New System.Windows.Forms.Button()
        Me.Editar_Carreras = New System.Windows.Forms.Button()
        Me.Insertar_Carreras = New System.Windows.Forms.Button()
        Me.Boton_Carreras = New System.Windows.Forms.Button()
        Me.Panel1_Logo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.l.SuspendLayout()
        Me.Panel_Consultas_1.SuspendLayout()
        Me.Panel_Profesores.SuspendLayout()
        Me.Panel_Consultas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Medicamentos.SuspendLayout()
        Me.Panel_Medicos.SuspendLayout()
        Me.Panel_Departamento.SuspendLayout()
        Me.Panel_Alumnos.SuspendLayout()
        Me.Panel_Carreras.SuspendLayout()
        Me.Panel1_Logo.SuspendLayout()
        Me.Panel_Contenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l
        '
        Me.l.AutoScroll = True
        Me.l.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.l.CausesValidation = False
        Me.l.Controls.Add(Me.Panel_Consultas_1)
        Me.l.Controls.Add(Me.Button_Consulta)
        Me.l.Controls.Add(Me.Panel_Profesores)
        Me.l.Controls.Add(Me.Button1_Profesores)
        Me.l.Controls.Add(Me.Panel_Consultas)
        Me.l.Controls.Add(Me.Button1_Citas)
        Me.l.Controls.Add(Me.Panel_Medicamentos)
        Me.l.Controls.Add(Me.Button1_Medicamentos)
        Me.l.Controls.Add(Me.Panel_Medicos)
        Me.l.Controls.Add(Me.Button1_Medicos)
        Me.l.Controls.Add(Me.Panel_Departamento)
        Me.l.Controls.Add(Me.Departamento)
        Me.l.Controls.Add(Me.Panel_Alumnos)
        Me.l.Controls.Add(Me.Button1_Alumnos)
        Me.l.Controls.Add(Me.Panel_Carreras)
        Me.l.Controls.Add(Me.Boton_Carreras)
        Me.l.Controls.Add(Me.Panel1_Logo)
        Me.l.Dock = System.Windows.Forms.DockStyle.Left
        Me.l.Location = New System.Drawing.Point(0, 0)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(250, 623)
        Me.l.TabIndex = 0
        '
        'Panel_Consultas_1
        '
        Me.Panel_Consultas_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Consultas_1.Controls.Add(Me.Button_Ver_Consultas)
        Me.Panel_Consultas_1.Controls.Add(Me.Button_Insertar_Consulta)
        Me.Panel_Consultas_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Consultas_1.Location = New System.Drawing.Point(0, 953)
        Me.Panel_Consultas_1.Name = "Panel_Consultas_1"
        Me.Panel_Consultas_1.Size = New System.Drawing.Size(233, 92)
        Me.Panel_Consultas_1.TabIndex = 17
        '
        'Button_Ver_Consultas
        '
        Me.Button_Ver_Consultas.BackColor = System.Drawing.Color.Transparent
        Me.Button_Ver_Consultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Ver_Consultas.FlatAppearance.BorderSize = 0
        Me.Button_Ver_Consultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button_Ver_Consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button_Ver_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ver_Consultas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Ver_Consultas.Location = New System.Drawing.Point(0, 30)
        Me.Button_Ver_Consultas.Name = "Button_Ver_Consultas"
        Me.Button_Ver_Consultas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button_Ver_Consultas.Size = New System.Drawing.Size(233, 26)
        Me.Button_Ver_Consultas.TabIndex = 3
        Me.Button_Ver_Consultas.Text = "Ver "
        Me.Button_Ver_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Ver_Consultas.UseVisualStyleBackColor = False
        '
        'Button_Insertar_Consulta
        '
        Me.Button_Insertar_Consulta.BackColor = System.Drawing.Color.Transparent
        Me.Button_Insertar_Consulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Insertar_Consulta.FlatAppearance.BorderSize = 0
        Me.Button_Insertar_Consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button_Insertar_Consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button_Insertar_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Insertar_Consulta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Insertar_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.Button_Insertar_Consulta.Name = "Button_Insertar_Consulta"
        Me.Button_Insertar_Consulta.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button_Insertar_Consulta.Size = New System.Drawing.Size(233, 30)
        Me.Button_Insertar_Consulta.TabIndex = 1
        Me.Button_Insertar_Consulta.Text = "Insertar"
        Me.Button_Insertar_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Insertar_Consulta.UseVisualStyleBackColor = False
        '
        'Button_Consulta
        '
        Me.Button_Consulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Consulta.FlatAppearance.BorderSize = 0
        Me.Button_Consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button_Consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Consulta.ForeColor = System.Drawing.SystemColors.Control
        Me.Button_Consulta.Location = New System.Drawing.Point(0, 923)
        Me.Button_Consulta.Name = "Button_Consulta"
        Me.Button_Consulta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button_Consulta.Size = New System.Drawing.Size(233, 30)
        Me.Button_Consulta.TabIndex = 15
        Me.Button_Consulta.Text = "Consulta"
        Me.Button_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Consulta.UseVisualStyleBackColor = True
        '
        'Panel_Profesores
        '
        Me.Panel_Profesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Profesores.Controls.Add(Me.Button_Ver_Profesores)
        Me.Panel_Profesores.Controls.Add(Me.Button_Editar_Profesores)
        Me.Panel_Profesores.Controls.Add(Me.Button_Insertar_Profesores)
        Me.Panel_Profesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Profesores.Location = New System.Drawing.Point(0, 831)
        Me.Panel_Profesores.Name = "Panel_Profesores"
        Me.Panel_Profesores.Size = New System.Drawing.Size(233, 92)
        Me.Panel_Profesores.TabIndex = 14
        '
        'Button_Ver_Profesores
        '
        Me.Button_Ver_Profesores.BackColor = System.Drawing.Color.Transparent
        Me.Button_Ver_Profesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Ver_Profesores.FlatAppearance.BorderSize = 0
        Me.Button_Ver_Profesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button_Ver_Profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button_Ver_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ver_Profesores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Ver_Profesores.Location = New System.Drawing.Point(0, 60)
        Me.Button_Ver_Profesores.Name = "Button_Ver_Profesores"
        Me.Button_Ver_Profesores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button_Ver_Profesores.Size = New System.Drawing.Size(233, 26)
        Me.Button_Ver_Profesores.TabIndex = 3
        Me.Button_Ver_Profesores.Text = "Ver Lista"
        Me.Button_Ver_Profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Ver_Profesores.UseVisualStyleBackColor = False
        '
        'Button_Editar_Profesores
        '
        Me.Button_Editar_Profesores.BackColor = System.Drawing.Color.Transparent
        Me.Button_Editar_Profesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Editar_Profesores.FlatAppearance.BorderSize = 0
        Me.Button_Editar_Profesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button_Editar_Profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button_Editar_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Editar_Profesores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Editar_Profesores.Location = New System.Drawing.Point(0, 30)
        Me.Button_Editar_Profesores.Name = "Button_Editar_Profesores"
        Me.Button_Editar_Profesores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button_Editar_Profesores.Size = New System.Drawing.Size(233, 30)
        Me.Button_Editar_Profesores.TabIndex = 2
        Me.Button_Editar_Profesores.Text = "Editar"
        Me.Button_Editar_Profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Editar_Profesores.UseVisualStyleBackColor = False
        '
        'Button_Insertar_Profesores
        '
        Me.Button_Insertar_Profesores.BackColor = System.Drawing.Color.Transparent
        Me.Button_Insertar_Profesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Insertar_Profesores.FlatAppearance.BorderSize = 0
        Me.Button_Insertar_Profesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button_Insertar_Profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button_Insertar_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Insertar_Profesores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Insertar_Profesores.Location = New System.Drawing.Point(0, 0)
        Me.Button_Insertar_Profesores.Name = "Button_Insertar_Profesores"
        Me.Button_Insertar_Profesores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button_Insertar_Profesores.Size = New System.Drawing.Size(233, 30)
        Me.Button_Insertar_Profesores.TabIndex = 1
        Me.Button_Insertar_Profesores.Text = "Insertar"
        Me.Button_Insertar_Profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Insertar_Profesores.UseVisualStyleBackColor = False
        '
        'Button1_Profesores
        '
        Me.Button1_Profesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1_Profesores.FlatAppearance.BorderSize = 0
        Me.Button1_Profesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Profesores.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1_Profesores.Location = New System.Drawing.Point(0, 801)
        Me.Button1_Profesores.Name = "Button1_Profesores"
        Me.Button1_Profesores.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1_Profesores.Size = New System.Drawing.Size(233, 30)
        Me.Button1_Profesores.TabIndex = 13
        Me.Button1_Profesores.Text = "Profesores"
        Me.Button1_Profesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Profesores.UseVisualStyleBackColor = True
        '
        'Panel_Consultas
        '
        Me.Panel_Consultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Consultas.Controls.Add(Me.Button1)
        Me.Panel_Consultas.Controls.Add(Me.Panel1)
        Me.Panel_Consultas.Controls.Add(Me.Ver_Cita)
        Me.Panel_Consultas.Controls.Add(Me.Editar_Cita)
        Me.Panel_Consultas.Controls.Add(Me.Nueva_Cita)
        Me.Panel_Consultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Consultas.Location = New System.Drawing.Point(0, 710)
        Me.Panel_Consultas.Name = "Panel_Consultas"
        Me.Panel_Consultas.Size = New System.Drawing.Size(233, 91)
        Me.Panel_Consultas.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(0, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(233, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Medicos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 91)
        Me.Panel1.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(0, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(233, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ver Lista"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(0, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(233, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Editar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(233, 30)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Insertar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Ver_Cita
        '
        Me.Ver_Cita.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Cita.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Cita.FlatAppearance.BorderSize = 0
        Me.Ver_Cita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Cita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Cita.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Cita.Location = New System.Drawing.Point(0, 60)
        Me.Ver_Cita.Name = "Ver_Cita"
        Me.Ver_Cita.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Cita.Size = New System.Drawing.Size(233, 30)
        Me.Ver_Cita.TabIndex = 3
        Me.Ver_Cita.Text = "Ver Lista"
        Me.Ver_Cita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Cita.UseVisualStyleBackColor = False
        '
        'Editar_Cita
        '
        Me.Editar_Cita.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Cita.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Cita.FlatAppearance.BorderSize = 0
        Me.Editar_Cita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Cita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Cita.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Cita.Location = New System.Drawing.Point(0, 30)
        Me.Editar_Cita.Name = "Editar_Cita"
        Me.Editar_Cita.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Cita.Size = New System.Drawing.Size(233, 30)
        Me.Editar_Cita.TabIndex = 2
        Me.Editar_Cita.Text = "Editar"
        Me.Editar_Cita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Cita.UseVisualStyleBackColor = False
        '
        'Nueva_Cita
        '
        Me.Nueva_Cita.BackColor = System.Drawing.Color.Transparent
        Me.Nueva_Cita.Dock = System.Windows.Forms.DockStyle.Top
        Me.Nueva_Cita.FlatAppearance.BorderSize = 0
        Me.Nueva_Cita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Nueva_Cita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Nueva_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nueva_Cita.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Nueva_Cita.Location = New System.Drawing.Point(0, 0)
        Me.Nueva_Cita.Name = "Nueva_Cita"
        Me.Nueva_Cita.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Nueva_Cita.Size = New System.Drawing.Size(233, 30)
        Me.Nueva_Cita.TabIndex = 1
        Me.Nueva_Cita.Text = "Nueva"
        Me.Nueva_Cita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nueva_Cita.UseVisualStyleBackColor = False
        '
        'Button1_Citas
        '
        Me.Button1_Citas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1_Citas.FlatAppearance.BorderSize = 0
        Me.Button1_Citas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Citas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Citas.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1_Citas.Location = New System.Drawing.Point(0, 680)
        Me.Button1_Citas.Name = "Button1_Citas"
        Me.Button1_Citas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1_Citas.Size = New System.Drawing.Size(233, 30)
        Me.Button1_Citas.TabIndex = 11
        Me.Button1_Citas.Text = "Citas"
        Me.Button1_Citas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Citas.UseVisualStyleBackColor = True
        '
        'Panel_Medicamentos
        '
        Me.Panel_Medicamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Medicamentos.Controls.Add(Me.Ver_Medicamentos)
        Me.Panel_Medicamentos.Controls.Add(Me.Editar_Medicamentos)
        Me.Panel_Medicamentos.Controls.Add(Me.Insertar_Medicamentos)
        Me.Panel_Medicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Medicamentos.Location = New System.Drawing.Point(0, 588)
        Me.Panel_Medicamentos.Name = "Panel_Medicamentos"
        Me.Panel_Medicamentos.Size = New System.Drawing.Size(233, 92)
        Me.Panel_Medicamentos.TabIndex = 10
        '
        'Ver_Medicamentos
        '
        Me.Ver_Medicamentos.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Medicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Medicamentos.FlatAppearance.BorderSize = 0
        Me.Ver_Medicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Medicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Medicamentos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Medicamentos.Location = New System.Drawing.Point(0, 60)
        Me.Ver_Medicamentos.Name = "Ver_Medicamentos"
        Me.Ver_Medicamentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Medicamentos.Size = New System.Drawing.Size(233, 26)
        Me.Ver_Medicamentos.TabIndex = 3
        Me.Ver_Medicamentos.Text = "Ver Lista"
        Me.Ver_Medicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Medicamentos.UseVisualStyleBackColor = False
        '
        'Editar_Medicamentos
        '
        Me.Editar_Medicamentos.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Medicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Medicamentos.FlatAppearance.BorderSize = 0
        Me.Editar_Medicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Medicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Medicamentos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Medicamentos.Location = New System.Drawing.Point(0, 30)
        Me.Editar_Medicamentos.Name = "Editar_Medicamentos"
        Me.Editar_Medicamentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Medicamentos.Size = New System.Drawing.Size(233, 30)
        Me.Editar_Medicamentos.TabIndex = 2
        Me.Editar_Medicamentos.Text = "Editar"
        Me.Editar_Medicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Medicamentos.UseVisualStyleBackColor = False
        '
        'Insertar_Medicamentos
        '
        Me.Insertar_Medicamentos.BackColor = System.Drawing.Color.Transparent
        Me.Insertar_Medicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Insertar_Medicamentos.FlatAppearance.BorderSize = 0
        Me.Insertar_Medicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Insertar_Medicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Insertar_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_Medicamentos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Insertar_Medicamentos.Location = New System.Drawing.Point(0, 0)
        Me.Insertar_Medicamentos.Name = "Insertar_Medicamentos"
        Me.Insertar_Medicamentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Insertar_Medicamentos.Size = New System.Drawing.Size(233, 30)
        Me.Insertar_Medicamentos.TabIndex = 1
        Me.Insertar_Medicamentos.Text = "Insertar"
        Me.Insertar_Medicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertar_Medicamentos.UseVisualStyleBackColor = False
        '
        'Button1_Medicamentos
        '
        Me.Button1_Medicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1_Medicamentos.FlatAppearance.BorderSize = 0
        Me.Button1_Medicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Medicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Medicamentos.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1_Medicamentos.Location = New System.Drawing.Point(0, 558)
        Me.Button1_Medicamentos.Name = "Button1_Medicamentos"
        Me.Button1_Medicamentos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1_Medicamentos.Size = New System.Drawing.Size(233, 30)
        Me.Button1_Medicamentos.TabIndex = 9
        Me.Button1_Medicamentos.Text = "Medicamentos"
        Me.Button1_Medicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Medicamentos.UseVisualStyleBackColor = True
        '
        'Panel_Medicos
        '
        Me.Panel_Medicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Medicos.Controls.Add(Me.Ver_Medicos)
        Me.Panel_Medicos.Controls.Add(Me.Editar_Medicos)
        Me.Panel_Medicos.Controls.Add(Me.Insertar_Medicos)
        Me.Panel_Medicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Medicos.Location = New System.Drawing.Point(0, 467)
        Me.Panel_Medicos.Name = "Panel_Medicos"
        Me.Panel_Medicos.Size = New System.Drawing.Size(233, 91)
        Me.Panel_Medicos.TabIndex = 8
        '
        'Ver_Medicos
        '
        Me.Ver_Medicos.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Medicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Medicos.FlatAppearance.BorderSize = 0
        Me.Ver_Medicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Medicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Medicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Medicos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Medicos.Location = New System.Drawing.Point(0, 60)
        Me.Ver_Medicos.Name = "Ver_Medicos"
        Me.Ver_Medicos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Medicos.Size = New System.Drawing.Size(233, 25)
        Me.Ver_Medicos.TabIndex = 3
        Me.Ver_Medicos.Text = "Ver Lista"
        Me.Ver_Medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Medicos.UseVisualStyleBackColor = False
        '
        'Editar_Medicos
        '
        Me.Editar_Medicos.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Medicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Medicos.FlatAppearance.BorderSize = 0
        Me.Editar_Medicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Medicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Medicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Medicos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Medicos.Location = New System.Drawing.Point(0, 30)
        Me.Editar_Medicos.Name = "Editar_Medicos"
        Me.Editar_Medicos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Medicos.Size = New System.Drawing.Size(233, 30)
        Me.Editar_Medicos.TabIndex = 2
        Me.Editar_Medicos.Text = "Editar"
        Me.Editar_Medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Medicos.UseVisualStyleBackColor = False
        '
        'Insertar_Medicos
        '
        Me.Insertar_Medicos.BackColor = System.Drawing.Color.Transparent
        Me.Insertar_Medicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Insertar_Medicos.FlatAppearance.BorderSize = 0
        Me.Insertar_Medicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Insertar_Medicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Insertar_Medicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_Medicos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Insertar_Medicos.Location = New System.Drawing.Point(0, 0)
        Me.Insertar_Medicos.Name = "Insertar_Medicos"
        Me.Insertar_Medicos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Insertar_Medicos.Size = New System.Drawing.Size(233, 30)
        Me.Insertar_Medicos.TabIndex = 1
        Me.Insertar_Medicos.Text = "Insertar"
        Me.Insertar_Medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertar_Medicos.UseVisualStyleBackColor = False
        '
        'Button1_Medicos
        '
        Me.Button1_Medicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1_Medicos.FlatAppearance.BorderSize = 0
        Me.Button1_Medicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Medicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Medicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Medicos.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1_Medicos.Location = New System.Drawing.Point(0, 437)
        Me.Button1_Medicos.Name = "Button1_Medicos"
        Me.Button1_Medicos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1_Medicos.Size = New System.Drawing.Size(233, 30)
        Me.Button1_Medicos.TabIndex = 7
        Me.Button1_Medicos.Text = "Medicos"
        Me.Button1_Medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Medicos.UseVisualStyleBackColor = True
        '
        'Panel_Departamento
        '
        Me.Panel_Departamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Departamento.Controls.Add(Me.Ver_Departamento)
        Me.Panel_Departamento.Controls.Add(Me.Editar_Departamento)
        Me.Panel_Departamento.Controls.Add(Me.Insertar_Departamento)
        Me.Panel_Departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Departamento.Location = New System.Drawing.Point(0, 341)
        Me.Panel_Departamento.Name = "Panel_Departamento"
        Me.Panel_Departamento.Size = New System.Drawing.Size(233, 96)
        Me.Panel_Departamento.TabIndex = 6
        '
        'Ver_Departamento
        '
        Me.Ver_Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Departamento.FlatAppearance.BorderSize = 0
        Me.Ver_Departamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Departamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Departamento.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Departamento.Location = New System.Drawing.Point(0, 60)
        Me.Ver_Departamento.Name = "Ver_Departamento"
        Me.Ver_Departamento.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Departamento.Size = New System.Drawing.Size(233, 30)
        Me.Ver_Departamento.TabIndex = 3
        Me.Ver_Departamento.Text = "Ver Lista"
        Me.Ver_Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Departamento.UseVisualStyleBackColor = False
        '
        'Editar_Departamento
        '
        Me.Editar_Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Departamento.FlatAppearance.BorderSize = 0
        Me.Editar_Departamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Departamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Departamento.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Departamento.Location = New System.Drawing.Point(0, 30)
        Me.Editar_Departamento.Name = "Editar_Departamento"
        Me.Editar_Departamento.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Departamento.Size = New System.Drawing.Size(233, 30)
        Me.Editar_Departamento.TabIndex = 2
        Me.Editar_Departamento.Text = "Editar"
        Me.Editar_Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Departamento.UseVisualStyleBackColor = False
        '
        'Insertar_Departamento
        '
        Me.Insertar_Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Insertar_Departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Insertar_Departamento.FlatAppearance.BorderSize = 0
        Me.Insertar_Departamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Insertar_Departamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Insertar_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_Departamento.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Insertar_Departamento.Location = New System.Drawing.Point(0, 0)
        Me.Insertar_Departamento.Name = "Insertar_Departamento"
        Me.Insertar_Departamento.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Insertar_Departamento.Size = New System.Drawing.Size(233, 30)
        Me.Insertar_Departamento.TabIndex = 1
        Me.Insertar_Departamento.Text = "Insertar"
        Me.Insertar_Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertar_Departamento.UseVisualStyleBackColor = False
        '
        'Departamento
        '
        Me.Departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Departamento.FlatAppearance.BorderSize = 0
        Me.Departamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Departamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Departamento.ForeColor = System.Drawing.SystemColors.Control
        Me.Departamento.Location = New System.Drawing.Point(0, 311)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Departamento.Size = New System.Drawing.Size(233, 30)
        Me.Departamento.TabIndex = 5
        Me.Departamento.Text = "Departamento"
        Me.Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Departamento.UseVisualStyleBackColor = True
        '
        'Panel_Alumnos
        '
        Me.Panel_Alumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Alumnos.Controls.Add(Me.Ver_Alumnos)
        Me.Panel_Alumnos.Controls.Add(Me.Editar_Alumnos)
        Me.Panel_Alumnos.Controls.Add(Me.Insertar_Alumnos)
        Me.Panel_Alumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Alumnos.Location = New System.Drawing.Point(0, 221)
        Me.Panel_Alumnos.Name = "Panel_Alumnos"
        Me.Panel_Alumnos.Size = New System.Drawing.Size(233, 90)
        Me.Panel_Alumnos.TabIndex = 4
        '
        'Ver_Alumnos
        '
        Me.Ver_Alumnos.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Alumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Alumnos.FlatAppearance.BorderSize = 0
        Me.Ver_Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Alumnos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Alumnos.Location = New System.Drawing.Point(0, 60)
        Me.Ver_Alumnos.Name = "Ver_Alumnos"
        Me.Ver_Alumnos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Alumnos.Size = New System.Drawing.Size(233, 24)
        Me.Ver_Alumnos.TabIndex = 3
        Me.Ver_Alumnos.Text = "Ver Lista"
        Me.Ver_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Alumnos.UseVisualStyleBackColor = False
        '
        'Editar_Alumnos
        '
        Me.Editar_Alumnos.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Alumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Alumnos.FlatAppearance.BorderSize = 0
        Me.Editar_Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Alumnos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Alumnos.Location = New System.Drawing.Point(0, 30)
        Me.Editar_Alumnos.Name = "Editar_Alumnos"
        Me.Editar_Alumnos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Alumnos.Size = New System.Drawing.Size(233, 30)
        Me.Editar_Alumnos.TabIndex = 2
        Me.Editar_Alumnos.Text = "Editar"
        Me.Editar_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Alumnos.UseVisualStyleBackColor = False
        '
        'Insertar_Alumnos
        '
        Me.Insertar_Alumnos.BackColor = System.Drawing.Color.Transparent
        Me.Insertar_Alumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Insertar_Alumnos.FlatAppearance.BorderSize = 0
        Me.Insertar_Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Insertar_Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Insertar_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_Alumnos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Insertar_Alumnos.Location = New System.Drawing.Point(0, 0)
        Me.Insertar_Alumnos.Name = "Insertar_Alumnos"
        Me.Insertar_Alumnos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Insertar_Alumnos.Size = New System.Drawing.Size(233, 30)
        Me.Insertar_Alumnos.TabIndex = 1
        Me.Insertar_Alumnos.Text = "Insertar"
        Me.Insertar_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertar_Alumnos.UseVisualStyleBackColor = False
        '
        'Button1_Alumnos
        '
        Me.Button1_Alumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1_Alumnos.FlatAppearance.BorderSize = 0
        Me.Button1_Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1_Alumnos.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1_Alumnos.Location = New System.Drawing.Point(0, 191)
        Me.Button1_Alumnos.Name = "Button1_Alumnos"
        Me.Button1_Alumnos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1_Alumnos.Size = New System.Drawing.Size(233, 30)
        Me.Button1_Alumnos.TabIndex = 3
        Me.Button1_Alumnos.Text = "Alumnos"
        Me.Button1_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1_Alumnos.UseVisualStyleBackColor = True
        '
        'Panel_Carreras
        '
        Me.Panel_Carreras.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel_Carreras.Controls.Add(Me.Ver_Carreras)
        Me.Panel_Carreras.Controls.Add(Me.Editar_Carreras)
        Me.Panel_Carreras.Controls.Add(Me.Insertar_Carreras)
        Me.Panel_Carreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Carreras.Location = New System.Drawing.Point(0, 83)
        Me.Panel_Carreras.Name = "Panel_Carreras"
        Me.Panel_Carreras.Size = New System.Drawing.Size(233, 108)
        Me.Panel_Carreras.TabIndex = 1
        '
        'Ver_Carreras
        '
        Me.Ver_Carreras.BackColor = System.Drawing.Color.Transparent
        Me.Ver_Carreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ver_Carreras.FlatAppearance.BorderSize = 0
        Me.Ver_Carreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Ver_Carreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Ver_Carreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver_Carreras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ver_Carreras.Location = New System.Drawing.Point(0, 80)
        Me.Ver_Carreras.Name = "Ver_Carreras"
        Me.Ver_Carreras.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Ver_Carreras.Size = New System.Drawing.Size(233, 23)
        Me.Ver_Carreras.TabIndex = 3
        Me.Ver_Carreras.Text = "Ver Lista"
        Me.Ver_Carreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ver_Carreras.UseVisualStyleBackColor = False
        '
        'Editar_Carreras
        '
        Me.Editar_Carreras.BackColor = System.Drawing.Color.Transparent
        Me.Editar_Carreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Editar_Carreras.FlatAppearance.BorderSize = 0
        Me.Editar_Carreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Editar_Carreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Editar_Carreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Carreras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Editar_Carreras.Location = New System.Drawing.Point(0, 40)
        Me.Editar_Carreras.Name = "Editar_Carreras"
        Me.Editar_Carreras.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Editar_Carreras.Size = New System.Drawing.Size(233, 40)
        Me.Editar_Carreras.TabIndex = 2
        Me.Editar_Carreras.Text = "Editar"
        Me.Editar_Carreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Carreras.UseVisualStyleBackColor = False
        '
        'Insertar_Carreras
        '
        Me.Insertar_Carreras.BackColor = System.Drawing.Color.Transparent
        Me.Insertar_Carreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Insertar_Carreras.FlatAppearance.BorderSize = 0
        Me.Insertar_Carreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Insertar_Carreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Insertar_Carreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_Carreras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Insertar_Carreras.Location = New System.Drawing.Point(0, 0)
        Me.Insertar_Carreras.Name = "Insertar_Carreras"
        Me.Insertar_Carreras.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Insertar_Carreras.Size = New System.Drawing.Size(233, 40)
        Me.Insertar_Carreras.TabIndex = 1
        Me.Insertar_Carreras.Text = "Insertar"
        Me.Insertar_Carreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertar_Carreras.UseVisualStyleBackColor = False
        '
        'Boton_Carreras
        '
        Me.Boton_Carreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_Carreras.FlatAppearance.BorderSize = 0
        Me.Boton_Carreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Boton_Carreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.Boton_Carreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Carreras.ForeColor = System.Drawing.SystemColors.Control
        Me.Boton_Carreras.Location = New System.Drawing.Point(0, 53)
        Me.Boton_Carreras.Name = "Boton_Carreras"
        Me.Boton_Carreras.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Boton_Carreras.Size = New System.Drawing.Size(233, 30)
        Me.Boton_Carreras.TabIndex = 2
        Me.Boton_Carreras.Text = "Carreras"
        Me.Boton_Carreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton_Carreras.UseVisualStyleBackColor = True
        '
        'Panel1_Logo
        '
        Me.Panel1_Logo.Controls.Add(Me.Label1)
        Me.Panel1_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel1_Logo.Name = "Panel1_Logo"
        Me.Panel1_Logo.Size = New System.Drawing.Size(233, 53)
        Me.Panel1_Logo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instituto Tecnologico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de Saltillo"
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Contenedor.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel_Contenedor.Controls.Add(Me.PictureBox2)
        Me.Panel_Contenedor.Location = New System.Drawing.Point(250, 0)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(684, 623)
        Me.Panel_Contenedor.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.Consultorio_Medico_ITS.My.Resources.Resources.Icono_Base
        Me.PictureBox2.Location = New System.Drawing.Point(201, 159)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(297, 274)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 623)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.l)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(950, 620)
        Me.MaximumSize = New System.Drawing.Size(950, 662)
        Me.MinimumSize = New System.Drawing.Size(950, 662)
        Me.Name = "Principal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.l.ResumeLayout(False)
        Me.Panel_Consultas_1.ResumeLayout(False)
        Me.Panel_Profesores.ResumeLayout(False)
        Me.Panel_Consultas.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Medicamentos.ResumeLayout(False)
        Me.Panel_Medicos.ResumeLayout(False)
        Me.Panel_Departamento.ResumeLayout(False)
        Me.Panel_Alumnos.ResumeLayout(False)
        Me.Panel_Carreras.ResumeLayout(False)
        Me.Panel1_Logo.ResumeLayout(False)
        Me.Panel1_Logo.PerformLayout()
        Me.Panel_Contenedor.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents l As Panel
    Friend WithEvents Panel_Carreras As Panel
    Friend WithEvents Ver_Carreras As Button
    Friend WithEvents Insertar_Carreras As Button
    Friend WithEvents Boton_Carreras As Button
    Friend WithEvents Panel1_Logo As Panel
    Friend WithEvents Panel_Medicos As Panel
    Friend WithEvents Ver_Medicos As Button
    Friend WithEvents Editar_Medicos As Button
    Friend WithEvents Insertar_Medicos As Button
    Friend WithEvents Button1_Medicos As Button
    Friend WithEvents Panel_Departamento As Panel
    Friend WithEvents Ver_Departamento As Button
    Friend WithEvents Editar_Departamento As Button
    Friend WithEvents Insertar_Departamento As Button
    Friend WithEvents Departamento As Button
    Friend WithEvents Panel_Alumnos As Panel
    Friend WithEvents Ver_Alumnos As Button
    Friend WithEvents Editar_Alumnos As Button
    Friend WithEvents Insertar_Alumnos As Button
    Friend WithEvents Button1_Alumnos As Button
    Friend WithEvents Editar_Carreras As Button
    Friend WithEvents Panel_Medicamentos As Panel
    Friend WithEvents Ver_Medicamentos As Button
    Friend WithEvents Editar_Medicamentos As Button
    Friend WithEvents Insertar_Medicamentos As Button
    Friend WithEvents Button1_Medicamentos As Button
    Friend WithEvents Panel_Consultas As Panel
    Friend WithEvents Ver_Cita As Button
    Friend WithEvents Editar_Cita As Button
    Friend WithEvents Nueva_Cita As Button
    Friend WithEvents Button1_Citas As Button

#End Region


    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()

    End Sub

    Public Sub hideSubmenu()
        Panel_Carreras.Visible = False
        Panel_Consultas.Visible = False
        Panel_Alumnos.Visible = False
        Panel_Departamento.Visible = False
        Panel_Medicos.Visible = False
        Panel_Medicamentos.Visible = False
        Panel_Profesores.Visible = False
        Panel_Consultas_1.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub


    Private currentForm As Form = Nothing

    Public Sub openContenedor(contenedor As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = contenedor
        contenedor.TopLevel = False
        contenedor.FormBorderStyle = FormBorderStyle.None
        contenedor.Dock = DockStyle.Fill
        Panel_Contenedor.Controls.Add(contenedor)
        Panel_Contenedor.Tag = contenedor
        contenedor.BringToFront()
        contenedor.Show()


    End Sub
#Region "Botones Principales"

    Private Sub Boton_Carreras_Click(sender As Object, e As EventArgs) Handles Boton_Carreras.Click
        showSubmenu(Panel_Carreras)

    End Sub

    Private Sub Button1_Alumnos_Click(sender As Object, e As EventArgs) Handles Button1_Alumnos.Click
        showSubmenu(Panel_Alumnos)

    End Sub

    Private Sub Departamento_Click(sender As Object, e As EventArgs) Handles Departamento.Click
        showSubmenu(Panel_Departamento)

    End Sub

    Private Sub Button1_Medicos_Click(sender As Object, e As EventArgs) Handles Button1_Medicos.Click
        showSubmenu(Panel_Medicos)

    End Sub

    Private Sub Button1_Medicamentos_Click(sender As Object, e As EventArgs) Handles Button1_Medicamentos.Click
        showSubmenu(Panel_Medicamentos)

    End Sub

    Private Sub Button1_Consultas_Click(sender As Object, e As EventArgs) Handles Button1_Citas.Click
        showSubmenu(Panel_Consultas)

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button1_Profesores.Click
        showSubmenu(Panel_Profesores)
    End Sub

    Private Sub Button_Consulta_Click(sender As Object, e As EventArgs) Handles Button_Consulta.Click
        showSubmenu(Panel_Consultas_1)
    End Sub

#End Region


#Region "Botones de subMenus"

    Private Sub Insertar_Carreras_Click(sender As Object, e As EventArgs) Handles Insertar_Carreras.Click
        openContenedor(New Forms_Carreras_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()

    End Sub

    Private Sub Editar_Carreras_Click(sender As Object, e As EventArgs) Handles Editar_Carreras.Click
        openContenedor(New Forms_Carreras_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Carreras_Click(sender As Object, e As EventArgs) Handles Ver_Carreras.Click
        openContenedor(New Forms_Carreras_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Insertar_Alumnos_Click(sender As Object, e As EventArgs) Handles Insertar_Alumnos.Click
        openContenedor(New Forms_Alumnos_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Editar_Alumnos_Click(sender As Object, e As EventArgs) Handles Editar_Alumnos.Click
        openContenedor(New Forms_Alumnos_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Alumnos_Click(sender As Object, e As EventArgs) Handles Ver_Alumnos.Click
        openContenedor(New Forms_Alumnos_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Insertar_Departamento_Click(sender As Object, e As EventArgs) Handles Insertar_Departamento.Click
        openContenedor(New Forms_Departamento_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Editar_Departamento_Click(sender As Object, e As EventArgs) Handles Editar_Departamento.Click
        openContenedor(New Forms_Departamento_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Departamento_Click(sender As Object, e As EventArgs) Handles Ver_Departamento.Click
        openContenedor(New Forms_Departamento_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Insertar_Medicos_Click(sender As Object, e As EventArgs) Handles Insertar_Medicos.Click
        openContenedor(New Forms_Medicos_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Editar_Medicos_Click(sender As Object, e As EventArgs) Handles Editar_Medicos.Click
        openContenedor(New Forms_Medicos_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Medicos_Click(sender As Object, e As EventArgs) Handles Ver_Medicos.Click
        openContenedor(New Forms_Medicos_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Insertar_Medicamentos_Click(sender As Object, e As EventArgs) Handles Insertar_Medicamentos.Click
        openContenedor(New Forms_Medicamentos_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Editar_Medicamentos_Click(sender As Object, e As EventArgs) Handles Editar_Medicamentos.Click
        openContenedor(New Forms_Medicamentos_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Medicamentos_Click(sender As Object, e As EventArgs) Handles Ver_Medicamentos.Click
        openContenedor(New Forms_Medicamentos_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Nueva_Cita_Click(sender As Object, e As EventArgs) Handles Nueva_Cita.Click
        openContenedor(New Form_Citas_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Editar_Cita_Click(sender As Object, e As EventArgs) Handles Editar_Cita.Click
        openContenedor(New Form_Citas_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Ver_Cita_Click(sender As Object, e As EventArgs) Handles Ver_Cita.Click
        openContenedor(New Form_Citas_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Button_Insertar_Profesores_Click(sender As Object, e As EventArgs) Handles Button_Insertar_Profesores.Click
        openContenedor(New Forms_Profesores_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Button_Editar_Profesores_Click(sender As Object, e As EventArgs) Handles Button_Editar_Profesores.Click
        openContenedor(New Forms_Profesores_Editar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Button_Ver_Profesores_Click(sender As Object, e As EventArgs) Handles Button_Ver_Profesores.Click
        openContenedor(New Forms_Profesores_Ver)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Button_Insertar_Consulta_Click(sender As Object, e As EventArgs) Handles Button_Insertar_Consulta.Click
        openContenedor(New Forms_Consultas_Insertar)
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub



    Private Sub Button_Ver_Consultas_Click(sender As Object, e As EventArgs) Handles Button_Ver_Consultas.Click
        Forms_Consultas_Ver.Show()
        'Codigo'
        '''
        '
        hideSubmenu()
    End Sub

    Private Sub Panel_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Contenedor.Paint

    End Sub



#End Region

End Class
