Imports System.IO
Imports System.Net.Mail

Public Class Benutzer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Benutzer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Bitte gieb einen Namen an")
            Exit Sub
        End If
        If Not TextBox2.Text Like "*@*" Or TextBox2.Text = "" Then
            MsgBox("Gieb eine gültige E-mail an!")
            Exit Sub

        End If
        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm/Benutzer") Then
            MkDir("C:/Noten-Rechner Programm/Benutzer")

        End If




        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Benutzer")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                If (fi.Name) = "" & TextBox1.Text & ".txt" Then
                    MsgBox("Der Benutzer wurde bereits erstellt!")
                    Exit Sub
                End If
            Next

        Catch
        End Try



















        If Not My.Computer.FileSystem.DirectoryExists("C:/Noten-Rechner Programm/Benutzer/" & TextBox1.Text & "") Then
            MkDir("C:/Noten-Rechner Programm/Benutzer/" & TextBox1.Text & "")

        End If

      
        Dim S As IO.StreamWriter = New IO.StreamWriter("C:/Noten-Rechner Programm/Benutzer/" & TextBox1.Text & "/" & TextBox1.Text & ".txt")

        S.WriteLine(TextBox1.Text)
        S.WriteLine(TextBox2.Text)
        S.Close()

        My.Settings.Benutzer = TextBox1.Text
      



        Dim Ip4 As String = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(0).ToString
        Dim Ip6 As String = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(1).ToString




        'E-Mail 1

        Try
            Dim Email As New MailMessage
            Email.From = New MailAddress("SidezockingLP.de@gmx.de")
            Email.To.Add("SidezockingLP@gmail.com")
            Email.Subject = ("Anmeldung bei Noten-Rechner-Programm")
            Email.Body = ("Eine neue Anmeldung wurde im Notenrechner Programm getätigt! Der nutzer meldete sich mit dem namen: " & TextBox1.Text & " und der e-mail: " & TextBox2.Text & " ein! IpPC:      IPv4: " & Ip4 & "      IpV6: " & Ip6 & "")

            Dim smtp As New SmtpClient("smtp.gmx.de")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("SidezockingLP.de@gmx.de", "derkleineprinz0802")
            smtp.EnableSsl = True
            smtp.Send(Email)

            MsgBox("Angaben wurden erfolgreich gespeichert und weitergeleitet")


        Catch ex As Exception
            MsgBox("Bei der Datenweiterleitung trat der Fehler '" & ex.Message & "' auf! Du kannst deinen neuen Benutzeraccount aber trotzdem nutzen!")


        End Try


        'E-Mail 2

        Try
            Dim Email As New MailMessage
            Email.From = New MailAddress("SidezockingLP.de@gmx.de")
            Email.To.Add(TextBox2.Text)
            Email.Subject = ("Excel Noten-Rechner Programm")
            Email.Body = ("Du hast dich erfolgreich mit dem Namen: " & TextBox1.Text & " und der e-mail: " & TextBox2.Text & " im Noten-Rechner-Programm angemeldet. Ich danke dir dass du dieses Programm verwendest!                                Bei Fragen/Anregungen/Fehler an SidezockingLP@gmail.com.                                        Diese E-Mail wurde automatisch versendet!")

            Dim smtp As New SmtpClient("smtp.gmx.de")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("SidezockingLP.de@gmx.de", "derkleineprinz0802")
            smtp.EnableSsl = True
            smtp.Send(Email)




        Catch ex As Exception
            MsgBox("Bei der Datenweiterleitung an deine E-Mail Adresse trat der Fehler '" & ex.Message & "' auf! Du kannst deinen neuen Benutzeraccount aber trotzdem nutzen!")


        End Try



        Me.Hide()
        MsgBox("Du wurdest erfolgreich als " & TextBox1.Text & " eingeloggt!")

        Form1.ToolStripComboBox1.Items.Clear()
        Try
            Dim di As New System.IO.DirectoryInfo("c:/Noten-Rechner Programm/Benutzer")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)

                Dim L() As String = IO.File.ReadAllLines(fi.FullName)
                Form1.ToolStripComboBox1.Items.Add(L(0))
            Next

        Catch
        End Try

        Form1.ListBox1.Items.Clear()
        Try
            Dim di As New System.IO.DirectoryInfo("C:/Noten-Rechner Programm/Programme/" & My.Settings.Benutzer & "")
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)


                Form1.ListBox1.Items.Add(fi.Name)
            Next

        Catch
        End Try

    End Sub
End Class