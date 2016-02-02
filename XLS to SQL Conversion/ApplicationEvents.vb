Imports System.IO

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' This will check and create pref and or config files. 

            If Not File_Check.Check_Config Then
                File_Check.Create_Config()
            End If

            If Not File_Check.Check_Pref Then
                File_Check.Create_Preferences()
            End If

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If MessageBox.Show("An unhandled exception has occured. Do you wish to send this error report?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                Dim sError As String = ""

                sError = sError & "HRESULT: " & e.Exception.HResult & " " & vbNewLine & vbNewLine
                sError = sError & "STACK TRACE: " & e.Exception.StackTrace & " " & vbNewLine & vbNewLine
                sError = sError & "MESSAGE: " & e.Exception.Message & " " & vbNewLine & vbNewLine

                Process.Start(String.Format("mailto:{0}?subject={1}&body={2}", "myoung@jjc.edu", "Error Report for Excel to SQL Conversion", sError))

                XLSSQL_Main.Close()
            End If
        End Sub
    End Class


End Namespace

