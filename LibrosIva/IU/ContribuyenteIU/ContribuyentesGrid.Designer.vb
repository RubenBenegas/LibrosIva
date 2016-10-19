<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContribuyentesGrid
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContribuyentesGrid))
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDependenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MesCierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInscripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContribuyentesCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContribuyentesCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Modificar
        '
        Me.Modificar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(125, 52)
        Me.Modificar.Text = "Modificar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.Eliminar, Me.Modificar, Me.Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 70)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(850, 55)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(115, 52)
        Me.Agregar.Text = "Agregar"
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(115, 52)
        Me.Eliminar.Text = "Eliminar"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.RightToLeftAutoMirrorImage = True
        Me.Salir.Size = New System.Drawing.Size(90, 52)
        Me.Salir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contribuyentes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 64)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 70)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 70)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Instituto Superior Dr. Carlos Maria Carena"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(775, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdPersonaDataGridViewTextBoxColumn, Me.TipoDocumentoDataGridViewTextBoxColumn, Me.NumeroDocumentoDataGridViewTextBoxColumn, Me.TipoPersonaDataGridViewTextBoxColumn, Me.TipoClaveDataGridViewTextBoxColumn, Me.EstadoClaveDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.IdProvinciaDataGridViewTextBoxColumn, Me.CodPostalDataGridViewTextBoxColumn, Me.IdDependenciaDataGridViewTextBoxColumn, Me.MesCierreDataGridViewTextBoxColumn, Me.FechaInscripcionDataGridViewTextBoxColumn, Me.NombreProvinciaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContribuyentesCollectionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(850, 225)
        Me.DataGridView1.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdPersonaDataGridViewTextBoxColumn
        '
        Me.IdPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona"
        Me.IdPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona"
        Me.IdPersonaDataGridViewTextBoxColumn.Name = "IdPersonaDataGridViewTextBoxColumn"
        Me.IdPersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDocumentoDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.HeaderText = "tipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Name = "TipoDocumentoDataGridViewTextBoxColumn"
        Me.TipoDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroDocumentoDataGridViewTextBoxColumn
        '
        Me.NumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "numeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "numeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.Name = "NumeroDocumentoDataGridViewTextBoxColumn"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoPersonaDataGridViewTextBoxColumn
        '
        Me.TipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "tipoPersona"
        Me.TipoPersonaDataGridViewTextBoxColumn.HeaderText = "tipoPersona"
        Me.TipoPersonaDataGridViewTextBoxColumn.Name = "TipoPersonaDataGridViewTextBoxColumn"
        Me.TipoPersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoClaveDataGridViewTextBoxColumn
        '
        Me.TipoClaveDataGridViewTextBoxColumn.DataPropertyName = "tipoClave"
        Me.TipoClaveDataGridViewTextBoxColumn.HeaderText = "tipoClave"
        Me.TipoClaveDataGridViewTextBoxColumn.Name = "TipoClaveDataGridViewTextBoxColumn"
        Me.TipoClaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoClaveDataGridViewTextBoxColumn
        '
        Me.EstadoClaveDataGridViewTextBoxColumn.DataPropertyName = "estadoClave"
        Me.EstadoClaveDataGridViewTextBoxColumn.HeaderText = "estadoClave"
        Me.EstadoClaveDataGridViewTextBoxColumn.Name = "EstadoClaveDataGridViewTextBoxColumn"
        Me.EstadoClaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProvinciaDataGridViewTextBoxColumn
        '
        Me.IdProvinciaDataGridViewTextBoxColumn.DataPropertyName = "idProvincia"
        Me.IdProvinciaDataGridViewTextBoxColumn.HeaderText = "idProvincia"
        Me.IdProvinciaDataGridViewTextBoxColumn.Name = "IdProvinciaDataGridViewTextBoxColumn"
        Me.IdProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodPostalDataGridViewTextBoxColumn
        '
        Me.CodPostalDataGridViewTextBoxColumn.DataPropertyName = "codPostal"
        Me.CodPostalDataGridViewTextBoxColumn.HeaderText = "codPostal"
        Me.CodPostalDataGridViewTextBoxColumn.Name = "CodPostalDataGridViewTextBoxColumn"
        Me.CodPostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDependenciaDataGridViewTextBoxColumn
        '
        Me.IdDependenciaDataGridViewTextBoxColumn.DataPropertyName = "idDependencia"
        Me.IdDependenciaDataGridViewTextBoxColumn.HeaderText = "idDependencia"
        Me.IdDependenciaDataGridViewTextBoxColumn.Name = "IdDependenciaDataGridViewTextBoxColumn"
        Me.IdDependenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesCierreDataGridViewTextBoxColumn
        '
        Me.MesCierreDataGridViewTextBoxColumn.DataPropertyName = "mesCierre"
        Me.MesCierreDataGridViewTextBoxColumn.HeaderText = "mesCierre"
        Me.MesCierreDataGridViewTextBoxColumn.Name = "MesCierreDataGridViewTextBoxColumn"
        Me.MesCierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInscripcionDataGridViewTextBoxColumn
        '
        Me.FechaInscripcionDataGridViewTextBoxColumn.DataPropertyName = "fechaInscripcion"
        Me.FechaInscripcionDataGridViewTextBoxColumn.HeaderText = "fechaInscripcion"
        Me.FechaInscripcionDataGridViewTextBoxColumn.Name = "FechaInscripcionDataGridViewTextBoxColumn"
        Me.FechaInscripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProvinciaDataGridViewTextBoxColumn
        '
        Me.NombreProvinciaDataGridViewTextBoxColumn.DataPropertyName = "nombreProvincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.HeaderText = "nombreProvincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.Name = "NombreProvinciaDataGridViewTextBoxColumn"
        Me.NombreProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContribuyentesCollectionBindingSource
        '
        Me.ContribuyentesCollectionBindingSource.DataSource = GetType(LibrosIva.ContribuyentesCollection)
        '
        'ContribuyentesGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 353)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "ContribuyentesGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContribuyentesGrid"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContribuyentesCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPersonaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPersonaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoClaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoClaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDependenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesCierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInscripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContribuyentesCollectionBindingSource As System.Windows.Forms.BindingSource
End Class
