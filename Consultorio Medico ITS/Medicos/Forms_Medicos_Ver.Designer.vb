<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forms_Medicos_Ver
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
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultorio_medicoDataSet1 = New Consultorio_Medico_ITS.consultorio_medicoDataSet1()
        Me.MedicosTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.MedicosTableAdapter()
        Me.MedicamentosRecetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicamentos_RecetaTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.Medicamentos_RecetaTableAdapter()
        Me.MedicamentosRecetaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentosRecetaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaestroTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.MaestroTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosRecetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosRecetaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosRecetaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 19)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 6
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "Medicos"
        Me.MedicosBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Consultorio_medicoDataSet1
        '
        Me.Consultorio_medicoDataSet1.DataSetName = "consultorio_medicoDataSet1"
        Me.Consultorio_medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'MedicamentosRecetaBindingSource
        '
        Me.MedicamentosRecetaBindingSource.DataMember = "Medicamentos_Receta"
        Me.MedicamentosRecetaBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Medicamentos_RecetaTableAdapter
        '
        Me.Medicamentos_RecetaTableAdapter.ClearBeforeFill = True
        '
        'MedicamentosRecetaBindingSource1
        '
        Me.MedicamentosRecetaBindingSource1.DataMember = "Medicamentos_Receta"
        Me.MedicamentosRecetaBindingSource1.DataSource = Me.Consultorio_medicoDataSet1
        '
        'MedicosBindingSource1
        '
        Me.MedicosBindingSource1.DataMember = "Medicos"
        Me.MedicosBindingSource1.DataSource = Me.Consultorio_medicoDataSet1
        '
        'MedicamentosRecetaBindingSource2
        '
        Me.MedicamentosRecetaBindingSource2.DataMember = "Medicamentos_Receta"
        Me.MedicamentosRecetaBindingSource2.DataSource = Me.Consultorio_medicoDataSet1
        '
        'MaestroTableAdapter
        '
        Me.MaestroTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 390)
        Me.DataGridView1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(581, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Forms_Medicos_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.X)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicos_Ver"
        Me.Text = "Especialidad"
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosRecetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosRecetaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosRecetaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents X As Button
    Friend WithEvents Consultorio_medicoDataSet1 As consultorio_medicoDataSet1
    Friend WithEvents MedicosBindingSource As BindingSource
    Friend WithEvents MedicosTableAdapter As consultorio_medicoDataSet1TableAdapters.MedicosTableAdapter
    Friend WithEvents MedicamentosRecetaBindingSource As BindingSource
    Friend WithEvents Medicamentos_RecetaTableAdapter As consultorio_medicoDataSet1TableAdapters.Medicamentos_RecetaTableAdapter
    Friend WithEvents MedicamentosRecetaBindingSource1 As BindingSource
    Friend WithEvents MedicamentosRecetaBindingSource2 As BindingSource
    Friend WithEvents MedicosBindingSource1 As BindingSource
    Friend WithEvents MaestroTableAdapter As consultorio_medicoDataSet1TableAdapters.MaestroTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
