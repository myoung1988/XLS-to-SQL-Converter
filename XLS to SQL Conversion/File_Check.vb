Imports System.IO

Public Class File_Check

    Public Shared Function Check_Config() As Boolean
        Return File.Exists(Application.StartupPath & "\Config.ini")
    End Function

    Public Shared Function Check_Pref() As Boolean
        Return File.Exists(Application.StartupPath & "\Preferences.ini")
    End Function

    Public Shared Sub Create_Config()
        Try
            Using sr As StreamWriter = New StreamWriter(Application.StartupPath() & "\Config.ini")
                sr.WriteLine("")
            End Using
        Catch
            MessageBox.Show("Could not write the Config.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub Create_Preferences()
        Try
            Using sr As StreamWriter = New StreamWriter(Application.StartupPath() & "\Preferences.ini")
                sr.WriteLine("Execute=False" & vbNewLine & "Mode=U" & vbNewLine & "DBLocation=C:/" & vbNewLine & "DBBackup=False")
            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function get_TestMode() As String
        Dim sMode As String = ""

        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Preferences.ini")
                Dim sExecute As String = ""

                sExecute = sr.ReadLine().Replace("Execute=", "")
                sMode = sr.ReadLine().Replace("Mode=", "")

                Return sMode

            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return sMode

    End Function

    Public Shared Function get_SQLMode() As Boolean
        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Preferences.ini")
                Dim sExecute As String = ""
                Dim sMode As String = ""

                sExecute = sr.ReadLine().Replace("Execute=", "")
                sMode = sr.ReadLine().Replace("Mode=", "")

                If sExecute = "True" Then
                    Return True
                Else
                    Return False
                End If

            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False

    End Function

    Public Shared Function get_DB_Location() As String
        Dim sExecute As String = ""
        Dim sMode As String = ""
        Dim sLoca As String = ""

        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Preferences.ini")

                sExecute = sr.ReadLine().Replace("Execute=", "")
                sMode = sr.ReadLine().Replace("Mode=", "")
                sLoca = sr.ReadLine().Replace("DBLocation=", "")

                Return sLoca

            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return sLoca

    End Function

    Public Shared Function get_DB_Backup() As Boolean
        Dim sExecute As String = ""
        Dim sMode As String = ""
        Dim sLoca As String = ""
        Dim DB As String = ""

        Try
            Using sr As StreamReader = New StreamReader(Application.StartupPath() & "\Preferences.ini")

                sExecute = sr.ReadLine().Replace("Execute=", "")
                sMode = sr.ReadLine().Replace("Mode=", "")
                sLoca = sr.ReadLine().Replace("DBLocation=", "")
                DB = sr.ReadLine().Replace("DBBackup=", "")

                If DB = "True" Then
                    Return True
                Else
                    Return False
                End If

            End Using
        Catch
            MessageBox.Show("Could not write the Preferences.ini file. This could be due to rights.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False

    End Function

End Class
