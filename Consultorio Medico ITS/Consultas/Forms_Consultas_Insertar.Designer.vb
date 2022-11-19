<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forms_Consultas_Insertar
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.X = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCitasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaestroNumeroEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlumnoMatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultorio_medicoDataSet1 = New Consultorio_Medico_ITS.consultorio_medicoDataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Consultorio_medicoDataSet = New Consultorio_Medico_ITS.consultorio_medicoDataSet()
        Me.RevisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RevisionTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSetTableAdapters.RevisionTableAdapter()
        Me.RevisionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitasTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.CitasTableAdapter()
        Me.TextBox_Id_Cita = New System.Windows.Forms.TextBox()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_Hora = New System.Windows.Forms.TextBox()
        Me.Label_Fecha = New System.Windows.Forms.Label()
        Me.Label_Id_Cita = New System.Windows.Forms.Label()
        Me.Label_Fecha_TexBox = New System.Windows.Forms.Label()
        Me.Label_Hora = New System.Windows.Forms.Label()
        Me.Button_Insertar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevisionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(12, 12)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 80
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCitasDataGridViewTextBoxColumn, Me.MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn, Me.MaestroNumeroEmpleadoDataGridViewTextBoxColumn, Me.AlumnoMatriculaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CitasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(644, 266)
        Me.DataGridView1.TabIndex = 83
        '
        'IdCitasDataGridViewTextBoxColumn
        '
        Me.IdCitasDataGridViewTextBoxColumn.DataPropertyName = "Id_Citas"
        Me.IdCitasDataGridViewTextBoxColumn.HeaderText = "Id_Citas"
        Me.IdCitasDataGridViewTextBoxColumn.Name = "IdCitasDataGridViewTextBoxColumn"
        '
        'MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn
        '
        Me.MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Medicos_Medico_Numero_Empleado"
        Me.MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn.HeaderText = "Medicos_Medico_Numero_Empleado"
        Me.MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn.Name = "MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn"
        '
        'MaestroNumeroEmpleadoDataGridViewTextBoxColumn
        '
        Me.MaestroNumeroEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Maestro_Numero_Empleado"
        Me.MaestroNumeroEmpleadoDataGridViewTextBoxColumn.HeaderText = "Maestro_Numero_Empleado"
        Me.MaestroNumeroEmpleadoDataGridViewTextBoxColumn.Name = "MaestroNumeroEmpleadoDataGridViewTextBoxColumn"
        '
        'AlumnoMatriculaDataGridViewTextBoxColumn
        '
        Me.AlumnoMatriculaDataGridViewTextBoxColumn.DataPropertyName = "Alumno_Matricula"
        Me.AlumnoMatriculaDataGridViewTextBoxColumn.HeaderText = "Alumno_Matricula"
        Me.AlumnoMatriculaDataGridViewTextBoxColumn.Name = "AlumnoMatriculaDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Consultorio_medicoDataSet1
        '
        Me.Consultorio_medicoDataSet1.DataSetName = "consultorio_medicoDataSet1"
        Me.Consultorio_medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 84
        '
        'Consultorio_medicoDataSet
        '
        Me.Consultorio_medicoDataSet.DataSetName = "consultorio_medicoDataSet"
        Me.Consultorio_medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RevisionBindingSource
        '
        Me.RevisionBindingSource.DataMember = "Revision"
        Me.RevisionBindingSource.DataSource = Me.Consultorio_medicoDataSet
        '
        'RevisionTableAdapter
        '
        Me.RevisionTableAdapter.ClearBeforeFill = True
        '
        'RevisionBindingSource1
        '
        Me.RevisionBindingSource1.DataMember = "Revision"
        Me.RevisionBindingSource1.DataSource = Me.Consultorio_medicoDataSet
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'TextBox_Id_Cita
        '
        Me.TextBox_Id_Cita.Location = New System.Drawing.Point(231, 160)
        Me.TextBox_Id_Cita.Name = "TextBox_Id_Cita"
        Me.TextBox_Id_Cita.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Id_Cita.TabIndex = 85
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.Location = New System.Drawing.Point(370, 159)
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Fecha.TabIndex = 86
        '
        'TextBox_Hora
        '
        Me.TextBox_Hora.Location = New System.Drawing.Point(504, 159)
        Me.TextBox_Hora.Name = "TextBox_Hora"
        Me.TextBox_Hora.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Hora.TabIndex = 87
        '
        'Label_Fecha
        '
        Me.Label_Fecha.AutoSize = True
        Me.Label_Fecha.Location = New System.Drawing.Point(82, 64)
        Me.Label_Fecha.Name = "Label_Fecha"
        Me.Label_Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Fecha.Size = New System.Drawing.Size(88, 13)
        Me.Label_Fecha.TabIndex = 88
        Me.Label_Fecha.Text = "Buscar por fecha"
        '
        'Label_Id_Cita
        '
        Me.Label_Id_Cita.AutoSize = True
        Me.Label_Id_Cita.Location = New System.Drawing.Point(228, 144)
        Me.Label_Id_Cita.Name = "Label_Id_Cita"
        Me.Label_Id_Cita.Size = New System.Drawing.Size(79, 13)
        Me.Label_Id_Cita.TabIndex = 89
        Me.Label_Id_Cita.Text = "Numero de cita"
        '
        'Label_Fecha_TexBox
        '
        Me.Label_Fecha_TexBox.AutoSize = True
        Me.Label_Fecha_TexBox.Location = New System.Drawing.Point(367, 143)
        Me.Label_Fecha_TexBox.Name = "Label_Fecha_TexBox"
        Me.Label_Fecha_TexBox.Size = New System.Drawing.Size(37, 13)
        Me.Label_Fecha_TexBox.TabIndex = 90
        Me.Label_Fecha_TexBox.Text = "Fecha"
        '
        'Label_Hora
        '
        Me.Label_Hora.AutoSize = True
        Me.Label_Hora.Location = New System.Drawing.Point(501, 143)
        Me.Label_Hora.Name = "Label_Hora"
        Me.Label_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Label_Hora.TabIndex = 91
        Me.Label_Hora.Text = "Hora"
        '
        'Button_Insertar
        '
        Me.Button_Insertar.Location = New System.Drawing.Point(572, 95)
        Me.Button_Insertar.Name = "Button_Insertar"
        Me.Button_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Insertar.TabIndex = 92
        Me.Button_Insertar.Text = "Nueva"
        Me.Button_Insertar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(360, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 93
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(123, 158)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 20)
        Me.RadioButton2.TabIndex = 101
        Me.RadioButton2.Text = "Profesor"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(17, 158)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton1.TabIndex = 100
        Me.RadioButton1.Text = "Alumno"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Forms_Consultas_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button_Insertar)
        Me.Controls.Add(Me.Label_Hora)
        Me.Controls.Add(Me.Label_Fecha_TexBox)
        Me.Controls.Add(Me.Label_Id_Cita)
        Me.Controls.Add(Me.Label_Fecha)
        Me.Controls.Add(Me.TextBox_Hora)
        Me.Controls.Add(Me.TextBox_Fecha)
        Me.Controls.Add(Me.TextBox_Id_Cita)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.X)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Consultas_Insertar"
        Me.Text = "Forms_Consultas_Insertar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevisionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents X As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Consultorio_medicoDataSet As consultorio_medicoDataSet
    Friend WithEvents RevisionBindingSource As BindingSource
    Friend WithEvents RevisionTableAdapter As consultorio_medicoDataSetTableAdapters.RevisionTableAdapter
    Friend WithEvents RevisionBindingSource1 As BindingSource
    Friend WithEvents Consultorio_medicoDataSet1 As consultorio_medicoDataSet1
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents CitasTableAdapter As consultorio_medicoDataSet1TableAdapters.CitasTableAdapter
    Friend WithEvents IdCitasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicosMedicoNumeroEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaestroNumeroEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlumnoMatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_Id_Cita As TextBox
    Friend WithEvents TextBox_Fecha As TextBox
    Friend WithEvents TextBox_Hora As TextBox
    Friend WithEvents Label_Fecha As Label
    Friend WithEvents Label_Id_Cita As Label
    Friend WithEvents Label_Fecha_TexBox As Label
    Friend WithEvents Label_Hora As Label
    Friend WithEvents Button_Insertar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
