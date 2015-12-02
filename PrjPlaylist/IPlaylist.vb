Public Interface IPlaylist
    Property PlayList() As M3U.NET.IM3UFile
    Sub load(ByVal path As String)
    Sub save(location As String, name As String)
    Sub add(location As String, title As String, runtime As Integer)
    Sub create(filename As String, folderpath As String)
End Interface
