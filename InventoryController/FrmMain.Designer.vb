<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.dgvInventoryStatus = New System.Windows.Forms.DataGridView()
        Me.LocationName = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ViewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleasedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblInventoryLocationReleaseStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInventoryRelease = New InventoryController.dsInventoryRelease()
        Me.TblInventoryLocationReleaseStatusTableAdapter = New InventoryController.dsInventoryReleaseTableAdapters.tblInventoryLocationReleaseStatusTableAdapter()
        CType(Me.dgvInventoryStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TblInventoryLocationReleaseStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventoryRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventoryStatus
        '
        Me.dgvInventoryStatus.AllowUserToAddRows = False
        Me.dgvInventoryStatus.AllowUserToDeleteRows = False
        Me.dgvInventoryStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventoryStatus.AutoGenerateColumns = False
        Me.dgvInventoryStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventoryStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LocationName, Me.ReleasedDataGridViewCheckBoxColumn})
        Me.dgvInventoryStatus.DataSource = Me.TblInventoryLocationReleaseStatusBindingSource
        Me.dgvInventoryStatus.Location = New System.Drawing.Point(12, 31)
        Me.dgvInventoryStatus.Name = "dgvInventoryStatus"
        Me.dgvInventoryStatus.ReadOnly = True
        Me.dgvInventoryStatus.Size = New System.Drawing.Size(527, 583)
        Me.dgvInventoryStatus.TabIndex = 0
        '
        'LocationName
        '
        Me.LocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocationName.DataPropertyName = "LocationName"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationName.DefaultCellStyle = DataGridViewCellStyle1
        Me.LocationName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LocationName.HeaderText = "Location"
        Me.LocationName.Name = "LocationName"
        Me.LocationName.ReadOnly = True
        Me.LocationName.ToolTipText = "Click this button to release the location to production."
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Maroon
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(396, 635)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 34)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.DarkGreen
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(12, 635)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 34)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset Locations"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageLocationsToolStripMenuItem, Me.ViewReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageLocationsToolStripMenuItem
        '
        Me.ManageLocationsToolStripMenuItem.Name = "ManageLocationsToolStripMenuItem"
        Me.ManageLocationsToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ManageLocationsToolStripMenuItem.Text = "Manage Locations"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(204, 635)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reload Grid"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ViewReportToolStripMenuItem
        '
        Me.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem"
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ViewReportToolStripMenuItem.Text = "View Status Report"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ReleasedDataGridViewCheckBoxColumn
        '
        Me.ReleasedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReleasedDataGridViewCheckBoxColumn.DataPropertyName = "Released"
        Me.ReleasedDataGridViewCheckBoxColumn.HeaderText = "Released"
        Me.ReleasedDataGridViewCheckBoxColumn.Name = "ReleasedDataGridViewCheckBoxColumn"
        Me.ReleasedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ReleasedDataGridViewCheckBoxColumn.Visible = False
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
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(551, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvInventoryStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Inventory Release Control Panel"
        CType(Me.dgvInventoryStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TblInventoryLocationReleaseStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventoryRelease, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInventoryStatus As System.Windows.Forms.DataGridView
    Friend WithEvents DsInventoryRelease As InventoryController.dsInventoryRelease
    Friend WithEvents TblInventoryLocationReleaseStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInventoryLocationReleaseStatusTableAdapter As InventoryController.dsInventoryReleaseTableAdapters.tblInventoryLocationReleaseStatusTableAdapter
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationName As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ReleasedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManageLocationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ViewReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
