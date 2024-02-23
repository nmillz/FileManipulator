<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.txtBaseFolder = New System.Windows.Forms.TextBox()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.lbFilesFound = New System.Windows.Forms.ListBox()
        Me.lblFolderLocation = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMangaName = New System.Windows.Forms.Label()
        Me.txtInsertAfter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInsertString = New System.Windows.Forms.TextBox()
        Me.btnAddVolumeNum = New System.Windows.Forms.Button()
        Me.rbReplaceString = New System.Windows.Forms.RadioButton()
        Me.rbAddVolNumbers = New System.Windows.Forms.RadioButton()
        Me.pnlAddString = New System.Windows.Forms.Panel()
        Me.pnlReplaceString = New System.Windows.Forms.Panel()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.rbRegularExp = New System.Windows.Forms.RadioButton()
        Me.btnReplaceString = New System.Windows.Forms.Button()
        Me.lblStringToFind = New System.Windows.Forms.Label()
        Me.txtStringToReplace = New System.Windows.Forms.TextBox()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.tlpStringOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPadNumbers = New System.Windows.Forms.TabPage()
        Me.cmboMinZeros = New System.Windows.Forms.ComboBox()
        Me.lblMinZeros = New System.Windows.Forms.Label()
        Me.lblPadAfter = New System.Windows.Forms.Label()
        Me.txtPadAfter = New System.Windows.Forms.TextBox()
        Me.btnPadNumbers = New System.Windows.Forms.Button()
        Me.tpReplaceInsertStrings = New System.Windows.Forms.TabPage()
        Me.tpManageFolders = New System.Windows.Forms.TabPage()
        Me.tpCombineImages = New System.Windows.Forms.TabPage()
        Me.btnCombineImages = New System.Windows.Forms.Button()
        Me.txtImageName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtImageSize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbRowColumn = New System.Windows.Forms.RadioButton()
        Me.rbColumnRow = New System.Windows.Forms.RadioButton()
        Me.btnRemoveEmptyFolders = New System.Windows.Forms.Button()
        Me.btnDeleteFiletype = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.pnlAddString.SuspendLayout()
        Me.pnlReplaceString.SuspendLayout()
        Me.tlpStringOptions.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpPadNumbers.SuspendLayout()
        Me.tpReplaceInsertStrings.SuspendLayout()
        Me.tpManageFolders.SuspendLayout()
        Me.tpCombineImages.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBaseFolder
        '
        Me.txtBaseFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBaseFolder.Location = New System.Drawing.Point(81, 12)
        Me.txtBaseFolder.Name = "txtBaseFolder"
        Me.txtBaseFolder.Size = New System.Drawing.Size(562, 20)
        Me.txtBaseFolder.TabIndex = 1
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Location = New System.Drawing.Point(649, 10)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(27, 23)
        Me.btnOpenFolder.TabIndex = 0
        Me.btnOpenFolder.Text = "..."
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'lbFilesFound
        '
        Me.lbFilesFound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFilesFound.HorizontalScrollbar = True
        Me.lbFilesFound.Location = New System.Drawing.Point(12, 61)
        Me.lbFilesFound.Name = "lbFilesFound"
        Me.lbFilesFound.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbFilesFound.Size = New System.Drawing.Size(306, 394)
        Me.lbFilesFound.Sorted = True
        Me.lbFilesFound.TabIndex = 2
        '
        'lblFolderLocation
        '
        Me.lblFolderLocation.AutoSize = True
        Me.lblFolderLocation.Location = New System.Drawing.Point(12, 15)
        Me.lblFolderLocation.Name = "lblFolderLocation"
        Me.lblFolderLocation.Size = New System.Drawing.Size(63, 13)
        Me.lblFolderLocation.TabIndex = 3
        Me.lblFolderLocation.Text = "Base Folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Files Found"
        '
        'lblMangaName
        '
        Me.lblMangaName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMangaName.AutoSize = True
        Me.lblMangaName.Location = New System.Drawing.Point(51, 16)
        Me.lblMangaName.Name = "lblMangaName"
        Me.lblMangaName.Size = New System.Drawing.Size(61, 13)
        Me.lblMangaName.TabIndex = 5
        Me.lblMangaName.Text = "Insert After:"
        '
        'txtInsertAfter
        '
        Me.txtInsertAfter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInsertAfter.Location = New System.Drawing.Point(114, 13)
        Me.txtInsertAfter.Name = "txtInsertAfter"
        Me.txtInsertAfter.Size = New System.Drawing.Size(161, 20)
        Me.txtInsertAfter.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "String to Insert:"
        '
        'txtInsertString
        '
        Me.txtInsertString.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInsertString.Location = New System.Drawing.Point(114, 58)
        Me.txtInsertString.Name = "txtInsertString"
        Me.txtInsertString.Size = New System.Drawing.Size(161, 20)
        Me.txtInsertString.TabIndex = 8
        '
        'btnAddVolumeNum
        '
        Me.btnAddVolumeNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddVolumeNum.Location = New System.Drawing.Point(186, 98)
        Me.btnAddVolumeNum.Name = "btnAddVolumeNum"
        Me.btnAddVolumeNum.Size = New System.Drawing.Size(94, 47)
        Me.btnAddVolumeNum.TabIndex = 11
        Me.btnAddVolumeNum.Text = "Insert String in Selected Files"
        Me.btnAddVolumeNum.UseVisualStyleBackColor = True
        '
        'rbReplaceString
        '
        Me.rbReplaceString.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbReplaceString.AutoSize = True
        Me.rbReplaceString.Checked = True
        Me.rbReplaceString.Location = New System.Drawing.Point(6, 17)
        Me.rbReplaceString.Name = "rbReplaceString"
        Me.rbReplaceString.Size = New System.Drawing.Size(100, 17)
        Me.rbReplaceString.TabIndex = 12
        Me.rbReplaceString.TabStop = True
        Me.rbReplaceString.Text = "Replace Strings"
        Me.rbReplaceString.UseVisualStyleBackColor = True
        '
        'rbAddVolNumbers
        '
        Me.rbAddVolNumbers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbAddVolNumbers.AutoSize = True
        Me.rbAddVolNumbers.Location = New System.Drawing.Point(135, 17)
        Me.rbAddVolNumbers.Name = "rbAddVolNumbers"
        Me.rbAddVolNumbers.Size = New System.Drawing.Size(81, 17)
        Me.rbAddVolNumbers.TabIndex = 13
        Me.rbAddVolNumbers.Text = "Insert String"
        Me.rbAddVolNumbers.UseVisualStyleBackColor = True
        '
        'pnlAddString
        '
        Me.pnlAddString.Controls.Add(Me.lblMangaName)
        Me.pnlAddString.Controls.Add(Me.txtInsertAfter)
        Me.pnlAddString.Controls.Add(Me.Label4)
        Me.pnlAddString.Controls.Add(Me.btnAddVolumeNum)
        Me.pnlAddString.Controls.Add(Me.txtInsertString)
        Me.pnlAddString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddString.Location = New System.Drawing.Point(3, 155)
        Me.pnlAddString.Name = "pnlAddString"
        Me.pnlAddString.Size = New System.Drawing.Size(314, 167)
        Me.pnlAddString.TabIndex = 14
        Me.pnlAddString.Visible = False
        '
        'pnlReplaceString
        '
        Me.pnlReplaceString.Controls.Add(Me.rbNormal)
        Me.pnlReplaceString.Controls.Add(Me.rbRegularExp)
        Me.pnlReplaceString.Controls.Add(Me.btnReplaceString)
        Me.pnlReplaceString.Controls.Add(Me.lblStringToFind)
        Me.pnlReplaceString.Controls.Add(Me.txtStringToReplace)
        Me.pnlReplaceString.Controls.Add(Me.txtReplaceWith)
        Me.pnlReplaceString.Controls.Add(Me.lblReplaceWith)
        Me.pnlReplaceString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReplaceString.Location = New System.Drawing.Point(3, 3)
        Me.pnlReplaceString.Name = "pnlReplaceString"
        Me.pnlReplaceString.Size = New System.Drawing.Size(314, 146)
        Me.pnlReplaceString.TabIndex = 15
        '
        'rbNormal
        '
        Me.rbNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Checked = True
        Me.rbNormal.Location = New System.Drawing.Point(31, 91)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbNormal.TabIndex = 17
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "Normal"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'rbRegularExp
        '
        Me.rbRegularExp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbRegularExp.AutoSize = True
        Me.rbRegularExp.Location = New System.Drawing.Point(30, 114)
        Me.rbRegularExp.Name = "rbRegularExp"
        Me.rbRegularExp.Size = New System.Drawing.Size(116, 17)
        Me.rbRegularExp.TabIndex = 18
        Me.rbRegularExp.Text = "Regular Expression"
        Me.rbRegularExp.UseVisualStyleBackColor = True
        '
        'btnReplaceString
        '
        Me.btnReplaceString.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReplaceString.Location = New System.Drawing.Point(186, 91)
        Me.btnReplaceString.Name = "btnReplaceString"
        Me.btnReplaceString.Size = New System.Drawing.Size(94, 47)
        Me.btnReplaceString.TabIndex = 12
        Me.btnReplaceString.Text = "Replace String in Selected Files"
        Me.btnReplaceString.UseVisualStyleBackColor = True
        '
        'lblStringToFind
        '
        Me.lblStringToFind.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStringToFind.AutoSize = True
        Me.lblStringToFind.Location = New System.Drawing.Point(25, 14)
        Me.lblStringToFind.Name = "lblStringToFind"
        Me.lblStringToFind.Size = New System.Drawing.Size(92, 13)
        Me.lblStringToFind.TabIndex = 12
        Me.lblStringToFind.Text = "String to Replace:"
        '
        'txtStringToReplace
        '
        Me.txtStringToReplace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStringToReplace.Location = New System.Drawing.Point(119, 11)
        Me.txtStringToReplace.Name = "txtStringToReplace"
        Me.txtStringToReplace.Size = New System.Drawing.Size(161, 20)
        Me.txtStringToReplace.TabIndex = 13
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtReplaceWith.Location = New System.Drawing.Point(119, 56)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.Size = New System.Drawing.Size(161, 20)
        Me.txtReplaceWith.TabIndex = 15
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.Location = New System.Drawing.Point(42, 59)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(75, 13)
        Me.lblReplaceWith.TabIndex = 14
        Me.lblReplaceWith.Text = "Replace With:"
        '
        'tlpStringOptions
        '
        Me.tlpStringOptions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpStringOptions.ColumnCount = 1
        Me.tlpStringOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStringOptions.Controls.Add(Me.pnlReplaceString, 0, 0)
        Me.tlpStringOptions.Controls.Add(Me.pnlAddString, 0, 1)
        Me.tlpStringOptions.Location = New System.Drawing.Point(6, 47)
        Me.tlpStringOptions.Name = "tlpStringOptions"
        Me.tlpStringOptions.RowCount = 3
        Me.tlpStringOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStringOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStringOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStringOptions.Size = New System.Drawing.Size(320, 348)
        Me.tlpStringOptions.TabIndex = 16
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(12, 467)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 17
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpPadNumbers)
        Me.TabControl1.Controls.Add(Me.tpReplaceInsertStrings)
        Me.TabControl1.Controls.Add(Me.tpManageFolders)
        Me.TabControl1.Controls.Add(Me.tpCombineImages)
        Me.TabControl1.Location = New System.Drawing.Point(336, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 450)
        Me.TabControl1.TabIndex = 18
        '
        'tpPadNumbers
        '
        Me.tpPadNumbers.Controls.Add(Me.cmboMinZeros)
        Me.tpPadNumbers.Controls.Add(Me.lblMinZeros)
        Me.tpPadNumbers.Controls.Add(Me.lblPadAfter)
        Me.tpPadNumbers.Controls.Add(Me.txtPadAfter)
        Me.tpPadNumbers.Controls.Add(Me.btnPadNumbers)
        Me.tpPadNumbers.Location = New System.Drawing.Point(4, 22)
        Me.tpPadNumbers.Name = "tpPadNumbers"
        Me.tpPadNumbers.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPadNumbers.Size = New System.Drawing.Size(332, 424)
        Me.tpPadNumbers.TabIndex = 1
        Me.tpPadNumbers.Text = "Pad Numbers"
        Me.tpPadNumbers.UseVisualStyleBackColor = True
        '
        'cmboMinZeros
        '
        Me.cmboMinZeros.FormattingEnabled = True
        Me.cmboMinZeros.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmboMinZeros.Location = New System.Drawing.Point(195, 83)
        Me.cmboMinZeros.Name = "cmboMinZeros"
        Me.cmboMinZeros.Size = New System.Drawing.Size(120, 21)
        Me.cmboMinZeros.TabIndex = 23
        '
        'lblMinZeros
        '
        Me.lblMinZeros.AutoSize = True
        Me.lblMinZeros.Location = New System.Drawing.Point(6, 86)
        Me.lblMinZeros.Name = "lblMinZeros"
        Me.lblMinZeros.Size = New System.Drawing.Size(183, 13)
        Me.lblMinZeros.TabIndex = 22
        Me.lblMinZeros.Text = "Minimum zeros to add before number:"
        '
        'lblPadAfter
        '
        Me.lblPadAfter.AutoSize = True
        Me.lblPadAfter.Location = New System.Drawing.Point(6, 37)
        Me.lblPadAfter.Name = "lblPadAfter"
        Me.lblPadAfter.Size = New System.Drawing.Size(136, 13)
        Me.lblPadAfter.TabIndex = 21
        Me.lblPadAfter.Text = "String to find numbers after:"
        '
        'txtPadAfter
        '
        Me.txtPadAfter.Location = New System.Drawing.Point(148, 37)
        Me.txtPadAfter.Name = "txtPadAfter"
        Me.txtPadAfter.Size = New System.Drawing.Size(167, 20)
        Me.txtPadAfter.TabIndex = 20
        Me.txtPadAfter.Text = "Chapter "
        '
        'btnPadNumbers
        '
        Me.btnPadNumbers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPadNumbers.Location = New System.Drawing.Point(233, 363)
        Me.btnPadNumbers.Name = "btnPadNumbers"
        Me.btnPadNumbers.Size = New System.Drawing.Size(82, 32)
        Me.btnPadNumbers.TabIndex = 19
        Me.btnPadNumbers.Text = "Pad Numbers"
        Me.btnPadNumbers.UseVisualStyleBackColor = True
        '
        'tpReplaceInsertStrings
        '
        Me.tpReplaceInsertStrings.Controls.Add(Me.tlpStringOptions)
        Me.tpReplaceInsertStrings.Controls.Add(Me.rbReplaceString)
        Me.tpReplaceInsertStrings.Controls.Add(Me.rbAddVolNumbers)
        Me.tpReplaceInsertStrings.Location = New System.Drawing.Point(4, 22)
        Me.tpReplaceInsertStrings.Name = "tpReplaceInsertStrings"
        Me.tpReplaceInsertStrings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReplaceInsertStrings.Size = New System.Drawing.Size(332, 424)
        Me.tpReplaceInsertStrings.TabIndex = 0
        Me.tpReplaceInsertStrings.Text = "Replace or Insert Strings"
        Me.tpReplaceInsertStrings.UseVisualStyleBackColor = True
        '
        'tpManageFolders
        '
        Me.tpManageFolders.Controls.Add(Me.txtFileType)
        Me.tpManageFolders.Controls.Add(Me.Label1)
        Me.tpManageFolders.Controls.Add(Me.btnDeleteFiletype)
        Me.tpManageFolders.Controls.Add(Me.btnRemoveEmptyFolders)
        Me.tpManageFolders.Location = New System.Drawing.Point(4, 22)
        Me.tpManageFolders.Name = "tpManageFolders"
        Me.tpManageFolders.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManageFolders.Size = New System.Drawing.Size(332, 424)
        Me.tpManageFolders.TabIndex = 2
        Me.tpManageFolders.Text = "Manage Folders"
        Me.tpManageFolders.UseVisualStyleBackColor = True
        '
        'tpCombineImages
        '
        Me.tpCombineImages.Controls.Add(Me.btnCombineImages)
        Me.tpCombineImages.Controls.Add(Me.txtImageName)
        Me.tpCombineImages.Controls.Add(Me.Label7)
        Me.tpCombineImages.Controls.Add(Me.txtImageSize)
        Me.tpCombineImages.Controls.Add(Me.Label6)
        Me.tpCombineImages.Controls.Add(Me.Label5)
        Me.tpCombineImages.Controls.Add(Me.rbRowColumn)
        Me.tpCombineImages.Controls.Add(Me.rbColumnRow)
        Me.tpCombineImages.Location = New System.Drawing.Point(4, 22)
        Me.tpCombineImages.Name = "tpCombineImages"
        Me.tpCombineImages.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCombineImages.Size = New System.Drawing.Size(332, 424)
        Me.tpCombineImages.TabIndex = 3
        Me.tpCombineImages.Text = "Combine Images"
        Me.tpCombineImages.UseVisualStyleBackColor = True
        '
        'btnCombineImages
        '
        Me.btnCombineImages.Location = New System.Drawing.Point(229, 377)
        Me.btnCombineImages.Name = "btnCombineImages"
        Me.btnCombineImages.Size = New System.Drawing.Size(97, 41)
        Me.btnCombineImages.TabIndex = 7
        Me.btnCombineImages.Text = "Combine Selected Images"
        Me.btnCombineImages.UseVisualStyleBackColor = True
        '
        'txtImageName
        '
        Me.txtImageName.Location = New System.Drawing.Point(111, 130)
        Me.txtImageName.Name = "txtImageName"
        Me.txtImageName.Size = New System.Drawing.Size(100, 20)
        Me.txtImageName.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Final image name:"
        '
        'txtImageSize
        '
        Me.txtImageSize.Location = New System.Drawing.Point(111, 95)
        Me.txtImageSize.Name = "txtImageSize"
        Me.txtImageSize.Size = New System.Drawing.Size(100, 20)
        Me.txtImageSize.TabIndex = 4
        Me.txtImageSize.Text = "256"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Square image size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Select the naming scheme of the files"
        '
        'rbRowColumn
        '
        Me.rbRowColumn.AutoSize = True
        Me.rbRowColumn.Location = New System.Drawing.Point(9, 57)
        Me.rbRowColumn.Name = "rbRowColumn"
        Me.rbRowColumn.Size = New System.Drawing.Size(85, 17)
        Me.rbRowColumn.TabIndex = 1
        Me.rbRowColumn.Text = "Row-Column"
        Me.rbRowColumn.UseVisualStyleBackColor = True
        '
        'rbColumnRow
        '
        Me.rbColumnRow.AutoSize = True
        Me.rbColumnRow.Checked = True
        Me.rbColumnRow.Location = New System.Drawing.Point(9, 34)
        Me.rbColumnRow.Name = "rbColumnRow"
        Me.rbColumnRow.Size = New System.Drawing.Size(85, 17)
        Me.rbColumnRow.TabIndex = 0
        Me.rbColumnRow.TabStop = True
        Me.rbColumnRow.Text = "Column-Row"
        Me.rbColumnRow.UseVisualStyleBackColor = True
        '
        'btnRemoveEmptyFolders
        '
        Me.btnRemoveEmptyFolders.Location = New System.Drawing.Point(6, 22)
        Me.btnRemoveEmptyFolders.Name = "btnRemoveEmptyFolders"
        Me.btnRemoveEmptyFolders.Size = New System.Drawing.Size(132, 23)
        Me.btnRemoveEmptyFolders.TabIndex = 0
        Me.btnRemoveEmptyFolders.Text = "Remove Empty Folders"
        Me.btnRemoveEmptyFolders.UseVisualStyleBackColor = True
        '
        'btnDeleteFiletype
        '
        Me.btnDeleteFiletype.Location = New System.Drawing.Point(238, 62)
        Me.btnDeleteFiletype.Name = "btnDeleteFiletype"
        Me.btnDeleteFiletype.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteFiletype.TabIndex = 1
        Me.btnDeleteFiletype.Text = "Delete"
        Me.btnDeleteFiletype.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Delete files with filetype:"
        '
        'txtFileType
        '
        Me.txtFileType.Location = New System.Drawing.Point(132, 64)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(100, 20)
        Me.txtFileType.TabIndex = 3
        Me.txtFileType.Text = "mp4"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbFilesFound)
        Me.Controls.Add(Me.lblFolderLocation)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Controls.Add(Me.txtBaseFolder)
        Me.Name = "MainForm"
        Me.Text = "Windows File Manipulator"
        Me.pnlAddString.ResumeLayout(False)
        Me.pnlAddString.PerformLayout()
        Me.pnlReplaceString.ResumeLayout(False)
        Me.pnlReplaceString.PerformLayout()
        Me.tlpStringOptions.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpPadNumbers.ResumeLayout(False)
        Me.tpPadNumbers.PerformLayout()
        Me.tpReplaceInsertStrings.ResumeLayout(False)
        Me.tpReplaceInsertStrings.PerformLayout()
        Me.tpManageFolders.ResumeLayout(False)
        Me.tpManageFolders.PerformLayout()
        Me.tpCombineImages.ResumeLayout(False)
        Me.tpCombineImages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBaseFolder As TextBox
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents lbFilesFound As ListBox
    Friend WithEvents lblFolderLocation As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMangaName As Label
    Friend WithEvents txtInsertAfter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInsertString As TextBox
    Friend WithEvents btnAddVolumeNum As Button
    Friend WithEvents rbReplaceString As RadioButton
    Friend WithEvents rbAddVolNumbers As RadioButton
    Friend WithEvents pnlAddString As Panel
    Friend WithEvents pnlReplaceString As Panel
    Friend WithEvents btnReplaceString As Button
    Friend WithEvents lblStringToFind As Label
    Friend WithEvents txtStringToReplace As TextBox
    Friend WithEvents txtReplaceWith As TextBox
    Friend WithEvents lblReplaceWith As Label
    Friend WithEvents tlpStringOptions As TableLayoutPanel
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents rbRegularExp As RadioButton
    Friend WithEvents chkSelectAll As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpReplaceInsertStrings As TabPage
    Friend WithEvents tpPadNumbers As TabPage
    Friend WithEvents btnPadNumbers As Button
    Friend WithEvents cmboMinZeros As ComboBox
    Friend WithEvents lblMinZeros As Label
    Friend WithEvents lblPadAfter As Label
    Friend WithEvents txtPadAfter As TextBox
    Friend WithEvents tpManageFolders As TabPage
    Friend WithEvents tpCombineImages As TabPage
    Friend WithEvents btnCombineImages As Button
    Friend WithEvents txtImageName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtImageSize As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbRowColumn As RadioButton
    Friend WithEvents rbColumnRow As RadioButton
    Friend WithEvents btnRemoveEmptyFolders As Button
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteFiletype As Button
End Class
