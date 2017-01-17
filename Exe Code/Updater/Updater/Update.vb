Imports System.Net
Imports System.IO
Public Class Update



















































    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim auslesen() As String = IO.File.ReadAllLines("C:/Noten-Rechner Programm/pfad.txt")
        Dim MeineVersion As Integer = auslesen(1)
        Dim auslesen2() As String = IO.File.ReadAllLines("C:/Noten-Rechner Programm/currentversion.txt")
        Dim CurrentVersion As Integer = auslesen2(0)

        Me.ShowInTaskbar = False
        Me.Opacity = 0





        If MeineVersion = CurrentVersion Then
            Application.Exit()
            Exit Sub
        End If
        Me.ShowInTaskbar = True
        Me.Opacity = 1000



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim auslesen() As String = IO.File.ReadAllLines("C:/Noten-Rechner Programm/pfad.txt")
        Dim Pfad As String = auslesen(0)

        If My.Computer.FileSystem.FileExists(Pfad) Then
            My.Computer.FileSystem.DeleteFile(Pfad)
        End If


        Try
            Dim wx As New WebClient
            Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/Noten-Rechner-Programm.exe"
            Dim Ziel As String = Pfad
            System.Threading.Thread.Sleep(100)
            wx.DownloadFileAsync(New Uri(PfadURL), Ziel)
        Catch Ex As Exception
            MsgBox("Fehler beim schreiben! Fehler: " & Ex.Message & "")

        End Try





        MsgBox("Update erfolgreich")
        Application.Exit()


    End Sub

End Class
