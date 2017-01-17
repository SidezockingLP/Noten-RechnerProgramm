Public Class Adminzugang

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "Jonas" Then
            MsgBox("Das Passwort ist nicht korrekt!!")
            Exit Sub
        End If

        Process.Start("https://github.com/SidezockingLP/Noten-RechnerProgramm")

    End Sub
End Class