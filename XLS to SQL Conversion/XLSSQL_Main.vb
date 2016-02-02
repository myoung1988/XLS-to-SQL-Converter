Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class XLSSQL_Main

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        diaPath.ShowDialog()

        If diaPath.FileName.ToString.Trim.Length > 0 Then
            txtFilePath.Text = diaPath.FileName
        Else
            txtFilePath.Text = ""
        End If

    End Sub

    Private Sub txtFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath.TextChanged
        If Not txtFilePath.Text = "" Then
            refresh_fields()
        End If
    End Sub

    Private Sub lnkRefreshFields_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRefreshFields.LinkClicked
        If Not txtFilePath.Text = "" Then
            refresh_fields()
        End If
    End Sub

    Private Sub radDelete_CheckedChanged(sender As Object, e As EventArgs) Handles radDelete.CheckedChanged
        If radDelete.Checked Then
            lvwFields.Items.Clear()
            lvwFields.Enabled = False
            lnkAdd.Enabled = False
            lnkDelete.Enabled = False
            lnkChanged.Enabled = False
        Else
            lvwFields.Enabled = True
            lnkAdd.Enabled = True
            lnkDelete.Enabled = True
            lnkChanged.Enabled = True
        End If
    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click

        If radInsert.Checked Then
            For Each itm As ListViewItem In lvwFields.Items
                If itm.SubItems(1).Text = "" Then
                    MessageBox.Show("All fields must have an excel column associated with it. If you have fewer excel columns thans required SQL fields, you will need to add more columns to your source Excel sheet.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
        End If

        If cboKeySQL.Text = "No Items Found" Or cboKeyXLS.Text = "No Items Found" Or cboTables.Text = "No Items Found" Or ((radUpdate.Checked Or radInsert.Checked) And lvwFields.Items.Count = 0) Then
            MessageBox.Show("Unable to generate SQL code. Please make sure all of the fields are filled out before generating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Processing.Show()
        Processing.Update()

        SQL_Statement.txtSQL.Text = ""

        Dim sType As String = ""

        If radDelete.Checked Then
            sType = "D"
        ElseIf radInsert.Checked Then
            sType = "I"
        Else
            sType = "U"
        End If

        SQL_Generation.Generate_Statement(sType, lvwFields, txtFilePath.Text, cboTables.Text, cboKeySQL.Text, cboKeyXLS.Text, chkTest.Checked)

        Processing.Close()
        SQL_Statement.ShowDialog()

    End Sub

    Private Sub radInsert_CheckedChanged(sender As Object, e As EventArgs) Handles radInsert.CheckedChanged
        If radInsert.Checked Then
            lvwFields.Items.Clear()
            populate_insert()
        End If
    End Sub

#Region "Private Sub Routines"
    Private Sub refresh_fields()
        Try
            cboKeyXLS.Items.Clear()
            Dim xlApp As New Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim range As Excel.Range
            Dim rCnt As Integer
            Dim cCnt As Integer
            Dim Obj As Object

            xlWorkBook = xlApp.Workbooks.Open(txtFilePath.Text)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")

            range = xlWorkSheet.UsedRange

            ' This reads each row of data
            For rCnt = 1 To range.Rows.Count
                For cCnt = 1 To range.Columns.Count
                    Obj = CType(range.Cells(rCnt, cCnt), Excel.Range)
                    'MsgBox(Obj.value)

                    If rCnt = 1 Then
                        cboKeyXLS.Items.Add(Obj.value)
                    End If
                Next
            Next

            If cboKeyXLS.Items.Count > 0 Then
                cboKeyXLS.SelectedIndex = 0
            Else
                MessageBox.Show("There are no headers within the Excel Document, the Headers must be in the first row of the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                populate_noitemsfound(cboKeyXLS)
            End If

            xlWorkBook.Close()
            xlApp.Quit()

        Catch ex As Exception
            MessageBox.Show("Could not read " & diaPath.FileName.ToString & "." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotImplemented()
        MessageBox.Show("This feature has not been implemented yet",
                        "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub populate_SQL_TablesFields()
        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try
                cboTables.Items.Clear()
                cboKeySQL.Items.Clear()

                Dim SQLCmd As New SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME", SQLConfig.SQLConn)
                Dim SQLReader As SqlDataReader = SQLCmd.ExecuteReader

                While SQLReader.Read()
                    cboTables.Items.Add(SQLReader(0).ToString())
                End While

                lblDatabase.Text = SQLConfig.SQLConn.Database

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to retrieve the results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()

        If cboTables.Items.Count > 0 Then
            cboTables.SelectedIndex = 0
        Else
            populate_noitemsfound(cboTables)
        End If

    End Sub

    Public Sub populate_noitemsfound(ByRef cboExmple As ComboBox)
        If cboExmple.Items.Count = 0 Then
            cboExmple.Items.Add("No Items Found")
            cboExmple.SelectedIndex = 0
        End If
    End Sub

    Private Sub populate_insert()

        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try
                Dim SQLCmd As New SqlCommand("SELECT NAME FROM sys.columns WHERE object_id = OBJECT_ID('" & cboTables.Text & "') AND NOT (NAME IN (SELECT column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 AND table_name = '" & cboTables.Text & "')) AND IS_NULLABLE = 0", SQLConfig.SQLConn)
                Dim SQLReader As SqlDataReader = SQLCmd.ExecuteReader

                While SQLReader.Read()
                    Dim itm As New ListViewItem
                    itm.Text = lvwFields.Items.Count + 1
                    itm.SubItems.Add("")
                    itm.SubItems.Add(SQLReader(0).ToString())

                    lvwFields.Items.Add(itm)
                End While

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to retrieve the results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()

        If cboKeySQL.Items.Count > 1 Then
            For Each itm In cboKeySQL.Items
                If Not itm = cboKeySQL.Text Then
                    Dim lvItm As New ListViewItem
                    lvItm.Text = lvwFields.Items.Count + 1
                    lvItm.SubItems.Add("")
                    lvItm.SubItems.Add(itm)
                    lvwFields.Items.Add(lvItm)
                End If
            Next
        End If

    End Sub

#End Region


    Private Sub lnkConfigSQL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkConfigSQL.LinkClicked
        SQLConfig.ShowDialog()
    End Sub

    Private Sub ConfigureSQLConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureSQLConnectionToolStripMenuItem.Click
        SQLConfig.ShowDialog()
    End Sub

    Private Sub XLSSQL_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkTest.Checked = File_Check.get_SQLMode
        Dim sMode As String = File_Check.get_TestMode

        If sMode = "D" Then
            radDelete.Checked = True
        ElseIf sMode = "I" Then
            radInsert.Checked = True
        Else
            radUpdate.Checked = True
        End If

        populate_noitemsfound(cboKeyXLS)
        populate_SQL_TablesFields()

        If lblDatabase.Text = "" Then
            lblDatabase.Text = "Not Connected"
        End If

    End Sub

    Private Sub lnkRefreshSQL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRefreshSQL.LinkClicked
        populate_SQL_TablesFields()
    End Sub

    Private Sub cboTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTables.SelectedIndexChanged
        If radInsert.Checked Then
            lvwFields.Items.Clear()
            populate_insert()
        End If

        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try
                cboKeySQL.Items.Clear()

                Dim SQLCmd As New SqlCommand("SELECT column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 AND table_name = '" & cboTables.Text & "'", SQLConfig.SQLConn)
                Dim SQLReader As SqlDataReader = SQLCmd.ExecuteReader

                While SQLReader.Read()
                    cboKeySQL.Items.Add(SQLReader(0).ToString())
                End While

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to retrieve the results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()

        If cboKeySQL.Items.Count > 0 Then
            cboKeySQL.SelectedIndex = 0
        Else
            populate_noitemsfound(cboTables)
        End If

    End Sub

    Private Sub lnkAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked

        If Not XLS_Found() Then
            MessageBox.Show("Please select an Excel Document before adding fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try
                new_matching.cboSQL.Items.Clear()

                Dim SQLCmd As New SqlCommand("SELECT NAME FROM sys.columns WHERE object_id = OBJECT_ID('" & cboTables.Text & "')", SQLConfig.SQLConn)
                Dim SQLReader As SqlDataReader = SQLCmd.ExecuteReader

                While SQLReader.Read()
                    If Not SQLReader(0).ToString() = cboKeySQL.Text Then
                        new_matching.cboSQL.Items.Add(SQLReader(0).ToString())
                    End If
                End While

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to retrieve the results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()

        If new_matching.cboSQL.Items.Count > 0 Then
            new_matching.cboSQL.SelectedIndex = 0
        Else
            populate_noitemsfound(new_matching.cboSQL)
        End If

        new_matching.lblTable.Text = cboTables.Text

        new_matching.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lnkDelete_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDelete.LinkClicked
        If Not XLS_Found() Then
            MessageBox.Show("Please select an Excel Document before deleting fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If lvwFields.SelectedItems.Count > 0 AndAlso radInsert.Checked Then
            If MessageBox.Show("Deleting fields that are required for inserting may result in failed SQL statements. Do you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        If lvwFields.SelectedItems.Count > 0 AndAlso MessageBox.Show("Are you sure you wish to delete this pairing?", "Delete Pairing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            lvwFields.Items.Remove(lvwFields.SelectedItems(0))
        End If

        reorder_fields()

    End Sub

    Private Sub GenerateSQLScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateSQLScriptToolStripMenuItem.Click
        btnGen_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Processing.Show()
    End Sub

    Private Sub radUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles radUpdate.CheckedChanged
        If radUpdate.Checked Then
            lvwFields.Items.Clear()
        End If
    End Sub

    Private Sub cboKeySQL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKeySQL.SelectedIndexChanged
        If radInsert.Checked Then
            lvwFields.Items.Clear()
            populate_insert()
        End If
    End Sub

    Private Sub lnkChanged_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkChanged.LinkClicked
        If Not XLS_Found() Then
            MessageBox.Show("Please select an Excel Document before changing fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        copy_match_call()
    End Sub

    Private Sub lvwFields_DoubleClick(sender As Object, e As EventArgs) Handles lvwFields.DoubleClick
        If Not XLS_Found() Then
            MessageBox.Show("Please select an Excel Document before changing fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        copy_match_call()
    End Sub

    Private Sub copy_match_call()
        If Not lvwFields.SelectedItems.Count > 0 Then
            MessageBox.Show("No Item Selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        copy_match.lblField.Text = lvwFields.SelectedItems(0).SubItems(2).Text
        copy_match.lblTable.Text = cboTables.Text

        copy_match.ShowDialog(Convert.ToInt32(lvwFields.SelectedItems(0).Text))
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        NotImplemented()
    End Sub

    Private Sub ExampleXLSDocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExampleXLSDocumentsToolStripMenuItem.Click

    End Sub

    Private Shared Sub reorder_fields()

        'Dim oTemp As New ListView
        Dim iCount As Integer = 1
        For Each itm As ListViewItem In XLSSQL_Main.lvwFields.Items
            itm.Text = iCount
            iCount = iCount + 1
        Next

        ' XLSSQL_Main.lvwFields.Items.Clear()
    End Sub

    Private Function XLS_Found() As Boolean
        If cboKeyXLS.Text = "No Items Found" Or txtFilePath.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub lvwFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwFields.SelectedIndexChanged

    End Sub

    Private Sub LoadUpdateSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadUpdateSQLExampleToolStripMenuItem.Click
        txtFilePath.Text = Application.StartupPath & "\Update_Example.xlsx"
        radUpdate.Checked = True
    End Sub

    Private Sub OpenUpdateSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenUpdateSQLExampleToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\Update_Example.xlsx")
    End Sub

    Private Sub LoadInsertSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadInsertSQLExampleToolStripMenuItem.Click
        txtFilePath.Text = Application.StartupPath & "\Insert_Example.xlsx"
        radInsert.Checked = True
    End Sub

    Private Sub OpenInsertSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInsertSQLExampleToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\Insert_Example.xlsx")
    End Sub

    Private Sub LoadDeleteSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDeleteSQLExampleToolStripMenuItem.Click
        txtFilePath.Text = Application.StartupPath & "\Delete_Example.xlsx"
        radDelete.Checked = True
    End Sub

    Private Sub OpenDeleteSQLExampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDeleteSQLExampleToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\Delete_Example.xlsx")
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub BackUpDatabaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackUpDatabaseToolStripMenuItem1.Click
        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try
                Dim sTimestamp As String = Now.Date.ToShortDateString & Now.ToShortTimeString

                sTimestamp = sTimestamp.Replace(":", "")
                sTimestamp = sTimestamp.Replace("-", "")
                sTimestamp = sTimestamp.Replace("/", "")
                sTimestamp = sTimestamp.Replace(" ", "")

                Dim SQLCmd As New SqlCommand("BACKUP DATABASE [" & SQLConfig.SQLConn.Database & "] TO DISK = '" & File_Check.get_DB_Location & "\" & SQLConfig.SQLConn.Database & sTimestamp & ".bak' WITH NOFORMAT, NAME = '" & SQLConfig.SQLConn.Database & "_" & sTimestamp & "'", SQLConfig.SQLConn)
                SQLCmd.ExecuteNonQuery()

                MessageBox.Show("The backup was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to backup the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()
    End Sub

    Private Sub InstallTestTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallTestTableToolStripMenuItem.Click
        SQLConfig.open_Connection()

        If SQLConfig.SQLConn.State = ConnectionState.Open Then
            Try

                Dim SQLCmd As New SqlCommand(My.Resources.Test_Install_sql, SQLConfig.SQLConn)
                SQLCmd.ExecuteNonQuery()

                MessageBox.Show("The Test Table was Installed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An unhandled error has occured when trying to backup the database. Verify you have rights to write to the database or that the table hasn't been previously installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SQLConfig.close_Connection()
            End Try
        End If

        SQLConfig.close_Connection()
    End Sub

    Private Sub AboutExcelToSQLConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutExcelToSQLConversionToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
End Class
