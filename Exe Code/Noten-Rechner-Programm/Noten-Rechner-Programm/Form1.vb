Imports System.IO
Imports System.Net.Mail
Imports System.Net
Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm") Then
            MkDir("C:/Noten-Rechner Programm")
        End If



        Dim PadS As IO.StreamWriter = New IO.StreamWriter("C:/Noten-Rechner Programm/pfad.txt")
        PadS.WriteLine(Application.ExecutablePath)
        PadS.WriteLine("1.0.0.3")
        PadS.Close()


        Me.ToolStripComboBox1.Items.Clear()
        Try
            Dim di As New System.IO.DirectoryInfo("c:/Noten-Rechner Programm/Benutzer")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)

                Dim L() As String = IO.File.ReadAllLines(fi.FullName)
                ToolStripComboBox1.Items.Add(L(0))
            Next

        Catch
        End Try



        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                ListBox1.Items.Add(fi.Name)
            Next

        Catch
        End Try

        CheckBox1.Checked = True


        Dim address As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/News.txt"
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString(address)

        ToolStripMenuItem1.Text = reply



        Try
            Dim wx As New Net.WebClient
            Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/Excelstarten.bat"
            Dim Ziel As String = "C:/Noten-Rechner Programm/data.bat"
            System.Threading.Thread.Sleep(100)
            wx.DownloadFileAsync(New Uri(PfadURL), Ziel)

        Catch ex As Exception
            MsgBox("Fehler beim schreiben: Fehler: " & ex.Message & "")
        End Try



        If Not My.Computer.FileSystem.FileExists("" & Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "/Updater.exe") Then
            Try
                Dim wx As New Net.WebClient
                Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/Updater.exe"
                Dim Ziel As String = "" & Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "/Updater.exe"
                System.Threading.Thread.Sleep(100)
                wx.DownloadFileAsync(New Uri(PfadURL), Ziel)

            Catch ex As Exception
                MsgBox("Fehler beim schreiben: Fehler: " & ex.Message & "")
            End Try
        End If



        Try
            Dim wx As New Net.WebClient
            Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/Verion.txt"
            Dim Ziel As String = "C:/Noten-Rechner Programm/currentversion.txt"
            System.Threading.Thread.Sleep(100)
            wx.DownloadFileAsync(New Uri(PfadURL), Ziel)

        Catch ex As Exception
            MsgBox("Fehler beim schreiben currentversion: Fehler: " & ex.Message & "")
        End Try

        Dim auslesen() As String = IO.File.ReadAllLines("C:/Noten-Rechner Programm/pfad.txt")
        Label2.Text = auslesen(1)
    End Sub

    Private Sub HinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HinzufügenToolStripMenuItem.Click

        If My.Settings.Benutzer = Nothing Or My.Settings.Benutzer = "" Then
            MsgBox("Du musst erst einen Benutzer auswählen oder einloggen!")
            Exit Sub
        End If

        Try
            If Not My.Computer.Network.Ping("www.google.de") Then
                MsgBox("Du bracust eine Internetverbindung um einen neuen Notenrechner anlegen zu können!")
            End If
        Catch
        End Try



        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm/Programme") Then
            MkDir("C:/Noten-Rechner Programm/Programme")
        End If





        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                If (fi.Name) = "" & ToolStripTextBox1.Text & ".xlsm" Then
                    MsgBox("Dieser Notenrechner wurde bereits erstellt!")
                    Exit Sub
                End If
            Next

        Catch
        End Try







        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "") Then
            MkDir("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
        End If

        Try
            Dim wx As New Net.WebClient
            Dim PfadURL As String = "https://raw.githubusercontent.com/SidezockingLP/Noten-RechnerProgramm/master/Noten-RechnerProgramm.xlsm"
            Dim Ziel As String = "C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "/" & ToolStripTextBox1.Text & ".xlsm"
            System.Threading.Thread.Sleep(100)
            wx.DownloadFileAsync(New Uri(PfadURL), Ziel)
            MsgBox("Wurde Erfolgreich erstellt")
        Catch ex As Exception
            MsgBox("Fehler beim erstellen: Fehler: " & ex.Message & "")
        End Try

        ListBox1.Items.Clear()

        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                ListBox1.Items.Add(fi.Name)
            Next

        Catch
        End Try








    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub



    Private Sub BenutzerHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BenutzerHinzufügenToolStripMenuItem.Click





        Benutzer.Show()






    End Sub

    Private Sub ServerStartenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerStartenToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub AnmeldenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnmeldenToolStripMenuItem.Click

        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm/Benutzer/" & ToolStripComboBox1.Text & "") Then
            MsgBox("Diesen Benutzer gieb es nicht")
            Exit Sub
        End If
        MsgBox("Du wurdest erfolgreich als " & ToolStripComboBox1.Text & " eingeloggt!")
        My.Settings.Benutzer = ToolStripComboBox1.Text
        ListBox1.Items.Clear()
        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                ListBox1.Items.Add(fi.Name)
            Next

        Catch
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If CheckBox1.Checked = False Then
            Exit Sub
        End If


        Try
            Dim di As New System.IO.DirectoryInfo("c:/Noten-Rechner Programm/Programme")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)

                If fi.Name = ListBox1.Text Then
                    Process.Start("c:/Noten-Rechner Programm/data.bat")
                    Process.Start(fi.FullName)
                End If
            Next

        Catch
        End Try

    End Sub

    Private Sub NameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ProgrammInfosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammInfosToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub NeuenServerErstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuenServerErstellenToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripComboBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim di As New System.IO.DirectoryInfo("c:/Noten-Rechner Programm/Programme")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)

                If fi.Name = ListBox1.Text Then
                    Process.Start("c:/Noten-Rechner Programm/data.bat")
                    Process.Start(fi.FullName)
                End If
            Next

        Catch
        End Try
    End Sub

    Private Sub AdminzugangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminzugangToolStripMenuItem.Click
        Adminzugang.Show()
    End Sub
End Class
