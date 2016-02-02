<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTest = New System.Windows.Forms.CheckBox()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.radInsert = New System.Windows.Forms.RadioButton()
        Me.radUpdate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnFolderLookup = New System.Windows.Forms.Button()
        Me.diaFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkbackup = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.XLS_to_SQL_Conversion.My.Resources.Resources.ss
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 26)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Default Settings"
        '
        'chkTest
        '
        Me.chkTest.AutoSize = True
        Me.chkTest.Location = New System.Drawing.Point(183, 49)
        Me.chkTest.Name = "chkTest"
        Me.chkTest.Size = New System.Drawing.Size(85, 17)
        Me.chkTest.TabIndex = 11
        Me.chkTest.Text = "Run As Test"
        Me.chkTest.UseVisualStyleBackColor = True
        '
        'radDelete
        '
        Me.radDelete.AutoSize = True
        Me.radDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDelete.Location = New System.Drawing.Point(329, 70)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(67, 17)
        Me.radDelete.TabIndex = 14
        Me.radDelete.Text = "DELETE"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'radInsert
        '
        Me.radInsert.AutoSize = True
        Me.radInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInsert.Location = New System.Drawing.Point(183, 70)
        Me.radInsert.Name = "radInsert"
        Me.radInsert.Size = New System.Drawing.Size(65, 17)
        Me.radInsert.TabIndex = 12
        Me.radInsert.Text = "INSERT"
        Me.radInsert.UseVisualStyleBackColor = True
        '
        'radUpdate
        '
        Me.radUpdate.AutoSize = True
        Me.radUpdate.Checked = True
        Me.radUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUpdate.Location = New System.Drawing.Point(254, 70)
        Me.radUpdate.Name = "radUpdate"
        Me.radUpdate.Size = New System.Drawing.Size(69, 17)
        Me.radUpdate.TabIndex = 13
        Me.radUpdate.TabStop = True
        Me.radUpdate.Text = "UPDATE"
        Me.radUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Execute:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mode:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnCancel)
        Me.GroupBox5.Controls.Add(Me.btnFinish)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 151)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(495, 41)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(414, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(333, 9)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 0
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 199)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(501, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Database Backup Location:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(183, 113)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(270, 20)
        Me.txtLocation.TabIndex = 20
        '
        'btnFolderLookup
        '
        Me.btnFolderLookup.Location = New System.Drawing.Point(456, 113)
        Me.btnFolderLookup.Name = "btnFolderLookup"
        Me.btnFolderLookup.Size = New System.Drawing.Size(30, 20)
        Me.btnFolderLookup.TabIndex = 21
        Me.btnFolderLookup.Text = "..."
        Me.btnFolderLookup.UseVisualStyleBackColor = True
        '
        'diaFolder
        '
        Me.diaFolder.Description = "Database Backup Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Backup Before SQL Execute:"
        '
        'chkbackup
        '
        Me.chkbackup.AutoSize = True
        Me.chkbackup.Location = New System.Drawing.Point(183, 93)
        Me.chkbackup.Name = "chkbackup"
        Me.chkbackup.Size = New System.Drawing.Size(63, 17)
        Me.chkbackup.TabIndex = 23
        Me.chkbackup.Text = "Backup"
        Me.chkbackup.UseVisualStyleBackColor = True
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 221)
        Me.Controls.Add(Me.chkbackup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFolderLookup)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radDelete)
        Me.Controls.Add(Me.radInsert)
        Me.Controls.Add(Me.radUpdate)
        Me.Controls.Add(Me.chkTest)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkTest As System.Windows.Forms.CheckBox
    Friend WithEvents radDelete As System.Windows.Forms.RadioButton
    Friend WithEvents radInsert As System.Windows.Forms.RadioButton
    Friend WithEvents radUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnFolderLookup As System.Windows.Forms.Button
    Friend WithEvents diaFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkbackup As System.Windows.Forms.CheckBox
End Class
