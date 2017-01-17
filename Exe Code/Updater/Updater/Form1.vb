


Public Class Form1



    Private InstallLink As String = "C:/SidezockingLP_Server-Manager"

    Private WithEvents wx As New Net.WebClient
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ProgressBar1.Value = 50
        If My.Computer.FileSystem.FileExists("" & InstallLink & "/Version.txt") Then
            My.Computer.FileSystem.DeleteFile("" & InstallLink & "/Version.txt")
        End If


        System.Threading.Thread.Sleep(100)
        ProgressBar1.Value = 0













        Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/MinecraftREAL/master/Modern%20Warfare-Content%20Pack-1.7.10-4.10.0.jar"
        Dim Ziel As String = "c://testll/test3.jar"
        System.Threading.Thread.Sleep(100)
        wx.DownloadFileAsync(New Uri(PfadURL), Ziel)





    End Sub

    Private Sub wx_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles wx.DownloadFileCompleted
        ProgressBar1.Value = 0
    End Sub

    Private Sub wx_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles wx.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class