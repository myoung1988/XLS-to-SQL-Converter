Imports System.IO

Public Class Preferences

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        Dim sExecute As Boolean = chkTest.Checked
        Dim sMode As String = ""

        If radDelete.Checked Then
            sMode = "D"
        ElseIf radInsert.Checked Then
            sMode = "I"
        Else
            sMode = "U"
        End If

        Try
            Using sr As StreamWriter = New StreamWriter(Application.StartupPath() & "\Preferences.ini")
                sr.WriteLine("Execute=" & sExecute & vbNewLine & "Mode=" & sMode & vbNewLine & "DBLocation=" & txtLocation.Text & vbNewLine & "DBBackup=" & chkbackup.Checked & vbNewLine)
            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()

    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            chkTest.Checked = File_Check.get_SQLMode

            Dim sMode As String = File_Check.get_TestMode
            If sMode = "D" Then
                radDelete.Checked = True
            ElseIf sMode = "I" Then
                radInsert.Checked = True
            Else
                radUpdate.Checked = True
            End If

            txtLocation.Text = File_Check.get_DB_Location()
            chkbackup.Checked = File_Check.get_DB_Backup()

        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFolderLookup_Click(sender As Object, e As EventArgs) Handles btnFolderLookup.Click
        diaFolder.ShowDialog()

        txtLocation.Text = diaFolder.SelectedPath

    End Sub

End Class