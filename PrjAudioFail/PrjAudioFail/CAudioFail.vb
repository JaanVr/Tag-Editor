Imports PrjAudioFail

Public Class CAudioFail
    Implements IAudioFail
    Private artist As String
    Private aasta As UInteger
    Private album As String
    Private laul As String
    Private tagFile As TagLib.File
    Private length As Integer

    Private Property propAlbum As String Implements IAudioFail.album
        Get
            Return album
        End Get
        Set(value As String)
            If value <> "" Then
                album = value
            End If
        End Set
    End Property

    Private Property propArtist As String Implements IAudioFail.artist
        Get
            Return artist
        End Get
        Set(value As String)
            If value <> "" Then
                artist = value
            End If
        End Set
    End Property

    Private Property propLaul As String Implements IAudioFail.laul
        Get
            Return laul
        End Get
        Set(value As String)
            laul = value
        End Set
    End Property

    Private Property propAasta As UShort Implements IAudioFail.aasta
        Get
            Return aasta
        End Get
        Set(value As UShort)
            aasta = value
        End Set
    End Property

    Private Property propLength As Integer Implements IAudioFail.length
        Get
            Return length
        End Get
        Set(value As Integer)
            length = value
        End Set
    End Property

    Public Sub avaFail(path As String) Implements IAudioFail.avaFail
        tagFile = TagLib.File.Create(path)
        propAasta = tagFile.Tag.Year
        propAlbum = tagFile.Tag.Album
        propArtist = tagFile.Tag.Performers(0)
        propLaul = tagFile.Tag.Title
        propLength = tagFile.Properties.Duration.TotalSeconds
    End Sub

    Public Sub salvestaFail() Implements IAudioFail.salvestaFail
        tagFile.Tag.AlbumArtists = New String() {propArtist}
        tagFile.Tag.Title = propLaul
        tagFile.Tag.Album = propAlbum
        tagFile.Tag.Year = propAasta
        tagFile.Save()
    End Sub
End Class
