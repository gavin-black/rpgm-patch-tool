Public Class patchTool

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles BrowseOrig.Click, BrowsePatch.Click
        Dim openPath As String
        Dim clickedButton As Button
        clickedButton = CType(sender, Button)
        If (clickedButton.Name.Equals("BrowseOrig")) Then
            openPath = TextOrig.Text
        Else
            openPath = TextPatch.Text
        End If

        If OpenFileDlg(openPath) Then
            If (clickedButton.Name.Equals("BrowseOrig")) Then
                TextOrig.Text = openPath
            Else
                TextPatch.Text = openPath
            End If
        End If
    End Sub


    Private Sub Text_Change(sender As Object, e As EventArgs) Handles TextOrig.TextChanged, TextPatch.TextChanged
        If (TextOrig.Text.Length > 0) Then
            ExtractButton.Enabled = True
            If (TextPatch.Text.Length > 0) Then
                PatchButton.Enabled = True
            End If
        Else
            ExtractButton.Enabled = False
            PatchButton.Enabled = False
        End If

        If (TextPatch.Text.Length = 0) Then
            PatchButton.Enabled = False
        End If
    End Sub

    Private Sub ExtractButton_Click(sender As Object, e As EventArgs) Handles ExtractButton.Click
        doExtract(TextOrig.Text)
    End Sub

    Private Sub PatchButton_Click(sender As Object, e As EventArgs) Handles PatchButton.Click
        MakePatch(TextOrig.Text, TextPatch.Text)
    End Sub


    Private Sub patchTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patchOffs = PatchStart()
        MsgBox(patchOffs)
        If (patchOffs > 0) Then
            PatchButton.Visible = False
            ExtractButton.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            BrowseOrig.Visible = False
            BrowsePatch.Visible = False
            TextOrig.Visible = False
            TextPatch.Visible = False
            Me.Height = 105
            ToolStripStatusLabel.Text = "Checking directory..."
            ApplyPatch(patchOffs)
        End If
    End Sub
End Class