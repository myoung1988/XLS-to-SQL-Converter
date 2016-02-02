<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XLSSQL_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XLSSQL_Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureSQLConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateSQLScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackUpDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpDatabaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallTestTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExampleXLSDocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadUpdateSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenUpdateSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadInsertSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInsertSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadDeleteSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDeleteSQLExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutExcelToSQLConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.diaPath = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnkDelete = New System.Windows.Forms.LinkLabel()
        Me.lnkChanged = New System.Windows.Forms.LinkLabel()
        Me.lnkAdd = New System.Windows.Forms.LinkLabel()
        Me.lvwFields = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radUpdate = New System.Windows.Forms.RadioButton()
        Me.radInsert = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboKeyXLS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboKeySQL = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTables = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkTest = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lnkConfigSQL = New System.Windows.Forms.LinkLabel()
        Me.lnkRefreshSQL = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lnkRefreshFields = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SQLToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureSQLConnectionToolStripMenuItem, Me.GenerateSQLScriptToolStripMenuItem, Me.ToolStripSeparator4, Me.BackUpDatabaseToolStripMenuItem})
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SQLToolStripMenuItem.Text = "SQL"
        '
        'ConfigureSQLConnectionToolStripMenuItem
        '
        Me.ConfigureSQLConnectionToolStripMenuItem.Name = "ConfigureSQLConnectionToolStripMenuItem"
        Me.ConfigureSQLConnectionToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ConfigureSQLConnectionToolStripMenuItem.Text = "Configure SQL Connection..."
        '
        'GenerateSQLScriptToolStripMenuItem
        '
        Me.GenerateSQLScriptToolStripMenuItem.Name = "GenerateSQLScriptToolStripMenuItem"
        Me.GenerateSQLScriptToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GenerateSQLScriptToolStripMenuItem.Text = "Generate SQL Script"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(222, 6)
        '
        'BackUpDatabaseToolStripMenuItem
        '
        Me.BackUpDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackUpDatabaseToolStripMenuItem1, Me.InstallTestTableToolStripMenuItem})
        Me.BackUpDatabaseToolStripMenuItem.Name = "BackUpDatabaseToolStripMenuItem"
        Me.BackUpDatabaseToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.BackUpDatabaseToolStripMenuItem.Text = "Database Management"
        '
        'BackUpDatabaseToolStripMenuItem1
        '
        Me.BackUpDatabaseToolStripMenuItem1.Name = "BackUpDatabaseToolStripMenuItem1"
        Me.BackUpDatabaseToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.BackUpDatabaseToolStripMenuItem1.Text = "Back Up Database"
        '
        'InstallTestTableToolStripMenuItem
        '
        Me.InstallTestTableToolStripMenuItem.Name = "InstallTestTableToolStripMenuItem"
        Me.InstallTestTableToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.InstallTestTableToolStripMenuItem.Text = "Install Test Table"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExampleXLSDocumentsToolStripMenuItem, Me.ViewHelpToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutExcelToSQLConversionToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExampleXLSDocumentsToolStripMenuItem
        '
        Me.ExampleXLSDocumentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadUpdateSQLExampleToolStripMenuItem, Me.OpenUpdateSQLExampleToolStripMenuItem, Me.ToolStripSeparator2, Me.LoadInsertSQLExampleToolStripMenuItem, Me.OpenInsertSQLExampleToolStripMenuItem, Me.ToolStripSeparator3, Me.LoadDeleteSQLExampleToolStripMenuItem, Me.OpenDeleteSQLExampleToolStripMenuItem})
        Me.ExampleXLSDocumentsToolStripMenuItem.Name = "ExampleXLSDocumentsToolStripMenuItem"
        Me.ExampleXLSDocumentsToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ExampleXLSDocumentsToolStripMenuItem.Text = "Example Excel Documents"
        '
        'LoadUpdateSQLExampleToolStripMenuItem
        '
        Me.LoadUpdateSQLExampleToolStripMenuItem.Name = "LoadUpdateSQLExampleToolStripMenuItem"
        Me.LoadUpdateSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LoadUpdateSQLExampleToolStripMenuItem.Text = "Load Update SQL Example"
        '
        'OpenUpdateSQLExampleToolStripMenuItem
        '
        Me.OpenUpdateSQLExampleToolStripMenuItem.Name = "OpenUpdateSQLExampleToolStripMenuItem"
        Me.OpenUpdateSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OpenUpdateSQLExampleToolStripMenuItem.Text = "Open Update SQL Example"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(212, 6)
        '
        'LoadInsertSQLExampleToolStripMenuItem
        '
        Me.LoadInsertSQLExampleToolStripMenuItem.Name = "LoadInsertSQLExampleToolStripMenuItem"
        Me.LoadInsertSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LoadInsertSQLExampleToolStripMenuItem.Text = "Load Insert SQL Example"
        '
        'OpenInsertSQLExampleToolStripMenuItem
        '
        Me.OpenInsertSQLExampleToolStripMenuItem.Name = "OpenInsertSQLExampleToolStripMenuItem"
        Me.OpenInsertSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OpenInsertSQLExampleToolStripMenuItem.Text = "Open Insert SQL Example"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(212, 6)
        '
        'LoadDeleteSQLExampleToolStripMenuItem
        '
        Me.LoadDeleteSQLExampleToolStripMenuItem.Name = "LoadDeleteSQLExampleToolStripMenuItem"
        Me.LoadDeleteSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LoadDeleteSQLExampleToolStripMenuItem.Text = "Load Delete SQL Example"
        '
        'OpenDeleteSQLExampleToolStripMenuItem
        '
        Me.OpenDeleteSQLExampleToolStripMenuItem.Name = "OpenDeleteSQLExampleToolStripMenuItem"
        Me.OpenDeleteSQLExampleToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OpenDeleteSQLExampleToolStripMenuItem.Text = "Open Delete SQL Example"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(234, 6)
        '
        'AboutExcelToSQLConversionToolStripMenuItem
        '
        Me.AboutExcelToSQLConversionToolStripMenuItem.Name = "AboutExcelToSQLConversionToolStripMenuItem"
        Me.AboutExcelToSQLConversionToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AboutExcelToSQLConversionToolStripMenuItem.Text = "About Excel to SQL Conversion"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblDatabase})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(559, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel1.Text = "Database"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = ":"
        '
        'lblDatabase
        '
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 48)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(469, 15)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Excel Document File Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilePath.Location = New System.Drawing.Point(158, 15)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(308, 20)
        Me.txtFilePath.TabIndex = 0
        '
        'diaPath
        '
        Me.diaPath.DefaultExt = "xlsx"
        Me.diaPath.Filter = "Excel files (*.xlsx) | *.xlsx"
        Me.diaPath.RestoreDirectory = True
        Me.diaPath.Title = "XLS Document Lookup"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnkDelete)
        Me.GroupBox2.Controls.Add(Me.lnkChanged)
        Me.GroupBox2.Controls.Add(Me.lnkAdd)
        Me.GroupBox2.Controls.Add(Me.lvwFields)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 216)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'lnkDelete
        '
        Me.lnkDelete.AutoSize = True
        Me.lnkDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkDelete.Location = New System.Drawing.Point(457, 185)
        Me.lnkDelete.Name = "lnkDelete"
        Me.lnkDelete.Size = New System.Drawing.Size(85, 13)
        Me.lnkDelete.TabIndex = 3
        Me.lnkDelete.TabStop = True
        Me.lnkDelete.Text = "Delete Matching"
        '
        'lnkChanged
        '
        Me.lnkChanged.AutoSize = True
        Me.lnkChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChanged.Location = New System.Drawing.Point(366, 185)
        Me.lnkChanged.Name = "lnkChanged"
        Me.lnkChanged.Size = New System.Drawing.Size(91, 13)
        Me.lnkChanged.TabIndex = 2
        Me.lnkChanged.TabStop = True
        Me.lnkChanged.Text = "Change Matching"
        '
        'lnkAdd
        '
        Me.lnkAdd.AutoSize = True
        Me.lnkAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAdd.Location = New System.Drawing.Point(292, 185)
        Me.lnkAdd.Name = "lnkAdd"
        Me.lnkAdd.Size = New System.Drawing.Size(73, 13)
        Me.lnkAdd.TabIndex = 1
        Me.lnkAdd.TabStop = True
        Me.lnkAdd.Text = "Add Matching"
        Me.lnkAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvwFields
        '
        Me.lvwFields.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwFields.FullRowSelect = True
        Me.lvwFields.Location = New System.Drawing.Point(6, 9)
        Me.lvwFields.MultiSelect = False
        Me.lvwFields.Name = "lvwFields"
        Me.lvwFields.Size = New System.Drawing.Size(543, 162)
        Me.lvwFields.TabIndex = 0
        Me.lvwFields.UseCompatibleStateImageBehavior = False
        Me.lvwFields.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Excel Field"
        Me.ColumnHeader2.Width = 196
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SQL Field"
        Me.ColumnHeader3.Width = 194
        '
        'radDelete
        '
        Me.radDelete.AutoSize = True
        Me.radDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDelete.Location = New System.Drawing.Point(207, 11)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(67, 17)
        Me.radDelete.TabIndex = 7
        Me.radDelete.Text = "DELETE"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Mode:"
        '
        'radUpdate
        '
        Me.radUpdate.AutoSize = True
        Me.radUpdate.Checked = True
        Me.radUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUpdate.Location = New System.Drawing.Point(132, 11)
        Me.radUpdate.Name = "radUpdate"
        Me.radUpdate.Size = New System.Drawing.Size(69, 17)
        Me.radUpdate.TabIndex = 5
        Me.radUpdate.TabStop = True
        Me.radUpdate.Text = "UPDATE"
        Me.radUpdate.UseVisualStyleBackColor = True
        '
        'radInsert
        '
        Me.radInsert.AutoSize = True
        Me.radInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInsert.Location = New System.Drawing.Point(61, 11)
        Me.radInsert.Name = "radInsert"
        Me.radInsert.Size = New System.Drawing.Size(65, 17)
        Me.radInsert.TabIndex = 4
        Me.radInsert.Text = "INSERT"
        Me.radInsert.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboKeyXLS)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 48)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'cboKeyXLS
        '
        Me.cboKeyXLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKeyXLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKeyXLS.FormattingEnabled = True
        Me.cboKeyXLS.Location = New System.Drawing.Point(79, 15)
        Me.cboKeyXLS.Name = "cboKeyXLS"
        Me.cboKeyXLS.Size = New System.Drawing.Size(420, 21)
        Me.cboKeyXLS.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Key Field:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboKeySQL)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cboTables)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(2, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(555, 48)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'cboKeySQL
        '
        Me.cboKeySQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKeySQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKeySQL.FormattingEnabled = True
        Me.cboKeySQL.Location = New System.Drawing.Point(323, 15)
        Me.cboKeySQL.Name = "cboKeySQL"
        Me.cboKeySQL.Size = New System.Drawing.Size(176, 21)
        Me.cboKeySQL.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(289, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Key:"
        '
        'cboTables
        '
        Me.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTables.FormattingEnabled = True
        Me.cboTables.Location = New System.Drawing.Point(79, 15)
        Me.cboTables.Name = "cboTables"
        Me.cboTables.Size = New System.Drawing.Size(194, 21)
        Me.cboTables.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Table:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnGen)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(2, 569)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 48)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(407, 13)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(135, 23)
        Me.btnGen.TabIndex = 0
        Me.btnGen.Text = "Generate SQL Script"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkTest)
        Me.GroupBox6.Controls.Add(Me.radDelete)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.radInsert)
        Me.GroupBox6.Controls.Add(Me.radUpdate)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(2, 24)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(555, 39)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        '
        'chkTest
        '
        Me.chkTest.AutoSize = True
        Me.chkTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTest.Location = New System.Drawing.Point(441, 11)
        Me.chkTest.Name = "chkTest"
        Me.chkTest.Size = New System.Drawing.Size(108, 17)
        Me.chkTest.TabIndex = 8
        Me.chkTest.Text = "Run SQL as Test"
        Me.chkTest.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.XLS_to_SQL_Conversion.My.Resources.Resources.ss
        Me.Panel4.Controls.Add(Me.lnkConfigSQL)
        Me.Panel4.Controls.Add(Me.lnkRefreshSQL)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(2, 234)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(555, 26)
        Me.Panel4.TabIndex = 8
        '
        'lnkConfigSQL
        '
        Me.lnkConfigSQL.AutoSize = True
        Me.lnkConfigSQL.BackColor = System.Drawing.Color.Transparent
        Me.lnkConfigSQL.LinkColor = System.Drawing.Color.White
        Me.lnkConfigSQL.Location = New System.Drawing.Point(336, 6)
        Me.lnkConfigSQL.Name = "lnkConfigSQL"
        Me.lnkConfigSQL.Size = New System.Drawing.Size(133, 13)
        Me.lnkConfigSQL.TabIndex = 5
        Me.lnkConfigSQL.TabStop = True
        Me.lnkConfigSQL.Text = "Configure SQL Connection"
        '
        'lnkRefreshSQL
        '
        Me.lnkRefreshSQL.AutoSize = True
        Me.lnkRefreshSQL.BackColor = System.Drawing.Color.Transparent
        Me.lnkRefreshSQL.LinkColor = System.Drawing.Color.White
        Me.lnkRefreshSQL.Location = New System.Drawing.Point(475, 6)
        Me.lnkRefreshSQL.Name = "lnkRefreshSQL"
        Me.lnkRefreshSQL.Size = New System.Drawing.Size(74, 13)
        Me.lnkRefreshSQL.TabIndex = 4
        Me.lnkRefreshSQL.TabStop = True
        Me.lnkRefreshSQL.Text = "Refresh Fields"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SQL Fields"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.XLS_to_SQL_Conversion.My.Resources.Resources.ss
        Me.Panel3.Controls.Add(Me.lnkRefreshFields)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(2, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(555, 26)
        Me.Panel3.TabIndex = 4
        '
        'lnkRefreshFields
        '
        Me.lnkRefreshFields.AutoSize = True
        Me.lnkRefreshFields.BackColor = System.Drawing.Color.Transparent
        Me.lnkRefreshFields.LinkColor = System.Drawing.Color.White
        Me.lnkRefreshFields.Location = New System.Drawing.Point(475, 6)
        Me.lnkRefreshFields.Name = "lnkRefreshFields"
        Me.lnkRefreshFields.Size = New System.Drawing.Size(74, 13)
        Me.lnkRefreshFields.TabIndex = 4
        Me.lnkRefreshFields.TabStop = True
        Me.lnkRefreshFields.Text = "Refresh Fields"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Excel Key Field"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.XLS_to_SQL_Conversion.My.Resources.Resources.ss
        Me.Panel2.Controls.Add(Me.lbl)
        Me.Panel2.Location = New System.Drawing.Point(2, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 26)
        Me.Panel2.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(5, 6)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(40, 13)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Fields"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.XLS_to_SQL_Conversion.My.Resources.Resources.ss
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 26)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Imported File"
        '
        'XLSSQL_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 645)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "XLSSQL_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excel to SQL Conversion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents diaPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lnkDelete As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkChanged As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAdd As System.Windows.Forms.LinkLabel
    Friend WithEvents lvwFields As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboKeyXLS As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lnkRefreshFields As System.Windows.Forms.LinkLabel
    Friend WithEvents SQLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigureSQLConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboKeySQL As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTables As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lnkConfigSQL As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkRefreshSQL As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radDelete As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents radUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents radInsert As System.Windows.Forms.RadioButton
    Friend WithEvents GenerateSQLScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExampleXLSDocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutExcelToSQLConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTest As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoadUpdateSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenUpdateSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoadInsertSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInsertSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoadDeleteSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDeleteSQLExampleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackUpDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpDatabaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallTestTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
