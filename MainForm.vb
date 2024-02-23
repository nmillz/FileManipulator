Imports System.IO
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Linq
Imports SautinSoft.Document


Public Class MainForm
    Dim sBaseFolder As String
    Dim lsFileLocations, lsFileNames As List(Of String)
    Dim fRegularExpressionReplace As Boolean = True
    Dim selectedTab As System.Windows.Forms.TabPage
    Dim indexOfSelectedTab As Integer
    Dim sFileOrDirectory As String = "File"

    Sub RefreshListBoxFiles(sFolderLocation As String)
        If Directory.Exists(sFolderLocation) Then
            lbFilesFound.Items.Clear()

            lsFileNames = New List(Of String)
            lsFileLocations = New List(Of String)

            sBaseFolder = sFolderLocation
            txtBaseFolder.Text = sBaseFolder
            If sFileOrDirectory = "File" Then
                lsFileLocations.AddRange(IO.Directory.GetFiles(sBaseFolder, "*.*", SearchOption.AllDirectories))
            ElseIf sFileOrDirectory = "Directory" Then
                lsFileLocations.AddRange(IO.Directory.GetDirectories(sBaseFolder, "*.*", SearchOption.AllDirectories))
            End If

            For Each sFile As String In lsFileLocations
                lsFileNames.Add(sFile.Substring(sFile.LastIndexOf("\") + 1))
            Next

            lbFilesFound.Items.AddRange(lsFileNames.ToArray)
        End If

        If chkSelectAll.Checked Then
            For index As Integer = 0 To Me.lbFilesFound.Items.Count - 1 Step 1
                Me.lbFilesFound.SetSelected(index, True)
            Next index
        End If
    End Sub

    Sub ReplaceString()
        Dim lsFilesToChange As New ArrayList
        Dim sOldString, sNewString, sNewFileName As String
        Dim rCode As Regex

        sOldString = txtStringToReplace.Text
        sNewString = txtReplaceWith.Text
        lsFilesToChange.AddRange(lbFilesFound.SelectedItems)

        If rbRegularExp.Checked Then
            rCode = New Regex(sOldString)
        End If


        For Each sFile As String In lsFilesToChange
            Try
                If (rbNormal.Checked AndAlso sFile.Contains(sOldString)) OrElse (rbRegularExp.Checked AndAlso Regex.Match(sFile, sOldString).Success) Then
                    Dim iFileLocation As Integer = lsFileLocations.FindIndex(Function(x As String) x.Contains(sFile))
                    Dim sFileLocation As String = lsFileLocations(iFileLocation)

                    If rbNormal.Checked Then
                        My.Computer.FileSystem.RenameFile(sFileLocation, sFile.Replace(sOldString, sNewString))
                    ElseIf rbRegularExp.Checked Then
                        sNewFileName = Regex.Replace(sFile, sOldString, sNewString)
                        My.Computer.FileSystem.RenameFile(sFileLocation, sNewFileName)
                    End If
                End If
            Catch
                Console.WriteLine(sFile)
            End Try
        Next

        RefreshListBoxFiles(txtBaseFolder.Text)
    End Sub

    Sub InsertString()
        Dim lsFilesToChange As New ArrayList
        Dim sMangaName, sVolNumber As String

        sMangaName = txtInsertAfter.Text
        sVolNumber = txtInsertString.Text

        lsFilesToChange.AddRange(lbFilesFound.SelectedItems)

        For Each sFile As String In lsFilesToChange
            Dim iFileLocation As Integer = lsFileLocations.FindIndex(Function(x As String) x.Equals(txtBaseFolder.Text + sFile))
            Dim sFileLocation As String = lsFileLocations(iFileLocation)

            sFile = sFile.Insert(sFile.IndexOf(sMangaName) + sMangaName.Length, sVolNumber)

            My.Computer.FileSystem.RenameFile(sFileLocation, sFile)
        Next

        RefreshListBoxFiles(txtBaseFolder.Text)
    End Sub

    Private Sub rbReplaceString_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplaceString.CheckedChanged
        pnlReplaceString.Visible = rbReplaceString.Checked
        pnlAddString.Visible = Not rbReplaceString.Checked
    End Sub

    Private Sub rbAddNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddVolNumbers.CheckedChanged
        pnlReplaceString.Visible = Not rbAddVolNumbers.Checked
        pnlAddString.Visible = rbAddVolNumbers.Checked
    End Sub

    Private Sub rbNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbNormal.CheckedChanged, rbRegularExp.CheckedChanged
        fRegularExpressionReplace = rbRegularExp.Checked
        If fRegularExpressionReplace Then
            txtStringToReplace.Text = "Season [0-9]+ Chapter [0-9]+"
        End If
    End Sub

    Private Sub btnReplaceString_Click(sender As Object, e As EventArgs) Handles btnReplaceString.Click
        Try
            ReplaceString()
        Catch ex As Exception
            RefreshListBoxFiles(txtBaseFolder.Text)
        End Try
    End Sub

    Private Sub btnAddVolumeNum_Click(sender As Object, e As EventArgs) Handles btnAddVolumeNum.Click
        Try
            InsertString()
        Catch ex As Exception
            RefreshListBoxFiles(txtBaseFolder.Text)
        End Try
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs)
        For index As Integer = 0 To Me.lbFilesFound.Items.Count - 1 Step 1
            Me.lbFilesFound.SetSelected(index, True)
        Next index
    End Sub

    Private Sub txtBaseFolder_TextChanged(sender As Object, e As EventArgs) Handles txtBaseFolder.LostFocus
        If Not String.IsNullOrWhiteSpace(txtBaseFolder.Text) Then
            RefreshListBoxFiles(txtBaseFolder.Text)
            If Not txtBaseFolder.Text(txtBaseFolder.Text.Length - 1) = "\" Then
                txtBaseFolder.Text += "\"
            End If
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked Then
            For index As Integer = 0 To Me.lbFilesFound.Items.Count - 1 Step 1
                Me.lbFilesFound.SetSelected(index, True)
            Next index
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        indexOfSelectedTab = TabControl1.SelectedIndex
        selectedTab = TabControl1.SelectedTab
        If selectedTab.Name = "tpReplaceInsertStrings" Then
            sFileOrDirectory = "File"
        ElseIf selectedTab.Name = "tpStitchPics" Then
            sFileOrDirectory = "Directory"
        End If
        If txtBaseFolder.TextLength > 0 Then
            RefreshListBoxFiles(txtBaseFolder.Text.ToString)
        End If

    End Sub

    Private Sub btnPadNumbers_Click(sender As Object, e As EventArgs) Handles btnPadNumbers.Click
        Dim sSearchAfter() As String = {txtPadAfter.Text}
        Dim iMinZeros As Integer = cmboMinZeros.SelectedIndex
        Dim iMaxNumber As Integer = 0

        For Each sFileName As String In lbFilesFound.Items
            If sFileName.Contains(sSearchAfter(0)) Then
                Dim sb As New System.Text.StringBuilder(sFileName.Length)
                For Each ch As Char In sFileName.Split(sSearchAfter, StringSplitOptions.None)(1)
                    If Char.IsDigit(ch) Then
                        sb.Append(ch)
                    Else
                        Exit For
                    End If
                Next
                If iMaxNumber < sb.Length Then iMaxNumber = sb.Length
            End If
        Next

        Dim sbFormat As New System.Text.StringBuilder(iMaxNumber + iMinZeros)
        For iCount As Integer = 1 To iMaxNumber + iMinZeros
            sbFormat.Append("0")
        Next

        For Each sFileName As String In lbFilesFound.Items
            If sFileName.Contains(sSearchAfter(0)) Then
                Dim iFileLocation As Integer = lsFileLocations.FindIndex(Function(x As String) x.Contains(sFileName))
                Dim sFileLocation As String = lsFileLocations(iFileLocation)
                Dim sbOriginalInt As New System.Text.StringBuilder(sFileName.Length)
                Dim iNewInt As Integer

                For Each ch As Char In sFileName.Split(sSearchAfter, StringSplitOptions.None)(1)
                    If Char.IsDigit(ch) Then
                        sbOriginalInt.Append(ch)
                    Else
                        Exit For
                    End If
                Next

                iNewInt = Integer.Parse(sbOriginalInt.ToString)
                Dim sbNewName As New System.Text.StringBuilder
                Dim nxt As String = iNewInt.ToString(sbFormat.ToString)
                sbNewName.Append(sFileName)
                Dim s As Integer = sFileName.IndexOf(sSearchAfter(0))
                sbNewName = sbNewName.Replace(sbOriginalInt.ToString, nxt, sFileName.IndexOf(sSearchAfter(0)), sSearchAfter(0).Length + nxt.Length)

                If Not sFileName.Equals(sbNewName.ToString) Then My.Computer.FileSystem.RenameFile(sFileLocation, sbNewName.ToString)
            End If
        Next

        RefreshListBoxFiles(txtBaseFolder.Text)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmboMinZeros.SelectedIndex = 0
    End Sub

    Private Sub btnCombineImages_Click(sender As Object, e As EventArgs) Handles btnCombineImages.Click
        Dim lsFilesToChange As New ArrayList
        Dim iRowCoord, iColCoord, iMaxHeight, iMaxWidth As Integer
        Dim sCoords As String
        Dim iImageSize As Integer = Val(txtImageSize.Text)
        Dim sNewFileName As String = txtImageName.Text + ".png"
        Dim sSeparator As String = "-"

        lsFilesToChange.AddRange(lbFilesFound.SelectedItems)
        iMaxHeight = 0
        iMaxWidth = 0

        'Find the largest coordinates and create the image
        For Each sFile As String In lsFilesToChange
            If sFile.Contains(sSeparator) Then
                sCoords = sFile.ToLower.Replace(".png", "")

                If rbColumnRow.Checked Then
                    If iMaxWidth < (Val(sCoords.Split(sSeparator)(0)) + 1) * iImageSize Then
                        iMaxWidth = (Val(sCoords.Split(sSeparator)(0)) + 1) * iImageSize
                    End If

                    If iMaxHeight < (Val(sCoords.Split(sSeparator)(1)) + 1) * iImageSize Then
                        iMaxHeight = (Val(sCoords.Split(sSeparator)(1)) + 1) * iImageSize
                    End If
                ElseIf rbRowColumn.Checked Then
                    If iMaxHeight < (Val(sCoords.Split(sSeparator)(1)) + 1) * iImageSize Then
                        iMaxHeight = (Val(sCoords.Split(sSeparator)(1)) + 1) * iImageSize
                    End If

                    If iMaxWidth < (Val(sCoords.Split(sSeparator)(0)) + 1) * iImageSize Then
                        iMaxWidth = (Val(sCoords.Split(sSeparator)(0)) + 1) * iImageSize
                    End If
                End If

            End If
        Next

        Dim bmp As New Bitmap(iMaxWidth, iMaxHeight)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Color.Transparent)

        For Each sFile As String In lsFilesToChange
            Dim iFileLocation As Integer = lsFileLocations.FindIndex(Function(x As String) x.Equals(txtBaseFolder.Text + sFile))
            Dim sFileLocation As String = lsFileLocations(iFileLocation)
            If sFile.Contains(sSeparator) Then
                sCoords = sFile.ToLower.Replace(".png", "")

                If rbColumnRow.Checked Then
                    iColCoord = Val(sCoords.Split(sSeparator)(0)) * iImageSize
                    iRowCoord = Val(sCoords.Split(sSeparator)(1)) * iImageSize
                ElseIf rbRowColumn.Checked Then
                    iRowCoord = Val(sCoords.Split(sSeparator)(0)) * iImageSize
                    iColCoord = Val(sCoords.Split(sSeparator)(1)) * iImageSize
                End If

                g.DrawImage(Image.FromFile(sFileLocation), iColCoord, iRowCoord)
            End If
        Next
        bmp.Save(txtBaseFolder.Text + sNewFileName, System.Drawing.Imaging.ImageFormat.Png)

        'RefreshListBoxFiles(txtBaseFolder.Text)
    End Sub

    Private Sub btnRemoveEmptyFolders_Click(sender As Object, e As EventArgs) Handles btnRemoveEmptyFolders.Click
        RecurseFolders(txtBaseFolder.Text)
    End Sub

    Private Sub RecurseFolders(oFolder As String)
        For Each oSub As String In Directory.GetDirectories(oFolder)
            If Directory.GetDirectories(oSub).Count = 0 Then
                If Directory.GetFiles(oSub).Count = 0 Then
                    Directory.Delete(oSub)
                End If
            Else
                RecurseFolders(oSub)
            End If
        Next
    End Sub

    Private Sub btnDeleteFiletype_Click(sender As Object, e As EventArgs) Handles btnDeleteFiletype.Click
        If MessageBox.Show("Are you sure you want to delete every " + txtFileType.Text + " file found in the folder: " + txtBaseFolder.Text + "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each sFile As String In Directory.GetFiles(txtBaseFolder.Text)
                If sFile.Split(".").Last = txtFileType.Text Then
                    File.Delete(sFile)
                End If
            Next
        End If
        RefreshListBoxFiles(txtBaseFolder.Text)
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim flg As New FolderBrowserDialog
        flg.SelectedPath = txtBaseFolder.Text.ToString()
        TabControl1_SelectedIndexChanged(sender, e)

        If (flg.ShowDialog() = DialogResult.OK) Then
            RefreshListBoxFiles(flg.SelectedPath)
            If selectedTab.Name IsNot Nothing Then
                If selectedTab.Name = "tpReplaceInsertStrings" Then
                    sFileOrDirectory = "File"
                ElseIf selectedTab.Name = "tpStitchPics" Then
                    sFileOrDirectory = "Directory"
                    RefreshListBoxFiles(flg.SelectedPath)
                End If
            End If
            If Not txtBaseFolder.Text(txtBaseFolder.Text.Length - 1) = "\" Then
                txtBaseFolder.Text += "\"
            End If
        End If
    End Sub

End Class
