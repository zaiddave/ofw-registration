Public Class frmMain

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmRegister.Show()

    End Sub

    Private Sub btnManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManage.Click
        Me.Hide()
        frmManage.Show()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Me.Hide()
        frmBackup.Show()

    End Sub
End Class
