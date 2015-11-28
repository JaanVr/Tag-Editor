Imports PrjAudioFail

Public Class CAudioFail
    Implements IAudioFail
    Private artistName As String
    Private aastaNumber As UInteger
    Private albumName As String
    Private laulName As String
    Private tagFile As TagLib.File

    Public Property album As String Implements IAudioFail.album
        Get
            Return albumName
        End Get
        Set(value As String)
            If value <> "" Then
                albumName = value
            End If
        End Set
    End Property

    Public Property artist As String Implements IAudioFail.artist
        Get
            Return artistName
        End Get
        Set(value As String)
            If value <> "" Then
                artistName = value
            End If
        End Set
    End Property

    Public Property laul As String Implements IAudioFail.laul
        Get
            Return laulName
        End Get
        Set(value As String)
            laulName = value
        End Set
    End Property

    Public Property aasta As UShort Implements IAudioFail.aasta
        Get
            Return aastaNumber
        End Get
        Set(value As UShort)
            aastaNumber = value
        End Set
    End Property

    Public Sub avaFail(path As String) Implements IAudioFail.avaFail
        tagFile = TagLib.File.Create(path)
        aasta = tagFile.Tag.Year
        album = tagFile.Tag.Album
        artist = tagFile.Tag.Performers(0)
        laul = tagFile.Tag.Title
    End Sub

    Public Sub salvestaFail() Implements IAudioFail.salvestaFail
        tagFile.Tag.AlbumArtists = New String() {artist}
        tagFile.Tag.Title = laul
        tagFile.Tag.Album = album
        tagFile.Tag.Year = aasta
        tagFile.Save()
    End Sub
End Class
