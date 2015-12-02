Public Class UCtrlVLCWrapper
    Implements IVLCWrapper
    Private vlcPlayer As New AxAXVLC.AxVLCPlugin()

    Private Sub play(folderpath As String, filename As String) Implements IVLCWrapper.play
        vlcPlayer.addTarget("file:///" + folderpath + "\" + filename, Nothing, AXVLC.VLCPlaylistMode.VLCPlayListReplaceAndGo, 0)
        vlcPlayer.play()
    End Sub
End Class
