<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Alumnos_Ver
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.X = New System.Windows.Forms.Button()
        Me.Consultorio_medicoDataSet1 = New Consultorio_Medico_ITS.consultorio_medicoDataSet1()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnoTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.AlumnoTableAdapter()
        Me.MatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadEspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMaternosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculaDataGridViewTextBoxColumn, Me.EspecialidadEspecialidadDataGridViewTextBoxColumn, Me.EspecialidadCarreraDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoPaternoDataGridViewTextBoxColumn, Me.ApellidoMaternosDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.SemestreDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(38, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(593, 359)
        Me.DataGridView1.TabIndex = 1
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 19)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 3
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'Consultorio_medicoDataSet1
        '
        Me.Consultorio_medicoDataSet1.DataSetName = "consultorio_medicoDataSet1"
        Me.Consultorio_medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "Alumno"
        Me.AlumnoBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'AlumnoTableAdapter
        '
        Me.AlumnoTableAdapter.ClearBeforeFill = True
        '
        'MatriculaDataGridViewTextBoxColumn
        '
        Me.MatriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.Name = "MatriculaDataGridViewTextBoxColumn"
        '
        'EspecialidadEspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad_Especialidad"
        Me.EspecialidadEspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad_Especialidad"
        Me.EspecialidadEspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadEspecialidadDataGridViewTextBoxColumn"
        '
        'EspecialidadCarreraDataGridViewTextBoxColumn
        '
        Me.EspecialidadCarreraDataGridViewTextBoxColumn.DataPropertyName = "Especialidad_Carrera"
        Me.EspecialidadCarreraDataGridViewTextBoxColumn.HeaderText = "Especialidad_Carrera"
        Me.EspecialidadCarreraDataGridViewTextBoxColumn.Name = "EspecialidadCarreraDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido_Paterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Name = "ApellidoPaternoDataGridViewTextBoxColumn"
        '
        'ApellidoMaternosDataGridViewTextBoxColumn
        '
        Me.ApellidoMaternosDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Maternos"
        Me.ApellidoMaternosDataGridViewTextBoxColumn.HeaderText = "Apellido_Maternos"
        Me.ApellidoMaternosDataGridViewTextBoxColumn.Name = "ApellidoMaternosDataGridViewTextBoxColumn"
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        '
        'SemestreDataGridViewTextBoxColumn
        '
        Me.SemestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.HeaderText = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.Name = "SemestreDataGridViewTextBoxColumn"
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        '
        'Forms_Alumnos_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Alumnos_Ver"
        Me.Text = "Forms_Alumno_Ver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents X As Button
    Friend WithEvents Consultorio_medicoDataSet1 As consultorio_medicoDataSet1
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents AlumnoTableAdapter As consultorio_medicoDataSet1TableAdapters.AlumnoTableAdapter
    Friend WithEvents MatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadEspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemestreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
