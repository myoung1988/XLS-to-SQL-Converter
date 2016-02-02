Public Class SQLName

    Private Sub btnRunSQL_Click(sender As Object, e As EventArgs) Handles btnRunSQL.Click
        If txtPath.Text = "" Then
            MessageBox.Show("Missing Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SQL_Statement.sFilePath = txtPath.Text
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        diaPath.ShowDialog()

        If diaPath.FileName.ToString.Trim.Length > 0 Then
            txtPath.Text = diaPath.FileName
        Else
            txtPath.Text = ""
        End If
    End Sub
End Class