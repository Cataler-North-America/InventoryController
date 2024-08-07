Public Class frmLocationManagement

    Private Sub frmLocationManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'DsInventoryRelease.tblInventoryLocationReleaseStatus' table.
        Me.TblInventoryLocationReleaseStatusTableAdapter.Fill(Me.DsInventoryRelease.tblInventoryLocationReleaseStatus)

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Dim ans As DialogResult = MsgBox("Update Locations?", MsgBoxStyle.YesNo, "Update")
        If ans = Windows.Forms.DialogResult.Yes Then
            Try
                Me.TblInventoryLocationReleaseStatusTableAdapter.Update(Me.DsInventoryRelease.tblInventoryLocationReleaseStatus)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    'Event handler to put default values in required cells
    Private Sub dgupdate_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgUpdate.DefaultValuesNeeded
        'Prevent DBNULL
        e.Row.Cells(0).Value = 0
        'Released = False
        e.Row.Cells(2).Value = 0
    End Sub
End Class