<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocationManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocationManagement))
        Me.dgUpdate = New System.Windows.Forms.DataGridView()
        Me.TblInventoryLocationReleaseStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInventoryRelease = New InventoryController.dsInventoryRelease()
        Me.TblInventoryLocationReleaseStatusTableAdapter = New InventoryController.dsInventoryReleaseTableAdapters.tblInventoryLocationReleaseStatusTableAdapter()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleasedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInventoryLocationReleaseStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventoryRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUpdate
        '
        Me.dgUpdate.AutoGenerateColumns = False
        Me.dgUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUpdate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LocationNameDataGridViewTextBoxColumn, Me.ReleasedDataGridViewCheckBoxColumn})
        Me.dgUpdate.DataSource = Me.TblInventoryLocationReleaseStatusBindingSource
        Me.dgUpdate.Location = New System.Drawing.Point(3, 4)
        Me.dgUpdate.Name = "dgUpdate"
        Me.dgUpdate.Size = New System.Drawing.Size(225, 641)
        Me.dgUpdate.TabIndex = 0
        '
        'TblInventoryLocationReleaseStatusBindingSource
        '
        Me.TblInventoryLocationReleaseStatusBindingSource.DataMember = "tblInventoryLocationReleaseStatus"
        Me.TblInventoryLocationReleaseStatusBindingSource.DataSource = Me.DsInventoryRelease
        '
        'DsInventoryRelease
        '
        Me.DsInventoryRelease.DataSetName = "dsInventoryRelease"
        Me.DsInventoryRelease.EnforceConstraints = False
        Me.DsInventoryRelease.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInventoryLocationReleaseStatusTableAdapter
        '
        Me.TblInventoryLocationReleaseStatusTableAdapter.ClearBeforeFill = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.DarkGreen
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(3, 665)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(219, 34)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Update"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Maroon
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(3, 715)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(219, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'LocationNameDataGridViewTextBoxColumn
        '
        Me.LocationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName"
        Me.LocationNameDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationNameDataGridViewTextBoxColumn.Name = "LocationNameDataGridViewTextBoxColumn"
        '
        'ReleasedDataGridViewCheckBoxColumn
        '
        Me.ReleasedDataGridViewCheckBoxColumn.DataPropertyName = "Released"
        Me.ReleasedDataGridViewCheckBoxColumn.HeaderText = "Released"
        Me.ReleasedDataGridViewCheckBoxColumn.Name = "ReleasedDataGridViewCheckBoxColumn"
        Me.ReleasedDataGridViewCheckBoxColumn.Visible = False
        '
        'frmLocationManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(231, 761)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dgUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(247, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(247, 800)
        Me.Name = "frmLocationManagement"
        Me.Text = "Location Management"
        CType(Me.dgUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInventoryLocationReleaseStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventoryRelease, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents DsInventoryRelease As InventoryController.dsInventoryRelease
    Friend WithEvents TblInventoryLocationReleaseStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInventoryLocationReleaseStatusTableAdapter As InventoryController.dsInventoryReleaseTableAdapters.tblInventoryLocationReleaseStatusTableAdapter
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReleasedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
