<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.webURL = New System.Windows.Forms.WebBrowser()
        Me.lnkSQLConfiguration = New System.Windows.Forms.LinkLabel()
        Me.lnkDelete = New System.Windows.Forms.LinkLabel()
        Me.lnkUpdate = New System.Windows.Forms.LinkLabel()
        Me.lnkInsert = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TopicsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(810, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TopicsToolStripMenuItem
        '
        Me.TopicsToolStripMenuItem.Name = "TopicsToolStripMenuItem"
        Me.TopicsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.TopicsToolStripMenuItem.Text = "Topics"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(810, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lnkInsert)
        Me.Panel1.Controls.Add(Me.lnkUpdate)
        Me.Panel1.Controls.Add(Me.lnkDelete)
        Me.Panel1.Controls.Add(Me.lnkSQLConfiguration)
        Me.Panel1.Location = New System.Drawing.Point(5, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 483)
        Me.Panel1.TabIndex = 2
        '
        'webURL
        '
        Me.webURL.Location = New System.Drawing.Point(188, 29)
        Me.webURL.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webURL.Name = "webURL"
        Me.webURL.ScriptErrorsSuppressed = True
        Me.webURL.Size = New System.Drawing.Size(615, 483)
        Me.webURL.TabIndex = 3
        '
        'lnkSQLConfiguration
        '
        Me.lnkSQLConfiguration.AutoSize = True
        Me.lnkSQLConfiguration.Location = New System.Drawing.Point(16, 14)
        Me.lnkSQLConfiguration.Name = "lnkSQLConfiguration"
        Me.lnkSQLConfiguration.Size = New System.Drawing.Size(140, 13)
        Me.lnkSQLConfiguration.TabIndex = 0
        Me.lnkSQLConfiguration.TabStop = True
        Me.lnkSQLConfiguration.Text = "SQL Connection Information"
        '
        'lnkDelete
        '
        Me.lnkDelete.AutoSize = True
        Me.lnkDelete.Location = New System.Drawing.Point(16, 27)
        Me.lnkDelete.Name = "lnkDelete"
        Me.lnkDelete.Size = New System.Drawing.Size(134, 13)
        Me.lnkDelete.TabIndex = 1
        Me.lnkDelete.TabStop = True
        Me.lnkDelete.Text = "Creating Delete SQL Script"
        '
        'lnkUpdate
        '
        Me.lnkUpdate.AutoSize = True
        Me.lnkUpdate.Location = New System.Drawing.Point(16, 40)
        Me.lnkUpdate.Name = "lnkUpdate"
        Me.lnkUpdate.Size = New System.Drawing.Size(138, 13)
        Me.lnkUpdate.TabIndex = 2
        Me.lnkUpdate.TabStop = True
        Me.lnkUpdate.Text = "Creating Update SQL Script"
        '
        'lnkInsert
        '
        Me.lnkInsert.AutoSize = True
        Me.lnkInsert.Location = New System.Drawing.Point(16, 53)
        Me.lnkInsert.Name = "lnkInsert"
        Me.lnkInsert.Size = New System.Drawing.Size(129, 13)
        Me.lnkInsert.TabIndex = 3
        Me.lnkInsert.TabStop = True
        Me.lnkInsert.Text = "Creating Insert SQL Script"
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 538)
        Me.Controls.Add(Me.webURL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Help"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lnkInsert As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkDelete As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkSQLConfiguration As System.Windows.Forms.LinkLabel
    Friend WithEvents webURL As System.Windows.Forms.WebBrowser
End Class
