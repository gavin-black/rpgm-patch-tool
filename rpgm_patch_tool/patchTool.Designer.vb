﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patchTool
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
        Me.TextOrig = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BrowseOrig = New System.Windows.Forms.Button()
        Me.BrowsePatch = New System.Windows.Forms.Button()
        Me.TextPatch = New System.Windows.Forms.TextBox()
        Me.PatchButton = New System.Windows.Forms.Button()
        Me.ExtractButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarStep = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextOrig
        '
        Me.TextOrig.Location = New System.Drawing.Point(94, 17)
        Me.TextOrig.Name = "TextOrig"
        Me.TextOrig.Size = New System.Drawing.Size(255, 26)
        Me.TextOrig.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Original :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Patched :"
        '
        'BrowseOrig
        '
        Me.BrowseOrig.Location = New System.Drawing.Point(363, 15)
        Me.BrowseOrig.Name = "BrowseOrig"
        Me.BrowseOrig.Size = New System.Drawing.Size(88, 25)
        Me.BrowseOrig.TabIndex = 1
        Me.BrowseOrig.Text = "Browse..."
        Me.BrowseOrig.UseVisualStyleBackColor = True
        '
        'BrowsePatch
        '
        Me.BrowsePatch.Location = New System.Drawing.Point(363, 57)
        Me.BrowsePatch.Name = "BrowsePatch"
        Me.BrowsePatch.Size = New System.Drawing.Size(88, 25)
        Me.BrowsePatch.TabIndex = 3
        Me.BrowsePatch.Text = "Browse..."
        Me.BrowsePatch.UseVisualStyleBackColor = True
        '
        'TextPatch
        '
        Me.TextPatch.Location = New System.Drawing.Point(94, 57)
        Me.TextPatch.Name = "TextPatch"
        Me.TextPatch.Size = New System.Drawing.Size(255, 26)
        Me.TextPatch.TabIndex = 2
        '
        'PatchButton
        '
        Me.PatchButton.Enabled = False
        Me.PatchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PatchButton.Location = New System.Drawing.Point(243, 98)
        Me.PatchButton.Name = "PatchButton"
        Me.PatchButton.Size = New System.Drawing.Size(192, 53)
        Me.PatchButton.TabIndex = 5
        Me.PatchButton.Text = "Create Patch"
        Me.PatchButton.UseVisualStyleBackColor = True
        '
        'ExtractButton
        '
        Me.ExtractButton.Enabled = False
        Me.ExtractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExtractButton.Location = New System.Drawing.Point(28, 98)
        Me.ExtractButton.Name = "ExtractButton"
        Me.ExtractButton.Size = New System.Drawing.Size(192, 53)
        Me.ExtractButton.TabIndex = 4
        Me.ExtractButton.Text = "Extract"
        Me.ExtractButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarStep})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 197)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(473, 28)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 12
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ProgressBarStep
        '
        Me.ProgressBarStep.Name = "ProgressBarStep"
        Me.ProgressBarStep.Size = New System.Drawing.Size(469, 22)
        Me.ProgressBarStep.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 167)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(473, 30)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(204, 25)
        Me.ToolStripStatusLabel.Text = "Waiting for user action..."
        '
        'patchTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 225)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ExtractButton)
        Me.Controls.Add(Me.PatchButton)
        Me.Controls.Add(Me.TextPatch)
        Me.Controls.Add(Me.BrowsePatch)
        Me.Controls.Add(Me.BrowseOrig)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextOrig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "patchTool"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "RPG Maker Patch Tool"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextOrig As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BrowseOrig As System.Windows.Forms.Button
    Friend WithEvents BrowsePatch As System.Windows.Forms.Button
    Friend WithEvents TextPatch As System.Windows.Forms.TextBox
    Friend WithEvents PatchButton As System.Windows.Forms.Button
    Friend WithEvents ExtractButton As System.Windows.Forms.Button
    Public WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBarStep As System.Windows.Forms.ToolStripProgressBar
End Class
