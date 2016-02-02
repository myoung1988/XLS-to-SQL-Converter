Public Class new_matching

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

        If cboXLS.Items.Count > 0 Then
            cboXLS.SelectedIndex = 0
        Else
            XLSSQL_Main.populate_noitemsfound(cboXLS)
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboXLS.Text = "No Items Found" Or cboSQL.Text = "No Items Found" Then
            MessageBox.Show("Please select an item to add matchings for", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Add_Item()
    End Sub

    Private Sub Add_Item()

        Dim lvitm As New ListViewItem
        lvitm.Text = XLSSQL_Main.lvwFields.Items.Count + 1
        lvitm.SubItems.Add(cboXLS.Text)
        lvitm.SubItems.Add(cboSQL.Text)

        Dim fFound As Boolean = False
        For Each itm As ListViewItem In XLSSQL_Main.lvwFields.Items
            If itm.SubItems(1).Text = cboXLS.Text Then
                fFound = True
            ElseIf itm.SubItems(2).Text = cboSQL.Text Then
                fFound = True
            End If
        Next

        If Not fFound Then
            XLSSQL_Main.lvwFields.Items.Add(lvitm)
        Else
            MessageBox.Show("This field has already been added", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class