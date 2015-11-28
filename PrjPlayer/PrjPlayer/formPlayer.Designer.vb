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
        CType(Me.songsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Location = New System.Drawing.Point(12, 345)
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
        Me.songsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.songsDataGridView.Size = New System.Drawing.Size(577, 323)
        Me.songsDataGridView.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(93, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'formPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 383)
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
End Class
