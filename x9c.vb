Public Class Form1
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        ' Oh you're here, you find me XD'

        Dim user As String = "admin"
        Dim pass As String = "home@123"

        If UsernameTxt.Text = user And PasswordTxt.Text = pass Then
            'MsgBox("Username: " + user + & +"Password: " + pass)
            MsgBox("Username: " + user & vbNewLine & "Password: " + pass & vbNewLine + "Nice, well done XD.")
            MsgBox("Don't forget to take a note")
            MsgBox("To submit the flag click ok")
            Dim webAddress As String = "https://forms.gle/wPseLHdhKcFYthuG6"
            Process.Start(webAddress)
        Else
            MsgBox("Try again :(")
        End If

    End Sub
End Class
