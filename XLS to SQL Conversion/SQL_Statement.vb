Imports System.IO

Public Class SQL_Statement

    Public sFilePath As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtSQL.Text)
    End Sub

    Private Sub SQL_Statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSQL.Text = txtSQL.Text.ToUpper
    End Sub

    Private Sub btnRunSQL_Click(sender As Object, e As EventArgs) Handles btnRunSQL.Click

        If SQLName.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Try
            Using sr As StreamWriter = New StreamWriter(sFilePath)
                sr.WriteLine(txtSQL.Text)
            End Using

            Dim p As New System.Diagnostics.Process
            Dim s As New System.Diagnostics.ProcessStartInfo(sFilePath)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()

        Catch ex As Exception
            MessageBox.Show("Could not write to " & sFilePath & ". This could be due to rights. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class