Imports System.IO

Public Class frmBackup

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Try
            Dim s As StreamWriter
            Dim path As String = My.Application.Info.DirectoryPath
            If MessageBox.Show("This will overwrite your current database. Are you sure you want to do this?", _
                        "Confirm Backup", _
                        MessageBoxButtons.OKCancel, _
                        MessageBoxIcon.Question, _
                        MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                If Not Directory.Exists("C:\Backup") Then
                    Directory.CreateDirectory("C:\Backup")
                    File.Create("C:\ Backup\OFWRegistration.Mdb").Close()
                    File.Create("C:\Backup\Backup log.rtf").Close()
                    s = New StreamWriter("C:\Backup\Backup log.rtf", True)
                    s.WriteLine("This backup was initially taken on - " & Date.Now)
                    s.Flush()
                    s.Close()
                    FileCopy(path & "\OFWRegistration.mdb", "C:\Backup\OFWRegistration.Mdb")
                    s = New StreamWriter("C:\Backup\Backup log.rtf", True)
                    MsgBox("New directory and backup file created")
                Else
                    'Creating a directory by specifying a path in the TextBox, of the form c:\examples
                    'Instead of using a TextBox you can directly type the location of the directory like this
                    'Directory.CreateDirectory("c:\examples")
                    FileCopy(path & "\OFWRegistration.mdb", "C:\Backup\OFWRegistration.Mdb")
                    s = New StreamWriter("C:\Backup\Backup log.rtf", True)
                    s.WriteLine("This backup was last updated on - " & Date.Now)
                    s.Flush()
                    s.Close()
                    MessageBox.Show("Backup completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Data Load Failed"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Try
            Dim portfolioPath As String = My.Application.Info.DirectoryPath
            If MessageBox.Show("Restoring the database will overwrite your current database. Are you sure you want to do this?", _
                        "Confirm Delete", _
                        MessageBoxButtons.OKCancel, _
                        MessageBoxIcon.Question, _
                        MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                'Restore the database from a backup copy.
                FileCopy("C:\Backup\OFWRegistration.Mdb", portfolioPath & "\OFWRegistration.mdb")
                MessageBox.Show("Database Restoration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Dim MessageString As String = "Report this error to the system administrator: " & ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Data Load Failed"
            MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()

    End Sub
End Class