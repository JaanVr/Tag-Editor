<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPlayer
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
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.songsDataGridView = New System.Windows.Forms.DataGridView()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPlaylist = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        CType(Me.songsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Location = New System.Drawing.Point(12, 375)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFolder.TabIndex = 1
        Me.btnOpenFolder.Text = "Open Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'songsDataGridView
        '
        Me.songsDataGridView.AllowUserToAddRows = False
        Me.songsDataGridView.AllowUserToDeleteRows = False
        Me.songsDataGridView.AllowUserToOrderColumns = True
        Me.songsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.songsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.songsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.songsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.songsDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.songsDataGridView.Name = "songsDataGridView"
        Me.songsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.songsDataGridView.Size = New System.Drawing.Size(556, 353)
        Me.songsDataGridView.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(93, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPlaylist.Location = New System.Drawing.Point(175, 375)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Size = New System.Drawing.Size(93, 23)
        Me.btnPlaylist.TabIndex = 4
        Me.btnPlaylist.Text = "Add to playlist"
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.Location = New System.Drawing.Point(274, 375)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "Preview"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'formPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 413)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnPlaylist)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.songsDataGridView)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Name = "formPlayer"
        Me.Text = "Player"
        CType(Me.songsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents songsDataGridView As DataGridView
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPlaylist As Button
    Friend WithEvents btnPlay As Button
End Class
