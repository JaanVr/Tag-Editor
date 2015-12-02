Imports M3U.NET

Public Class CPlaylist
    Implements IPlaylist
    Private playlistLocal As M3UFile
    Dim tracks As New List(Of M3UFile)

    Private Property PlayList As IM3UFile Implements IPlaylist.PlayList
        Get
            Return playlistLocal
        End Get
        Set(value As IM3UFile)
            playlistLocal = value
        End Set
    End Property

    Private Sub create(filename As String, folderpath As String) Implements IPlaylist.create
        Dim file As IO.FileInfo = New IO.FileInfo(folderpath + "\" + filename + ".M3U")
        playlistLocal = New M3UFile(file)
    End Sub

    Private Sub add(location As String, title As String, runtime As Integer) Implements IPlaylist.add
        Dim track As MediaItem = New MediaItem
        track.Inf = title
        track.Location = location
        track.Runtime = runtime

        playlistLocal.Files.Add(track)
    End Sub

    Private Sub load(path As String) Implements IPlaylist.load
        Throw New NotImplementedException()
    End Sub

    Private Sub save(location As String, name As String) Implements IPlaylist.save
        playlistLocal.Save()
    End Sub
End Class
