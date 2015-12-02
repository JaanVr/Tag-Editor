Imports PrjAudioFail
Imports PrjPlaylist
Imports PrjVlcWrapper

Public Class formPlayer
    Private audioFailid As New Microsoft.VisualBasic.Collection()
    Private dirtySongKeys As New Microsoft.VisualBasic.Collection()
    Private folderPath As String
    Private playlist As IPlaylist = New CPlaylist
    'Private player As New UCtrlVLCWrapper

    Private Sub formPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        songsDataGridView.ColumnCount = 5

        songsDataGridView.Columns(0).Name = "Index"
        songsDataGridView.Columns(0).Visible = False
        songsDataGridView.Columns(1).Name = "Song"
        songsDataGridView.Columns(2).Name = "Artist"
        songsDataGridView.Columns(3).Name = "Album"
        songsDataGridView.Columns(4).Name = "Year"

        btnSave.Enabled = False
        btnPlaylist.Enabled = False
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim row As String()
        Dim index As Integer = 0

        songsDataGridView.Rows.Clear()
        audioFailid.Clear()
        FolderBrowserDialog.ShowDialog()
        folderPath = FolderBrowserDialog.SelectedPath

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(folderPath)
            If foundFile.Contains(".flac") Or foundFile.Contains(".mp3") Then

                Dim audioFail As IAudioFail
                audioFail = New CAudioFail

                audioFail.avaFail(foundFile)
                audioFailid.Add(audioFail, index.ToString)

                row = {index, audioFail.laul, audioFail.artist, audioFail.album, audioFail.aasta}
                index = index + 1
                songsDataGridView.Rows.Add(row)
            End If
        Next

        btnSave.Enabled = True
        btnPlaylist.Enabled = True
    End Sub

    Private Sub songsDataGridView_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles songsDataGridView.CurrentCellDirtyStateChanged

        Dim contains As Boolean = dirtySongKeys.Contains(songsDataGridView.CurrentRow.Cells.Item(0).Value)

        If Not (contains) Then
            dirtySongKeys.Add(songsDataGridView.CurrentRow.Cells.Item(0).Value, songsDataGridView.CurrentRow.Cells.Item(0).Value)
        End If

        btnSave.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim audioFail As IAudioFail
        Dim currentCells As DataGridViewCellCollection
        Dim indexCell As DataGridViewCell

        audioFail = New CAudioFail

        For Each dirtySongKey As String In dirtySongKeys
            audioFail = audioFailid.Item(dirtySongKey)

            For Each Row As DataGridViewRow In songsDataGridView.Rows
                currentCells = Row.Cells
                indexCell = currentCells.Item(0)

                If StrComp(indexCell.Value, dirtySongKey) = 0 Then
                    audioFail.laul = currentCells.Item(1).Value
                    audioFail.artist = currentCells.Item(2).Value
                    audioFail.album = currentCells.Item(3).Value
                    audioFail.aasta = currentCells.Item(4).Value
                    audioFail.salvestaFail()
                    Exit For
                End If

            Next
        Next

        dirtySongKeys.Clear()
        btnSave.Enabled = False

    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        Dim selectedRows As DataGridViewSelectedRowCollection
        Dim indexCell As DataGridViewCell
        Dim audioFail As IAudioFail

        audioFail = New CAudioFail

        playlist.create("debug", folderPath)
        selectedRows = songsDataGridView.SelectedRows

        For Each row As DataGridViewRow In selectedRows
            indexCell = row.Cells.Item(0)
            audioFail = audioFailid(indexCell.Value)
            playlist.add(folderPath, audioFail.laul, audioFail.length)
        Next

        playlist.save(folderPath, "debug")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Dim form As New Form
        'player.play(folderPath, "Little V - Side Quest - 01 Reach For The Heavens.flac")
        'Form.Controls.Add(player)
        'Form.Show()
    End Sub
End Class
