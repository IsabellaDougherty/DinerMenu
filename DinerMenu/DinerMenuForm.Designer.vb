﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DailySpecialLabel = New System.Windows.Forms.Label()
        Me.BlobFishPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BlobFishPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.BackColor = System.Drawing.Color.Red
        Me.DinerNameLabel.Font = New System.Drawing.Font("Constantia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DinerNameLabel.Location = New System.Drawing.Point(106, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(599, 78)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "The Spicy Meatball"
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SoupButton.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SoupButton.Location = New System.Drawing.Point(12, 368)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(249, 67)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "Soup"
        Me.ToolTip.SetToolTip(Me.SoupButton, "Click this to see the soup special")
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaladButton.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaladButton.Location = New System.Drawing.Point(267, 368)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(265, 67)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "Salad"
        Me.ToolTip.SetToolTip(Me.SaladButton, "Click this to see the salad special")
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FishButton.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FishButton.Location = New System.Drawing.Point(538, 368)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(250, 67)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Fish"
        Me.ToolTip.SetToolTip(Me.FishButton, "Click this to see the firsh special")
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(741, 9)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(47, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Pressing this will close the program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DailySpecialLabel
        '
        Me.DailySpecialLabel.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.DailySpecialLabel.Location = New System.Drawing.Point(12, 87)
        Me.DailySpecialLabel.Name = "DailySpecialLabel"
        Me.DailySpecialLabel.Size = New System.Drawing.Size(776, 278)
        Me.DailySpecialLabel.TabIndex = 6
        Me.DailySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlobFishPictureBox
        '
        Me.BlobFishPictureBox.Image = Global.DinerMenu.My.Resources.Resources.Blobfish_feels_pretty
        Me.BlobFishPictureBox.Location = New System.Drawing.Point(222, 90)
        Me.BlobFishPictureBox.Name = "BlobFishPictureBox"
        Me.BlobFishPictureBox.Size = New System.Drawing.Size(373, 275)
        Me.BlobFishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BlobFishPictureBox.TabIndex = 7
        Me.BlobFishPictureBox.TabStop = False
        Me.BlobFishPictureBox.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BlobFishPictureBox)
        Me.Controls.Add(Me.DailySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BlobFishPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DailySpecialLabel As Label
    Friend WithEvents BlobFishPictureBox As PictureBox
    Friend WithEvents ToolTip As ToolTip
End Class
