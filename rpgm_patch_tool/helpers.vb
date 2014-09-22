Imports System.IO
Imports System.Text

Module helpers
    Dim progress As Integer
    Public Function OpenFileDlg(ByRef location As String) As Boolean
        Dim openDir As New FolderBrowserDialog

        openDir.RootFolder = Environment.SpecialFolder.Desktop
        openDir.SelectedPath = Application.StartupPath

        If (location.Length > 0) Then
            openDir.SelectedPath = location
        End If
        openDir.Description = "Choose the directory of the game"

        If openDir.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return False
        End If
        location = openDir.SelectedPath
        Return True
    End Function

    Public Function DeleteFileIfExist(ByVal sPath As String) As Integer
        Try
            If File.Exists(sPath) Then
                File.Delete(sPath)
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return -1
    End Function


    Public Function MakePatch(origDir As String, patchDir As String)
        patchTool.ToolStripStatusLabel.Text = "Calculating number of files"
        Dim numVals = DirSearch(patchDir, patchDir, origDir, 0)
        progress = 0
        DirSearch(patchDir, patchDir, origDir, numVals)
        patchTool.ProgressBarStep.Value = 100
        patchTool.ToolStripStatusLabel.Text = "Patch created: "
    End Function

    Private Function ReservedFileName(f As String)
        Dim reserved As String() = {"\Game.rgss3a.extracted", "\Game", "\Game.rgss3a"}
        For Each str As String In reserved
            If f.Equals(str) Or f.StartsWith("\Save\") Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ApplyPatch(ByRef fileLoc As String)
        Dim br As New BinaryReader(File.OpenRead(fileLoc))

        Do
            Dim length As Integer = BitConverter.ToInt32(br.ReadBytes(4), 0)
            MsgBox(length)

            Dim nameSize As Integer = BitConverter.ToInt32(br.ReadBytes(4), 0)
            MsgBox(nameSize)

            Dim name As String = System.Text.Encoding.UTF8.GetString(br.ReadBytes(nameSize))
            patchTool.ToolStripStatusLabel.Text = "Extracting " + name
            MsgBox(name)
            Dim wr As New BinaryWriter(File.OpenWrite("G:\extract\patch\" + name))
            wr.Write(br.ReadBytes(length))
            wr.Close()
        Loop
        br.Close()

    End Function

    Function DirSearch(ByVal sDir As String, ByVal patchDir As String, ByVal origDir As String, ByVal fileCount As Integer)
        Dim d As String
        Dim f As String
        Dim ret As Integer
        Try
            For Each f In Directory.GetFiles(sDir, "*")
                Dim lenDiff = f.Length - patchDir.Length
                Dim fileName As String = f.Substring(patchDir.Length, lenDiff)
                If (ReservedFileName(fileName)) Then
                    Continue For
                End If
                If fileCount = 0 Then
                    ret += 1
                Else
                    patchTool.ToolStripStatusLabel.Text = "Comparing: " + fileName
                    Application.DoEvents()
                    Dim bytes As Byte()

                    If (False = CompareFiles(f, origDir + fileName)) Then
                        patchTool.ToolStripStatusLabel.Text = "Archiving: " + fileName
                        bytes = System.Text.Encoding.UTF8.GetBytes(fileName)
                        Dim allBytes = File.ReadAllBytes(f)
                        Dim statArray As Byte() = New Byte(8 + bytes.Length) {}
                        Dim lenArray As Byte() = BitConverter.GetBytes(allBytes.Length)
                        Dim fnameArray As Byte() = BitConverter.GetBytes(bytes.Length)
                        Array.Copy(lenArray, 0, statArray, 0, 4)
                        Array.Copy(fnameArray, 0, statArray, 4, 4)
                        Array.Copy(bytes, 0, statArray, 8, bytes.Length)
                        My.Computer.FileSystem.WriteAllBytes("G:\extract\test", statArray, True)
                        My.Computer.FileSystem.WriteAllBytes("G:\extract\test", allBytes, True)
                    End If

                    ' Update progress bar
                    progress += 1
                    patchTool.ProgressBarStep.Value = 100 * progress / fileCount
                End If
            Next

            For Each d In Directory.GetDirectories(sDir)
                ret += DirSearch(d, patchDir, origDir, fileCount)
            Next
        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
        Return ret
    End Function

    Public Function CompareFiles(origPath As String, patchPath As String)
        Dim ret = True
        Try
            Dim patchFile As New System.IO.StreamReader(patchPath)
            Dim origFile As New System.IO.StreamReader(origPath)
            Do Until patchFile.EndOfStream Or origFile.EndOfStream Or ret = False
                Dim patchChar = patchFile.Read
                Dim origChar = origFile.Read
                If origChar <> patchChar Then
                    ret = False
                End If
            Loop
            patchFile.Close()
            origFile.Close()
        Catch ex As Exception
            ret = False
        End Try
        Return ret
    End Function

    Public Function ReadCString(ByVal br As BinaryReader,
                                ByVal MaxLength As Integer,
                                Optional ByVal lOffset As Long = -1,
                                Optional ByVal enc As Encoding = Nothing) As String

        Dim fTemp As Long = br.BaseStream.Position
        Dim bTemp As Byte = 0, i As Integer = 0, result As String = ""

        If lOffset > -1 Then
            br.BaseStream.Seek(lOffset, SeekOrigin.Begin)
        End If

        Do
            bTemp = br.ReadByte()
            If bTemp = 0 Then Exit Do

            i += 1
        Loop While i < MaxLength

        If lOffset > -1 Then
            br.BaseStream.Seek(lOffset, SeekOrigin.Begin)
            If enc Is Nothing Then
                result = Encoding.ASCII.GetString(br.ReadBytes(i))
            Else
                result = enc.GetString(br.ReadBytes(i))
            End If
            br.BaseStream.Seek(fTemp, SeekOrigin.Begin)
        Else
            br.BaseStream.Seek(fTemp, SeekOrigin.Begin)
            If enc Is Nothing Then
                result = Encoding.ASCII.GetString(br.ReadBytes(i))
            Else
                result = enc.GetString(br.ReadBytes(i))
            End If
            br.BaseStream.Seek(fTemp + MaxLength, SeekOrigin.Begin)
        End If

        Return result
    End Function

End Module
