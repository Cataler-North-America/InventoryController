Public Class FrmMain

    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call SetupGrid() 'Fill the grid, size buttons,set styles, etc.

        'Only Finance/IT can see the controls.
        If IsInGroup("CATALER-NA\AccountingGlobal") = True Or IsInGroup("CATALER-NA\IT Group") Then
            dgvInventoryStatus.Visible = True
        Else 'Hide controls just in case and then exit the program
            MsgBox("You are not allowed to use this program!", MsgBoxStyle.Exclamation, "Access Denied")
            btnReset.Visible = False 'Don't let anyone reset the grid
            dgvInventoryStatus.Visible = False 'Hide the grid
            Me.Size = New Size(180, 100) 'Resize the window
            Me.Dispose()
        End If

    End Sub


    Private Sub dgvInventoryStatus_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventoryStatus.CellContentClick

        'Debug code START
        'Dim colName As String = dgDocView.Columns(e.ColumnIndex).Name ' Get the column name if needed
        'Dim extension As String = Strings.Right(Strings.RTrim(dgDocView.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value), 5)
        'You can tell which row it is on by reading the RowIndex property from the event arg e.
        'MessageBox.Show(String.Format("You clicked the button in row {0} of the Location column", e.RowIndex))
        'MsgBox(dgDocView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        'Debug code END
        Dim ans As DialogResult = MsgBox("Release this location to production?", MsgBoxStyle.YesNo, "Verify")
        If ans = Windows.Forms.DialogResult.Yes Then
            If dgvInventoryStatus.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = False Then
                'DB Code goes here
                Me.TblInventoryLocationReleaseStatusTableAdapter.UpdateRelease(dgvInventoryStatus.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                dgvInventoryStatus.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Style.BackColor = Color.DarkGreen
                ''Hide the current row
                Me.dgvInventoryStatus.CurrentCell = Nothing
                Me.dgvInventoryStatus.Rows(e.RowIndex).Visible = False
                dgvInventoryStatus.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = True
            Else : MsgBox("This area is already released", MsgBoxStyle.OkOnly, "Status")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Dim ans As DialogResult = MsgBox("This will Reset ALL Locations, are you sure?", MsgBoxStyle.YesNo, "Database Operation")
        If ans = Windows.Forms.DialogResult.Yes Then
            Me.TblInventoryLocationReleaseStatusTableAdapter.ResetLocations()
            Call SetupGrid() 'Redraw the grid
        End If
    End Sub

    Private Sub SetupGrid()
        'This line of code loads data into the 'DsInventoryRelease.tblInventoryLocationReleaseStatus' table.
        Me.TblInventoryLocationReleaseStatusTableAdapter.Fill(Me.DsInventoryRelease.tblInventoryLocationReleaseStatus)

        'Make the buttons bigger
        Dim rowNumber As Integer = 0
        For Each row As DataGridViewRow In dgvInventoryStatus.Rows
            row.Height = 90 'Button height in pixels6
            If row.IsNewRow Then Continue For
            If dgvInventoryStatus.Rows(rowNumber).Cells(2).Value = True Then
                dgvInventoryStatus.Rows(rowNumber).Cells(2).Style.BackColor = Color.DarkGreen
                'Hide the current row when released
                Me.dgvInventoryStatus.CurrentCell = Nothing
                Me.dgvInventoryStatus.Rows(rowNumber).Visible = False
            Else : dgvInventoryStatus.Rows(rowNumber).Cells(2).Style.BackColor = Color.Maroon
            End If
            rowNumber = rowNumber + 1
        Next 'loop
    End Sub

    'This function checks to see if the user is in the specified AD group from parameter "GroupName"
    Private Function IsInGroup(GroupName As String) As Boolean
        Dim MyIdentity As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim MyPrincipal As System.Security.Principal.WindowsPrincipal = New System.Security.Principal.WindowsPrincipal(MyIdentity)

        Return MyPrincipal.IsInRole(GroupName) 'This is the check against AD
    End Function

    Private Sub ManageLocationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManageLocationsToolStripMenuItem.Click
        Dim f As New frmLocationManagement
        f.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a As New frmAboutBox
        a.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call SetupGrid() 'Fill the grid, size buttons,set styles, etc.
    End Sub

    Private Sub ViewReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewReportToolStripMenuItem.Click
        Process.Start(My.Settings.IExplorer, My.Settings.siteInventoryStatus)
    End Sub
End Class
