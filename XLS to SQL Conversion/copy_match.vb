Public Class copy_match

    Public iNum As Integer
    Private sInitialSQL As String
    Private sInitialXLS As String

    Public Overloads Sub ShowDialog(ByVal iNumber As Integer)
        iNum = iNumber
        sInitialSQL = XLSSQL_Main.lvwFields.SelectedItems(0).SubItems(2).Text
        sInitialXLS = XLSSQL_Main.lvwFields.SelectedItems(0).SubItems(1).Text
        Me.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub new_matching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboXLS.Items.Clear()

        For Each itm In XLSSQL_Main.cboKeyXLS.Items
            If Not itm = XLSSQL_Main.cboKeyXLS.Text Then
                cboXLS.Items.Add(itm)
            End If
        Next

        For Each lvwitm As ListViewItem In XLSSQL_Main.lvwFields.Items
            If lvwitm.Text = iNum Then
                lblField.Text = lvwitm.SubItems(2).Text
                Exit For
            End If
        Next

        XLSSQL_Main.populate_noitemsfound(cboXLS)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboXLS.Text = "No Items Found" Or lblField.Text = "No Items Found" Then
            MessageBox.Show("Please select an item to update matchings for", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Update_Item()
    End Sub

    Private Sub Update_Item()

        Dim lvitm As New ListViewItem
        lvitm.Text = iNum
        lvitm.SubItems.Add(cboXLS.Text)
        lvitm.SubItems.Add(lblField.Text)

        Dim fFound As Boolean = False
        For Each itm As ListViewItem In XLSSQL_Main.lvwFields.Items
            If itm.SubItems(1).Text = cboXLS.Text Then
                fFound = True
            End If
        Next

        If fFound Then
            MessageBox.Show("This field has already been added", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each itm As ListViewItem In XLSSQL_Main.lvwFields.Items
            If itm.Text = iNum Then
                XLSSQL_Main.lvwFields.Items(iNum - 1) = lvitm
            End If
        Next

        Me.Close()

    End Sub



End Class