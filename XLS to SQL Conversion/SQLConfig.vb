Imports System.IO
Imports System.Data.SqlClient

Public Class SQLConfig
    Public sConnection As String = get_Connection_String()
    Public SQLConn As New SqlConnection(get_Connection_String) 'The SQL Connection

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        If (txtDatabase.Text = "" Or txtDataSource.Text = "" Or txtPswd.Text = "" Or txtUserID.Text = "") And txtConnectionString.Text = "" Then
            MessageBox.Show("All fields are required when creating the connection", "Validation Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Data Source=maindb03;Initial Catalog=r25;Persist Security Info=True;User ID=r25_Counts;Password=Pswd%1
        Try
            Using sr As StreamWriter = New StreamWriter(Application.StartupPath() & "\Config.ini")
                sr.WriteLine(txtConnectionString.Text)
                MessageBox.Show("Your changes have been Saved. Please restart the program for these changes to take effect.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch
            MessageBox.Show("Could not write to the Config.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SQLConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_scrn()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        open_Connection()

        If SQLConn.State = ConnectionState.Open Then
            MessageBox.Show("Connection Test Successfull", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Unable to connect to SQL Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        close_Connection()
    End Sub

    Public Function get_Connection_String()
        Dim sTmpConnect As String = ""

        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Config.ini")
                sTmpConnect = sr.ReadLine
            End Using
        Catch
        End Try

        Return sTmpConnect

    End Function

    Public Sub open_Connection()

        Try
            If SQLConn.State = ConnectionState.Closed Then
                SQLConn.Open() 'Open the connection
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub close_Connection()

        Try
            If SQLConn.State = ConnectionState.Open Then
                SQLConn.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub populate_scrn()

        txtConnectionString.Text = ""

        Dim sTmpConnect As String = ""

        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Config.ini")
                sTmpConnect = sr.ReadLine
            End Using
        Catch
        End Try

        txtConnectionString.Text = get_Connection_String()

    End Sub

    Private Sub txtDataSource_TextChanged(sender As Object, e As EventArgs) Handles txtDataSource.TextChanged
        update_connection_str()
    End Sub

    Private Sub txtDatabase_TextChanged(sender As Object, e As EventArgs) Handles txtDatabase.TextChanged
        update_connection_str()
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        update_connection_str()
    End Sub

    Private Sub txtPswd_TextChanged(sender As Object, e As EventArgs) Handles txtPswd.TextChanged
        update_connection_str()
    End Sub

    Private Sub chkSecurity_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecurity.CheckedChanged
        update_connection_str()
    End Sub

    Private Sub update_connection_str()
        txtConnectionString.Text = "Data Source=" & txtDataSource.Text & ";Initial Catalog=" & txtDatabase.Text & _
                             ";Persist Security Info=" & chkSecurity.Checked & ";User ID=" & txtUserID.Text & _
                             ";Password=" & txtPswd.Text

        SQLConn.ConnectionString = txtConnectionString.Text

    End Sub

End Class