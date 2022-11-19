<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forms_Medicamentos_Ver
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
        Me.Consultorio_medicoDataSet1 = New Consultorio_Medico_ITS.consultorio_medicoDataSet1()
        Me.MedicamentosAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicamentos_AlmacenTableAdapter = New Consultorio_Medico_ITS.consultorio_medicoDataSet1TableAdapters.Medicamentos_AlmacenTableAdapter()
        Me.IDMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.Location = New System.Drawing.Point(23, 19)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(75, 23)
        Me.X.TabIndex = 4
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMedicamentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicamentosAlmacenBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(248, 359)
        Me.DataGridView1.TabIndex = 3
        '
        'Consultorio_medicoDataSet1
        '
        Me.Consultorio_medicoDataSet1.DataSetName = "consultorio_medicoDataSet1"
        Me.Consultorio_medicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicamentosAlmacenBindingSource
        '
        Me.MedicamentosAlmacenBindingSource.DataMember = "Medicamentos_Almacen"
        Me.MedicamentosAlmacenBindingSource.DataSource = Me.Consultorio_medicoDataSet1
        '
        'Medicamentos_AlmacenTableAdapter
        '
        Me.Medicamentos_AlmacenTableAdapter.ClearBeforeFill = True
        '
        'IDMedicamentoDataGridViewTextBoxColumn
        '
        Me.IDMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.HeaderText = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.Name = "IDMedicamentoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Forms_Medicamentos_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 542)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(684, 581)
        Me.MinimumSize = New System.Drawing.Size(684, 581)
        Me.Name = "Forms_Medicamentos_Ver"
        Me.Text = "Forms_Medicamentos_Ver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultorio_medicoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents X As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Consultorio_medicoDataSet1 As consultorio_medicoDataSet1
    Friend WithEvents MedicamentosAlmacenBindingSource As BindingSource
    Friend WithEvents Medicamentos_AlmacenTableAdapter As consultorio_medicoDataSet1TableAdapters.Medicamentos_AlmacenTableAdapter
    Friend WithEvents IDMedicamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
