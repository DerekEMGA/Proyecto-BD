<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms_Consultas_Ver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forms_Consultas_Ver))
        Me.X = New System.Windows.Forms.Button()
        Me.MedicamentosRecetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultorio_medicoDataSet1 = New Consultorio_Medico_ITS.consultorio_medicoDataSet1()
        Me.RevisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RevisionTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.RevisionTableAdapter()
        Me.Medicamentos_RecetaTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.Medicamentos_RecetaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedicamentosRecetaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MedicamentosRecetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosRecetaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(10, 57)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 8
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'MedicamentosRecetaBindingSource
        '
        Me.MedicamentosRecetaBindingSource.DataMember = "Medicamentos_Receta"
        Me.MedicamentosRecetaBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Consultorio_medicoDataSet1
        '
        Me.Consultorio_medicoDataSet1.DataSetName = "consultorio_medicoDataSet1"
        Me.Consultorio_medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RevisionBindingSource
        '
        Me.RevisionBindingSource.DataMember = "Revision"
        Me.RevisionBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'RevisionTableAdapter
        '
        Me.RevisionTableAdapter.ClearBeforeFill = True
        '
        'Medicamentos_RecetaTableAdapter
        '
        Me.Medicamentos_RecetaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(847, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(12, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(910, 463)
        Me.DataGridView1.TabIndex = 10
        '
        'MedicamentosRecetaBindingSource1
        '
        Me.MedicamentosRecetaBindingSource1.DataMember = "Medicamentos_Receta"
        Me.MedicamentosRecetaBindingSource1.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Forms_Consultas_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(934, 623)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.X)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 662)
        Me.MinimumSize = New System.Drawing.Size(950, 662)
        Me.Name = "Forms_Consultas_Ver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forms_Consultas_Ver"
        CType(Me.MedicamentosRecetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosRecetaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents X As Button
    Friend WithEvents Consultorio_medicoDataSet1 As consultorio_medicoDataSet1
    Friend WithEvents RevisionBindingSource As BindingSource
    Friend WithEvents RevisionTableAdapter As consultorio_medicoDataSet1TableAdapters.RevisionTableAdapter
    Friend WithEvents MedicamentosRecetaBindingSource As BindingSource
    Friend WithEvents Medicamentos_RecetaTableAdapter As consultorio_medicoDataSet1TableAdapters.Medicamentos_RecetaTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MedicamentosRecetaBindingSource1 As BindingSource
End Class
